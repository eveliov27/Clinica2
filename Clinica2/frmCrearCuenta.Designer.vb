<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearCuenta
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
        Me.gbCrearCuenta = New System.Windows.Forms.GroupBox()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.cbo_Tipo_usuario = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txtPsswd = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblPsswrd = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ttRegresar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttLimpiar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbCrearCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCrearCuenta
        '
        Me.gbCrearCuenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbCrearCuenta.Controls.Add(Me.lblTipoUsuario)
        Me.gbCrearCuenta.Controls.Add(Me.cbo_Tipo_usuario)
        Me.gbCrearCuenta.Controls.Add(Me.btnLimpiar)
        Me.gbCrearCuenta.Controls.Add(Me.txtCorreo)
        Me.gbCrearCuenta.Controls.Add(Me.Label1)
        Me.gbCrearCuenta.Controls.Add(Me.btn_regresar)
        Me.gbCrearCuenta.Controls.Add(Me.btn_guardar)
        Me.gbCrearCuenta.Controls.Add(Me.txtPsswd)
        Me.gbCrearCuenta.Controls.Add(Me.txtNombre)
        Me.gbCrearCuenta.Controls.Add(Me.lblPsswrd)
        Me.gbCrearCuenta.Controls.Add(Me.lblNombre)
        Me.gbCrearCuenta.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCrearCuenta.Location = New System.Drawing.Point(29, 15)
        Me.gbCrearCuenta.Name = "gbCrearCuenta"
        Me.gbCrearCuenta.Size = New System.Drawing.Size(926, 541)
        Me.gbCrearCuenta.TabIndex = 2
        Me.gbCrearCuenta.TabStop = False
        Me.gbCrearCuenta.Text = "Crear Cuenta"
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUsuario.Location = New System.Drawing.Point(101, 374)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(172, 27)
        Me.lblTipoUsuario.TabIndex = 12
        Me.lblTipoUsuario.Text = "Tipo de Usuario"
        '
        'cbo_Tipo_usuario
        '
        Me.cbo_Tipo_usuario.FormattingEnabled = True
        Me.cbo_Tipo_usuario.Items.AddRange(New Object() {"Administrador", "Paciente", "Doctor", "Soporte"})
        Me.cbo_Tipo_usuario.Location = New System.Drawing.Point(377, 366)
        Me.cbo_Tipo_usuario.Name = "cbo_Tipo_usuario"
        Me.cbo_Tipo_usuario.Size = New System.Drawing.Size(237, 35)
        Me.cbo_Tipo_usuario.TabIndex = 11
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Khaki
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(377, 464)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(236, 71)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(381, 163)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(233, 34)
        Me.txtCorreo.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ingresar Correo"
        '
        'btn_regresar
        '
        Me.btn_regresar.BackColor = System.Drawing.Color.Teal
        Me.btn_regresar.Location = New System.Drawing.Point(6, 464)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(236, 71)
        Me.btn_regresar.TabIndex = 5
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Teal
        Me.btn_guardar.Location = New System.Drawing.Point(684, 464)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(236, 71)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'txtPsswd
        '
        Me.txtPsswd.Location = New System.Drawing.Point(381, 271)
        Me.txtPsswd.Name = "txtPsswd"
        Me.txtPsswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsswd.Size = New System.Drawing.Size(233, 34)
        Me.txtPsswd.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(381, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(233, 34)
        Me.txtNombre.TabIndex = 2
        '
        'lblPsswrd
        '
        Me.lblPsswrd.AutoSize = True
        Me.lblPsswrd.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsswrd.Location = New System.Drawing.Point(58, 267)
        Me.lblPsswrd.Name = "lblPsswrd"
        Me.lblPsswrd.Size = New System.Drawing.Size(215, 27)
        Me.lblPsswrd.TabIndex = 1
        Me.lblPsswrd.Text = "Ingresar Contraseña"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(178, 71)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(95, 27)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'ttGuardar
        '
        '
        'frmCrearCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 568)
        Me.Controls.Add(Me.gbCrearCuenta)
        Me.Name = "frmCrearCuenta"
        Me.Text = "frmCrearCuenta"
        Me.gbCrearCuenta.ResumeLayout(False)
        Me.gbCrearCuenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCrearCuenta As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_regresar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txtPsswd As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblPsswrd As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents cbo_Tipo_usuario As ComboBox
    Friend WithEvents lblTipoUsuario As Label
    Friend WithEvents ttRegresar As ToolTip
    Friend WithEvents ttLimpiar As ToolTip
    Friend WithEvents ttGuardar As ToolTip
End Class
