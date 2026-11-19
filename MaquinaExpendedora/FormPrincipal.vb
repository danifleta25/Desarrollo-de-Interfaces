Public Class FormPrincipal
    Dim FormInventario As New FormInventario
    Dim descuentoActual As Double = 0.0


    Public Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitarBotones(False)

        ActualizarEscaparate()
        txtBoxSaldo.Text = "0"

    End Sub




    Public Sub desabilitarBotones(estado As Boolean)
        For Each boton As Button In Me.panelNumerico.Controls.OfType(Of Button)()
            boton.Enabled = estado
        Next
    End Sub

    Private Sub selecNum(sender As Object, e As EventArgs) Handles btn0.Click, btn7.Click, btn8.Click, btn9.Click, btn6.Click, btn5.Click, btn4.Click, btn1.Click, btn2.Click, btn3.Click
        If txtBoxSeleccion.Text.Length < 2 Then
            txtBoxSeleccion.Text &= CType(sender, Button).Text
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtBoxSeleccion.Text = ""
    End Sub


    Public Sub ActualizarEscaparate()
        panelEscaparate.Controls.Clear()
        ' Crear lista de productos que ya pertenecen al listBoxInventario
        For Each producto As Object In FormInventario.listBoxProductos.Items
            Dim linea() As String = producto.ToString().Split("-"c)
            Dim codigo As String = linea(0).Trim()
            Dim nombre As String = linea(1).Trim()
            Dim precio As Double = Double.Parse(linea(2).Trim())
            Dim precioFinal As Double = precio * (1 - descuentoActual)
            Dim stock As Integer = Integer.Parse(linea(3).Trim())


            Dim lbl As New Label()
            lbl.Size = New Size(200, 30)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.BorderStyle = BorderStyle.FixedSingle

            If stock = 0 Then
                lbl.Text = $"{codigo} - {nombre}{vbCrLf} - AGOTADO"
                lbl.BackColor = Color.LightCoral
            Else
                lbl.Text = $"{codigo} - {nombre}{vbCrLf} - {precioFinal:F2}€"
                lbl.BackColor = Color.WhiteSmoke
            End If

            panelEscaparate.Controls.Add(lbl)
        Next
    End Sub

    Private Sub sumarSaldo(sender As Object, e As EventArgs) Handles btn050.Click, btn1euro.Click, btn150.Click
        If sender Is btn050 Then
            txtBoxSaldo.Text = (Double.Parse(txtBoxSaldo.Text) + 0.5).ToString()
        ElseIf sender Is btn1euro Then
            txtBoxSaldo.Text = (Double.Parse(txtBoxSaldo.Text) + 1).ToString()
        ElseIf sender Is btn150 Then
            txtBoxSaldo.Text = (Double.Parse(txtBoxSaldo.Text) + 1.5).ToString()
        End If
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim seleccion As String = txtBoxSeleccion.Text.Trim()

        If seleccion.Length < 2 Then
            MessageBox.Show("Por favor, ingrese un código de producto válido.")
            Exit Sub
        End If

        Dim encontrado As Boolean = False

        For i As Integer = 0 To FormInventario.listBoxProductos.Items.Count - 1
            Dim linea() As String = FormInventario.listBoxProductos.Items(i).ToString().Split("-"c)
            Dim codigo As String = linea(0).Trim()

            If codigo = seleccion Then
                encontrado = True
                Dim nombre As String = linea(1).Trim()
                Dim precio As Double = Double.Parse(linea(2).Trim())
                Dim precioFinal As Double = precio * (1 - descuentoActual)
                Dim stock As Integer = Integer.Parse(linea(3).Trim())
                Dim saldo As Double = Double.Parse(txtBoxSaldo.Text)

                'Comprobar stock
                If stock <= 0 Then
                    ' Aquí cargarías imagen de error
                    MessageBox.Show($"El producto {nombre} está agotado.", "Sin stock")
                    Exit For
                End If

                'Comprobar saldo
                If saldo < precioFinal Then
                    ' Aquí cargarías imagen de error
                    MessageBox.Show($"Saldo insuficiente para comprar {nombre}.", "Saldo insuficiente")
                    Exit For
                End If

                ' Si hay stock y saldo suficiente, realizar la compra
                stock -= 1
                saldo -= precioFinal


                ' Actualizar el saldo en la interfaz
                txtBoxSaldo.Text = saldo.ToString("F2")

                ' Actualizar el stock en FormInventario
                FormInventario.listBoxProductos.Items(i) = $"{codigo} - {nombre} - {precio:F2} - {stock}"

                MessageBox.Show($"Has comprado {nombre} por {precioFinal:F2}€")

                ActualizarEscaparate()
                txtBoxSeleccion.Text = ""

                Exit For

            End If

        Next

        If Not encontrado Then
            MessageBox.Show("Producto no encontrado. Por favor, ingrese un código válido.")
            txtBoxSeleccion.Text = ""
        End If

    End Sub

    Private Sub EncenderNuevaCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncenderNuevaCompraToolStripMenuItem.Click
        desabilitarBotones(True)
        txtBoxSaldo.Text = "0,00"
        txtBoxSeleccion.Text = ""
        ActualizarEscaparate()
        ' Si usas PictureBox para estados:
        ' cambiarImagenEstado("estado_espera.png")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit() ' O Me.Close()
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentoToolStripMenuItem.Click
        Dim frmModo As New FormModo()
        If frmModo.ShowDialog() = DialogResult.OK Then
            descuentoActual = frmModo.DescuentoSeleccionado
            ActualizarEscaparate() ' Refresca los precios visuales en pantalla
        End If
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        FormInventario.ShowDialog()
        ActualizarEscaparate() ' Refleja los productos añadidos, borrados o repuestos
    End Sub



End Class
