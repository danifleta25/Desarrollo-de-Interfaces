
Public Class Nivel
    Public Shared max_Fallos As Integer = 10

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim palabra_Nivel As String = ""

        For Each radio As Control In gBoxOpciones.Controls
            If TypeOf radio Is RadioButton Then
                If CType(radio, RadioButton).Checked = True Then
                    palabra_Nivel = radio.Text.ToString()
                End If
            End If
        Next

        If palabra_Nivel.Equals("") Then
            MsgBox("No has seleccionado ningún nivel")
            Return
        End If

        If palabra_Nivel.ToLower().Equals("principiante") Then
            max_Fallos = 10
        ElseIf palabra_Nivel.ToLower().Equals("intermedio") Then
            max_Fallos = 8
        ElseIf palabra_Nivel.ToLower().Equals("experto") Then
            max_Fallos = 6
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class