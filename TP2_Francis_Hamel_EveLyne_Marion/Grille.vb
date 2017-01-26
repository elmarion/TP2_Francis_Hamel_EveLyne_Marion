Public Class Grille
    Private _nbLignesColonne As Integer

#Region "Get|Set"
    Public Property NbLignesColonnes() As Integer
        Get
            Return _nbLignesColonne
        End Get
        Set(ByVal value As Integer)
            _nbLignesColonne = value
        End Set
    End Property
#End Region

    Public Sub New(pNbLignesColonnes As Integer)
        NbLignesColonnes = pNbLignesColonnes
    End Sub

    ''' <summary>
    ''' Dessine une grille de jeu avec des cases de 50X50 pixels.
    ''' </summary>
    ''' <param name="pctbox">Prend un élément graphique en paramètre.</param>
    Public Sub DessinerGrille(pctbox As Graphics)
        For index = 0 To NbLignesColonnes
            pctbox.DrawLine(New Pen(Color.Gold, 3), New Point(index * 50, 0), New Point(index * 50, 700))
            pctbox.DrawLine(New Pen(Color.Gold, 3), New Point(0, index * 50), New Point(700, index * 50))
        Next
    End Sub
End Class
