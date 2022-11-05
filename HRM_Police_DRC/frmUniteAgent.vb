Public Class frmUniteAgent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
        Dim desc As String = txtDesc.Text
        Dim query As String = $"
            INSERT INTO [dbo].[unite]
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
            saveData(query)
            txtDesc.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class