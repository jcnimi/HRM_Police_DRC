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
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(671, 187)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(434, 148)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(211, 23)
        Me.txtpassword.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 148)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Mot de passe:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Groupe:"
        '
        'cboGroup
        '
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(434, 80)
        Me.cboGroup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(211, 23)
        Me.cboGroup.TabIndex = 17
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(139, 118)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(166, 23)
        Me.txtMail.TabIndex = 16
        '
        'chkLocked
        '
        Me.chkLocked.AutoSize = True
        Me.chkLocked.Location = New System.Drawing.Point(26, 153)
        Me.chkLocked.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkLocked.Name = "chkLocked"
        Me.chkLocked.Size = New System.Drawing.Size(71, 19)
        Me.chkLocked.TabIndex = 15
        Me.chkLocked.Text = "Verouillé"
        Me.chkLocked.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Actif", "Inactif"})
        Me.cboStatus.Location = New System.Drawing.Point(434, 113)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(211, 23)
        Me.cboStatus.TabIndex = 14
        '
        'dtpDateExpiration
        '
        Me.dtpDateExpiration.Location = New System.Drawing.Point(434, 49)
        Me.dtpDateExpiration.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpDateExpiration.Name = "dtpDateExpiration"
        Me.dtpDateExpiration.Size = New System.Drawing.Size(211, 23)
        Me.dtpDateExpiration.TabIndex = 13
        '
        'dtpDateDebut
        '
        Me.dtpDateDebut.Location = New System.Drawing.Point(434, 13)
        Me.dtpDateDebut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpDateDebut.Name = "dtpDateDebut"
        Me.dtpDateDebut.Size = New System.Drawing.Size(211, 23)
        Me.dtpDateDebut.TabIndex = 12
        '
        'cboSexe
        '
        Me.cboSexe.FormattingEnabled = True
        Me.cboSexe.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.cboSexe.Location = New System.Drawing.Point(139, 48)
        Me.cboSexe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboSexe.Name = "cboSexe"
        Me.cboSexe.Size = New System.Drawing.Size(166, 23)
        Me.cboSexe.TabIndex = 11
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(139, 85)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(166, 23)
        Me.txtUser.TabIndex = 9
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(139, 18)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(166, 23)
        Me.txtNom.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 118)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Statut:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date debut:"
        '
        'lblDateExpiration
        '
        Me.lblDateExpiration.AutoSize = True
        Me.lblDateExpiration.Location = New System.Drawing.Point(324, 53)
        Me.lblDateExpiration.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateExpiration.Name = "lblDateExpiration"
        Me.lblDateExpiration.Size = New System.Drawing.Size(100, 15)
        Me.lblDateExpiration.TabIndex = 4
        Me.lblDateExpiration.Text = "Date d'expiration:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nom d'utilisateur:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mail:"
        '
        'cmdValider
        '
        Me.cmdValider.Location = New System.Drawing.Point(388, 202)
        Me.cmdValider.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdValider.Name = "cmdValider"
        Me.cmdValider.Size = New System.Drawing.Size(78, 20)
        Me.cmdValider.TabIndex = 3
        Me.cmdValider.Text = "Valider"
        Me.cmdValider.UseVisualStyleBackColor = True
        '
        'cmdSuivant
        '
        Me.cmdSuivant.Location = New System.Drawing.Point(483, 202)
        Me.cmdSuivant.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdSuivant.Name = "cmdSuivant"
        Me.cmdSuivant.Size = New System.Drawing.Size(78, 20)
        Me.cmdSuivant.TabIndex = 4
        Me.cmdSuivant.Text = "Suivant"
        Me.cmdSuivant.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Location = New System.Drawing.Point(586, 202)
        Me.cmdAnnuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(78, 20)
        Me.cmdAnnuler.TabIndex = 5
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(680, 229)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdSuivant)
        Me.Controls.Add(Me.cmdValider)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
