Public Class frmListTable
    Public listData As List(Of String)
    Public selectedItem As String
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        selectedItem = ""
        Me.Close()
    End Sub

    Private Sub frmListTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboListTable.Items.AddRange(listData.ToArray())
    End Sub

    Private Sub cboListTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboListTable.SelectedIndexChanged
        btnValider.Enabled = True
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        selectedItem = cboListTable.Text
        Me.Close()
    End Sub
End Class