<Serializable>
Public MustInherit Class Ordinateur
    Inherits Personnages

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        MyBase.New(pPositionnement, pLimiteDeplacement)
    End Sub

End Class
