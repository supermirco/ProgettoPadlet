Public Class Form1


    Private Sub BtnMacchina_Click(sender As System.Object, e As System.EventArgs) Handles BtnMacchina.Click
        If PctFoto.Visible = False Then
            PctFoto.Image = My.Resources.Ferrari
            PctFoto.Visible = True
            LblFoto.Text = "La mia macchina preferita è la Ferrari"
            LblFoto.Visible = True
        Else
            PctFoto.Visible = False
            LblFoto.Visible = False
        End If
    End Sub

    Private Sub BtnCibo_Click(sender As System.Object, e As System.EventArgs) Handles BtnCibo.Click
        If PctFoto.Visible = False Then
            PctFoto.Image = My.Resources.Pizza_Tonno_Cipolle
            PctFoto.Visible = True
            LblFoto.Text = "Il mio piatto preferito è la Pizza"
            LblFoto.Visible = True
        Else
            PctFoto.Visible = False
            LblFoto.Visible = False
        End If
    End Sub

    Private Sub BtnArtista_Click(sender As System.Object, e As System.EventArgs) Handles BtnArtista.Click
        If PctFoto.Visible = False Then
            PctFoto.Image = My.Resources.Immagine_Dragon
            PctFoto.Visible = True
            LblFoto.Text = "I miei artisti preferiti sono gli Immagine Dragons"
            LblFoto.Visible = True
        Else
            PctFoto.Visible = False
            LblFoto.Visible = False
        End If
    End Sub

    Private Sub BtnMateria_Click(sender As System.Object, e As System.EventArgs) Handles BtnMateria.Click
        If PctFoto.Visible = False Then
            PctFoto.Image = My.Resources.Storia
            PctFoto.Visible = True
            LblFoto.Text = "La mia materia preferita è Storia"
            LblFoto.Visible = True
        Else
            PctFoto.Visible = False
            LblFoto.Visible = False
        End If
    End Sub

    Private Sub BtnSport_Click(sender As System.Object, e As System.EventArgs) Handles BtnSport.Click
        If PctFoto.Visible = False Then
            PctFoto.Image = My.Resources.Campo_Tennis
            PctFoto.Visible = True
            LblFoto.Text = "Il mio sport preferito è il Tennis"
            LblFoto.Visible = True
        Else
            PctFoto.Visible = False
            LblFoto.Visible = False
        End If
    End Sub

    Private Sub BtnSocial_Click(sender As System.Object, e As System.EventArgs) Handles BtnSocial.Click
        If PctFoto.Visible = False Then
            PctFoto.Image = My.Resources.Instagram
            PctFoto.Visible = True
            LblFoto.Text = "Il mio social preferito è Instagram"
            LblFoto.Visible = True
        Else
            PctFoto.Visible = False
            LblFoto.Visible = False
        End If
    End Sub

    Private Sub BtnSquadra_Click(sender As System.Object, e As System.EventArgs) Handles BtnSquadra.Click
        If PctFoto.Visible = False Then
            PctFoto.Image = My.Resources.milan
            PctFoto.Visible = True
            LblFoto.Text = "La mia squadra preferita è il Milan"
            LblFoto.Visible = True
        Else
            PctFoto.Visible = False
            LblFoto.Visible = False
        End If
    End Sub

    Private Sub BtnEsci_Click(sender As System.Object, e As System.EventArgs) Handles BtnEsci.Click
        Me.Close()
    End Sub
End Class
