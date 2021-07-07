Imports MySql.Data.MySqlClient
Public Class Form_modificar_usuario
    Dim conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub Form_modificar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'actualizardatosmodificar()
    End Sub
    Public Function actualizardatosmodificar()
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario"
            conexion.Open()
            Dim consulta As String
            consulta = "select * from usuarios"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            DataGridView2_modificar_usuario.DataSource = datos
            DataGridView2_modificar_usuario.DataMember = "usuarios"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    'Public Function consulta(ByVal query) As DataSet
    'Dim datos As New DataSet
    'Try
    '       conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario"
    '   conexion.Open()
    'Catch ex As Exception

    'End Try
    'End Function

    Private Sub btn_modificar_form_modificar_usuario_Click(sender As Object, e As EventArgs) Handles btn_modificar_form_modificar_usuario.Click

        Try
            Dim modificar As String
            conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario"
            conexion.Open()
            modificar = "update from usuarios set usuario '" & txt_modificar_usuario_usuario.Text & "',contrasena='" & txt_modificar_usuario_contrasena.Text & "',nivel='" & cmb_modificar_usuario_nivel.Text & "' where Idusuario=" & txt_modificar_usuario_id.Text & ""
        Catch ex As Exception
            MsgBox("A ocurrido un error")
        End Try
    End Sub
End Class