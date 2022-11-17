<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportData
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLeftFingerPrintFolder = New System.Windows.Forms.Button()
        Me.txtLeftFingerPrintFolder = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImageFolder = New System.Windows.Forms.Button()
        Me.txtImageFolder = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDataFilePath = New System.Windows.Forms.Button()
        Me.txtSourceFilePath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSourceFormat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnImporter = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnMapping = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLeftFingerPrintFolder)
        Me.GroupBox1.Controls.Add(Me.txtLeftFingerPrintFolder)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnImageFolder)
        Me.GroupBox1.Controls.Add(Me.txtImageFolder)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnDataFilePath)
        Me.GroupBox1.Controls.Add(Me.txtSourceFilePath)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboSourceFormat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnLeftFingerPrintFolder
        '
        Me.btnLeftFingerPrintFolder.Location = New System.Drawing.Point(870, 167)
        Me.btnLeftFingerPrintFolder.Name = "btnLeftFingerPrintFolder"
        Me.btnLeftFingerPrintFolder.Size = New System.Drawing.Size(44, 31)
        Me.btnLeftFingerPrintFolder.TabIndex = 16
        Me.btnLeftFingerPrintFolder.Text = "..."
        Me.btnLeftFingerPrintFolder.UseVisualStyleBackColor = True
        '
        'txtLeftFingerPrintFolder
        '
        Me.txtLeftFingerPrintFolder.Location = New System.Drawing.Point(244, 167)
        Me.txtLeftFingerPrintFolder.Name = "txtLeftFingerPrintFolder"
        Me.txtLeftFingerPrintFolder.Size = New System.Drawing.Size(620, 31)
        Me.txtLeftFingerPrintFolder.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Dossier empreinte"
        '
        'btnImageFolder
        '
        Me.btnImageFolder.Location = New System.Drawing.Point(870, 118)
        Me.btnImageFolder.Name = "btnImageFolder"
        Me.btnImageFolder.Size = New System.Drawing.Size(44, 31)
        Me.btnImageFolder.TabIndex = 10
        Me.btnImageFolder.Text = "..."
        Me.btnImageFolder.UseVisualStyleBackColor = True
        '
        'txtImageFolder
        '
        Me.txtImageFolder.Location = New System.Drawing.Point(244, 118)
        Me.txtImageFolder.Name = "txtImageFolder"
        Me.txtImageFolder.Size = New System.Drawing.Size(620, 31)
        Me.txtImageFolder.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dossier Image:"
        '
        'btnDataFilePath
        '
        Me.btnDataFilePath.Location = New System.Drawing.Point(871, 68)
        Me.btnDataFilePath.Name = "btnDataFilePath"
        Me.btnDataFilePath.Size = New System.Drawing.Size(44, 31)
        Me.btnDataFilePath.TabIndex = 4
        Me.btnDataFilePath.Text = "..."
        Me.btnDataFilePath.UseVisualStyleBackColor = True
        '
        'txtSourceFilePath
        '
        Me.txtSourceFilePath.Location = New System.Drawing.Point(245, 71)
        Me.txtSourceFilePath.Name = "txtSourceFilePath"
        Me.txtSourceFilePath.Size = New System.Drawing.Size(620, 31)
        Me.txtSourceFilePath.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fichier source:"
        '
        'cboSourceFormat
        '
        Me.cboSourceFormat.FormattingEnabled = True
        Me.cboSourceFormat.Items.AddRange(New Object() {"Excel", "CSV (Separateur Virgule)", "CSV (Separateur Point Virgule)", "CSV (Separateur Tabulation)", "CSV (Separateur Espace)"})
        Me.cboSourceFormat.Location = New System.Drawing.Point(245, 25)
        Me.cboSourceFormat.Name = "cboSourceFormat"
        Me.cboSourceFormat.Size = New System.Drawing.Size(265, 33)
        Me.cboSourceFormat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Format source:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnImporter
        '
        Me.btnImporter.Enabled = False
        Me.btnImporter.Location = New System.Drawing.Point(685, 238)
        Me.btnImporter.Name = "btnImporter"
        Me.btnImporter.Size = New System.Drawing.Size(112, 34)
        Me.btnImporter.TabIndex = 1
        Me.btnImporter.Text = "Importer"
        Me.btnImporter.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(839, 238)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(112, 34)
        Me.btnAnnuler.TabIndex = 2
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnMapping
        '
        Me.btnMapping.Location = New System.Drawing.Point(512, 239)
        Me.btnMapping.Name = "btnMapping"
        Me.btnMapping.Size = New System.Drawing.Size(119, 33)
        Me.btnMapping.TabIndex = 3
        Me.btnMapping.Text = "Mapping"
        Me.btnMapping.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 291)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(962, 31)
        Me.ProgressBar1.TabIndex = 4
        Me.ProgressBar1.Visible = False
        '
        'frmImportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 322)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnMapping)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnImporter)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importation des données"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboSourceFormat As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDataFilePath As Button
    Friend WithEvents txtSourceFilePath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnLeftFingerPrintFolder As Button
    Friend WithEvents txtLeftFingerPrintFolder As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnImageFolder As Button
    Friend WithEvents txtImageFolder As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnImporter As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnMapping As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
