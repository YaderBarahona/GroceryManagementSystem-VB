Public Class Ventas
    Dim precio As Integer
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numero As Integer
        numero = Integer.Parse(StrReader("select factura from venta")) + 1
        textFactura.Text = numero
    End Sub

    Private Sub buscarProducto(ByVal codigo As String)
        Dim encontrado = True
        conectarAccess()
        Dim dato As String = 0

        Try
            dato = StrReader("SELECT producto FROM Productos WHERE codigo='" & codigo & "'")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            If dato = "0" Then
                MsgBox("Producto no encontrado", MsgBoxStyle.Information)
            Else

                conectarAccess()

                Dim tabla As OleDb.OleDbDataReader
                Try
                    tabla = ArrayAcces("SELECT producto,preciocompra FROM Productos WHERE codigo='" & textCodigo.Text & "'")
                    textProducto.Text = tabla.GetValue(0)
                    textPrecio.Text = tabla.GetValue(1)
                    precio = Integer.Parse(textPrecio.Text)

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dato = ""

    End Sub

    Private Sub textCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCodigo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            buscarProducto(textCodigo.Text)
        End If

    End Sub

    Private Sub textCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCantidad.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            textImporte.Text = Integer.Parse(textCantidad.Text) * precio
            montofinal += Integer.Parse(textImporte.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add(textCodigo.Text, textProducto.Text, textPrecio.Text, textCantidad.Text, textImporte.Text)

        borrar()
    End Sub

    Private Sub borrar()
        textCodigo.Clear()
        textCantidad.Clear()
        textPrecio.Clear()
        textProducto.Clear()
        textImporte.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' MsgBox(montofinal)
        factura.Show()
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Subtract) Then
            montofinal -= Integer.Parse(DataGridView1.CurrentRow.Cells(4).Value)
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyValue = 46 Then
            montofinal -= Integer.Parse(DataGridView1.CurrentRow.Cells(4).Value)
        End If
    End Sub
End Class