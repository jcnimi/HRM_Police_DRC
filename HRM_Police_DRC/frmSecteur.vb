Public Class frmSecteur
    Private Sub frmSecteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Territoire
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_territoire as value, nom as display FROM [dbo].territoire"
        loadComboBox(cmbTerritoire, query)
    End Sub

    Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
        Dim desc As String = txtDesc.Text
        Dim territoire As String = cmbTerritoire.SelectedValue
        Dim query As String = $"
            INSERT INTO [dbo].[secteur]
           ([id_territoire]
           ,[nom]
           ,[date_creation]
           ,[cree_par])
            VALUES
           ({territoire}
           ,'{desc}'
           ,SYSDATETIME()
           ,1
            )
        "
        Try
            insertData(query)
            txtDesc.Text = ""
            cmbTerritoire.SelectedValue = 0

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class