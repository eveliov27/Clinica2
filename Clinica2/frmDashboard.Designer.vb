<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnEspecialidades = New System.Windows.Forms.Button()
        Me.btnDoctores = New System.Windows.Forms.Button()
        Me.btn_Personas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnUsuarios)
        Me.GroupBox1.Controls.Add(Me.btnConsultas)
        Me.GroupBox1.Controls.Add(Me.btnEspecialidades)
        Me.GroupBox1.Controls.Add(Me.btnDoctores)
        Me.GroupBox1.Controls.Add(Me.btn_Personas)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(690, 368)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opcion"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(570, 295)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 60)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.Teal
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 231)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(116, 60)
        Me.btnUsuarios.TabIndex = 4
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnConsultas
        '
        Me.btnConsultas.BackColor = System.Drawing.Color.Teal
        Me.btnConsultas.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.Location = New System.Drawing.Point(12, 295)
        Me.btnConsultas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(116, 60)
        Me.btnConsultas.TabIndex = 3
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = False
        '
        'btnEspecialidades
        '
        Me.btnEspecialidades.BackColor = System.Drawing.Color.Teal
        Me.btnEspecialidades.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEspecialidades.Location = New System.Drawing.Point(12, 167)
        Me.btnEspecialidades.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEspecialidades.Name = "btnEspecialidades"
        Me.btnEspecialidades.Size = New System.Drawing.Size(116, 60)
        Me.btnEspecialidades.TabIndex = 2
        Me.btnEspecialidades.Text = "Especialidades"
        Me.btnEspecialidades.UseVisualStyleBackColor = False
        '
        'btnDoctores
        '
        Me.btnDoctores.BackColor = System.Drawing.Color.Teal
        Me.btnDoctores.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctores.Location = New System.Drawing.Point(12, 103)
        Me.btnDoctores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDoctores.Name = "btnDoctores"
        Me.btnDoctores.Size = New System.Drawing.Size(116, 60)
        Me.btnDoctores.TabIndex = 1
        Me.btnDoctores.Text = "Doctores"
        Me.btnDoctores.UseVisualStyleBackColor = False
        '
        'btn_Personas
        '
        Me.btn_Personas.BackColor = System.Drawing.Color.Teal
        Me.btn_Personas.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Personas.Location = New System.Drawing.Point(12, 39)
        Me.btn_Personas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Personas.Name = "btn_Personas"
        Me.btn_Personas.Size = New System.Drawing.Size(116, 60)
        Me.btn_Personas.TabIndex = 0
        Me.btn_Personas.Text = "Personas"
        Me.btn_Personas.UseVisualStyleBackColor = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(709, 397)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnEspecialidades As Button
    Friend WithEvents btnDoctores As Button
    Friend WithEvents btn_Personas As Button
End Class
