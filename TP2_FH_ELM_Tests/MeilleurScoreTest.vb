Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class MeilleurScoreTest

    <TestMethod()> Public Sub CreationMeilleurScore()
        Dim uneDate As Date = Date.Now
        Dim unMeilleurScore As New MeilleurScore(12, uneDate)
        Assert.AreEqual(unMeilleurScore.NbrTour, 12)
        Assert.AreEqual(unMeilleurScore.laDate, uneDate)
    End Sub

End Class