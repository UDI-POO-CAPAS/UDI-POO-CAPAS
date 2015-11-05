Imports CapaNegocio

Public Class frmListadoPasajeros

    Private Sub frmListadoPasajeros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call cargaPasajeros()
    End Sub
    Sub cargaPasajeros()
        Dim capaNegocio As New CNPasajero
        dgpasajeros.DataSource = capaNegocio.listadoPasajero.Tables("Pasajeros")
        lbltotal.Text = capaNegocio.listadoPasajero.Tables("Pasajeros").Rows.Count
    End Sub

End Class

