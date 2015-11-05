Imports System.Data.SqlServerCe
Imports System.Configuration
Imports Tienda_Entidades

'Definimos el acceso de nuestra clase como public, asegurando con esto su accesibilidad desde
'otros proyectos.
Public Class ProductoDal
    'Primero y siguiendo el orden de las acciones CRUD
    'Crearemos un Método que se encarga de insertar un nuevo Producto es nuestra tabla Producto
    ''' <summary>
    ''' Inserta un nuevo Producto en la tabla Producto
    ''' </summary>
    ''' <param name="producto">Entidad contenedora de los valores a insertar</param>
    ''' <autor>José Luis García Bautista</autor>
    Public Sub Insert(ByVal producto As EProducto)
        'Creamos nuestro objeto de conexión usando nuestro archivo de configuraciones
        Using cnx As New SqlCeConnection(ConfigurationManager.ConnectionStrings("cnnString").ToString())
            cnx.Open()
            'Declaramos nuestra consulta de Acción Sql parametrizada
            Const sqlQuery As String = "INSERT INTO Producto (Descripcion, Marca, Precio) VALUES (@descripcion, @marca, @precio)"
            Using cmd As New SqlCeCommand(sqlQuery, cnx)
                'El primero de los cambios significativos con respecto al ejemplo descargado es que aqui...
                'ya no leeremos controles sino usaremos las propiedades del Objeto EProducto de nuestra capa
                'de entidades...
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion)
                cmd.Parameters.AddWithValue("@marca", producto.Marca)
                cmd.Parameters.AddWithValue("@precio", producto.Precio)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Devuelve una lista de Productos ordenados por el campo Id de manera Ascendente
    ''' </summary>
    ''' <returns>Lista de productos</returns>
    ''' <autor>José Luis García Bautista</autor>
    Public Function GetAll() As List(Of EProducto)
        'Declaramos una lista del objeto EProducto la cual será la encargada de
        'regresar una colección de los elementos que se obtengan de la BD
        '
        'La lista substituye a DataTable utilizado en el proyecto de ejemplo
        Dim productos As New List(Of EProducto)()

        Using cnx As New SqlCeConnection(ConfigurationManager.ConnectionStrings("cnnString").ToString())
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Producto ORDER BY Id ASC"
            Using cmd As New SqlCeCommand(sqlQuery, cnx)
                Dim dataReader As SqlCeDataReader = cmd.ExecuteReader()
                '
                'Preguntamos si el DataReader fue devuelto con datos
                While dataReader.Read()
                    '
                    'Instanciamos al objeto Eproducto para llenar sus propiedades
                    Dim producto As New EProducto()
                    producto.Id = Convert.ToInt32(dataReader("Id"))
                    producto.Descripcion = Convert.ToString(dataReader("Descripcion"))
                    producto.Marca = Convert.ToString(dataReader("Marca"))
                    producto.Precio = Convert.ToDecimal(dataReader("Precio"))
                    '
                    'Insertamos el objeto Producto dentro de la lista Productos
                    productos.Add(producto)
                End While
            End Using
        End Using
        Return productos
    End Function

    ''' <summary>
    ''' Devuelve un Objeto Producto
    ''' </summary>
    ''' <param name="idProducto">Id del producto a buscar</param>
    ''' <returns>Un registro con los valores del Producto</returns>
    ''' <autor>José Luis García Bautista</autor>
    Public Function GetByid(ByVal idProducto As Integer) As EProducto
        Using cnx As New SqlCeConnection(ConfigurationManager.ConnectionStrings("cnnString").ToString())
            cnx.Open()

            Const sqlGetById As String = "SELECT * FROM Producto WHERE Id = @id"
            Using cmd As New SqlCeCommand(sqlGetById, cnx)
                '
                'Utilizamos el valor del parámetro idProducto para enviarlo al parámetro declarado en la consulta
                'de selección SQL
                cmd.Parameters.AddWithValue("@id", idProducto)
                Dim dataReader As SqlCeDataReader = cmd.ExecuteReader()
                If dataReader.Read() Then
                    Dim producto As New EProducto()
                    producto.Id = Convert.ToInt32(dataReader("Id"))
                    producto.Descripcion = Convert.ToString(dataReader("Descripcion"))
                    producto.Marca = Convert.ToString(dataReader("Marca"))
                    producto.Precio = Convert.ToDecimal(dataReader("Precio"))

                    Return producto
                End If
            End Using
        End Using

        Return Nothing
    End Function

    ''' <summary>
    ''' Actualiza el Producto correspondiente al Id proporcionado
    ''' </summary>
    ''' <param name="producto">Valores utilizados para hacer el Update al registro</param>
    ''' <autor>José Luis García Bautista</autor>
    Public Sub Update(ByVal producto As EProducto)
        Using cnx As New SqlCeConnection(ConfigurationManager.ConnectionStrings("cnnString").ToString())
            cnx.Open()
            Const sqlQuery As String = "UPDATE Producto SET Descripcion = @descripcion, Marca = @marca, Precio = @precio WHERE Id = @id"
            Using cmd As New SqlCeCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion)
                cmd.Parameters.AddWithValue("@marca", producto.Marca)
                cmd.Parameters.AddWithValue("@precio", producto.Precio)
                cmd.Parameters.AddWithValue("@id", producto.Id)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Elimina un registro coincidente con el Id Proporcionado
    ''' </summary>
    ''' <param name="idproducto">Id del registro a Eliminar</param>
    ''' <autor>José Luis García Bautista</autor>
    Public Sub Delete(ByVal idproducto As Integer)
        Using cnx As New SqlCeConnection(ConfigurationManager.ConnectionStrings("cnnString").ToString())
            cnx.Open()
            Const sqlQuery As String = "DELETE FROM Producto WHERE Id = @id"
            Using cmd As New SqlCeCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idproducto)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
