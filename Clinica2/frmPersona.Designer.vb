<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersona
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
        Me.gbxPersona = New System.Windows.Forms.GroupBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha_Nac = New System.Windows.Forms.Label()
        Me.txtConacto = New System.Windows.Forms.TextBox()
        Me.lblConacto_Emer = New System.Windows.Forms.Label()
        Me.lblTipo_Sangre = New System.Windows.Forms.Label()
        Me.cboTipo_Sangre = New System.Windows.Forms.ComboBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.dgv_persona_view = New System.Windows.Forms.DataGridView()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.gbxPersona.SuspendLayout()
        CType(Me.dgv_persona_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxPersona
        '
        Me.gbxPersona.AutoSize = True
        Me.gbxPersona.BackColor = System.Drawing.Color.PaleGreen
        Me.gbxPersona.Controls.Add(Me.dtpFechaNac)
        Me.gbxPersona.Controls.Add(Me.lblFecha_Nac)
        Me.gbxPersona.Controls.Add(Me.txtConacto)
        Me.gbxPersona.Controls.Add(Me.lblConacto_Emer)
        Me.gbxPersona.Controls.Add(Me.lblTipo_Sangre)
        Me.gbxPersona.Controls.Add(Me.cboTipo_Sangre)
        Me.gbxPersona.Controls.Add(Me.lblId)
        Me.gbxPersona.Controls.Add(Me.dgv_persona_view)
        Me.gbxPersona.Controls.Add(Me.lblDireccion)
        Me.gbxPersona.Controls.Add(Me.cboSexo)
        Me.gbxPersona.Controls.Add(Me.txtDireccion)
        Me.gbxPersona.Controls.Add(Me.lblSexo)
        Me.gbxPersona.Controls.Add(Me.txtNombre)
        Me.gbxPersona.Controls.Add(Me.txtApellidos)
        Me.gbxPersona.Controls.Add(Me.txtEdad)
        Me.gbxPersona.Controls.Add(Me.txtTelefono)
        Me.gbxPersona.Controls.Add(Me.txtIdentificacion)
        Me.gbxPersona.Controls.Add(Me.lblEdad)
        Me.gbxPersona.Controls.Add(Me.lblTelefono)
        Me.gbxPersona.Controls.Add(Me.lblApellidos)
        Me.gbxPersona.Controls.Add(Me.lblNombre)
        Me.gbxPersona.Controls.Add(Me.lblIdentificacion)
        Me.gbxPersona.Controls.Add(Me.btnSalir)
        Me.gbxPersona.Controls.Add(Me.btnLimpiar)
        Me.gbxPersona.Controls.Add(Me.btnRegistrar)
        Me.gbxPersona.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPersona.Location = New System.Drawing.Point(1, 7)
        Me.gbxPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxPersona.Name = "gbxPersona"
        Me.gbxPersona.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxPersona.Size = New System.Drawing.Size(710, 382)
        Me.gbxPersona.TabIndex = 2
        Me.gbxPersona.TabStop = False
        Me.gbxPersona.Text = "Agregar pacientes"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(162, 119)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(265, 24)
        Me.dtpFechaNac.TabIndex = 30
        '
        'lblFecha_Nac
        '
        Me.lblFecha_Nac.AutoSize = True
        Me.lblFecha_Nac.Location = New System.Drawing.Point(17, 122)
        Me.lblFecha_Nac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha_Nac.Name = "lblFecha_Nac"
        Me.lblFecha_Nac.Size = New System.Drawing.Size(148, 18)
        Me.lblFecha_Nac.TabIndex = 29
        Me.lblFecha_Nac.Text = "Fecha de Nacimiento"
        '
        'txtConacto
        '
        Me.txtConacto.Location = New System.Drawing.Point(468, 176)
        Me.txtConacto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConacto.Multiline = True
        Me.txtConacto.Name = "txtConacto"
        Me.txtConacto.Size = New System.Drawing.Size(214, 50)
        Me.txtConacto.TabIndex = 28
        '
        'lblConacto_Emer
        '
        Me.lblConacto_Emer.AutoSize = True
        Me.lblConacto_Emer.Location = New System.Drawing.Point(464, 157)
        Me.lblConacto_Emer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConacto_Emer.Name = "lblConacto_Emer"
        Me.lblConacto_Emer.Size = New System.Drawing.Size(171, 18)
        Me.lblConacto_Emer.TabIndex = 27
        Me.lblConacto_Emer.Text = "Contacto de Emergencia"
        '
        'lblTipo_Sangre
        '
        Me.lblTipo_Sangre.AutoSize = True
        Me.lblTipo_Sangre.Location = New System.Drawing.Point(430, 122)
        Me.lblTipo_Sangre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipo_Sangre.Name = "lblTipo_Sangre"
        Me.lblTipo_Sangre.Size = New System.Drawing.Size(110, 18)
        Me.lblTipo_Sangre.TabIndex = 26
        Me.lblTipo_Sangre.Text = "Tipo de Sangre"
        '
        'cboTipo_Sangre
        '
        Me.cboTipo_Sangre.FormattingEnabled = True
        Me.cboTipo_Sangre.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.cboTipo_Sangre.Location = New System.Drawing.Point(555, 120)
        Me.cboTipo_Sangre.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipo_Sangre.Name = "cboTipo_Sangre"
        Me.cboTipo_Sangre.Size = New System.Drawing.Size(129, 24)
        Me.cboTipo_Sangre.TabIndex = 25
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(326, 317)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 18)
        Me.lblId.TabIndex = 23
        Me.lblId.Text = "ID"
        '
        'dgv_persona_view
        '
        Me.dgv_persona_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_persona_view.Location = New System.Drawing.Point(4, 185)
        Me.dgv_persona_view.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_persona_view.Name = "dgv_persona_view"
        Me.dgv_persona_view.RowHeadersWidth = 62
        Me.dgv_persona_view.RowTemplate.Height = 28
        Me.dgv_persona_view.Size = New System.Drawing.Size(425, 122)
        Me.dgv_persona_view.TabIndex = 22
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(465, 231)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(71, 18)
        Me.lblDireccion.TabIndex = 20
        Me.lblDireccion.Text = "Direccion"
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Masculino", "Femenino", "No Detallado"})
        Me.cboSexo.Location = New System.Drawing.Point(555, 70)
        Me.cboSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(129, 24)
        Me.cboSexo.TabIndex = 19
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(468, 250)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(214, 59)
        Me.txtDireccion.TabIndex = 18
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(494, 72)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(41, 18)
        Me.lblSexo.TabIndex = 17
        Me.lblSexo.Text = "Sexo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(107, 68)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(129, 24)
        Me.txtNombre.TabIndex = 16
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(329, 68)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(129, 24)
        Me.txtApellidos.TabIndex = 15
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(555, 21)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(129, 24)
        Me.txtEdad.TabIndex = 14
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(329, 21)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(129, 24)
        Me.txtTelefono.TabIndex = 13
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(107, 21)
        Me.txtIdentificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(129, 24)
        Me.txtIdentificacion.TabIndex = 12
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(494, 23)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(41, 18)
        Me.lblEdad.TabIndex = 11
        Me.lblEdad.Text = "Edad"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(261, 25)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(67, 18)
        Me.lblTelefono.TabIndex = 10
        Me.lblTelefono.Text = "Telefono"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(259, 72)
        Me.lblApellidos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(71, 18)
        Me.lblApellidos.TabIndex = 9
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(44, 72)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 18)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(9, 25)
        Me.lblIdentificacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(98, 18)
        Me.lblIdentificacion.TabIndex = 7
        Me.lblIdentificacion.Text = "Identificacion"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(587, 324)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 36)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnLimpiar.Location = New System.Drawing.Point(121, 324)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(97, 36)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRegistrar.Location = New System.Drawing.Point(12, 324)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(97, 36)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'frmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 397)
        Me.Controls.Add(Me.gbxPersona)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPersona"
        Me.Text = "frmPersona"
        Me.gbxPersona.ResumeLayout(False)
        Me.gbxPersona.PerformLayout()
        CType(Me.dgv_persona_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxPersona As GroupBox
    Friend WithEvents cboTipo_Sangre As ComboBox
    Friend WithEvents lblId As Label
    Friend WithEvents dgv_persona_view As DataGridView
    Friend WithEvents lblDireccion As Label
    Friend WithEvents cboSexo As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents lblFecha_Nac As Label
    Friend WithEvents txtConacto As TextBox
    Friend WithEvents lblConacto_Emer As Label
    Friend WithEvents lblTipo_Sangre As Label
End Class
