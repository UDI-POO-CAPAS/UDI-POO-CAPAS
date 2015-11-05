Option Strict On

Imports System.Data.OleDb

Public Class cBaseDatos
    Public vConexion As OleDbConnection = Nothing

    Private vComando As OleDbCommand = Nothing
    Private vTransaccion As OleDbTransaction = Nothing

    Public Function EjecutarConsulta(ByVal sentenciaSQL As String) As OleDbDataReader
        Me.vComando = New OleDbCommand

        Me.vComando.Connection = Me.vConexion
        Me.vComando.CommandText = sentenciaSQL
        Me.vComando.CommandType = Data.CommandType.Text

        If Not Me.vTransaccion Is Nothing Then
            Me.vComando.Transaction = Me.vTransaccion
        End If

        Return Me.vComando.ExecuteReader()
    End Function

    Public Function EjecutarComando(ByVal comandoSQL As String) As Integer
        Me.vComando = New OleDbCommand

        Me.vComando.Connection = Me.vConexion
        Me.vComando.CommandText = comandoSQL
        Me.vComando.CommandType = Data.CommandType.Text

        If Not Me.vTransaccion Is Nothing Then
            Me.vComando.Transaction = Me.vTransaccion
        End If

        Return Me.vComando.ExecuteNonQuery()
    End Function

    Public Sub ComenzarTransaccion()
        If Me.vTransaccion Is Nothing Then
            Me.vTransaccion = Me.vConexion.BeginTransaction()
        End If
    End Sub

    Public Sub CancelarTransaccion()
        If Not Me.vTransaccion Is Nothing Then
            Me.vTransaccion.Rollback()
        End If
    End Sub

    Public Sub ConfirmarTransaccion()
        If Not Me.vTransaccion Is Nothing Then
            Me.vTransaccion.Commit()
        End If
    End Sub

    Public Sub Conectar()

        If Not Me.vConexion Is Nothing Then
            If Me.vConexion.State = Data.ConnectionState.Open Then
                Throw New BaseDatosException("La conexión ya se encuentra abierta.")
            End If
        End If

        Try

            If Me.vConexion Is Nothing Then
                Me.vConexion = New OleDbConnection
                Me.vComando = New OleDbCommand
                Me.vConexion.ConnectionString = gCadenaConexion
            End If

            Me.vConexion.Open()

        Catch ex As BaseDatosException
            Throw New BaseDatosException("Error al conectarse.")
        End Try
    End Sub

    Public Sub Desconectar()
        If Me.vConexion.State = Data.ConnectionState.Open Then
            Me.vConexion.Close()
        End If
    End Sub
End Class

Public Class BaseDatosException
    Inherits ApplicationException

    Public Sub New(ByVal mensaje As String, ByVal original As Exception)
        MyBase.New(mensaje, original)
    End Sub

    Public Sub New(ByVal mensaje As String)
        MyBase.New(mensaje)
    End Sub
End Class
