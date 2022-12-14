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
            select id_user, nom, username, password, status, date_debut, date_fin, locked, must_change_pwd, last_pwd_change_dt
            from users
            where username = '{username}'
        "
        Try
            Using reader As SqlDataReader = getData(query)
                If reader.HasRows Then
                    reader.Read()
                    userId = reader("id_user").ToString
                    userFullName = reader("nom").ToString

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
                If mustChangePwd Or (currentDate - lastPwdChangeDt).TotalDays >= 30 Then
                    MessageBox.Show("L'utilisateur dois changer de mot de passe")
                    Dim frmCP As New frmChangePwd()
                    frmCP.userName = username
                    frmCP.oldPassword = password
                    frmCP.ShowDialog()
                    If frmCP.clickedButton = "cancel" Then
                        Exit Sub
                    Else
                        txtpassword.Text = frmCP.newPassword
                    End If

                End If
                userName_ = username
                userPwd = password
                Me.Hide()
                Dim frmload As New frmLoadingData()
                frmload.ShowDialog()

                Dim frmM As New frmMain()
                frmM.ShowDialog()
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
        conn.Close()
        conn.Dispose()
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub

    Private Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        'obj.BackColor = Color.Cyan


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)


    End Sub
End Class