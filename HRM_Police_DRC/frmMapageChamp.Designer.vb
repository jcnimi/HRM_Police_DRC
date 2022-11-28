<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapageChamp
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnOuvrir = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.file = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.db = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(854, 423)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Champs"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.file, Me.db})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(827, 373)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnOuvrir)
        Me.GroupBox2.Controls.Add(Me.btnEnregistrer)
        Me.GroupBox2.Controls.Add(Me.btnAnnuler)
        Me.GroupBox2.Controls.Add(Me.btnValider)
        Me.GroupBox2.Location = New System.Drawing.Point(869, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 422)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnOuvrir
        '
        Me.btnOuvrir.Location = New System.Drawing.Point(31, 162)
        Me.btnOuvrir.Name = "btnOuvrir"
        Me.btnOuvrir.Size = New System.Drawing.Size(111, 45)
        Me.btnOuvrir.TabIndex = 3
        Me.btnOuvrir.Text = "Ouvrir"
        Me.btnOuvrir.UseVisualStyleBackColor = True
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Location = New System.Drawing.Point(31, 98)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(111, 45)
        Me.btnEnregistrer.TabIndex = 2
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(31, 227)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(111, 45)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Fermer"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(31, 35)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(111, 45)
        Me.btnValider.TabIndex = 0
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'file
        '
        Me.file.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.file.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.file.HeaderText = "Source"
        Me.file.MinimumWidth = 8
        Me.file.Name = "file"
        Me.file.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.file.Sorted = True
        Me.file.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.file.Width = 102
        '
        'db
        '
        Me.db.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.db.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.db.HeaderText = "Destination"
        Me.db.Items.AddRange(New Object() {"adresse", "autorite", "commissariat_recrutement", "date_expiration", "date_mariage_civil", "date_naissance", "date_recructement", "empreinte_droite", "empreinte_gauche", "entre_grade", "etat_civil", "fonction", "grade", "groupe_sanguin", "guid", "lieu_naissance", "matricule", "nom", "nom_conjoint", "photo", "photo_hash", "postnom", "prenom", "province_origine", "province_recrutement", "regroupement", "secteur_origine", "sexe", "sexe_conjoint", "signature", "status", "telephone1", "telephone2", "telephone3", "territoire_origine", "unite_agent"})
        Me.db.MinimumWidth = 8
        Me.db.Name = "db"
        Me.db.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.db.Sorted = True
        Me.db.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.db.Width = 138
        '
        'frmMapageChamp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1057, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMapageChamp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mapage des Champs"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnValider As Button
    Friend WithEvents btnOuvrir As Button
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents file As DataGridViewComboBoxColumn
    Friend WithEvents db As DataGridViewComboBoxColumn
End Class
