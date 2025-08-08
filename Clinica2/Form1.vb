Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Imports System.Text


Public Class Form1
    Dim conexion As New Conexion()
    Public Shared correoUsuarioActual As String


    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        Dim conn = conexion.Abrir() 'INSTANCIA (INTANCIAR) UN OBJETO de la clase Conexion para abrir la conexión a la base de datos

        If conn IsNot Nothing Then
            Dim correo As String = txtUser.Text.Trim()
            Dim passoword As String = txtPsswd.Text.Trim()
            If String.IsNullOrEmpty(correo) Or String.IsNullOrEmpty(passoword) Then
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim hashContrasena As String = HashSHA256(passoword) 'SE HASHEA LA CONTRASEÑA PARA COMPARARLA CON LA BASE DE DATOS
            Dim query As String = "SELECT * FROM usuarios WHERE correo = @correo AND password = @password"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@correo", correo)
                cmd.Parameters.AddWithValue("@password", hashContrasena)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then 'si existe // si es verdadero //
                        frmDashboard.Show() ' Mostrar el formulario del dashboard
                        Me.Hide() ' Cerrar el formulario de inicio de sesión
                        ' MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Aquí puedes redirigir al usuario a la siguiente pantalla
                        correoUsuarioActual = correo ' Guardar el correo del usuario actual
                    Else
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
            conexion.Cerrar()
        Else
            MessageBox.Show("No se pudo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function HashSHA256(texto As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        frmCrearCuenta.Show()
        Me.Hide()
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtUser.Text = ""
        txtPsswd.Text = ""
        txtUser.Focus()

    End Sub
    'Opcion de salir completamente de la app 
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Seguro que desea salir? ", "Salir de la App",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            End
        End If
    End Sub
    'Tooltip para ingresar al menu
    Private Sub btn_ingresar_MouseHover(sender As Object, e As EventArgs) Handles btn_ingresar.MouseHover
        ttIngresar.SetToolTip(btn_ingresar, "Ingresar al menu principal")
        ttIngresar.ToolTipTitle = "Informacion"
        ttIngresar.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tooltip para limpiar
    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ttLimpiar.SetToolTip(btnLimpiar, "Borrar la informacion")
        ttLimpiar.ToolTipTitle = "Informacion"
        ttLimpiar.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tool tip para salir
    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ttSalir.SetToolTip(btnSalir, "Salir de la aplicacion")
        ttSalir.ToolTipTitle = "Informacion"
        ttSalir.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tooltip para guardar
    Private Sub btn_crear_MouseHover(sender As Object, e As EventArgs) Handles btn_crear.MouseHover
        ttCrearCuenta.SetToolTip(btn_crear, "Crear una cuenta")
        ttCrearCuenta.ToolTipTitle = "Informacion"
        ttCrearCuenta.ToolTipIcon = ToolTipIcon.Info
    End Sub









End Class