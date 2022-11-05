<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.chkLocked = New System.Windows.Forms.CheckBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.dtpDateExpiration = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateDebut = New System.Windows.Forms.DateTimePicker()
        Me.cboSexe = New System.Windows.Forms.ComboBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDateExpiration = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdValider = New System.Windows.Forms.Button()
        Me.cmdSuivant = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sexe:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboGroup)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.chkLocked)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.dtpDateExpiration)
        Me.GroupBox1.Controls.Add(Me.dtpDateDebut)
        Me.GroupBox1.Controls.Add(Me.cboSexe)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblDateExpiration)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(958, 311)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(463, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Groupe:"
        '
        'cboGroup
        '
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(620, 134)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(300, 33)
        Me.cboGroup.TabIndex = 17
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(198, 196)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(236, 31)
        Me.txtMail.TabIndex = 16
        '
        'chkLocked
        '
        Me.chkLocked.AutoSize = True
        Me.chkLocked.Location = New System.Drawing.Point(37, 255)
        Me.chkLocked.Name = "chkLocked"
        Me.chkLocked.Size = New System.Drawing.Size(105, 29)
        Me.chkLocked.TabIndex = 15
        Me.chkLocked.Text = "Verouillé"
        Me.chkLocked.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Actif", "Inactif"})
        Me.cboStatus.Location = New System.Drawing.Point(620, 188)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(300, 33)
        Me.cboStatus.TabIndex = 14
        '
        'dtpDateExpiration
        '
        Me.dtpDateExpiration.Location = New System.Drawing.Point(620, 82)
        Me.dtpDateExpiration.Name = "dtpDateExpiration"
        Me.dtpDateExpiration.Size = New System.Drawing.Size(300, 31)
        Me.dtpDateExpiration.TabIndex = 13
        '
        'dtpDateDebut
        '
        Me.dtpDateDebut.Location = New System.Drawing.Point(620, 22)
        Me.dtpDateDebut.Name = "dtpDateDebut"
        Me.dtpDateDebut.Size = New System.Drawing.Size(300, 31)
        Me.dtpDateDebut.TabIndex = 12
        '
        'cboSexe
        '
        Me.cboSexe.FormattingEnabled = True
        Me.cboSexe.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.cboSexe.Location = New System.Drawing.Point(198, 80)
        Me.cboSexe.Name = "cboSexe"
        Me.cboSexe.Size = New System.Drawing.Size(236, 33)
        Me.cboSexe.TabIndex = 11
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(198, 142)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(236, 31)
        Me.txtUser.TabIndex = 9
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(198, 30)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(236, 31)
        Me.txtNom.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(463, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Statut:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(459, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date debut:"
        '
        'lblDateExpiration
        '
        Me.lblDateExpiration.AutoSize = True
        Me.lblDateExpiration.Location = New System.Drawing.Point(463, 88)
        Me.lblDateExpiration.Name = "lblDateExpiration"
        Me.lblDateExpiration.Size = New System.Drawing.Size(151, 25)
        Me.lblDateExpiration.TabIndex = 4
        Me.lblDateExpiration.Text = "Date d'expiration:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nom d'utilisateur:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mail:"
        '
        'cmdValider
        '
        Me.cmdValider.Location = New System.Drawing.Point(555, 336)
        Me.cmdValider.Name = "cmdValider"
        Me.cmdValider.Size = New System.Drawing.Size(112, 34)
        Me.cmdValider.TabIndex = 3
        Me.cmdValider.Text = "Valider"
        Me.cmdValider.UseVisualStyleBackColor = True
        '
        'cmdSuivant
        '
        Me.cmdSuivant.Location = New System.Drawing.Point(690, 336)
        Me.cmdSuivant.Name = "cmdSuivant"
        Me.cmdSuivant.Size = New System.Drawing.Size(112, 34)
        Me.cmdSuivant.TabIndex = 4
        Me.cmdSuivant.Text = "Suivant"
        Me.cmdSuivant.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Location = New System.Drawing.Point(837, 336)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(112, 34)
        Me.cmdAnnuler.TabIndex = 5
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Mot de passe:"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(620, 246)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(300, 31)
        Me.txtpassword.TabIndex = 20
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 382)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdSuivant)
        Me.Controls.Add(Me.cmdValider)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUser"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkLocked As CheckBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents dtpDateExpiration As DateTimePicker
    Friend WithEvents dtpDateDebut As DateTimePicker
    Friend WithEvents cboSexe As ComboBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDateExpiration As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdValider As Button
    Friend WithEvents cmdSuivant As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboGroup As ComboBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label8 As Label
End Class
