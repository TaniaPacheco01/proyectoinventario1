Imports MySql.Data.MySqlClient
Public Class Form_eliminar_usuarios
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_eliminar_usuario.Click
        Dim eliminar As String
        Dim si As Byte
        si = MsgBox("¿Desea eliminar el registro?", vbYesNo, "Eliminar")
        If si = 6 Then
            eliminar = "delete from usuarios where Idusuario='" & txt_idusuario.Text & "'"
            comandos = New MySqlCommand(eliminar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Registro eliminado")
            txt_buscar_usuario.Clear()
            txt_idusuario.Clear()
            txt_nombre_usuario.Clear()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_idusuario.TextChanged

    End Sub

    Private Sub btn_buscar_usuario_Click(sender As Object, e As EventArgs) Handles btn_buscar_usuario.Click
        Dim consulta As String
        Dim lista As Byte
        If txt_buscar_usuario.Text <> "" Then
            consulta = "select * from usuarios where usuario='" & txt_buscar_usuario.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            lista = datos.Tables("usuarios").Rows.Count
        End If
        If lista <> 0 Then
            txt_idusuario.Text = datos.Tables("usuarios").Rows(0).Item("Idusuario")
            txt_nombre_usuario.Text = datos.Tables("usuarios").Rows(0).Item("usuario")
        End If
        Dim consulta2 As String
        Dim lista2 As Byte
        If txt_buscar_usuario.Text <> "" Then
            consulta2 = "select * from usuarios where Idusuario='" & txt_buscar_usuario.Text & "'"
            adaptador = New MySqlDataAdapter(consulta2, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            lista2 = datos.Tables("usuarios").Rows.Count
        End If
        If lista2 <> 0 Then
            txt_idusuario.Text = datos.Tables("usuarios").Rows(0).Item("Idusuario")
            txt_nombre_usuario.Text = datos.Tables("usuarios").Rows(0).Item("usuario")

        End If
    End Sub

    Private Sub Form_eliminar_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class