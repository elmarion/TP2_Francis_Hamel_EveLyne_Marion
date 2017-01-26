<Serializable>
Public Class MeilleurScore
    Private _nbrTour As Integer
    Private _date As Date

#Region "Get|Set"
    Public Property laDate() As Date
        Get
            Return _date
        End Get
        Set(ByVal value As Date)
            _date = value
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

    Public sub New(pNbrTour As Integer, pDate As Date)
        laDate = pDate
        NbrTour = pNbrTour
    End sub
    Public Overrides Function ToString() As String
	    Return String.Format("Date:{0}:{1}:{2} à {3} heures :{4} minutes avec le score de {5}", laDate.Year, laDate.Month, laDate.Day, laDate.hour, ladate.Minute, NbrTour)
	End Function

End Class
