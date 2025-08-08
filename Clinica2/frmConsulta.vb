Imports MySql.Data.MySqlClient

Public Class frmConsulta
    'Form donde se guarda la consulta, relaciona un doctor, un paciente y un tratamiento y los guarda en la base de datos
    Dim conexion As New Conexion()
    'Llena el combo de doctor, unicamente con el dominio de @doctor
    Private Sub LlenarComboDoctor()
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim query As String = "SELECT id, correo FROM usuarios"
        Try
            Dim cmd As New MySqlCommand(query, conexionBD)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)

            ' Filter rows to only those with "@doctor" in the correo
            Dim filteredRows = dt.AsEnumerable().Where(Function(row) row.Field(Of String)("correo").Contains("@doctor"))
            Dim filteredTable As DataTable = dt.Clone() ' Clone to get the schema
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
    'Llena el combo de paciente, unicamente con el dominio de @paciente
    Private Sub LlenarComboPersona()
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim query As String = "SELECT id, correo FROM usuarios"
        Try
            Dim cmd As New MySqlCommand(query, conexionBD)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)

            'Filtra las columnas que contienten "@paciente" en el correo
            Dim filteredRows = dt.AsEnumerable().Where(Function(row) row.Field(Of String)("correo").Contains("@paciente"))
            Dim filteredTable As DataTable = dt.Clone() ' Clone to get the schema
            For Each row In filteredRows
                filteredTable.ImportRow(row)
            Next

            cboPaciente.DataSource = filteredTable
            cboPaciente.DisplayMember = "correo"
            cboPaciente.ValueMember = "correo"
            cboPaciente.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar doctores: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try
    End Sub
    'Llena el combo de especialidad
    Private Sub LlenarComboEspecialidad()
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim query As String = "SELECT id, nombre_tratamiento FROM tratamiento"
        Try
            Dim cmd As New MySqlCommand(query, conexionBD)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            cboTratamiento.DataSource = dt
            cboTratamiento.DisplayMember = "nombre_tratamiento"   ' Column to show
            cboTratamiento.ValueMember = "id"         ' Value to use internally
            cboTratamiento.SelectedIndex = -1         ' No selection by default
        Catch ex As Exception
            MessageBox.Show("Error al cargar tratamiento: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try
    End Sub
    'Llama a los metodos de llenado de combos y vista cuando se carga el form
    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboDoctor()
        LlenarComboEspecialidad()
        LlenarComboPersona()
        cargarVistaConsultas()
    End Sub
    'Limpia los datos ingresados
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtHora.Text = ""
        txtObservaciones.Text = ""
        dtpFecha.Value = DateTime.Now ' Limpiar la fecha 
        cboPaciente.SelectedValue = -1 ' Limpiar la selección del ComboBox de paciente
        cboDoctor.SelectedValue = -1 ' Limpiar la selección del ComboBox de doctor
        cboTratamiento.SelectedIndex = -1 ' Limpiar la selección del ComboBox de tratamiento

    End Sub
    'Vuelve al menu principal
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        frmDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexionBD As MySqlConnection = conexion.Abrir()

        Try
            ' Valida el id de doctor y lo guarda en doctor_id
            If cboDoctor.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, seleccione un doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim doctorEmail As String = cboDoctor.SelectedValue.ToString()
            Dim doctorId As Integer = -1
            Dim getDoctorIdQuery As String = "SELECT id FROM persona WHERE correo = @correo"
            Using cmd As New MySqlCommand(getDoctorIdQuery, conexionBD)
                cmd.Parameters.AddWithValue("@correo", doctorEmail)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    doctorId = Convert.ToInt32(reader("id"))
                Else
                    MessageBox.Show("No se pudo encontrar el ID del doctor seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    reader.Close()
                    Exit Sub
                End If
                reader.Close()
            End Using

            ' Valida el id de persona y lo guarda en persona_id
            If cboPaciente.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, seleccione un paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim pacienteEmail As String = cboPaciente.SelectedValue.ToString()
            Dim personaId As Integer = -1
            Dim getPersonaIdQuery As String = "SELECT id FROM persona WHERE correo = @correo"
            Using cmd As New MySqlCommand(getPersonaIdQuery, conexionBD)
                cmd.Parameters.AddWithValue("@correo", pacienteEmail)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    personaId = Convert.ToInt32(reader("id"))
                Else
                    MessageBox.Show("No se pudo encontrar el ID del paciente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    reader.Close()
                    Exit Sub
                End If
                reader.Close()
            End Using

            ' Valida el id de tratamiento y lo guarda en tratamientoId
            If cboTratamiento.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, seleccione un tratamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim tratamientoId As Integer = Convert.ToInt32(cboTratamiento.SelectedValue)

            ' Valida hora
            Dim hora As String = txtHora.Text.Trim()
            If String.IsNullOrEmpty(hora) Then
                MessageBox.Show("Por favor, ingrese la hora de la cita médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Valida observaciones
            Dim observaciones As String = txtObservaciones.Text.Trim()
            If String.IsNullOrEmpty(observaciones) Then
                MessageBox.Show("Por favor, ingrese las especificaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Guarda toda la informacion en la base de datos
            Dim insertConsultaQuery As String = "INSERT INTO consulta (hora, fecha, observaciones, persona_id_2, doctor_id, tratamiento_id) VALUES (@hora, @fecha, @observaciones, @persona_id_2, @doctor_id, @tratamiento_id)"
            Using cmd As New MySqlCommand(insertConsultaQuery, conexionBD)
                cmd.Parameters.AddWithValue("@hora", hora)
                cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value)
                cmd.Parameters.AddWithValue("@observaciones", observaciones)
                cmd.Parameters.AddWithValue("@persona_id_2", personaId)
                cmd.Parameters.AddWithValue("@doctor_id", doctorId)
                cmd.Parameters.AddWithValue("@tratamiento_id", tratamientoId)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Consulta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al registrar la consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Cerrar()
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim id_consulta As Integer

        If Integer.TryParse(lblId.Text, id_consulta) Then
            Try
                Dim conn = conexion.Abrir()
                Dim deleteQuery As String = "DELETE FROM consulta WHERE id = @id"
                Using command As New MySqlCommand(deleteQuery, conn)
                    command.Parameters.AddWithValue("@id", id_consulta)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Consulta eliminada exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("No se pudo eliminar la consulta. Inténtelo de nuevo.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la consulta: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor, seleccione una consulta para eliminar.", "Selección Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Carga la vista de consultas desde el view en mysql
    Sub cargarVistaConsultas()
        Try
            'ANTES DE REALIZAR EL INSERT  HACE Un SELECT, SE TRAEN EL ULTIMO ID Y LE SUMAN 1
            Dim conn = conexion.Abrir()
            Dim query As String = "SELECT * FROM vista_consulta"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            ' Asignar el DataTable a un DataGridView o similar para mostrar los datos
            dgv_consultas.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar las consultas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Tooltip para guardar una consulta
    Private Sub btn_guardar_MouseHover(sender As Object, e As EventArgs) Handles btn_guardar.MouseHover
        ttGuardar.SetToolTip(btn_guardar, "Click para registrar una consulta")
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