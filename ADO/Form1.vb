Imports System.Data.SqlClient
Public Class Form1

    Private Sub AceptarInsertarButton_Click(sender As Object, e As EventArgs) Handles AceptarInsertarButton.Click
        Dim conexion As New SqlConnection(My.Settings.cadena)
        Dim comando As New SqlCommand()
        Dim consulta As String

        'Configuramos la conexión del comando
        comando.Connection = conexion

        'Establecemos la consulta SQL a ejecutar utilizando parámetros
        consulta = "INSERT INTO Clientes(id,nombre,edad) VALUES (@identificador,@nombre,@edad);"
        comando.CommandText = consulta

        'Definimos los tres parámetros de la consulta
        comando.Parameters.Add("@identificador", SqlDbType.Int)
        comando.Parameters.Add("@nombre", SqlDbType.NVarChar)
        comando.Parameters.Add("@edad", SqlDbType.Int)

        'Asignamos a los parámetros los valores que provienen de los cuadros de texto
        comando.Parameters("@identificador").Value = CType(IdTextBox.Text, Integer)
        comando.Parameters("@nombre").Value = NombreTextBox.Text
        comando.Parameters("@edad").Value = EdadTextBox.Text

        'Ejecutamos la consulta
        Try
            conexion.Open()
            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Cliente insertado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not conexion.State = ConnectionState.Closed Then
                conexion.Close()
            End If
        End Try

    End Sub

    Private Sub CargarListBoxButton_Click(sender As Object, e As EventArgs) Handles CargarListBoxButton.Click
        Dim conexion As New SqlConnection(My.Settings.cadena)
        Dim comando As New SqlCommand()
        Dim consulta As String
        Dim lector As SqlDataReader

        'Configuramos la conexión del comando
        comando.Connection = conexion

        'Establecemos la consulta SQL a ejecutar
        consulta = "SELECT * FROM Clientes"
        comando.CommandText = consulta

        'Ejecutamos la consulta
        Try
            conexion.Open()
            lector = comando.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Si no ha habido ningún problema ejecutando la consulta y ha devuelto alguna fila
        'El operador AndAlso hace que lector.HasRows no generé excepción si ha habido algún error
        'al ejecutar la consulta y lector no está instanciado
        If lector IsNot Nothing AndAlso lector.HasRows() Then

            'Vaciamos el ListBox
            ClientesListBox.Items.Clear()

            'Recorremos los resultados de la consulta y vamos añadiendo los 
            Do While lector.Read()
                ClientesListBox.Items.Add(lector.GetString(1))
            Loop

            'Cerramos el lector
            lector.Close()

        End If

        'Cerramos la conexión
        If Not conexion.State = ConnectionState.Closed Then
            conexion.Close()
        End If

    End Sub

    Private Sub CargarComboBoxButton_Click(sender As Object, e As EventArgs) Handles CargarComboBoxButton.Click

        'Creamos y configuramos los diferentes objetos necesarios para el modo desconectado
        Dim conexion As New SqlConnection(My.Settings.cadena)
        Dim adaptador As New SqlDataAdapter("SELECT * FROM Clientes", conexion)
        Dim generador As New SqlCommandBuilder(adaptador)
        Dim conjunto As New DataSet

        'Llenamos el DataSet usando el adaptador
        adaptador.Fill(conjunto, "Clientes")

        'Configuramos el binding del ComboBox
        NombreComboBox.DisplayMember = "nombre"
        NombreComboBox.ValueMember = "id"
        NombreComboBox.DataSource = conjunto.Tables("Clientes")
    End Sub


    Private Sub NombreComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreComboBox.SelectedIndexChanged
        'Cuando cambiamos la selección del combobox actualizamos el identificador accediendo a la propiedad SelectedValue
        'Funciona porque previamente hemos configurado la propiedad ValueMember del ComboBox
        IdComboBoxTextBox.Text = NombreComboBox.SelectedValue.ToString()
    End Sub


    Private Sub CargarDataGridViewButton_Click(sender As Object, e As EventArgs) Handles CargarDataGridViewButton.Click

        'Creamos y configuramos los objetos necesarios para utilizar el modo desconectado
        Dim conexion As New SqlConnection(My.Settings.cadena)
        Dim adaptador As New SqlDataAdapter("SELECT * FROM Clientes", conexion)
        Dim generador As New SqlCommandBuilder(adaptador)
        Dim conjunto As New DataSet

        'Rellenamos el DataSet con los datos de la base de datos
        adaptador.Fill(conjunto, "Clientes")

        'Enlazamos el DataGridView al DataTable
        DataGridView1.DataSource = conjunto.Tables("Clientes")
    End Sub


    Private Sub ActualizarDataGridViewButton_Click(sender As Object, e As EventArgs) Handles ActualizarDataGridViewButton.Click

        'Creamos y configuramos los objetos necesarios para el acceso desconectado
        Dim conexion As New SqlConnection(My.Settings.cadena)
        Dim adaptador As New SqlDataAdapter("SELECT * FROM Clientes", conexion)
        Dim generador As New SqlCommandBuilder(adaptador)

        'Actualizamos el origen de datos. Pare recuperar el DataTable accedemos a la propiedad DataSource
        adaptador.Update(DataGridView1.DataSource)
    End Sub



    Private Sub CargarBindingSourceButton_Click(sender As Object, e As EventArgs) Handles CargarBindingSourceButton.Click
        'Creamos y configuramos los objetos necesarios para utilizar el modo desconectado
        Dim conexion As New SqlConnection(My.Settings.cadena)
        Dim adaptador As New SqlDataAdapter("SELECT * FROM Clientes", conexion)
        Dim generador As New SqlCommandBuilder(adaptador)
        Dim conjunto As New DataSet

        'Rellenamos el DataSet con los datos de la base de datos
        adaptador.Fill(conjunto, "Clientes")

        'Creamos un nuevo BindingSource y lo asociamos al DataTable
        Dim enlace As New BindingSource(conjunto, "Clientes")

        'Enlazamos el DataGridView al BindingSource
        DataGridView2.DataSource = enlace
        BindingNavigator1.BindingSource = enlace
        'Enlazamos los TextBox al BindingSource
        NombreBindingSourceTextBox.DataBindings.Clear()
        NombreBindingSourceTextBox.DataBindings.Add("Text", enlace, "nombre")
        EdadBindingSourceTextBox.DataBindings.Clear()
        EdadBindingSourceTextBox.DataBindings.Add("Text", enlace, "edad")
        IdBindingSourceTextBox.DataBindings.Clear()
        IdBindingSourceTextBox.DataBindings.Add("Text", enlace, "id")
    End Sub

    Private Sub ActualizarBindingSourceButton_Click(sender As Object, e As EventArgs) Handles ActualizarBindingSourceButton.Click
        'Creamos y configuramos los objetos necesarios para el acceso desconectado
        Dim conexion As New SqlConnection(My.Settings.cadena)
        Dim adaptador As New SqlDataAdapter("SELECT * FROM Clientes", conexion)
        Dim generador As New SqlCommandBuilder(adaptador)

        'Actualizamos el origen de datos. Pare recuperar el DataTable accedemos a la propiedad DataSource del DataGridView (BindingSource)
        'A su vez, tenemos que acceder a la propiedad DataSource del BindingSource, que es un DataSet
        'Finalmente, obtenemos el DataTable que nos interesa del DataSet
        adaptador.Update(CType(CType(DataGridView2.DataSource, BindingSource).DataSource, DataSet).Tables("Clientes"))
    End Sub

    Private Sub FiltrarButton_Click(sender As Object, e As EventArgs) Handles FiltrarButton.Click
        'Configuramos el filtro del BindingSource
        DirectCast(DataGridView2.DataSource, BindingSource).Filter = "Nombre LIKE '%" & NombreBinding.Text & "%'"
    End Sub


End Class
