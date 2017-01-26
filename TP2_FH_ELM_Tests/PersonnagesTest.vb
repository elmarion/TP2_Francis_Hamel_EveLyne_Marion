Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP2_Francis_Hamel_EveLyne_Marion
Imports System.Drawing

<TestClass()> Public Class PersonnagesTest

    <TestMethod()> Public Sub ConvertirMatriceEnPixel()
        Dim uneMilice As New Milice(New Point(1, 1), 14)
        Assert.AreEqual(uneMilice.ConvertirMatricePixels.X, 50)
        Assert.AreEqual(uneMilice.ConvertirMatricePixels.Y, 50)
    End Sub

End Class