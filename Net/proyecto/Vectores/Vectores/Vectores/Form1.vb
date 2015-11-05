Public Class Form1
    Dim Ventas(12) As Integer
    Dim i As Integer

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        i = txtMes.Text
        If (i >= 1 And i <= 12) Then
            Ventas(i) = txtValor.Text
        Else
            MsgBox("Ingrese un valor entre 1 y 12")

        End If
        txtMes.Text = ""
        txtValor.Text = ""
        txtMes.Focus()

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        i = 1
        dgvDatos.Rows.Clear()

        Do While (i <= 12)
            dgvDatos.Rows.Add(i, Ventas(i))
            i = i + 1
        Loop
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        i = 1
        Do While (i <= 12)
            Ventas(i) = 0
            i = i + 1
        Loop
    End Sub
End Class
