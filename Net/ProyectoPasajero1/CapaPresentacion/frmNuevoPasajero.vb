Imports CapaNegocio
Imports CapaEntidad

Public Class frmNuevoPasajero
    Dim capaNegocios As New CNPasajero
    Private Sub frmNuevoPasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call generaCodigo()
        Call cargarPais()
    End Sub
    Sub generaCodigo()
        txtcodigo.Text = capaNegocios.nuevoCodigo
    End Sub
    Sub cargarPais()
        cboPais.DataSource = capaNegocios.listaPais.Tables("paises")
        cboPais.DisplayMember = "PAIS"
        cboPais.ValueMember = "IDPAIS"
    End Sub

    'Funciones de capturar valor
    Function getcodigo() As String
        Return txtcodigo.Text
    End Function

    Function getNombres() As String
        Return txtnombres.Text
    End Function

    Function getPais() As String
        Return cboPais.SelectedValue
    End Function

    Function getTelefono() As String
        Return txttelefono.Text
    End Function

    Function getEmail() As String
        Return txtemail.Text
    End Function

    Sub LimpiarCajas()
        Dim Cajas As Control

        For Each Cajas In Me.Controls
            If TypeOf Cajas Is System.Windows.Forms.TextBox Then
                Cajas.Text = ""
            End If
        Next
        txtnombres.Focus()
    End Sub

    Function Validar()
        With Me
            If Len(Trim(.txtcodigo.Text)) = 0 Then
                Return "Codigo"
            ElseIf Len(Trim(.txtnombres.Text)) = 0 Then
                Return "Nombres"
            ElseIf cboPais.SelectedIndex = -1 Then
                Return "Pais"
            ElseIf Len(Trim(.txttelefono.Text)) = 0 Then
                Return "Telefono"
            ElseIf Len(Trim(.txtemail.Text)) = 0 Then
                Return "Email"
            Else
                Return ""
            End If
        End With
    End Function
    Sub RegistraPasajero()
        Try
            Dim objeto As New CEPasajero
            If Validar() = "" Then
                objeto.idPasajero = getcodigo()
                objeto.nombres = getNombres()
                objeto.idPais = getPais()
                objeto.telefono = getTelefono()
                objeto.email = getEmail()

                capaNegocios.nuevoPasajero(objeto)
                Call LimpiarCajas()
                Call generaCodigo()
            Else
                MessageBox.Show("ERROR EN " + Validar(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR AL REGISTRAR" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        Call RegistraPasajero()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Call LimpiarCajas()
        Call generaCodigo()

    End Sub
End Class