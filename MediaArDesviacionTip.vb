Public Class MediaArDesviacionTip

    Public Function mediaArmonica(ByVal cadena As String)
        Dim valores = cadena.Split(",")
        Dim sumaInversos As Double = 0
        For i = 0 To (valores.Length - 1)
            sumaInversos = sumaInversos + (1 / valores(i))
        Next
        Return Math.Round(valores.Length / sumaInversos, 5)
    End Function

    Public Function desviacionTipica(ByVal cadena As String)
        Dim valores = cadena.Split(",")
        Dim media As Double = 0
        For i = 0 To (valores.Length - 1)
            media = media + valores(i)
        Next
        media = media / valores.Length
        Dim sumacuadrados As Double = 0
        For i = 0 To (valores.Length - 1)
            sumacuadrados = sumacuadrados + Math.Pow((valores(i) - media), 2)
        Next
        sumacuadrados = sumacuadrados / valores.Length
        Return Math.Round((Math.Sqrt(sumacuadrados)), 5)
    End Function
End Class
