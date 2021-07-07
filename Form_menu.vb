Public Class Form_menu
    Private Sub btn_menu_productos_Click(sender As Object, e As EventArgs) Handles btn_menu_productos.Click
        Form_productos.Show()
    End Sub

    Private Sub btn_menu_admin_Click(sender As Object, e As EventArgs) Handles btn_menu_admin.Click
        Form_usuarios.Show()
    End Sub

End Class