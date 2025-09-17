<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblNumeroEmploye = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblNas = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtNoEmploye = New System.Windows.Forms.TextBox()
        Me.txtNAS = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lblGestionEmployer = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(29, 95)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(52, 15)
        Me.lblPrenom.TabIndex = 0
        Me.lblPrenom.Text = "Prénom:"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(29, 130)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(37, 15)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Nom:"
        '
        'lblNumeroEmploye
        '
        Me.lblNumeroEmploye.AutoSize = True
        Me.lblNumeroEmploye.Location = New System.Drawing.Point(29, 291)
        Me.lblNumeroEmploye.Name = "lblNumeroEmploye"
        Me.lblNumeroEmploye.Size = New System.Drawing.Size(78, 15)
        Me.lblNumeroEmploye.TabIndex = 2
        Me.lblNumeroEmploye.Text = "No. Employé:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nouveau Mot de Passe:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Confirmer Mot de Passe:"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(29, 162)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(51, 15)
        Me.lblAdresse.TabIndex = 5
        Me.lblAdresse.Text = "Adresse:"
        '
        'lblNas
        '
        Me.lblNas.AutoSize = True
        Me.lblNas.Location = New System.Drawing.Point(29, 260)
        Me.lblNas.Name = "lblNas"
        Me.lblNas.Size = New System.Drawing.Size(33, 15)
        Me.lblNas.TabIndex = 6
        Me.lblNas.Text = "NAS:"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(185, 92)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(121, 23)
        Me.txtPrenom.TabIndex = 0
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(185, 362)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(122, 23)
        Me.txtConfirmPass.TabIndex = 7
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(185, 323)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(122, 23)
        Me.txtNewPass.TabIndex = 6
        '
        'txtNoEmploye
        '
        Me.txtNoEmploye.Location = New System.Drawing.Point(185, 288)
        Me.txtNoEmploye.Name = "txtNoEmploye"
        Me.txtNoEmploye.Size = New System.Drawing.Size(122, 23)
        Me.txtNoEmploye.TabIndex = 5
        '
        'txtNAS
        '
        Me.txtNAS.Location = New System.Drawing.Point(185, 252)
        Me.txtNAS.Name = "txtNAS"
        Me.txtNAS.Size = New System.Drawing.Size(121, 23)
        Me.txtNAS.TabIndex = 4
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(185, 159)
        Me.txtAdresse.Multiline = True
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(121, 50)
        Me.txtAdresse.TabIndex = 2
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(186, 127)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(121, 23)
        Me.txtNom.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(329, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(446, 328)
        Me.DataGridView1.TabIndex = 14
        '
        'Column4
        '
        Me.Column4.HeaderText = "NO EMPLOYÉ"
        Me.Column4.Name = "Column4"
        '
        'Column1
        '
        Me.Column1.HeaderText = "PRÉNOM"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOM"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "TÉLÉPHONE"
        Me.Column3.Name = "Column3"
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(685, 415)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(81, 23)
        Me.btnQuitter.TabIndex = 13
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnNouveau
        '
        Me.btnNouveau.Location = New System.Drawing.Point(424, 383)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(81, 23)
        Me.btnNouveau.TabIndex = 9
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'btnSauvegarder
        '
        Me.btnSauvegarder.Location = New System.Drawing.Point(685, 383)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(81, 23)
        Me.btnSauvegarder.TabIndex = 12
        Me.btnSauvegarder.Text = "Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Location = New System.Drawing.Point(598, 383)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(81, 23)
        Me.btnEffacer.TabIndex = 11
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(511, 383)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(81, 23)
        Me.btnModifier.TabIndex = 10
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(337, 383)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(81, 23)
        Me.btnAjouter.TabIndex = 8
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'lblGestionEmployer
        '
        Me.lblGestionEmployer.AutoSize = True
        Me.lblGestionEmployer.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGestionEmployer.Location = New System.Drawing.Point(29, 34)
        Me.lblGestionEmployer.Name = "lblGestionEmployer"
        Me.lblGestionEmployer.Size = New System.Drawing.Size(263, 32)
        Me.lblGestionEmployer.TabIndex = 21
        Me.lblGestionEmployer.Text = "Gestion des Employés"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(28, 225)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 15)
        Me.lblTelephone.TabIndex = 22
        Me.lblTelephone.Text = "Téléphone"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(185, 225)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.PlaceholderText = "(444) 444-4444"
        Me.txtTelephone.Size = New System.Drawing.Size(122, 23)
        Me.txtTelephone.TabIndex = 3
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.lblGestionEmployer)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.btnSauvegarder)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtNAS)
        Me.Controls.Add(Me.txtNoEmploye)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.lblNas)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNumeroEmploye)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblPrenom)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblNumeroEmploye As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblNas As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtNoEmploye As TextBox
    Friend WithEvents txtNAS As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents btnSauvegarder As Button
    Friend WithEvents btnEffacer As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents lblGestionEmployer As Label
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lblTelephone As Label
    Friend WithEvents txtTelephone As TextBox
End Class
