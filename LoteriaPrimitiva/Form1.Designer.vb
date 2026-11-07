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
        lbl1 = New Label()
        lbl2 = New Label()
        lbl3 = New Label()
        lbl4 = New Label()
        lbl5 = New Label()
        lbl6 = New Label()
        lblReintegro = New Label()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.BackColor = SystemColors.ControlLight
        lbl1.BorderStyle = BorderStyle.Fixed3D
        lbl1.Dock = DockStyle.Left
        lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbl1.Location = New Point(0, 0)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(100, 81)
        lbl1.TabIndex = 0
        ' 
        ' lbl2
        ' 
        lbl2.BackColor = SystemColors.ControlLight
        lbl2.BorderStyle = BorderStyle.Fixed3D
        lbl2.Dock = DockStyle.Left
        lbl2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbl2.Location = New Point(100, 0)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(100, 81)
        lbl2.TabIndex = 1
        ' 
        ' lbl3
        ' 
        lbl3.BackColor = SystemColors.ControlLight
        lbl3.BorderStyle = BorderStyle.Fixed3D
        lbl3.Dock = DockStyle.Left
        lbl3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbl3.Location = New Point(200, 0)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(100, 81)
        lbl3.TabIndex = 2
        ' 
        ' lbl4
        ' 
        lbl4.BackColor = SystemColors.ControlLight
        lbl4.BorderStyle = BorderStyle.Fixed3D
        lbl4.Dock = DockStyle.Left
        lbl4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbl4.Location = New Point(300, 0)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(100, 81)
        lbl4.TabIndex = 3
        ' 
        ' lbl5
        ' 
        lbl5.BackColor = SystemColors.ControlLight
        lbl5.BorderStyle = BorderStyle.Fixed3D
        lbl5.Dock = DockStyle.Left
        lbl5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbl5.Location = New Point(400, 0)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(100, 81)
        lbl5.TabIndex = 4
        ' 
        ' lbl6
        ' 
        lbl6.BackColor = SystemColors.ControlLight
        lbl6.BorderStyle = BorderStyle.Fixed3D
        lbl6.Dock = DockStyle.Left
        lbl6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbl6.Location = New Point(500, 0)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(111, 81)
        lbl6.TabIndex = 5
        ' 
        ' lblReintegro
        ' 
        lblReintegro.BackColor = SystemColors.ControlLight
        lblReintegro.BorderStyle = BorderStyle.Fixed3D
        lblReintegro.Dock = DockStyle.Left
        lblReintegro.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblReintegro.Location = New Point(611, 0)
        lblReintegro.Name = "lblReintegro"
        lblReintegro.Size = New Size(118, 81)
        lblReintegro.TabIndex = 6
        lblReintegro.Text = "REINTEGRO:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(735, 81)
        Controls.Add(lblReintegro)
        Controls.Add(lbl6)
        Controls.Add(lbl5)
        Controls.Add(lbl4)
        Controls.Add(lbl3)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        Name = "Form1"
        Text = "La combinación de la primitiva es:"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl6 As Label

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Friend WithEvents lblReintegro As Label
End Class
