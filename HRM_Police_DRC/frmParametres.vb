Public Class frmParametres
    Private Sub picUsers_Click(sender As Object, e As EventArgs) Handles picUsers.Click
        Dim frm As New frmUserList()
        frm.ShowDialog()
    End Sub

    Private Sub picUsers_MouseHover(sender As Object, e As EventArgs) Handles picUsers.MouseHover
        picUsers.Image = My.Resources.users2
    End Sub

    Private Sub picUsers_MouseLeave(sender As Object, e As EventArgs) Handles picUsers.MouseLeave
        picUsers.Image = My.Resources.users1
    End Sub
End Class