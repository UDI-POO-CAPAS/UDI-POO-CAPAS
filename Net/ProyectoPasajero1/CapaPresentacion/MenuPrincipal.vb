Imports System.Windows.Forms

Public Class MenuPrincipal

    Private Sub NuevoPasajeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPasajeroToolStripMenuItem.Click
        Call cierraTodo()
        Dim chilform As New frmListadoPasajeros
        chilform.MdiParent = Me
        chilform.Show()
    End Sub


    Private Sub NuevoPasajeroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoPasajeroToolStripMenuItem1.Click
        Call cierratodo()
        Dim chilform As New frmNuevoPasajero
        chilform.MdiParent = Me
        chilform.Show()
    End Sub

    Sub cierraTodo()
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ActualizarPasajeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarPasajeroToolStripMenuItem.Click
        Call cierraTodo()
        Dim chilform As New frmActualizarPasajero
        chilform.MdiParent = Me
        chilform.Show()
    End Sub
End Class
