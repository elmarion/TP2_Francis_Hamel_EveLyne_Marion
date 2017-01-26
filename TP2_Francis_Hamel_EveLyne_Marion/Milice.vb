<Serializable>
Public Class Milice
    Inherits Autorite
    Private _VuCitoyen As Boolean
    Private _caseDetectionCitoyen As Integer

#Region "Get|Set"
    Public Property CaseDetectionCitoyen() As Integer
        Get
            Return _caseDetectionCitoyen
        End Get
        Set(ByVal value As Integer)
            _caseDetectionCitoyen = value
        End Set
    End Property
    Public Property VuCitoyen() As Boolean
        Get
            Return _VuCitoyen
        End Get
        Set(ByVal value As Boolean)
            _VuCitoyen = value
        End Set
    End Property
#End Region

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        MyBase.New(pPositionnement, pLimiteDeplacement)
        Image = New Bitmap(Image.FromFile("../../Images/redneck.png"), 50, 50)
        Deplacement = 1
        CaseDetection = 3
        CaseDetectionCitoyen = 5
    End Sub

    ''' <summary>
    ''' Regarde s'il à détecté un citoyen selon le nombre de case qu'il peut détecter
    ''' </summary>
    ''' <param name="pCitoyen">prend un citoyen en paramètre</param>
    Public Sub DetecteCitoyen(pCitoyen As Citoyen)
        If VuVraiFauxRefugie Then
            _VuCitoyen = False
        Else
            If Math.Abs(pCitoyen.Positionnement.X - Positionnement.X) + Math.Abs(pCitoyen.Positionnement.Y - Positionnement.Y) <= CaseDetectionCitoyen Then
                _VuCitoyen = True
                ListePersonnageDetecter.Add(pCitoyen)
            Else
                _VuCitoyen = False
            End If
        End If
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
                    nouveauX = Positionnement.X - Deplacement
                Case 2
                    nouveauX = Positionnement.X + Deplacement
                Case 3
                    nouveauY = Positionnement.Y + Deplacement
                Case 4
                    nouveauY = Positionnement.Y - Deplacement
            End Select
        Loop While nouveauX > LimiteDeplacement - 1 OrElse nouveauX < 0 OrElse nouveauY > LimiteDeplacement - 1 OrElse nouveauY < 0
        Positionnement = New Point(nouveauX, nouveauY)
    End Sub
End Class