Imports MySql.Data.MySqlClient
Public Class conexion
    Const usuario As String = "root"
    Const password As String = ""
    Const servidor As String = "localhost"
    Const base_datos As String = "inventario"
    Dim datos_servidor = "server=" & servidor & ";user id=" & usuario & ";password=" & password & ";database=" & base_datos & ";"
    Dim conexion As New MySqlConnection(datos_servidor)

    Public Function consultas(ByVal query) As DataSet
        Dim dataset As New DataSet
        Try
            If Not conexion.State = ConnectionState.Open Then
                conexion.ConnectionString = datos_servidor
                conexion.Open()
            End If
            Dim comando As New MySqlCommand(query, conexion)
            Dim adaptador = New MySqlDataAdapter(comando)
            adaptador.Fill(dataset)
            adaptador.Dispose()
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.ToString)
        End Try
        Return dataset
    End Function

End Class
