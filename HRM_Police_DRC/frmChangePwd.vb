Public Class frmChangePwd
    Public userName As String
    Public oldPassword As String
    Public clickedButton As String
    Public newPassword As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        clickedButton = "cancel"
        Me.Close()
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        newPassword = txtnewPwd.Text
        Dim newPasswordRepeat As String = txtNewPwdRepeat.Text

        If oldPassword <> txtOldPwd.Text Then
            MessageBox.Show("L'ancien mot de passe ne pas correct")
            Exit Sub
        End If

        If newPassword <> newPasswordRepeat Then
            MessageBox.Show("Nouveau et repeter ne sont pas egal")
            Exit Sub
        End If

        Dim query As String = $"
                UPDATE [dbo].[users]
                SET [password] = '{BCrypt.Net.BCrypt.HashPassword(newPassword)}'
                  ,[must_change_pwd] = 'False'
                  ,[last_pwd_change_dt] = SYSDATETIME()
                WHERE username = '{userName}'
            "
        Try
            saveData(query)
            MessageBox.Show("Mot de passe MIS à jour avec succes")
            clickedButton = "validate"
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur:", ex.Message)
        End Try
    End Sub
End Class