Public Class Directorio
    Private Sub Directorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDataGrid(dataContactos, "SELECT codigo,producto,marca,tipo,presentacion,preciocompra,precioventa FROM Provedores")
    End Sub
End Class