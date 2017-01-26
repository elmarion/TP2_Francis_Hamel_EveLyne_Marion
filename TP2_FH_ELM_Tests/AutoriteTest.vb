Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing


<TestClass()> Public Class AutoriteTest

    <TestMethod()> Public Sub DetecterPersonnage()

        Dim uneMilice As New Milice(New Point(0, 0), 14)
        Dim unRefegie As New Refugie(New Point(0, 1), 14)
        Assert.AreEqual(uneMilice.ListePersonnageDetecter.Count, 0)
        uneMilice.DetecterPersonnage(unRefegie)
        Assert.AreEqual(uneMilice.ListePersonnageDetecter.Count, 1)
        Dim unFauxRefugie As New FauxRefugier(New Point(13, 13), 14)
        uneMilice.DetecterPersonnage(unFauxRefugie)
        Assert.AreEqual(uneMilice.ListePersonnageDetecter.Count, 1)
        Dim unAutreFauxRefugie As New FauxRefugier(New Point(1, 0), 14)
        uneMilice.DetecterPersonnage(unAutreFauxRefugie)
        Assert.AreEqual(uneMilice.ListePersonnageDetecter.Count, 2)
    End Sub

    <TestMethod()> Public Sub DeplacementAvecDetection()
        Dim uneMilice As New Milice(New Point(0, 0), 14)
        Dim unRefegie As New Refugie(New Point(0, 1), 14)
        Assert.AreEqual(uneMilice.ListePersonnageDetecter.Count, 0)
        uneMilice.DetecterPersonnage(unRefegie)

        uneMilice.DeplacementAvecDetection()
        Assert.AreEqual(uneMilice.PersonnageDetecte, unRefegie)
        If uneMilice.Positionnement.X <> 0 Then
            Assert.AreEqual(Math.Abs(uneMilice.Positionnement.X - 0), 1)
        Else
            Assert.AreEqual(Math.Abs(uneMilice.Positionnement.Y - 0), 1)
        End If
    End Sub
End Class