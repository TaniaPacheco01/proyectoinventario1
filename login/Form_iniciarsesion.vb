Imports MySql.Data.MySqlClient

Public Class Form_iniciarsesion
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet

    Private Sub Form_iniciarsesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario"
            conexion.Open()
            MsgBox("Conexion con BD establecida")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button_login_iniciar_Click(sender As Object, e As EventArgs) Handles btn_login_iniciar.Click
        Dim consulta As String
        Dim lista As Byte
        If txt_usuario.Text <> "" And txt_contrasena.Text <> "" Then
            consulta = "select * from usuarios where usuario='" & txt_usuario.Text & "' and contrasena='" & txt_contrasena.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            lista = datos.Tables("usuarios").Rows.Count
        End If
        If lista <> 0 Then
            MsgBox("Bienvenido")

            Form_usuarios.Show()
        Else
            MsgBox("intentelo de nuevo")
        End If
        txt_usuario.Clear()
        txt_contrasena.Clear()
        Me.Hide()
    End Sub

    Private Function comando() As MySqlCommand
        Throw New NotImplementedException()
    End Function

    Private Sub btn_login_salir_Click(sender As Object, e As EventArgs) Handles btn_login_salir.Click
        Close()
    End Sub
End Class
