<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebcam
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnValidate = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(518, 426)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(557, 24)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 34)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Demarrer"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(557, 156)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 34)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(557, 88)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(112, 34)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Arreter"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(557, 214)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(112, 34)
        Me.btnValidate.TabIndex = 4
        Me.btnValidate.Text = "Valider"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'frmWebcam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 450)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWebcam"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capture de la phoro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnValidate As Button
End Class
