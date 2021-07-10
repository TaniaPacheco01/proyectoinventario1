Public Class Form_admin_opciones
    Private Sub btn_usuarios_admin_Click(sender As Object, e As EventArgs) Handles btn_usuarios_admin.Click
        Form_usuarios.Show()
        Me.Close()
        Form_menu.Hide()
    End Sub

    Private Sub btn_productos_admin_Click(sender As Object, e As EventArgs) Handles btn_productos_admin.Click
        Form_productos.Show()
        Me.Close()
        Form_menu.Hide()
    End Sub
End Class