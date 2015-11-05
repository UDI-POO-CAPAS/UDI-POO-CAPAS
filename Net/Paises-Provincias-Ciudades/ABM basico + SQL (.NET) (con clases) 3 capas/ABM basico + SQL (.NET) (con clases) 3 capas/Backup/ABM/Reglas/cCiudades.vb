Imports System.Text
Imports System.Data.OleDb

Public Class cCiudades

    Private m_IdCiudad As String
    Private m_IdProvincia As String
    Private m_Nombre As String

    Public Sub New()

    End Sub

    Public Property IdCiudad() As String
        Get
            Return Me.m_IdCiudad
        End Get
        Set(ByVal value As String)
            Me.m_IdCiudad = value
        End Set
    End Property

    Public Property IdProvincia() As String
        Get
            Return Me.m_IdProvincia
        End Get
        Set(ByVal value As String)
            Me.m_IdProvincia = value
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

    Public Function TraerCiudades(ByVal pIdPais As String, ByVal pIdProvincia As String, ByVal pNombre As String) As OleDbDataReader
        Dim vSQL As New StringBuilder

        vSQL.Append("SELECT c.*")
        vSQL.Append(" FROM ((Ciudades c)")
        vSQL.Append(" INNER JOIN Provincias p ON p.idprovincia=c.idprovincia)")
        vSQL.Append(" INNER JOIN paises pa ON p.idpais=pa.idpais WHERE 1=1")

        If pIdPais.Equals("") = False Then
            vSQL.Append(" AND pa.idPais='" & pIdPais & "'")
        End If

        If pIdProvincia.Equals("") = False Then
            vSQL.Append(" AND c.idProvincia='" & pIdProvincia & "'")
        End If

        If pNombre.Equals("") = False Then
            vSQL.Append(" AND c.nombre LIKE '%" & pNombre & "%'")
        End If

        Return oDB.EjecutarConsulta(vSQL.ToString)
    End Function

    Public Function Insertar() As Boolean
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("INSERT INTO Ciudades ")
        vSQL.Append("(idCiudad")
        vSQL.Append(",idProvincia")
        vSQL.Append(",nombre")
        vSQL.Append(")")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & Me.m_IdCiudad & "'")
        vSQL.Append(",'" & Me.m_IdProvincia & "'")
        vSQL.Append(",'" & Me.m_Nombre & "'")
        vSQL.Append(")")

        Call oDB.EjecutarComando(vSQL.ToString)

        vResultado = True
        Return vResultado
    End Function

    Public Function Actualizar() As Boolean
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("UPDATE Ciudades SET")
        vSQL.Append(" idProvincia='" & Me.m_IdProvincia & "',")
        vSQL.Append(" nombre='" & Me.m_Nombre & "'")
        vSQL.Append(" WHERE idCiudad='" & Me.m_IdCiudad & "'")

        Call oDB.EjecutarComando(vSQL.ToString)

        vResultado = True
        Return vResultado
    End Function

    Public Function Eliminar(ByVal pIdCiudad As String) As Boolean
        Dim vResultado As Boolean = False

        If pIdCiudad > "" Then

            Call oDB.EjecutarComando("DELETE FROM Ciudades WHERE idCiudad='" & pIdCiudad & "'")

            vResultado = True
            Return vResultado
        End If
    End Function

    Public Function TraerCiudad(ByVal pIdCiudad As String) As Boolean
        Dim vEncontro As Boolean = False
        Dim drDatos As OleDbDataReader = oDB.EjecutarConsulta("SELECT * FROM Ciudades WHERE idCiudad='" & pIdCiudad & "'")

        If drDatos.Read Then
            Me.m_IdCiudad = drDatos("idCiudad")
            Me.m_IdProvincia = drDatos("idProvincia")
            Me.m_Nombre = drDatos("Nombre")
            vEncontro = True
        End If

        drDatos.Close()
        drDatos = Nothing

        Return vEncontro
    End Function

    Public Function ExisteCiudad(ByVal pIdCiudad As String) As Boolean
        Dim vExiste As Boolean = False
        Dim drDatos As OleDbDataReader = oDB.EjecutarConsulta("SELECT idCiudad FROM Ciudades WHERE idCiudad='" & pIdCiudad & "'")

        If drDatos.Read Then
            vExiste = True
        End If

        drDatos.Close()
        drDatos = Nothing

        Return vExiste
    End Function
End Class
