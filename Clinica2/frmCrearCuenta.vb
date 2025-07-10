Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Imports System.Text

Public Class frmCrearCuenta
    Dim conexion As New Conexion()
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub frmCrearCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Dim nombre As String = txtNombre.Text.Trim() 'Limpiar
        Dim correo As String = txtCorreo.Text.Trim()
        Dim password As String = txtPsswd.Text.Trim()
        Dim tipo_usuario As String = cbo_Tipo_usuario.Text.Trim()

        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(correo) OrElse String.IsNullOrEmpty(tipo_usuario) Then
            MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del sub si los campos están vacíos
        End If

        Try
            Dim conn = conexion.Abrir()
            Dim insertQuery As String = "INSERT INTO usuarios (nombre,correo, password,tipo_usuario) VALUES (@nombre,@correo, @password,@tipo_usuario)"
            Using command As New MySqlCommand(insertQuery, conn)
                ' Añadir parámetros para evitar inyección SQL
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@correo", correo) ' ¡Recordatorio: en una app real, hashea las contraseñas!
                command.Parameters.AddWithValue("@password", HashSHA256(password)) ' ¡Recordatorio: en una app real, hashea las contraseñas!
                command.Parameters.AddWithValue("@tipo_usuario", tipo_usuario) ' ¡Recordatorio: en una app real, hashea las contraseñas!

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Usuario '" & nombre & "' registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Opcional: Limpiar los campos después de un registro exitoso
                    txtNombre.Clear()
                    txtCorreo.Clear()
                    cbo_Tipo_usuario.SelectedIndex = -1 ' Limpiar el combo box
                    txtPsswd.Clear()
                    txtNombre.Focus() ' Poner el foco en el campo de usuario
                Else
                    MessageBox.Show("No se pudo registrar el usuario. Inténtelo de nuevo.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error de base de datos al registrar usuario: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function HashSHA256(texto As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
End Class