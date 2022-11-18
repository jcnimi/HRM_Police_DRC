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
        Me.cboFormatSeparateur = New System.Windows.Forms.ComboBox()
        Me.lblSep = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFormatValeur = New System.Windows.Forms.ComboBox()
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
        Me.GroupBox4.Controls.Add(Me.cboFormatSeparateur)
        Me.GroupBox4.Controls.Add(Me.lblSep)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cboFormatValeur)
        Me.GroupBox4.Location = New System.Drawing.Point(501, 7)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(227, 73)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Format"
        '
        'cboFormatSeparateur
        '
        Me.cboFormatSeparateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormatSeparateur.Enabled = False
        Me.cboFormatSeparateur.FormattingEnabled = True
        Me.cboFormatSeparateur.Items.AddRange(New Object() {"Virgule (,)", "Point virgule (;)", "Tabulation", "Espace"})
        Me.cboFormatSeparateur.Location = New System.Drawing.Point(83, 41)
        Me.cboFormatSeparateur.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboFormatSeparateur.Name = "cboFormatSeparateur"
        Me.cboFormatSeparateur.Size = New System.Drawing.Size(134, 23)
        Me.cboFormatSeparateur.TabIndex = 8
        '
        'lblSep
        '
        Me.lblSep.AutoSize = True
        Me.lblSep.Enabled = False
        Me.lblSep.Location = New System.Drawing.Point(8, 43)
        Me.lblSep.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(66, 15)
        Me.lblSep.TabIndex = 7
        Me.lblSep.Text = "Separateur:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valeur:"
        '
        'cboFormatValeur
        '
        Me.cboFormatValeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormatValeur.FormattingEnabled = True
        Me.cboFormatValeur.Items.AddRange(New Object() {"Excel", "CSV"})
        Me.cboFormatValeur.Location = New System.Drawing.Point(83, 17)
        Me.cboFormatValeur.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboFormatValeur.Name = "cboFormatValeur"
        Me.cboFormatValeur.Size = New System.Drawing.Size(134, 23)
        Me.cboFormatValeur.TabIndex = 5
        '
        'grpValue
        '
        Me.grpValue.Controls.Add(Me.lbldtA)
        Me.grpValue.Controls.Add(Me.dtpTo)
        Me.grpValue.Controls.Add(Me.dtpFrom)
        Me.grpValue.Controls.Add(Me.lbldtDe)
        Me.grpValue.Location = New System.Drawing.Point(13, 7)
        Me.grpValue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpValue.Name = "grpValue"
        Me.grpValue.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpValue.Size = New System.Drawing.Size(248, 73)
        Me.grpValue.TabIndex = 12
        Me.grpValue.TabStop = False
        Me.grpValue.Text = "Date d'impression"
        '
        'lbldtA
        '
        Me.lbldtA.AutoSize = True
        Me.lbldtA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldtA.Location = New System.Drawing.Point(16, 45)
        Me.lbldtA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldtA.Name = "lbldtA"
        Me.lbldtA.Size = New System.Drawing.Size(13, 15)
        Me.lbldtA.TabIndex = 9
        Me.lbldtA.Text = "à"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(45, 43)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(190, 23)
        Me.dtpTo.TabIndex = 8
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(44, 16)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(191, 23)
        Me.dtpFrom.TabIndex = 7
        '
        'lbldtDe
        '
        Me.lbldtDe.AutoSize = True
        Me.lbldtDe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldtDe.Location = New System.Drawing.Point(15, 16)
        Me.lbldtDe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldtDe.Name = "lbldtDe"
        Me.lbldtDe.Size = New System.Drawing.Size(23, 15)
        Me.lbldtDe.TabIndex = 4
        Me.lbldtDe.Text = "De"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmbCriterion)
        Me.GroupBox3.Controls.Add(Me.cmbValue)
        Me.GroupBox3.Location = New System.Drawing.Point(267, 7)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(230, 73)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Critère"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "valeur:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Critère:"
        '
        'cmbCriterion
        '
        Me.cmbCriterion.FormattingEnabled = True
        Me.cmbCriterion.Items.AddRange(New Object() {"Fonction", "Grade", "Matricule"})
        Me.cmbCriterion.Location = New System.Drawing.Point(65, 14)
        Me.cmbCriterion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbCriterion.Name = "cmbCriterion"
        Me.cmbCriterion.Size = New System.Drawing.Size(154, 23)
        Me.cmbCriterion.TabIndex = 1
        '
        'cmbValue
        '
        Me.cmbValue.FormattingEnabled = True
        Me.cmbValue.Location = New System.Drawing.Point(65, 40)
        Me.cmbValue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbValue.Name = "cmbValue"
        Me.cmbValue.Size = New System.Drawing.Size(154, 23)
        Me.cmbValue.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 79)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(719, 211)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aperçu"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(694, 182)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExporter)
        Me.GroupBox2.Controls.Add(Me.btnAnnuler)
        Me.GroupBox2.Controls.Add(Me.btnFiltrer)
        Me.GroupBox2.Location = New System.Drawing.Point(733, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(105, 283)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'btnExporter
        '
        Me.btnExporter.Enabled = False
        Me.btnExporter.Location = New System.Drawing.Point(11, 60)
        Me.btnExporter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExporter.Name = "btnExporter"
        Me.btnExporter.Size = New System.Drawing.Size(78, 20)
        Me.btnExporter.TabIndex = 2
        Me.btnExporter.Text = "Exporter"
        Me.btnExporter.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(11, 104)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(78, 20)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnFiltrer
        '
        Me.btnFiltrer.Location = New System.Drawing.Point(11, 21)
        Me.btnFiltrer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFiltrer.Name = "btnFiltrer"
        Me.btnFiltrer.Size = New System.Drawing.Size(78, 20)
        Me.btnFiltrer.TabIndex = 0
        Me.btnFiltrer.Text = "Filtrer"
        Me.btnFiltrer.UseVisualStyleBackColor = True
        '
        'frmRapports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(845, 298)
        Me.Controls.Add(Me.grpValue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents cboFormatSeparateur As ComboBox
    Friend WithEvents lblSep As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboFormatValeur As ComboBox
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
