<Serializable>
Public MustInherit Class Personnages
    Private _positionnement As Point
    Private _image As Image
    Private _deplacement As Integer
    Private _limiteDeplacement As Integer

#Region "Get|Set"
    Public Property LimiteDeplacement() As Integer
        Get
            Return _limiteDeplacement
        End Get
        Set(ByVal value As Integer)
            _limiteDeplacement = value
        End Set
    End Property
    Public Property Deplacement() As Integer
        Get
            Return _deplacement
        End Get
        Set(ByVal value As Integer)
            _deplacement = value
        End Set
    End Property
    Public Property Image() As Image
        Get
            Return _image
        End Get
        Set(ByVal value As Image)
            _image = value
        End Set
    End Property
    Public Property Positionnement() As Point
        Get
            Return _positionnement
        End Get
        Set(ByVal value As Point)
            _positionnement = value
        End Set
    End Property
#End Region

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        Positionnement = pPositionnement
        LimiteDeplacement = pLimiteDeplacement
    End Sub

    ''' <summary>
    ''' Déplacement du personnage selon l'algorithme correspondant.
    ''' </summary>
    Public MustOverride Sub DeplacementPersonnage()

    ''' <summary>
    ''' Convertie un point en pixel par bond de 50 pixels. 
    ''' </summary>
    ''' <returns>retourne une nouvelle coordonner adapté au pixel.</returns>
    Public function ConvertirMatricePixels() As point
        return New Point(Positionnement.X * 50, Positionnement.Y * 50)
    End function
End Class
