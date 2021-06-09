Imports MySql.Data.MySqlClient

Public Class Form_iniciarsesion
    Dim conexion As New MySqlConnection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_login_bienvenido.Click

    End Sub
    Private Sub Form_iniciarsesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=sistema_inventario;"
            conexion.Open()
            MsgBox("Conexion con BD establecida")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
