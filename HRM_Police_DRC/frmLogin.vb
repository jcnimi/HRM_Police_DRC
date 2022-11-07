Public Class frmLogin

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picvalidate.Click
        'BCrypt.Net.BCrypt.HashPassword(
        Dim hashFromDb As String = ""
        Dim username As String = txtUsername.Text
        Dim password As String = txtpassword.Text
        Dim currentDate As Date = Date.Now()
        Dim startDT As Date
        Dim endDT As Date
        Dim mustChangePwd As Boolean
        Dim lastPwdChangeDt As Date
        Dim locked As Boolean
        Dim status As String
        Dim query As String = $"
            select username, password, status, date_debut, date_fin, locked, must_change_pwd, last_pwd_change_dt
            from users
            where username = '{username}'
        "
        Try
            Using reader As SqlDataReader = getData(query)
                If reader.HasRows Then
                    reader.Read()
                    hashFromDb = reader("password").ToString
                    If Not DateTime.TryParse(reader("date_debut").ToString, startDT) Then
                        startDT = Nothing
                    End If
                    If Not DateTime.TryParse(reader("date_fin").ToString, endDT) Then
                        endDT = Nothing
                    End If
                    locked = reader("locked")
                    mustChangePwd = reader("must_change_pwd")
                    If Not DateTime.TryParse(reader("last_pwd_change_dt").ToString, lastPwdChangeDt) Then
                        lastPwdChangeDt = Nothing
                    End If
                    status = reader("status").ToString
                End If
            End Using
            Dim match As Boolean = BCrypt.Net.BCrypt.Verify(password, hashFromDb)
            If match Then
                If startDT > currentDate Then
                    MessageBox.Show("Date de debut dans le futur, veuillez contacter l'administrateur")
                    Exit Sub
                End If
                If endDT < currentDate Then
                    MessageBox.Show("Nom d'utilisateur expiré")
                    Exit Sub
                End If
                If status = "Inactif" Then
                    MessageBox.Show("Utilisateur inactif")
                    Exit Sub
                End If
                If locked Then
                    MessageBox.Show("Utilisateur verouillé")
                    Exit Sub
                End If
                If mustChangePwd Then
                    '
                    MessageBox.Show("L'utilisateur dois changer de mot de passe")

                    'show the change pwd dialog
                    Exit Sub
                End If
                If (currentDate - lastPwdChangeDt).TotalDays >= 30 Then
                    MessageBox.Show("Mot de passe expiré, L'utilisateur dois changer de mot de passe")

                    'show dialog

                    Exit Sub
                End If
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