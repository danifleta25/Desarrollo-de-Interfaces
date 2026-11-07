Public Class Form1

    Dim numeros(5) As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_resultados_sorteo()
    End Sub



    Private Sub mostrar_resultados_sorteo()
        Dim random As New Random()

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

End Class
