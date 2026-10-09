<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        startButton = New Button()
        cociente = New NumericUpDown()
        label8 = New Label()
        label9 = New Label()
        dividedRightLabel = New Label()
        dividedLeftLabel = New Label()
        producto = New NumericUpDown()
        label6 = New Label()
        label7 = New Label()
        timesRightLabel = New Label()
        timesLeftLabel = New Label()
        diferencia = New NumericUpDown()
        label2 = New Label()
        label5 = New Label()
        minusRightLabel = New Label()
        minusLeftLabel = New Label()
        suma = New NumericUpDown()
        label4 = New Label()
        label3 = New Label()
        plusRightLabel = New Label()
        plusLeftLabel = New Label()
        label1 = New Label()
        timeLabel = New Label()
        Timer1 = New Timer(components)
        CType(cociente, ComponentModel.ISupportInitialize).BeginInit()
        CType(producto, ComponentModel.ISupportInitialize).BeginInit()
        CType(diferencia, ComponentModel.ISupportInitialize).BeginInit()
        CType(suma, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' startButton
        ' 
        startButton.AutoSize = True
        startButton.Font = New Font("Segoe UI", 14F)
        startButton.Location = New Point(178, 314)
        startButton.Name = "startButton"
        startButton.Size = New Size(111, 35)
        startButton.TabIndex = 23
        startButton.Text = "Iniciar "
        startButton.UseVisualStyleBackColor = True
        ' 
        ' cociente
        ' 
        cociente.Font = New Font("Segoe UI", 18F)
        cociente.Location = New Point(268, 238)
        cociente.Name = "cociente"
        cociente.Size = New Size(100, 39)
        cociente.TabIndex = 31
        ' 
        ' label8
        ' 
        label8.Font = New Font("Segoe UI", 18F)
        label8.Location = New Point(208, 231)
        label8.Name = "label8"
        label8.Size = New Size(60, 50)
        label8.TabIndex = 43
        label8.Text = "="
        label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label9
        ' 
        label9.Font = New Font("Segoe UI", 18F)
        label9.Location = New Point(76, 231)
        label9.Name = "label9"
        label9.Size = New Size(60, 50)
        label9.TabIndex = 42
        label9.Text = "÷"
        label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dividedRightLabel
        ' 
        dividedRightLabel.Font = New Font("Segoe UI", 18F)
        dividedRightLabel.Location = New Point(142, 231)
        dividedRightLabel.Name = "dividedRightLabel"
        dividedRightLabel.Size = New Size(60, 50)
        dividedRightLabel.TabIndex = 41
        dividedRightLabel.Text = "?"
        dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dividedLeftLabel
        ' 
        dividedLeftLabel.Font = New Font("Segoe UI", 18F)
        dividedLeftLabel.Location = New Point(10, 231)
        dividedLeftLabel.Name = "dividedLeftLabel"
        dividedLeftLabel.Size = New Size(60, 50)
        dividedLeftLabel.TabIndex = 40
        dividedLeftLabel.Text = "?"
        dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' producto
        ' 
        producto.Font = New Font("Segoe UI", 18F)
        producto.Location = New Point(268, 188)
        producto.Name = "producto"
        producto.Size = New Size(100, 39)
        producto.TabIndex = 28
        ' 
        ' label6
        ' 
        label6.Font = New Font("Segoe UI", 18F)
        label6.Location = New Point(208, 181)
        label6.Name = "label6"
        label6.Size = New Size(60, 50)
        label6.TabIndex = 39
        label6.Text = "="
        label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label7
        ' 
        label7.Font = New Font("Segoe UI", 18F)
        label7.Location = New Point(76, 181)
        label7.Name = "label7"
        label7.Size = New Size(60, 50)
        label7.TabIndex = 38
        label7.Text = "x"
        label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timesRightLabel
        ' 
        timesRightLabel.Font = New Font("Segoe UI", 18F)
        timesRightLabel.Location = New Point(142, 181)
        timesRightLabel.Name = "timesRightLabel"
        timesRightLabel.Size = New Size(60, 50)
        timesRightLabel.TabIndex = 37
        timesRightLabel.Text = "?"
        timesRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timesLeftLabel
        ' 
        timesLeftLabel.Font = New Font("Segoe UI", 18F)
        timesLeftLabel.Location = New Point(10, 181)
        timesLeftLabel.Name = "timesLeftLabel"
        timesLeftLabel.Size = New Size(60, 50)
        timesLeftLabel.TabIndex = 36
        timesLeftLabel.Text = "?"
        timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' diferencia
        ' 
        diferencia.Font = New Font("Segoe UI", 18F)
        diferencia.Location = New Point(269, 138)
        diferencia.Name = "diferencia"
        diferencia.Size = New Size(100, 39)
        diferencia.TabIndex = 26
        ' 
        ' label2
        ' 
        label2.Font = New Font("Segoe UI", 18F)
        label2.Location = New Point(209, 131)
        label2.Name = "label2"
        label2.Size = New Size(60, 50)
        label2.TabIndex = 35
        label2.Text = "="
        label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label5
        ' 
        label5.Font = New Font("Segoe UI", 18F)
        label5.Location = New Point(77, 131)
        label5.Name = "label5"
        label5.Size = New Size(60, 50)
        label5.TabIndex = 34
        label5.Text = "-"
        label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' minusRightLabel
        ' 
        minusRightLabel.Font = New Font("Segoe UI", 18F)
        minusRightLabel.Location = New Point(143, 131)
        minusRightLabel.Name = "minusRightLabel"
        minusRightLabel.Size = New Size(60, 50)
        minusRightLabel.TabIndex = 33
        minusRightLabel.Text = "?"
        minusRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' minusLeftLabel
        ' 
        minusLeftLabel.Font = New Font("Segoe UI", 18F)
        minusLeftLabel.Location = New Point(11, 131)
        minusLeftLabel.Name = "minusLeftLabel"
        minusLeftLabel.Size = New Size(60, 50)
        minusLeftLabel.TabIndex = 32
        minusLeftLabel.Text = "?"
        minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' suma
        ' 
        suma.Font = New Font("Segoe UI", 18F)
        suma.Location = New Point(269, 88)
        suma.Name = "suma"
        suma.Size = New Size(100, 39)
        suma.TabIndex = 25
        ' 
        ' label4
        ' 
        label4.Font = New Font("Segoe UI", 18F)
        label4.Location = New Point(209, 81)
        label4.Name = "label4"
        label4.Size = New Size(60, 50)
        label4.TabIndex = 30
        label4.Text = "="
        label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label3
        ' 
        label3.Font = New Font("Segoe UI", 18F)
        label3.Location = New Point(77, 81)
        label3.Name = "label3"
        label3.Size = New Size(60, 50)
        label3.TabIndex = 29
        label3.Text = "+"
        label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' plusRightLabel
        ' 
        plusRightLabel.Font = New Font("Segoe UI", 18F)
        plusRightLabel.Location = New Point(143, 81)
        plusRightLabel.Name = "plusRightLabel"
        plusRightLabel.Size = New Size(60, 50)
        plusRightLabel.TabIndex = 27
        plusRightLabel.Text = "?"
        plusRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' plusLeftLabel
        ' 
        plusLeftLabel.Font = New Font("Segoe UI", 18F)
        plusLeftLabel.Location = New Point(11, 81)
        plusLeftLabel.Name = "plusLeftLabel"
        plusLeftLabel.Size = New Size(60, 50)
        plusLeftLabel.TabIndex = 24
        plusLeftLabel.Text = "?"
        plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 15.75F)
        label1.Location = New Point(100, 26)
        label1.Name = "label1"
        label1.Size = New Size(168, 30)
        label1.TabIndex = 22
        label1.Text = "Tiempo Restante"
        ' 
        ' timeLabel
        ' 
        timeLabel.BackColor = SystemColors.ControlDark
        timeLabel.BorderStyle = BorderStyle.FixedSingle
        timeLabel.Font = New Font("Segoe UI", 15.75F)
        timeLabel.Location = New Point(274, 25)
        timeLabel.Name = "timeLabel"
        timeLabel.Size = New Size(200, 30)
        timeLabel.TabIndex = 21
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 357)
        Controls.Add(startButton)
        Controls.Add(cociente)
        Controls.Add(label8)
        Controls.Add(label9)
        Controls.Add(dividedRightLabel)
        Controls.Add(dividedLeftLabel)
        Controls.Add(producto)
        Controls.Add(label6)
        Controls.Add(label7)
        Controls.Add(timesRightLabel)
        Controls.Add(timesLeftLabel)
        Controls.Add(diferencia)
        Controls.Add(label2)
        Controls.Add(label5)
        Controls.Add(minusRightLabel)
        Controls.Add(minusLeftLabel)
        Controls.Add(suma)
        Controls.Add(label4)
        Controls.Add(label3)
        Controls.Add(plusRightLabel)
        Controls.Add(plusLeftLabel)
        Controls.Add(label1)
        Controls.Add(timeLabel)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "Form1"
        Text = "Prueba matemática"
        CType(cociente, ComponentModel.ISupportInitialize).EndInit()
        CType(producto, ComponentModel.ISupportInitialize).EndInit()
        CType(diferencia, ComponentModel.ISupportInitialize).EndInit()
        CType(suma, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents startButton As Button
    Private WithEvents cociente As NumericUpDown
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents dividedRightLabel As Label
    Private WithEvents dividedLeftLabel As Label
    Private WithEvents producto As NumericUpDown
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
    Private WithEvents timesRightLabel As Label
    Private WithEvents timesLeftLabel As Label
    Private WithEvents diferencia As NumericUpDown
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents minusRightLabel As Label
    Private WithEvents minusLeftLabel As Label
    Private WithEvents suma As NumericUpDown
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents plusRightLabel As Label
    Private WithEvents plusLeftLabel As Label
    Private WithEvents label1 As Label
    Private WithEvents timeLabel As Label
    Friend WithEvents Timer1 As Timer

End Class
