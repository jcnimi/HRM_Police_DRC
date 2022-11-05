Public Class frmVillageorigine
    Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
        Dim desc As String = txtDesc.Text
        Dim secteur As String = cmbSecteur.SelectedValue
        Dim query As String = $"
            INSERT INTO [dbo].[village]
           ([description]
           ,[secteur]
           ,[date_creation]
           ,[cree_par])
            VALUES
           ('{desc}'
           ,{secteur}
           ,SYSDATETIME()
           ,{userId}
           )
        "
        Try
            saveData(query)
            txtDesc.Text = ""
            cmbSecteur.SelectedValue = 0

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub frmVillageorigine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Secteur
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_secteur as value, nom as display FROM [dbo].secteur"
        loadComboBox(cmbSecteur, query)
    End Sub
End Class