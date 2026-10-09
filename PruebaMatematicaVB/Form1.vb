Public Class Form1

    'Crea un objeto Random
    Dim randomizer As New Random()

    'Variable para almacenar los numeros aleatorios generados
    Dim num1 As Integer
    Dim num2 As Integer

    Dim resta1 As Integer
    Dim resta2 As Integer

    Dim mult1 As Integer
    Dim mult2 As Integer

    Dim divis1 As Integer
    Dim divis2 As Integer

    'Almacena el tiempo restante
    Dim timeLeft As Integer

    Public Sub StartTheQuiz()
        'Suma 
        num1 = randomizer.Next(51)
        num2 = randomizer.Next(51)
        plusLeftLabel.Text = num1.ToString()
        plusRightLabel.Text = num2.ToString()

        'Resta
        resta1 = randomizer.Next(1, 51)
        resta2 = randomizer.Next(1, resta1)
        minusLeftLabel.Text = resta1.ToString()
        minusRightLabel.Text = resta2.ToString()

        'Multiplicación
        mult1 = randomizer.Next(2, 11)
        mult2 = randomizer.Next(2, 11)
        timesLeftLabel.Text = mult1.ToString()
        timesRightLabel.Text = mult2.ToString()

        'División
        divis1 = randomizer.Next(20, 51)
        divis2 = randomizer.Next(2, 11)
        dividedLeftLabel.Text = divis1.ToString()
        dividedRightLabel.Text = divis2.ToString()


        'Valores iniciales de los NumericUpDown
        suma.Value = 0
        diferencia.Value = 0
        producto.Value = 0
        cociente.Value = 0

        'Comienza el timer
        timeLeft = 30
        timeLabel.Text = "30 segundos"
        Timer1.Start()
        startButton.Enabled = False
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        StartTheQuiz()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If checkTheAnswer() Then
            Timer1.Stop()
            MessageBox.Show("¡Felicidades! Respuesta correcta")
            startButton.Enabled = True
        ElseIf TimeLeft > 5 Then
            'Muestra el tiempo restante y lo actualiza
            timeLeft = timeLeft - 1
            timeLabel.Text = timeLeft & " segundos"
        ElseIf timeLeft <= 5 AndAlso timeLeft > 0 Then
            'Si el tiempo restante es menor o igual a 5 segundos, cambia el color del label a rojo
            timeLabel.BackColor = Color.Red
            timeLeft = timeLeft - 1
            timeLabel.Text = timeLeft & " segundos"
        Else
            'Si el tiempo se acaba, para el timer y muestra un mensaje y las respuestas
            Timer1.Stop()
            timeLabel.Text = "Tiempo agotado"
            suma.Value = num1 + num2
            diferencia.Value = resta1 - resta2
            producto.Value = mult1 * mult2
            cociente.Value = divis1 / divis2

            MessageBox.Show("Se acabó el tiempo")
            startButton.Enabled = True
        End If
    End Sub


    Public Function checkTheAnswer() As Boolean
        If suma.Value = num1 + num2 AndAlso diferencia.Value = resta1 - resta2 AndAlso producto.Value = mult1 * mult2 AndAlso cociente.Value = divis1 / divis2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub answer_Enter(sender As Object, e As EventArgs) Handles suma.Enter, diferencia.Enter, producto.Enter, cociente.Enter
        'Selecciona el contenido del NumericUpDown cuando se apunta
        Dim answerBox As NumericUpDown = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer As Integer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)

        End If
    End Sub
End Class
