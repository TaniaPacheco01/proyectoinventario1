
Public Class Form_iniciarsesion
    Dim conexion As New conexion
    Dim datos As DataSet

    Private Sub Form_iniciarsesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datos = conexion.consultas("select * from usuarios")

    End Sub

    Private Sub Button_login_iniciar_Click(sender As Object, e As EventArgs) Handles btn_login_iniciar.Click
        'LOGIN
        Dim datos As New DataSet
        Dim lista As Byte
        If txt_usuario.Text <> "" And txt_contrasena.Text <> "" And cmb_nivel_login.Text <> "" Then

            datos = conexion.consultas("select * from usuarios where usuario='" & txt_usuario.Text & "' and contrasena='" & txt_contrasena.Text & "' and nivel='" & cmb_nivel_login.Text & "' ")
            lista = datos.Tables(0).Rows.Count
        End If
        If lista <> 0 Then
            MsgBox("Bienvenido")

            Form_menu.Show()
            Me.Hide()
        Else
            MsgBox("intentelo de nuevo")
            Me.Refresh()
        End If

        'PRIVILEGIO DE USUARIO
        If cmb_nivel_login.Text = "Administrador" Then
            Form_productos.GroupBox_form_productos.Visible = True
        End If
    End Sub

    Private Sub btn_login_salir_Click(sender As Object, e As EventArgs) Handles btn_login_salir.Click
        Close()
    End Sub
End Class
