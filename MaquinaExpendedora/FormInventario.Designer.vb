<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        listBoxProductos = New ListBox()
        SuspendLayout()
        ' 
        ' listBoxProductos
        ' 
        listBoxProductos.FormattingEnabled = True
        listBoxProductos.Items.AddRange(New Object() {"01 - Agua - 1,20 - 5", "02 - Refresco Cola - 1,50 - 4", "03 - Zumo Naranja - 1,40 - 3", "04 - Patatas Fritas - 1,10 - 6", "05 - Chocolatina - 1,30 - 0", "06 - Galletas - 1,00 - 8", "07 - Sandwich Mixto - 2,50 - 2", "08 - Cafe con Leche - 1,25 - 7"})
        listBoxProductos.Location = New Point(12, 12)
        listBoxProductos.Name = "listBoxProductos"
        listBoxProductos.Size = New Size(469, 184)
        listBoxProductos.TabIndex = 0
        ' 
        ' FormInventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 202)
        Controls.Add(listBoxProductos)
        Name = "FormInventario"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents listBoxProductos As ListBox
End Class
