Public Class Form1
    Dim taxRate As Double
    Dim val1 As Double
    Dim discount As Double

    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
        taxRate = txtTax.Text
        val1 = txtPrice.Text
        discount = txtDisc.Text
        Dim ct As New CalcTotal

        lblTotal.Text = ct.CalculateTotal(taxRate, val1, discount).ToString("c")
    End Sub
End Class
