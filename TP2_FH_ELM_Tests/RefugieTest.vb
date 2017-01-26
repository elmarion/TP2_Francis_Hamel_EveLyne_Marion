Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class RefugieTest

    <TestMethod()> Public Sub CreationRefugie()
        Dim unRefugie As New Refugie(New Point(0, 0), 14)
        Assert.AreEqual(unRefugie.Deplacement, 1)
        Assert.AreEqual(unRefugie.LimiteDeplacement, 14)
        Assert.AreEqual(unRefugie.Positionnement.X, 0)
        Assert.AreEqual(unRefugie.Positionnement.Y, 0)
        Dim unPoint As New Point(0, 0)
        Assert.AreEqual(unRefugie.Positionnement, unPoint)
    End Sub


    <TestMethod()> Public Sub DeplacementRefugie()
        Dim unRefugie As New Refugie(New Point(0, 0), 14)
        unRefugie.OuIlSeDirige = EDestination.VersLaDroite
        unRefugie.DeplacementPersonnage()
        Assert.AreEqual(unRefugie.Positionnement.X, 1)
        unRefugie.OuIlSeDirige = EDestination.VersLaGauche
        unRefugie.DeplacementPersonnage()
        Assert.AreEqual(unRefugie.Positionnement.X, 0)
        unRefugie.OuIlSeDirige = EDestination.VersLeBas
        unRefugie.DeplacementPersonnage()
        Assert.AreEqual(unRefugie.Positionnement.Y, 1)
        unRefugie.OuIlSeDirige = EDestination.VersLeHaut
        unRefugie.DeplacementPersonnage()
        Assert.AreEqual(unRefugie.Positionnement.Y, 0)
    End Sub
End Class