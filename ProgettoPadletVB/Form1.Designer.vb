<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnMacchina = New System.Windows.Forms.Button()
        Me.BtnCibo = New System.Windows.Forms.Button()
        Me.BtnArtista = New System.Windows.Forms.Button()
        Me.BtnMateria = New System.Windows.Forms.Button()
        Me.BtnSport = New System.Windows.Forms.Button()
        Me.BtnSocial = New System.Windows.Forms.Button()
        Me.BtnSquadra = New System.Windows.Forms.Button()
        Me.LblFoto = New System.Windows.Forms.Label()
        Me.BtnEsci = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PctFoto = New System.Windows.Forms.PictureBox()
        CType(Me.PctFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMacchina
        '
        Me.BtnMacchina.BackColor = System.Drawing.Color.Red
        Me.BtnMacchina.Font = New System.Drawing.Font("Mongolian Baiti", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMacchina.Location = New System.Drawing.Point(1335, 66)
        Me.BtnMacchina.Name = "BtnMacchina"
        Me.BtnMacchina.Size = New System.Drawing.Size(216, 66)
        Me.BtnMacchina.TabIndex = 0
        Me.BtnMacchina.Text = "Macchina Preferita"
        Me.BtnMacchina.UseVisualStyleBackColor = False
        '
        'BtnCibo
        '
        Me.BtnCibo.BackColor = System.Drawing.Color.Gold
        Me.BtnCibo.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCibo.Location = New System.Drawing.Point(99, 66)
        Me.BtnCibo.Name = "BtnCibo"
        Me.BtnCibo.Size = New System.Drawing.Size(216, 66)
        Me.BtnCibo.TabIndex = 1
        Me.BtnCibo.Text = "Cibo Preferito"
        Me.BtnCibo.UseVisualStyleBackColor = False
        '
        'BtnArtista
        '
        Me.BtnArtista.BackColor = System.Drawing.Color.MediumPurple
        Me.BtnArtista.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArtista.Location = New System.Drawing.Point(1371, 222)
        Me.BtnArtista.Name = "BtnArtista"
        Me.BtnArtista.Size = New System.Drawing.Size(216, 66)
        Me.BtnArtista.TabIndex = 2
        Me.BtnArtista.Text = "Artista Preferito"
        Me.BtnArtista.UseVisualStyleBackColor = False
        '
        'BtnMateria
        '
        Me.BtnMateria.BackColor = System.Drawing.Color.Orange
        Me.BtnMateria.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMateria.Location = New System.Drawing.Point(24, 249)
        Me.BtnMateria.Name = "BtnMateria"
        Me.BtnMateria.Size = New System.Drawing.Size(216, 66)
        Me.BtnMateria.TabIndex = 3
        Me.BtnMateria.Text = "Materia Preferita"
        Me.BtnMateria.UseVisualStyleBackColor = False
        '
        'BtnSport
        '
        Me.BtnSport.BackColor = System.Drawing.Color.Chartreuse
        Me.BtnSport.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSport.Location = New System.Drawing.Point(1352, 406)
        Me.BtnSport.Name = "BtnSport"
        Me.BtnSport.Size = New System.Drawing.Size(216, 66)
        Me.BtnSport.TabIndex = 4
        Me.BtnSport.Text = "Sport Preferito"
        Me.BtnSport.UseVisualStyleBackColor = False
        '
        'BtnSocial
        '
        Me.BtnSocial.BackColor = System.Drawing.Color.Fuchsia
        Me.BtnSocial.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSocial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSocial.Location = New System.Drawing.Point(84, 433)
        Me.BtnSocial.Name = "BtnSocial"
        Me.BtnSocial.Size = New System.Drawing.Size(216, 66)
        Me.BtnSocial.TabIndex = 5
        Me.BtnSocial.Text = "Social Preferito"
        Me.BtnSocial.UseVisualStyleBackColor = False
        '
        'BtnSquadra
        '
        Me.BtnSquadra.BackColor = System.Drawing.Color.IndianRed
        Me.BtnSquadra.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSquadra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSquadra.Location = New System.Drawing.Point(35, 631)
        Me.BtnSquadra.Name = "BtnSquadra"
        Me.BtnSquadra.Size = New System.Drawing.Size(216, 66)
        Me.BtnSquadra.TabIndex = 6
        Me.BtnSquadra.Text = "Squadra Preferita"
        Me.BtnSquadra.UseVisualStyleBackColor = False
        '
        'LblFoto
        '
        Me.LblFoto.Font = New System.Drawing.Font("Mongolian Baiti", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFoto.Location = New System.Drawing.Point(416, 748)
        Me.LblFoto.Name = "LblFoto"
        Me.LblFoto.Size = New System.Drawing.Size(814, 65)
        Me.LblFoto.TabIndex = 8
        Me.LblFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEsci
        '
        Me.BtnEsci.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnEsci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEsci.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.BtnEsci.Location = New System.Drawing.Point(1371, 645)
        Me.BtnEsci.Name = "BtnEsci"
        Me.BtnEsci.Size = New System.Drawing.Size(216, 66)
        Me.BtnEsci.TabIndex = 10
        Me.BtnEsci.Text = "Esci"
        Me.BtnEsci.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(645, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 74)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "COSA MI PIACE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctFoto
        '
        Me.PctFoto.Location = New System.Drawing.Point(329, 149)
        Me.PctFoto.Name = "PctFoto"
        Me.PctFoto.Size = New System.Drawing.Size(980, 562)
        Me.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctFoto.TabIndex = 9
        Me.PctFoto.TabStop = False
        Me.PctFoto.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1613, 831)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEsci)
        Me.Controls.Add(Me.PctFoto)
        Me.Controls.Add(Me.LblFoto)
        Me.Controls.Add(Me.BtnSquadra)
        Me.Controls.Add(Me.BtnSocial)
        Me.Controls.Add(Me.BtnSport)
        Me.Controls.Add(Me.BtnMateria)
        Me.Controls.Add(Me.BtnArtista)
        Me.Controls.Add(Me.BtnCibo)
        Me.Controls.Add(Me.BtnMacchina)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Le Mie Preferenze"
        CType(Me.PctFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnMacchina As System.Windows.Forms.Button
    Friend WithEvents BtnArtista As System.Windows.Forms.Button
    Friend WithEvents BtnMateria As System.Windows.Forms.Button
    Friend WithEvents BtnSport As System.Windows.Forms.Button
    Friend WithEvents BtnSocial As System.Windows.Forms.Button
    Friend WithEvents BtnSquadra As System.Windows.Forms.Button
    Public WithEvents LblFoto As System.Windows.Forms.Label
    Friend WithEvents BtnCibo As System.Windows.Forms.Button
    Friend WithEvents BtnEsci As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PctFoto As System.Windows.Forms.PictureBox

End Class
