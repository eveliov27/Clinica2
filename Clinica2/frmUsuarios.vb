Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmUsuarios
    Dim conexion As New Conexion()
    'Vuelve al dashboard
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        frmDashboard.Show()
        Me.Close()
    End Sub
    'Guarda los nuevos usuarios creados por el administrador
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
                command.Parameters.AddWithValue("@correo", correo) ' 
                command.Parameters.AddWithValue("@password", HashSHA256(password)) ' Hash de contrasena
                command.Parameters.AddWithValue("@tipo_usuario", tipo_usuario)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then

                    MessageBox.Show("Usuario '" & nombre & "' registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cargarVista()
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
    'Carga la vista desde el momento que se lee el form 
    Private Sub frmEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MANDAR A LLAMAR AL METODO QUE CARGA LOS DATOS
        cargarVista()
    End Sub
    'Sub para cargar la vista desde la base de datos 
    Sub cargarVista()
        Try
            'ANTES DE REALIZAR EL INSERT  HACE Un SELECT, SE TRAEN EL ULTIMO ID Y LE SUMAN 1
            Dim conn = conexion.Abrir()
            Dim query As String = "SELECT * FROM vista_usuarios_info"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            ' Asignar el DataTable a un DataGridView o similar para mostrar los datos
            dgv_Usuarios.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar las especialidades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgv_Usuarioss_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Usuarios.CellContentClick
        ' Aquí puedes manejar el evento de clic en la celda si es necesario
        ' Por ejemplo, si quieres mostrar un mensaje con el ID de la especialidad seleccionada:
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_Usuarios.Rows(e.RowIndex)
            Dim usuarioId As Integer = Convert.ToInt32(row.Cells("id").Value) ' Asegúrate de que "id" es el nombre correcto de la columna
            Dim correo As String = row.Cells("correo").Value.ToString() ' Asegúrate de que "descripcion" es el nombre correcto de la columna
            Dim nombre As String = row.Cells("nombre").Value.ToString()
            Dim tipo_usuario As String = row.Cells("tipo_usuario").Value.ToString()
            txtCorreo.Text = correo ' Mostrar la descripción en el TextBox
            txtNombre.Text = nombre ' Mostrar el nombre en el TextBox
            cbo_Tipo_usuario.Text = tipo_usuario ' Mostrar el tipo de usuario en el ComboBox    
            lblId.Text = usuarioId.ToString() ' Mostrar el ID en la etiqueta lbl_id
            MessageBox.Show("ID del usuario seleccionado: " & correo.ToString(), "Especialidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim id_especialidad As Integer

        If Integer.TryParse(lblId.Text, id_especialidad) Then
            Try
                Dim conn = conexion.Abrir()
                Dim deleteQuery As String = "DELETE FROM usuarios WHERE id = @id"
                Using command As New MySqlCommand(deleteQuery, conn)
                    command.Parameters.AddWithValue("@id", id_especialidad)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cargarVista() ' Recargar las especialidades después de eliminar
                    Else
                        MessageBox.Show("No se pudo eliminar al usuario. Inténtelo de nuevo.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la usuario: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Selección Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    'Hash de contraseñas
    Private Function HashSHA256(texto As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    'Tooltip para guardar un usuario
    Private Sub btn_guardar_MouseHover(sender As Object, e As EventArgs) Handles btn_guardar.MouseHover
        ttGuardar.SetToolTip(btn_guardar, "Click para registrar un usuario")
        ttGuardar.ToolTipTitle = "Informacion"
        ttGuardar.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tooltip para limpiar
    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ttLimpiar.SetToolTip(btnLimpiar, "Borrar la informacion")
        ttLimpiar.ToolTipTitle = "Informacion"
        ttLimpiar.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tool tip para salir al menu principal
    Private Sub btn_regresar_MouseHover(sender As Object, e As EventArgs) Handles btn_regresar.MouseHover
        ttRegresar.SetToolTip(btn_regresar, "Volver al menu principal")
        ttRegresar.ToolTipTitle = "Informacion"
        ttRegresar.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tool tip para eliminar una entrada
    Private Sub btn_eliminar_MouseHover(sender As Object, e As EventArgs) Handles btn_eliminar.MouseHover
        ttEliminar.SetToolTip(btn_regresar, "Eliminar una entrada")
        ttEliminar.ToolTipTitle = "Informacion"
        ttEliminar.ToolTipIcon = ToolTipIcon.Warning
    End Sub
End Class