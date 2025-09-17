Public Class Form4

    Dim temps = Date.Now.ToString("yyyy/MM/dd")
    ' Envoie un MessageBox à l'utilisateur
    Private Sub btnDebit_Click(sender As Object, e As EventArgs) Handles btnDebit.Click
        MessageBox.Show("Le rapport des transactions Débit en date du: " & temps & vbCrLf & "est envoyé à l'imprimante", "Impression...", MessageBoxButtons.OK)
    End Sub
    ' Envoie un MessageBox à l'utilisateur
    Private Sub btnCredit_Click(sender As Object, e As EventArgs) Handles btnCredit.Click
        MessageBox.Show("Le rapport total des transactions Crédit en date du: " & temps & vbCrLf & "est envoyé à l'imprimante", "Impression...", MessageBoxButtons.OK)
    End Sub
    ' Envoie un MessageBox à l'utilisateur
    Private Sub btnArgent_Click(sender As Object, e As EventArgs) Handles btnArgent.Click
        MessageBox.Show("Le rapport total des transactions Argent en date du: " & temps & vbCrLf & "est envoyé à l'imprimante", "Impression...", MessageBoxButtons.OK)
    End Sub
    ' Envoie un MessageBox à l'utilisateur
    Private Sub btnCheque_Click(sender As Object, e As EventArgs) Handles btnCheque.Click
        MessageBox.Show("Le rapport total des transactions Chèque en date du: " & temps & vbCrLf & "est envoyé à l'imprimante", "Impression...", MessageBoxButtons.OK)
    End Sub
    ' Envoie un MessageBox à l'utilisateur
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        MessageBox.Show("Le rapport des transactions Total en date du: " & temps & vbCrLf & "est envoyé à l'imprimante", "Impression...", MessageBoxButtons.OK)
    End Sub
    ' Fermeture de la page
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub
End Class