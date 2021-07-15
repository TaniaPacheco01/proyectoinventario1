
Public Class Form_usuarios
    Dim conexion As New conexion
    Dim datos As DataSet
    Dim fila As Integer
    Private Sub Form_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizardatosdgusuarios()
    End Sub
    Public Function actualizardatosdgusuarios() As String
        Dim datos As New DataSet
        datos = conexion.consultas("select * from usuarios")
        DataGridView1_usuarios.DataSource = datos.Tables(0)
        DataGridView1_usuarios.Refresh()
        Return Nothing

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_agregar_ir_a_registro.Click
        Form_agregar_usuario.Show()
    End Sub

    Private Sub DataGridView1_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1_usuarios.CellClick
        fila = e.RowIndex
    End Sub

    Private Sub btn_eliminar_usuarios_Click(sender As Object, e As EventArgs) Handles btn_eliminar_usuarios.Click
        Dim confirmar As MsgBoxResult
        confirmar = MsgBox("Esta a punto de eliminar un usuario, ¿desea continuar?", MsgBoxStyle.YesNo, "Elimianr Usuario")
        If confirmar = MsgBoxResult.Yes Then
            conexion.consultas("delete from usuarios where Idusuario=" & DataGridView1_usuarios.Rows(fila).Cells(0).Value & "")
            MsgBox("Usuario eliminado")
        End If
        actualizardatosdgusuarios()
    End Sub

    Private Sub btn_modificar_usuarios_Click(sender As Object, e As EventArgs) Handles btn_modificar_usuarios.Click
        Form_modificar_usuario.Show()
        Form_modificar_usuario.txt_modificar_usuario_id.Text = DataGridView1_usuarios.Rows(fila).Cells(0).Value
        Form_modificar_usuario.txt_modificar_usuario_usuario.Text = DataGridView1_usuarios.Rows(fila).Cells(1).Value
        Form_modificar_usuario.txt_modificar_usuario_contrasena.Text = DataGridView1_usuarios.Rows(fila).Cells(2).Value
        Form_modificar_usuario.cmb_modificar_usuario_nivel.Text = DataGridView1_usuarios.Rows(fila).Cells(3).Value
    End Sub

    Private Sub txt_buscar_usuarios_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_usuarios.TextChanged
        Dim datosbuscar As New DataSet
        datosbuscar = conexion.consultas("select * from usuarios where usuario like '%" & txt_buscar_usuarios.Text & "%'")
        DataGridView1_usuarios.DataSource = datosbuscar.Tables(0)
        DataGridView1_usuarios.Refresh()
    End Sub

    Private Sub txt_buscar_usuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscar_usuarios.KeyPress
        Dim tabladedatos = New DataTable
        Me.DataGridView1_usuarios.DataSource = tabladedatos
        Refresh()
    End Sub

    Private Sub btn_inicio_form_usuarios_Click(sender As Object, e As EventArgs) Handles btn_inicio_form_usuarios.Click
        Form_menu.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1_usuarios.CellContentClick

    End Sub
End Class