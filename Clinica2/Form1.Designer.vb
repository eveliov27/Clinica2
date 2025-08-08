<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.txtPsswd = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPsswrd = New System.Windows.Forms.Label()
        Me.lblIngresarCorreo = New System.Windows.Forms.Label()
        Me.ttCrearCuenta = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttIngresar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttLimpiar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btn_crear)
        Me.GroupBox1.Controls.Add(Me.btn_ingresar)
        Me.GroupBox1.Controls.Add(Me.txtPsswd)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.lblPsswrd)
        Me.GroupBox1.Controls.Add(Me.lblIngresarCorreo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 533)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar al sistema"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Khaki
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(553, 402)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(180, 99)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(739, 402)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(180, 99)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btn_crear
        '
        Me.btn_crear.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_crear.Location = New System.Drawing.Point(5, 400)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(170, 99)
        Me.btn_crear.TabIndex = 5
        Me.btn_crear.Text = "Crear Cuenta"
        Me.btn_crear.UseVisualStyleBackColor = False
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_ingresar.Location = New System.Drawing.Point(190, 400)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(170, 99)
        Me.btn_ingresar.TabIndex = 4
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'txtPsswd
        '
        Me.txtPsswd.Location = New System.Drawing.Point(381, 250)
        Me.txtPsswd.Name = "txtPsswd"
        Me.txtPsswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsswd.Size = New System.Drawing.Size(233, 34)
        Me.txtPsswd.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(381, 125)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(233, 34)
        Me.txtUser.TabIndex = 2
        '
        'lblPsswrd
        '
        Me.lblPsswrd.AutoSize = True
        Me.lblPsswrd.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsswrd.Location = New System.Drawing.Point(58, 246)
        Me.lblPsswrd.Name = "lblPsswrd"
        Me.lblPsswrd.Size = New System.Drawing.Size(215, 27)
        Me.lblPsswrd.TabIndex = 1
        Me.lblPsswrd.Text = "Ingresar Contraseña"
        '
        'lblIngresarCorreo
        '
        Me.lblIngresarCorreo.AutoSize = True
        Me.lblIngresarCorreo.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresarCorreo.Location = New System.Drawing.Point(58, 125)
        Me.lblIngresarCorreo.Name = "lblIngresarCorreo"
        Me.lblIngresarCorreo.Size = New System.Drawing.Size(168, 27)
        Me.lblIngresarCorreo.TabIndex = 0
        Me.lblIngresarCorreo.Text = "Ingresar Correo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(958, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btn_crear As Button
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents txtPsswd As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblPsswrd As Label
    Friend WithEvents lblIngresarCorreo As Label
    Friend WithEvents ttCrearCuenta As ToolTip
    Friend WithEvents ttIngresar As ToolTip
    Friend WithEvents ttLimpiar As ToolTip
    Friend WithEvents ttSalir As ToolTip
End Class
