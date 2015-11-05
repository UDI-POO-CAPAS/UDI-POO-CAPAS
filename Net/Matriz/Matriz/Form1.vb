Public Class Form1
    Dim columna, fila As Byte
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim i As Byte
        columna = Val(Me.txtColumnas.Text)
        fila = Val(Me.txtFilas.Text)

        If Val(Me.txtColumnas.Text) > "0" And Val(Me.txtFilas.Text) > "0" Then

            Me.dgvMatriz1.ColumnCount = columna
            Me.dgvMatriz1.RowCount = fila
            Me.dgvMatriz1.RowHeadersWidth = 50

            Me.dgvMatriz2.ColumnCount = columna
            Me.dgvMatriz2.RowCount = fila
            Me.dgvMatriz2.RowHeadersWidth = 50

            Me.dgvRespuesta.ColumnCount = columna
            Me.dgvRespuesta.RowCount = fila
            Me.dgvRespuesta.RowHeadersWidth = 50

            For i = 0 To columna - 1
                Me.dgvMatriz1.Columns(i).Width = 40
                Me.dgvMatriz2.Columns(i).Width = 40
                Me.dgvRespuesta.Columns(i).Width = 40
                Me.dgvMatriz1.Columns(i).HeaderText = i + 1
                Me.dgvMatriz2.Columns(i).HeaderText = i + 1
                Me.dgvRespuesta.Columns(i).HeaderText = i + 1
            Next

            For i = 0 To fila - 1
                Me.dgvMatriz1.Rows(i).HeaderCell.Value = (i + 1).ToString
                Me.dgvMatriz2.Rows(i).HeaderCell.Value = (i + 1).ToString
                Me.dgvRespuesta.Rows(i).HeaderCell.Value = (i + 1).ToString

            Next
            Me.btnSuma.Enabled = True
            Me.btnResta.Enabled = True

        Else
            MsgBox("DIGITA ALGUN VALOR")
            Me.txtFilas.Focus()
        End If


    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim i, j As Byte

        For i = 0 To fila - 1
            For j = 0 To columna - 1
                Me.dgvRespuesta.Rows(i).Cells(j).Value = Val(Me.dgvMatriz1.Rows(i).Cells(j).Value) + Val(Me.dgvMatriz2.Rows(i).Cells(j).Value)
            Next
        Next
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim i, j As Byte

        For i = 0 To fila - 1
            For j = 0 To columna - 1
                Me.dgvRespuesta.Rows(i).Cells(j).Value = Val(Me.dgvMatriz1.Rows(i).Cells(j).Value) - Val(Me.dgvMatriz2.Rows(i).Cells(j).Value)
            Next
        Next
    End Sub


    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim i, j As Byte

        For i = 0 To fila - 1
            For j = 0 To columna - 1
                Me.dgvMatriz1.Rows(i).Cells(j).Value = ""
                Me.dgvMatriz2.Rows(i).Cells(j).Value = ""
                Me.dgvRespuesta.Rows(i).Cells(j).Value = ""
            Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
