Public Class frmFonction
    Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
        Dim desc As String = txtDesc.Text
        Dim query As String = $"
            INSERT INTO [dbo].[fonction]
            ([description]
            ,[date_creation]
            ,[cree_par])
            VALUES
            ('{desc}'
            ,SYSDATETIME()
            ,{userId}
            )
        "
        Try
            insertData(query)
            txtDesc.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class