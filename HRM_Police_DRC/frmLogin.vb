Public Class frmLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picvalidate.Click
        Me.Close()
        Dim frm As New frmMain()
        frm.ShowDialog()
    End Sub

    Private Sub picvalidate_MouseHover(sender As Object, e As EventArgs) Handles picvalidate.MouseHover
        picvalidate.Image = My.Resources.validate2

    End Sub

    Private Sub picvalidate_MouseLeave(sender As Object, e As EventArgs) Handles picvalidate.MouseLeave
        picvalidate.Image = My.Resources.validate
    End Sub

    Private Sub picCancel_MouseHover(sender As Object, e As EventArgs) Handles picCancel.MouseHover
        picCancel.Image = My.Resources.Annuler2
    End Sub

    Private Sub picCancel_MouseLeave(sender As Object, e As EventArgs) Handles picCancel.MouseLeave
        picCancel.Image = My.Resources.Annuler
    End Sub
End Class