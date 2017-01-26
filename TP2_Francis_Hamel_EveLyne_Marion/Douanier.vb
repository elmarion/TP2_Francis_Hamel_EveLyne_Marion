<Serializable>
Public Class Douanier
    Inherits Autorite

    Public Sub New(pPositionnement As Point, pLimiteDeplacement As Integer)
        MyBase.New(pPositionnement, pLimiteDeplacement)
        Image = New Bitmap(Image.FromFile("../../Images/douane.png"), 50, 50)
        Deplacement = 1
        CaseDetection = 5

    End Sub

    ''' <summary>
    ''' Déplace le douanier pour le diriger vers sa séquence 
    ''' le plus rapidement possible lorsqu'il n'est plus dans sa séquence habituelle
    ''' </summary>
    Private Sub DeplacementDouanierHorsSequence()
        Dim leDeplacement As Integer = Deplacement
        Dim nouveauX As Integer = Positionnement.X
        Dim nouveauY As Integer = Positionnement.Y
        Dim lstInt As New List(Of Integer)
       If (Positionnement.X = LimiteDeplacement - 3 AndAlso (Positionnement.Y >= 2 AndAlso Positionnement.Y <= LimiteDeplacement -3)) OrElse 
            (Positionnement.X = 2 AndAlso (Positionnement.Y >= 2 AndAlso Positionnement.Y <= LimiteDeplacement -3)) OrElse
                (Positionnement.Y = LimiteDeplacement - 3 AndAlso (Positionnement.X >= 2 AndAlso Positionnement.X <= LimiteDeplacement -3)) OrElse 
                (Positionnement.Y = 2 AndAlso (Positionnement.X >= 2 AndAlso Positionnement.X <= LimiteDeplacement -3)) Then
            Throw New Exception("Il est déjà dans sa track")
        Else

        If Positionnement.X > LimiteDeplacement - 3 OrElse Positionnement.X < 2 OrElse
                Positionnement.Y > LimiteDeplacement - 3 OrElse Positionnement.Y < 2 Then
                leDeplacement = -leDeplacement
        End If
            
            lstInt.Add(Math.Abs(Positionnement.X - 2))
            lstInt.Add(Math.Abs(Positionnement.X - (LimiteDeplacement - 3)))
            lstInt.Add(Math.Abs(Positionnement.Y - 2))
            lstInt.Add(Math.Abs(Positionnement.Y - (LimiteDeplacement - 3)))


            If lstInt(0) <= lstInt(1) AndAlso lstInt(0) <= lstInt(2) AndAlso lstInt(0) <= lstInt(3)
                nouveauX = Positionnement.X - leDeplacement
            ElseIf lstInt(1) <= lstInt(0) AndAlso lstInt(1) <= lstInt(2) AndAlso lstInt(1) <= lstInt(3)
                nouveauX = Positionnement.X + leDeplacement
            ElseIf lstInt(2) <= lstInt(0) AndAlso lstInt(2) <= lstInt(1) AndAlso lstInt(2) <= lstInt(3)
                nouveauY = Positionnement.Y - leDeplacement
            ElseIf lstInt(3) <= lstInt(0) AndAlso lstInt(3) <= lstInt(1) AndAlso lstInt(3) <= lstInt(2)
                nouveauY = Positionnement.Y + leDeplacement
            End If
                End If
        Positionnement = New Point(nouveauX, nouveauY)
    End Sub

    ''' <summary>
    ''' Déplace le douanier selon une séquence en forme de carré du longueur de côté
    ''' égale à celle de la grille - 2 cases.
    ''' </summary>
    Public Overrides Sub DeplacementPersonnage()
        Dim nouveauX As Integer = Positionnement.X
        Dim nouveauY As Integer = Positionnement.Y

        If (Positionnement.X = LimiteDeplacement - 3 AndAlso (Positionnement.Y >= 2 AndAlso Positionnement.Y <= LimiteDeplacement -3)) OrElse 
            (Positionnement.X = 2 AndAlso (Positionnement.Y >= 2 AndAlso Positionnement.Y <= LimiteDeplacement -3)) OrElse
                (Positionnement.Y = LimiteDeplacement - 3 AndAlso (Positionnement.X >= 2 AndAlso Positionnement.X <= LimiteDeplacement -3)) OrElse 
                (Positionnement.Y = 2 AndAlso (Positionnement.X >= 2 AndAlso Positionnement.X <= LimiteDeplacement -3)) Then

            If Positionnement.X = LimiteDeplacement - 3 Then
                If Positionnement.Y = 2 Then
                    nouveauX = Positionnement.X - 1
                Else
                    nouveauY = Positionnement.Y - 1
                End If
            ElseIf Positionnement.X = 2 Then
                If Positionnement.Y = LimiteDeplacement - 3 Then
                    nouveauX = Positionnement.X + 1
                Else
                    nouveauY = Positionnement.Y + 1
                End If
            Else
                If Positionnement.Y = 2 Then
                    nouveauX = Positionnement.X - 1
                ElseIf Positionnement.Y = LimiteDeplacement - 3 Then
                    nouveauX = Positionnement.X + 1
                End If
            End If
            Positionnement = New Point(nouveauX, nouveauY)
        Else
            DeplacementDouanierHorsSequence()
        End If
    End Sub
End Class
