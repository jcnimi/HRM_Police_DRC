Imports System.Data
Imports System.Data.Sql
Imports System.Drawing
Imports Emgu.CV.Fuzzy.FuzzyInvoke
Imports System.Security.Cryptography.Xml
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Newtonsoft.Json.Linq

Public Class frmMain
    Dim dtFrom As String = ""
    Dim dtTo As String = ""
    Dim query As String = ""
    Dim selectedRow As DataGridViewRow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text + $" - [{userFullName}]"
        Me.Width = GroupBox1.Width + 40
        Me.Height = 540
        Me.StartPosition = FormStartPosition.CenterScreen
        'Me.Left = 30

        'tooltip
        Dim tt As New ToolTip()
        tt.SetToolTip(picSearch, "Filtrer")
        tt.SetToolTip(picAddAgent, "Ajouter un nouvel agent")
        tt.SetToolTip(picExportAgent, "Exporter les données")
        tt.SetToolTip(picSettings, "Administration du système")

        Dim queryString = "SELECT top 20 [matricule] Matricule
        ,a.[nom] Nom
        ,[postnom] Postnom
        ,[prenom] Prenom 
        ,c.description as Grade
		,d.[nom] ""Lieu de naissance""
		,a.[date_naissance] ""Date de Naissance""
	    ,b.description as Fonction
        ,[date_expiration] ""Date expiration""
        ,autorite
        FROM [dbo].[agent] a
        left join [dbo].[fonction] b on a.fonction = b.id_fonction
        left join [dbo].[grade] c on a.grade = c.id_grade
		left join [dbo].[lieu] d on a.[lieu_naissance] = d.id_lieu
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
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New frmNewAgent
        frm.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub picSettings_Click(sender As Object, e As EventArgs) Handles picSettings.Click
        Dim frm As New frmAdministration()
        frm.ShowDialog()
    End Sub

    Private Sub picSettings_MouseHover(sender As Object, e As EventArgs) Handles picSettings.MouseHover
        picSettings.Image = My.Resources.Settings2
    End Sub

    Private Sub picSettings_MouseLeave(sender As Object, e As EventArgs) Handles picSettings.MouseLeave
        picSettings.Image = My.Resources.Settings1
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        searchAgents()
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
        ExportAgent()
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

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 And selectedRow IsNot Nothing Then
            Dim frm As New frmNewAgent
            frm.matriculeAgent = selectedRow.Cells("matricule").Value
            frm.isUpdating = True
            Me.Cursor = Cursors.WaitCursor
            frm.ShowDialog()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            selectedRow = DataGridView1.SelectedRows.Item(0)
        End If
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        MessageBox.Show(e.ToString)
    End Sub

    Private Sub ChangerDeMotDePasseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangerDeMotDePasseToolStripMenuItem.Click
        Dim frmCP As New frmChangePwd()
        frmCP.userName = userName_
        frmCP.oldPassword = userPwd
        frmCP.ShowDialog()
        If frmCP.clickedButton = "cancel" Then
            Exit Sub
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        conn.Close()
        conn.Dispose()
        Application.Exit()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub ExportAgent()
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
            cmd.ExecuteNonQuery()
            MessageBox.Show("Exportation reussie")

            'open cardpresso

            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            Dim proc As Process
            Try
                pi.FileName = cardPressoPath
                proc = Process.Start(pi)
            Catch ex As Exception
                MessageBox.Show("Erreur: " + ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub

    Private Sub ExportAgentSelection()
        Try
            'truncate db_cardpresso
            saveData("delete from db_cardpresso")

            'geberate an id to be used as reference
            Dim idCardPresso As String = getGuid()

            'get the selected data
            Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
            If selectedRowCount > 0 Then
                Dim i As Integer
                For i = 0 To selectedRowCount - 1
                    Dim value As String = DataGridView1.SelectedRows(i).Cells("matricule").Value.ToString
                    'insert data
                    Dim param As SqlParameter
                    Dim dbParam As New List(Of SqlParameter)
                    param = New SqlParameter("@matricule", SqlDbType.NVarChar)
                    param.Value = value
                    dbParam.Add(param)
                    param = New SqlParameter("@reference", SqlDbType.NVarChar)
                    param.Value = idCardPresso
                    dbParam.Add(param)
                    saveDataSP("sp_ExportAgent_1", dbParam)

                Next i
            Else
                MessageBox.Show("Veuillez séléctionner au moins une ligne")
            End If
            MessageBox.Show("Exportation reussie")

            'open cardpresso

            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            Dim proc As Process
            Try
                'pi.Arguments = " /C " + """" + cardPressoPath + """"
                pi.FileName = cardPressoPath
                proc = Process.Start(pi)
            Catch ex As Exception
                MessageBox.Show("Erreur: " + ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub

    Private Sub searchAgents()
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
            mnuExportCardPresso.Enabled = True
            mnuExportSelection.Enabled = True
            'CType(DataGridView1.Columns(DataGridView1.Columns.Count - 1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub

    Private Sub mnuRechercher_Click(sender As Object, e As EventArgs) Handles mnuRechercher.Click
        searchAgents()
    End Sub

    Private Sub DataGridView1_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
        If e.StateChanged = DataGridViewElementStates.Selected Then
            mnuModifierAgent.Enabled = True
        Else
            mnuModifierAgent.Enabled = False
        End If
    End Sub

    Private Sub mnuModifierAgent_Click(sender As Object, e As EventArgs) Handles mnuModifierAgent.Click
        Dim frm As New frmNewAgent
        frm.matriculeAgent = selectedRow.Cells("matricule").Value
        frm.isUpdating = True
        Me.Cursor = Cursors.WaitCursor
        frm.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mnuAjouterAgent_Click(sender As Object, e As EventArgs) Handles mnuAjouterAgent.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frm As New frmNewAgent
        frm.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mnuParametres_Click(sender As Object, e As EventArgs) Handles mnuParametres.Click
        Dim frm As New frmAdministration()
        frm.ShowDialog()
    End Sub

    Private Sub mnuExportCardPresso_Click(sender As Object, e As EventArgs) Handles mnuExportCardPresso.Click
        ExportAgent()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As New frmRapports()
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim frm As New frmImportData()
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles mnuExportSelection.Click
        ExportAgentSelection()
    End Sub
End Class
