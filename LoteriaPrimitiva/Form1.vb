Public Class Form1

    Dim numeros(5) As Integer
    Dim random As New Random()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarReintegro()
    End Sub



    Private Sub mostrar_Resultados_Sorteo()

        ' Generamos los 6 numeros aleatorios
        For i = 0 To 5 Step 1
            Dim n As Integer

            Do
                n = random.Next(1, 50)
            Loop Until repetido(n) = False

            numeros(i) = n
        Next

        ' Ordenamos el array ascendentemente
        ordenar(numeros)

        'Asignamos los numeros a los labels
        lbl1.Text = numeros(0).ToString()
        lbl2.Text = numeros(1).ToString()
        lbl3.Text = numeros(2).ToString()
        lbl4.Text = numeros(3).ToString()
        lbl5.Text = numeros(4).ToString()
        lbl6.Text = numeros(5).ToString()

        ' Reitegro
        Dim reintegro As Integer = random.Next(0, 10)
        lblReintegro.Text = "REINTEGRO: " + reintegro.ToString()

    End Sub


    Private Function repetido(numero As Integer) As Boolean
        If numeros.Contains(numero) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ordenar(lista As Array)
        Array.Sort(lista)
    End Sub

    Private Sub mostrarReintegro()
        Dim num As Integer = random.Next(0, 10)
        txtBoxReintegro.Text = num.ToString()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        'Recorremos los controles del panelCheckBoxes
        For Each ctrl As Control In panelCheckboxes.Controls
            ' Si el control es un CheckBox se desmarca
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If
        Next
    End Sub


    Private Function comprobar_Aciertos(numUsuario() As Integer) As Integer
        Dim contador As Integer = 0
        For Each num In numeros
            If numUsuario.Contains(num) Then
                contador += 1
            End If
        Next
        Return contador
    End Function





    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        Dim numUsuario(5) As Integer


        ' Comprobar que se han marcado 6 checkBox
        Dim contador As Integer = 0
        ' Recorremos los controles del panelCheckBoxes
        For Each ctrl As Control In panelCheckboxes.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cBox As CheckBox = CType(ctrl, CheckBox)

                If cBox.Checked Then

                    If contador < 6 Then
                        ' Si el checkbox esta marcado guardamos el número en numUsuario eliminando los ":"
                        numUsuario(contador) = Integer.Parse(cBox.Text.Replace(":", "").Trim())
                    End If
                    contador += 1

                End If
            End If
        Next

        If contador <> 6 Then
            MsgBox("Hay que seleccionar exactamente 6 numeros")
            Exit Sub
        End If


        ' Ordenamos numUsuario
        ordenar(numUsuario)


        lblUser1.Text = numUsuario(0).ToString()
        lblUser2.Text = numUsuario(1).ToString()
        lblUser3.Text = numUsuario(2).ToString()
        lblUser4.Text = numUsuario(3).ToString()
        lblUser5.Text = numUsuario(4).ToString()
        lblUser6.Text = numUsuario(5).ToString()



        lblUserReintegro.Text = "REINTEGRO: " + txtBoxReintegro.Text.ToString()



        mostrar_Resultados_Sorteo()

        lblResultado.Text = "Nº ACIERTOS: " + comprobar_Aciertos(numUsuario).ToString()



    End Sub


End Class
