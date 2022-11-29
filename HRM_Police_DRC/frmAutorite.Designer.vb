<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutorite
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dtpCreateDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        Me.btnImporter = New System.Windows.Forms.Button()
        Me.btnScanner = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 285)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dtpCreateDate)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 201)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(440, 74)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Date création"
        '
        'dtpCreateDate
        '
        Me.dtpCreateDate.Location = New System.Drawing.Point(12, 28)
        Me.dtpCreateDate.Name = "dtpCreateDate"
        Me.dtpCreateDate.Size = New System.Drawing.Size(421, 31)
        Me.dtpCreateDate.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cboStatus)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 109)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(440, 88)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Statut"
        '
        'cboStatus
        '
        Me.cboStatus.Enabled = False
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Actif", "Inactif"})
        Me.cboStatus.Location = New System.Drawing.Point(12, 30)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(421, 33)
        Me.cboStatus.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtNom)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(443, 75)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Nom"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(12, 29)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(421, 31)
        Me.txtNom.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.picSignature)
        Me.GroupBox4.Controls.Add(Me.btnImporter)
        Me.GroupBox4.Controls.Add(Me.btnScanner)
        Me.GroupBox4.Location = New System.Drawing.Point(479, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(292, 261)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Signature"
        '
        'picSignature
        '
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSignature.Location = New System.Drawing.Point(27, 30)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(230, 167)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 0
        Me.picSignature.TabStop = False
        '
        'btnImporter
        '
        Me.btnImporter.Location = New System.Drawing.Point(145, 203)
        Me.btnImporter.Name = "btnImporter"
        Me.btnImporter.Size = New System.Drawing.Size(112, 47)
        Me.btnImporter.TabIndex = 3
        Me.btnImporter.Text = "Importer"
        Me.btnImporter.UseVisualStyleBackColor = True
        '
        'btnScanner
        '
        Me.btnScanner.Location = New System.Drawing.Point(27, 203)
        Me.btnScanner.Name = "btnScanner"
        Me.btnScanner.Size = New System.Drawing.Size(112, 47)
        Me.btnScanner.TabIndex = 2
        Me.btnScanner.Text = "Scanner"
        Me.btnScanner.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1010, 227)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1004, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnsave)
        Me.GroupBox3.Controls.Add(Me.btnNew)
        Me.GroupBox3.Location = New System.Drawing.Point(809, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(215, 285)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Actions"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(41, 201)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 54)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Fermer"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(41, 123)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(128, 54)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Enregistrer"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(41, 45)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(128, 54)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Nouveau"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmAutorite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1036, 530)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAutorite"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorité"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents dtpCreateDate As DateTimePicker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents picSignature As PictureBox
    Friend WithEvents btnImporter As Button
    Friend WithEvents btnScanner As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
