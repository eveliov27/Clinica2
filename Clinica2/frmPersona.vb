Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class frmPersona
    Dim conexion As New Conexion()


    'La clase persona es la principal clase, aqui se meten los datos de los pacientes y doctores 
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim conexionBD As MySqlConnection = conexion.Abrir()

        Try
            Dim usuarios_id As Integer = Convert.ToInt32(cboUser.SelectedValue) 'Con base el el id de usuarios, vamos a cargar el correo relacionado con la persona
            Dim correo As String = cboUser.Text

            ' Validación de permisos
            If Not (correo.EndsWith("@paciente") Or correo.EndsWith("@admin") Or correo.EndsWith("@doctor")) Then
                MessageBox.Show("No tienes derechos para agregar personas. Contacte a un administrador.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Insertar Persona
            Dim insertPersonaQuery As New MySqlCommand("
            INSERT INTO persona
            (identificacion, nombre_completo, apellidos, direccion, telefono, correo, edad, sexo, fecha_nacimiento, tipo_sangre, contacto_emer, usuarios_id) 
            VALUES 
            (@identificacion, @nombre, @apellidos, @direccion, @telefono, @correo, @edad, @sexo, @fecha_nacimiento, @tipo_sangre, @contacto_emer, @usuarios_id);
        ", conexionBD)

            insertPersonaQuery.Parameters.AddWithValue("@identificacion", txtIdentificacion.Text)
            insertPersonaQuery.Parameters.AddWithValue("@nombre", txtNombre.Text)
            insertPersonaQuery.Parameters.AddWithValue("@apellidos", txtApellidos.Text)
            insertPersonaQuery.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            insertPersonaQuery.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            insertPersonaQuery.Parameters.AddWithValue("@correo", correo)
            insertPersonaQuery.Parameters.AddWithValue("@edad", txtEdad.Text)
            insertPersonaQuery.Parameters.AddWithValue("@sexo", cboSexo.SelectedItem.ToString())
            insertPersonaQuery.Parameters.AddWithValue("@fecha_nacimiento", dtpFechaNac.Value)
            insertPersonaQuery.Parameters.AddWithValue("@tipo_sangre", cboTipo_Sangre.SelectedItem.ToString())
            insertPersonaQuery.Parameters.AddWithValue("@contacto_emer", txtConacto.Text)
            insertPersonaQuery.Parameters.AddWithValue("@usuarios_id", usuarios_id)

            insertPersonaQuery.ExecuteNonQuery()
            MessageBox.Show("Persona registrada exitosamente con ID de usuario: " & usuarios_id.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cargarVistaPersona() 'Refrescar la informacion en el data view
        Catch ex As Exception
            MessageBox.Show("Error al registrar persona: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try
    End Sub

    'Limpiar los datos del form
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtApellidos.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEdad.Text = ""
        txtConacto.Text = ""
        txtIdentificacion.Focus()


        'Limpiar los combo boxes
        cboSexo.SelectedIndex = -1
        cboTipo_Sangre.SelectedIndex = -1
        cboUser.SelectedIndex = -1

        dtpFechaNac.Value = DateTime.Now ' Limpiar la fecha de nacimiento, con la fecha actual

    End Sub
    'Regresa al dashboard
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmDashboard.Show()
        Me.Close()
    End Sub
    'Cargamos la vista de persona, en donde se relaciona la informacion del usuario y la persona
    Sub cargarVistaPersona()
        Try
            'ANTES DE REALIZAR EL INSERT  HACE UN SELECT, SE TRAEN EL ULTIMO ID Y LE SUMAN 1
            Dim conn = conexion.Abrir()
            Dim query As String = "SELECT * FROM vista_personas"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            ' Asignar el DataTable a un DataGridView o similar para mostrar los datos
            dgv_persona_view.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la vista: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgv_persona_view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_persona_view.CellContentClick
        ' Aquí puedes manejar el evento de clic en la celda si es necesario
        ' Por ejemplo, si quieres mostrar un mensaje con el ID de la especialidad seleccionada:
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_persona_view.Rows(e.RowIndex)
            Dim nombre As String = row.Cells("NOMBRE").Value.ToString() ' Asegúrate de que "id" es el nombre correcto de la columna
            Dim apellido As String = row.Cells("APELLIDOS").Value.ToString() ' Asegúrate de que es el nombre correcto de la columna
            Dim correo As String = row.Cells("CORREO").Value.ToString() '
            Dim telefono As String = row.Cells("TELEFONO").Value.ToString()
            Dim tipo_sangre As String = row.Cells("TIPO DE SANGRE").Value.ToString() '
            txtNombre.Text = nombre ' Mostrar la descripción en el TextBox
            txtApellidos.Text = apellido ' Mostrar la descripción en el TextBox
            'lblId.Text = especialidadId.ToString() ' Mostrar el ID en la etiqueta lbl_id
            'MessageBox.Show("ID de la especialidad seleccionada: " & especialidadId.ToString(), "Especialidad Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'Se carga la vista de persona al momento de leer el form Persona, y se llena el combo box de usuarios
    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarVistaPersona()
        ' Cargar la vista de pacientes al iniciar el formulario
        llenarComboUser()
        ' Llenar el combo de usuarios al cargar el formulario
    End Sub

    Private Sub llenarComboUser()
        'Llenamos el combo de Usuario con los datos de la base de datos
        Dim conexionBD As MySqlConnection = conexion.Abrir()
        Dim query As String = "SELECT id, correo FROM usuarios"
        Try
            Dim cmd As New MySqlCommand(query, conexionBD)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            cboUser.DataSource = dt
            cboUser.DisplayMember = "correo"   ' Columna a mostrar
            cboUser.ValueMember = "id"         ' Valor para usar internamente
            cboUser.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar especialidades: " & ex.Message)
        Finally
            conexion.Cerrar()
        End Try
    End Sub
    'Tooltip para ingresar una persona
    Private Sub btnRegistrar_MouseHover(sender As Object, e As EventArgs) Handles btnRegistrar.MouseHover
        ttRegistar.SetToolTip(btnRegistrar, "Click para registrar una persona")
        ttRegistar.ToolTipTitle = "Informacion"
        ttRegistar.ToolTipIcon = ToolTipIcon.Info
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