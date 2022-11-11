<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picvalidate = New System.Windows.Forms.PictureBox()
        Me.picCancel = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picvalidate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(460, 102)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(332, 31)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Tag = ""
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(460, 196)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(332, 31)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(67, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'picvalidate
        '
        Me.picvalidate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picvalidate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picvalidate.Image = CType(resources.GetObject("picvalidate.Image"), System.Drawing.Image)
        Me.picvalidate.Location = New System.Drawing.Point(460, 311)
        Me.picvalidate.Name = "picvalidate"
        Me.picvalidate.Size = New System.Drawing.Size(150, 75)
        Me.picvalidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picvalidate.TabIndex = 5
        Me.picvalidate.TabStop = False
        '
        'picCancel
        '
        Me.picCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCancel.Image = CType(resources.GetObject("picCancel.Image"), System.Drawing.Image)
        Me.picCancel.Location = New System.Drawing.Point(642, 311)
        Me.picCancel.Name = "picCancel"
        Me.picCancel.Size = New System.Drawing.Size(150, 75)
        Me.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCancel.TabIndex = 6
        Me.picCancel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(460, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nom d'utilisateur:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(460, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mot de passe:"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(462, 241)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(230, 29)
        Me.chkShowPassword.TabIndex = 4
        Me.chkShowPassword.Text = "Afficher le mot de passe"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(884, 411)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCancel)
        Me.Controls.Add(Me.picvalidate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picvalidate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picvalidate As PictureBox
    Friend WithEvents picCancel As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkShowPassword As CheckBox
End Class
