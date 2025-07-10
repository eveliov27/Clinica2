<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.gbxPersonas = New System.Windows.Forms.GroupBox()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.cbo_Tipo_usuario = New System.Windows.Forms.ComboBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPsswd = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblPsswrd = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dgv_Usuarios = New System.Windows.Forms.DataGridView()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.gbxPersonas.SuspendLayout()
        CType(Me.dgv_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxPersonas
        '
        Me.gbxPersonas.BackColor = System.Drawing.Color.PaleTurquoise
        Me.gbxPersonas.Controls.Add(Me.lblTipoUsuario)
        Me.gbxPersonas.Controls.Add(Me.cbo_Tipo_usuario)
        Me.gbxPersonas.Controls.Add(Me.txtCorreo)
        Me.gbxPersonas.Controls.Add(Me.Label1)
        Me.gbxPersonas.Controls.Add(Me.txtPsswd)
        Me.gbxPersonas.Controls.Add(Me.txtNombre)
        Me.gbxPersonas.Controls.Add(Me.lblPsswrd)
        Me.gbxPersonas.Controls.Add(Me.lblNombre)
        Me.gbxPersonas.Controls.Add(Me.lblId)
        Me.gbxPersonas.Controls.Add(Me.btn_eliminar)
        Me.gbxPersonas.Controls.Add(Me.btnEditar)
        Me.gbxPersonas.Controls.Add(Me.dgv_Usuarios)
        Me.gbxPersonas.Controls.Add(Me.btn_regresar)
        Me.gbxPersonas.Controls.Add(Me.btnLimpiar)
        Me.gbxPersonas.Controls.Add(Me.btn_guardar)
        Me.gbxPersonas.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPersonas.Location = New System.Drawing.Point(11, 11)
        Me.gbxPersonas.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxPersonas.Name = "gbxPersonas"
        Me.gbxPersonas.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxPersonas.Size = New System.Drawing.Size(723, 428)
        Me.gbxPersonas.TabIndex = 4
        Me.gbxPersonas.TabStop = False
        Me.gbxPersonas.Text = "Agregar Especialidad"
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUsuario.Location = New System.Drawing.Point(390, 68)
        Me.lblTipoUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(119, 19)
        Me.lblTipoUsuario.TabIndex = 40
        Me.lblTipoUsuario.Text = "Tipo de Usuario"
        '
        'cbo_Tipo_usuario
        '
        Me.cbo_Tipo_usuario.FormattingEnabled = True
        Me.cbo_Tipo_usuario.Items.AddRange(New Object() {"Administrador", "Paciente", "Doctor", "Soporte"})
        Me.cbo_Tipo_usuario.Location = New System.Drawing.Point(513, 63)
        Me.cbo_Tipo_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_Tipo_usuario.Name = "cbo_Tipo_usuario"
        Me.cbo_Tipo_usuario.Size = New System.Drawing.Size(159, 24)
        Me.cbo_Tipo_usuario.TabIndex = 39
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(513, 26)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(157, 24)
        Me.txtCorreo.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Ingresar Correo"
        '
        'txtPsswd
        '
        Me.txtPsswd.Location = New System.Drawing.Point(166, 63)
        Me.txtPsswd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPsswd.Name = "txtPsswd"
        Me.txtPsswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsswd.Size = New System.Drawing.Size(157, 24)
        Me.txtPsswd.TabIndex = 36
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(166, 26)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(157, 24)
        Me.txtNombre.TabIndex = 35
        '
        'lblPsswrd
        '
        Me.lblPsswrd.AutoSize = True
        Me.lblPsswrd.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsswrd.Location = New System.Drawing.Point(12, 63)
        Me.lblPsswrd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPsswrd.Name = "lblPsswrd"
        Me.lblPsswrd.Size = New System.Drawing.Size(150, 19)
        Me.lblPsswrd.TabIndex = 34
        Me.lblPsswrd.Text = "Ingresar Contraseña"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(95, 31)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 19)
        Me.lblNombre.TabIndex = 33
        Me.lblNombre.Text = "Nombre"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(36, 102)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 18)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "ID"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_eliminar.Location = New System.Drawing.Point(334, 388)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(97, 36)
        Me.btn_eliminar.TabIndex = 23
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnEditar.Location = New System.Drawing.Point(226, 388)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(97, 36)
        Me.btnEditar.TabIndex = 22
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'dgv_Usuarios
        '
        Me.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Usuarios.Location = New System.Drawing.Point(39, 131)
        Me.dgv_Usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Usuarios.Name = "dgv_Usuarios"
        Me.dgv_Usuarios.RowHeadersWidth = 62
        Me.dgv_Usuarios.RowTemplate.Height = 28
        Me.dgv_Usuarios.Size = New System.Drawing.Size(633, 243)
        Me.dgv_Usuarios.TabIndex = 21
        '
        'btn_regresar
        '
        Me.btn_regresar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_regresar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(622, 388)
        Me.btn_regresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(97, 36)
        Me.btn_regresar.TabIndex = 6
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Beige
        Me.btnLimpiar.Location = New System.Drawing.Point(114, 388)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(97, 36)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_guardar.Location = New System.Drawing.Point(5, 388)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(97, 36)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 450)
        Me.Controls.Add(Me.gbxPersonas)
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuarios"
        Me.gbxPersonas.ResumeLayout(False)
        Me.gbxPersonas.PerformLayout()
        CType(Me.dgv_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxPersonas As GroupBox
    Friend WithEvents lblId As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents dgv_Usuarios As DataGridView
    Friend WithEvents btn_regresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents lblTipoUsuario As Label
    Friend WithEvents cbo_Tipo_usuario As ComboBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPsswd As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblPsswrd As Label
    Friend WithEvents lblNombre As Label
End Class
