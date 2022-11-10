Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports STPadCaptLib


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
    Public matriculeAgent As String = ""
    Public isUpdating As Boolean = False
    Private idAgent As String
    Private Sub frmNewAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoading = True  'avoid cascade update of territoire, secteur, etc to happen 
        'when loading the form

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

        'tooltip
        Dim tt As New ToolTip()
        tt.SetToolTip(picAddFonction, "Ajouter une nouvelle fonction")
        tt.SetToolTip(picAddGrade, "Ajouter un nouveau grade")
        tt.SetToolTip(picAddLieu, "Ajouter un nouveau lieu de naissance")
        tt.SetToolTip(picAddSecteur, "Ajouter un nouveau secteur")
        tt.SetToolTip(picAddUnite, "Ajouter une nouvelle unité")
        tt.SetToolTip(picAddVillage, "Ajouter un nouveau village")
        tt.SetToolTip(picAddCommissariat, "Ajouter un nouveau commissariat")


        If isUpdating = True Then
            Dim dateNaissance As String
            Dim dateMariageCivil As String
            Dim dateRecrutement As String
            Dim dateExpiration As String
            Dim dateGrade As String

            btnSuivant.Enabled = False
            'load the agent data
            query = $"
              SELECT *
              FROM [dbo].[agent]
              WHERE matricule = '{matriculeAgent}'
            "
            Try
                Using reader As SqlDataReader = getData(query)
                    If reader.HasRows Then
                        reader.Read()
                        idAgent = reader("id_agent").ToString
                        'texts
                        maskMatric.Text = matriculeAgent
                        txtNom.Text = reader("nom").ToString
                        txtPostnom.Text = reader("postnom").ToString
                        txtPrenom.Text = reader("prenom").ToString
                        txtAdresse.Text = reader("adresse").ToString
                        txtNomConjoint.Text = reader("nom_conjoint").ToString
                        'lists
                        cmbSexe.Text = reader("sexe").ToString
                        cmbUnite.SelectedValue = reader("unite_agent")
                        cmbCommissariatRecrutement.SelectedValue = reader("commissariat_recrutement").ToString
                        cmbEtatCivil.Text = reader("etat_civil").ToString
                        cmbFonction.SelectedValue = reader("fonction").ToString
                        cmbGrade.SelectedValue = reader("grade").ToString
                        cmbGroupeSanguin.Text = reader("groupe_sanguin").ToString
                        cmbLieuNaissance.SelectedValue = reader("lieu_naissance").ToString
                        cmbProvinceRecrutement.SelectedValue = reader("province_recrutement").ToString
                        cmbProvOrigine.SelectedValue = reader("province_origine").ToString
                        cmbSecteurOrigine.SelectedValue = reader("secteur_origine").ToString
                        cmbSexeConjoint.Text = reader("sexe_conjoint").ToString
                        cmbTerritoireOrigine.SelectedValue = reader("territoire_origine").ToString
                        cmbVillage.SelectedValue = reader("regroupement").ToString

                        'dates
                        'Date de naissance
                        dateNaissance = reader("date_naissance").ToString
                        If IsDate(dateNaissance) Then
                            dtDateNaissance.Value = dateNaissance
                        End If

                        'Date mariage civil
                        dateMariageCivil = reader("date_mariage_civil").ToString
                        If IsDate(dateMariageCivil) Then
                            dtDateMariageCivil.Value = dateMariageCivil
                        End If

                        'Date recrutement
                        dateRecrutement = reader("date_recructement").ToString
                        If IsDate(dateRecrutement) Then
                            dtDateRecrutement.Value = dateRecrutement
                        End If

                        'Date expiration
                        dateExpiration = reader("date_expiration").ToString
                        If IsDate(dateExpiration) Then
                            dtDateExpiration.Value = dateExpiration
                        End If

                        'Date entré en grade
                        dateGrade = reader("entre_grade").ToString
                        If IsDate(dateGrade) Then
                            dtDateEntreGrade.Value = dateGrade
                        End If

                        'photo, signature, fingerprints
                        'photo
                        If Not reader.IsDBNull("photo") Then
                            Using ms As New IO.MemoryStream(CType(reader("photo"), Byte()))
                                Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                                picPhoto.Image = img
                            End Using
                        End If

                        'signature
                        If Not reader.IsDBNull("signature") Then
                            Using ms As New IO.MemoryStream(CType(reader("signature"), Byte()))
                                Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                                picSignature.Image = img
                            End Using
                        End If


                        'fingerprint left
                        If Not reader.IsDBNull("empreinte_gauche") Then
                            Using ms As New IO.MemoryStream(CType(reader("empreinte_gauche"), Byte()))
                                Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                                picfingerprintL.Image = img
                            End Using
                        End If

                        'fingerprint right
                        If Not reader.IsDBNull("empreinte_droite") Then
                            Using ms As New IO.MemoryStream(CType(reader("empreinte_droite"), Byte()))
                                Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                                picFingerprintR.Image = img
                            End Using
                        End If

                        'maskedit
                        maskTel1.Text = reader("telephone1").ToString
                        maskTel2.Text = reader("telephone2").ToString
                        maskTel3.Text = reader("telephone3").ToString
                    End If
                End Using
                'load childs
                query = $"
                SELECT *
                FROM [dbo].[enfant]
                WHERE id_agent = '{idAgent}'
                "
                Using reader As SqlDataReader = getData(query)
                    If reader.HasRows Then
                        While reader.Read()
                            Dim nom As String = reader("nom")
                            Dim sexe As String = reader("sexe")
                            Dim id As String = reader("id_enfant")
                            Dim datenaissanceEnfant As String = reader("date_naissance")
                            Dim row As String() = New String() {$"{nom}", $"{sexe}", $"{datenaissanceEnfant}", $"{id}"}
                            gridEnfant.Rows.Add(row)
                        End While
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error :" + ex.Message)
            End Try
        End If
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
                cmbProvinceRecrutement.Select()
                Exit Sub
            End If

            'Checking data quality
            'birth date at least 18 years old
            Dim now = Date.Now()
            Dim span = now - Date.Parse(dateNaissanceAgent)
            If (span.TotalDays \ 365) < 18 Then
                MessageBox.Show("L'agent doit avoir au moins 18 ans, Veuillez corriger la date de naissance", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtDateNaissance.Select()
                Exit Sub
            End If



            Dim queryInsert As String = $"
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
           ,[telephone3]
           ,photo
           ,[signature]
           ,[empreinte_gauche]
           ,[empreinte_droite])
            VALUES
           ('{matricule}'
           ,'{nom}'
           ,'{postnom}'
           ,'{prenom}'
           ,'{sexe}'
           ,'{grade}'
           ,'{lieu_naissance}'
           ,'{territoire_origine}'
           ,'{secteur_origine}'
           ,'{province_origine}'
           ,'{adresse}'
           ,'{If(groupe_sanguin = "Select", Nothing, groupe_sanguin)}'     
           ,'{If(fonction = "0", Nothing, fonction)}'
           ,'{unite_agent}'
           ,'{regroupement}'
           ,'{dateNaissanceAgent}'
           ,'{etat_civil}'
           ,'{If(dateMariageCivilAgent = "", Nothing, dateMariageCivilAgent)}' 
           ,'{If(sexe_conjoint = "Select", Nothing, sexe_conjoint)}'
           ,'{nom_conjoint}'
           ,'{dateRecructementAgent}'
           ,'{If(dateExpirationAgent = "", Nothing, dateExpirationAgent)}' 
           ,'{If(dateEntreGradeAgent = "", Nothing, dateEntreGradeAgent)}' 
           ,'{province_recrutement}'
           ,{userId}
           ,'{If(commissariat_recrutement = "0", Nothing, commissariat_recrutement)}' 
           ,SYSDATETIME()
           ,'{telephone1}'
           ,'{If(telephone2 = "", Nothing, telephone2)}' 
           ,'{If(telephone3 = "", Nothing, telephone3)}' 
           ,@photo
           ,@signature
           ,@lfingerp
           ,@rfingerp
            )
            "

            Dim queryUpdate As String = $"
            UPDATE [dbo].[agent]
               SET [matricule] = '{matricule}'
                  ,[nom] = '{nom}'
                  ,[postnom] = '{postnom}'
                  ,[prenom] = '{prenom}'
                  ,[sexe] = '{sexe}'
                  ,[grade] = '{grade}'
                  ,[lieu_naissance] = '{lieu_naissance}'
                  ,[territoire_origine] = '{territoire_origine}'
                  ,[secteur_origine] = '{secteur_origine}'
                  ,[province_origine] = '{province_origine}'
                  ,[adresse] = '{adresse}'
                  ,[groupe_sanguin] = '{If(groupe_sanguin = "Select", Nothing, groupe_sanguin)}'
                  ,[fonction] = '{If(fonction = "0", Nothing, fonction)}'
                  ,[unite_agent] = '{unite_agent}'
                  ,[regroupement] = '{regroupement}'
                  ,[date_naissance] = '{dateNaissanceAgent}'
                  ,[photo] = @photo
                  ,[empreinte_gauche] = @lfingerp
                  ,[empreinte_droite] = @rfingerp
                  ,[signature] = @signature
                  ,[etat_civil] = '{etat_civil}'
                  ,[date_mariage_civil] = '{If(dateMariageCivilAgent = "", Nothing, dateMariageCivilAgent)}' 
                  ,[sexe_conjoint] = '{If(sexe_conjoint = "Select", Nothing, sexe_conjoint)}'
                  ,[nom_conjoint] = '{nom_conjoint}'
                  ,[date_recructement] = '{dateRecructementAgent}'
                  ,[date_expiration] = '{If(dateExpirationAgent = "", Nothing, dateExpirationAgent)}'
                  ,[entre_grade] = '{If(dateEntreGradeAgent = "", Nothing, dateEntreGradeAgent)}' 
                  ,[province_recrutement] = '{province_recrutement}'
                  ,[commissariat_recrutement] = '{If(commissariat_recrutement = "0", Nothing, commissariat_recrutement)}'
                  ,[telephone1] = '{telephone1}'
                  ,[telephone2] = '{If(telephone2 = "", Nothing, telephone2)}' 
                  ,[telephone3] = '{If(telephone3 = "", Nothing, telephone3)}' 
             WHERE [id_agent] = {idAgent}
            "

            Dim im1 As Image
            Dim ms As System.IO.MemoryStream
            Dim md As Byte()
            Dim param As SqlParameter
            Dim listParams As New Generic.List(Of SqlParameter)

            'add the photo
            If picPhoto.Image IsNot Nothing Then
                im1 = picPhoto.Image
                ms = New System.IO.MemoryStream()
                im1.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                md = ms.GetBuffer()
                param = New SqlParameter("@photo", SqlDbType.Image)
                param.Value = md
                listParams.Add(param)
            Else
                param = New SqlParameter("@photo", SqlDbType.Image)
                param.Value = System.DBNull.Value
                listParams.Add(param)
            End If

            'add signature
            If picSignature.Image IsNot Nothing Then
                im1 = picSignature.Image
                ms = New System.IO.MemoryStream
                im1.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                md = ms.GetBuffer
                param = New SqlParameter("@signature", SqlDbType.Image)
                param.Value = md
                listParams.Add(param)
            Else
                param = New SqlParameter("@signature", SqlDbType.Image)
                param.Value = System.DBNull.Value
                listParams.Add(param)
            End If

            'add left fingerprint
            If picfingerprintL.Image IsNot Nothing Then
                im1 = picfingerprintL.Image
                ms = New System.IO.MemoryStream
                im1.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                md = ms.GetBuffer
                param = New SqlParameter("@lfingerp", SqlDbType.Image)
                param.Value = md
                listParams.Add(param)
            Else
                param = New SqlParameter("@lfingerp", SqlDbType.Image)
                param.Value = System.DBNull.Value
                listParams.Add(param)
            End If

            'add right fingerprint
            If picFingerprintR.Image IsNot Nothing Then
                im1 = picFingerprintR.Image
                ms = New System.IO.MemoryStream
                im1.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                md = ms.GetBuffer
                param = New SqlParameter("@rfingerp", SqlDbType.Image)
                param.Value = md
                listParams.Add(param)
            Else
                param = New SqlParameter("@rfingerp", SqlDbType.Image)
                param.Value = System.DBNull.Value
                listParams.Add(param)
            End If

            'add or update agent
            If isUpdating = False Then
                saveData(queryInsert, listParams)
            Else
                saveData(queryUpdate, listParams)
            End If

            'Get childs from datagridview and save in the db
            Dim idEnfant As String
            Dim nomEnfant As String
            Dim sexeEnfant As String
            Dim dateNaissanceEnfant As String
            Dim id As String = ""

            If isUpdating = False Then
                'get from the db the id of the agent
                Dim queryID As String = $"
                    select id_agent
                    from agent 
                    where matricule = '{matricule}'
                    "
                Using reader As SqlDataReader = getData(queryID)
                    If reader.HasRows Then
                        reader.Read()
                        idAgent = reader("id_agent")
                    Else
                        MessageBox.Show("Erreur de lecture de données dans la base de données")
                        Exit Sub
                    End If
                End Using
            End If

            'Processing childs from datagridview
            For Each Row As DataGridViewRow In gridEnfant.Rows
                idEnfant = CStr(Row.Cells("id").Value)
                nomEnfant = CStr(Row.Cells("Nom").Value)
                sexeEnfant = CStr(Row.Cells("Sexe").Value)
                dateNaissanceEnfant = CStr(Row.Cells("Date_naissance").Value)

                Dim queryEnfantInsert = $"
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
                   ,{idAgent}
                   ,{userId}
                   ,SYSDATETIME()
                   )
                "

                Dim queryEnfantUpdate = $"
                update [dbo].[enfant]
                SET [nom] = '{nomEnfant}'
                   ,[sexe] = '{sexeEnfant}'
                   ,[date_naissance] = '{dateNaissanceEnfant}'
                WHERE ID_ENFANT = {idEnfant}
                "

                If isUpdating = False Then
                    saveData(queryEnfantInsert)
                Else
                    saveData(queryEnfantUpdate)
                End If
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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picAddUnite.Click
        'ajouter unité
        Dim frm As New frmUniteAgent
        frm.ShowDialog()
        'update unite list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_unite as value, description as display FROM [dbo].unite"
        loadComboBox(cmbUnite, query)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles picAddGrade.Click
        'ajouter grade
        Dim frm As New frmGrade
        frm.ShowDialog()
        'update grade list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_grade as value, description as display FROM [dbo].grade"
        loadComboBox(cmbGrade, query)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles picAddFonction.Click
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

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles picAddLieu.Click
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

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles picAddSecteur.Click
        'ajouter secteur
        Dim frm As New frmSecteur
        frm.ShowDialog()
        'update fonction list
        Dim query As String = "Select 0 value, 'Select' display union  SELECT id_secteur as value, nom as display FROM [dbo].secteur"
        loadComboBox(cmbSecteurOrigine, query)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles picAddVillage.Click
        'ajouter village
        Dim frm As New frmVillageorigine
        frm.ShowDialog()
        If frm.isCancelled = False Then
            'update fonction list
            Dim query As String = "Select 0 value, 'Select' display union  SELECT id_village as value, description as display FROM [dbo].village"
            loadComboBox(cmbVillage, query)
        End If
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
                If reader IsNot Nothing AndAlso reader.HasRows Then
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

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles picAddCommissariat.Click
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
            dtDateNaisEnfant.Parent = GroupBox2
            'SET SIZE AND LOCATION
            Dim rect = gridEnfant.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            dtDateNaisEnfant.Size = New Size(rect.Width, rect.Height)
            dtDateNaisEnfant.Location = New Point(rect.X, rect.Y + 18) 'USE YOU OFFSET HERE
            dtDateNaisEnfant.BringToFront()
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
        Dim frm As New frmWebcam()
        frm.ShowDialog()
        picPhoto.Image = frm.PictureBox1.Image
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png"
            .Title = "Ouvrir une image"
            .ShowDialog()
        End With
        If OpenFileDialog1.FileName <> "" Then
            picPhoto.Image = New Bitmap(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub picAddUnite_MouseHover(sender As Object, e As EventArgs) Handles picAddUnite.MouseHover,
        picAddFonction.MouseHover, picAddGrade.MouseHover, picAddCommissariat.MouseHover,
        picAddLieu.MouseHover, picAddSecteur.MouseHover, picAddVillage.MouseHover
        Dim pic As PictureBox = DirectCast(sender, PictureBox)
        pic.Image = My.Resources.add2
    End Sub

    Private Sub picAddUnite_MouseLeave(sender As Object, e As EventArgs) Handles picAddUnite.MouseLeave,
        picAddFonction.MouseLeave, picAddGrade.MouseLeave, picAddCommissariat.MouseLeave,
        picAddLieu.MouseLeave, picAddSecteur.MouseLeave, picAddVillage.MouseLeave
        Dim pic As PictureBox = DirectCast(sender, PictureBox)
        pic.Image = My.Resources.add
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MyComputer = New Microsoft.VisualBasic.Devices.Computer
        Dim grabpicture As System.Drawing.Image
        grabpicture = MyComputer.Clipboard.GetImage()
        picSignature.Image = grabpicture
    End Sub

    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click
        txtAdresse.Text = ""
        txtNom.Text = ""
        txtNomConjoint.Text = ""
        txtPostnom.Text = ""
        txtPrenom.Text = ""
        cmbCommissariatRecrutement.SelectedValue = 0
        cmbEtatCivil.Text = "Select"
        cmbFonction.SelectedValue = 0
        cmbGrade.SelectedValue = 0
        cmbGroupeSanguin.Text = "Select"
        cmbLieuNaissance.SelectedValue = 0
        cmbProvinceRecrutement.SelectedValue = 0
        cmbProvOrigine.SelectedValue = 0
        cmbSecteurOrigine.SelectedValue = 0
        cmbSexe.Text = "Select"
        cmbSexeConjoint.Text = "Select"
        cmbTerritoireOrigine.SelectedValue = 0
        cmbUnite.SelectedValue = 0
        cmbVillage.SelectedValue = 0
        maskMatric.ResetText()
        maskTel1.ResetText()
        maskTel2.ResetText()
        maskTel3.ResetText()
        gridEnfant.Rows.Clear()
        dtDateEntreGrade.ResetText()
        dtDateExpiration.ResetText()
        dtDateMariageCivil.ResetText()
        'dtDateNaisEnfant.ResetText()
        dtDateNaissance.ResetText()
        dtDateRecrutement.ResetText()
        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        picfingerprintL.Image = Nothing
        picFingerprintR.Image = Nothing
    End Sub

End Class