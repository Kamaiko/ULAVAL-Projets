<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lblReleve = New System.Windows.Forms.Label()
        Me.btnDebit = New System.Windows.Forms.Button()
        Me.btnCredit = New System.Windows.Forms.Button()
        Me.btnArgent = New System.Windows.Forms.Button()
        Me.btnCheque = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblRapportTransactions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblReleve
        '
        Me.lblReleve.AutoSize = True
        Me.lblReleve.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReleve.Location = New System.Drawing.Point(202, 133)
        Me.lblReleve.Name = "lblReleve"
        Me.lblReleve.Size = New System.Drawing.Size(389, 21)
        Me.lblReleve.TabIndex = 0
        Me.lblReleve.Text = "Choisissez le type de relevé de transactions à imprimer"
        '
        'btnDebit
        '
        Me.btnDebit.Location = New System.Drawing.Point(232, 169)
        Me.btnDebit.Name = "btnDebit"
        Me.btnDebit.Size = New System.Drawing.Size(162, 36)
        Me.btnDebit.TabIndex = 1
        Me.btnDebit.Text = "Débit"
        Me.btnDebit.UseVisualStyleBackColor = True
        '
        'btnCredit
        '
        Me.btnCredit.Location = New System.Drawing.Point(410, 169)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(162, 36)
        Me.btnCredit.TabIndex = 2
        Me.btnCredit.Text = "Crédit"
        Me.btnCredit.UseVisualStyleBackColor = True
        '
        'btnArgent
        '
        Me.btnArgent.Location = New System.Drawing.Point(232, 220)
        Me.btnArgent.Name = "btnArgent"
        Me.btnArgent.Size = New System.Drawing.Size(162, 36)
        Me.btnArgent.TabIndex = 3
        Me.btnArgent.Text = "Argent"
        Me.btnArgent.UseVisualStyleBackColor = True
        '
        'btnCheque
        '
        Me.btnCheque.Location = New System.Drawing.Point(410, 220)
        Me.btnCheque.Name = "btnCheque"
        Me.btnCheque.Size = New System.Drawing.Size(162, 36)
        Me.btnCheque.TabIndex = 4
        Me.btnCheque.Text = "Chèque"
        Me.btnCheque.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(323, 277)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(162, 36)
        Me.btnTotal.TabIndex = 5
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(671, 415)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(97, 23)
        Me.btnQuitter.TabIndex = 6
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblRapportTransactions
        '
        Me.lblRapportTransactions.AutoSize = True
        Me.lblRapportTransactions.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRapportTransactions.Location = New System.Drawing.Point(260, 35)
        Me.lblRapportTransactions.Name = "lblRapportTransactions"
        Me.lblRapportTransactions.Size = New System.Drawing.Size(290, 32)
        Me.lblRapportTransactions.TabIndex = 25
        Me.lblRapportTransactions.Text = "Rapport de transactions"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRapportTransactions)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnCheque)
        Me.Controls.Add(Me.btnArgent)
        Me.Controls.Add(Me.btnCredit)
        Me.Controls.Add(Me.btnDebit)
        Me.Controls.Add(Me.lblReleve)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReleve As Label
    Friend WithEvents btnDebit As Button
    Friend WithEvents btnCredit As Button
    Friend WithEvents btnArgent As Button
    Friend WithEvents btnCheque As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblRapportTransactions As Label
End Class
