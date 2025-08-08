Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class fromDoctor
    Dim conexion As New Conexion()
    'Este form crea desde una instancia de persona, un doctor. La informacion de la persona se muestra cuando se selecciona el correo del doctor

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim conexionBD As MySqlConnection = conexion.Abrir()

        Try
            ' Tomamos el correo seleccionado del combo box 
            Dim selectedEmail As String = cboDoctor.SelectedValue.ToString()

            ' Busca el id de persona, para hacer match con persona_id desde la bd, por medio del correo
            Dim getPersonaIdQuery As String = "SELECT id FROM persona WHERE correo = @correo"
            Dim personaId As Integer = -1

            Using cmd As New MySqlCommand(getPersonaIdQuery, conexionBD)
                cmd.Parameters.AddWithValue("@correo", selectedEmail)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    personaId = Convert.ToInt32(reader("id"))
                Else
                    MessageBox.Show("No se pudo encontrar el ID de la persona asociada al correo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    reader.Close()
                    Exit Sub
                End If
                reader.Close()
            End Using


            'Obtenemos la descripcion de la especialidad desde el combo box
            If cboEspecialidad.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, seleccione una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim especialidadDescripcion As String = cboEspecialidad.Text

            'Buscamos la id de especialidad y se guarda en especialidad_id 
            Dim especialidadId As Integer = -1
            Dim getEspecialidadIdQuery As String = "SELECT id FROM especialidad WHERE descripcion = @descripcion"

            Using cmd As New MySqlCommand(getEspecialidadIdQuery, conexionBD)
                cmd.Parameters.AddWithValue("@descripcion", especialidadDescripcion)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    especialidadId = Convert.ToInt32(reader("id"))
                Else
                    MessageBox.Show("No se pudo encontrar el ID de la especialidad seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    reader.Close()
                    Exit Sub
                End If
                reader.Close()
            End Using

            'Obtenemos licencia_medica desde el text box
            Dim licenciaMedica As String = txtlicencia.Text.Trim()
            If String.IsNullOrEmpty(licenciaMedica) Then
                MessageBox.Show("Por favor, ingrese la licencia médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Insertamos persona_id, especialidad_id, y licencia_medica en la tabla doctor
            Dim insertDoctorQuery As String = "INSERT INTO doctor (persona_id, especialidad_id, licencia_medica) VALUES (@persona_id, @especialidad_id, @licencia_medica)"
            Using cmd As New MySqlCommand(insertDoctorQuery, conexionBD)
                cmd.Parameters.AddWithValue("@persona_id", personaId)
                cmd.Parameters.AddWithValue("@especialidad_id", especialidadId)
                cmd.Parameters.AddWithValue("@licencia_medica", licenciaMedica)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Doctor registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al registrar el doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Cerrar()
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ' Limpiar todos los TextBox
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtApellidos.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEdad.Text = ""
        txtlicencia.Text = ""

        ' Limpiar ComboBox 
        cboSexo.SelectedIndex = -1
        cboEspecialidad.SelectedIndex = -1
        cboDoctor.SelectedIndex = -1

        'Ponemos el focus en el primer text
        txtIdentificacion.Focus()
    End Sub
    'Regreso al menu (dashboard) 
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmDashboard.Show()
        Me.Close()

    End Sub
    'Cargamos la vista de doctor desde la base de datos
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
    'Cuando se lee el form Doctor, se cargan los cbos especialidad y doctor, ademas de cargar la vista
    Private Sub fromDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboEspecialidad()
        cargarVistaDoc()
        LlenarComboDoctor()
    End Sub

    'Sub creado para llenar el combo doctor con la informacion
    Private Sub LlenarComboDoctor()
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim query As String = "SELECT id, correo FROM usuarios"
        Try
            Dim cmd As New MySqlCommand(query, conexionBD)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)

            'Filtramos las columnas que contienen "@doctor" 
            Dim filteredRows = dt.AsEnumerable().Where(Function(row) row.Field(Of String)("correo").Contains("@doctor"))
            Dim filteredTable As DataTable = dt.Clone()
            For Each row In filteredRows
                filteredTable.ImportRow(row)
            Next

            cboDoctor.DataSource = filteredTable
            cboDoctor.DisplayMember = "correo"
            cboDoctor.ValueMember = "correo"
            cboDoctor.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar doctores: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try
    End Sub
    'Sub creado para auto generar la informacion de la persona, relacionada con ese correo de doctor
    Private Sub cboDoctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDoctor.SelectedIndexChanged
        If cboDoctor.SelectedIndex = -1 OrElse cboDoctor.SelectedValue Is Nothing Then Exit Sub

        Dim correoSeleccionado As String = cboDoctor.SelectedValue.ToString()
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim query As String = "SELECT identificacion, telefono, edad, sexo, apellidos, nombre_completo, direccion FROM persona WHERE correo = @correo"

        Try
            Dim cmd As New MySqlCommand(query, conexionBD)
            cmd.Parameters.AddWithValue("@correo", correoSeleccionado)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtIdentificacion.Text = reader("identificacion").ToString()
                txtTelefono.Text = reader("telefono").ToString()
                txtEdad.Text = reader("edad").ToString()
                cboSexo.SelectedItem = reader("sexo").ToString()
                txtApellidos.Text = reader("apellidos").ToString()
                txtNombre.Text = reader("nombre_completo").ToString()
                txtDireccion.Text = reader("direccion").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos de la persona: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try
    End Sub
    'Sub creado para llenar el combo especialidad  con la informacion
    Private Sub LlenarComboEspecialidad()
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim query As String = "SELECT id, descripcion FROM especialidad"
        Try
            Dim cmd As New MySqlCommand(query, conexionBD)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            cboEspecialidad.DataSource = dt
            cboEspecialidad.DisplayMember = "descripcion"   'Columna a mostrar
            cboEspecialidad.ValueMember = "id"         ' Valor para usar internamente
            cboEspecialidad.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar especialidades: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try
    End Sub
    'Tooltip para ingresar un doctor
    Private Sub btnRegistrar_MouseHover(sender As Object, e As EventArgs) Handles btnRegistrar.MouseHover
        ttRegistrar.SetToolTip(btnRegistrar, "Click para registrar un doctor")
        ttRegistrar.ToolTipTitle = "Informacion"
        ttRegistrar.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tooltip para limpiar
    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ttLimpiar.SetToolTip(btnLimpiar, "Borrar la informacion")
        ttLimpiar.ToolTipTitle = "Informacion"
        ttLimpiar.ToolTipIcon = ToolTipIcon.Info
    End Sub
    'Tool tip para salir al menu principal
    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ttSalir.SetToolTip(btnSalir, "Volver al menu principal")
        ttSalir.ToolTipTitle = "Informacion"
        ttSalir.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class