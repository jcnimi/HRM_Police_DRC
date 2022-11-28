Imports System.IO.Pipelines
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Emgu.CV.Fuzzy.FuzzyInvoke
Imports Microsoft.Office.Interop
Imports Newtonsoft.Json.Linq
Imports SourceAFIS
Imports System.Threading

Public Class frmImportData
    Dim sourceFileFormat As String = ""
    Dim sourceFilePath As String = ""
    Dim imgFolder As String = ""
    Dim fingerPrintFolder As String = ""
    Dim separator As String = ""
    Dim accessTableName As String = ""
    Private Sub btnDataFile_Click(sender As Object, e As EventArgs) Handles btnDataFilePath.Click
        With OpenFileDialog1
            If cboSourceFormat.Text = "Excel" Then
                .Filter = "Excel (.xslx)|*.xlsx"
            ElseIf cboSourceFormat.Text = "Access" Then
                .Filter = "Access (*.accdb)|*.accdb"
            ElseIf cboSourceFormat.Text.Contains("CSV") Then
                .Filter = "CSV (*.csv)|*.csv"
            End If
            .Title = "Ouvrir une fichier"

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSourceFilePath.Text = OpenFileDialog1.FileName
            End If
        End With
    End Sub

    Private Sub frmImportData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cboSourceFormat.SelectedItem = "Excel"
        'cboSourceFormat.Enabled = False
        txtImageFolder.Text = Application.StartupPath
        txtLeftFingerPrintFolder.Text = Application.StartupPath
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub btnImporter_Click(sender As Object, e As EventArgs) Handles btnImporter.Click
        Dim msg As String = "Vous êtes sur le point d'importer les enregistrements dans la base de données, cliquez sur oui pour continuer et non pour annuler"
        If MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'get input
            sourceFileFormat = cboSourceFormat.Text
            sourceFilePath = txtSourceFilePath.Text
            imgFolder = txtImageFolder.Text
            fingerPrintFolder = txtLeftFingerPrintFolder.Text
            If sourceFileFormat = "CSV(Separateur Virgule)" Then
                separator = ","
            ElseIf sourceFileFormat = "CSV(Separateur Point Virgule)" Then
                separator = ";"
            ElseIf sourceFileFormat = "CSV(Separateur Tabulation)" Then
                separator = vbTab
            ElseIf sourceFileFormat = "CSV(Separateur Espace)" Then
                separator = " "
            End If
            If MappingList Is Nothing Then
                MessageBox.Show("Mapping enexistant, veuillez d'abord cliquer sur Mapping")
                Exit Sub
            End If
            If sourceFileFormat = "Excel" Then
                importExcel()
            ElseIf sourceFileFormat = "Access" Then
                importAccess()
            Else
                importCSV()
            End If
        End If
    End Sub

    Private Sub btnImageFolder_Click(sender As Object, e As EventArgs) Handles btnImageFolder.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtImageFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub



    Private Sub btnLeftFingerPrintFolder_Click(sender As Object, e As EventArgs) Handles btnLeftFingerPrintFolder.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtLeftFingerPrintFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnMapping_Click(sender As Object, e As EventArgs) Handles btnMapping.Click
        'get input
        sourceFileFormat = cboSourceFormat.Text
        sourceFilePath = txtSourceFilePath.Text
        imgFolder = txtImageFolder.Text
        fingerPrintFolder = txtLeftFingerPrintFolder.Text
        If sourceFileFormat = "CSV(Separateur Virgule)" Then
            separator = ","
        ElseIf sourceFileFormat = "CSV(Separateur Point Virgule)" Then
            separator = ";"
        ElseIf sourceFileFormat = "CSV(Separateur Tabulation)" Then
            separator = vbTab
        ElseIf sourceFileFormat = "CSV(Separateur Espace)" Then
            separator = " "
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New frmMapageChamp()
        frm.importSourceFilePath = txtSourceFilePath.Text
        frm.seperator = separator
        frm.sourceFormat = sourceFileFormat
        frm.accessTableName = accessTableName
        frm.ShowDialog()
        If frm.mappingSuccess Then
            btnImporter.Enabled = True
        End If
        Me.Cursor = Cursors.Default
    End Sub


    Private Function getTemplateSqltParameter(fileField As String, value As String) As SqlParameter
        Dim dbField As String = getDBFieldMappingByFileField(fileField)
        Dim templateField As String = ""
        Dim param As SqlParameter = Nothing
        Dim img As Image = Nothing
        Dim matcher As ImageMatcher = New ImageMatcher()
        If dbField = "" Then
            Return Nothing
        End If
        If dbField = "empreinte_gauche" Then
            templateField = "empreinte_gauche_template"
        ElseIf dbField = "empreinte_droite" Then
            templateField = "empreinte_droite_template"
        Else
            Return Nothing
        End If

        param = New SqlParameter($"@{templateField}", SqlDbType.VarBinary)
        Dim path As String = $"{imgFolder}\{value}"
        img = getImageFromFile(path)
        If img IsNot Nothing Then
            Dim encoded = matcher.encodeFingerPrintImage(img)
            Dim serial = SerialiseFingerPrintTemplate(matcher.getTemplate(encoded))
            param.Value = serial
        Else
            param.Value = System.DBNull.Value
        End If
        Return param
    End Function


    Private Function getSqltParameter(fileField As String, value As String) As SqlParameter
        Dim dbField As String = getDBFieldMappingByFileField(fileField)
        If dbField = "" Then
            Return Nothing
        End If
        Dim param As SqlParameter
        Dim imgFields As List(Of String)
        imgFields = New List(Of String)({"photo", "signature", "empreinte_gauche", "empreinte_droite"})
        If imgFields.Contains(dbField) Then
            param = New SqlParameter($"@{dbField}", SqlDbType.Image)
            If value <> "" Then
                Dim path As String = $"{imgFolder}\{value}"
                param.Value = getMemoryStream(getImageFromFile(path))
            Else
                param.Value = System.DBNull.Value
            End If
        Else
            param = New SqlParameter($"@{dbField}", SqlDbType.NVarChar)
            If value <> "" Then
                'particular case for lieu_naissance, territoire_origine, secteur_origine, province_origine, 
                'fonction, unite_agent, regroupement, province_recrutement, commissariat_recrutement
                Dim foreighKeyList As List(Of String) = New List(Of String)({"lieu_naissance", "territoire_origine" _
                    , "secteur_origine", "province_origine", "fonction", "unite_agent", "regroupement" _
                    , "province_recrutement", "commissariat_recrutement", "grade"})
                If foreighKeyList.Contains(dbField) Then

                    Dim foreignKey As String = getForeignKeyValue(dbField, value)
                    If foreignKey <> "" Then
                        param.Value = foreignKey
                    Else
                        param.Value = System.DBNull.Value
                    End If

                Else
                    param.Value = preProcessData(dbField, value)
                End If

            Else
                param.Value = System.DBNull.Value
            End If
        End If

        Return param
    End Function

    Public Function getForeignKeyValue(ByVal field As String, ByVal value As String) As String
        Dim query As String = ""
        Dim returnValue As String = ""
        If field = "lieu_naissance" Then
            query = $"select top(1) id_lieu id
                    from lieu
                    where nom = '{value}'
                    "
        ElseIf field = "territoire_origine" Then
            query = $"select top(1) id_territoire id
                    from territoire
                    where nom = '{value}'
                    "
        ElseIf field = "secteur_origine" Then
            query = $"select top(1) id_secteur id
                    from secteur
                    where nom = '{value}'
                    "
        ElseIf field = "province_origine" Then
            query = $"select top(1) id_province id
                    from province
                    where nom = '{value}'
                    "
        ElseIf field = "fonction" Then
            query = $"select top(1) id_fonction id
                    from fonction
                    where description = '{value}'
                    "
        ElseIf field = "unite_agent" Then
            query = $"select top(1) id_unite id
                    from unite
                    where description = '{value}'
                    "
        ElseIf field = "regroupement" Then
            query = $"select top(1) id_village id
                    from village
                    where description = '{value}'
                    "
        ElseIf field = "province_recrutement" Then
            query = $"select top(1) id_province id
                    from province
                    where nom = '{value}'
                    "
        ElseIf field = "commissariat_recrutement" Then
            query = $"Select Top(1) id_commissariat id
                    From commissariat
                    Where description = '{value}'
                    "
        ElseIf field = "grade" Then
            query = $"Select Top(1) id_grade id
                    From grade
                    Where description = '{value}'
                    "
        End If
        Using queryResult As SqlDataReader = getData(query)
            If queryResult.HasRows() Then
                queryResult.Read()
                returnValue = queryResult("id").ToString()
            End If
        End Using
        If returnValue = "" Then 'data not in the db, add it
            Dim param As SqlParameter
            Dim dbParam As New List(Of SqlParameter)
            param = New SqlParameter("@description", SqlDbType.NVarChar)
            param.Value = value
            dbParam.Add(param)
            param = New SqlParameter("@created_by", SqlDbType.BigInt)
            param.Value = userId
            dbParam.Add(param)
            Select Case field
                Case "commissariat_recrutement"
                    returnValue = CStr(saveDataSPV("sp_insert_commissariat", dbParam))
                Case "lieu_naissance"
                    returnValue = CStr(saveDataSPV("sp_insert_lieu", dbParam))
                Case "fonction"
                    returnValue = CStr(saveDataSPV("sp_insert_fonction", dbParam))
                Case "grade"
                    returnValue = CStr(saveDataSPV("sp_insert_grade", dbParam))
            End Select
        End If

        Return returnValue
    End Function

    Private Function getMemoryStream(ByRef img As Image) As Byte()
        Dim memData As Byte()
        If img IsNot Nothing Then
            Using memoStrem As IO.MemoryStream = New IO.MemoryStream()
                img.Save(memoStrem, System.Drawing.Imaging.ImageFormat.Png)
                memData = memoStrem.ToArray()
            End Using
        Else
            memData = Nothing
        End If
        Return memData
    End Function

    Private Function getImageFromFile(ByVal path As String) As Image
        Dim img As Image = Nothing
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.WindowStyle = ProcessWindowStyle.Hidden
        pi.CreateNoWindow = True
        pi.UseShellExecute = False
        Try
            If path <> "" Then
                If System.IO.File.Exists(path) Then
                    'wsq particular case
                    If System.IO.Path.GetExtension(path) = ".WSQ" Then
                        If Not System.IO.File.Exists(path.Replace("WSQ", "jpg")) Then
                            Dim scriptPath As String = Application.StartupPath + "Script\wsqTojpg.py"
                            'convert it to jpg with a python script
                            pi.Arguments = $"/C C:\ProgramData\Anaconda3\Scripts\activate.bat && pythonw {scriptPath} {path}"
                            pi.FileName = "cmd.exe"
                            Dim proc As Process = Process.Start(pi)
                            proc.WaitForExit()
                        End If
                        Dim newPath As String = path.Replace("WSQ", "jpg")
                        img = Image.FromFile(newPath)
                        'IO.File.Delete(newPath)

                    Else
                            img = Image.FromFile(path)
                    End If
                Else
                    img = Nothing
                End If
            Else
                img = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        Return img
    End Function

    Private Sub importExcel()
        Dim paramList As List(Of SqlParameter)
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Open(sourceFilePath)
        Dim xlWorkSheet As Excel.Worksheet = CType(xlWorkBook.Worksheets("sheet1"), Excel.Worksheet)
        Dim Range As Excel.Range = xlWorkSheet.UsedRange

        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 2
        ProgressBar1.Maximum = Range.Rows.Count
        Try
            For rCnt = 2 To Range.Rows.Count
                paramList = New List(Of SqlParameter)()
                For cCnt = 1 To Range.Columns.Count
                    Dim data As String = CType(Range.Cells(rCnt, cCnt), Excel.Range).Text
                    'check if matricule is blank
                    If getDBFieldMappingByFileField(fileFieldList(cCnt)) = "matricule" And data = "" Then
                        'matricule vide, donc passe à l'iteration suivante
                        Continue For
                    End If
                    Dim param As SqlParameter = getSqltParameter(fileFieldList(cCnt), data)
                    If param IsNot Nothing Then
                        paramList.Add(param)
                        'add template in case of fingerprint
                        Dim param2 As SqlParameter = getTemplateSqltParameter(fileFieldList(cCnt), data)
                        If param2 IsNot Nothing Then
                            paramList.Add(param2)
                        End If
                    End If
                Next
                saveDataSP("[sp_InsertAgent]", paramList)
                ProgressBar1.Value = rCnt
                Me.Text = $"Importation des données - [{Math.Round((rCnt / Range.Rows.Count) * 100, 2)} %]"
                Application.DoEvents()
            Next
            Me.Text = "Importation des données - [100 %]"
            MessageBox.Show("Importation des données reussies")

            xlWorkBook.Close()
            xlApp.Quit()

            xlWorkSheet = Nothing
            xlWorkBook = Nothing
            xlApp = Nothing
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub

    Private Sub importCSV()
        Dim paramList As List(Of SqlParameter)
        Dim FileContent() As String

        Using fileReader As System.IO.StreamReader = New System.IO.StreamReader(sourceFilePath)
            FileContent = fileReader.ReadToEnd().Split(vbCrLf)
        End Using

        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 1
        ProgressBar1.Maximum = FileContent.Count
        Try
            For rCnt As Integer = 1 To FileContent.Count - 1
                paramList = New List(Of SqlParameter)()
                Dim fileRow As String() = FileContent(rCnt).Split(separator)
                For cCnt As Integer = 0 To fileRow.Count - 1
                    Dim data As String = fileRow(cCnt)
                    'check if matricule is blank
                    If getDBFieldMappingByFileField(fileFieldList(cCnt + 1)) = "matricule" And data = "" Then
                        'matricule vide, donc passe à l'iteration suivante
                        Continue For
                    End If
                    Dim param As SqlParameter = getSqltParameter(fileFieldList(cCnt + 1), data)
                    If param IsNot Nothing Then
                        paramList.Add(param)
                        'add template in case of fingerprint
                        Dim param2 As SqlParameter = getTemplateSqltParameter(fileFieldList(cCnt + 1), data)
                        If param2 IsNot Nothing Then
                            paramList.Add(param2)
                        End If
                    End If
                Next
                saveDataSP("[sp_InsertAgent]", paramList)
                ProgressBar1.Value = rCnt
                Me.Text = $"Importation des données - [{Math.Round((rCnt / FileContent.Count) * 100, 2)} %]"
                Application.DoEvents()
            Next
            Me.Text = "Importation des données - [100 %]"
            MessageBox.Show("Importation des données reussies")
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub

    Private Sub importAccess()
        Dim paramList As List(Of SqlParameter)
        Try
            Dim odbcConnString = "DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" + sourceFilePath + "; Uid = Admin; Pwd =;"
            Dim connAccess As OdbcConnection = New OdbcConnection(odbcConnString)
            connAccess.Open()

            Dim table As DataTable = connAccess.GetSchema("tables")
            connAccess.Close()

            Dim listTable As List(Of String) = New List(Of String)()
            For Each row As DataRow In table.Rows
                Dim table_type As String = row("TABLE_TYPE").ToString()
                Dim table_name As String = row("TABLE_NAME").ToString()
                If table_type = "TABLE" Then
                    listTable.Add(table_name)
                End If
            Next

            'get the selection from the user
            Dim frm As New frmListTable()
            frm.listData = listTable
            frm.ShowDialog()
            Dim selectedTable As String = frm.selectedItem
            Dim queryString As String = $"select * from [{selectedTable}]"
            table = New DataTable()
            Dim cmd As New OdbcCommand(queryString, connAccess)
            Dim adapter As New OdbcDataAdapter(cmd)
            adapter.Fill(table)
            adapter.Dispose()
            cmd.Dispose()
            connAccess.Dispose()

            ProgressBar1.Visible = True
            ProgressBar1.Minimum = 1
            ProgressBar1.Maximum = table.Rows.Count

            For rCnt = 0 To table.Rows.Count - 1
                paramList = New List(Of SqlParameter)()
                Dim dr As DataRow = table.Rows.Item(rCnt)
                For cCnt = 0 To dr.ItemArray.Count - 1
                    Dim data As String = dr.ItemArray(cCnt).ToString
                    'check if matricule is blank
                    If getDBFieldMappingByFileField(fileFieldList(cCnt + 1)) = "matricule" And data = "" Then
                        'matricule vide, donc passe à l'iteration suivante
                        Continue For
                    End If
                    Dim param As SqlParameter = getSqltParameter(fileFieldList(cCnt + 1), data)
                    If param IsNot Nothing Then
                        paramList.Add(param)
                        'add template in case of fingerprint
                        Dim param2 As SqlParameter = getTemplateSqltParameter(fileFieldList(cCnt + 1), data)
                        If param2 IsNot Nothing Then
                            paramList.Add(param2)
                        End If
                    End If
                Next
                saveDataSP("[sp_InsertAgent]", paramList)
                ProgressBar1.Value = rCnt + 1
                Me.Text = $"Importation des données - [{Math.Round((rCnt / table.Rows.Count) * 100, 2)} %]"
                Application.DoEvents()
            Next
            Me.Text = "Importation des données - [100 %]"
            MessageBox.Show("Importation des données reussies")
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub


    Private Sub txtLeftFingerPrintFolder_TextChanged(sender As Object, e As EventArgs) Handles txtLeftFingerPrintFolder.TextChanged
        If cboSourceFormat.Text <> "" AndAlso txtSourceFilePath.Text <> "" AndAlso
                txtImageFolder.Text <> "" AndAlso txtLeftFingerPrintFolder.Text <> "" Then
            'btnImporter.Enabled = True
            'btnMapping.Enabled = True
            btnDataPreview.Enabled = True
        End If
    End Sub

    Private Sub txtSourceFilePath_TextChanged(sender As Object, e As EventArgs) Handles txtSourceFilePath.TextChanged
        If cboSourceFormat.Text <> "" AndAlso txtSourceFilePath.Text <> "" AndAlso
                txtImageFolder.Text <> "" AndAlso txtLeftFingerPrintFolder.Text <> "" Then
            'btnImporter.Enabled = True
            'btnMapping.Enabled = True
            btnDataPreview.Enabled = True
        End If
    End Sub

    Private Sub btnDataPreview_Click(sender As Object, e As EventArgs) Handles btnDataPreview.Click
        'get input
        sourceFileFormat = cboSourceFormat.Text
        sourceFilePath = txtSourceFilePath.Text
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New frmDataPreview()
        frm.srcFileFormat = sourceFileFormat
        frm.srcFileName = sourceFilePath
        frm.ShowDialog()
        accessTableName = frm.selectedTable
        If frm.previewSuccess Then
            btnMapping.Enabled = True
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Function preProcessData(ByVal fieldName As String, ByVal fieldValue As String) As String
        Dim returnValue As String = ""
        Dim query As String = ""
        Select Case fieldName
            Case "sexe"
                If fieldValue.ToLower() = "f" OrElse fieldValue.ToLower() = "feminin" Then
                    returnValue = "Femme"
                ElseIf fieldValue.ToLower() = "m" OrElse fieldValue.ToLower = "masculin" Then
                    returnValue = "Homme"
                Else
                    returnValue = ""
                End If
            Case Else
                returnValue = fieldValue
        End Select

        Return returnValue
    End Function
End Class