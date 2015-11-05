Imports System.Windows.Forms
Imports Tienda_Entidades
Imports Tienda_LogicaNegocio

Public Class Form1

    Private _producto As EProducto
    Private ReadOnly _productoBol As New ProductoBol()

    Public Sub New()
        InitializeComponent()
    End Sub

    '
    'Creamos los métodos generales llenando y leyendo objetos
    '
    Private Sub Guardar()
        Try
            If _producto Is Nothing Then
                _producto = New EProducto()
            End If

            _producto.Id = Convert.ToInt32(txtId.Text)
            _producto.Descripcion = txtDescripcion.Text
            _producto.Marca = txtMarca.Text
            _producto.Precio = Convert.ToDecimal(txtPrecio.Text)

            _productoBol.Registrar(_producto)

            If _productoBol.stringBuilder.Length <> 0 Then
                MessageBox.Show(_productoBol.stringBuilder.ToString(), "Para continuar:")
            Else
                MessageBox.Show("Producto registrado/actualizado con éxito")

                TraerTodos()
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado")
        End Try
    End Sub

    Private Sub TraerTodos()
        Dim productos As List(Of EProducto) = _productoBol.Todos()

        If productos.Count > 0 Then
            dgvDatos.AutoGenerateColumns = False
            dgvDatos.DataSource = productos
            dgvDatos.Columns("columnId").DataPropertyName = "Id"
            dgvDatos.Columns("columnDescripcion").DataPropertyName = "Descripcion"
            dgvDatos.Columns("columnMarca").DataPropertyName = "Marca"
            dgvDatos.Columns("columnPrecio").DataPropertyName = "Precio"
        Else
            MessageBox.Show("No existen producto Registrado")
        End If
    End Sub

    Private Sub TraerPorId(id As Integer)
        Try
            _producto = _productoBol.TraerPorId(id)

            If _producto IsNot Nothing Then
                txtId.Text = Convert.ToString(_producto.Id)
                txtDescripcion.Text = _producto.Descripcion
                txtMarca.Text = _producto.Marca
                txtPrecio.Text = Convert.ToString(_producto.Precio)
            Else
                MessageBox.Show("El Producto solicitado no existe")
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado")
        End Try
    End Sub

    Private Sub Eliminar(id As Integer)
        Try
            _productoBol.Eliminar(id)

            MessageBox.Show("Producto eliminado satisfactoriamente")

            TraerTodos()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado")
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Guardar()
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyData = Keys.Enter AndAlso Not String.IsNullOrWhiteSpace(txtId.Text) Then
            e.SuppressKeyPress = True

            TraerPorId(Convert.ToInt32(txtId.Text))
        End If
    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecio.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True

            Guardar()
        End If
    End Sub

    Private Sub btbnBuscar_Click(sender As Object, e As EventArgs) Handles btbnBuscar.Click
        If Not String.IsNullOrWhiteSpace(txtId.Text) Then
            TraerPorId(Convert.ToInt32(txtId.Text))
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not String.IsNullOrWhiteSpace(txtId.Text) Then
            Eliminar(Convert.ToInt32(txtId.Text))
        End If
    End Sub
End Class