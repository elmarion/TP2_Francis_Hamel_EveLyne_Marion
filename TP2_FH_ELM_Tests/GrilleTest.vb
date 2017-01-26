Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class GrilleTest

    <TestMethod()> Public Sub CreationGrille()
        Dim uneGrille As New Grille(14)
        Assert.AreEqual(uneGrille.NbLignesColonnes, 14)
    End Sub

End Class