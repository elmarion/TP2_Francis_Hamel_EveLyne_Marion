Public Enum EmplacementDepartCitoyen
    Gauche
    Droite
    Bas
    Haut
    CoinHGauche
    CoinHDroite
    CoinBGauche
    CoinBDroit
End Enum
<Serializable>
Public Class Citoyen
        Inherits Ordinateur
    Private _mouton As Boolean
    Private _destination As Point
    Private _DeplacementUntourSurDeux As Boolean
    Private _horsGrille As Boolean

#Region "Get|Set"
    Public Property HorsGrille() As Boolean
        Get
            Return _horsGrille
        End Get
        Set(ByVal value As Boolean)
            _horsGrille = value
        End Set
    End Property
    Public Property Destination() As Point
        Get
            Return _destination
        End Get
        Set(ByVal value As Point)
            _destination = value
        End Set
    End Property


    Public Property DeplacementUntourSurDeux() As Boolean
        Get
            Return _DeplacementUntourSurDeux
        End Get
        Set(ByVal value As Boolean)
            _DeplacementUntourSurDeux = value
        End Set
    End Property
    Public Property Mouton() As Boolean
        Get
            Return _mouton
        End Get
        Set(ByVal value As Boolean)
            _mouton = value
        End Set
    End Property
#End Region

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        MyBase.New(pPositionnement, pLimiteDeplacement)
        Image = New Bitmap(Image.FromFile("../../Images/citoyen.png"), 50, 50)
        Deplacement = 1
        HorsGrille = False
        If New Aleatoire().ObtenirNombreEntre(0, 100) <= 60 Then
            _mouton = True
        Else
            _mouton = False
        End If
        DeplacementUntourSurDeux = False
        ChoixDirectionCitoyen()
    End Sub

    ''' <summary>
    ''' Choisi une aléatoirement une destination vers l'un des périphéries opposée.
    ''' </summary>
    Private Sub ChoixDirectionCitoyen()
        Dim rnd As Aleatoire = New Aleatoire()
        If Positionnement.X > 0 AndAlso Positionnement.X < LimiteDeplacement - 1 Then
            Select Case rnd.ObtenirNombreEntre(1, 3)
                Case 1
                    Destination = New Point(Positionnement.X, LimiteDeplacement - 1 - Positionnement.Y)
                Case 2
                    Destination = New Point(LimiteDeplacement - 1 - Positionnement.Y, LimiteDeplacement - 1 - Positionnement.X)
                Case 3
                    Destination = New Point(LimiteDeplacement - 1 - (LimiteDeplacement - 1 - Positionnement.Y), LimiteDeplacement - 1 - (LimiteDeplacement - 1 - Positionnement.X))
            End Select
        ElseIf Positionnement.Y > 0 AndAlso Positionnement.Y < LimiteDeplacement - 1 Then
            Select Case rnd.ObtenirNombreEntre(1, 3)
                Case 1
                    Destination = New Point(LimiteDeplacement - 1 - Positionnement.X, Positionnement.Y)
                Case 2
                    Destination = New Point(LimiteDeplacement - 1 - Positionnement.Y, LimiteDeplacement - 1 - Positionnement.X)
                Case 3
                    Destination = New Point(LimiteDeplacement - 1 - (LimiteDeplacement - 1 - Positionnement.Y), LimiteDeplacement - 1 - (LimiteDeplacement - 1 - Positionnement.X))
            End Select
        ElseIf Positionnement.X = Positionnement.Y Then
            Select Case rnd.ObtenirNombreEntre(1, 3)
                Case 1
                    Destination = New Point(Positionnement.X, LimiteDeplacement - 1 - Positionnement.Y)
                Case 2
                    Destination = New Point(LimiteDeplacement - 1 - Positionnement.X, Positionnement.Y)
                Case 3
                    Destination = New Point(LimiteDeplacement - 1 - Positionnement.Y, LimiteDeplacement - 1 - Positionnement.X)
            End Select
        Else
            Select Case rnd.ObtenirNombreEntre(1, 3)
                Case 1
                    Destination = New Point(Positionnement.X, LimiteDeplacement - 1 - Positionnement.Y)
                Case 2
                    Destination = New Point(LimiteDeplacement - 1 - Positionnement.X, Positionnement.Y)
                Case 3
                    Destination = New Point(LimiteDeplacement - 1 - (LimiteDeplacement - 1 - Positionnement.Y), LimiteDeplacement - 1 - (LimiteDeplacement - 1 - Positionnement.X))
            End Select
        End If
    End Sub

    ''' <summary>
    ''' Déplacement du personnage selon la destination de celui-ci
    ''' </summary>
    Public Overrides Sub DeplacementPersonnage()
        Dim nouveauX As Integer = Positionnement.X
        Dim nouveauY As Integer = Positionnement.Y
        If DeplacementUntourSurDeux Then

            If Not (Positionnement = Destination) Then

                If Destination.X - Positionnement.X > 0 Then
                    nouveauX = Positionnement.X + Deplacement
                ElseIf Destination.X - Positionnement.X < 0 Then
                    nouveauX = Positionnement.X - Deplacement
                End If
                If Destination.Y - Positionnement.Y > 0 Then
                    nouveauY = Positionnement.Y + Deplacement
                ElseIf Destination.Y - Positionnement.Y < 0 Then
                    nouveauY = Positionnement.Y - Deplacement
                End If
                Positionnement = New Point(nouveauX, nouveauY)
                DeplacementUntourSurDeux = False
            Else
                HorsGrille = True
            End If
        Else
            DeplacementUntourSurDeux = True
        End If
    End Sub

''' <summary>
''' Convertir un citoyen selon le personnage qui à rencontré.
''' Si il rencontre un réfugié, il devient faux réfugié 
''' si il rencontre milice, il devient une milice.
''' </summary>
''' <param name="pBerger"></param>
''' <returns>Retourne le personnage convertie</returns>
    Public Function ConvertirCitoyen(pBerger As Personnages) As Personnages
        If _mouton Then
            If TypeOf (pBerger) Is Milice Then
                Return New Milice(pBerger.Positionnement, LimiteDeplacement)
            ElseIf TypeOf (pBerger) Is Refugie Then
                Return New FauxRefugier(pBerger.Positionnement, LimiteDeplacement)
            Else
                Return Me
            End If
        Else
            Return Me
        End If
    End Function
End Class
