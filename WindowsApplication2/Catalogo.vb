Public Class Catalogo
    Private Sub Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cargarDataGrid(dataProductos, "SELECT codigo,producto,marca,tipo,presentacion,preciocompra,precioventa FROM Productos")
    End Sub
End Class