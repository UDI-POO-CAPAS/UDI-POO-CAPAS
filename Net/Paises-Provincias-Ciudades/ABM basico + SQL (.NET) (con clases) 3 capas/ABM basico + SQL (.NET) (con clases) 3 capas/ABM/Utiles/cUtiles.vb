Imports System.IO

Public Class cUtiles
    ' -----------------------------------------------------------------------------------
    ' \\ -- Devuelve la primer linea de texto de un archivo
    ' -----------------------------------------------------------------------------------
    Public Shared Function LeerLineaArchivo(ByVal pPathArchivo As String) As String
        Try
            Dim vStream As StreamReader = New StreamReader(pPathArchivo)
            Dim vLinea As String = vStream.ReadLine()
            vStream.Close()
            vStream.Dispose()
            Return vLinea
        Catch Err As Exception
            Return ""
            MsgBox(Err.Message)
        End Try
    End Function

    ' -----------------------------------------------------------------------------------
    ' \\ -- Devuelve el path actual de ejecución de la aplicación
    ' -----------------------------------------------------------------------------------
    Public Shared Function AppPath() As String
        Return System.Windows.Forms.Application.StartupPath
    End Function

End Class

' -----------------------------------------------------------------------------------
' \\ -- Clase para simular la propiedad ItemData de los combobox o Listbox
' -----------------------------------------------------------------------------------
Public Class Combo_ItemData
    Private vId As String
    Private vNombre As String

    Public Sub New()
        vNombre = ""
        vId = 0
    End Sub

    Public Sub New(ByVal pNombre As String, ByVal pId As String)
        vNombre = pNombre
        vId = pId
    End Sub

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal sValue As String)
            vNombre = sValue
        End Set
    End Property

    Public Property ItemData() As String
        Get
            Return vId
        End Get
        Set(ByVal iValue As String)
            vId = iValue
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return vNombre
    End Function
End Class
