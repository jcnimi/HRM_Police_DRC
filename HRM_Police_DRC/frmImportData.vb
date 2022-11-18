Imports System.IO.Pipelines
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Emgu.CV.Fuzzy.FuzzyInvoke
Imports Microsoft.Office.Interop
Imports Newtonsoft.Json.Linq

Public Class frmImportData
    Dim sourceFileFormat As String = ""
    Dim sourceFilePath As String = ""
    Dim imgFolder As String = ""
    Dim fingerPrintFolder As String = ""
    Private Sub btnDataFile_Click(sender As Object, e As EventArgs) Handles btnDataFilePath.Click
        With OpenFileDialog1
            .Filter = "Excel (.xslx)|*.xlsx|CSV (.csv)|*.csv"
            .Title = "Ouvrir une fichier"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSourceFilePath.Text = OpenFileDialog1.FileName
            End If
        End With
    End Sub

    Private Sub frmImportData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSourceFormat.SelectedItem = "Excel"
        cboSourceFormat.Enabled = False
        txtImageFolder.Text = Application.StartupPath
        txtLeftFingerPrintFolder.Text = Application.StartupPath
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub btnImporter_Click(sender As Object, e As EventArgs) Handles btnImporter.Click
        'get input
        sourceFileFormat = cboSourceFormat.Text
        sourceFilePath = txtSourceFilePath.Text
        imgFolder = txtImageFolder.Text
        fingerPrintFolder = txtLeftFingerPrintFolder.Text
        If MappingList Is Nothing Then
            MessageBox.Show("Mapping enexistant, veuillez d'abord cliquer sur Mapping")
            Exit Sub
        End If
        If sourceFileFormat = "Excel" Then
            importExcel()
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
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New frmMapageChamp()
        frm.importSourceFilePath = txtSourceFilePath.Text
        frm.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub


    Private Function getSqltParameter(fileField As String, value As String) As SqlParameter
        Dim dbField As String = getDBFieldMappingByFileField(fileField)
        If dbField = "" Then
            Return Nothing
        End If
        Dim param As SqlParameter
        Dim imgFields As List(Of String)
        imgFields = New List(Of String)({"photo", "signature", "empreinte_gauche", "empreinte_droite"})
        If imgFields.Contains(fileField) Then
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
                    param.Value = value
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
        Try
            If path <> "" Then
                If System.IO.File.Exists(path) Then
                    img = Image.FromFile(path)
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
                    Dim Obj As Excel.Range = CType(Range.Cells(rCnt, cCnt), Excel.Range)
                    Dim param As SqlParameter = getSqltParameter(fileFieldList(cCnt), Obj.Text)
                    If param IsNot Nothing Then
                        paramList.Add(param)
                    End If
                Next
                saveDataSP("[sp_InsertAgent]", paramList)
                ProgressBar1.Value = rCnt
                Me.Text = $"Importation des données - [{Math.Round((rCnt / Range.Rows.Count) * 100, 2)} %]"
                Application.DoEvents()
            Next
            MessageBox.Show("Importation des données reussies")
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub

    Private Sub txtLeftFingerPrintFolder_TextChanged(sender As Object, e As EventArgs) Handles txtLeftFingerPrintFolder.TextChanged
        If cboSourceFormat.Text <> "" AndAlso txtSourceFilePath.Text <> "" AndAlso
                txtImageFolder.Text <> "" AndAlso txtLeftFingerPrintFolder.Text <> "" Then
            btnImporter.Enabled = True
            btnMapping.Enabled = True
        End If
    End Sub

    Private Sub txtSourceFilePath_TextChanged(sender As Object, e As EventArgs) Handles txtSourceFilePath.TextChanged
        If cboSourceFormat.Text <> "" AndAlso txtSourceFilePath.Text <> "" AndAlso
                txtImageFolder.Text <> "" AndAlso txtLeftFingerPrintFolder.Text <> "" Then
            btnImporter.Enabled = True
            btnMapping.Enabled = True
        End If
    End Sub
End Class