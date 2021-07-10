
Public Class Form_productos
    Dim conexion As New conexion
    Dim datos As DataSet
    Dim fila As Integer
    Private Sub Form_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizardatosproductos()
    End Sub
    Public Function actualizardatosproductos() As String
        Dim datos As New DataSet
        datos = conexion.consultas("select * from productos")
        DataGridView2_productos.DataSource = datos.Tables(0)
        DataGridView2_productos.Refresh()
        Return Nothing
    End Function

    Private Sub btn_agregar_productos_Click(sender As Object, e As EventArgs) Handles btn_agregar_productos.Click
        'esta funcion solo sirve para el administrador
        Form_agregar_productos.Show()
    End Sub

    Private Sub DataGridView2_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2_productos.CellClick
        fila = e.RowIndex
    End Sub

    Private Sub btn_eliminar_productos_Click(sender As Object, e As EventArgs) Handles btn_eliminar_productos.Click
        conexion.consultas("delete from productos where Idproductos=" & DataGridView2_productos.Rows(fila).Cells(0).Value & "")
        MsgBox("El producto ha sido eliminado")
        actualizardatosproductos()
    End Sub

    Private Sub txt_buscar_productos_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_productos.TextChanged
        Dim datosbuscar As New DataSet
        datosbuscar = conexion.consultas("select * from productos where descripcion like '%" & txt_buscar_productos.Text & "%'")
        DataGridView2_productos.DataSource = datosbuscar.Tables(0)
        DataGridView2_productos.Refresh()
    End Sub

    Private Sub btn_inicio_form_productos_Click(sender As Object, e As EventArgs)
        Form_menu.Show()
    End Sub

    Private Sub btn_modificar_productos_Click(sender As Object, e As EventArgs) Handles btn_modificar_productos.Click
        Form_modificar_productos.Show()
        Form_modificar_productos.txt_modificar_productos_id.Text = DataGridView2_productos.Rows(fila).Cells(0).Value
        Form_modificar_productos.txt_productos_modificar_codigo.Text = DataGridView2_productos.Rows(fila).Cells(1).Value
        Form_modificar_productos.txt_productos_modificar_descripcion.Text = DataGridView2_productos.Rows(fila).Cells(2).Value
        Form_modificar_productos.txt_productos_modificar_unidad.Text = DataGridView2_productos.Rows(fila).Cells(3).Value
        Form_modificar_productos.txt_productos_modificar_precio.Text = DataGridView2_productos.Rows(fila).Cells(4).Value
        Form_modificar_productos.txt_productos_modificar_existencia.Text = DataGridView2_productos.Rows(fila).Cells(5).Value

    End Sub

    Private Sub btn_inicio_form_usuarios_Click(sender As Object, e As EventArgs) Handles btn_inicio_form_usuarios.Click
        Form_menu.Show()
        Me.Close()
    End Sub
End Class