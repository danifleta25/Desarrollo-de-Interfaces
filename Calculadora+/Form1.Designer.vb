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
        txtBoxOperacion = New RichTextBox()
        txtBoxResultado = New RichTextBox()
        tableLayoutPanel1 = New TableLayoutPanel()
        igual = New Label()
        label19 = New Label()
        label18 = New Label()
        label17 = New Label()
        sumar = New Label()
        label15 = New Label()
        label14 = New Label()
        label13 = New Label()
        restar = New Label()
        label11 = New Label()
        label10 = New Label()
        label9 = New Label()
        multiplicar = New Label()
        label7 = New Label()
        label6 = New Label()
        label5 = New Label()
        dividir = New Label()
        label3 = New Label()
        label2 = New Label()
        label1 = New Label()
        tableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBoxOperacion
        ' 
        txtBoxOperacion.BackColor = Color.Linen
        txtBoxOperacion.BorderStyle = BorderStyle.None
        txtBoxOperacion.Location = New Point(189, 5)
        txtBoxOperacion.Name = "txtBoxOperacion"
        txtBoxOperacion.Size = New Size(178, 47)
        txtBoxOperacion.TabIndex = 5
        txtBoxOperacion.Text = ""
        ' 
        ' txtBoxResultado
        ' 
        txtBoxResultado.BackColor = Color.Linen
        txtBoxResultado.BorderStyle = BorderStyle.None
        txtBoxResultado.Location = New Point(12, 58)
        txtBoxResultado.Name = "txtBoxResultado"
        txtBoxResultado.Size = New Size(355, 86)
        txtBoxResultado.TabIndex = 4
        txtBoxResultado.Text = ""
        ' 
        ' tableLayoutPanel1
        ' 
        tableLayoutPanel1.BackColor = Color.Linen
        tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        tableLayoutPanel1.ColumnCount = 4
        tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tableLayoutPanel1.Controls.Add(igual, 3, 4)
        tableLayoutPanel1.Controls.Add(label19, 2, 4)
        tableLayoutPanel1.Controls.Add(label18, 1, 4)
        tableLayoutPanel1.Controls.Add(label17, 0, 4)
        tableLayoutPanel1.Controls.Add(sumar, 3, 3)
        tableLayoutPanel1.Controls.Add(label15, 2, 3)
        tableLayoutPanel1.Controls.Add(label14, 1, 3)
        tableLayoutPanel1.Controls.Add(label13, 0, 3)
        tableLayoutPanel1.Controls.Add(restar, 3, 2)
        tableLayoutPanel1.Controls.Add(label11, 2, 2)
        tableLayoutPanel1.Controls.Add(label10, 1, 2)
        tableLayoutPanel1.Controls.Add(label9, 0, 2)
        tableLayoutPanel1.Controls.Add(multiplicar, 3, 1)
        tableLayoutPanel1.Controls.Add(label7, 2, 1)
        tableLayoutPanel1.Controls.Add(label6, 1, 1)
        tableLayoutPanel1.Controls.Add(label5, 0, 1)
        tableLayoutPanel1.Controls.Add(dividir, 3, 0)
        tableLayoutPanel1.Controls.Add(label3, 2, 0)
        tableLayoutPanel1.Controls.Add(label2, 1, 0)
        tableLayoutPanel1.Controls.Add(label1, 0, 0)
        tableLayoutPanel1.Location = New Point(12, 150)
        tableLayoutPanel1.Name = "tableLayoutPanel1"
        tableLayoutPanel1.RowCount = 5
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tableLayoutPanel1.Size = New Size(355, 295)
        tableLayoutPanel1.TabIndex = 3
        ' 
        ' igual
        ' 
        igual.BackColor = Color.WhiteSmoke
        igual.Dock = DockStyle.Fill
        igual.Font = New Font("OpenSymbol", 28F)
        igual.Location = New Point(270, 235)
        igual.Name = "igual"
        igual.Size = New Size(79, 57)
        igual.TabIndex = 19
        igual.Text = "="
        igual.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label19
        ' 
        label19.BackColor = Color.WhiteSmoke
        label19.Dock = DockStyle.Fill
        label19.Font = New Font("OpenSymbol", 28F)
        label19.Location = New Point(182, 235)
        label19.Name = "label19"
        label19.Size = New Size(79, 57)
        label19.TabIndex = 18
        label19.Text = ","
        label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label18
        ' 
        label18.BackColor = Color.WhiteSmoke
        label18.Dock = DockStyle.Fill
        label18.Font = New Font("OpenSymbol", 28F)
        label18.Location = New Point(94, 235)
        label18.Name = "label18"
        label18.Size = New Size(79, 57)
        label18.TabIndex = 17
        label18.Text = "0"
        label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label17
        ' 
        label17.BackColor = Color.WhiteSmoke
        label17.Dock = DockStyle.Fill
        label17.Font = New Font("OpenSymbol", 28F)
        label17.Location = New Point(6, 235)
        label17.Name = "label17"
        label17.Size = New Size(79, 57)
        label17.TabIndex = 16
        label17.Text = "+/-"
        label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' sumar
        ' 
        sumar.BackColor = Color.WhiteSmoke
        sumar.Dock = DockStyle.Fill
        sumar.Font = New Font("OpenSymbol", 28F)
        sumar.Location = New Point(270, 177)
        sumar.Name = "sumar"
        sumar.Size = New Size(79, 55)
        sumar.TabIndex = 15
        sumar.Text = "+"
        sumar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label15
        ' 
        label15.BackColor = Color.WhiteSmoke
        label15.Dock = DockStyle.Fill
        label15.Font = New Font("OpenSymbol", 28F)
        label15.Location = New Point(182, 177)
        label15.Name = "label15"
        label15.Size = New Size(79, 55)
        label15.TabIndex = 14
        label15.Text = "3"
        label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label14
        ' 
        label14.BackColor = Color.WhiteSmoke
        label14.Dock = DockStyle.Fill
        label14.Font = New Font("OpenSymbol", 28F)
        label14.Location = New Point(94, 177)
        label14.Name = "label14"
        label14.Size = New Size(79, 55)
        label14.TabIndex = 13
        label14.Text = "2"
        label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label13
        ' 
        label13.BackColor = Color.WhiteSmoke
        label13.Dock = DockStyle.Fill
        label13.Font = New Font("OpenSymbol", 28F)
        label13.Location = New Point(6, 177)
        label13.Name = "label13"
        label13.Size = New Size(79, 55)
        label13.TabIndex = 12
        label13.Text = "1"
        label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' restar
        ' 
        restar.BackColor = Color.WhiteSmoke
        restar.Dock = DockStyle.Fill
        restar.Font = New Font("OpenSymbol", 28F)
        restar.Location = New Point(270, 119)
        restar.Name = "restar"
        restar.Size = New Size(79, 55)
        restar.TabIndex = 11
        restar.Text = "-"
        restar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label11
        ' 
        label11.BackColor = Color.WhiteSmoke
        label11.Dock = DockStyle.Fill
        label11.Font = New Font("OpenSymbol", 28F)
        label11.Location = New Point(182, 119)
        label11.Name = "label11"
        label11.Size = New Size(79, 55)
        label11.TabIndex = 10
        label11.Text = "6"
        label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label10
        ' 
        label10.BackColor = Color.WhiteSmoke
        label10.Dock = DockStyle.Fill
        label10.Font = New Font("OpenSymbol", 28F)
        label10.Location = New Point(94, 119)
        label10.Name = "label10"
        label10.Size = New Size(79, 55)
        label10.TabIndex = 9
        label10.Text = "5"
        label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label9
        ' 
        label9.BackColor = Color.WhiteSmoke
        label9.Dock = DockStyle.Fill
        label9.Font = New Font("OpenSymbol", 28F)
        label9.Location = New Point(6, 119)
        label9.Name = "label9"
        label9.Size = New Size(79, 55)
        label9.TabIndex = 8
        label9.Text = "4"
        label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' multiplicar
        ' 
        multiplicar.BackColor = Color.WhiteSmoke
        multiplicar.Dock = DockStyle.Fill
        multiplicar.Font = New Font("OpenSymbol", 28F)
        multiplicar.Location = New Point(270, 61)
        multiplicar.Name = "multiplicar"
        multiplicar.Size = New Size(79, 55)
        multiplicar.TabIndex = 7
        multiplicar.Text = "x"
        multiplicar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label7
        ' 
        label7.BackColor = Color.WhiteSmoke
        label7.Dock = DockStyle.Fill
        label7.Font = New Font("OpenSymbol", 28F)
        label7.Location = New Point(182, 61)
        label7.Name = "label7"
        label7.Size = New Size(79, 55)
        label7.TabIndex = 6
        label7.Text = "9"
        label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label6
        ' 
        label6.BackColor = Color.WhiteSmoke
        label6.Dock = DockStyle.Fill
        label6.Font = New Font("OpenSymbol", 28F)
        label6.Location = New Point(94, 61)
        label6.Name = "label6"
        label6.Size = New Size(79, 55)
        label6.TabIndex = 5
        label6.Text = "8"
        label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label5
        ' 
        label5.BackColor = Color.WhiteSmoke
        label5.Dock = DockStyle.Fill
        label5.Font = New Font("OpenSymbol", 28F)
        label5.Location = New Point(6, 61)
        label5.Name = "label5"
        label5.Size = New Size(79, 55)
        label5.TabIndex = 4
        label5.Text = "7"
        label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dividir
        ' 
        dividir.BackColor = Color.WhiteSmoke
        dividir.Dock = DockStyle.Fill
        dividir.Font = New Font("OpenSymbol", 28F)
        dividir.Location = New Point(270, 3)
        dividir.Name = "dividir"
        dividir.Size = New Size(79, 55)
        dividir.TabIndex = 3
        dividir.Text = "÷"
        dividir.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label3
        ' 
        label3.BackColor = Color.WhiteSmoke
        label3.Dock = DockStyle.Fill
        label3.Font = New Font("OpenSymbol", 28F)
        label3.Location = New Point(182, 3)
        label3.Name = "label3"
        label3.Size = New Size(79, 55)
        label3.TabIndex = 2
        label3.Text = "⌫"
        label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label2
        ' 
        label2.BackColor = Color.WhiteSmoke
        label2.Dock = DockStyle.Fill
        label2.Font = New Font("OpenSymbol", 28F)
        label2.Location = New Point(94, 3)
        label2.Name = "label2"
        label2.Size = New Size(79, 55)
        label2.TabIndex = 1
        label2.Text = "C"
        label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label1
        ' 
        label1.BackColor = Color.WhiteSmoke
        label1.Dock = DockStyle.Fill
        label1.Font = New Font("OpenSymbol", 28F)
        label1.Location = New Point(6, 3)
        label1.Name = "label1"
        label1.Size = New Size(79, 55)
        label1.TabIndex = 0
        label1.Text = "CE"
        label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 464)
        Controls.Add(txtBoxOperacion)
        Controls.Add(txtBoxResultado)
        Controls.Add(tableLayoutPanel1)
        Name = "Form1"
        Text = "Calculadora"
        tableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents txtBoxOperacion As RichTextBox
    Private WithEvents txtBoxResultado As RichTextBox
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents igual As Label
    Private WithEvents label19 As Label
    Private WithEvents label18 As Label
    Private WithEvents label17 As Label
    Private WithEvents sumar As Label
    Private WithEvents label15 As Label
    Private WithEvents label14 As Label
    Private WithEvents label13 As Label
    Private WithEvents restar As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents multiplicar As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents dividir As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label

End Class
