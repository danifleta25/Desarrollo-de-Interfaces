Imports System.Reflection.Emit
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Public Class FormPrincipal
    Dim formDiccionario As New Diccionario()
    Dim formNivel As New Nivel()

    Dim intentos As Integer = 0

    'Obtenemos la palabra aleatoria
    Dim palabra As String = ""

    Private labels_Palabra As New List(Of System.Windows.Forms.Label)

    'Maximos intentos principiante
    Dim fallos_Maximos As Integer = 10





    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoxIntentos.Text = intentos
        crear_palabra()

    End Sub


    ' Activar a desactivar botones
    Public Sub Activar_Botones(encendido_Apagado As Boolean)
        For Each ctrl As Control In panelBotones.Controls
            If TypeOf ctrl Is Button Then
                CType(ctrl, Button).Enabled = encendido_Apagado
            End If
        Next
    End Sub

    ' Cambio al Form Diccionario
    Private Sub DiccionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiccionarioToolStripMenuItem.Click
        formDiccionario.ShowDialog()
    End Sub

    Private Sub click_Letra(sender As Object, e As EventArgs) Handles Button1.Click, Button27.Click, Button28.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click

        ' Cast del button sender
        Dim btn As Button = CType(sender, Button)

        btn.Enabled = False
        ' Accedemos a la letra
        Dim letra_Clickada As String = btn.Text.ToString()


        comprobar_Letra(letra_Clickada)
    End Sub

    Private Sub comprobar_Letra(letra As Char)
        Dim acierto As Boolean = False

        For i = 0 To palabra.Length - 1
            If palabra(i) = letra Then
                acierto = True
                labels_Palabra(i).Text = letra.ToString()
            End If
        Next

        If acierto Then
            comprobar_Victoria()
        Else
            ' Actualizar contador intentos
            intentos += 1
            txtBoxIntentos.Text = intentos.ToString()
            actualizar_Imagen()

            If intentos >= fallos_Maximos Then
                MsgBox($"Has llegado al número máximo de fallos, la palabra era {palabra}")
                Activar_Botones(False)
            End If
        End If

    End Sub

    Private Sub comprobar_Victoria()
        Dim victoria As Boolean = True

        For Each label As System.Windows.Forms.Label In labels_Palabra
            If label.Text = "_" Then
                victoria = False
                Exit For
            End If
        Next

        If victoria Then
            MessageBox.Show("Felicidades, has ganado!", "Victoria")
            Activar_Botones(False)
        End If

    End Sub

    Private Sub actualizar_Imagen()
        Dim ruta As String = Application.StartupPath & $"\Imagenes\AHOR{intentos.ToString}.BMP"

        If File.Exists(ruta) Then
            picBoxAhorcado.Image = Image.FromFile(ruta)
        End If
    End Sub

    Private Sub crear_palabra()

        palabra = formDiccionario.seleccion_Palabra()

        'Limpiamos el panel
        panelPalabra.Controls.Clear()
        labels_Palabra.Clear()

        For i As Integer = 0 To palabra.Length - 1
            Dim lbl As New System.Windows.Forms.Label()

            lbl.Text = "_"
            lbl.AutoSize = True

            panelPalabra.Controls.Add(lbl)
            labels_Palabra.Add(lbl)
        Next

    End Sub

    Private Sub NuevoJuegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoJuegoToolStripMenuItem.Click
        ' Al iniciar un nuevo juego reseteamos el panel de labels y la palabra
        labels_Palabra.Clear()
        panelPalabra.Controls.Clear()
        intentos = 0
        txtBoxIntentos.Text = intentos.ToString()
        actualizar_Imagen()
        crear_palabra()
        Activar_Botones(True)
    End Sub

    Private Sub NivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NivelToolStripMenuItem.Click
        Dim formNivel As New Nivel()

        If formNivel.ShowDialog() = DialogResult.OK Then
            fallos_Maximos = Nivel.max_Fallos
            NuevoJuegoToolStripMenuItem_Click(sender, e)
        End If
    End Sub
End Class
