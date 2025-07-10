Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEspecialidades_Click(sender As Object, e As EventArgs) Handles btnEspecialidades.Click
        frmEspecialidades.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnDoctores_Click(sender As Object, e As EventArgs) Handles btnDoctores.Click
        If Not ((Form1.correoUsuarioActual.EndsWith("@doctor")) Or (Form1.correoUsuarioActual.EndsWith("@admin"))) Then
            MessageBox.Show("Acceso restringido, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        fromDoctor.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Personas_Click(sender As Object, e As EventArgs) Handles btn_Personas.Click
        If Not ((Form1.correoUsuarioActual.EndsWith("@personas")) Or (Form1.correoUsuarioActual.EndsWith("@admin"))) Then
            MessageBox.Show("No debes agregar pacientes desde una cuenta doctor, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmPersona.Show()
        Me.Hide()
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        ' Replace Form1.tipo_usuarioActual with your actual variable/property for user type
        If Not (Form1.correoUsuarioActual.EndsWith("@admin")) Then
            MessageBox.Show("No tienes rights para agregar usuarios manualmente, contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmUsuarios.Show()
        Me.Hide()
        'frmUsuarios.Show()
        'Me.Hide()
    End Sub
End Class