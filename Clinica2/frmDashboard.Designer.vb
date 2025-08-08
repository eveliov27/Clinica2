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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTratamientos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnEspecialidades = New System.Windows.Forms.Button()
        Me.btnDoctores = New System.Windows.Forms.Button()
        Me.btn_Personas = New System.Windows.Forms.Button()
        Me.ttPersonas = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttDoctores = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEspecialidades = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttUsuarios = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttConsultas = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttTratameintos = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnTratamientos)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnUsuarios)
        Me.GroupBox1.Controls.Add(Me.btnConsultas)
        Me.GroupBox1.Controls.Add(Me.btnEspecialidades)
        Me.GroupBox1.Controls.Add(Me.btnDoctores)
        Me.GroupBox1.Controls.Add(Me.btn_Personas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 557)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opcion"
        '
        'btnTratamientos
        '
        Me.btnTratamientos.BackColor = System.Drawing.Color.Teal
        Me.btnTratamientos.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTratamientos.Location = New System.Drawing.Point(841, 60)
        Me.btnTratamientos.Name = "btnTratamientos"
        Me.btnTratamientos.Size = New System.Drawing.Size(174, 92)
        Me.btnTratamientos.TabIndex = 6
        Me.btnTratamientos.Text = "Tratamientos"
        Me.btnTratamientos.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(855, 454)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(160, 92)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.Teal
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Location = New System.Drawing.Point(18, 355)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(174, 92)
        Me.btnUsuarios.TabIndex = 4
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnConsultas
        '
        Me.btnConsultas.BackColor = System.Drawing.Color.Teal
        Me.btnConsultas.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.Location = New System.Drawing.Point(18, 454)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(174, 92)
        Me.btnConsultas.TabIndex = 3
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = False
        '
        'btnEspecialidades
        '
        Me.btnEspecialidades.BackColor = System.Drawing.Color.Teal
        Me.btnEspecialidades.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEspecialidades.Location = New System.Drawing.Point(18, 257)
        Me.btnEspecialidades.Name = "btnEspecialidades"
        Me.btnEspecialidades.Size = New System.Drawing.Size(174, 92)
        Me.btnEspecialidades.TabIndex = 2
        Me.btnEspecialidades.Text = "Especialidades"
        Me.btnEspecialidades.UseVisualStyleBackColor = False
        '
        'btnDoctores
        '
        Me.btnDoctores.BackColor = System.Drawing.Color.Teal
        Me.btnDoctores.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctores.Location = New System.Drawing.Point(18, 158)
        Me.btnDoctores.Name = "btnDoctores"
        Me.btnDoctores.Size = New System.Drawing.Size(174, 92)
        Me.btnDoctores.TabIndex = 1
        Me.btnDoctores.Text = "Doctores"
        Me.btnDoctores.UseVisualStyleBackColor = False
        '
        'btn_Personas
        '
        Me.btn_Personas.BackColor = System.Drawing.Color.Teal
        Me.btn_Personas.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Personas.Location = New System.Drawing.Point(18, 60)
        Me.btn_Personas.Name = "btn_Personas"
        Me.btn_Personas.Size = New System.Drawing.Size(174, 92)
        Me.btn_Personas.TabIndex = 0
        Me.btn_Personas.Text = "Personas"
        Me.btn_Personas.UseVisualStyleBackColor = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1064, 597)
        Me.Controls.Add(Me.GroupBox1)
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
    Friend WithEvents btnTratamientos As Button
    Friend WithEvents ttPersonas As ToolTip
    Friend WithEvents ttDoctores As ToolTip
    Friend WithEvents ttEspecialidades As ToolTip
    Friend WithEvents ttUsuarios As ToolTip
    Friend WithEvents ttConsultas As ToolTip
    Friend WithEvents ttTratameintos As ToolTip
    Friend WithEvents ttSalir As ToolTip
End Class
