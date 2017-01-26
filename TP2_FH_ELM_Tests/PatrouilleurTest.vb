Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class PatrouilleurTest

    <TestMethod()> Public Sub CrationPatrouilleur()
        Dim unPatrouilleur As New Patrouilleur(New Point(0, 0), 14)
        Assert.AreEqual(unPatrouilleur.CaseDetection, 4)
        Assert.AreEqual(unPatrouilleur.Deplacement, 2)
        Assert.AreEqual(unPatrouilleur.LimiteDeplacement, 14)
        Assert.AreEqual(unPatrouilleur.Positionnement.X, 0)
        Assert.AreEqual(unPatrouilleur.Positionnement.Y, 0)
        Dim unPoint As New Point(0, 0)
        Assert.AreEqual(unPatrouilleur.Positionnement, unPoint)
    End Sub

    <TestMethod()> Public Sub DeplacementPatrouilleur()
        Dim unPatrouilleur As New Patrouilleur(New Point(5, 5), 14)
        unPatrouilleur.DeplacementPersonnage()
        If unPatrouilleur.Positionnement.X <> 5 Then
            If Math.Abs(unPatrouilleur.Positionnement.X - 5) = 2 Then
                Assert.AreEqual(Math.Abs(unPatrouilleur.Positionnement.X - 5), unPatrouilleur.Deplacement)
            Else
                Assert.AreEqual(Math.Abs(unPatrouilleur.Positionnement.X - 5), unPatrouilleur.Deplacement - 1)
                Assert.AreEqual(Math.Abs(unPatrouilleur.Positionnement.Y - 5), unPatrouilleur.Deplacement - 1)
            End If

        Else
            Assert.AreEqual(Math.Abs(unPatrouilleur.Positionnement.Y - 5), unPatrouilleur.Deplacement)
        End If

    End Sub

End Class