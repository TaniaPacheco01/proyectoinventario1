Imports MySql.Data.MySqlClient
Public Class Form_agregar_productos
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Private Sub Form_agregar_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario;"
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_agregar_productos_Click(sender As Object, e As EventArgs) Handles btn_agregar_productos.Click
        Try
            comandos = New MySqlCommand("insert into productos(Idproductos,codigo,descripcion,unidad,precio_unitario,existencia)" & Chr(13) &
                                    "values(@Idproductos,@codigo,@descripcion,@unidad,@precio_unitario,@existencia)", conexion)
            comandos.Parameters.AddWithValue("@Idproductos", "")
            comandos.Parameters.AddWithValue("@codigo", txt_productos_agregar_codigo.Text)
            comandos.Parameters.AddWithValue("@descripcion", txt_productos_agregar_descripcion.Text)
            comandos.Parameters.AddWithValue("@unidad", txt_productos_agregar_unidad.Text)
            comandos.Parameters.AddWithValue("@precio_unitario", txt_productos_agregar_precio.Text)
            comandos.Parameters.AddWithValue("@existencia", txt_productos_agregar_existencia.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Datos registrados")


        Catch ex As Exception
            MsgBox("Intentelo de nuevo")
        End Try
        txt_productos_agregar_codigo.Clear()
        txt_productos_agregar_descripcion.Clear()
        txt_productos_agregar_unidad.Clear()
        txt_productos_agregar_precio.Clear()
        txt_productos_agregar_existencia.Clear()

        Close()
    End Sub
End Class