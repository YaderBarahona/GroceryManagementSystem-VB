Imports System.Data.OleDb
Imports System.IO

Public Class Productos
    Dim ms = New System.IO.MemoryStream()
    Dim guardar, actualizar As Boolean
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        guardarDatosProducto()
    End Sub
#Region "funciones"
    Private Function ConvertPicBoxImageToByte(ByVal pbImage As PictureBox) As Byte()

        Dim img As Image = pbImage.Image
        If (img Is Nothing) Then
            Throw New ArgumentException("No existe ninguna imagen disponible.")
        End If

        Dim ms As New System.IO.MemoryStream()
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()

    End Function
    Private Sub buscarProducto(ByVal codigo As String)
        Dim encontrado = True
        conectarAccess()
        Dim dato As String

        Try
            dato = StrReader("SELECT producto FROM Productos WHERE codigo='" & codigo & "'")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            If dato = "0" Then
                guardar = True
            Else
                actualizar = True
                conectarAccess()

                Dim tabla As OleDb.OleDbDataReader
                Try
                    tabla = ArrayAcces("SELECT * FROM Productos WHERE codigo='" & TextBox1.Text & "'")
                    TextBox2.Text = tabla.GetValue(1)
                    TextBox3.Text = tabla.GetValue(5)
                    TextBox6.Text = tabla.GetValue(2)
                    TextBox5.Text = tabla.GetValue(3)
                    ComboBox1.Text = tabla.GetValue(6)
                    TextBox4.Text = tabla.GetValue(7)
                    'myRow = dt.Rows(tabla.GetValue(4))
                    Dim MyData As Byte() = DirectCast(tabla.GetValue(4), Byte())

                    Dim Stream = New MemoryStream(MyData)

                    PictureBox1.Image = Image.FromStream(Stream)

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dato = ""

    End Sub
#End Region


#Region "Metodos"
    Public Sub cargarDatosProducto()

    End Sub

    Public Sub guardarDatosProducto()
        conectarAccess()
        Dim cmd As New OleDbCommand

        Dim imagen As Byte() = ConvertPicBoxImageToByte(PictureBox1)
        'GUARDAR----------------------------------------------------------------------------------------------------------------------------
        If guardar = True Then
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "agregaProductos"
            cmd.Connection = conexionAcces
            Try

                If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And ComboBox1.Text <> "") Then

                    cmd.Parameters.AddWithValue("@codigo", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@producto", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@preciocompra", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@precioventa", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@imagen", imagen)
                    cmd.Parameters.AddWithValue("@marca", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@tipo", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@presentacion", TextBox4.Text)
                    cmd.ExecuteNonQuery() ' Permite guardar a la base de datos
                    MsgBox("Datos almacenados de manera correcta")
                Else
                    MsgBox("Por favor llene todos los campos", MsgBoxStyle.Information)

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'ATUALIZAR-------------------------------------------------------------------------------------------------------------------------------------------------
        Else
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "actualizarProductos"
            cmd.Connection = conexionAcces
            Try

                If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And ComboBox1.Text <> "" And TextBox4.Text <> "") Then

                    cmd.Parameters.AddWithValue("@codigo", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@producto", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@preciocompra", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@precioventa", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@imagen", imagen)
                    cmd.Parameters.AddWithValue("@marca", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@tipo", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@presentacion", TextBox4.Text)
                    cmd.ExecuteNonQuery() ' Permite guardar a la base de datos
                Else
                    MsgBox("Por favor llene todos los campos", MsgBoxStyle.Information)

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MsgBox("Dato Actualizado", MsgBoxStyle.Information)

        End If
        guardar = False
        actualizar = False
    End Sub

    Public Sub actualizarDatosProducto()

    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            buscarProducto(TextBox1.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        Me.PictureBox1.Image = Nothing
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            OpenFileDialog1.Title = "Open Picture"
            OpenFileDialog1.FileName = ".jpg"
            OpenFileDialog1.Filter = "All Files |*.*"
            OpenFileDialog1.ShowDialog()
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception 'Do Nothing 

        End Try
    End Sub
#End Region
End Class