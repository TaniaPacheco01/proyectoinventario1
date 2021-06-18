Imports MySql.Data.MySqlClient

Public Class Form_usuarios
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
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


    End Sub

    Private Sub btn_eliminar_usuarios_Click(sender As Object, e As EventArgs) Handles btn_eliminar_usuarios.Click

    End Sub

End Class