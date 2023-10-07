Public Class CajeroAutomatico
    Dim cajero As New Cajero()
    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Try
            Dim retiro = cajero.retirar(txtCantidad.Text)
            TextBox1.Text = retiro(0).ToString
            TextBox2.Text = retiro(1).ToString
            TextBox3.Text = retiro(2).ToString
            TextBox4.Text = retiro(3).ToString
            TextBox5.Text = retiro(4).ToString
            TextBox6.Text = retiro(5).ToString
            TextBox7.Text = retiro(6).ToString
            TextBox8.Text = retiro(7).ToString
            TextBox9.Text = retiro(8).ToString
            TextBox10.Text = retiro(9).ToString
        Catch ex As Exception
            MessageBox.Show("El valor debe ser numerico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnLimpiar.PerformClick()
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        txtCantidad.Text = ""
        txtCantidad.Select()
    End Sub

    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click
        Me.Hide()
        Principal.Show()
    End Sub
End Class
