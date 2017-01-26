Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class DouanierTest

    <TestMethod()> Public Sub CreerUnDouanier()
        Dim unDouanier As New Douanier(New Point(0, 0), 14)
        Assert.AreEqual(unDouanier.CaseDetection, 5)
        Assert.AreEqual(unDouanier.Deplacement, 1)
        Assert.AreEqual(unDouanier.Positionnement.X, 0)
        Assert.AreEqual(unDouanier.Positionnement.Y, 0)
        Dim unPoint As New Point(0, 0)
        Assert.AreEqual(unDouanier.Positionnement, unPoint)
        Assert.AreEqual(unDouanier.LimiteDeplacement, 14)
    End Sub

    <TestMethod()> Public Sub DeplacerDouanier()
        Dim unDouanier As New Douanier(New Point(11, 11), 14)
        Dim unX As Integer = 11
        Dim unY As Integer = 11
        For i = 1 To 9
            unDouanier.DeplacementPersonnage()
            unY = unY - 1
            Assert.AreEqual(unDouanier.Positionnement.X, 11)
            Assert.AreEqual(unDouanier.Positionnement.Y, unY)
        Next
        For i = 1 To 9
            unDouanier.DeplacementPersonnage()
            unX = unX - 1
            Assert.AreEqual(unDouanier.Positionnement.X, unX)
            Assert.AreEqual(unDouanier.Positionnement.Y, unY)
        Next
        For i = 1 To 9
            unDouanier.DeplacementPersonnage()
            unY = unY + 1
            Assert.AreEqual(unDouanier.Positionnement.X, unX)
            Assert.AreEqual(unDouanier.Positionnement.Y, unY)
        Next
        For i = 1 To 9
            unDouanier.DeplacementPersonnage()
            unX = unX + 1
            Assert.AreEqual(unDouanier.Positionnement.X, unX)
            Assert.AreEqual(unDouanier.Positionnement.Y, unY)
        Next
    End Sub

End Class