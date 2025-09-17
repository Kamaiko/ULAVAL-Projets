Public Class Form2
    Dim numeroClient As Integer
    Private Sub btnEquipements_Click(sender As Object, e As EventArgs) Handles btnEquipements.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub btnRenouveler_Click(sender As Object, e As EventArgs) Handles btnRenouveler.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub
    ' Vérifie si des champs sont vides et affiche les données au ListBox
    Private Sub btnTraiterContrat_Click(sender As Object, e As EventArgs) Handles btnTraiterContrat.Click
        If (txtNomClient.Text = "") Then
            MessageBox.Show("Veuillez saisir le nom et le prénom séparé par une virgule", "Erreur", MessageBoxButtons.OK)
        End If
        If (txtDateDebut.Text = "") Then
            MessageBox.Show("Veuillez entrer la date de début", "Erreur", MessageBoxButtons.OK)
        End If
        If (txtDateFin.Text = "") Then
            MessageBox.Show("Veuillez entrer la date de fin", "Erreur", MessageBoxButtons.OK)
        End If
        If (txtMontantDu.Text = "") Then
            MessageBox.Show("Veuillez entrer le montant dû", "Erreur", MessageBoxButtons.OK)
        End If
        If (CbStatut.Text = "") Then
            MessageBox.Show("Veuillez entrer indiquer le statut", "Erreur", MessageBoxButtons.OK)
        End If

        txtContractID.Text = numeroClient + 1
        txtClientID.Text = getClientID() & txtContractID.Text
        lblModifieActuel.Text = Date.Now.ToString("yyyy/MM/dd")
        lstInvoice.Items.Clear()
        lstInvoice.Items.Add("Client ID: " & txtClientID.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Nom: " & NameInProperOrder())
        lstInvoice.Items.Add("Date de début: " & txtDateDebut.Text)
        lstInvoice.Items.Add("Date de Fin: " & txtDateFin.Text)
        lstInvoice.Items.Add("Statut Du Contrat: " & CbStatut.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Montant dû: " & txtMontantDu.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("                            ------------")
        lstInvoice.Items.Add("            Date de Modification:" & " " & lblModifieActuel.Text)
    End Sub
    ' Réinitialise les données dans les TextBox et la ListBox
    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        txtClientID.Text = ""
        txtNomClient.Text = ""
        txtContractID.Text = ""
        txtDateDebut.Text = ""
        txtDateFin.Text = ""
        txtMontantDu.Text = ""
        CbStatut.Text = "Inactif"
        lstInvoice.Items.Clear()
        lblModifieActuel.Text = "AAAA-MM-JJ"
    End Sub
    ' Fermeture de la page
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub
    ' Sépare le nom et prénom du client à l'aide du séparateur vigule(,) et 
    ' retourne le nom et prénom du client
    Private Function NameInProperOrder() As String
        Dim name, firstName, lastName As String
        Dim comma As Integer
        name = txtNomClient.Text
        comma = name.IndexOf(",")
        lastName = name.Substring(0, comma)
        firstName = name.Substring(comma + 2)
        Return firstName & " " & lastName
    End Function
    ' Retourne 2 lettres du nom du client suivi par le numéro de client
    Private Function getClientID() As String
        Dim str As String = txtNomClient.Text.Substring(0, 2).ToUpper & numeroClient
        Return str
    End Function
End Class