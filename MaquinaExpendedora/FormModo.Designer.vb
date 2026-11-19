<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModo
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
        rbNormal = New RadioButton()
        rbEstudiante = New RadioButton()
        rbHoraFeliz = New RadioButton()
        btnAceptar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' rbNormal
        ' 
        rbNormal.AutoSize = True
        rbNormal.Location = New Point(31, 37)
        rbNormal.Name = "rbNormal"
        rbNormal.Size = New Size(65, 19)
        rbNormal.TabIndex = 0
        rbNormal.TabStop = True
        rbNormal.Text = "Normal"
        rbNormal.UseVisualStyleBackColor = True
        ' 
        ' rbEstudiante
        ' 
        rbEstudiante.AutoSize = True
        rbEstudiante.Location = New Point(31, 81)
        rbEstudiante.Name = "rbEstudiante"
        rbEstudiante.Size = New Size(80, 19)
        rbEstudiante.TabIndex = 1
        rbEstudiante.TabStop = True
        rbEstudiante.Text = "Estudiante"
        rbEstudiante.UseVisualStyleBackColor = True
        ' 
        ' rbHoraFeliz
        ' 
        rbHoraFeliz.AutoSize = True
        rbHoraFeliz.Location = New Point(31, 126)
        rbHoraFeliz.Name = "rbHoraFeliz"
        rbHoraFeliz.Size = New Size(74, 19)
        rbHoraFeliz.TabIndex = 2
        rbHoraFeliz.TabStop = True
        rbHoraFeliz.Text = "HoraFeliz"
        rbHoraFeliz.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(20, 198)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 3
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(125, 198)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' FormModo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(221, 265)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(rbHoraFeliz)
        Controls.Add(rbEstudiante)
        Controls.Add(rbNormal)
        Name = "FormModo"
        Text = "FormModo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rbNormal As RadioButton
    Friend WithEvents rbEstudiante As RadioButton
    Friend WithEvents rbHoraFeliz As RadioButton
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
