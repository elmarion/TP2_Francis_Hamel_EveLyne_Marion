<Serializable>
Public Class Patrouilleur
    Inherits Autorite

#Region "Get|Set"

#End Region

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        MyBase.New(pPositionnement, pLimiteDeplacement)
        Image = New Bitmap(Image.FromFile("../../Images/patrol.png"), 50, 50)
        Deplacement = 2
        CaseDetection = 4
    End Sub

    ''' <summary>
    ''' Déplace le patrouilleur selon ses caractéristiques de déplacement
    ''' Il ne sortira jamais de la grille
    ''' </summary>
    Public Overrides Sub DeplacementPersonnage()
        Dim rnd As New Aleatoire
        Dim deplacementAleatoireX As Integer
        Dim deplacementAleatoireY As Integer
        Dim nouveauX As Integer
        Dim nouveauY As Integer
        Do
            deplacementAleatoireX = rnd.ObtenirNombreEntre(-2, 2)
            deplacementAleatoireY = Deplacement - Math.Abs(deplacementAleatoireX)
            If rnd.ObtenirNombreEntre(0, 1) = 0 Then
                deplacementAleatoireY = -deplacementAleatoireY
            End If
            nouveauX = Positionnement.X + deplacementAleatoireX
            nouveauY = Positionnement.Y + deplacementAleatoireY
        Loop While nouveauX > LimiteDeplacement - 1 OrElse nouveauX < 0 OrElse nouveauY > LimiteDeplacement - 1 OrElse nouveauY < 0
        Positionnement = New Point(nouveauX, nouveauY)
    End Sub
End Class
