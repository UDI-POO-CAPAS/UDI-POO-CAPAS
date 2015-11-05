Imports System.Data.SqlClient
Public Class clsConexion

    Public Function CadenadeConexion(ByVal BaseDatos As String) As String
        Dim cCon As String = "Server=THE-PUNISHER\SQLEXPRESS;Database= " + BaseDatos + ";Integrated Security=true"
        Using Conexion As New SqlConnection(cCon)
            Conexion.Open()
        End Using
        Return cCon
    End Function
End Class
