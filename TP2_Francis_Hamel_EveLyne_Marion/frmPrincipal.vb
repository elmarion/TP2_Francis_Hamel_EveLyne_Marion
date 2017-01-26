Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmPrincipal
    Private _lstPersonnage As New List(Of Personnages)
    Private _nbLignesColonnesGrille As Integer
    Private _nbNombreTour As Integer
    Private _meilleurScore As New List(Of MeilleurScore)
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        NouvellePartie()
        Dim formJeu As New frmJeu
        formJeu.DonnerPartie(New Partie(_nbNombreTour, _lstPersonnage, _nbLignesColonnesGrille))
        If formJeu.ShowDialog() = DialogResult.OK Then
            _meilleurScore.Add(formJeu.DonnerScore())
        End If
        formJeu.Close()
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub

    Private Sub btnCharger_Click(sender As Object, e As EventArgs) Handles btnCharger.Click
         If File.Exists("..\..\partie.dat") Then
            Dim fic As New FileStream("..\..\partie.dat", FileMode.Open)
            Dim binaryReader As New BinaryFormatter
            Dim unePartie As Partie = binaryReader.Deserialize(fic)
            _lstPersonnage = unePartie.ListePersonnage
            _nbNombreTour = unePartie.NbrTour
            _nbLignesColonnesGrille = unePartie.NbrColonneLigneGrille
            fic.Close()
        Dim formJeu As New frmJeu
        formJeu.DonnerPartie(New Partie(_nbNombreTour, _lstPersonnage, _nbLignesColonnesGrille))
        If formJeu.ShowDialog() = DialogResult.OK Then
            _meilleurScore.Add(formJeu.DonnerScore())
        End If
        Else
            MessageBox.Show("Il faudrait avoir sauvegarder une partie avant...", "Pas fort !")
        End If
    End Sub

    ''' <summary>
    ''' Création d'une nouvel partie.
    ''' </summary>
    Private sub NouvellePartie()
            _lstPersonnage.Clear
            _nbLignesColonnesGrille = 14
        _lstPersonnage.Add(New Refugie(New Point(0, 0), _nbLignesColonnesGrille))
        _lstPersonnage.Add(New Patrouilleur(New Point(10, 10), _nbLignesColonnesGrille))
            _lstPersonnage.Add(New Douanier(New Point(11, 11), _nbLignesColonnesGrille))
            _lstPersonnage.Add(New Milice(New Point(13, 13), _nbLignesColonnesGrille))
            _lstPersonnage.Add(New Citoyen(New Point(13, 7), _nbLignesColonnesGrille))
            _nbNombreTour = 0
    End sub

    Private Sub btnMeilleurResultat_Click(sender As Object, e As EventArgs) Handles btnMeilleurResultat.Click
         Dim formMeilleurScore As New frmMeilleurScore
        formMeilleurScore.ObtenirListeScore(_meilleurScore)
        formMeilleurScore.ShowDialog()
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fic As New FileStream("..\..\meilleurScore.dat", FileMode.Create)
        Dim bf As New BinaryFormatter
        bf.Serialize(fic, _meilleurScore)
        fic.Close()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         If File.Exists("..\..\meilleurScore.dat") Then
            Dim fic As New FileStream("..\..\meilleurScore.dat", FileMode.Open)
            Dim binaryReader As New BinaryFormatter
            _meilleurScore = binaryReader.Deserialize(fic)
            fic.Close()
         End If
    End Sub

    Private Sub btnCommentJouer_Click(sender As Object, e As EventArgs) Handles btnCommentJouer.Click
        Dim formCommentjouer As New frmCommentJouer
        formCommentjouer.ShowDialog()
    End Sub
End Class