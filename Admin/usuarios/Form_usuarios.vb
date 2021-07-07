Imports MySql.Data.MySqlClient

Public Class Form_usuarios
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim fila As Integer
    Private Sub Form_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizardatos()
    End Sub
    Public Function actualizardatos() As String
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario"
            conexion.Open()
            Dim consulta As String
            consulta = "select * from usuarios"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            DataGridView1_usuarios.DataSource = datos
            DataGridView1_usuarios.DataMember = "usuarios"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_agregar_ir_a_registro.Click
        Form_agregar_usuario.Show()
    End Sub

    Private Sub btn_actualizar_usuarios_Click(sender As Object, e As EventArgs) Handles btn_actualizar_usuarios.Click
        Dim consulta As String
        consulta = "select * from usuarios"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "usuarios")
        DataGridView1_usuarios.DataSource = datos
        DataGridView1_usuarios.DataMember = "usuarios"
    End Sub

    Private Sub DataGridView1_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1_usuarios.CellClick
        fila = e.RowIndex

    End Sub

    Private Sub btn_eliminar_usuarios_Click(sender As Object, e As EventArgs) Handles btn_eliminar_usuarios.Click
        Form_eliminar_usuarios.Show()

        '("delete from usuarios where id=" & DataGridView1_usuarios.Rows(fila).Cells(0).Value & "")
    End Sub

    Private Sub btn_modificar_usuarios_Click(sender As Object, e As EventArgs) Handles btn_modificar_usuarios.Click
        Form_modificar_usuario.Show()
        Form_modificar_usuario.txt_modificar_usuario_id.Text = DataGridView1_usuarios.Rows(fila).Cells(0).Value
        Form_modificar_usuario.txt_modificar_usuario_usuario.Text = DataGridView1_usuarios.Rows(fila).Cells(1).Value
        Form_modificar_usuario.txt_modificar_usuario_contrasena.Text = DataGridView1_usuarios.Rows(fila).Cells(2).Value
        Form_modificar_usuario.cmb_modificar_usuario_nivel.Text = DataGridView1_usuarios.Rows(fila).Cells(3).Value
    End Sub

    Private Sub txt_buscar_usuarios_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_usuarios.TextChanged

    End Sub

    Private Sub txt_buscar_usuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscar_usuarios.KeyPress
        Dim adaptador As New MySqlDataAdapter("Select * from usuarios where usuario like '" + txt_buscar_usuarios.Text + "%'", conexion)
        Dim tabladedatos = New DataTable
        adaptador.Fill(tabladedatos)
        Me.DataGridView1_usuarios.DataSource = tabladedatos
        Refresh()
    End Sub

    Private Sub btn_inicio_form_usuarios_Click(sender As Object, e As EventArgs) Handles btn_inicio_form_usuarios.Click
        Form_menu.Show()
    End Sub
End Class