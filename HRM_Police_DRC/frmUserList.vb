Public Class frmUserList
    Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim queryString = "
        SELECT a.[nom] Nom
	      ,a.[username] ""Nom utilisateur""
          ,a.[date_creation] ""Date Creation""
          ,a.[status] Statut
          ,a.[email] Mail
          ,b.group_name as Groupe
        FROM [dbo].[users] a
        join [dbo].[user_profile] b on a.groupe = b.group_id
        "

        Dim cmd As New SqlCommand(queryString, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgvUsers.DataSource = table
    End Sub
End Class