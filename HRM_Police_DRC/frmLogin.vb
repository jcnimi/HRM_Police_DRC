Public Class frmLogin

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picvalidate.Click
        'BCrypt.Net.BCrypt.HashPassword(
        Dim hashFromDb As String = ""
        Dim username As String = txtUsername.Text
        Dim password As String = txtpassword.Text
        Dim query As String = $"
            select username, password
            from users
            where username = '{username}'
        "
        Try
            Using reader As SqlDataReader = getData(query)
                If reader.HasRows Then
                    reader.Read()
                    hashFromDb = reader("password").ToString
                End If
            End Using
            Dim match As Boolean = BCrypt.Net.BCrypt.Verify(password, hashFromDb)
            If match Then
                Me.Close()
                Dim frm As New frmMain()
                frm.ShowDialog()
            Else
                MessageBox.Show("Nom d'utilisateur ou Mot de passe incorect")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur :" + ex.Message)
        End Try

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

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
            txtpassword.PasswordChar = ""
        Else
            txtpassword.UseSystemPasswordChar = True
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub picCancel_Click(sender As Object, e As EventArgs) Handles picCancel.Click
        Me.Close()
    End Sub
End Class