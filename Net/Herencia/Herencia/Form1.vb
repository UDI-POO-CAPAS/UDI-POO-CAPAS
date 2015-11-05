Public Class Form1

    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click
        Dim objCuadrado As New ClaseBase.Heredado
        Dim a, b As Integer
        b = Me.txtBase.Text
        a = objCuadrado.AreaCuadrado(b)
        Me.txtResultado.Text = a


    End Sub

    Private Sub btnRectangulo_Click(sender As Object, e As EventArgs) Handles btnRectangulo.Click
        Dim objRectangulo As New ClaseBase.Heredado
        Dim b, h, tx As Integer
        b = Me.txtBase.Text
        h = Me.txtAltura.Text
        tx = objRectangulo.AreaRectangulo(b, h)
        Me.txtResultado.Text = tx

    End Sub

    Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click
        Dim objTriangulo As New ClaseBase.Heredado
        Dim b, h, tx As Double
        b = Me.txtBase.Text
        h = Me.txtAltura.Text
        tx = objTriangulo.AreaTriangulo(b, h)
        Me.txtResultado.Text = tx
    End Sub




    Private Sub btnCirculo_Click(sender As Object, e As EventArgs) Handles btnCirculo.Click
        Dim objCirculo As New ClaseBase.Heredado
        Dim a, r As Double
        r = Me.txtRadio.Text
        a = objCirculo.AreaCirculo(r)
        Me.txtResultado.Text = a

    End Sub
End Class
