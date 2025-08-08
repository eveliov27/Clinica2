<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Me.gbxConsultas = New System.Windows.Forms.GroupBox()
        Me.cboTratamiento = New System.Windows.Forms.ComboBox()
        Me.lblTratamiento = New System.Windows.Forms.Label()
        Me.cboDoctor = New System.Windows.Forms.ComboBox()
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.cboPaciente = New System.Windows.Forms.ComboBox()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.dgv_consultas = New System.Windows.Forms.DataGridView()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttLimpiar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEliminar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttRegresar = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxConsultas.SuspendLayout()
        CType(Me.dgv_consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxConsultas
        '
        Me.gbxConsultas.BackColor = System.Drawing.Color.Cyan
        Me.gbxConsultas.Controls.Add(Me.cboTratamiento)
        Me.gbxConsultas.Controls.Add(Me.lblTratamiento)
        Me.gbxConsultas.Controls.Add(Me.cboDoctor)
        Me.gbxConsultas.Controls.Add(Me.lblDoctor)
        Me.gbxConsultas.Controls.Add(Me.cboPaciente)
        Me.gbxConsultas.Controls.Add(Me.lblPaciente)
        Me.gbxConsultas.Controls.Add(Me.dtpFecha)
        Me.gbxConsultas.Controls.Add(Me.lblFecha)
        Me.gbxConsultas.Controls.Add(Me.lblHora)
        Me.gbxConsultas.Controls.Add(Me.txtHora)
        Me.gbxConsultas.Controls.Add(Me.lblId)
        Me.gbxConsultas.Controls.Add(Me.btn_eliminar)
        Me.gbxConsultas.Controls.Add(Me.dgv_consultas)
        Me.gbxConsultas.Controls.Add(Me.lblObservaciones)
        Me.gbxConsultas.Controls.Add(Me.txtObservaciones)
        Me.gbxConsultas.Controls.Add(Me.btn_regresar)
        Me.gbxConsultas.Controls.Add(Me.btnLimpiar)
        Me.gbxConsultas.Controls.Add(Me.btn_guardar)
        Me.gbxConsultas.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxConsultas.Location = New System.Drawing.Point(-8, 4)
        Me.gbxConsultas.Name = "gbxConsultas"
        Me.gbxConsultas.Size = New System.Drawing.Size(924, 534)
        Me.gbxConsultas.TabIndex = 5
        Me.gbxConsultas.TabStop = False
        Me.gbxConsultas.Text = "Consultas"
        '
        'cboTratamiento
        '
        Me.cboTratamiento.FormattingEnabled = True
        Me.cboTratamiento.Location = New System.Drawing.Point(667, 230)
        Me.cboTratamiento.Name = "cboTratamiento"
        Me.cboTratamiento.Size = New System.Drawing.Size(192, 34)
        Me.cboTratamiento.TabIndex = 38
        '
        'lblTratamiento
        '
        Me.lblTratamiento.AutoSize = True
        Me.lblTratamiento.Location = New System.Drawing.Point(662, 192)
        Me.lblTratamiento.Name = "lblTratamiento"
        Me.lblTratamiento.Size = New System.Drawing.Size(129, 26)
        Me.lblTratamiento.TabIndex = 37
        Me.lblTratamiento.Text = "Tratamiento"
        '
        'cboDoctor
        '
        Me.cboDoctor.FormattingEnabled = True
        Me.cboDoctor.Location = New System.Drawing.Point(667, 137)
        Me.cboDoctor.Name = "cboDoctor"
        Me.cboDoctor.Size = New System.Drawing.Size(192, 34)
        Me.cboDoctor.TabIndex = 36
        '
        'lblDoctor
        '
        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Location = New System.Drawing.Point(662, 99)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(77, 26)
        Me.lblDoctor.TabIndex = 35
        Me.lblDoctor.Text = "Doctor"
        '
        'cboPaciente
        '
        Me.cboPaciente.FormattingEnabled = True
        Me.cboPaciente.Location = New System.Drawing.Point(667, 57)
        Me.cboPaciente.Name = "cboPaciente"
        Me.cboPaciente.Size = New System.Drawing.Size(192, 34)
        Me.cboPaciente.TabIndex = 34
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(662, 19)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(93, 26)
        Me.lblPaciente.TabIndex = 33
        Me.lblPaciente.Text = "Paciente"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(259, 87)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(350, 33)
        Me.dtpFecha.TabIndex = 32
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(331, 49)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(66, 26)
        Me.lblFecha.TabIndex = 31
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(35, 49)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(58, 26)
        Me.lblHora.TabIndex = 26
        Me.lblHora.Text = "Hora"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(34, 87)
        Me.txtHora.Multiline = True
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(150, 33)
        Me.txtHora.TabIndex = 25
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(885, 505)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(33, 26)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "ID"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_eliminar.Location = New System.Drawing.Point(345, 460)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(146, 55)
        Me.btn_eliminar.TabIndex = 23
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'dgv_consultas
        '
        Me.dgv_consultas.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgv_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultas.Location = New System.Drawing.Point(20, 288)
        Me.dgv_consultas.Name = "dgv_consultas"
        Me.dgv_consultas.RowHeadersWidth = 62
        Me.dgv_consultas.RowTemplate.Height = 28
        Me.dgv_consultas.Size = New System.Drawing.Size(882, 150)
        Me.dgv_consultas.TabIndex = 21
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(35, 137)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(149, 26)
        Me.lblObservaciones.TabIndex = 20
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(34, 166)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(455, 79)
        Me.txtObservaciones.TabIndex = 18
        '
        'btn_regresar
        '
        Me.btn_regresar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_regresar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(713, 460)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(146, 55)
        Me.btn_regresar.TabIndex = 6
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Beige
        Me.btnLimpiar.Location = New System.Drawing.Point(182, 460)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(146, 55)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_guardar.Location = New System.Drawing.Point(18, 460)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(146, 55)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(950, 548)
        Me.Controls.Add(Me.gbxConsultas)
        Me.Name = "frmConsulta"
        Me.Text = "frmConsulta"
        Me.gbxConsultas.ResumeLayout(False)
        Me.gbxConsultas.PerformLayout()
        CType(Me.dgv_consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxConsultas As GroupBox
    Friend WithEvents lblHora As Label
    Friend WithEvents txtHora As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents dgv_consultas As DataGridView
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents btn_regresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents cboTratamiento As ComboBox
    Friend WithEvents lblTratamiento As Label
    Friend WithEvents cboDoctor As ComboBox
    Friend WithEvents lblDoctor As Label
    Friend WithEvents cboPaciente As ComboBox
    Friend WithEvents lblPaciente As Label
    Friend WithEvents ttGuardar As ToolTip
    Friend WithEvents ttLimpiar As ToolTip
    Friend WithEvents ttEliminar As ToolTip
    Friend WithEvents ttRegresar As ToolTip
End Class
