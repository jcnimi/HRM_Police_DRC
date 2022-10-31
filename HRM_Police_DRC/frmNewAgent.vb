Public Class frmNewAgent
    Private Sub frmNewAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRegroupement.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click


        MessageBox.Show(cmbTerritoireOrigine.Text + " " + cmbTerritoireOrigine.SelectedValue.ToString())



        'Get the data from input controls
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
        Dim regroupement As String = cmbRegroupement.SelectedValue
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
           ({matricule}
           ,{nom}
           ,{postnom}
           ,{prenom}
           ,{sexe}
           ,{grade}
           ,{lieu_naissance}
           ,{territoire_origine}
           ,{secteur_origine}
           ,{province_origine}
           ,{adresse}
           ,{groupe_sanguin}
           ,{fonction}
           ,{unite_agent}
           ,{regroupement}
           ,{date_naissance}
           ,null
           ,null
           ,null
           ,{etat_civil}
           ,{date_mariage_civil}
           ,{sexe_conjoint}
           ,{nom_conjoint}
           ,{date_recructement}
           ,{date_expiration}
           ,{entre_grade}
           ,{province_recrutement}
           ,{userId}
           ,{commissariat_recrutement}
           ,SYSDATETIME()
           ,{telephone1}
           ,{telephone2}
           ,{telephone3}
            )
        "
    End Sub

    Private Sub cmbSexe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSexe.SelectedIndexChanged
        If cmbSexe.Text = "Homme" Then
            cmbSexeConjoint.Text = "Femme"
        End If

        If cmbSexe.Text = "Femme" Then
            cmbSexeConjoint.Text = "Homme"
        End If
    End Sub
End Class