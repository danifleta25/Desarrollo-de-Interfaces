Public Class FormInventario

    ' Bandera para alternar entre orden A-Z y Z-A
    Dim ordenAscendente As Boolean = True

    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comprobarLimiteEliminar()
    End Sub

    ' 1. ORDENAR (A-Z y Z-A alternativamente)
    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        Dim listaTemp As New List(Of String)

        ' Pasamos los elementos del ListBox a una lista auxiliar
        For Each item As Object In listBoxProductos.Items
            listaTemp.Add(item.ToString())
        Next

        ' Ordenamos alfabéticamente y si toca descendente le damos la vuelta
        listaTemp.Sort()
        If Not ordenAscendente Then
            listaTemp.Reverse()
        End If

        ' Volcamos de nuevo al ListBox
        listBoxProductos.Items.Clear()
        For Each producto As String In listaTemp
            listBoxProductos.Items.Add(producto)
        Next

        ' Invertimos el estado para la próxima pulsación
        ordenAscendente = Not ordenAscendente
    End Sub

    ' 2. REPONER STOCK (+1)
    Private Sub btnReponer_Click(sender As Object, e As EventArgs) Handles btnReponer.Click
        Dim idx As Integer = listBoxProductos.SelectedIndex

        If idx = -1 Then
            MessageBox.Show("Selecciona un producto de la lista para reponer stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim linea() As String = listBoxProductos.Items(idx).ToString().Split("-"c)
        Dim codigo As String = linea(0).Trim()
        Dim nombre As String = linea(1).Trim()
        Dim precio As Double = Double.Parse(linea(2).Trim())
        Dim stock As Integer = Integer.Parse(linea(3).Trim())

        stock += 1

        ' Actualizamos la línea y mantenemos la selección
        listBoxProductos.Items(idx) = $"{codigo} - {nombre} - {precio:F2} - {stock}"
        listBoxProductos.SelectedIndex = idx
    End Sub

    ' 3. ELIMINAR PRODUCTO (con confirmación y límite mínimo de 4)
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idx As Integer = listBoxProductos.SelectedIndex

        If idx = -1 Then
            MessageBox.Show("Selecciona el producto que deseas eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show($"¿Seguro que deseas eliminar '{listBoxProductos.Items(idx)}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            listBoxProductos.Items.RemoveAt(idx)
            comprobarLimiteEliminar()
        End If
    End Sub

    ' Deshabilita el botón Eliminar si hay 4 o menos productos
    Private Sub comprobarLimiteEliminar()
        btnEliminar.Enabled = (listBoxProductos.Items.Count > 4)
    End Sub

    ' 4. AÑADIR PRODUCTO (validando código duplicado y tipos numéricos)
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim nuevoCodigo As String = InputBox("Introduce el código de 2 dígitos (ej. 09):", "Nuevo Producto").Trim()
        If String.IsNullOrEmpty(nuevoCodigo) Then Exit Sub

        If nuevoCodigo.Length <> 2 OrElse Not IsNumeric(nuevoCodigo) Then
            MessageBox.Show("El código debe tener exactamente 2 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Comprobamos que el código no exista ya en el inventario
        For Each item As Object In listBoxProductos.Items
            Dim codigoExistente As String = item.ToString().Split("-"c)(0).Trim()
            If codigoExistente = nuevoCodigo Then
                MessageBox.Show($"Ya existe un producto con el código {nuevoCodigo}.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        Dim nuevoNombre As String = InputBox("Introduce el nombre del producto:", "Nuevo Producto").Trim()
        If String.IsNullOrEmpty(nuevoNombre) Then Exit Sub

        Dim strPrecio As String = InputBox("Introduce el precio (usa coma para decimales, ej. 1,50):", "Nuevo Producto").Trim()
        Dim nuevoPrecio As Double
        If Not Double.TryParse(strPrecio, nuevoPrecio) OrElse nuevoPrecio <= 0 Then
            MessageBox.Show("El precio introducido no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim strStock As String = InputBox("Introduce el stock inicial:", "Nuevo Producto").Trim()
        Dim nuevoStock As Integer
        If Not Integer.TryParse(strStock, nuevoStock) OrElse nuevoStock < 0 Then
            MessageBox.Show("El stock debe ser un número entero igual o mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Añadimos el nuevo producto con el formato estándar
        listBoxProductos.Items.Add($"{nuevoCodigo} - {nuevoNombre} - {nuevoPrecio:F2} - {nuevoStock}")
        comprobarLimiteEliminar()
    End Sub

End Class