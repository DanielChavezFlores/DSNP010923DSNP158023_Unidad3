Public Class Calcular

    Dim Cantidad As Double

    Public Function Calcular_resultado(ByVal Monto As Double)



        If Monto > 0 And Monto <= 500 Then

            Cantidad = ((Monto - 0.01) / 1000) + 1.5

        Else

            If Monto > 500.01 And Monto <= 1000 Then

                Cantidad = (((Monto - 500.01) / 1000) * 3) + 1.5
            Else

                If Monto >= 1000.01 And Monto <= 2000 Then
                    Cantidad = (((Monto - 1000.01) / 1000) * 3) + 3
                Else

                    If Monto >= 2000.01 And Monto <= 3000 Then
                        Cantidad = (((Monto - 2000.01) / 1000) * 3) + 6

                    Else
                        If Monto >= 3000.01 And Monto <= 6000 Then
                            Cantidad = (((Monto - 3000.01) / 1000) * 2) + 9

                        Else

                            If Monto >= 8000.01 And Monto <= 18000 Then
                                Cantidad = (((Monto - 8000.01) / 1000) * 2) + 15
                            Else
                                If Monto >= 18000.01 And Monto <= 30000 Then
                                    Cantidad = (((Monto - 18000.01) / 1000) * 2) + 39
                                Else
                                    If Monto >= 30000.01 And Monto <= 60000 Then
                                        Cantidad = (((Monto - 30000.01) / 1000) * 1) + 63
                                    Else
                                        If Monto >= 60000.01 And Monto <= 100000 Then
                                            Cantidad = (((Monto - 60000.01) / 1000) * 0.8) + 93

                                        Else
                                            If Monto >= 100000.01 And Monto <= 200000 Then
                                                Cantidad = (((Monto - 100000.01) / 1000) * 0.7) + 125

                                            Else
                                                If Monto >= 200000.01 And Monto <= 300000 Then
                                                    Cantidad = (((Monto - 200000.01) / 1000) * 0.6) + 195
                                                Else
                                                    If Monto >= 300000.01 And Monto <= 400000 Then
                                                        Cantidad = (((Monto - 300000.01) / 1000) * 0.45) + 255

                                                    Else
                                                        If Monto >= 400000.01 And Monto <= 500000 Then
                                                            Cantidad = (((Monto - 400000.01) / 1000) * 0.4) + 300
                                                        Else
                                                            If Monto >= 500000.01 And Monto <= 1000000 Then
                                                                Cantidad = (((Monto - 500000.01) / 1000) * 0.3) + 340
                                                            Else
                                                                If Monto >= 1000000.01 And Monto <= 99999999 Then
                                                                    Cantidad = (((Monto - 1000000.01) / 1000) * 0.18) + 490
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If

                                            End If

                                        End If

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


        Return Cantidad

    End Function

End Class
