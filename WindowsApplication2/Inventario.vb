Public Class Inventario
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            conectarAccess()


            Try
                lector1 = ArrayAcces("SELECT producto FROM Productos WHERE codigo='" & TextBox1.Text & "'")
                TextBox2.Text = lector1.GetValue(0)
                lector2 = ArrayAcces("SELECT cantidad,fechaingreso,fechacaducidad FROM Inventario WHERE codigo='" & TextBox1.Text & "'")
                TextBox3.Text = lector2.GetValue(0)
                DateTimePicker1.Text = lector2.GetValue(1)
                DateTimePicker2.Text = lector2.GetValue(2)
            Catch ex As Exception
                ' MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try


            lector1 = ArrayAcces("SELECT id FROM Inventario WHERE codigo='" & TextBox1.Text & "'")
            If (lector1.HasRows = False) Then
                'Codigo para guardar un registro en la tabla de inventarios
                Try
                    guardar("INSERT INTO Inventario(Codigo,producto,cantidad,fechaingreso,fechacaducidad) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & Me.DateTimePicker1.Text & "','" & Me.DateTimePicker2.Text & "')")
                    MsgBox("Datos almacenados", MsgBoxStyle.Information)
                    borrar()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                'Codigo para actualizar un registro en la tabla de inventarios
                Try
                    guardar("UPDATE Inventario SET producto='" & TextBox2.Text & "', cantidad= '" & TextBox3.Text & "', fechaingreso= '" & Me.DateTimePicker1.Text & "', fechacaducidad= '" & Me.DateTimePicker2.Text & "' WHERE Codigo='" & TextBox1.Text & "'")
                    MsgBox("Datos actualizados", MsgBoxStyle.Information)
                    borrar()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub borrar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class