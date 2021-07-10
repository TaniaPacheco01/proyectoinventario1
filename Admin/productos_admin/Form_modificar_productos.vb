Public Class Form_modificar_productos
    Dim conexion As New conexion
    Private Sub btn_modificar_productos_Click(sender As Object, e As EventArgs) Handles btn_modificar_productos.Click
        conexion.consultas("update productos set codigo='" & txt_productos_modificar_codigo.Text & "', descripcion='" & txt_productos_modificar_descripcion.Text & "', unidad='" & txt_productos_modificar_unidad.Text & "', precio_unitario='" & txt_productos_modificar_precio.Text & "', existencia='" & txt_productos_modificar_existencia.Text & "' where Idproductos=" & txt_modificar_productos_id.Text & " ")
        Form_productos.actualizardatosproductos()
        MsgBox("Datos actualizados")
        Me.Close()
    End Sub

    Private Sub Form_modificar_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class