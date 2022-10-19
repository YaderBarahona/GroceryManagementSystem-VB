<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.BtnRestaurar = New System.Windows.Forms.PictureBox()
        Me.BtnMaximizar = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.SubMenu = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BtnGanancias = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BtnContactos = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BtnStock = New System.Windows.Forms.Button()
        Me.BtnCatalogo = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        Me.SubMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.BtnRestaurar)
        Me.BarraTitulo.Controls.Add(Me.BtnMaximizar)
        Me.BarraTitulo.Controls.Add(Me.BtnMinimizar)
        Me.BarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1300, 35)
        Me.BarraTitulo.TabIndex = 0
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.restaurar
        Me.BtnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.Location = New System.Drawing.Point(1230, 6)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(25, 25)
        Me.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnRestaurar.TabIndex = 3
        Me.BtnRestaurar.TabStop = False
        Me.BtnRestaurar.Visible = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.maximizar__1_
        Me.BtnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.Location = New System.Drawing.Point(1230, 6)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMaximizar.TabIndex = 2
        Me.BtnMaximizar.TabStop = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.minimizar
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Location = New System.Drawing.Point(1199, 7)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMinimizar.TabIndex = 1
        Me.BtnMinimizar.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.cerrar1
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Location = New System.Drawing.Point(1261, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.SubMenu)
        Me.MenuVertical.Controls.Add(Me.Panel6)
        Me.MenuVertical.Controls.Add(Me.Panel5)
        Me.MenuVertical.Controls.Add(Me.BtnReportes)
        Me.MenuVertical.Controls.Add(Me.Panel4)
        Me.MenuVertical.Controls.Add(Me.Button5)
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.Button4)
        Me.MenuVertical.Controls.Add(Me.Panel2)
        Me.MenuVertical.Controls.Add(Me.Button3)
        Me.MenuVertical.Controls.Add(Me.Button2)
        Me.MenuVertical.Controls.Add(Me.Panel1)
        Me.MenuVertical.Controls.Add(Me.Button1)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Controls.Add(Me.PictureBox2)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 35)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(220, 615)
        Me.MenuVertical.TabIndex = 1
        '
        'SubMenu
        '
        Me.SubMenu.Controls.Add(Me.Panel11)
        Me.SubMenu.Controls.Add(Me.Panel10)
        Me.SubMenu.Controls.Add(Me.BtnGanancias)
        Me.SubMenu.Controls.Add(Me.Panel9)
        Me.SubMenu.Controls.Add(Me.BtnContactos)
        Me.SubMenu.Controls.Add(Me.Panel8)
        Me.SubMenu.Controls.Add(Me.BtnStock)
        Me.SubMenu.Controls.Add(Me.BtnCatalogo)
        Me.SubMenu.Location = New System.Drawing.Point(47, 444)
        Me.SubMenu.Name = "SubMenu"
        Me.SubMenu.Size = New System.Drawing.Size(172, 141)
        Me.SubMenu.TabIndex = 0
        Me.SubMenu.Visible = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(3, 105)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(5, 28)
        Me.Panel11.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(3, 71)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 28)
        Me.Panel10.TabIndex = 3
        '
        'BtnGanancias
        '
        Me.BtnGanancias.FlatAppearance.BorderSize = 0
        Me.BtnGanancias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGanancias.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGanancias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGanancias.Location = New System.Drawing.Point(5, 105)
        Me.BtnGanancias.Name = "BtnGanancias"
        Me.BtnGanancias.Size = New System.Drawing.Size(169, 28)
        Me.BtnGanancias.TabIndex = 4
        Me.BtnGanancias.Text = "Ganancias"
        Me.BtnGanancias.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(3, 37)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 28)
        Me.Panel9.TabIndex = 3
        '
        'BtnContactos
        '
        Me.BtnContactos.FlatAppearance.BorderSize = 0
        Me.BtnContactos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContactos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContactos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContactos.Location = New System.Drawing.Point(3, 71)
        Me.BtnContactos.Name = "BtnContactos"
        Me.BtnContactos.Size = New System.Drawing.Size(169, 28)
        Me.BtnContactos.TabIndex = 4
        Me.BtnContactos.Text = "Contactos"
        Me.BtnContactos.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 28)
        Me.Panel8.TabIndex = 1
        '
        'BtnStock
        '
        Me.BtnStock.FlatAppearance.BorderSize = 0
        Me.BtnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStock.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStock.Location = New System.Drawing.Point(3, 37)
        Me.BtnStock.Name = "BtnStock"
        Me.BtnStock.Size = New System.Drawing.Size(169, 28)
        Me.BtnStock.TabIndex = 4
        Me.BtnStock.Text = "Stock"
        Me.BtnStock.UseVisualStyleBackColor = True
        '
        'BtnCatalogo
        '
        Me.BtnCatalogo.FlatAppearance.BorderSize = 0
        Me.BtnCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCatalogo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatalogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalogo.Location = New System.Drawing.Point(3, 3)
        Me.BtnCatalogo.Name = "BtnCatalogo"
        Me.BtnCatalogo.Size = New System.Drawing.Size(169, 28)
        Me.BtnCatalogo.TabIndex = 2
        Me.BtnCatalogo.Text = "Catálogo"
        Me.BtnCatalogo.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(2, 395)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 46)
        Me.Panel6.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(3, 343)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 46)
        Me.Panel5.TabIndex = 3
        '
        'BtnReportes
        '
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReportes.Image = Global.WindowsApplication2.My.Resources.Resources.reportar
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(6, 395)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(213, 46)
        Me.BtnReportes.TabIndex = 6
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(3, 291)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 46)
        Me.Panel4.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Image = Global.WindowsApplication2.My.Resources.Resources.espress
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(7, 343)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(213, 46)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Express"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 239)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 46)
        Me.Panel3.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Image = Global.WindowsApplication2.My.Resources.Resources.ventas
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(7, 291)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(213, 46)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Ventas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 187)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 46)
        Me.Panel2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = Global.WindowsApplication2.My.Resources.Resources.provedor
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(220, 46)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Proveedores"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = Global.WindowsApplication2.My.Resources.Resources.inventarios
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(6, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Inventario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 46)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.WindowsApplication2.My.Resources.Resources.prodcuto1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(2, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Productos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources._3_White_logo_on_color1_185x65
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.WindowsApplication2.My.Resources.Resources.boton_de_apagado
        Me.PictureBox2.Location = New System.Drawing.Point(7, 562)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(220, 35)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1080, 615)
        Me.PanelContenedor.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BarraTitulo.ResumeLayout(False)
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        Me.SubMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BtnMaximizar As PictureBox
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BtnRestaurar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnReportes As Button
    Friend WithEvents SubMenu As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents BtnContactos As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnStock As Button
    Friend WithEvents BtnCatalogo As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents BtnGanancias As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
