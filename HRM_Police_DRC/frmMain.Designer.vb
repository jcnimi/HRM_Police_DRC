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
        Me.grpValue = New System.Windows.Forms.GroupBox()
        Me.lbldtA = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblValeurUnique = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.lbldtDe = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbCritere = New System.Windows.Forms.ComboBox()
        Me.cmbIncluEgal = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.grpValue.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpValue)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(1497, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'grpValue
        '
        Me.grpValue.Controls.Add(Me.lbldtA)
        Me.grpValue.Controls.Add(Me.dtTo)
        Me.grpValue.Controls.Add(Me.dtFrom)
        Me.grpValue.Controls.Add(Me.lblValeurUnique)
        Me.grpValue.Controls.Add(Me.txtValue)
        Me.grpValue.Controls.Add(Me.lbldtDe)
        Me.grpValue.Location = New System.Drawing.Point(443, 23)
        Me.grpValue.Name = "grpValue"
        Me.grpValue.Size = New System.Drawing.Size(354, 119)
        Me.grpValue.TabIndex = 8
        Me.grpValue.TabStop = False
        Me.grpValue.Text = "Valeurs de rechercher"
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
        'dtTo
        '
        Me.dtTo.Location = New System.Drawing.Point(64, 71)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(233, 31)
        Me.dtTo.TabIndex = 8
        '
        'dtFrom
        '
        Me.dtFrom.Location = New System.Drawing.Point(63, 27)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(233, 31)
        Me.dtFrom.TabIndex = 7
        '
        'lblValeurUnique
        '
        Me.lblValeurUnique.AutoSize = True
        Me.lblValeurUnique.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblValeurUnique.Location = New System.Drawing.Point(23, 50)
        Me.lblValeurUnique.Name = "lblValeurUnique"
        Me.lblValeurUnique.Size = New System.Drawing.Size(22, 25)
        Me.lblValeurUnique.TabIndex = 6
        Me.lblValeurUnique.Text = "à"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(64, 52)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(187, 31)
        Me.txtValue.TabIndex = 5
        '
        'lbldtDe
        '
        Me.lbldtDe.AutoSize = True
        Me.lbldtDe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldtDe.Location = New System.Drawing.Point(23, 27)
        Me.lbldtDe.Name = "lbldtDe"
        Me.lbldtDe.Size = New System.Drawing.Size(35, 25)
        Me.lbldtDe.TabIndex = 4
        Me.lbldtDe.Text = "De"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbCritere)
        Me.GroupBox3.Controls.Add(Me.cmbIncluEgal)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 119)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Critères de recherche"
        '
        'cmbCritere
        '
        Me.cmbCritere.FormattingEnabled = True
        Me.cmbCritere.Items.AddRange(New Object() {"Tous", "Matricule", "Date Création", "Province", "Territoire", "Secteur", "Nom", "Postnom", "Prenom", "", ""})
        Me.cmbCritere.Location = New System.Drawing.Point(20, 52)
        Me.cmbCritere.Name = "cmbCritere"
        Me.cmbCritere.Size = New System.Drawing.Size(182, 33)
        Me.cmbCritere.TabIndex = 1
        '
        'cmbIncluEgal
        '
        Me.cmbIncluEgal.FormattingEnabled = True
        Me.cmbIncluEgal.Items.AddRange(New Object() {"Egal", "Entre"})
        Me.cmbIncluEgal.Location = New System.Drawing.Point(239, 52)
        Me.cmbIncluEgal.Name = "cmbIncluEgal"
        Me.cmbIncluEgal.Size = New System.Drawing.Size(110, 33)
        Me.cmbIncluEgal.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HRM_Police_DRC.My.Resources.Resources.export1
        Me.PictureBox2.Location = New System.Drawing.Point(1290, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1150, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmdSearch.Location = New System.Drawing.Point(828, 52)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(124, 65)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Rechercher"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1499, 404)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1493, 374)
        Me.DataGridView1.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1523, 579)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Identification de l'agent"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpValue.ResumeLayout(False)
        Me.grpValue.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents cmbIncluEgal As ComboBox
    Friend WithEvents cmbCritere As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents grpValue As GroupBox
    Friend WithEvents lblValeurUnique As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents lbldtDe As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbldtA As Label
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents dtFrom As DateTimePicker
End Class
