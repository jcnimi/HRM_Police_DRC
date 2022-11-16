Imports System.IO.Pipelines
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class frmImportData
    Private Sub btnDataFile_Click(sender As Object, e As EventArgs) Handles btnDataFilePath.Click
        With OpenFileDialog1
            .Filter = "Excel (.xslx)|*.xlsx|CSV (.csv)|*.csv|PDF (.pdf)|*.pdf"
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
        'get input
        Dim sourceFileFormat As String = cboSourceFormat.Text
        Dim sourceFilePath As String = txtSourceFilePath.Text
        Dim imgFolder As String = txtImageFolder.Text
        Dim signatureFolder As String = txtSignatureFolder.Text
        Dim leftFingerPrintFolder As String = txtLeftFingerPrintFolder.Text
        Dim rightFingerPrintFolder As String = txtRightFingerPrintFolder.Text
        Try
            'Get the header file

        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try


    End Sub

    Private Sub txtRightFingerPrintFolder_TextChanged(sender As Object, e As EventArgs) Handles txtRightFingerPrintFolder.TextChanged
        If cboSourceFormat.Text <> "" AndAlso txtSourceFilePath.Text <> "" _
           AndAlso txtImageFolder.Text <> "" AndAlso txtRightFingerPrintFolder.Text <> "" _
           AndAlso txtSignatureFolder.Text <> "" AndAlso txtLeftFingerPrintFolder.Text <> "" Then
            btnImporter.Enabled = True
        End If
    End Sub

    Private Sub btnImageFolder_Click(sender As Object, e As EventArgs) Handles btnImageFolder.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtImageFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnSignatureFolder_Click(sender As Object, e As EventArgs) Handles btnSignatureFolder.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtSignatureFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnLeftFingerPrintFolder_Click(sender As Object, e As EventArgs) Handles btnLeftFingerPrintFolder.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtLeftFingerPrintFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnRightFingerPrintFolder_Click(sender As Object, e As EventArgs) Handles btnRightFingerPrintFolder.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtRightFingerPrintFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class