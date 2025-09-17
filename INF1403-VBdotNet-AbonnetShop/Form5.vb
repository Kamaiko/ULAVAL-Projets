Public Class Form5
    ' Affiche le résultat dans le DataGridView si les mots de passes ne sont pas identique,
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If (txtNewPass.Text <> txtConfirmPass.Text) Then
            MessageBox.Show("Veuillez entrer des Mots de Passe identiques", "Attention!", MessageBoxButtons.OK)
        Else
            DataGridView1.Rows.Add(txtNoEmploye.Text, txtPrenom.Text, txtNom.Text, txtTelephone.Text)
        End If
    End Sub
    ' Réinitialise les TextBox
    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        txtPrenom.Text = ""
        txtNom.Text = ""
        txtAdresse.Text = ""
        txtTelephone.Text = ""
        txtNAS.Text = ""
        txtNoEmploye.Text = ""
        txtNewPass.Text = ""
        txtConfirmPass.Text = ""
    End Sub
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub
    ' Suprimme une rangée du DataGridView si une rangée est sélectionnée
    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim resultat As DialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette rangée?", "Attention!", MessageBoxButtons.YesNo)
            If resultat = DialogResult.Yes Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If
        Else
            MessageBox.Show("Sélectionner une colonne à supprimer avant de cliquer sur Effacer")
        End If

    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        MessageBox.Show("Désoler. Cette fonctionnalité sera intégrée dans la prochaine version", "Projet en développement", MessageBoxButtons.OK)
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class