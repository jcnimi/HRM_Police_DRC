Imports System.Data
Imports System.Data.Sql


Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldtDe.Visible = False
        lbldtA.Visible = False
        dtFrom.Visible = False
        dtTo.Visible = False

        Dim cmd As New SqlCommand("SELECT * FROM [dbo].[territoire]", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.Screenshot_2
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.Screenshot_1
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.export2
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.export1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As New frmNewAgent
        frm.ShowDialog()
    End Sub

    Private Sub cmbCritere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCritere.SelectedIndexChanged
        If cmbCritere.SelectedItem = "Date Création" Then
            cmbIncluEgal.Enabled = False
            cmbIncluEgal.SelectedItem = "Entre"


            lbldtDe.Visible = True
            lbldtA.Visible = True
            dtFrom.Visible = True
            dtTo.Visible = True
            lblValeurUnique.Visible = False
            txtValue.Visible = False



        Else
            cmbIncluEgal.Enabled = True
            cmbIncluEgal.SelectedItem = ""

            lbldtDe.Visible = False
            lbldtA.Visible = False
            dtFrom.Visible = False
            dtTo.Visible = False
            lblValeurUnique.Visible = True
            txtValue.Visible = True

        End If
    End Sub
End Class
