<Serializable>
Public Class Partie
    Private _nbrTour As Integer
    Private _listPersonnage As List(Of Personnages)
    Private _nbrColonneLigneGrille As Integer

#Region "Get|Set"
    Public Property NbrColonneLigneGrille() As Integer
        Get
            Return _nbrColonneLigneGrille
        End Get
        Set(ByVal value As Integer)
            _nbrColonneLigneGrille = value
        End Set
    End Property
    Public Property ListePersonnage() As List(Of Personnages)
        Get
            Return _listPersonnage
        End Get
        Set(ByVal value As List(Of Personnages))
            _listPersonnage = value
        End Set
    End Property
    Public Property NbrTour() As Integer
        Get
            Return _nbrTour
        End Get
        Set(ByVal value As Integer)
            _nbrTour = value
        End Set
    End Property
#End Region

    Public sub New(pNbrTour As integer, pListePersonnage As List(Of Personnages), pNbrColonneLigneGrille As integer)
        NbrTour = pNbrTour
        ListePersonnage = pListePersonnage
        NbrColonneLigneGrille = pNbrColonneLigneGrille
    End sub
End Class
