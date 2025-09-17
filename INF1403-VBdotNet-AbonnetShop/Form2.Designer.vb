<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnRenouveler = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnTraiterContrat = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnEquipements = New System.Windows.Forms.Button()
        Me.btnOption = New System.Windows.Forms.Button()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.grpClient = New System.Windows.Forms.GroupBox()
        Me.txtNomClient = New System.Windows.Forms.TextBox()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.lblNomClient = New System.Windows.Forms.Label()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.grpContrat = New System.Windows.Forms.GroupBox()
        Me.lblModifieActuel = New System.Windows.Forms.Label()
        Me.lblModifieNow = New System.Windows.Forms.Label()
        Me.CbStatut = New System.Windows.Forms.ComboBox()
        Me.lblStatut = New System.Windows.Forms.Label()
        Me.txtMontantDu = New System.Windows.Forms.TextBox()
        Me.txtDateFin = New System.Windows.Forms.TextBox()
        Me.txtDateDebut = New System.Windows.Forms.TextBox()
        Me.txtContractID = New System.Windows.Forms.TextBox()
        Me.lblModifie = New System.Windows.Forms.Label()
        Me.lblMontantDu = New System.Windows.Forms.Label()
        Me.lblDateFin = New System.Windows.Forms.Label()
        Me.lblDateDebut = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNouveauContrat = New System.Windows.Forms.Label()
        Me.grpClient.SuspendLayout()
        Me.grpContrat.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSauvegarder
        '
        Me.btnSauvegarder.Location = New System.Drawing.Point(218, 415)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(102, 23)
        Me.btnSauvegarder.TabIndex = 22
        Me.btnSauvegarder.Text = "Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = True
        '
        'btnRenouveler
        '
        Me.btnRenouveler.Location = New System.Drawing.Point(218, 391)
        Me.btnRenouveler.Name = "btnRenouveler"
        Me.btnRenouveler.Size = New System.Drawing.Size(102, 23)
        Me.btnRenouveler.TabIndex = 21
        Me.btnRenouveler.Text = "Renouveler"
        Me.btnRenouveler.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(663, 420)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(97, 23)
        Me.btnQuitter.TabIndex = 20
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnTraiterContrat
        '
        Me.btnTraiterContrat.Location = New System.Drawing.Point(458, 420)
        Me.btnTraiterContrat.Name = "btnTraiterContrat"
        Me.btnTraiterContrat.Size = New System.Drawing.Size(97, 23)
        Me.btnTraiterContrat.TabIndex = 19
        Me.btnTraiterContrat.Text = "Traiter Contrat"
        Me.btnTraiterContrat.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Location = New System.Drawing.Point(561, 420)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(97, 23)
        Me.btnEffacer.TabIndex = 18
        Me.btnEffacer.Text = "Tout Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnEquipements
        '
        Me.btnEquipements.Location = New System.Drawing.Point(98, 415)
        Me.btnEquipements.Name = "btnEquipements"
        Me.btnEquipements.Size = New System.Drawing.Size(102, 23)
        Me.btnEquipements.TabIndex = 17
        Me.btnEquipements.Text = "Équipements"
        Me.btnEquipements.UseVisualStyleBackColor = True
        '
        'btnOption
        '
        Me.btnOption.Location = New System.Drawing.Point(98, 391)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Size = New System.Drawing.Size(102, 23)
        Me.btnOption.TabIndex = 16
        Me.btnOption.Text = "Options"
        Me.btnOption.UseVisualStyleBackColor = True
        '
        'lstInvoice
        '
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 15
        Me.lstInvoice.Location = New System.Drawing.Point(458, 79)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(302, 304)
        Me.lstInvoice.TabIndex = 15
        '
        'grpClient
        '
        Me.grpClient.Controls.Add(Me.txtNomClient)
        Me.grpClient.Controls.Add(Me.txtClientID)
        Me.grpClient.Controls.Add(Me.lblNomClient)
        Me.grpClient.Controls.Add(Me.lblClientID)
        Me.grpClient.Location = New System.Drawing.Point(63, 37)
        Me.grpClient.Name = "grpClient"
        Me.grpClient.Size = New System.Drawing.Size(288, 125)
        Me.grpClient.TabIndex = 0
        Me.grpClient.TabStop = False
        Me.grpClient.Text = "Client"
        '
        'txtNomClient
        '
        Me.txtNomClient.Location = New System.Drawing.Point(118, 75)
        Me.txtNomClient.Name = "txtNomClient"
        Me.txtNomClient.Size = New System.Drawing.Size(154, 23)
        Me.txtNomClient.TabIndex = 1
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(172, 34)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.ReadOnly = True
        Me.txtClientID.Size = New System.Drawing.Size(100, 23)
        Me.txtClientID.TabIndex = 2
        '
        'lblNomClient
        '
        Me.lblNomClient.AutoSize = True
        Me.lblNomClient.Location = New System.Drawing.Point(22, 68)
        Me.lblNomClient.Name = "lblNomClient"
        Me.lblNomClient.Size = New System.Drawing.Size(90, 30)
        Me.lblNomClient.TabIndex = 1
        Me.lblNomClient.Text = "Nom Client :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Nom, Prénom)"
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Location = New System.Drawing.Point(22, 34)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(58, 15)
        Me.lblClientID.TabIndex = 1
        Me.lblClientID.Text = "Client ID :"
        '
        'grpContrat
        '
        Me.grpContrat.Controls.Add(Me.lblModifieActuel)
        Me.grpContrat.Controls.Add(Me.lblModifieNow)
        Me.grpContrat.Controls.Add(Me.CbStatut)
        Me.grpContrat.Controls.Add(Me.lblStatut)
        Me.grpContrat.Controls.Add(Me.txtMontantDu)
        Me.grpContrat.Controls.Add(Me.txtDateFin)
        Me.grpContrat.Controls.Add(Me.txtDateDebut)
        Me.grpContrat.Controls.Add(Me.txtContractID)
        Me.grpContrat.Controls.Add(Me.lblModifie)
        Me.grpContrat.Controls.Add(Me.lblMontantDu)
        Me.grpContrat.Controls.Add(Me.lblDateFin)
        Me.grpContrat.Controls.Add(Me.lblDateDebut)
        Me.grpContrat.Controls.Add(Me.lblID)
        Me.grpContrat.Location = New System.Drawing.Point(63, 168)
        Me.grpContrat.Name = "grpContrat"
        Me.grpContrat.Size = New System.Drawing.Size(288, 208)
        Me.grpContrat.TabIndex = 1
        Me.grpContrat.TabStop = False
        Me.grpContrat.Text = "Contrat"
        '
        'lblModifieActuel
        '
        Me.lblModifieActuel.AutoSize = True
        Me.lblModifieActuel.Location = New System.Drawing.Point(172, 174)
        Me.lblModifieActuel.Name = "lblModifieActuel"
        Me.lblModifieActuel.Size = New System.Drawing.Size(79, 15)
        Me.lblModifieActuel.TabIndex = 13
        Me.lblModifieActuel.Text = "AAAA-MM-JJ"
        '
        'lblModifieNow
        '
        Me.lblModifieNow.AutoSize = True
        Me.lblModifieNow.Location = New System.Drawing.Point(172, 146)
        Me.lblModifieNow.Name = "lblModifieNow"
        Me.lblModifieNow.Size = New System.Drawing.Size(0, 15)
        Me.lblModifieNow.TabIndex = 12
        '
        'CbStatut
        '
        Me.CbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbStatut.FormattingEnabled = True
        Me.CbStatut.Items.AddRange(New Object() {"Inactif", "Actif"})
        Me.CbStatut.Location = New System.Drawing.Point(172, 143)
        Me.CbStatut.Name = "CbStatut"
        Me.CbStatut.Size = New System.Drawing.Size(100, 23)
        Me.CbStatut.TabIndex = 11
        '
        'lblStatut
        '
        Me.lblStatut.AutoSize = True
        Me.lblStatut.Location = New System.Drawing.Point(22, 146)
        Me.lblStatut.Name = "lblStatut"
        Me.lblStatut.Size = New System.Drawing.Size(44, 15)
        Me.lblStatut.TabIndex = 10
        Me.lblStatut.Text = "Statut :"
        '
        'txtMontantDu
        '
        Me.txtMontantDu.Location = New System.Drawing.Point(172, 110)
        Me.txtMontantDu.Name = "txtMontantDu"
        Me.txtMontantDu.PlaceholderText = "0.00$"
        Me.txtMontantDu.Size = New System.Drawing.Size(100, 23)
        Me.txtMontantDu.TabIndex = 8
        '
        'txtDateFin
        '
        Me.txtDateFin.Location = New System.Drawing.Point(172, 81)
        Me.txtDateFin.Name = "txtDateFin"
        Me.txtDateFin.PlaceholderText = "AAAA-MM-JJ"
        Me.txtDateFin.Size = New System.Drawing.Size(100, 23)
        Me.txtDateFin.TabIndex = 7
        '
        'txtDateDebut
        '
        Me.txtDateDebut.Location = New System.Drawing.Point(172, 53)
        Me.txtDateDebut.Name = "txtDateDebut"
        Me.txtDateDebut.PlaceholderText = "AAAA-MM-JJ"
        Me.txtDateDebut.Size = New System.Drawing.Size(100, 23)
        Me.txtDateDebut.TabIndex = 6
        '
        'txtContractID
        '
        Me.txtContractID.Location = New System.Drawing.Point(172, 24)
        Me.txtContractID.Name = "txtContractID"
        Me.txtContractID.ReadOnly = True
        Me.txtContractID.Size = New System.Drawing.Size(100, 23)
        Me.txtContractID.TabIndex = 5
        '
        'lblModifie
        '
        Me.lblModifie.AutoSize = True
        Me.lblModifie.Location = New System.Drawing.Point(22, 174)
        Me.lblModifie.Name = "lblModifie"
        Me.lblModifie.Size = New System.Drawing.Size(54, 15)
        Me.lblModifie.TabIndex = 4
        Me.lblModifie.Text = "Modifié :"
        '
        'lblMontantDu
        '
        Me.lblMontantDu.AutoSize = True
        Me.lblMontantDu.Location = New System.Drawing.Point(22, 118)
        Me.lblMontantDu.Name = "lblMontantDu"
        Me.lblMontantDu.Size = New System.Drawing.Size(76, 15)
        Me.lblMontantDu.TabIndex = 3
        Me.lblMontantDu.Text = "Montant dû :"
        '
        'lblDateFin
        '
        Me.lblDateFin.AutoSize = True
        Me.lblDateFin.Location = New System.Drawing.Point(22, 89)
        Me.lblDateFin.Name = "lblDateFin"
        Me.lblDateFin.Size = New System.Drawing.Size(70, 15)
        Me.lblDateFin.TabIndex = 2
        Me.lblDateFin.Text = "Date de fin :"
        '
        'lblDateDebut
        '
        Me.lblDateDebut.AutoSize = True
        Me.lblDateDebut.Location = New System.Drawing.Point(22, 61)
        Me.lblDateDebut.Name = "lblDateDebut"
        Me.lblDateDebut.Size = New System.Drawing.Size(90, 15)
        Me.lblDateDebut.TabIndex = 1
        Me.lblDateDebut.Text = "Date de début : "
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(22, 32)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(67, 15)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Contrat ID :"
        '
        'lblNouveauContrat
        '
        Me.lblNouveauContrat.AutoSize = True
        Me.lblNouveauContrat.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNouveauContrat.Location = New System.Drawing.Point(503, 37)
        Me.lblNouveauContrat.Name = "lblNouveauContrat"
        Me.lblNouveauContrat.Size = New System.Drawing.Size(210, 32)
        Me.lblNouveauContrat.TabIndex = 23
        Me.lblNouveauContrat.Text = "Nouveau Contrat"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNouveauContrat)
        Me.Controls.Add(Me.btnSauvegarder)
        Me.Controls.Add(Me.btnRenouveler)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnTraiterContrat)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnEquipements)
        Me.Controls.Add(Me.btnOption)
        Me.Controls.Add(Me.lstInvoice)
        Me.Controls.Add(Me.grpClient)
        Me.Controls.Add(Me.grpContrat)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.grpClient.ResumeLayout(False)
        Me.grpClient.PerformLayout()
        Me.grpContrat.ResumeLayout(False)
        Me.grpContrat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSauvegarder As Button
    Friend WithEvents btnRenouveler As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnTraiterContrat As Button
    Friend WithEvents btnEffacer As Button
    Friend WithEvents btnEquipements As Button
    Friend WithEvents btnOption As Button
    Friend WithEvents lstInvoice As ListBox
    Friend WithEvents grpClient As GroupBox
    Friend WithEvents txtNomClient As TextBox
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents lblNomClient As Label
    Friend WithEvents lblClientID As Label
    Friend WithEvents grpContrat As GroupBox
    Friend WithEvents CbStatut As ComboBox
    Friend WithEvents lblStatut As Label
    Friend WithEvents txtMontantDu As TextBox
    Friend WithEvents txtDateFin As TextBox
    Friend WithEvents txtDateDebut As TextBox
    Friend WithEvents txtContractID As TextBox
    Friend WithEvents lblModifie As Label
    Friend WithEvents lblMontantDu As Label
    Friend WithEvents lblDateFin As Label
    Friend WithEvents lblDateDebut As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblModifieNow As Label
    Friend WithEvents lblModifieActuel As Label
    Friend WithEvents lblNouveauContrat As Label
End Class
