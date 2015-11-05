Imports System.Text
Imports Tienda_AccesoDatos
Imports Tienda_Entidades

Public Class ProductoBol
    'Instanciamos nuestra clase ProductoDal para poder utilizar sus miembros
    Private _productoDal As New ProductoDal()
    '
    'El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
    Public ReadOnly stringBuilder As New StringBuilder()

    '
    'Creamos nuestro método para Insertar un nuevo Producto, observe como este método tampoco valida los el contenido
    'de las propiedades, sino que manda a llamar a una Función que tiene como tarea única hacer esta validación
    '
    Public Sub Registrar(producto As EProducto)
        If ValidarProducto(producto) Then
            If _productoDal.GetByid(producto.Id) Is Nothing Then
                _productoDal.Insert(producto)
            Else
                _productoDal.Update(producto)

            End If
        End If
    End Sub

    Public Function Todos() As List(Of EProducto)
        Return _productoDal.GetAll()
    End Function

    Public Function TraerPorId(idProduct As Integer) As EProducto
        stringBuilder.Clear()

        If idProduct = 0 Then
            stringBuilder.Append("Por favor proporcione un valor de Id valido")
        End If

        If stringBuilder.Length = 0 Then
            Return _productoDal.GetByid(idProduct)
        End If
        Return Nothing
    End Function

    Public Sub Eliminar(idProduct As Integer)
        stringBuilder.Clear()

        If idProduct = 0 Then
            stringBuilder.Append("Por favor proporcione un valor de Id valido")
        End If

        If stringBuilder.Length = 0 Then
            _productoDal.Delete(idProduct)
        End If
    End Sub

    Private Function ValidarProducto(producto As EProducto) As Boolean
        stringBuilder.Clear()

        If String.IsNullOrEmpty(producto.Descripcion) Then
            stringBuilder.Append("El campo Descripción es obligatorio")
        End If
        If String.IsNullOrEmpty(producto.Marca) Then
            stringBuilder.Append(Environment.NewLine + "El campo Marca es obligatorio")
        End If
        If producto.Precio <= 0 Then
            stringBuilder.Append(Environment.NewLine + "El campo Precio es obligatorio")
        End If

        Return stringBuilder.Length = 0
    End Function
End Class

