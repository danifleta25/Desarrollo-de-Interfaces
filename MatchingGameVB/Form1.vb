Public Class Form1

    'Crea un objeto Random para los iconos de cada celda
    Dim random As New Random()

    Dim temporaryArray() As String = {"!", "!", "N", "N", ",", ",", "k", "k",
                                  "b", "b", "v", "v", "w", "w", "z", "z",
                                  "a", "a", "H", "H", "d", "d", "e", "e",
                                  "f", "f", "L", "L", "h", "h", "j", "j",
                                  "m", "m", "p", "p"}
    Dim icons As List(Of String) = temporaryArray.ToList()

    'Primer click
    Dim firstClicked As Label = Nothing
    'Segundo click
    Dim secondClicked As Label = Nothing

    Dim soundCorrect As New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")
    Dim soundIncorrect As New System.Media.SoundPlayer("C:\Windows\Media\ding.wav")
    Dim soundWin As New System.Media.SoundPlayer("C:\Windows\Media\chimes.wav")

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        AsignIconsToSquares()
    End Sub

    Private Sub AsignIconsToSquares()

        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel As Label = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber As Integer = random.Next(icons.Count)
                iconLabel.Text = icons.ElementAt(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If
        Next
    End Sub

    Private Sub label_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label9.Click, Label10.Click, Label11.Click, Label12.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label17.Click, Label26.Click, Label18.Click, Label27.Click, Label19.Click, Label28.Click, Label20.Click, Label29.Click, Label25.Click, Label30.Click, Label36.Click, Label35.Click, Label34.Click, Label24.Click, Label23.Click, Label33.Click, Label32.Click, Label22.Click, Label21.Click, Label31.Click

        If Timer1.Enabled = True Then
            Return
        End If


        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then
            If clickedLabel.ForeColor = Color.Black Then
                Return
            End If

            If firstClicked Is Nothing Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                Timer2.Start()
                Return
            End If

            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black
            Timer2.Stop()

            CheckForWinner()

            If firstClicked.Text = secondClicked.Text Then
                'Si enlazas dos labels, los marca en verde
                firstClicked.BackColor = Color.LightGreen
                secondClicked.BackColor = Color.LightGreen
                'Sonido de acierto
                soundCorrect.Play()
                'Resetea firstClicked y secondClicked
                firstClicked = Nothing
                secondClicked = Nothing
                Return
            End If

            'Si llega al punto de tener dos labels clickeados empieza el timer
            Timer1.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Para el timer
        Timer1.Stop()

        soundIncorrect.Play()
        'Oculta los dos label
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        'Resetea firstClicked y secondClicked
        firstClicked = Nothing
        secondClicked = Nothing
    End Sub


    Private Sub CheckForWinner()

        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel As Label = TryCast(control, Label)

            If iconLabel IsNot Nothing Then
                If (iconLabel.ForeColor = iconLabel.BackColor) Then
                    Return
                End If
            End If
        Next
        soundWin.Play()
        MessageBox.Show("Felicidades!")
        Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        If firstClicked IsNot Nothing Then
            If secondClicked Is Nothing Then
                firstClicked.ForeColor = firstClicked.BackColor
                firstClicked = Nothing
            End If
        End If
    End Sub
End Class
