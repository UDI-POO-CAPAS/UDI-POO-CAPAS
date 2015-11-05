Imports System.Text
Imports System.Data.OleDb

Public Class cProvincias

    Private m_IdProvincia As String
    Private m_IdPais As String
    Private m_Nombre As String

    Public Sub New()

    End Sub

    Public Property IdProvincia() As String
        Get
            Return Me.m_IdProvincia
        End Get
        Set(ByVal value As String)
            Me.m_IdProvincia = value
        End Set
    End Property

    Public Property IdPais() As String
        Get
            Return Me.m_IdPais
        End Get
        Set(ByVal value As String)
            Me.m_IdPais = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me.m_Nombre
        End Get
        Set(ByVal value As String)
            Me.m_Nombre = value
        End Set
    End Property

    Public Function TraerProvincias(ByVal pIdPais As String, ByVal pNombre As String) As OleDbDataReader
        Dim vSQL As New StringBuilder

        vSQL.Append("SELECT * FROM Provincias WHERE 1=1")

        If pIdPais.Equals("") = False Then
            vSQL.Append(" AND idPais='" & pIdPais & "'")
        End If

        If pNombre.Equals("") = False Then
            vSQL.Append(" AND nombre LIKE '%" & pNombre & "%'")
        End If

        Return oDB.EjecutarConsulta(vSQL.ToString)
    End Function

    Public Function Insertar() As Boolean
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("INSERT INTO Provincias ")
        vSQL.Append("(idProvincia")
        vSQL.Append(",idPais")
        vSQL.Append(",nombre")
        vSQL.Append(")")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & Me.m_IdProvincia & "'")
        vSQL.Append(",'" & Me.m_IdPais & "'")
        vSQL.Append(",'" & Me.m_Nombre & "'")
        vSQL.Append(")")

        Call oDB.EjecutarComando(vSQL.ToString)

        vResultado = True
        Return vResultado
    End Function

    Public Function Actualizar() As Boolean
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("UPDATE Provincias SET")
        vSQL.Append(" idPais='" & Me.m_IdPais & "',")
        vSQL.Append(" nombre='" & Me.m_Nombre & "'")
        vSQL.Append(" WHERE idProvincia='" & Me.m_IdProvincia & "'")

        Call oDB.EjecutarComando(vSQL.ToString)

        vResultado = True
        Return vResultado
    End Function

    Public Function Eliminar(ByVal pIdProvincia As String) As Boolean
        Dim vResultado As Boolean = False

        If pIdProvincia > "" Then

            Call oDB.EjecutarComando("DELETE FROM Provincias WHERE idProvincia='" & pIdProvincia & "'")

            vResultado = True
            Return vResultado
        End If
    End Function

    Public Function TraerProvincia(ByVal pIdProvincia As String) As Boolean
        Dim vEncontro As Boolean = False
        Dim drDatos As OleDbDataReader = oDB.EjecutarConsulta("SELECT * FROM Provincias WHERE idProvincia='" & pIdProvincia & "'")

        If drDatos.Read Then
            Me.m_IdProvincia = drDatos("idProvincia")
            Me.m_IdPais = drDatos("idPais")
            Me.m_Nombre = drDatos("Nombre")
            vEncontro = True
        End If

        drDatos.Close()
        drDatos = Nothing

        Return vEncontro
    End Function

    Public Function ExisteProvincia(ByVal pIdProvincia As String) As Boolean
        Dim vExiste As Boolean = False
        Dim drDatos As OleDbDataReader = oDB.EjecutarConsulta("SELECT idProvincia FROM Provincias WHERE idProvincia='" & pIdProvincia & "'")

        If drDatos.Read Then
            vExiste = True
        End If

        drDatos.Close()
        drDatos = Nothing

        Return vExiste
    End Function
End Class
