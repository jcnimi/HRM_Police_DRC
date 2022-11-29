<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministration))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picAuthorite = New System.Windows.Forms.PictureBox()
        Me.picUsers = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picAuthorite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picAuthorite)
        Me.GroupBox1.Controls.Add(Me.picUsers)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administration du système"
        '
        'picAuthorite
        '
        Me.picAuthorite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picAuthorite.Image = Global.HRM_Police_DRC.My.Resources.Resources.authorite1
        Me.picAuthorite.Location = New System.Drawing.Point(222, 44)
        Me.picAuthorite.Name = "picAuthorite"
        Me.picAuthorite.Size = New System.Drawing.Size(180, 184)
        Me.picAuthorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAuthorite.TabIndex = 1
        Me.picAuthorite.TabStop = False
        '
        'picUsers
        '
        Me.picUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picUsers.Image = CType(resources.GetObject("picUsers.Image"), System.Drawing.Image)
        Me.picUsers.Location = New System.Drawing.Point(19, 47)
        Me.picUsers.Name = "picUsers"
        Me.picUsers.Size = New System.Drawing.Size(178, 181)
        Me.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsers.TabIndex = 0
        Me.picUsers.TabStop = False
        '
        'frmAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(777, 295)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdministration"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametres"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picAuthorite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picUsers As PictureBox
    Friend WithEvents picAuthorite As PictureBox
End Class
