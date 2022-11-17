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

    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub btnImporter_Click(sender As Object, e As EventArgs) Handles btnImporter.Click
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


    Private Function getSqltParameters(fileField As String, value As String) As SqlParameter
        Dim dbField As String = getMappingByFile(fileField)
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
                param.Value = value
            Else
                param.Value = System.DBNull.Value
            End If
        End If

        Return param
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
        Dim query As String
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Open(sourceFilePath)
        Dim xlWorkSheet As Excel.Worksheet = CType(xlWorkBook.Worksheets("sheet1"), Excel.Worksheet)
        Dim Range As Excel.Range = xlWorkSheet.UsedRange

        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0

        'get input
        sourceFileFormat = cboSourceFormat.Text
        sourceFilePath = txtSourceFilePath.Text
        imgFolder = txtImageFolder.Text
        fingerPrintFolder = txtLeftFingerPrintFolder.Text
        Try

            'read the source file to get the colum name

            For rCnt = 1 To Range.Rows.Count
                For cCnt = 1 To Range.Columns.Count
                    Obj = CType(Range.Cells(rCnt, cCnt), Excel.Range)
                    ' Obj.value now contains the value in the cell.. 
                Next
            Next

            For cCnt = 1 To Range.Columns.Count
                'xlWorkSheet.Cells(1, k + 1)
                Dim Obj As Excel.Range = CType(Range.Cells(1, cCnt), Excel.Range)
                fileCol.Items.Add(Obj.Text)
                fileFieldList.Add(Obj.Text)
            Next



        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub

End Class