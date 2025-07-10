<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEspecialidades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbxPersonas = New System.Windows.Forms.GroupBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dgv_especialidades = New System.Windows.Forms.DataGridView()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.gbxPersonas.SuspendLayout()
        CType(Me.dgv_especialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxPersonas
        '
        Me.gbxPersonas.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.gbxPersonas.Controls.Add(Me.lblId)
        Me.gbxPersonas.Controls.Add(Me.btn_eliminar)
        Me.gbxPersonas.Controls.Add(Me.btnEditar)
        Me.gbxPersonas.Controls.Add(Me.dgv_especialidades)
        Me.gbxPersonas.Controls.Add(Me.lblEspecialidad)
        Me.gbxPersonas.Controls.Add(Me.txtEspecialidad)
        Me.gbxPersonas.Controls.Add(Me.btn_regresar)
        Me.gbxPersonas.Controls.Add(Me.btnLimpiar)
        Me.gbxPersonas.Controls.Add(Me.btn_guardar)
        Me.gbxPersonas.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPersonas.Location = New System.Drawing.Point(8, 8)
        Me.gbxPersonas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxPersonas.Name = "gbxPersonas"
        Me.gbxPersonas.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxPersonas.Size = New System.Drawing.Size(616, 347)
        Me.gbxPersonas.TabIndex = 3
        Me.gbxPersonas.TabStop = False
        Me.gbxPersonas.Text = "Agregar Especialidad"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(416, 146)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 18)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "ID"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_eliminar.Location = New System.Drawing.Point(341, 299)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(97, 36)
        Me.btn_eliminar.TabIndex = 23
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnEditar.Location = New System.Drawing.Point(233, 299)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(97, 36)
        Me.btnEditar.TabIndex = 22
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'dgv_especialidades
        '
        Me.dgv_especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_especialidades.Location = New System.Drawing.Point(12, 146)
        Me.dgv_especialidades.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_especialidades.Name = "dgv_especialidades"
        Me.dgv_especialidades.RowHeadersWidth = 62
        Me.dgv_especialidades.RowTemplate.Height = 28
        Me.dgv_especialidades.Size = New System.Drawing.Size(361, 135)
        Me.dgv_especialidades.TabIndex = 21
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Location = New System.Drawing.Point(9, 49)
        Me.lblEspecialidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(91, 18)
        Me.lblEspecialidad.TabIndex = 20
        Me.lblEspecialidad.Text = "Especialidad"
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Location = New System.Drawing.Point(12, 81)
        Me.txtEspecialidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEspecialidad.Multiline = True
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(361, 51)
        Me.txtEspecialidad.TabIndex = 18
        '
        'btn_regresar
        '
        Me.btn_regresar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_regresar.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(488, 21)
        Me.btn_regresar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(97, 36)
        Me.btn_regresar.TabIndex = 6
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Beige
        Me.btnLimpiar.Location = New System.Drawing.Point(121, 299)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(97, 36)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_guardar.Location = New System.Drawing.Point(12, 299)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(97, 36)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'frmEspecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 365)
        Me.Controls.Add(Me.gbxPersonas)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEspecialidades"
        Me.Text = "frmEspecialidades"
        Me.gbxPersonas.ResumeLayout(False)
        Me.gbxPersonas.PerformLayout()
        CType(Me.dgv_especialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxPersonas As GroupBox
    Friend WithEvents lblId As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents dgv_especialidades As DataGridView
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents btn_regresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btn_guardar As Button
End Class
