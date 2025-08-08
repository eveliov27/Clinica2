Public Class frmDashboard

    'Abre el form de doctores y esconde el dashboard
    'Verifica que unicamente puedan accesar doctores o administradores
    Private Sub btnDoctores_Click(sender As Object, e As EventArgs) Handles btnDoctores.Click
        If Not ((Form1.correoUsuarioActual.EndsWith("@doctor")) Or (Form1.correoUsuarioActual.EndsWith("@admin"))) Then
            MessageBox.Show("Acceso restringido, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        fromDoctor.Show()
        Me.Hide()
    End Sub
    'Abre el form de personas y esconde el dashboard
    'Verifica que unicamente puedan accesar pacientes, para agregar datos personales, o administradores (agregan las personas-doctores)
    Private Sub btn_Personas_Click(sender As Object, e As EventArgs) Handles btn_Personas.Click
        If Not ((Form1.correoUsuarioActual.EndsWith("@personas")) Or (Form1.correoUsuarioActual.EndsWith("@admin"))) Then
            MessageBox.Show("No debes agregar pacientes desde una cuenta doctor, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmPersona.Show()
        Me.Hide()
    End Sub
    'Abre el form de consultas y esconde el dashboard
    'Verifica que unicamente puedan accesar doctores, o administradores
    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        If Not ((Form1.correoUsuarioActual.EndsWith("@doctor")) Or (Form1.correoUsuarioActual.EndsWith("@admin"))) Then
            MessageBox.Show("No tienes rights para accesar esta funcionalidad, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmConsulta.Show()
        Me.Hide()
    End Sub
    'Abre el form de usuarios y esconde el dashboard
    'Verifica que unicamente puedan accesar administradores a crear cuentas desde adentro de la app
    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        'Verifica que el correo actual sea unicamente admin
        If Not (Form1.correoUsuarioActual.EndsWith("@admin")) Then
            MessageBox.Show("No tienes rights para agregar usuarios manualmente, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmUsuarios.Show()
        Me.Hide()

    End Sub
    'Abre el form de tratamientos y esconde el dashboard
    'Verifica que unicamente puedan accesar doctores o administradores a crear tratamientos
    Private Sub btnTratamientos_Click(sender As Object, e As EventArgs) Handles btnTratamientos.Click
        If Not ((Form1.correoUsuarioActual.EndsWith("@doctor")) Or (Form1.correoUsuarioActual.EndsWith("@admin"))) Then
            MessageBox.Show("Acceso restringido, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmTratamiento.Show()
        Me.Hide()
    End Sub
    'Cierra completamente la app ya que este es nuestro form principal
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Seguro que desea salir? ", "Salir de la App",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub
    'Abre el form de especialidades y esconde el dashboard
    'Verifica que unicamente puedan accesar doctores o administradores a crear especialidades
    Private Sub btnEspecialidades_Click(sender As Object, e As EventArgs) Handles btnEspecialidades.Click
        If Not ((Form1.correoUsuarioActual.EndsWith("@doctor")) Or (Form1.correoUsuarioActual.EndsWith("@admin"))) Then
            MessageBox.Show("No debes agregar pacientes desde una cuenta doctor, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmEspecialidades.Show()
        Me.Hide()
    End Sub


    'Tool tip para salir al menu principal
    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ttSalir.SetToolTip(btnSalir, "Volver al menu principal")
        ttSalir.ToolTipTitle = "Informacion"
        ttSalir.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tool tip para agregar doctores
    Private Sub btnDoctores_MouseHover(sender As Object, e As EventArgs) Handles btnDoctores.MouseHover
        ttDoctores.SetToolTip(btnDoctores, "Click para registrar un doctor/Acceso restringido")
        ttDoctores.ToolTipTitle = "Informacion"
        ttDoctores.ToolTipIcon = ToolTipIcon.Warning
    End Sub
    'Tool tip para agregar personas
    Private Sub btn_Personas_MouseHover(sender As Object, e As EventArgs) Handles btn_Personas.MouseHover
        ttPersonas.SetToolTip(btn_Personas, "Click para registrar un paciente/Acceso restringido")
        ttPersonas.ToolTipTitle = "Informacion"
        ttPersonas.ToolTipIcon = ToolTipIcon.Warning
    End Sub
    'Tool tip para registrar una consulta
    Private Sub btnConsultas_MouseHover(sender As Object, e As EventArgs) Handles btnConsultas.MouseHover
        ttConsultas.SetToolTip(btnConsultas, "Click para registrar una consulta/Acceso restringido")
        ttConsultas.ToolTipTitle = "Informacion"
        ttConsultas.ToolTipIcon = ToolTipIcon.Warning
    End Sub
    'Tool tip para registrar un usuario
    Private Sub btnUsuarios_MouseHover(sender As Object, e As EventArgs) Handles btnUsuarios.MouseHover
        ttUsuarios.SetToolTip(btnUsuarios, "Click para registrar un usuario/Acceso restringido")
        ttUsuarios.ToolTipTitle = "Informacion"
        ttUsuarios.ToolTipIcon = ToolTipIcon.Warning
    End Sub
    'Tool tip para registrar un tratamiento
    Private Sub btnTratamientos_MouseHover(sender As Object, e As EventArgs) Handles btnTratamientos.MouseHover
        ttTratameintos.SetToolTip(btnTratamientos, "Click para registrar un tratamiento/Acceso restringido")
        ttTratameintos.ToolTipTitle = "Informacion"
        ttTratameintos.ToolTipIcon = ToolTipIcon.Warning
    End Sub
    'Tool tip para registrar especialidades
    Private Sub btnEspecialidades_MouseHover(sender As Object, e As EventArgs) Handles btnEspecialidades.MouseHover
        ttEspecialidades.SetToolTip(btnEspecialidades, "Click para registrar una especialidad/Acceso restringido")
        ttEspecialidades.ToolTipTitle = "Informacion"
        ttEspecialidades.ToolTipIcon = ToolTipIcon.Warning
    End Sub
End Class