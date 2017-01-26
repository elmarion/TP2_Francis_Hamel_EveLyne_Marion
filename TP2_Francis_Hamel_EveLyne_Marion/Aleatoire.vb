
Public Class Aleatoire

    Private Shared rnd As Random

    Public Sub New()
        If rnd Is Nothing Then
            rnd = New Random()
        End If
    End Sub

    ''' <summary>
    ''' Obtient un nombre aléatoire entre les nombres donnés en paramètres
    ''' </summary>
    ''' <param name="pMin">Minimum</param>
    ''' <param name="pMax">Maximum</param>
    ''' <returns>Retoune un nombre entre minimum et maximum inclusivement</returns>
    Public Function ObtenirNombreEntre(pMin As Integer, pMax As Integer) As Integer
        Return rnd.Next(pMin, pMax + 1)
    End Function
End Class