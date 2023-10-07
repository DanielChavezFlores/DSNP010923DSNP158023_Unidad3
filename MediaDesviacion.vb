Public Class MediaDesviacion

    Dim calculo As New MediaArDesviacionTip()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TextBox2.Text = calculo.mediaArmonica(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Hubo un error interpretando la serie de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TextBox2.Text = calculo.desviacionTipica(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Hubo un error interpretando la serie de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Principal.Show()
    End Sub
End Class