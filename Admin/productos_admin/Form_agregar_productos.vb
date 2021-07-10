
Public Class Form_agregar_productos
    Dim conexion As New conexion
    Dim datos As DataSet
    Private Sub Form_agregar_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datos = conexion.consultas("select * from productos")
    End Sub

    Private Sub btn_agregar_productos_Click(sender As Object, e As EventArgs) Handles btn_agregar_productos.Click
        conexion.consultas("INSERT INTO `productos` (`Idproductos`, `codigo`, `descripcion`, `unidad`,`precio_unitario`,`existencia`) VALUES (NULL, '" & txt_productos_agregar_codigo.Text & "', '" & txt_productos_agregar_descripcion.Text & "', '" & txt_productos_agregar_unidad.Text & "','" & txt_productos_agregar_precio.Text & "','" & txt_productos_agregar_existencia.Text & "'); ")
        Form_productos.actualizardatosproductos()
        MsgBox("Se ha registrado el producto")
        Me.Close()
    End Sub
End Class