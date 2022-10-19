Imports System.IO
Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarDataGrid(dataInventario, "SELECT codigo,producto,cantidad,fechaingreso,fechacaducidad FROM Inventario")
    End Sub

    Private Sub dataInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataInventario.CellContentClick
        Dim codigo As String
        Dim tabla As OleDb.OleDbDataReader
        codigo = dataInventario.CurrentRow.Cells(0).Value.ToString
        conectarAccess()


        Try
            tabla = ArrayAcces("SELECT imagen FROM Productos WHERE codigo='" & codigo & "'")

            Dim MyData As Byte() = DirectCast(tabla.GetValue(0), Byte())

            Dim Stream = New MemoryStream(MyData)

            imagenProducto.Image = Image.FromStream(Stream)

        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try
    End Sub
End Class