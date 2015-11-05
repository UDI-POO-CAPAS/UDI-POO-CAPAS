Imports System.Data.SqlClient
Imports Libreria_Datos
Public Class Form1

    Dim objDatos As New clsDatos

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cboBD.DataSource = objDatos.ListarBD
            cboBD.DisplayMember = "name"
            cboBD.ValueMember = "name"
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub cboBD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBD.SelectedIndexChanged
        
        Try
            cboTabla.DataSource = objDatos.ListarTablas(cboBD.SelectedValue.ToString)
            cboTabla.DisplayMember = "name"
            cboTabla.ValueMember = "name"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboTabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTabla.SelectedIndexChanged
        Try
            dgvRegistros.DataSource = objDatos.ListarRegistros(cboTabla.SelectedValue.ToString)
        Catch ex As Exception

        End Try
    End Sub
End Class
