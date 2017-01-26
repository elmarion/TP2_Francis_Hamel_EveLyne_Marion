Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class FauxRefugieTest

    <TestMethod()> Public Sub CreerUnFauxRefugie()
        Dim unFauxRefugie As New FauxRefugier(New Point(0, 0), 14)
        Assert.AreEqual(unFauxRefugie.Deplacement, 1)
        Assert.AreEqual(unFauxRefugie.LimiteDeplacement, 14)
        Assert.AreEqual(unFauxRefugie.Positionnement.X, 0)
        Assert.AreEqual(unFauxRefugie.Positionnement.Y, 0)
        Dim unPoint As New Point(0, 0)
        Assert.AreEqual(unFauxRefugie.Positionnement, unPoint)
    End Sub

    <TestMethod()> Public Sub DeplacementFauxRefugie()
        Dim unFauxRefugie As New FauxRefugier(New Point(0, 0), 14)
        unFauxRefugie.DeplacementPersonnage()
        If unFauxRefugie.Positionnement.X <> 0 Then
            Assert.AreEqual(Math.Abs(unFauxRefugie.Positionnement.X - 0), unFauxRefugie.Deplacement)
        Else
            Assert.AreEqual(Math.Abs(unFauxRefugie.Positionnement.Y - 0), unFauxRefugie.Deplacement)
        End If
    End Sub
End Class