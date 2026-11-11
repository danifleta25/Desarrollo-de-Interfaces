<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diccionario
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
        listBoxPalabras = New ListBox()
        btnOrdenar = New Button()
        btnAñadir = New Button()
        btnBorrar = New Button()
        SuspendLayout()
        ' 
        ' listBoxPalabras
        ' 
        listBoxPalabras.FormattingEnabled = True
        listBoxPalabras.Items.AddRange(New Object() {"CARACOLA", "AMIGO", "DEFENSA", "EXAMEN", "AÑO", "JOVEN", "CAMARA", "VASO", "BOTELLA", "GUITARRA"})
        listBoxPalabras.Location = New Point(12, 27)
        listBoxPalabras.Name = "listBoxPalabras"
        listBoxPalabras.Size = New Size(190, 229)
        listBoxPalabras.TabIndex = 0
        ' 
        ' btnOrdenar
        ' 
        btnOrdenar.Location = New Point(241, 27)
        btnOrdenar.Name = "btnOrdenar"
        btnOrdenar.Size = New Size(101, 41)
        btnOrdenar.TabIndex = 1
        btnOrdenar.Text = "Ordenar"
        btnOrdenar.UseVisualStyleBackColor = True
        ' 
        ' btnAñadir
        ' 
        btnAñadir.Location = New Point(241, 153)
        btnAñadir.Name = "btnAñadir"
        btnAñadir.Size = New Size(101, 41)
        btnAñadir.TabIndex = 2
        btnAñadir.Text = "Añadir"
        btnAñadir.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Location = New Point(241, 215)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(101, 41)
        btnBorrar.TabIndex = 3
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' Diccionario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(367, 271)
        Controls.Add(btnBorrar)
        Controls.Add(btnAñadir)
        Controls.Add(btnOrdenar)
        Controls.Add(listBoxPalabras)
        Name = "Diccionario"
        Text = "Diccionario"
        ResumeLayout(False)
    End Sub

    Friend WithEvents listBoxPalabras As ListBox
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnBorrar As Button
End Class
