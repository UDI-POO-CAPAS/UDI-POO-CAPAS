Imports CapaDatos
Imports CapaEntidad

Public Class CNPasajero
    Dim objPas As New DAOPasajero
    Public Function listadoPasajero() As DataSet
        Return objPas.listadoPasajeros

    End Function

    Public Function nuevoCodigo() As String
        Return objPas.nuevoCodigo
    End Function

    Public Function listaPais() As DataSet
        Return objPas.listaPais
    End Function

    Public Sub nuevoPasajero(ByVal objp As CEPasajero)
        objPas.NuevoPasajero(objp)
    End Sub

    Public Sub actualizapasajero(ByVal objp As CEPasajero)
        objPas.ActualizaPasajero(objp)
    End Sub

End Class
