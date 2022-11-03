Imports System.Data
Imports System.Data.Sql
Imports System.Drawing


Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = GroupBox1.Width + 40
        Me.Height = 450
        'Me.StartPosition = FormStartPosition.CenterScreen
        Me.Left = 30

        'tooltip
        Dim tt As New ToolTip()
        tt.SetToolTip(picAddAgent, "Ajouter un nouvel agent")
        tt.SetToolTip(picExportAgent, "Exporter les données")
        tt.SetToolTip(picSettings, "Administration du système")

        Dim queryString = "SELECT top 20 [matricule] Matricule
        ,[nom] Nom
        ,[postnom] Postnom
        ,[prenom] Prenom 
        ,[sexe] Sexe
		,[etat_civil] ""Etat Civil""
        ,c.description as Grade
	    ,b.description as Fonction
	    ,[adresse] Adresse
        FROM [dbo].[agent] a
        join [dbo].[fonction] b on a.fonction = b.id_fonction
        join [dbo].[grade] c on a.grade = c.id_grade
        order by a.date_creation desc
        "

        Dim cmd As New SqlCommand(queryString, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles picAddAgent.MouseHover
        picAddAgent.Image = My.Resources.Screenshot_2
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles picAddAgent.MouseLeave
        picAddAgent.Image = My.Resources.Screenshot_1
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles picExportAgent.MouseHover
        picExportAgent.Image = My.Resources.export2
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles picExportAgent.MouseLeave
        picExportAgent.Image = My.Resources.export1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picAddAgent.Click
        Dim frm As New frmNewAgent
        frm.ShowDialog()
    End Sub



    Private Sub picSettings_Click(sender As Object, e As EventArgs) Handles picSettings.Click
        Dim frm As New frmParametres()
        frm.ShowDialog()
    End Sub

    Private Sub picSettings_MouseHover(sender As Object, e As EventArgs) Handles picSettings.MouseHover
        picSettings.Image = My.Resources.Settings2
    End Sub

    Private Sub picSettings_MouseLeave(sender As Object, e As EventArgs) Handles picSettings.MouseLeave
        picSettings.Image = My.Resources.Settings1
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        'search
    End Sub

    Private Sub picSearch_MouseHover(sender As Object, e As EventArgs) Handles picSearch.MouseHover
        '
        picSearch.Image = My.Resources.Serch2
    End Sub

    Private Sub picSearch_MouseLeave(sender As Object, e As EventArgs) Handles picSearch.MouseLeave
        '
        picSearch.Image = My.Resources.Serch1
    End Sub

    Private Sub picExportAgent_Click(sender As Object, e As EventArgs) Handles picExportAgent.Click
        Dim frm As New frmExport()
        frm.ShowDialog()
    End Sub
End Class
