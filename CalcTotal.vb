Public Class CalcTotal
    Private Tax As Double
    Private Value As Double
    Private Disc As Double

    Public Function CalculateTotal(Tax, Value, Disc) As Double
        Dim SubTotal As Double = Value - ((Disc / 100) * Value)
        Dim Total As Double = SubTotal + ((Tax / 100) * SubTotal)
        Return Total
    End Function
End Class
