<Serializable>
Public Class FauxRefugier
    Inherits Citoyen

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        MyBase.New(pPositionnement, pLimiteDeplacement)
        Image = New Bitmap(Image.FromFile("../../Images/fauxrefugie.png"), 50, 50)
        Deplacement = 1
    End Sub

    ''' <summary>
    ''' Déplacement du personnage de façon aléatoire.
    ''' </summary>
    Public Overrides Sub DeplacementPersonnage()
        Dim rnd As New Aleatoire()
        Dim nouveauX As Integer = Positionnement.X
        Dim nouveauY As Integer = Positionnement.Y
        Do
            Select Case rnd.ObtenirNombreEntre(1, 4)
                Case 1
                    nouveauX = Positionnement.X - 1
                Case 2
                    nouveauX = Positionnement.X + 1
                Case 3
                    nouveauY = Positionnement.Y + 1
                Case 4
                    nouveauY = Positionnement.Y - 1
            End Select
        Loop While nouveauX > LimiteDeplacement - 1 OrElse nouveauX < 0 OrElse nouveauY > LimiteDeplacement - 1 OrElse nouveauY < 0
        Positionnement = New Point(nouveauX, nouveauY)
    End Sub
End Class
