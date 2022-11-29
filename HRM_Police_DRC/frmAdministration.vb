Public Class frmAdministration
    Private Sub picUsers_Click(sender As Object, e As EventArgs) Handles picUsers.Click
        Dim tt As New ToolTip()
        tt.SetToolTip(picUsers, "Gestion des utilisateurs")
        tt.SetToolTip(picAuthorite, "Gestion des authorités")

        Dim frm As New frmUserList()
        frm.ShowDialog()
    End Sub

    Private Sub picUsers_MouseHover(sender As Object, e As EventArgs) Handles picUsers.MouseHover
        picUsers.Image = My.Resources.users2
    End Sub

    Private Sub picUsers_MouseLeave(sender As Object, e As EventArgs) Handles picUsers.MouseLeave
        picUsers.Image = My.Resources.users1
    End Sub

    Private Sub picAuthorite_MouseHover(sender As Object, e As EventArgs) Handles picAuthorite.MouseHover
        picAuthorite.Image = My.Resources.autorite2
    End Sub

    Private Sub picAuthorite_MouseLeave(sender As Object, e As EventArgs) Handles picAuthorite.MouseLeave
        picAuthorite.Image = My.Resources.authorite1
    End Sub

    Private Sub picAuthorite_Click(sender As Object, e As EventArgs) Handles picAuthorite.Click
        Dim frm As New frmAutorite()
        frm.ShowDialog()
    End Sub
End Class