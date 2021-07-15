Public Class Form_menu
    Private Sub btn_menu_productos_Click(sender As Object, e As EventArgs) Handles btn_menu_productos.Click
        Form_productos.Show()
    End Sub

    Private Sub btn_menu_admin_Click(sender As Object, e As EventArgs) Handles btn_menu_admin.Click
        Form_admin_opciones.Show()
    End Sub

    Private Sub Form_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form_iniciarsesion.nivelUsuario = "Administrador" Then
            btn_menu_admin.Visible = True
        End If
    End Sub

    Private Sub btn_cerrar_sesion_Click(sender As Object, e As EventArgs) Handles btn_cerrar_sesion.Click
        Dim salir As MsgBoxResult
        salir = MsgBox("¿Desea cerrar sesion?", MsgBoxStyle.YesNo, "Cerrar sesion")
        If salir = MsgBoxResult.Yes Then
            Me.Close()
            Form_iniciarsesion.Show()
        End If
    End Sub
End Class