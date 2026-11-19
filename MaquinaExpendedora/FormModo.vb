Public Class FormModo

    Public DescuentoSeleccionado As Double = 0.0

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If rbNormal.Checked Then
            DescuentoSeleccionado = 0.0
        ElseIf rbEstudiante.Checked Then
            DescuentoSeleccionado = 0.1
        ElseIf rbHoraFeliz.Checked Then
            DescuentoSeleccionado = 0.2
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub



End Class