Public Class frmImportData
    Private Sub btnDataFile_Click(sender As Object, e As EventArgs) Handles btnDataFilePath.Click
        With OpenFileDialog1
            .Filter = "Excel (.xslx)|*.xlsx|CSV (.csv)|*.csv|PDF (.pdf)|*.pdf"
            .Title = "Ouvrir une fichier"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' export code here
            End If
        End With
    End Sub

    Private Sub btnTemplateFilePath_Click(sender As Object, e As EventArgs) Handles btnTemplateFilePath.Click
        With OpenFileDialog1
            .Filter = "Fichier JSON (.json)|*.json"
            .Title = "Ouvrir une fichier"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' export code here
            End If
        End With
    End Sub

    Private Sub frmImportData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTemplateFilePath.Text = Application.StartupPath + "\Import_template.json"
    End Sub
End Class