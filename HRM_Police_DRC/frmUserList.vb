Public Class frmUserList
    Dim selectedRow As DataGridViewRow
    Dim userName As String
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

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim frm As New frmUser()
        frm.isUpdating = False
        frm.ShowDialog()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        userName = CStr(selectedRow.Cells("Nom utilisateur").Value)
        Dim frm As New frmUser()
        frm.isUpdating = True
        frm.userName = userName
        frm.ShowDialog()
    End Sub



    Private Sub dgvUsers_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvUsers.RowStateChanged
        If e.StateChanged = DataGridViewElementStates.Selected Then
            btnModifier.Enabled = True
        Else
            btnModifier.Enabled = False
        End If
    End Sub

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        If dgvUsers.SelectedRows.Count > 0 Then
            selectedRow = dgvUsers.SelectedRows.Item(0)
        End If
    End Sub

End Class