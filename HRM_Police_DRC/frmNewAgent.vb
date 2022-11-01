Public Class frmNewAgent
    Private formLoading = False
    Private Sub frmNewAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoading = True

        'loding list data on combo boxes
        Dim query As String
        'territoire
        cmbTerritoireOrigine.Items.Clear()
        query = "Select 0 value, 'Select' display union SELECT id_territoire as value, nom as display FROM [dbo].territoire"
        loadComboBox(cmbTerritoireOrigine, query)

        'Province d'origine
        query = "Select 0 value, 'Select' display union  SELECT id_province as value, nom as display FROM [dbo].province"
        loadComboBox(cmbProvOrigine, query)

        'Province de recrutement
        query = "Select 0 value, 'Select' display union  SELECT id_province as value, nom as display FROM [dbo].province"
        loadComboBox(cmbProvinceRecrutement, query)

        'Unité
        query = "Select 0 value, 'Select' display union  SELECT id_unite as value, description as display FROM [dbo].unite"
        loadComboBox(cmbUnite, query)

        'Grade
        query = "Select 0 value, 'Select' display union  SELECT id_grade as value, description as display FROM [dbo].grade"
        loadComboBox(cmbGrade, query)

        'Fonction
        query = "Select 0 value, 'Select' display union  SELECT id_fonction as value, description as display FROM [dbo].fonction"
        loadComboBox(cmbFonction, query)

        'Lieu de naissance
        query = "Select 0 value, 'Select' display union  SELECT id_lieu as value, nom as display FROM [dbo].lieu"
        loadComboBox(cmbLieuNaissance, query)

        'secteur
        query = "Select 0 value, 'Select' display union  SELECT id_secteur as value, nom as display FROM [dbo].secteur"
        loadComboBox(cmbSecteurOrigine, query)

        'village
        query = "Select 0 value, 'Select' display union  SELECT id_village as value, description as display FROM [dbo].village"
        loadComboBox(cmbVillage, query)


        dtDateNaisEnfant.Visible = False


        formLoading = False
    End Sub

    Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
        'Get the data from input controls
        Try
            Dim nom As String = txtNom.Text
            Dim postnom As String = txtPostnom.Text
            Dim prenom As String = txtPrenom.Text
            Dim matricule As String = maskMatric.Text
            Dim sexe As String = cmbSexe.Text
            Dim grade As String = cmbGrade.SelectedValue
            Dim lieu_naissance As String = cmbLieuNaissance.SelectedValue
            Dim territoire_origine As String = cmbTerritoireOrigine.SelectedValue
            Dim secteur_origine As String = cmbSecteurOrigine.SelectedValue
            Dim province_origine As String = cmbSecteurOrigine.SelectedValue
            Dim adresse As String = txtAdresse.Text
            Dim groupe_sanguin As String = cmbGroupeSanguin.Text
            Dim fonction As String = cmbFonction.SelectedValue
            Dim unite_agent As String = cmbUnite.SelectedValue
            Dim regroupement As String = cmbVillage.SelectedValue
            Dim date_naissance As String = dtDateNaissance.Text
            Dim etat_civil As String = cmbEtatCivil.Text
            Dim date_mariage_civil As String = dtDateMariageCivil.Text
            Dim sexe_conjoint As String = cmbSexeConjoint.Text
            Dim nom_conjoint As String = txtNomConjoint.Text
            Dim date_recructement As String = dtDateRecrutement.Text
            Dim date_expiration As String = dtDateExpiration.Text
            Dim entre_grade As String = dtDateEntreGrade.Text
            Dim province_recrutement As String = cmbProvinceRecrutement.SelectedValue
            Dim commissariat_recrutement As String = cmbCommissariatRecrutement.SelectedValue
            Dim telephone1 As String = maskTel1.Text
            Dim telephone2 As String = maskTel2.Text
            Dim telephone3 As String = maskTel3.Text

            Dim query As String = $"
        INSERT INTO [dbo].[agent]
           ([matricule]
           ,[nom]
           ,[postnom]
           ,[prenom]
           ,[sexe]
           ,[grade]
           ,[lieu_naissance]
           ,[territoire_origine]
           ,[secteur_origine]
           ,[province_origine]
           ,[adresse]
           ,[groupe_sanguin]
           ,[fonction]
           ,[unite_agent]
           ,[regroupement]
           ,[date_naissance]
           ,[phto]
           ,[empreinte_gauche]
           ,[empreinte_droite]
           ,[etat_civil]
           ,[date_mariage_civil]
           ,[sexe_conjoint]
           ,[nom_conjoint]
           ,[date_recructement]
           ,[date_expiration]
           ,[entre_grade]
           ,[province_recrutement]
           ,[cree_par]
           ,[commissariat_recrutement]
           ,[date_creation]
           ,[telephone1]
           ,[telephone2]
           ,[telephone3])
        VALUES
           ('{matricule}'
           ,'{nom}'
           ,'{postnom}'
           ,'{prenom}'
           ,'{sexe}'
           ,{grade}
           ,{lieu_naissance}
           ,{territoire_origine}
           ,{secteur_origine}
           ,{province_origine}
           ,'{adresse}'
           ,'{groupe_sanguin}'
           ,{fonction}
           ,{unite_agent}
           ,{regroupement}
           ,'{date_naissance}'
           ,null
           ,null
           ,null
           ,'{etat_civil}'
           ,'{date_mariage_civil}'
           ,'{sexe_conjoint}'
           ,'{nom_conjoint}'
           ,'{date_recructement}'
           ,'{date_expiration}'
           ,'{entre_grade}'
           ,{province_recrutement}
           ,{userId}
           ,{commissariat_recrutement}
           ,SYSDATETIME()
           ,'{telephone1}'
           ,'{telephone2}'
           ,'{telephone3}'
            )
        "
            'Get childs and save in the db
            Dim nomEnfant As String
            Dim sexeEnfant As String
            Dim dateNaissanceEnfant As String
            For Each Row As DataGridViewRow In gridEnfant.Rows
                nomEnfant = CStr(Row.Cells("Nom").Value)
                sexeEnfant = CStr(Row.Cells("Sexe").Value)
                dateNaissanceEnfant = CStr(Row.Cells("Date_naissance").Value)

                If nomEnfant <> "" AndAlso sexeEnfant <> "" AndAlso dateNaissanceEnfant <> "" Then
                    MessageBox.Show(nomEnfant + " " + sexeEnfant + " " + dateNaissanceEnfant)
                End If

            Next
        Catch ex As Exception
            MessageBox.Show("Error: ", ex.Message())
        End Try
    End Sub

    Private Sub cmbSexe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSexe.SelectedIndexChanged
        If cmbSexe.Text = "Homme" Then
            cmbSexeConjoint.Text = "Femme"
        End If

        If cmbSexe.Text = "Femme" Then
            cmbSexeConjoint.Text = "Homme"
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'ajouter unité
        Dim frm As New frmUniteAgent
        frm.ShowDialog()
        'update unite list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_unite as value, description as display FROM [dbo].unite"
        loadComboBox(cmbUnite, query)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'ajouter grade
        Dim frm As New frmGrade
        frm.ShowDialog()
        'update grade list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_grade as value, description as display FROM [dbo].grade"
        loadComboBox(cmbGrade, query)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'ajouter fonction
        Dim frm As New frmFonction
        frm.ShowDialog()
        'update fonction list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_fonction as value, description as display FROM [dbo].fonction"
        loadComboBox(cmbFonction, query)
    End Sub

    'user selected
    Private Sub cmbTerritoireOrigine_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTerritoireOrigine.SelectionChangeCommitted

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'ajouter lieu de naissance
        Dim frm As New frmLieu
        frm.ShowDialog()
        'update fonction list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_lieu as value, nom as display FROM [dbo].lieu"
        loadComboBox(cmbLieuNaissance, query)
    End Sub

    Private Sub cmbTerritoireOrigine_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTerritoireOrigine.SelectedValueChanged
        If formLoading = True Then
            Exit Sub
        End If

        Try
            Dim id As String
            Dim province As String
            Dim territoire = cmbTerritoireOrigine.SelectedValue
            'get from the db the province name
            Dim query As String = $"
            select id_province, province
            from territoire 
            where id_territoire = '{territoire}'
            "
            Using reader As SqlDataReader = getData(query)
                If reader.HasRows Then
                    reader.Read()
                    id = reader("id_province")
                    province = reader("province")
                Else
                    id = 0
                End If
            End Using
            cmbProvOrigine.SelectedValue = id
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message())
        End Try
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        'ajouter secteur
        Dim frm As New frmSecteur
        frm.ShowDialog()
        'update fonction list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_secteur as value, nom as display FROM [dbo].secteur"
        loadComboBox(cmbSecteurOrigine, query)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        'ajouter village
        Dim frm As New frmVillageorigine
        frm.ShowDialog()
        'update fonction list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_village as value, description as display FROM [dbo].village"
        loadComboBox(cmbVillage, query)
    End Sub

    Private Sub cmbVillage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVillage.SelectedIndexChanged
        If formLoading = True Then
            Exit Sub
        End If
        Try
            Dim secteur As String
            Dim village = cmbVillage.SelectedValue
            '
            Dim query As String = $"
            select secteur
            from village 
            where id_village = {village}
            "
            Using reader As SqlDataReader = getData(query)
                If reader.HasRows Then
                    reader.Read()
                    'id = reader("id_village")
                    secteur = reader("secteur")
                Else
                    secteur = 0
                End If
            End Using
            cmbSecteurOrigine.SelectedValue = secteur
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message())
        End Try
    End Sub

    Private Sub cmbSecteurOrigine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecteurOrigine.SelectedIndexChanged
        If formLoading = True Then
            Exit Sub
        End If

        Try
            Dim territoire As String
            Dim secteur = cmbSecteurOrigine.SelectedValue
            'get from the db the province name
            Dim query As String = $"
            select id_territoire
            from secteur 
            where id_secteur = {secteur}
            "
            Using reader As SqlDataReader = getData(query)
                If reader.HasRows Then
                    reader.Read()
                    territoire = reader("id_territoire")
                Else
                    territoire = 0
                End If
            End Using
            cmbTerritoireOrigine.SelectedValue = territoire
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message())
        End Try

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        'ajouter commissariat
        Dim frm As New frmCommissariat
        frm.ShowDialog()
        'update fonction list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_commissariat as value, description as display FROM [dbo].commissariat"
        loadComboBox(cmbCommissariatRecrutement, query)
    End Sub

    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        Me.Close()
    End Sub

    Private Sub gridEnfant_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridEnfant.CellClick
        If e.ColumnIndex = 2 Then 'CHECK IF IT IS THE RIGHT COLUMN

            'SET SIZE AND LOCATION
            Dim rect = gridEnfant.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            dtDateNaisEnfant.Size = New Size(rect.Width, rect.Height)
            dtDateNaisEnfant.Location = New Point(rect.X + 9, rect.Y + 157) 'USE YOU OFFSET HERE

            dtDateNaisEnfant.Visible = True
            ActiveControl = dtDateNaisEnfant

        End If
    End Sub

    Private Sub dtDateNaisEnfant_ValueChanged(sender As Object, e As EventArgs) Handles dtDateNaisEnfant.ValueChanged
        If gridEnfant.RowCount > 0 Then 'JUST TO AVOID FORM LOAD CRASH

            gridEnfant.CurrentCell.Value = dtDateNaisEnfant.Value.ToShortDateString
            dtDateNaisEnfant.Visible = False

        End If
    End Sub
End Class