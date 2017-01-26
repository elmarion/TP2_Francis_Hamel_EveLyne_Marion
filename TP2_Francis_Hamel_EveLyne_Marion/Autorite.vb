<Serializable>
Public MustInherit Class Autorite
    Inherits Ordinateur
    Private _caseDetection As Integer
    Private _PersonnageDetecte As Personnages
    Private _VuVraiFauxRefugie As Boolean
    Private _deplacementSiDetection As Integer
    Private _listePersonnageDetecter As List(Of Personnages)

#Region "Get|Set"
    Public Property ListePersonnageDetecter() As List(Of Personnages)
        Get
            Return _listePersonnageDetecter
        End Get
        Set(ByVal value As List(Of Personnages))
            _listePersonnageDetecter = value
        End Set
    End Property
    Public Property DeplacementSiDetection() As Integer
        Get
            Return _deplacementSiDetection
        End Get
        Set(ByVal value As Integer)
            _deplacementSiDetection = value
        End Set
    End Property
    Public Property VuVraiFauxRefugie() As Boolean
        Get
            Return _VuVraiFauxRefugie
        End Get
        Set(ByVal value As Boolean)
            _VuVraiFauxRefugie = value
        End Set
    End Property
    Public Property PersonnageDetecte() As Personnages
        Get
            Return _PersonnageDetecte
        End Get
        Set(ByVal value As Personnages)
            _PersonnageDetecte = value
        End Set
    End Property
    Public Property CaseDetection() As Integer
        Get
            Return _caseDetection
        End Get
        Set(ByVal value As Integer)
            _caseDetection = value
        End Set
    End Property

#End Region

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        MyBase.New(pPositionnement, pLimiteDeplacement)
        DeplacementSiDetection = 1
        ListePersonnageDetecter = New List(Of Personnages)
    End Sub

    ''' <summary>
    ''' Détection du réfugié selon le nombre de case à laquelle le personnage peut voir
    ''' </summary>
    ''' <param name="pPersonnage">Prend un personnage à détecter</param>
    Public Sub DetecterPersonnage(pPersonnage As Personnages)
        If TypeOf pPersonnage Is Refugie OrElse TypeOf pPersonnage Is FauxRefugier Then
            If Math.Abs(pPersonnage.Positionnement.X - Positionnement.X) +
                Math.Abs(pPersonnage.Positionnement.Y - Positionnement.Y) <= CaseDetection Then
                ListePersonnageDetecter.Add(pPersonnage)
                VuVraiFauxRefugie = True
            End If
        End If

        If ListePersonnageDetecter.Count = 0 Then
            VuVraiFauxRefugie = False
        End If
    End Sub

    ''' <summary>
    ''' Prend le personnage le plus proche comme cible.
    ''' </summary>
    Private Sub PrioriteDetection()
        PersonnageDetecte = ListePersonnageDetecter(0)
        For index = 1 To ListePersonnageDetecter.Count - 1
            If Math.Abs(ListePersonnageDetecter(index).Positionnement.X - Positionnement.X) + Math.Abs(ListePersonnageDetecter(index).Positionnement.Y - Positionnement.Y) <
                    Math.Abs(PersonnageDetecte.Positionnement.X - Positionnement.X) + Math.Abs(PersonnageDetecte.Positionnement.Y - Positionnement.Y) Then
                PersonnageDetecte = ListePersonnageDetecter(index)
            ElseIf Math.Abs(ListePersonnageDetecter(index).Positionnement.X - Positionnement.X) + Math.Abs(ListePersonnageDetecter(index).Positionnement.Y - Positionnement.Y) =
                    Math.Abs(PersonnageDetecte.Positionnement.X - Positionnement.X) + Math.Abs(PersonnageDetecte.Positionnement.Y - Positionnement.Y) Then

                If New Aleatoire().ObtenirNombreEntre(1, 2) = 1 Then
                    PersonnageDetecte = ListePersonnageDetecter(index)
                End If
            End If
        Next
        ListePersonnageDetecter.Clear()
    End Sub

    ''' <summary>
    ''' Déplace le personnage lorsqu'il a détecté une cible
    ''' </summary>
    Public Sub DeplacementAvecDetection()
        Dim rnd As Aleatoire = New Aleatoire()
        Dim nouveauX As Integer = Positionnement.X
        Dim nouveauY As Integer = Positionnement.Y
        PrioriteDetection()
        Select Case rnd.ObtenirNombreEntre(1, 2)
            Case 1
                If PersonnageDetecte.Positionnement.X - Positionnement.X >= 1 Then
                    nouveauX = Positionnement.X + DeplacementSiDetection
                ElseIf PersonnageDetecte.Positionnement.X - Positionnement.X <= -1 Then
                    nouveauX = Positionnement.X - DeplacementSiDetection
                Else
                    If PersonnageDetecte.Positionnement.Y - Positionnement.Y >= 1 Then
                        nouveauY = Positionnement.Y + DeplacementSiDetection
                    ElseIf PersonnageDetecte.Positionnement.Y - Positionnement.Y <= -1 Then
                        nouveauY = Positionnement.Y - DeplacementSiDetection
                    Else
                        PersonnageDetecte = Nothing
                        VuVraiFauxRefugie = False
                    End If
                End If
            Case 2
                If PersonnageDetecte.Positionnement.Y - Positionnement.Y >= 1 Then
                    nouveauY = Positionnement.Y + DeplacementSiDetection
                ElseIf PersonnageDetecte.Positionnement.Y - Positionnement.Y <= -1 Then
                    nouveauY = Positionnement.Y - DeplacementSiDetection
                Else
                    If PersonnageDetecte.Positionnement.X - Positionnement.X >= 1 Then
                        nouveauX = Positionnement.X + DeplacementSiDetection
                    ElseIf PersonnageDetecte.Positionnement.X - Positionnement.X <= -1 Then
                        nouveauX = Positionnement.X - DeplacementSiDetection
                    Else
                        PersonnageDetecte = Nothing
                        VuVraiFauxRefugie = False
                    End If
                End If
        End Select
        Positionnement = New Point(nouveauX, nouveauY)
    End Sub
End Class
