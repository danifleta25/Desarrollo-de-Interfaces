Public Class Form1

    Dim numeros(5) As Integer
    Dim random As New Random()
    Dim numUsuario(5) As Integer


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

        ' Mostramos el reintegro del usuario
        lblUserReintegro.Text = "REINTEGRO: " + txtBoxReintegro.Text.ToString()

        'Asignamos los numeros del usuario a sus labels
        lblUser1.Text = numUsuario(0).ToString()
        lblUser2.Text = numUsuario(1).ToString()
        lblUser3.Text = numUsuario(2).ToString()
        lblUser4.Text = numUsuario(3).ToString()
        lblUser5.Text = numUsuario(4).ToString()
        lblUser6.Text = numUsuario(5).ToString()

        'Mostramos el numero de aciertos
        lblResultado.Text = "Nº ACIERTOS: " + comprobar_Aciertos(numUsuario).ToString()

        'Comprobar reintegro
        If txtBoxReintegro.Text.Equals(reintegro.ToString()) Then
            lblUserReintegro.Text = "REINTEGRO: ACIERTO"
        Else
            lblUserReintegro.Text = "REINTEGRO: FALLIDO"
        End If


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
        'Comprobar que se han marcado 6 checkBox
        If contador <> 6 Then
            MsgBox("Hay que seleccionar exactamente 6 numeros")
            Exit Sub
        End If


        ' Ordenamos numUsuario
        ordenar(numUsuario)

        'Mostramos resultados
        mostrarReintegro()
        mostrar_Resultados_Sorteo()

    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        'Limpiamos los checkBox
        btnBorrar_Click(sender, e)

        For i = 0 To 5 Step 1
            Dim num As Integer = random.Next(1, 50)
            Dim numCheckBox As String = "CheckBox" + num.ToString()
            Dim cBox As CheckBox = CType(panelCheckboxes.Controls(numCheckBox), CheckBox)

            If cBox.Checked = False Then
                cBox.Checked = True
            Else
                i -= 1
            End If
        Next

        btnManual_Click(sender, e)

        ' Ordenamos numUsuario
        ordenar(numUsuario)
        ' mOSTRAMOS RESULTADOS
        mostrarReintegro()
        mostrar_Resultados_Sorteo()
    End Sub


End Class
