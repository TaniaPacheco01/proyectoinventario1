Public Class Form_agregar_usuario
    Dim conexion As New conexion
    Private Sub btn_agregar_usuario_Click(sender As Object, e As EventArgs) Handles btn_agregar_usuario.Click
        conexion.consultas("INSERT INTO `usuarios` (`Idusuario`, `usuario`, `contrasena`, `nivel`) VALUES (NULL, '" & txt_agregar_usuario.Text & "', '" & txt_agregar_contrasena.Text & "', '" & cmb_agregar_nivel.Text & "'); ")
        Form_usuarios.actualizardatosdgusuarios()
        MsgBox("Usuario agregado")
        Me.Close()
    End Sub

    Private Sub Form_agregar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class