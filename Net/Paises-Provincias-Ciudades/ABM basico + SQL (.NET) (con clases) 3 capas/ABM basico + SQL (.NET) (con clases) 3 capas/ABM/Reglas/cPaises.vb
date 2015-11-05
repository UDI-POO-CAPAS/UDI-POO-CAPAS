Imports System.Text
Imports System.Data.OleDb

Public Class cPaises

    Private m_IdPais As String
    Private m_Nombre As String

    Public Sub New()

    End Sub

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

    Public Function TraerPaises(ByVal pNombre As String) As OleDbDataReader
        Dim vSQL As New StringBuilder

        vSQL.Append("SELECT * FROM Paises WHERE 1=1")

        If pNombre.Equals("") = False Then
            vSQL.Append(" AND nombre LIKE '%" & pNombre & "%'")
        End If

        Return oDB.EjecutarConsulta(vSQL.ToString)
    End Function

    Public Function Insertar() As Boolean
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("INSERT INTO Paises ")
        vSQL.Append("(idPais")
        vSQL.Append(",nombre")
        vSQL.Append(")")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & Me.m_IdPais & "'")
        vSQL.Append(",'" & Me.m_Nombre & "'")
        vSQL.Append(")")

        Call oDB.EjecutarComando(vSQL.ToString)

        vResultado = True
        Return vResultado
    End Function

    Public Function Actualizar() As Boolean
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("UPDATE Paises SET")
        vSQL.Append(" nombre='" & Me.m_Nombre & "'")
        vSQL.Append(" WHERE idPais='" & Me.m_IdPais & "'")

        Call oDB.EjecutarComando(vSQL.ToString)

        vResultado = True
        Return vResultado
    End Function

    Public Function Eliminar(ByVal pIdPais As String) As Boolean
        Dim vResultado As Boolean = False

        If pIdPais > "" Then

            Call oDB.EjecutarComando("DELETE FROM Paises WHERE idPais='" & pIdPais & "'")

            vResultado = True
            Return vResultado
        End If
    End Function

    Public Function TraerPais(ByVal pIdPais As String) As Boolean
        Dim vEncontro As Boolean = False
        Dim drDatos As OleDbDataReader = oDB.EjecutarConsulta("SELECT * FROM Paises WHERE idPais='" & pIdPais & "'")

        If drDatos.Read Then
            Me.m_IdPais = drDatos("idPais")
            Me.m_Nombre = drDatos("Nombre")
            vEncontro = True
        End If

        drDatos.Close()
        drDatos = Nothing

        Return vEncontro
    End Function

    Public Function ExistePais(ByVal pIdPais As String) As Boolean
        Dim vExiste As Boolean = False
        Dim drDatos As OleDbDataReader = oDB.EjecutarConsulta("SELECT idPais FROM Paises WHERE idPais='" & pIdPais & "'")

        If drDatos.Read Then
            vExiste = True
        End If

        drDatos.Close()
        drDatos = Nothing

        Return vExiste
    End Function
End Class