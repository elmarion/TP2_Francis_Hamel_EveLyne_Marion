Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class MiliceTest

    <TestMethod()> Public Sub CreationMilice()
        Dim uneMilice As New Milice(New Point(10, 12), 14)
        Assert.AreEqual(uneMilice.Deplacement, 1)
        Assert.AreEqual(uneMilice.CaseDetection, 3)
        Assert.AreEqual(uneMilice.CaseDetectionCitoyen, 5)
        Assert.AreEqual(uneMilice.Positionnement.X, 10)
        Assert.AreEqual(uneMilice.Positionnement.Y, 12)
        Dim unPoint As New Point(10, 12)
        Assert.AreEqual(uneMilice.Positionnement, unPoint)
        Assert.AreEqual(uneMilice.LimiteDeplacement, 14)
        Assert.IsFalse(uneMilice.VuCitoyen)
        Assert.IsFalse(uneMilice.VuVraiFauxRefugie)
    End Sub

    <TestMethod()> Public Sub DetecterCitoyen()
        Dim uneMilice As New Milice(New Point(10, 12), 14)
        Dim unCitoyen As New Citoyen(New Point(11, 12), 14)
        uneMilice.DetecteCitoyen(unCitoyen)
        Assert.AreEqual(uneMilice.ListePersonnageDetecter.Count, 1)
    End Sub

    <TestMethod()> Public Sub DeplacementMilice()
        Dim uneMilice As New Milice(New Point(10, 12), 14)
        uneMilice.DeplacementPersonnage()
        If uneMilice.Positionnement.X <> 10 Then
            Assert.AreEqual(Math.Abs(uneMilice.Positionnement.X - 10), uneMilice.Deplacement)
        Else
            Assert.AreEqual(Math.Abs(uneMilice.Positionnement.Y - 12), uneMilice.Deplacement)
        End If

    End Sub
End Class