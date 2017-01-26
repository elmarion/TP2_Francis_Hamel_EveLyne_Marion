Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing


<TestClass()> Public Class PartieTest

    <TestMethod()> Public Sub CreationPartie()
        Dim lstPersos As New List(Of Personnages)
        lstPersos.Add(New Milice(New Point(2, 2), 14))
        Dim unePartie As New Partie(12, lstPersos, 14)
        Assert.AreEqual(unePartie.NbrTour, 12)
        Assert.AreEqual(unePartie.ListePersonnage.Count, 1)
        Assert.AreEqual(unePartie.NbrColonneLigneGrille, 14)
    End Sub

End Class