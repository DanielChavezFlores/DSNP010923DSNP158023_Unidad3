Public Class Cajero
    Dim valores As Decimal() = {100, 50, 20, 10, 5, 1, 0.25, 0.1, 0.05, 0.01}
    Dim entregar As Int16() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Sub limpiarEntrega()
        entregar = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    End Sub

    Public Function retirar(ByVal cantidad As Decimal)
        limpiarEntrega()
        Dim monto = cantidad
        For i = 0 To (valores.Length - 1)
            Dim billetes = Math.Floor(monto / valores(i))
            entregar(i) = billetes
            monto = monto - (billetes * valores(i))
        Next
        Return entregar
    End Function
End Class
