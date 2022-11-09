<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePwd
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
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.txtNewPwdRepeat = New System.Windows.Forms.TextBox()
        Me.txtnewPwd = New System.Windows.Forms.TextBox()
        Me.txtOldPwd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnValider)
        Me.GroupBox1.Controls.Add(Me.btnAnnuler)
        Me.GroupBox1.Controls.Add(Me.txtNewPwdRepeat)
        Me.GroupBox1.Controls.Add(Me.txtnewPwd)
        Me.GroupBox1.Controls.Add(Me.txtOldPwd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(414, 166)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(112, 34)
        Me.btnValider.TabIndex = 7
        Me.btnValider.Text = "valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(276, 166)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(112, 34)
        Me.btnAnnuler.TabIndex = 6
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'txtNewPwdRepeat
        '
        Me.txtNewPwdRepeat.Location = New System.Drawing.Point(240, 111)
        Me.txtNewPwdRepeat.Name = "txtNewPwdRepeat"
        Me.txtNewPwdRepeat.Size = New System.Drawing.Size(286, 31)
        Me.txtNewPwdRepeat.TabIndex = 5
        Me.txtNewPwdRepeat.UseSystemPasswordChar = True
        '
        'txtnewPwd
        '
        Me.txtnewPwd.Location = New System.Drawing.Point(240, 71)
        Me.txtnewPwd.Name = "txtnewPwd"
        Me.txtnewPwd.Size = New System.Drawing.Size(286, 31)
        Me.txtnewPwd.TabIndex = 4
        Me.txtnewPwd.UseSystemPasswordChar = True
        '
        'txtOldPwd
        '
        Me.txtOldPwd.Location = New System.Drawing.Point(240, 31)
        Me.txtOldPwd.Name = "txtOldPwd"
        Me.txtOldPwd.Size = New System.Drawing.Size(286, 31)
        Me.txtOldPwd.TabIndex = 3
        Me.txtOldPwd.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rasaisir le nouveau :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nouveau mot de passe:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ancien Mot de passe:"
        '
        'frmChangePwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 224)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePwd"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changement de mot de passe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnValider As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents txtNewPwdRepeat As TextBox
    Friend WithEvents txtnewPwd As TextBox
    Friend WithEvents txtOldPwd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
