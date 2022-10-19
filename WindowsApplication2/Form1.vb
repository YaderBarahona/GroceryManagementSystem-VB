Imports System.Runtime.InteropServices
Public Class Form1
    Private Arrastrar As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private fh As Form

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler MouseDown, AddressOf miMouseDown
        AddHandler BarraTitulo.MouseDown, AddressOf miMouseDown

        AddHandler MouseUp, AddressOf miMouseUp
        AddHandler BarraTitulo.MouseUp, AddressOf miMouseUp

        AddHandler MouseMove, AddressOf miMouseMove
        AddHandler BarraTitulo.MouseMove, AddressOf miMouseMove
        AbrirFormEnPanel(Principal)

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            Arrastrar = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub miMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            Arrastrar = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub

    Private Sub miMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            Arrastrar = False
        End If
    End Sub

    Private Sub miMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastrar = True Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        BtnRestaurar.Visible = False
        BtnMaximizar.Visible = True
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        SubMenu.Visible = True
    End Sub

    Private Sub BtnCatalogo_Click(sender As Object, e As EventArgs) Handles BtnCatalogo.Click
        SubMenu.Visible = False
        AbrirFormEnPanel(Catalogo)
    End Sub

    Private Sub BtnStock_Click(sender As Object, e As EventArgs) Handles BtnStock.Click
        SubMenu.Visible = False
        AbrirFormEnPanel(Stock)
    End Sub

    Private Sub BtnContactos_Click(sender As Object, e As EventArgs) Handles BtnContactos.Click
        SubMenu.Visible = False
    End Sub

    Private Sub BtnGanancias_Click(sender As Object, e As EventArgs) Handles BtnGanancias.Click
        SubMenu.Visible = False
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
    End Sub

    Private Sub AbrirFormEnPanel(FormHijo As Form)
        If (Me.PanelContenedor.Controls.Count > 0) Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        fh = FormHijo
            fh.TopLevel = False
            fh.FormBorderStyle = FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
            fh.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(Productos)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AbrirFormEnPanel(Principal)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(Provedores)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(Inventario)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel(Ventas)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirFormEnPanel(Express)
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) 

    End Sub
End Class
