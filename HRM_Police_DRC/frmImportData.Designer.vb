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
        Me.btnTemplateFilePath = New System.Windows.Forms.Button()
        Me.txtTemplateFilePath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDataFilePath = New System.Windows.Forms.Button()
        Me.txtSourceFilePath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSourceFormat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnTemplateFilePath)
        Me.GroupBox1.Controls.Add(Me.txtTemplateFilePath)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnDataFilePath)
        Me.GroupBox1.Controls.Add(Me.txtSourceFilePath)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboSourceFormat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 434)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnTemplateFilePath
        '
        Me.btnTemplateFilePath.Location = New System.Drawing.Point(871, 155)
        Me.btnTemplateFilePath.Name = "btnTemplateFilePath"
        Me.btnTemplateFilePath.Size = New System.Drawing.Size(44, 31)
        Me.btnTemplateFilePath.TabIndex = 7
        Me.btnTemplateFilePath.Text = "..."
        Me.btnTemplateFilePath.UseVisualStyleBackColor = True
        '
        'txtTemplateFilePath
        '
        Me.txtTemplateFilePath.Location = New System.Drawing.Point(245, 155)
        Me.txtTemplateFilePath.Name = "txtTemplateFilePath"
        Me.txtTemplateFilePath.Size = New System.Drawing.Size(620, 31)
        Me.txtTemplateFilePath.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fichier Modele:"
        '
        'btnDataFilePath
        '
        Me.btnDataFilePath.Location = New System.Drawing.Point(871, 93)
        Me.btnDataFilePath.Name = "btnDataFilePath"
        Me.btnDataFilePath.Size = New System.Drawing.Size(44, 31)
        Me.btnDataFilePath.TabIndex = 4
        Me.btnDataFilePath.Text = "..."
        Me.btnDataFilePath.UseVisualStyleBackColor = True
        '
        'txtSourceFilePath
        '
        Me.txtSourceFilePath.Location = New System.Drawing.Point(245, 96)
        Me.txtSourceFilePath.Name = "txtSourceFilePath"
        Me.txtSourceFilePath.Size = New System.Drawing.Size(620, 31)
        Me.txtSourceFilePath.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fichier source:"
        '
        'cboSourceFormat
        '
        Me.cboSourceFormat.FormattingEnabled = True
        Me.cboSourceFormat.Items.AddRange(New Object() {"Excel", "CSV (Separateur Virgule)", "CSV (Separateur Point Virgule)", "CSV (Separateur Tabulation)", "CSV (Separateur Espace)"})
        Me.cboSourceFormat.Location = New System.Drawing.Point(245, 39)
        Me.cboSourceFormat.Name = "cboSourceFormat"
        Me.cboSourceFormat.Size = New System.Drawing.Size(265, 33)
        Me.cboSourceFormat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Format source:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(870, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(244, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(620, 31)
        Me.TextBox1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dossier Image:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(870, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 31)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(244, 261)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(620, 31)
        Me.TextBox2.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Dossier signature:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(870, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 31)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(244, 310)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(620, 31)
        Me.TextBox3.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Dossier empri,te gauche:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(871, 366)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 31)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(245, 366)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(620, 31)
        Me.TextBox4.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Dossier empreinte droite:"
        '
        'frmImportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 450)
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
    Friend WithEvents btnTemplateFilePath As Button
    Friend WithEvents txtTemplateFilePath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
