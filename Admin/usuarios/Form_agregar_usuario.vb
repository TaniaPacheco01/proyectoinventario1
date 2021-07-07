Imports MySql.Data.MySqlClient
Public Class Form_agregar_usuario
    Dim comandos As New MySqlCommand
    Dim conexion As New MySqlConnection
    Private Sub btn_agregar_usuario_Click(sender As Object, e As EventArgs) Handles btn_agregar_usuario.Click
        Try
            comandos = New MySqlCommand("insert into usuarios(Idusuario,usuario,contrasena,nivel)" & Chr(13) &
                                    "values(@Idusuario,@usuario,@contrasena,@nivel)", conexion)
            comandos.Parameters.AddWithValue("@Idusuario", "")
            comandos.Parameters.AddWithValue("@usuario", txt_agregar_usuario.Text)
            comandos.Parameters.AddWithValue("@contrasena", txt_agregar_contrasena.Text)
            comandos.Parameters.AddWithValue("@nivel", cmb_agregar_nivel.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Datos registrados")
            'Form_usuarios.actualizardatos()'

        Catch ex As Exception
            MsgBox("Intentelo de nuevo")
        End Try
        txt_agregar_usuario.Clear()
        txt_agregar_contrasena.Clear()


        Close()

    End Sub

    Private Sub Form_agregar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=inventario;"
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btn_agregar_volver_Click(sender As Object, e As EventArgs) Handles btn_agregar_volver.Click
        Me.Hide()
        Form_iniciarsesion.Show()
    End Sub
End Class