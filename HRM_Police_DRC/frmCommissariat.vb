Public Class frmCommissariat
    Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
        Dim desc As String = txtDesc.Text
        Dim province As String = cmbProvince.SelectedValue
        Dim adress As String = txtAdresse.Text
        Dim query As String = $"  
        INSERT INTO [dbo].[Commissariat]
           ([description]
           ,[province]
           ,[adresse]
           ,[date_creation]
           ,[cree_par])
        VALUES
           ('{desc}'
           ,{province}
           ,'{adress}'
           ,SYSDATETIME()
           ,1
        )
        "
        Try
            insertData(query)
            txtDesc.Text = ""
            cmbProvince.SelectedValue = 0
            txtAdresse.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub frmCommissariat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Province
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_province as value, nom as display FROM [dbo].province"
        loadComboBox(cmbProvince, query)
    End Sub
End Class