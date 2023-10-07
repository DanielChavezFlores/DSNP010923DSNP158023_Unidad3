Public Class Impuesto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim Monto As Double
        Dim calcular As Calcular = New Calcular()


        Monto = Entrada.Text
        If Monto < 0.01 Or Monto > 99999999 Then
            MessageBox.Show("Ingrese un valor entre 0.01 y 99999999 ")
            Exit Sub
        End If

        Resultado.Text = calcular.Calcular_resultado(Monto)
    End Sub
End Class