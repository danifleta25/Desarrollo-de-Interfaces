Public Class Diccionario
    Dim orden_Ascendente As Boolean = True
    Dim random As New Random

    Private Sub Diccionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comprobar_Boton_Borrar()
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        Dim palabras As New List(Of String)
        For Each pal In listBoxPalabras.Items
            palabras.Add(pal)
        Next

        palabras.Sort()

        If orden_Ascendente = False Then
            palabras.Reverse()
        End If

        orden_Ascendente = Not orden_Ascendente

        listBoxPalabras.Items.Clear()

        For Each p In palabras
            listBoxPalabras.Items.Add(p)
        Next
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim palabra As String = InputBox("Introduce una nueva palabra:", "Añadir palabra").Trim().ToUpper

        'Comprobar que no haya pulsado cancelar o haya dejado el texto vacio
        If String.IsNullOrEmpty(palabra) Then
            Return
        End If

        If Not listBoxPalabras.Items.Contains(palabra) Then
            listBoxPalabras.Items.Add(palabra)
            comprobar_Boton_Borrar()
        Else
            MsgBox("La palabra ya esta en la lista")
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If listBoxPalabras.SelectedItem Is Nothing Then
            MsgBox("No hay ninguna palabra seleccionada")
            Return
        End If

        Dim respuesta As DialogResult = MessageBox.Show("Deseas eliminar la palabra seleccionada?", "Eliminar palabra", MessageBoxButtons.YesNo)

        Dim seleccionado As Object = listBoxPalabras.SelectedItem
        If respuesta = DialogResult.Yes Then
            listBoxPalabras.Items.Remove(seleccionado)
            comprobar_Boton_Borrar()
        End If
    End Sub

    Private Sub comprobar_Boton_Borrar()
        If listBoxPalabras.Items.Count <= 5 Then
            btnBorrar.Enabled = False
        Else
            btnBorrar.Enabled = True
        End If
    End Sub



    Public Function seleccion_Palabra() As String
        If listBoxPalabras.Items.Count = 0 Then
            Return "AHORCADO"
        End If


        Dim p_Random = random.Next(0, listBoxPalabras.Items.Count)
        Dim palabra As String = listBoxPalabras.Items(p_Random)

        Return palabra.ToString().ToUpper()
    End Function





End Class