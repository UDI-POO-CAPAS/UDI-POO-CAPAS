Imports System.Data.SqlClient
Imports System.Configuration
Public Class CEPasajero

    Private _idPasajero As String
    Private _nombres As String
    Private _idPais As String
    Private _telefono As String
    Private _email As String

    Public Property idPasajero As String
        Get
            Return _idPasajero
        End Get
        Set(value As String)
            _idPasajero = value
        End Set
    End Property
    Public Property nombres As String
        Get
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value
        End Set
    End Property
    Public Property idPais As String
        Get
            Return _idPais
        End Get
        Set(value As String)
            _idPais = value
        End Set
    End Property
    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

End Class
