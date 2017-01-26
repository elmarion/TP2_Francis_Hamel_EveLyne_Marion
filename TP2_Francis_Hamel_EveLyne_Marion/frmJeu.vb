Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class frmJeu
    Private _lstPersonnage As New List(Of Personnages)
    Private _nbLignesColonnesGrille As Integer
    Private _nbNombreTour As Integer
    Private _partieTermine As Boolean

    ''' <summary>
    ''' Dessine la grille de jeu ainsi que les images de personnages
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles pctbox_GrilleJeu.Paint
        Dim laGrile As New Grille(_nbLignesColonnesGrille)
        laGrile.DessinerGrille(e.Graphics)

        For Each elem In _lstPersonnage
            e.Graphics.DrawImage(elem.Image, elem.ConvertirMatricePixels.X, elem.ConvertirMatricePixels.Y, 50, 50)
        Next
    End Sub

    ''' <summary>
    ''' Génère un emplacement aléatoire en périphérie de la grille pour un citoyen
    ''' </summary>
    ''' <returns>Retourne un point en périphérie</returns>
    Private Function GenererPointCitoyen() As Point
        Dim rnd As Aleatoire = New Aleatoire()
        Dim nouveauX As Integer
        Dim nouveauY As Integer
        nouveauX = rnd.ObtenirNombreEntre(0, _nbLignesColonnesGrille - 1)
        If nouveauX = 0 OrElse nouveauX = _nbLignesColonnesGrille - 1 Then
            nouveauY = rnd.ObtenirNombreEntre(0, _nbLignesColonnesGrille - 1)
        Else
            If rnd.ObtenirNombreEntre(0, 1) = 0 Then
                nouveauY = 0
            Else
                nouveauY = _nbLignesColonnesGrille - 1
            End If
        End If
        Return New Point(nouveauX, nouveauY)
    End Function

    ''' <summary>
    ''' Fait le déplacement de tout les personnages
    ''' </summary>
    Private Sub BougerToutPerso()
        For Each elem In _lstPersonnage
            If TypeOf elem Is Autorite Then
                For Each elemDetection In _lstPersonnage
                    CType(elem, Autorite).DetecterPersonnage(elemDetection)
                    If TypeOf elem Is Milice AndAlso TypeOf elemDetection Is Citoyen
                        CType(elem, Milice).DetecteCitoyen(elemDetection)
                    End If
                Next
                If CType(elem, Autorite).VuVraiFauxRefugie Then
                    CType(elem, Autorite).DeplacementAvecDetection()
                ElseIf TypeOf elem Is Milice AndAlso CType(elem, Milice).VuCitoyen
                    CType(elem,Milice).DeplacementAvecDetection()
                Else
                    elem.DeplacementPersonnage()
                End If
            ElseIf Not TypeOf elem Is Refugie Then
                elem.DeplacementPersonnage()
            End If
        Next
        _lstPersonnage(0).DeplacementPersonnage()

    End Sub

    ''' <summary>
    ''' Valide les collisions entre les différents personnages
    ''' </summary>
    Private Sub Collision()
        Dim listPersoRetirer As List(Of Personnages) = New List(Of Personnages)
        Dim listCitoyenChangerAAjouter As List(Of Personnages) = New List(Of Personnages)
        SortirLesCitoyens()
        For Each elem In _lstPersonnage
            If TypeOf elem Is Autorite AndAlso elem.Positionnement = _lstPersonnage(0).Positionnement Then
                _partieTermine = True
            End If
            If TypeOf elem Is Autorite Then
                For Each FauxRefugie In _lstPersonnage
                    If TypeOf FauxRefugie Is FauxRefugier AndAlso elem.Positionnement = FauxRefugie.Positionnement Then
                        listPersoRetirer.Add(FauxRefugie)
                    End If
                Next
            End If
            If TypeOf elem Is Milice OrElse TypeOf elem Is Refugie Then
                For Each citoyens In _lstPersonnage
                    If TypeOf citoyens Is Citoyen AndAlso elem.Positionnement = citoyens.Positionnement Then
                        If CType(citoyens, Citoyen).Mouton Then
                            listCitoyenChangerAAjouter.Add(CType(citoyens, Citoyen).ConvertirCitoyen(elem))
                            listPersoRetirer.Add(citoyens)
                        End If
                        If Typeof elem Is Milice then
                            CType(elem, Milice).VuCitoyen = False
                        End If
                    End If
                Next
            End If
        Next
        For Each citoyensChange In listCitoyenChangerAAjouter
            _lstPersonnage.Add(citoyensChange)
        Next
        For Each PersoAEnlever In listPersoRetirer
            _lstPersonnage.Remove(PersoAEnlever)
        Next
    End Sub

    ''' <summary>
    ''' Sort le cityoens du jeu lorsqu'il est rendu à sa destination final.
    ''' </summary>
    Private Sub SortirLesCitoyens()
        Dim lstAEnlever As List(Of Citoyen) = New List(Of Citoyen)
        For Each elem In _lstPersonnage
            If TypeOf elem Is Citoyen Then
                If CType(elem, Citoyen).HorsGrille Then
                    lstAEnlever.Add(elem)
                End If
            End If
        Next
        For Each citoyens In lstAEnlever
            _lstPersonnage.Remove(citoyens)
        Next
    End Sub
    Private Sub frmJeu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            lblErreur.Text = ""
            Select Case e.KeyCode
                Case Keys.A
                    CType(_lstPersonnage(0), Refugie).OuIlSeDirige = EDestination.VersLaGauche
                    e.Handled = true
                Case Keys.D
                    CType(_lstPersonnage(0), Refugie).OuIlSeDirige = EDestination.VersLaDroite
                    e.Handled = true
                Case Keys.W
                    CType(_lstPersonnage(0), Refugie).OuIlSeDirige = EDestination.VersLeHaut
                    e.Handled = true
                Case Keys.S
                    CType(_lstPersonnage(0), Refugie).OuIlSeDirige = EDestination.VersLeBas
                    e.Handled = true
                Case Else
            End Select
            _nbNombreTour += 1
            BougerToutPerso()
            If (_nbNombreTour Mod 5 = 0) Then
                _lstPersonnage.Add(New Citoyen(GenererPointCitoyen(), _nbLignesColonnesGrille))
            End If
            Collision()
            pctbox_GrilleJeu.Refresh()
            If _partieTermine Then
                MessageBox.Show( "Vous avec perdu avec le score de " & _nbNombreTour, "GameOver", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            lblErreur.Text = ex.Message
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim unePartie As New Partie(_nbNombreTour, _lstPersonnage, _nbLignesColonnesGrille)
        Dim fic As New FileStream("..\..\partie.dat", FileMode.Create)
        Dim bf As New BinaryFormatter
        bf.Serialize(fic, unePartie)
        fic.Close()
        lblErreur.Text = "Partie sauvegardée"
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Permet de transférer une partie afin d'initialiser les attributs à frmjeu
    ''' </summary>
    ''' <param name="unePartie">Prend une partie en paramètre</param>
    Public sub DonnerPartie(unePartie As Partie)
        _lstPersonnage = unePartie.ListePersonnage
        _nbNombreTour = unePartie.NbrTour
        _nbLignesColonnesGrille = unePartie.NbrColonneLigneGrille
    End sub

    ''' <summary>
    ''' Permet de créer une sauvegarde des statistiques lorsque la partie est terminé
    ''' </summary>
    ''' <returns>un objet meilleurScore</returns>
    Public Function DonnerScore() As MeilleurScore
          Return New MeilleurScore(_nbNombreTour, Date.Now)
    End Function
End Class