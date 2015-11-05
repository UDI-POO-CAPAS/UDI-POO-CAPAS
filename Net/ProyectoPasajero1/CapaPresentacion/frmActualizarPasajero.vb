Imports CapaEntidad
Imports CapaNegocio
Public Class frmActualizarPasajero

    Dim capanegocios As New CNPasajero

    Private Sub frmActualizarPasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarPasajeros()
        Call CargarPais()
    End Sub

    Sub CargarPasajeros()
        Dim capanegocios1 As New CNPasajero
        dgPasajeros.DataSource = capanegocios1.listadoPasajero.Tables("Pasajeros")
    End Sub


    Sub CargarPais()
        cboPais.DataSource = capanegocios.listaPais.Tables("paises")
        cboPais.DisplayMember = "PAIS"
        cboPais.ValueMember = "IDPAIS"

    End Sub
    Function Validar()
        With Me
            If Len(Trim(.txtCodigo.Text)) = 0 Then
                Return "Codigo"
            ElseIf Len(Trim(.txtNombres.Text)) = 0 Then
                Return "Nombres"
            ElseIf cboPais.SelectedIndex = -1 Then
                Return "Pais"
            ElseIf Len(Trim(.txtTelefono.Text)) = 0 Then
                Return "Telefono"
            ElseIf Len(Trim(.txtEmail.Text)) = 0 Then
                Return "Email"
            Else
                Return ""
            End If
        End With
    End Function
    Sub LimpiarCajas()
        Dim Cajas As Control
        txtCodigo.Text = Nothing
        cboPais.Text = Nothing
        For Each Cajas In Me.Controls
            If TypeOf Cajas Is System.Windows.Forms.TextBox Then
                Cajas.Text = ""
            End If
        Next
        txtnombres.Focus()
    End Sub

    Private Sub dgPasajeros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPasajeros.CellContentClick
        Try
            With dgPasajeros.CurrentRow
                txtCodigo.Text = .Cells(0).Value
                txtNombres.Text = .Cells(1).Value
                cboPais.Text = .Cells(2).Value
                txtTelefono.Text = .Cells(3).Value
                txtEmail.Text = .Cells(4).Value
            End With
        Catch ex As Exception
            MessageBox.Show("Error, Seleccione un Registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Function getcodigo() As String
        Return txtCodigo.Text
    End Function

    Function getNombres() As String
        Return txtNombres.Text
    End Function

    Function getPais() As String
        Return cboPais.SelectedValue
    End Function

    Function getTelefono() As String
        Return txtTelefono.Text
    End Function

    Function getEmail() As String
        Return txtEmail.Text
    End Function


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Call actualizapasajero()

    End Sub

    Sub actualizapasajero()
        Try
            Dim objeto As New CEPasajero
            If Validar() = "" Then
                objeto.idPasajero = getcodigo()
                objeto.nombres = getNombres()
                objeto.idPais = getPais()
                objeto.telefono = getTelefono()
                objeto.email = getEmail()

                capanegocios.actualizapasajero(objeto)
                MessageBox.Show("Pasajero actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Call LimpiarCajas()
                Call CargarPasajeros()
            Else
                MessageBox.Show("ERROR EN " + Validar(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR AL REGISTRAR" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call LimpiarCajas()
    End Sub
End Class