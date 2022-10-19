Public Class Provedores
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            guardar("INSERT INTO Proveedores(proveedor,marca,telefono,correo) values ('" & textNombre.Text & "','" & textMarca.Text & "','" & textTelefono.Text & "','" & textCorreo.Text & "')")
            MsgBox("Datos almacenados", MsgBoxStyle.Information)
            borrar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub borrar()
        textNombre.Clear()
        textMarca.Clear()
        textTelefono.Clear()
        textCorreo.Clear()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        borrar()
    End Sub
End Class