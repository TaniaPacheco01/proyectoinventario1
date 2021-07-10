
Public Class Form_modificar_usuario
    Dim conexion As New conexion
    Dim datos As DataSet
    Private Sub Form_modificar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'actualizardatosmodificar()
    End Sub

    Private Sub btn_modificar_form_modificar_usuario_Click(sender As Object, e As EventArgs) Handles btn_modificar_form_modificar_usuario.Click
        conexion.consultas("update usuarios set usuario='" & txt_modificar_usuario_usuario.Text & "', contrasena='" & txt_modificar_usuario_contrasena.Text & "', nivel='" & cmb_modificar_usuario_nivel.Text & "' where Idusuario=" & txt_modificar_usuario_id.Text & " ")
        Form_usuarios.actualizardatosdgusuarios()
        MsgBox("Datos del usuario actualizados")
        Me.Close()
    End Sub
End Class