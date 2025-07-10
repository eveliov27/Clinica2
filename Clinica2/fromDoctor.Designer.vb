<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromDoctor
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
        Me.gbxDoctores = New System.Windows.Forms.GroupBox()
        Me.cboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.dgv_doctor_view = New System.Windows.Forms.DataGridView()
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
        Me.gbxDoctores.SuspendLayout()
        CType(Me.dgv_doctor_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDoctores
        '
        Me.gbxDoctores.BackColor = System.Drawing.Color.Aquamarine
        Me.gbxDoctores.Controls.Add(Me.cboEspecialidad)
        Me.gbxDoctores.Controls.Add(Me.lblEspecialidad)
        Me.gbxDoctores.Controls.Add(Me.lblId)
        Me.gbxDoctores.Controls.Add(Me.dgv_doctor_view)
        Me.gbxDoctores.Controls.Add(Me.lblDireccion)
        Me.gbxDoctores.Controls.Add(Me.cboSexo)
        Me.gbxDoctores.Controls.Add(Me.txtDireccion)
        Me.gbxDoctores.Controls.Add(Me.lblSexo)
        Me.gbxDoctores.Controls.Add(Me.txtNombre)
        Me.gbxDoctores.Controls.Add(Me.txtApellidos)
        Me.gbxDoctores.Controls.Add(Me.txtEdad)
        Me.gbxDoctores.Controls.Add(Me.txtTelefono)
        Me.gbxDoctores.Controls.Add(Me.txtIdentificacion)
        Me.gbxDoctores.Controls.Add(Me.lblEdad)
        Me.gbxDoctores.Controls.Add(Me.lblTelefono)
        Me.gbxDoctores.Controls.Add(Me.lblApellidos)
        Me.gbxDoctores.Controls.Add(Me.lblNombre)
        Me.gbxDoctores.Controls.Add(Me.lblIdentificacion)
        Me.gbxDoctores.Controls.Add(Me.btnSalir)
        Me.gbxDoctores.Controls.Add(Me.btnLimpiar)
        Me.gbxDoctores.Controls.Add(Me.btnRegistrar)
        Me.gbxDoctores.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDoctores.Location = New System.Drawing.Point(12, 2)
        Me.gbxDoctores.Name = "gbxDoctores"
        Me.gbxDoctores.Size = New System.Drawing.Size(1051, 588)
        Me.gbxDoctores.TabIndex = 1
        Me.gbxDoctores.TabStop = False
        Me.gbxDoctores.Text = "Doctores"
        '
        'cboEspecialidad
        '
        Me.cboEspecialidad.FormattingEnabled = True
        Me.cboEspecialidad.Location = New System.Drawing.Point(833, 185)
        Me.cboEspecialidad.Name = "cboEspecialidad"
        Me.cboEspecialidad.Size = New System.Drawing.Size(192, 34)
        Me.cboEspecialidad.TabIndex = 25
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Location = New System.Drawing.Point(697, 188)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(129, 26)
        Me.lblEspecialidad.TabIndex = 24
        Me.lblEspecialidad.Text = "Especialidad"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(64, 299)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(33, 26)
        Me.lblId.TabIndex = 23
        Me.lblId.Text = "ID"
        '
        'dgv_doctor_view
        '
        Me.dgv_doctor_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_doctor_view.Location = New System.Drawing.Point(161, 266)
        Me.dgv_doctor_view.Name = "dgv_doctor_view"
        Me.dgv_doctor_view.RowHeadersWidth = 62
        Me.dgv_doctor_view.RowTemplate.Height = 28
        Me.dgv_doctor_view.Size = New System.Drawing.Size(864, 188)
        Me.dgv_doctor_view.TabIndex = 22
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(53, 188)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(102, 26)
        Me.lblDireccion.TabIndex = 20
        Me.lblDireccion.Text = "Direccion"
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Masculino", "Femenino", "No Detallado"})
        Me.cboSexo.Location = New System.Drawing.Point(833, 108)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(192, 34)
        Me.cboSexo.TabIndex = 19
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(161, 155)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(439, 89)
        Me.txtDireccion.TabIndex = 18
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(741, 111)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(57, 26)
        Me.lblSexo.TabIndex = 17
        Me.lblSexo.Text = "Sexo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(161, 104)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 33)
        Me.txtNombre.TabIndex = 16
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(494, 104)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(192, 33)
        Me.txtApellidos.TabIndex = 15
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(833, 32)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(192, 33)
        Me.txtEdad.TabIndex = 14
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(494, 32)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(192, 33)
        Me.txtTelefono.TabIndex = 13
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(161, 32)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(192, 33)
        Me.txtIdentificacion.TabIndex = 12
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(741, 35)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(58, 26)
        Me.lblEdad.TabIndex = 11
        Me.lblEdad.Text = "Edad"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(392, 39)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(96, 26)
        Me.lblTelefono.TabIndex = 10
        Me.lblTelefono.Text = "Telefono"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(388, 111)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(100, 26)
        Me.lblApellidos.TabIndex = 9
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(66, 111)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(89, 26)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(13, 39)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(142, 26)
        Me.lblIdentificacion.TabIndex = 7
        Me.lblIdentificacion.Text = "Identificacion"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(900, 479)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(145, 55)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnLimpiar.Location = New System.Drawing.Point(180, 479)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(145, 55)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRegistrar.Location = New System.Drawing.Point(29, 479)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(145, 55)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'fromDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 585)
        Me.Controls.Add(Me.gbxDoctores)
        Me.Name = "fromDoctor"
        Me.Text = "fromDoctor"
        Me.gbxDoctores.ResumeLayout(False)
        Me.gbxDoctores.PerformLayout()
        CType(Me.dgv_doctor_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxDoctores As GroupBox
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
    Friend WithEvents dgv_doctor_view As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents cboEspecialidad As ComboBox
    Friend WithEvents lblEspecialidad As Label
End Class
