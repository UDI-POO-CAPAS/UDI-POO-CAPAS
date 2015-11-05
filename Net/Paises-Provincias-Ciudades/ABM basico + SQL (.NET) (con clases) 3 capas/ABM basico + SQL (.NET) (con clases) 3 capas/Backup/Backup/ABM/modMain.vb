Imports System.IO

Module modMain

    ' -----------------------------
    ' \\ -- Clases
    ' -----------------------------

    Public oDB As cBaseDatos
    Public oPaises As cPaises
    Public oProvincias As cProvincias
    Public oCiudades As cCiudades

    ' -----------------------------
    ' \\ -- Variables Globales
    ' -----------------------------
    Public gCadenaConexion As String

    Public Sub Main()

        Try

            If File.Exists(cUtiles.AppPath & "\datos.mdb") = False Then
                MessageBox.Show("No existe la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End
            Else
                gCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=datos.mdb;"
            End If

            oDB = New cBaseDatos
            oDB.Conectar()

            oPaises = New cPaises
            oProvincias = New cProvincias
            oCiudades = New cCiudades

            Application.EnableVisualStyles()
            Application.Run(frmMenu)

        Catch ex As Exception
            MessageBox.Show("Error al Inicar. " & vbNewLine & "Descripción del Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module