Public Enum EDestination
    VersLaGauche
    VersLaDroite
    VersLeBas
    VersLeHaut
End Enum
<Serializable>
Public Class Refugie
    Inherits Personnages

    Private _OuIlSeDirige As EDestination

#Region "Get|Set"

    Public Property OuIlSeDirige() As EDestination
        Get
            Return _OuIlSeDirige
        End Get
        Set(ByVal value As EDestination)
            If value = EDestination.VersLaGauche AndAlso Positionnement.X - 1 < 0 Then
                Throw New Exception("En dehors de la grille")
            ElseIf value = EDestination.VersLaDroite AndAlso Positionnement.X + 1 > LimiteDeplacement - 1Then
                Throw New Exception("En dehors de la grille")
            ElseIf value = EDestination.VersLeHaut AndAlso Positionnement.Y - 1 < 0 Then
                Throw New Exception("En dehors de la grille")
            ElseIf value = EDestination.VersLeBas AndAlso Positionnement.Y + 1 > LimiteDeplacement -1 Then
                Throw New Exception("En dehors de la grille")
            Else
                _OuIlSeDirige = value
            End If
        End Set
    End Property
#End Region

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        MyBase.New(pPositionnement, pLimiteDeplacement)
        Image = New Bitmap(Image.FromFile("../../Images/refugee.png"), 50, 50)
        Deplacement = 1
    End Sub

    ''' <summary>
    ''' Déplacement du personnage selon les directive de l'utilisateur.
    ''' </summary>
    Public Overrides Sub DeplacementPersonnage()
        Select Case OuIlSeDirige
            Case EDestination.VersLaGauche
                Positionnement = New Point(Positionnement.X - Deplacement, Positionnement.Y)
            Case EDestination.VersLaDroite
                Positionnement = New Point(Positionnement.X + Deplacement, Positionnement.Y)
            Case EDestination.VersLeHaut
                Positionnement = New Point(Positionnement.X, Positionnement.Y - Deplacement)
            Case EDestination.VersLeBas
                Positionnement = New Point(Positionnement.X, Positionnement.Y + Deplacement)
        End Select
    End Sub
End Class
