Imports System.Data
Imports System.Data.Sql
Imports System.Drawing
Imports Emgu.CV.Fuzzy.FuzzyInvoke
Imports System.Security.Cryptography.Xml


Public Class frmMain
    Dim dtFrom As String = ""
    Dim dtTo As String = ""
    Dim query As String
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
        'Search
        Try
            DataGridView1.DataSource = Nothing
            Dim cmd As SqlCommand = conn.CreateCommand()
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_FilterAgent"
                With .Parameters
                    .Add(New SqlParameter("criterion_location", cmbCriterionLocation.Text))
                    .Add(New SqlParameter("location_value", cmbValueLocation.SelectedValue))
                    .Add(New SqlParameter("creation_date_from", dtFrom))
                    .Add(New SqlParameter("creation_date_to", dtTo))
                    .Add(New SqlParameter("criterion_personal", cmbCriterionPeronel.Text))
                    If cmbCriterionPeronel.Text = "Matricule" Then
                        .Add(New SqlParameter("criterion_personal_value", cmbValuePersonal.Text))
                    Else
                        .Add(New SqlParameter("criterion_personal_value", cmbValuePersonal.SelectedValue))
                    End If

                End With
            End With
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            picExportAgent.Enabled = True
            'CType(DataGridView1.Columns(DataGridView1.Columns.Count - 1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
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
        Try
            Dim cmd As SqlCommand = conn.CreateCommand()
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_ExportAgent"
                With .Parameters
                    .Add(New SqlParameter("criterion_location", cmbCriterionLocation.Text))
                    .Add(New SqlParameter("location_value", cmbValueLocation.SelectedValue))
                    .Add(New SqlParameter("creation_date_from", dtFrom))
                    .Add(New SqlParameter("creation_date_to", dtTo))
                    .Add(New SqlParameter("criterion_personal", cmbCriterionPeronel.Text))
                    If cmbCriterionPeronel.Text = "Matricule" Then
                        .Add(New SqlParameter("criterion_personal_value", cmbValuePersonal.Text))
                    Else
                        .Add(New SqlParameter("criterion_personal_value", cmbValuePersonal.SelectedValue))
                    End If

                End With
            End With
            cmd.ExecuteNonQueryAsync()
            MessageBox.Show("Exportation reussie")
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        dtFrom = dtpFrom.Value
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        dtTo = dtpTo.Value
    End Sub

    Private Sub cmbCriterionLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCriterionLocation.SelectedIndexChanged
        query = ""
        'load values accprdingly
        If cmbCriterionLocation.Text = "Province d'origine" Then
            query = "Select 0 value, 'Select' display union  SELECT id_province as value, nom as display FROM [dbo].province"
        ElseIf cmbCriterionLocation.Text = "Territoire d'origine" Then
            query = "Select 0 value, 'Select' display union SELECT id_territoire as value, nom as display FROM [dbo].territoire"
        ElseIf cmbCriterionLocation.Text = "Secteur d'origine" Then
            query = "Select 0 value, 'Select' display union  SELECT id_secteur as value, nom as display FROM [dbo].secteur"
        End If
        If query <> "" Then
            loadComboBox(cmbValueLocation, query)
        End If
    End Sub

    Private Sub cmbCriterionPeronel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCriterionPeronel.SelectedIndexChanged
        query = ""
        'load values accprdingly
        If cmbCriterionPeronel.Text = "Grade" Then
            query = "Select 0 value, 'Select' display union  SELECT id_grade as value, description as display FROM [dbo].grade"
        ElseIf cmbCriterionPeronel.Text = "Unité" Then
            query = "Select 0 value, 'Select' display union  SELECT id_unite as value, description as display FROM [dbo].unite"
        ElseIf cmbCriterionPeronel.Text = "Fonction" Then
            query = "Select 0 value, 'Select' display union  SELECT id_fonction as value, description as display FROM [dbo].fonction"
        Else
            query = ""
            cmbValuePersonal.DataSource = Nothing
        End If
        If query <> "" Then
            loadComboBox(cmbValuePersonal, query)
        End If

    End Sub
End Class
