<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTratamiento
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
        Me.gbxTratamientos = New System.Windows.Forms.GroupBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.dgv_especialidades = New System.Windows.Forms.DataGridView()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttLimpiar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttEliminar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttRegresar = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxTratamientos.SuspendLayout()
        CType(Me.dgv_especialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxTratamientos
        '
        Me.gbxTratamientos.BackColor = System.Drawing.Color.Cyan
        Me.gbxTratamientos.Controls.Add(Me.lblCosto)
        Me.gbxTratamientos.Controls.Add(Me.txtCosto)
        Me.gbxTratamientos.Controls.Add(Me.lblNombre)
        Me.gbxTratamientos.Controls.Add(Me.txtNombre)
        Me.gbxTratamientos.Controls.Add(Me.lblId)
        Me.gbxTratamientos.Controls.Add(Me.btn_eliminar)
        Me.gbxTratamientos.Controls.Add(Me.dgv_especialidades)
        Me.gbxTratamientos.Controls.Add(Me.lblDescripcion)
        Me.gbxTratamientos.Controls.Add(Me.txtDescripcion)
        Me.gbxTratamientos.Controls.Add(Me.btn_regresar)
        Me.gbxTratamientos.Controls.Add(Me.btnLimpiar)
        Me.gbxTratamientos.Controls.Add(Me.btn_guardar)
        Me.gbxTratamientos.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTratamientos.Location = New System.Drawing.Point(21, 11)
        Me.gbxTratamientos.Name = "gbxTratamientos"
        Me.gbxTratamientos.Size = New System.Drawing.Size(924, 534)
        Me.gbxTratamientos.TabIndex = 4
        Me.gbxTratamientos.TabStop = False
        Me.gbxTratamientos.Text = "Agregar Tratamientos"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Location = New System.Drawing.Point(345, 32)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(65, 26)
        Me.lblCosto.TabIndex = 28
        Me.lblCosto.Text = "Costo"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(350, 61)
        Me.txtCosto.Multiline = True
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(282, 44)
        Me.txtCosto.TabIndex = 27
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(13, 29)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(89, 26)
        Me.lblNombre.TabIndex = 26
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(17, 61)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(282, 44)
        Me.txtNombre.TabIndex = 25
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(869, 489)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(33, 26)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "ID"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_eliminar.Location = New System.Drawing.Point(414, 460)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(146, 55)
        Me.btn_eliminar.TabIndex = 23
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'dgv_especialidades
        '
        Me.dgv_especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_especialidades.Location = New System.Drawing.Point(18, 271)
        Me.dgv_especialidades.Name = "dgv_especialidades"
        Me.dgv_especialidades.RowHeadersWidth = 62
        Me.dgv_especialidades.RowTemplate.Height = 28
        Me.dgv_especialidades.Size = New System.Drawing.Size(860, 162)
        Me.dgv_especialidades.TabIndex = 21
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 126)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(123, 26)
        Me.lblDescripcion.TabIndex = 20
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(17, 155)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(866, 96)
        Me.txtDescripcion.TabIndex = 18
        '
        'btn_regresar
        '
        Me.btn_regresar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_regresar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(732, 32)
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
        'frmTratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(966, 556)
        Me.Controls.Add(Me.gbxTratamientos)
        Me.Name = "frmTratamiento"
        Me.Text = "frmTratamiento"
        Me.gbxTratamientos.ResumeLayout(False)
        Me.gbxTratamientos.PerformLayout()
        CType(Me.dgv_especialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxTratamientos As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents dgv_especialidades As DataGridView
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btn_regresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents lblCosto As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents ttGuardar As ToolTip
    Friend WithEvents ttLimpiar As ToolTip
    Friend WithEvents ttEliminar As ToolTip
    Friend WithEvents ttRegresar As ToolTip
End Class
