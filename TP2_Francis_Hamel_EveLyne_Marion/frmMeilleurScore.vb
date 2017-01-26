Public Class frmMeilleurScore
    Private listeScore As List(Of MeilleurScore)

    ''' <summary>
    ''' Permet d'initialiser l'attribut liste de score pour pouvoir afficher les meilleurs résultats
    ''' </summary>
    ''' <param name="pUneListeDeScore">Prend une liste de meilleurScore</param>
    Public sub ObtenirListeScore(pUneListeDeScore As List(Of MeilleurScore))
        listeScore = pUneListeDeScore 
    End sub

    Private Sub frmMeilleurScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       listeScore.Sort(Function(x,y) x.NbrTour.CompareTo(y.NbrTour))

        For index = listeScore.Count -1 To 0 Step -1
            lstScore.Items.Add(listeScore(index))
        Next
     End sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        me.close()
    End Sub
End Class