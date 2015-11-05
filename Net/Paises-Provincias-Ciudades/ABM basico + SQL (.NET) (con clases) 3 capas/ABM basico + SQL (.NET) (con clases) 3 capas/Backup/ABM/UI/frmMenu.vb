Public Class frmMenu

    Private Sub mnuPaises_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaises.Click
        frmPaises.ShowDialog()
        frmPaises.Dispose()
    End Sub

    Private Sub mnuProvincias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProvincias.Click
        frmProvincias.ShowDialog()
        frmProvincias.Dispose()
    End Sub

    Private Sub mnuCiudades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCiudades.Click
        frmCiudades.ShowDialog()
        frmCiudades.Dispose()
    End Sub

    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
        Application.Exit()
    End Sub
End Class
