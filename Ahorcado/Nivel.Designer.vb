<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nivel
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
        gBoxOpciones = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        btnAceptar = New Button()
        btnCancelar = New Button()
        gBoxOpciones.SuspendLayout()
        SuspendLayout()
        ' 
        ' gBoxOpciones
        ' 
        gBoxOpciones.Controls.Add(RadioButton3)
        gBoxOpciones.Controls.Add(RadioButton2)
        gBoxOpciones.Controls.Add(RadioButton1)
        gBoxOpciones.Location = New Point(12, 12)
        gBoxOpciones.Name = "gBoxOpciones"
        gBoxOpciones.Size = New Size(233, 187)
        gBoxOpciones.TabIndex = 0
        gBoxOpciones.TabStop = False
        gBoxOpciones.Text = "Nivel"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(20, 132)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(64, 19)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Experto"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(20, 85)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(83, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Intermedio"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(20, 36)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(88, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Principiante"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(32, 218)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 1
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(150, 218)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 2
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Nivel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(257, 263)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(gBoxOpciones)
        Name = "Nivel"
        Text = "Nivel"
        gBoxOpciones.ResumeLayout(False)
        gBoxOpciones.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gBoxOpciones As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
