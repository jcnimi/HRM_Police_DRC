Imports Emgu.CV.DepthAI
Imports Microsoft.Office.Interop

Public Class frmMapageChamp
    Public importSourceFilePath As String = ""
    Public seperator As String = ""
    Public sourceFormat As String = ""
    Public accessTableName As String = ""
    Public mappingSuccess As Boolean = False
    Private Sub saveMappingMemory()
        Dim dbFieldName As String = ""
        Dim fileFieldName As String = ""
        MappingList = New List(Of Mapping)()

        Try
            For Each Row As DataGridViewRow In DataGridView1.Rows
                dbFieldName = CStr(Row.Cells("db").Value)
                fileFieldName = CStr(Row.Cells("file").Value)
                If dbFieldName = "" Then 'to prevent adding a black line
                    Continue For
                End If
                MappingList.Add(New Mapping(dbFieldName, fileFieldName))
            Next
            mappingSuccess = True
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try

    End Sub
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        saveMappingMemory()
        Me.Close()
    End Sub

    Private Sub frmMapageChamp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileFieldList = New ArrayList()
        fileFieldList.Add("")
        'add datagridview combobox items
        Dim fileCol As DataGridViewComboBoxColumn = CType(DataGridView1.Columns.Item("file"), DataGridViewComboBoxColumn)
        'read the source file to get the colum name
        If sourceFormat = "Excel" Then
            Try
                Dim xlApp As Excel.Application = New Excel.Application
                Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Open(importSourceFilePath)
                Dim xlWorkSheet As Excel.Worksheet = CType(xlWorkBook.Worksheets("sheet1"), Excel.Worksheet)
                Dim Range As Excel.Range = xlWorkSheet.UsedRange

                For cCnt = 1 To Range.Columns.Count
                    'xlWorkSheet.Cells(1, k + 1)
                    Dim Obj As Excel.Range = CType(Range.Cells(1, cCnt), Excel.Range)
                    fileCol.Items.Add(Obj.Text)
                    fileFieldList.Add(Obj.Text)
                Next
            Catch ex As Exception
                MessageBox.Show("Erreur: " + ex.Message)
            End Try
        ElseIf sourceFormat = "CSV" Then
            Try
                Using fileReader As System.IO.StreamReader = New System.IO.StreamReader(importSourceFilePath)
                    Dim FileHeader As String = fileReader.ReadLine
                    Dim fileFields As String() = FileHeader.Split(seperator)
                    For i As Integer = 0 To fileFields.Count - 1
                        fileCol.Items.Add(fileFields(i))
                        fileFieldList.Add(fileFields(i))
                    Next
                End Using
            Catch ex As Exception
                MessageBox.Show("Erreur: " + ex.Message)
            End Try
        ElseIf sourceFormat = "Access" Then
            Try
                Try
                    Dim fields = GetAccessTableFieldList(accessTableName)
                    For Each item In fields
                        fileCol.Items.Add(item.ToString())
                        fileFieldList.Add(item.ToString())
                    Next
                    'fileFieldList = fields
                Catch ex As Exception
                    MessageBox.Show("Erreur: " + ex.Message)
                End Try
            Catch ex As Exception

            End Try
        End If

        'Load any existing mapping
        If MappingList IsNot Nothing Then
            For Each item As Mapping In MappingList
                Dim row As String() = New String() {$"{item.dbFieldName}", $"{item.fileFieldName}"}
                DataGridView1.Rows.Add(row)
            Next
        End If

    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        saveMappingMemory()
        Try
            With SaveFileDialog1
                .Filter = "Fichier mapping (.map)|*.map|All(*.*)|*.*"
                .Title = "Enregistrer le mapping"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using fileWritter As System.IO.StreamWriter = New System.IO.StreamWriter(SaveFileDialog1.FileName)
                        Dim FileContent As String = exportMapping()
                        fileWritter.Write(FileContent)
                        fileWritter.Flush()
                    End Using
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try

    End Sub

    Private Sub btnOuvrir_Click(sender As Object, e As EventArgs) Handles btnOuvrir.Click
        DataGridView1.Rows.Clear()
        Try
            With OpenFileDialog1
                .Filter = "Fichier mapping (.map)|*.map|All(*.*)|*.*"
                .Title = "Ouvrir un fichier mapping"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using fileReader As System.IO.StreamReader = New System.IO.StreamReader(OpenFileDialog1.FileName)
                        Dim FileContent As String = fileReader.ReadToEnd()
                        For Each item As String In FileContent.Split(vbCrLf)
                            If item <> "" Then
                                Dim items As String() = item.Split(",")
                                Dim row As String() = New String() {$"{items(1)}", $"{items(0)}"}
                                DataGridView1.Rows.Add(row)
                            End If
                        Next
                    End Using
                End If
            End With
            saveMappingMemory()
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub
    Private Function GetAccessTableFieldList(ByVal tableName As String) As ArrayList
        Dim odbcConnString As String = "DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" + importSourceFilePath + "; Uid = Admin; Pwd =;"
        Dim fieldList As ArrayList = New ArrayList()
        'Recupère la description des champs (type, etc...)
        Using connection As OdbcConnection = New OdbcConnection(odbcConnString)
            connection.Open()
            Dim adapter As OdbcDataAdapter = New OdbcDataAdapter()
            adapter.SelectCommand = New OdbcCommand("select * from [" + tableName + "] where 1=2", connection)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds, "export")
            Dim item As DataTable = ds.Tables(0)
            adapter.InsertCommand = New OdbcCommandBuilder(adapter).GetInsertCommand()
            fieldList = New ArrayList()
            For Each col As DataColumn In item.Columns
                fieldList.Add(col)
            Next
            ds.Dispose()
            adapter.Dispose()
            connection.Dispose()
        End Using
        Return fieldList
    End Function
End Class