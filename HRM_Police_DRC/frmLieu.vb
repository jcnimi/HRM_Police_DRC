Public Class frmLieu
    Private Sub frmLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Province
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_province as value, nom as display FROM [dbo].province"
        loadComboBox(cmbProvince, query)
    End Sub

    Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
        Dim desc As String = txtDesc.Text
        Dim prov As String = cmbProvince.SelectedValue
        Dim query As String = $"
            INSERT INTO [dbo].[lieu]
           ([nom]
           ,[province]
           ,[date_creation]
           ,[cree_par])
            VALUES
           ('{desc}'
           ,{prov}
           ,SYSDATETIME()
           ,1
           )
        "
        Try
            insertData(query)
            txtDesc.Text = ""
            cmbProvince.SelectedValue = 0

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class