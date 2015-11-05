Imports System.Data.SqlClient
Imports Libreria_Conexion
Public Class clsDatos

    Dim objConexion As New clsConexion
    Dim strConexion As String = objConexion.CadenadeConexion("master")
    Dim da As SqlDataAdapter

    Public Function ListarBD() As DataTable

        Dim strSQL As String = "select name from sysdatabases where dbid > 6"
        Dim ds As New DataSet
        da = New SqlDataAdapter(strSQL, strConexion)
        da.Fill(ds, "dtBD")
        Return ds.Tables("dtBD")
    End Function

    Public Function ListarTablas(ByVal BaseDatos As String) As DataTable
        strConexion = objConexion.CadenadeConexion(BaseDatos)
        Dim strSQL As String = "select name from sysobjects where xtype='U'"
        Dim ds As New DataSet
        da = New SqlDataAdapter(strSQL, strConexion)
        da.Fill(ds, "dtTablas")
        Return ds.Tables("dtTablas")
    End Function

    Public Function ListarRegistros(ByVal Tabla As String) As DataTable
        Dim strSQL As String = "select * from [" + Tabla + "]"
        Dim ds As New DataSet
        da = New SqlDataAdapter(strSQL, strConexion)
        da.Fill(ds, "dtTablas")
        Return ds.Tables("dtTablas")
    End Function
End Class
