<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRapports
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboSeparateur = New System.Windows.Forms.ComboBox()
        Me.lblSep = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboValeur = New System.Windows.Forms.ComboBox()
        Me.grpValue = New System.Windows.Forms.GroupBox()
        Me.lbldtA = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lbldtDe = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCriterion = New System.Windows.Forms.ComboBox()
        Me.cmbValue = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExporter = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnFiltrer = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox4.SuspendLayout()
        Me.grpValue.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboSeparateur)
        Me.GroupBox4.Controls.Add(Me.lblSep)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cboValeur)
        Me.GroupBox4.Location = New System.Drawing.Point(716, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(324, 121)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Format"
        '
        'cboSeparateur
        '
        Me.cboSeparateur.Enabled = False
        Me.cboSeparateur.FormattingEnabled = True
        Me.cboSeparateur.Items.AddRange(New Object() {"Virgule (,)", "Point virgule (;)", "Tabulation", "Espace"})
        Me.cboSeparateur.Location = New System.Drawing.Point(118, 69)
        Me.cboSeparateur.Name = "cboSeparateur"
        Me.cboSeparateur.Size = New System.Drawing.Size(190, 33)
        Me.cboSeparateur.TabIndex = 8
        '
        'lblSep
        '
        Me.lblSep.AutoSize = True
        Me.lblSep.Enabled = False
        Me.lblSep.Location = New System.Drawing.Point(11, 72)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(101, 25)
        Me.lblSep.TabIndex = 7
        Me.lblSep.Text = "Separateur:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valeur:"
        '
        'cboValeur
        '
        Me.cboValeur.FormattingEnabled = True
        Me.cboValeur.Items.AddRange(New Object() {"Excel", "CSV", "PDF"})
        Me.cboValeur.Location = New System.Drawing.Point(118, 29)
        Me.cboValeur.Name = "cboValeur"
        Me.cboValeur.Size = New System.Drawing.Size(190, 33)
        Me.cboValeur.TabIndex = 5
        '
        'grpValue
        '
        Me.grpValue.Controls.Add(Me.lbldtA)
        Me.grpValue.Controls.Add(Me.dtpTo)
        Me.grpValue.Controls.Add(Me.dtpFrom)
        Me.grpValue.Controls.Add(Me.lbldtDe)
        Me.grpValue.Location = New System.Drawing.Point(18, 12)
        Me.grpValue.Name = "grpValue"
        Me.grpValue.Size = New System.Drawing.Size(354, 121)
        Me.grpValue.TabIndex = 12
        Me.grpValue.TabStop = False
        Me.grpValue.Text = "Date d'impression"
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
        Me.GroupBox3.Controls.Add(Me.cmbCriterion)
        Me.GroupBox3.Controls.Add(Me.cmbValue)
        Me.GroupBox3.Location = New System.Drawing.Point(381, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 121)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Critère"
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
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Critère:"
        '
        'cmbCriterion
        '
        Me.cmbCriterion.FormattingEnabled = True
        Me.cmbCriterion.Items.AddRange(New Object() {"Fonction", "Grade", "Matricule"})
        Me.cmbCriterion.Location = New System.Drawing.Point(93, 24)
        Me.cmbCriterion.Name = "cmbCriterion"
        Me.cmbCriterion.Size = New System.Drawing.Size(218, 33)
        Me.cmbCriterion.TabIndex = 1
        '
        'cmbValue
        '
        Me.cmbValue.FormattingEnabled = True
        Me.cmbValue.Location = New System.Drawing.Point(93, 67)
        Me.cmbValue.Name = "cmbValue"
        Me.cmbValue.Size = New System.Drawing.Size(218, 33)
        Me.cmbValue.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1027, 352)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aperçu"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(992, 304)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExporter)
        Me.GroupBox2.Controls.Add(Me.btnAnnuler)
        Me.GroupBox2.Controls.Add(Me.btnFiltrer)
        Me.GroupBox2.Location = New System.Drawing.Point(1047, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 472)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'btnExporter
        '
        Me.btnExporter.Enabled = False
        Me.btnExporter.Location = New System.Drawing.Point(16, 100)
        Me.btnExporter.Name = "btnExporter"
        Me.btnExporter.Size = New System.Drawing.Size(112, 34)
        Me.btnExporter.TabIndex = 2
        Me.btnExporter.Text = "Exporter"
        Me.btnExporter.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(16, 174)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(112, 34)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnFiltrer
        '
        Me.btnFiltrer.Location = New System.Drawing.Point(16, 35)
        Me.btnFiltrer.Name = "btnFiltrer"
        Me.btnFiltrer.Size = New System.Drawing.Size(112, 34)
        Me.btnFiltrer.TabIndex = 0
        Me.btnFiltrer.Text = "Filtrer"
        Me.btnFiltrer.UseVisualStyleBackColor = True
        '
        'frmRapports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 496)
        Me.Controls.Add(Me.grpValue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRapports"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRapports"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpValue.ResumeLayout(False)
        Me.grpValue.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cboSeparateur As ComboBox
    Friend WithEvents lblSep As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboValeur As ComboBox
    Friend WithEvents grpValue As GroupBox
    Friend WithEvents lbldtA As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lbldtDe As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCriterion As ComboBox
    Friend WithEvents cmbValue As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnFiltrer As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnExporter As Button
End Class
