Imports System.Data.SqlClient
Imports CapaEntidad

Public Class DAOPasajero

    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    'Funcion que permita mostrar una lista de los pasajeros
    Public Function listadoPasajeros() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("LISTADOPASAJERO", cn)
        da.Fill(ds, "Pasajeros")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'Funcion que permita autogenerar el codigo del pasajero
    Public Function nuevoCodigo() As String
        cn = objCon.conectar
        cn.Open()
        da = New SqlDataAdapter("ULTIMOPASAJERO", cn)
        Dim ultimo$ = da.SelectCommand.ExecuteScalar()
        Return "P" & (Right(ultimo, 4) + 1).ToString("0000")

    End Function

    'Funcion que permita mostrar los paises
    Public Function listaPais() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New SqlDataAdapter("LISTAPAIS", cn)
        da.Fill(ds, "Paises")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()

    End Function

    'procedimiento que inserta un nuevo pasajero
    Public Sub NuevoPasajero(ByVal objp As CEPasajero)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("NUEVOPASAJERO", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@idpas", SqlDbType.Char).Value = objp.idPasajero
                .Add("@nom", SqlDbType.VarChar).Value = objp.nombres
                .Add("@idpai", SqlDbType.Char).Value = objp.idPais
                .Add("@tel", SqlDbType.VarChar).Value = objp.telefono
                .Add("@ema", SqlDbType.VarChar).Value = objp.email
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Pasajero registrado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error al registrar el pasajero", MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()

        End Try

    End Sub
    'Procedimiento que permita actualizar o modificar a un pasajero
    Public Sub ActualizaPasajero(ByVal objp As CEPasajero)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("ACTUALIZAPASAJERO", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@idpas", SqlDbType.Char).Value = objp.idPasajero
                .Add("@nom", SqlDbType.VarChar).Value = objp.nombres
                .Add("@idpai", SqlDbType.Char).Value = objp.idPais
                .Add("@tel", SqlDbType.VarChar).Value = objp.telefono
                .Add("@ema", SqlDbType.VarChar).Value = objp.email
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Pasajero se Modifico correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error al modificar el pasajero", MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()

        End Try
    End Sub

    'Procedimiento para eliminar a un pasajero
    Public Sub EliminaPasajero(ByVal objp As CEPasajero)
        cn = objCon.conectar
        Try
            da = New SqlDataAdapter("ELIMINAPASAJERO", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@idpas", SqlDbType.Char).Value = objp.idPasajero
            cn.Open()
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Pasajero se Eliminó correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error al Eliminar el pasajero", MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()

        End Try
    End Sub

End Class

