<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.gbClientInformation = New System.Windows.Forms.GroupBox()
        Me.txtCodePostal = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtCourriel = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.lblCodePostal = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblCourriel = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblCreerClient = New System.Windows.Forms.Label()
        Me.gbClientInformation.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbClientInformation
        '
        Me.gbClientInformation.Controls.Add(Me.txtCodePostal)
        Me.gbClientInformation.Controls.Add(Me.txtVille)
        Me.gbClientInformation.Controls.Add(Me.txtAdresse)
        Me.gbClientInformation.Controls.Add(Me.txtTelephone)
        Me.gbClientInformation.Controls.Add(Me.txtCourriel)
        Me.gbClientInformation.Controls.Add(Me.txtNom)
        Me.gbClientInformation.Controls.Add(Me.txtPrenom)
        Me.gbClientInformation.Controls.Add(Me.txtClientID)
        Me.gbClientInformation.Controls.Add(Me.lblCodePostal)
        Me.gbClientInformation.Controls.Add(Me.lblVille)
        Me.gbClientInformation.Controls.Add(Me.lblAdresse)
        Me.gbClientInformation.Controls.Add(Me.lblCourriel)
        Me.gbClientInformation.Controls.Add(Me.lblTelephone)
        Me.gbClientInformation.Controls.Add(Me.lblNom)
        Me.gbClientInformation.Controls.Add(Me.lblPrenom)
        Me.gbClientInformation.Controls.Add(Me.lblClientID)
        Me.gbClientInformation.Location = New System.Drawing.Point(79, 71)
        Me.gbClientInformation.Name = "gbClientInformation"
        Me.gbClientInformation.Size = New System.Drawing.Size(536, 175)
        Me.gbClientInformation.TabIndex = 0
        Me.gbClientInformation.TabStop = False
        Me.gbClientInformation.Text = "Client Information"
        '
        'txtCodePostal
        '
        Me.txtCodePostal.Location = New System.Drawing.Point(371, 134)
        Me.txtCodePostal.Name = "txtCodePostal"
        Me.txtCodePostal.Size = New System.Drawing.Size(134, 23)
        Me.txtCodePostal.TabIndex = 6
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(371, 98)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(134, 23)
        Me.txtVille.TabIndex = 5
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(371, 62)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(134, 23)
        Me.txtAdresse.TabIndex = 4
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(371, 26)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.PlaceholderText = "(111) 222-3333"
        Me.txtTelephone.Size = New System.Drawing.Size(134, 23)
        Me.txtTelephone.TabIndex = 3
        '
        'txtCourriel
        '
        Me.txtCourriel.Location = New System.Drawing.Point(100, 134)
        Me.txtCourriel.Name = "txtCourriel"
        Me.txtCourriel.PlaceholderText = "aaaa@bbbb.com"
        Me.txtCourriel.Size = New System.Drawing.Size(134, 23)
        Me.txtCourriel.TabIndex = 2
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(100, 98)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(134, 23)
        Me.txtNom.TabIndex = 1
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(100, 62)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(134, 23)
        Me.txtPrenom.TabIndex = 0
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(100, 26)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.ReadOnly = True
        Me.txtClientID.Size = New System.Drawing.Size(134, 23)
        Me.txtClientID.TabIndex = 7
        '
        'lblCodePostal
        '
        Me.lblCodePostal.AutoSize = True
        Me.lblCodePostal.Location = New System.Drawing.Point(251, 137)
        Me.lblCodePostal.Name = "lblCodePostal"
        Me.lblCodePostal.Size = New System.Drawing.Size(73, 15)
        Me.lblCodePostal.TabIndex = 7
        Me.lblCodePostal.Text = "Code Postal:"
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Location = New System.Drawing.Point(251, 101)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(32, 15)
        Me.lblVille.TabIndex = 6
        Me.lblVille.Text = "Ville:"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(251, 65)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(51, 15)
        Me.lblAdresse.TabIndex = 5
        Me.lblAdresse.Text = "Adresse:"
        '
        'lblCourriel
        '
        Me.lblCourriel.AutoSize = True
        Me.lblCourriel.Location = New System.Drawing.Point(23, 137)
        Me.lblCourriel.Name = "lblCourriel"
        Me.lblCourriel.Size = New System.Drawing.Size(52, 15)
        Me.lblCourriel.TabIndex = 4
        Me.lblCourriel.Text = "Courriel:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(251, 29)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(64, 15)
        Me.lblTelephone.TabIndex = 3
        Me.lblTelephone.Text = "Téléphone:"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(23, 101)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(37, 15)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom:"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(23, 65)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(52, 15)
        Me.lblPrenom.TabIndex = 1
        Me.lblPrenom.Text = "Prénom:"
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Location = New System.Drawing.Point(23, 29)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(55, 15)
        Me.lblClientID.TabIndex = 0
        Me.lblClientID.Text = "Client ID:"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(79, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(640, 172)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "CLIENT ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRÉNOM"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOM"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "COURRIEL"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TÉLÉPHONE"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "ADRESSE"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "VILLE"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "CODE POSTAL"
        Me.Column8.Name = "Column8"
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(633, 79)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(86, 23)
        Me.btnAjouter.TabIndex = 2
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(633, 137)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(86, 23)
        Me.btnModifier.TabIndex = 4
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Location = New System.Drawing.Point(633, 166)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(86, 23)
        Me.btnEffacer.TabIndex = 5
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnSauvegarder
        '
        Me.btnSauvegarder.Location = New System.Drawing.Point(633, 194)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(86, 23)
        Me.btnSauvegarder.TabIndex = 6
        Me.btnSauvegarder.Text = "Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = True
        '
        'btnNouveau
        '
        Me.btnNouveau.Location = New System.Drawing.Point(633, 108)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(86, 23)
        Me.btnNouveau.TabIndex = 3
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(633, 223)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(86, 23)
        Me.btnQuitter.TabIndex = 7
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblCreerClient
        '
        Me.lblCreerClient.AutoSize = True
        Me.lblCreerClient.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCreerClient.Location = New System.Drawing.Point(322, 36)
        Me.lblCreerClient.Name = "lblCreerClient"
        Me.lblCreerClient.Size = New System.Drawing.Size(148, 32)
        Me.lblCreerClient.TabIndex = 24
        Me.lblCreerClient.Text = "Créer Client"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCreerClient)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.btnSauvegarder)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gbClientInformation)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.gbClientInformation.ResumeLayout(False)
        Me.gbClientInformation.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbClientInformation As GroupBox
    Friend WithEvents txtCodePostal As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtCourriel As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents lblCodePostal As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblCourriel As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblClientID As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnEffacer As Button
    Friend WithEvents btnSauvegarder As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents lblCreerClient As Label
End Class
