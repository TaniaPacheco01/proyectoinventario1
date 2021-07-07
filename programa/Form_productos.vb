Imports MySql.Data.MySqlClient
Public Class Form_productos
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim fila As Integer
    Private Sub Form_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizardatosproductos()
    End Sub
    Public Function actualizardatosproductos() As String
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario"
            conexion.Open()
            Dim consulta As String
            consulta = "select * from productos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "productos")
            DataGridView2_productos.DataSource = datos
            DataGridView2_productos.DataMember = "productos"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub btn_agregar_productos_Click(sender As Object, e As EventArgs) Handles btn_agregar_productos.Click
        'esta funcion solo sirve para el administrador
        Form_agregar_productos.Show()
    End Sub

    Private Sub btn_actualizar_productos_Click(sender As Object, e As EventArgs) Handles btn_actualizar_productos.Click
        Dim consulta As String
        consulta = "select * from productos"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "productos")
        DataGridView2_productos.DataSource = datos
        DataGridView2_productos.DataMember = "productos"
    End Sub

    Private Sub DataGridView2_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2_productos.CellClick
        fila = e.RowIndex
    End Sub

    Private Sub btn_eliminar_productos_Click(sender As Object, e As EventArgs) Handles btn_eliminar_productos.Click
        'Try
        Dim eliminar As String
        'conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario"
        'conexion.Open()
        eliminar = "delete from productos where Idproductos=" & DataGridView2_productos.Rows(fila).Cells(0).Value
        MsgBox(eliminar)
        Dim comando = New MySqlCommand(eliminar, conexion)
        Dim adaptador = MySqlDataAdapter(comando)  'crear clase de conexion
        MsgBox("Producto eliminado")
        ' actualizardatosproductos()
        'Catch ex As Exception
        'MsgBox("A ocurrido un error" + ex.Message)

        'End Try





        'conexion.ConnectionString("delete from productos where Idproductos=" & DataGridView2_productos.Rows(fila).Cells(0).Value(0) & "")
        'MsgBox("Usuario eliminado")
    End Sub

    Private Sub txt_buscar_productos_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_productos.TextChanged
        Dim adaptador As New MySqlDataAdapter("Select * from productos where descripcion like '" + txt_buscar_productos.Text + "%'", conexion)
        Dim tabladedatos = New DataTable
        adaptador.Fill(tabladedatos)
        Me.DataGridView2_productos.DataSource = tabladedatos
        Refresh()
    End Sub

    Private Sub btn_inicio_form_productos_Click(sender As Object, e As EventArgs) Handles btn_inicio_form_productos.Click
        Form_menu.Show()
    End Sub
End Class