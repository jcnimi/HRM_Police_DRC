Public Class frmNewAgent
    Private formLoading = False
    Private dateNaissanceAgent As String = ""
    Private dateMariageCivilAgent As String = ""
    Private dateRecructementAgent As String = ""
    Private dateExpirationAgent As String = ""
    Private dateEntreGradeAgent As String = ""
    Private telephone1 As String = ""
    Private telephone2 As String = ""
    Private telephone3 As String = ""
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

        'Commissariat de recrutement
        query = "Select 0 value, 'Select' display union  SELECT id_commissariat as value, description as display FROM [dbo].commissariat"
        loadComboBox(cmbCommissariatRecrutement, query)

        dtDateNaisEnfant.Visible = False

        'default value for some combo box
        cmbSexe.Text = "Select"
        cmbGroupeSanguin.Text = "Select"
        cmbEtatCivil.Text = "Select"
        cmbSexeConjoint.Text = "Select"

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
            Dim province_origine As String = cmbProvOrigine.SelectedValue
            Dim adresse As String = txtAdresse.Text
            Dim groupe_sanguin As String = cmbGroupeSanguin.Text
            Dim fonction As String = cmbFonction.SelectedValue
            Dim unite_agent As String = cmbUnite.SelectedValue
            Dim regroupement As String = cmbVillage.SelectedValue
            Dim etat_civil As String = cmbEtatCivil.Text
            Dim sexe_conjoint As String = cmbSexeConjoint.Text
            Dim nom_conjoint As String = txtNomConjoint.Text
            Dim province_recrutement As String = cmbProvinceRecrutement.SelectedValue
            Dim commissariat_recrutement As String = cmbCommissariatRecrutement.SelectedValue

            'Make sure that all the mandatory fields are filled
            If nom = "" Then
                MessageBox.Show("Le nom est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If postnom = "" Then
                MessageBox.Show("Le postnom est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If prenom = "" Then
                MessageBox.Show("Le prenom est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If matricule = "" Then
                MessageBox.Show("Le matricule est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If sexe = "Select" Then
                MessageBox.Show("Le choix du sexe est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If unite_agent = 0 Then
                MessageBox.Show("Le choix de l'unité est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If grade = 0 Then
                MessageBox.Show("Le choix du grade est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If adresse = "" Then
                MessageBox.Show("L'adresse est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dateNaissanceAgent = "" Then
                MessageBox.Show("La date de naissance est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If lieu_naissance = 0 Then
                MessageBox.Show("Le  choix du lieu de naissance est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If regroupement = 0 Then
                MessageBox.Show("Le choix du village d'origine est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If secteur_origine = 0 Then
                MessageBox.Show("Le choix du secteur d'origine est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If territoire_origine = 0 Then
                MessageBox.Show("Le choix du territoire d'origine est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If province_origine = 0 Then
                MessageBox.Show("Le choix de la province d'origine est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If telephone1 = "" Then
                MessageBox.Show("Au moins un numero de téléphone est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If etat_civil = "Select" Then
                MessageBox.Show("Le choix de l'etat civil est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dateRecructementAgent = "" Then
                MessageBox.Show("La date de recrutement est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If province_recrutement = 0 Then
                MessageBox.Show("La choix de la province de recutement est obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


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
           ,'{If(groupe_sanguin = "Select", Nothing, groupe_sanguin)}'     
           ,{If(fonction = "0", Nothing, fonction)}  
           ,{unite_agent}
           ,{regroupement}
           ,'{dateNaissanceAgent}'
           ,'{etat_civil}'
           ,'{If(dateMariageCivilAgent = "", Nothing, dateMariageCivilAgent)}' 
           ,'{If(sexe_conjoint = "Select", Nothing, sexe_conjoint)}'
           ,'{nom_conjoint}'
           ,'{dateRecructementAgent}'
           ,'{If(dateExpirationAgent = "", Nothing, dateExpirationAgent)}' 
           ,'{If(dateEntreGradeAgent = "", Nothing, dateEntreGradeAgent)}' 
           ,{province_recrutement}
           ,{userId}
           ,{If(commissariat_recrutement = "0", Nothing, commissariat_recrutement)} 
           ,SYSDATETIME()
           ,'{telephone1}'
           ,'{If(telephone2 = "", Nothing, telephone2)}' 
           ,'{If(telephone3 = "", Nothing, telephone3)}' 
            )
            "
            'add agent
            insertData(query)

            'Get childs from datagridview and save in the db
            Dim nomEnfant As String
            Dim sexeEnfant As String
            Dim dateNaissanceEnfant As String
            For Each Row As DataGridViewRow In gridEnfant.Rows
                nomEnfant = CStr(Row.Cells("Nom").Value)
                sexeEnfant = CStr(Row.Cells("Sexe").Value)
                dateNaissanceEnfant = CStr(Row.Cells("Date_naissance").Value)

                'Get the agent id from the db
                Dim id As String = ""
                Try
                    'get from the db the province name
                    Dim queryID As String = $"
                    select id_agent
                    from agent 
                    where matricule = '{matricule}'
                    "
                    Using reader As SqlDataReader = getData(query)
                        If reader.HasRows Then
                            reader.Read()
                            id = reader("id_agent")
                        Else
                            MessageBox.Show("Erreur en tentant d'inserer les enfants ")
                            Exit Sub
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Erreur: " + ex.Message())
                End Try

                Dim queryEnfant = $"
                    INSERT INTO [dbo].[enfant]
                   ([nom]
                   ,[sexe]
                   ,[date_naissance]
                   ,[id_agent]
                   ,[cree_par]
                   ,[date_creation])
                    VALUES
                   ('{nomEnfant}'
                   ,'{sexeEnfant}'
                   ,'{dateNaissanceEnfant}'
                   ,{id}
                   ,{userId}
                   ,SYSDATETIME()
                   )
                "

                insertData(queryEnfant)
            Next
            MessageBox.Show("Enregistrement effectué avec succès")
        Catch ex As Exception
            MessageBox.Show("Error: ", ex.Message())
        End Try
    End Sub

    Private Sub cmbSexe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSexe.SelectedIndexChanged
        If cmbSexe.Text = "Homme" Then
            cmbSexeConjoint.Text = "Femme"
        ElseIf cmbSexe.Text = "Femme" Then
            cmbSexeConjoint.Text = "Homme"
        Else
            cmbSexeConjoint.Text = "Select"
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
            gridEnfant.CurrentCell.Value = dtDateNaisEnfant.Value.ToString("MM/dd/yyyy")
            dtDateNaisEnfant.Visible = False
        End If
    End Sub

    Private Sub dtDateNaissance_ValueChanged(sender As Object, e As EventArgs) Handles dtDateNaissance.ValueChanged
        dateNaissanceAgent = dtDateNaissance.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub dtDateMariageCivil_ValueChanged(sender As Object, e As EventArgs) Handles dtDateMariageCivil.ValueChanged
        dateMariageCivilAgent = dtDateMariageCivil.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub dtDateRecrutement_ValueChanged(sender As Object, e As EventArgs) Handles dtDateRecrutement.ValueChanged
        dateRecructementAgent = dtDateRecrutement.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub dtDateExpiration_ValueChanged(sender As Object, e As EventArgs) Handles dtDateExpiration.ValueChanged
        dateExpirationAgent = dtDateExpiration.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub dtDateEntreGrade_ValueChanged(sender As Object, e As EventArgs) Handles dtDateEntreGrade.ValueChanged
        dateEntreGradeAgent = dtDateEntreGrade.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub cmbEtatCivil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEtatCivil.SelectedIndexChanged
        If cmbEtatCivil.Text = "Celibataire" Then
            'desable nom conjoin and sexe conjoint
            txtNomConjoint.Text = ""
            txtNomConjoint.Enabled = False
            cmbSexeConjoint.Text = "Select"
            dtDateMariageCivil.Enabled = False
        Else
            txtNomConjoint.Enabled = True
            dtDateMariageCivil.Enabled = True
        End If
    End Sub

    Private Sub maskTel1_TextChanged(sender As Object, e As EventArgs) Handles maskTel1.TextChanged
        If maskTel1.MaskCompleted Then
            telephone1 = maskTel1.Text
        End If
    End Sub

    Private Sub maskTel2_TextChanged(sender As Object, e As EventArgs) Handles maskTel2.TextChanged
        If maskTel2.MaskCompleted Then
            telephone2 = maskTel2.Text
        End If
    End Sub

    Private Sub maskTel3_TextChanged(sender As Object, e As EventArgs) Handles maskTel3.TextChanged
        If maskTel3.MaskCompleted Then
            telephone3 = maskTel3.Text
        End If
    End Sub

    Private Sub btnWebCam_Click(sender As Object, e As EventArgs) Handles btnWebCam.Click
        Dim frm As New frmImageWebCam()
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmWebcam()
        frm.ShowDialog()
    End Sub
End Class