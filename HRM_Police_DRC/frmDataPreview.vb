Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Emgu.Util.Platform
Imports Microsoft.Office.Interop

Public Class frmDataPreview
    Public srcFileName As String = ""
    Public srcFileFormat As String = ""
    Public selectedTable As String = ""
    Private separator As String = ""
    Public previewSuccess As Boolean = False
    Private Sub frmDataPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If srcFileFormat = "Access" Then
            loadAccess()
        ElseIf srcFileFormat = "Excel" Then
            loadExcel()
        ElseIf srcFileFormat.Contains("CSV") Then
            If srcFileFormat = "CSV(Separateur Virgule)" Then
                separator = ","
            ElseIf srcFileFormat = "CSV(Separateur Point Virgule)" Then
                separator = ";"
            ElseIf srcFileFormat = "CSV(Separateur Tabulation)" Then
                separator = vbTab
            ElseIf srcFileFormat = "CSV(Separateur Espace)" Then
                separator = " "
            End If
            loadCSV(separator)
        End If
    End Sub
    Private Sub loadExcel()
        'Header
        Try
            Dim xlApp As Excel.Application = New Excel.Application
            Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Open(srcFileName)
            Dim xlWorkSheet As Excel.Worksheet = CType(xlWorkBook.Worksheets("sheet1"), Excel.Worksheet)
            Dim Range As Excel.Range = xlWorkSheet.UsedRange
            DataGridView1.ColumnCount = Range.Columns.Count

            For cCnt = 1 To Range.Columns.Count
                Dim Obj As Excel.Range = CType(Range.Cells(1, cCnt), Excel.Range)
                DataGridView1.Columns(cCnt - 1).Name = Obj.Text
            Next
            'Data

            For rCnt = 2 To Range.Rows.Count
                Dim row As DataGridViewRow = CType(DataGridView1.Rows(0).Clone(), DataGridViewRow)
                For cCnt = 1 To Range.Columns.Count
                    Dim data As String = CType(Range.Cells(rCnt, cCnt), Excel.Range).Text
                    row.Cells(cCnt - 1).Value = data
                Next
                DataGridView1.Rows.Add(row)
            Next

            xlWorkBook.Close()
            xlApp.Quit()

            xlWorkSheet = Nothing
            xlWorkBook = Nothing
            xlApp = Nothing
            previewSuccess = True
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub
    Private Sub loadCSV(ByVal sep As String)
        Dim FileContent() As String
        Try
            Using fileReader As System.IO.StreamReader = New System.IO.StreamReader(srcFileName)
                Dim FileHeader As String = fileReader.ReadLine
                Dim fileFields As String() = FileHeader.Split(separator)
                DataGridView1.ColumnCount = fileFields.Count
                For i As Integer = 0 To fileFields.Count - 1
                    DataGridView1.Columns(i).Name = fileFields(i)
                Next
            End Using

            Using fileReader As System.IO.StreamReader = New System.IO.StreamReader(srcFileName)
                FileContent = fileReader.ReadToEnd().Split(vbCrLf)
            End Using


            For rCnt As Integer = 1 To FileContent.Count - 1
                Dim row As DataGridViewRow = CType(DataGridView1.Rows(0).Clone(), DataGridViewRow)
                Dim fileRow As String() = FileContent(rCnt).Split(separator)
                For cCnt As Integer = 0 To fileRow.Count - 1
                    Dim data As String = fileRow(cCnt)
                    row.Cells(cCnt).Value = data
                Next
                DataGridView1.Rows.Add(row)
            Next
            previewSuccess = True
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub
    Private Sub loadAccess()
        Try
            'get the list of table in access
            Dim odbcConnString = "DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" + srcFileName + "; Uid = Admin; Pwd =;"
            Dim connAccess As OdbcConnection = New OdbcConnection(odbcConnString)
            connAccess.Open()

            Dim table As DataTable = connAccess.GetSchema("tables")
            connAccess.Close()

            'DataGridView1.DataSource = dt
            Dim listTable As List(Of String) = New List(Of String)()
            For Each row As DataRow In table.Rows
                Dim table_type As String = row("TABLE_TYPE").ToString()
                Dim table_name As String = row("TABLE_NAME").ToString()
                If table_type = "TABLE" Then
                    listTable.Add(table_name)
                End If
            Next

            'get the table selection from the user
            Dim frm As New frmListTable()
            frm.listData = listTable
            frm.ShowDialog()
            selectedTable = frm.selectedItem
            If selectedTable = "" Then
                Exit Sub
            End If
            Dim queryString As String = $"select * from [{selectedTable}]"
            table = New DataTable()
            Dim cmd As New OdbcCommand(queryString, connAccess)
            Dim adapter As New OdbcDataAdapter(cmd)
            adapter.Fill(table)
            DataGridView1.DataSource = table
            previewSuccess = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class