Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
<TestClass()> Public Class AleatoireTest

    <TestMethod()> Public Sub CreationAleatoire()
        Dim unAleatoire As New Aleatoire()
        Assert.IsNotNull(unAleatoire)
    End Sub

    <TestMethod()> Public Sub ObtenirNombre()
        Dim unAleatoire As New Aleatoire()
        Dim unNombre As Integer
        unNombre = unAleatoire.ObtenirNombreEntre(0, 2)
        If unNombre = 0 Then
            Assert.AreEqual(unNombre, 0)
        ElseIf unNombre = 1 Then
            Assert.AreEqual(unNombre, 1)
        Else
            Assert.AreEqual(unNombre, 2)
        End If
    End Sub
End Class