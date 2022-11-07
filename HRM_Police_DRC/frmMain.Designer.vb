<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.picSettings = New System.Windows.Forms.PictureBox()
        Me.picExportAgent = New System.Windows.Forms.PictureBox()
        Me.picAddAgent = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCriterionPeronel = New System.Windows.Forms.ComboBox()
        Me.cmbValuePersonal = New System.Windows.Forms.ComboBox()
        Me.grpValue = New System.Windows.Forms.GroupBox()
        Me.lbldtA = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lbldtDe = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCriterionLocation = New System.Windows.Forms.ComboBox()
        Me.cmbValueLocation = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExportAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAddAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.grpValue.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.grpValue)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(1497, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.picSearch)
        Me.GroupBox5.Controls.Add(Me.picSettings)
        Me.GroupBox5.Controls.Add(Me.picExportAgent)
        Me.GroupBox5.Controls.Add(Me.picAddAgent)
        Me.GroupBox5.Location = New System.Drawing.Point(1053, 23)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(431, 131)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Actions"
        '
        'picSearch
        '
        Me.picSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSearch.Image = CType(resources.GetObject("picSearch.Image"), System.Drawing.Image)
        Me.picSearch.Location = New System.Drawing.Point(18, 26)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(95, 88)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSearch.TabIndex = 15
        Me.picSearch.TabStop = False
        '
        'picSettings
        '
        Me.picSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSettings.Image = CType(resources.GetObject("picSettings.Image"), System.Drawing.Image)
        Me.picSettings.Location = New System.Drawing.Point(318, 26)
        Me.picSettings.Name = "picSettings"
        Me.picSettings.Size = New System.Drawing.Size(95, 88)
        Me.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSettings.TabIndex = 14
        Me.picSettings.TabStop = False
        '
        'picExportAgent
        '
        Me.picExportAgent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picExportAgent.Image = Global.HRM_Police_DRC.My.Resources.Resources.export1
        Me.picExportAgent.Location = New System.Drawing.Point(218, 26)
        Me.picExportAgent.Name = "picExportAgent"
        Me.picExportAgent.Size = New System.Drawing.Size(95, 88)
        Me.picExportAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExportAgent.TabIndex = 13
        Me.picExportAgent.TabStop = False
        '
        'picAddAgent
        '
        Me.picAddAgent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picAddAgent.Image = CType(resources.GetObject("picAddAgent.Image"), System.Drawing.Image)
        Me.picAddAgent.Location = New System.Drawing.Point(118, 26)
        Me.picAddAgent.Name = "picAddAgent"
        Me.picAddAgent.Size = New System.Drawing.Size(95, 88)
        Me.picAddAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAddAgent.TabIndex = 12
        Me.picAddAgent.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cmbCriterionPeronel)
        Me.GroupBox4.Controls.Add(Me.cmbValuePersonal)
        Me.GroupBox4.Location = New System.Drawing.Point(723, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(324, 131)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Personel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "valeur:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Critère:"
        '
        'cmbCriterionPeronel
        '
        Me.cmbCriterionPeronel.FormattingEnabled = True
        Me.cmbCriterionPeronel.Items.AddRange(New Object() {"Grade", "Unité", "Fonction", "Matricule"})
        Me.cmbCriterionPeronel.Location = New System.Drawing.Point(90, 27)
        Me.cmbCriterionPeronel.Name = "cmbCriterionPeronel"
        Me.cmbCriterionPeronel.Size = New System.Drawing.Size(218, 33)
        Me.cmbCriterionPeronel.TabIndex = 5
        '
        'cmbValuePersonal
        '
        Me.cmbValuePersonal.FormattingEnabled = True
        Me.cmbValuePersonal.Location = New System.Drawing.Point(90, 70)
        Me.cmbValuePersonal.Name = "cmbValuePersonal"
        Me.cmbValuePersonal.Size = New System.Drawing.Size(218, 33)
        Me.cmbValuePersonal.TabIndex = 6
        '
        'grpValue
        '
        Me.grpValue.Controls.Add(Me.lbldtA)
        Me.grpValue.Controls.Add(Me.dtpTo)
        Me.grpValue.Controls.Add(Me.dtpFrom)
        Me.grpValue.Controls.Add(Me.lbldtDe)
        Me.grpValue.Location = New System.Drawing.Point(359, 23)
        Me.grpValue.Name = "grpValue"
        Me.grpValue.Size = New System.Drawing.Size(354, 131)
        Me.grpValue.TabIndex = 8
        Me.grpValue.TabStop = False
        Me.grpValue.Text = "Date création"
        '
        'lbldtA
        '
        Me.lbldtA.AutoSize = True
        Me.lbldtA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldtA.Location = New System.Drawing.Point(23, 75)
        Me.lbldtA.Name = "lbldtA"
        Me.lbldtA.Size = New System.Drawing.Size(22, 25)
        Me.lbldtA.TabIndex = 9
        Me.lbldtA.Text = "à"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(64, 71)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(270, 31)
        Me.dtpTo.TabIndex = 8
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(63, 27)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(271, 31)
        Me.dtpFrom.TabIndex = 7
        '
        'lbldtDe
        '
        Me.lbldtDe.AutoSize = True
        Me.lbldtDe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldtDe.Location = New System.Drawing.Point(22, 27)
        Me.lbldtDe.Name = "lbldtDe"
        Me.lbldtDe.Size = New System.Drawing.Size(35, 25)
        Me.lbldtDe.TabIndex = 4
        Me.lbldtDe.Text = "De"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmbCriterionLocation)
        Me.GroupBox3.Controls.Add(Me.cmbValueLocation)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 131)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lieu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "valeur:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Critère:"
        '
        'cmbCriterionLocation
        '
        Me.cmbCriterionLocation.FormattingEnabled = True
        Me.cmbCriterionLocation.Items.AddRange(New Object() {"Province d'origine", "Territoire d'origine", "Secteur d'origine"})
        Me.cmbCriterionLocation.Location = New System.Drawing.Point(93, 24)
        Me.cmbCriterionLocation.Name = "cmbCriterionLocation"
        Me.cmbCriterionLocation.Size = New System.Drawing.Size(218, 33)
        Me.cmbCriterionLocation.TabIndex = 1
        '
        'cmbValueLocation
        '
        Me.cmbValueLocation.FormattingEnabled = True
        Me.cmbValueLocation.Location = New System.Drawing.Point(93, 67)
        Me.cmbValueLocation.Name = "cmbValueLocation"
        Me.cmbValueLocation.Size = New System.Drawing.Size(218, 33)
        Me.cmbValueLocation.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1499, 469)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agents"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1493, 439)
        Me.DataGridView1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1523, 656)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Identification de l'agent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExportAgent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAddAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpValue.ResumeLayout(False)
        Me.grpValue.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbValueLocation As ComboBox
    Friend WithEvents cmbCriterionLocation As ComboBox
    Friend WithEvents grpValue As GroupBox
    Friend WithEvents lbldtDe As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbldtA As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents picSettings As PictureBox
    Friend WithEvents picExportAgent As PictureBox
    Friend WithEvents picAddAgent As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCriterionPeronel As ComboBox
    Friend WithEvents cmbValuePersonal As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
