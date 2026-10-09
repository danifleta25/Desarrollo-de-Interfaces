Public Class Form1

    Dim startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")
    Dim finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\ding.wav")


    Public Sub New()
        InitializeComponent()

        MoveToStart()
    End Sub


    Private Sub finishLabel_MouseEnter(sender As Object, e As EventArgs) Handles finishLabel.MouseEnter
        finishSoundPlayer.Play()
        'Muestra un MessageBox cuando el jugador llega a la meta y cierra el Form
        MessageBox.Show("Felicidades, has llegado a la meta!")
        Close()
    End Sub

    ''' <summary>
    ''' Mueve el cursor a la posición inicial del laberinto cuando el mouse entra en el panel del laberinto
    ''' </summary>
    Private Sub MoveToStart()
        startSoundPlayer.Play()

        Dim startingPoint = Panel1.Location
        startingPoint.Offset(60, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub wall_MouseEnter(sender As Object, e As EventArgs) Handles label53.MouseEnter, label52.MouseEnter, label43.MouseEnter, label26.MouseEnter, label7.MouseEnter, label42.MouseEnter, label51.MouseEnter, label50.MouseEnter, label49.MouseEnter, label48.MouseEnter, label47.MouseEnter, label46.MouseEnter, label45.MouseEnter, label44.MouseEnter, label41.MouseEnter, label40.MouseEnter, label39.MouseEnter, label38.MouseEnter, label37.MouseEnter, label36.MouseEnter, label35.MouseEnter, label34.MouseEnter, label33.MouseEnter, label32.MouseEnter, label31.MouseEnter, label30.MouseEnter, label29.MouseEnter, label28.MouseEnter, label27.MouseEnter, label25.MouseEnter, label24.MouseEnter, label23.MouseEnter, label22.MouseEnter, label21.MouseEnter, label20.MouseEnter, label19.MouseEnter, label18.MouseEnter, label17.MouseEnter, label6.MouseEnter, label8.MouseEnter, label9.MouseEnter, label16.MouseEnter, label15.MouseEnter, label5.MouseEnter, label14.MouseEnter, label4.MouseEnter, label13.MouseEnter, label2.MouseEnter, label12.MouseEnter, label11.MouseEnter, label10.MouseEnter, label1.MouseEnter, label3.MouseEnter, Panel1.MouseEnter
        'Al entrar en contacto con una pared llama al metodo MoveToStart() 
        MoveToStart()
    End Sub
End Class
