Imports MySql.Data.MySqlClient

Public Class frmTratamiento
    'Form donde se crean los tratamientos, tiene restriccion de usuarion para limitar el uso de doctores y administrativos unicamente
    Dim conexion As New Conexion()
    'Vuelve al dashboard 
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        frmDashboard.Show()
        Me.Close()
    End Sub
    'Guarda el tratamiento el la base de datos y refresca la vista a tiempo real
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim descripcion As String = txtDescripcion.Text.Trim()
        Dim nombre As String = txtNombre.Text.Trim()
        Dim costo As String = txtCosto.Text.Trim()
        If String.IsNullOrEmpty(descripcion) Then
            MessageBox.Show("Por favor, ingrese una especialidad.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del sub si los campos están vacíos
        End If

        Try
            Dim conn = conexion.Abrir()
            Dim insertQuery As String = "INSERT INTO tratamiento (descripcion, nombre_tratamiento, costo) VALUES (@descripcion, @nombre_tratamiento, @costo)"
            Using command As New MySqlCommand(insertQuery, conn)
                ' Añadir parámetros para evitar inyección SQL
                command.Parameters.AddWithValue("@descripcion", descripcion)
                command.Parameters.AddWithValue("@nombre_tratamiento", nombre)
                command.Parameters.AddWithValue("@costo", costo)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Especialidad '" & descripcion & "' registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Opcional: Limpiar los campos después de un registro exitoso
                    txtNombre.Clear()
                    txtCosto.Clear()
                    txtDescripcion.Clear()
                    txtNombre.Focus() ' Poner el foco en el campo de usuario
                    cargarTratamiento() ' Llamar al método para recargar las especialidades
                Else
                    MessageBox.Show("No se pudo registrar la especialidad. Inténtelo de nuevo.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error de base de datos al registrar especialidad: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MANDAR A LLAMAR AL METODO QUE CARGA LOS DATOS
        cargarTratamiento()
    End Sub

    Sub cargarTratamiento()
        Try
            'ANTES DE REALIZAR EL INSERT  HACE Un SELECT, SE TRAEN EL ULTIMO ID Y LE SUMAN 1
            Dim conn = conexion.Abrir()
            Dim query As String = "SELECT * FROM tratamiento"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            ' Asignar el DataTable a un DataGridView o similar para mostrar los datos
            dgv_especialidades.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar los tratamientos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgv_especialidades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_especialidades.CellContentClick
        ' Aquí puedes manejar el evento de clic en la celda si es necesario
        ' Por ejemplo, si quieres mostrar un mensaje con el ID de la especialidad seleccionada:
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_especialidades.Rows(e.RowIndex)
            Dim especialidadId As Integer = Convert.ToInt32(row.Cells("id").Value) ' Asegúrate de que "id" es el nombre correcto de la columna
            Dim descripcion As String = row.Cells("descripcion").Value.ToString() ' Asegúrate de que "descripcion" es nombre correcto de la columna
            txtDescripcion.Text = descripcion ' Mostrar la descripción en el TextBox
            lblId.Text = especialidadId.ToString() ' Mostrar el ID en la etiqueta lbl_id
            'MessageBox.Show("ID de la especialidad seleccionada: " & especialidadId.ToString(), "Especialidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim id_especialidad As Integer

        If Integer.TryParse(lblId.Text, id_especialidad) Then
            Try
                Dim conn = conexion.Abrir()
                Dim deleteQuery As String = "DELETE FROM tratamiento WHERE id = @id"
                Using command As New MySqlCommand(deleteQuery, conn)
                    command.Parameters.AddWithValue("@id", id_especialidad)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Tratamiento eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cargarTratamiento() ' Recargar las especialidades después de eliminar
                    Else
                        MessageBox.Show("No se pudo eliminar el tratamiento. Inténtelo de nuevo.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el tratamiento: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor, seleccione un tratamiento para eliminar.", "Selección Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub frmTratamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtCosto.Clear()
        txtDescripcion.Clear()
        txtNombre.Focus() ' Poner +el foco en el campo de usuario
        cargarTratamiento()
    End Sub

    'Tooltip para guardar un tratamiento
    Private Sub btn_guardar_MouseHover(sender As Object, e As EventArgs) Handles btn_guardar.MouseHover
        ttGuardar.SetToolTip(btn_guardar, "Click para registrar un tratamiento")
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