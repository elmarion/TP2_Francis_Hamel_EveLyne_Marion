Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class CitoyenTest

    <TestMethod()> Public Sub CreerCitoyen()
        Dim unCitoyen As New Citoyen(New Point(0, 0), 14)
        Assert.AreEqual(unCitoyen.Deplacement, 1)
        Assert.IsFalse(unCitoyen.HorsGrille)
        Assert.IsFalse(unCitoyen.DeplacementUntourSurDeux)
        Assert.AreEqual(unCitoyen.Positionnement.X, 0)
        Assert.AreEqual(unCitoyen.Positionnement.Y, 0)
        Dim unPoint As New Point(0, 0)
        Assert.AreEqual(unCitoyen.Positionnement, unPoint)
        Assert.AreEqual(unCitoyen.LimiteDeplacement, 14)
    End Sub

    <TestMethod()> Public Sub ConvertirCitoyen()
        Dim unCitoyen As New Citoyen(New Point(0, 0), 14)
        Dim uneMilice As New Milice(New Point(0, 0), 14)
        Dim unPerso As Personnages
        unPerso = unCitoyen.ConvertirCitoyen(uneMilice)
        If unCitoyen.Mouton Then
            Assert.AreSame(unPerso, CType(unPerso, Milice))
        Else
            Assert.AreSame(unPerso, unCitoyen)
        End If
        Dim unRefugie As New Refugie(New Point(0, 0), 14)
        unPerso = unCitoyen.ConvertirCitoyen(unRefugie)
        If unCitoyen.Mouton Then
            Assert.AreSame(unPerso, CType(unPerso, FauxRefugier))
        Else
            Assert.AreSame(unPerso, unCitoyen)
        End If

    End Sub

    <TestMethod()> Public Sub DeplacementCitoyen()
        Dim unCitoyen As New Citoyen(New Point(0, 0), 14)
        unCitoyen.DeplacementUntourSurDeux = True
        unCitoyen.DeplacementPersonnage()
        If unCitoyen.Positionnement.X <> 0 Then
            Assert.AreEqual(Math.Abs(unCitoyen.Positionnement.X - 0), unCitoyen.Deplacement)
        Else
            Assert.AreEqual(Math.Abs(unCitoyen.Positionnement.Y - 0), unCitoyen.Deplacement)
        End If
        Assert.IsFalse(unCitoyen.DeplacementUntourSurDeux)
    End Sub
End Class