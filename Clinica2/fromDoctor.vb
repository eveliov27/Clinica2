Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class fromDoctor
    Dim conexion As New Conexion()


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim correo As String = Form1.correoUsuarioActual
        If Not (correo.EndsWith("@doctor") Or correo.EndsWith("@admin")) Then
            MessageBox.Show("No tienes rights para agregar doctores, contacte a un administrador o un doctor.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' PRIMERO obtenemos el ID del usuario basado en el correo
        Dim getUserIdQuery As New MySqlCommand("SELECT id FROM usuarios WHERE correo = @correo", conexionBD)
        getUserIdQuery.Parameters.AddWithValue("@correo", Form1.correoUsuarioActual)
        Dim usuarios_id As Integer = -1

        ' Aquí deberías obtener el ID del usuario de alguna manera, por ejemplo, desde un formulario anterior
        Try
            Dim reader As MySqlDataReader = getUserIdQuery.ExecuteReader()
            If reader.Read() Then
                usuarios_id += 0
                usuarios_id = Convert.ToInt32(reader("id"))
            Else
                MessageBox.Show("No se pudo obtener el ID del usuario.")
                reader.Close()
                conexion.Cerrar()
                Exit Sub
            End If
            reader.Close()

            ' INSERTAMOS en doctor usando el ID obtenido
            Dim insertQuery As New MySqlCommand("
            INSERT INTO doctor
            (identificacion, nombre_completo, apellidos, direccion, telefono, correo, edad, sexo, usuarios_id, especialidad_id) 
            VALUES 
            (@identificacion, @nombre, @apellidos, @direccion, @telefono, @correo, @edad, @sexo, @usuarios_id,@especialidad_id)
        ", conexionBD)


            insertQuery.Parameters.AddWithValue("@identificacion", txtIdentificacion.Text)
            insertQuery.Parameters.AddWithValue("@nombre", txtNombre.Text)
            insertQuery.Parameters.AddWithValue("@apellidos", txtApellidos.Text)
            insertQuery.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            insertQuery.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            insertQuery.Parameters.AddWithValue("@correo", Form1.correoUsuarioActual) ' Usamos el correo del usuario actual
            insertQuery.Parameters.AddWithValue("@edad", txtEdad.Text)
            insertQuery.Parameters.AddWithValue("@sexo", cboSexo.SelectedItem.ToString())
            insertQuery.Parameters.AddWithValue("@usuarios_id", usuarios_id)
            insertQuery.Parameters.AddWithValue("especialidad_id", cboEspecialidad.SelectedValue)


            insertQuery.ExecuteNonQuery()
            'Mostrar el ID de usuario asignado al doctor
            MessageBox.Show("Doctor registrado exitosamente con ID de usuario: " & usuarios_id.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)


            MessageBox.Show("Doctor registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al registrar doctor: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtApellidos.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        cboSexo.SelectedValue = -1
        txtEdad.Text = ""
        txtIdentificacion.Focus()
        cboEspecialidad.SelectedIndex = -1 ' Limpiar la selección del ComboBox de especialidades

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmDashboard.Show()
        Me.Close()

    End Sub
    Sub cargarVistaDoc()
        Try
            'ANTES DE REALIZAR EL INSERT  HACE UN SELECT, SE TRAEN EL ULTIMO ID Y LE SUMAN 1
            Dim conn = conexion.Abrir()
            Dim query As String = "SELECT * FROM vista_doctores_especialidades"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            ' Asignar el DataTable a un DataGridView o similar para mostrar los datos
            dgv_doctor_view.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la vista: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgv_doctor_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_doctor_view.CellContentClick
        ' Aquí puedes manejar el evento de clic en la celda si es necesario
        ' Por ejemplo, si quieres mostrar un mensaje con el ID de la especialidad seleccionada:
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_doctor_view.Rows(e.RowIndex)
            Dim nombre As String = row.Cells("NOMBRE").Value.ToString() ' Asegúrate de que "id" es el nombre correcto de la columna
            Dim apellido As String = row.Cells("APELLIDOS").Value.ToString() ' Asegúrate de que es el nombre correcto de la columna
            Dim correo As String = row.Cells("CORREO").Value.ToString() '
            Dim especialidad As String = row.Cells("ESPECIALIDAD").Value.ToString() '
            txtNombre.Text = nombre ' Mostrar la descripción en el TextBox
            txtApellidos.Text = apellido ' Mostrar la descripción en el TextBox
            'lblId.Text = especialidadId.ToString() ' Mostrar el ID en la etiqueta lbl_id
            'MessageBox.Show("ID de la especialidad seleccionada: " & especialidadId.ToString(), "Especialidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub fromDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboEspecialidad()
        cargarVistaDoc()
    End Sub

    Private Sub LlenarComboEspecialidad()
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim query As String = "SELECT id, descripcion FROM especialidad"
        Try
            Dim cmd As New MySqlCommand(query, conexionBD)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            cboEspecialidad.DataSource = dt
            cboEspecialidad.DisplayMember = "descripcion"   ' Column to show
            cboEspecialidad.ValueMember = "id"         ' Value to use internally
            cboEspecialidad.SelectedIndex = -1         ' No selection by default
        Catch ex As Exception
            MessageBox.Show("Error al cargar especialidades: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try
    End Sub

    Private Sub cboEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEspecialidad.SelectedIndexChanged

    End Sub
End Class