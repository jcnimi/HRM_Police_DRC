Public Class frmUser
    Public userName As String
    Public isUpdating As Boolean = False
    Dim query As String
    Dim dtDateDebut As String = ""
    Dim dtDateExpiration As String = ""
    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        Me.Close()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load group combo box
        query = "Select 0 value, 'Select' display union  SELECT [group_id] as value, [group_name] as display FROM [dbo].[user_profile]"
        loadComboBox(cboGroup, query)

        If isUpdating = True Then
            'load the data from the database
            query = $"
                select [nom]
                       ,[sexe]
                       ,[date_creation]
                       ,[cree_par]
                       ,[status]
                       ,[date_debut]
                       ,[date_fin]
                       ,[username]
                       ,[locked]
                       ,[email]
                       ,[groupe]
                       ,[password]
                from [dbo].[users]
                where username = '{userName}'
            "
            Using reader As SqlDataReader = getData(query)
                If reader.HasRows Then
                    reader.Read()
                    txtNom.Text = reader("nom").ToString
                    txtMail.Text = reader("email").ToString
                    txtUser.Text = userName
                    txtpassword.Text = reader("password").ToString
                    cboSexe.Text = reader("sexe").ToString
                    cboStatus.Text = reader("status").ToString

                    dtDateDebut = reader("date_debut").ToString
                    If IsDate(dtDateDebut) Then
                        dtpDateDebut.Value = dtDateDebut
                    End If

                    dtDateExpiration = reader("date_fin").ToString
                    If IsDate(dtDateExpiration) Then
                        dtpDateExpiration.Value = dtDateExpiration
                    End If

                    chkLocked.Checked = reader("locked")
                    cboGroup.SelectedValue = reader("groupe")
                Else
                    MessageBox.Show("Erreur en tentant d'inserer les enfants ")
                    Exit Sub
                End If
            End Using
        End If
    End Sub

    Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
        Dim password = BCrypt.Net.BCrypt.HashPassword(txtpassword.Text)
        If isUpdating = False Then
            query = $"
            INSERT INTO [dbo].[users]
                       ([nom]
                       ,[sexe]
                       ,[date_creation]
                       ,[cree_par]
                       ,[status]
                       ,[date_debut]
                       ,[date_fin]
                       ,[username]
                       ,[locked]
                       ,[email]
                       ,[groupe]
                       ,[password])
                 VALUES
                       ('{txtNom.Text}'
                       ,'{cboSexe.Text}'
                       ,SYSDATETIME()
                       ,{userId}
                       ,'{cboStatus.Text}'
                       ,'{dtDateDebut}'
                       ,'{dtDateExpiration}'
                       ,'{txtUser.Text}'
                       ,'{chkLocked.Checked}'
                       ,'{txtMail.Text}'
                       ,'{cboGroup.SelectedValue}'
                       ,'{password}')
             "
        Else
            query = $"

            "
        End If
        Try
            saveData(query)
            MessageBox.Show("User ajouté avec succes")
        Catch ex As Exception
            MessageBox.Show("Erreur:", ex.Message)
        End Try
    End Sub

    Private Sub dtpDateDebut_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateDebut.ValueChanged
        dtDateDebut = dtpDateDebut.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateExpiration.ValueChanged
        dtDateExpiration = dtpDateExpiration.Value.ToString("MM/dd/yyyy")
    End Sub
End Class