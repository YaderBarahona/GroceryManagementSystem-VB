<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Express
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Textboxproducto = New System.Windows.Forms.GroupBox()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxPago = New System.Windows.Forms.ComboBox()
        Me.TextProducto = New System.Windows.Forms.TextBox()
        Me.TextboxEmail = New System.Windows.Forms.TextBox()
        Me.TextboxTelefono = New System.Windows.Forms.TextBox()
        Me.TextboxDireccion = New System.Windows.Forms.TextBox()
        Me.TextboxNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dataProductos = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Textboxproducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dataProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(482, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 33)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Express"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SeaGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(399, 490)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 46)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Borrar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(284, 490)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 46)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Textboxproducto
        '
        Me.Textboxproducto.BackColor = System.Drawing.Color.Transparent
        Me.Textboxproducto.Controls.Add(Me.TextBoxCodigo)
        Me.Textboxproducto.Controls.Add(Me.Label7)
        Me.Textboxproducto.Controls.Add(Me.ComboBoxPago)
        Me.Textboxproducto.Controls.Add(Me.TextProducto)
        Me.Textboxproducto.Controls.Add(Me.TextboxEmail)
        Me.Textboxproducto.Controls.Add(Me.TextboxTelefono)
        Me.Textboxproducto.Controls.Add(Me.TextboxDireccion)
        Me.Textboxproducto.Controls.Add(Me.TextboxNombre)
        Me.Textboxproducto.Controls.Add(Me.Label6)
        Me.Textboxproducto.Controls.Add(Me.Label5)
        Me.Textboxproducto.Controls.Add(Me.Label4)
        Me.Textboxproducto.Controls.Add(Me.Label3)
        Me.Textboxproducto.Controls.Add(Me.Label2)
        Me.Textboxproducto.Controls.Add(Me.Label1)
        Me.Textboxproducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Textboxproducto.Location = New System.Drawing.Point(33, 90)
        Me.Textboxproducto.Name = "Textboxproducto"
        Me.Textboxproducto.Size = New System.Drawing.Size(477, 371)
        Me.Textboxproducto.TabIndex = 13
        Me.Textboxproducto.TabStop = False
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodigo.Location = New System.Drawing.Point(178, 162)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(229, 24)
        Me.TextBoxCodigo.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(21, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "codigo"
        '
        'ComboBoxPago
        '
        Me.ComboBoxPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPago.FormattingEnabled = True
        Me.ComboBoxPago.Items.AddRange(New Object() {"efectivo", "tarjeta de credito", "tarjeta de debito"})
        Me.ComboBoxPago.Location = New System.Drawing.Point(178, 282)
        Me.ComboBoxPago.Name = "ComboBoxPago"
        Me.ComboBoxPago.Size = New System.Drawing.Size(229, 26)
        Me.ComboBoxPago.TabIndex = 4
        '
        'TextProducto
        '
        Me.TextProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextProducto.Location = New System.Drawing.Point(178, 201)
        Me.TextProducto.Name = "TextProducto"
        Me.TextProducto.Size = New System.Drawing.Size(229, 24)
        Me.TextProducto.TabIndex = 6
        '
        'TextboxEmail
        '
        Me.TextboxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxEmail.Location = New System.Drawing.Point(178, 240)
        Me.TextboxEmail.Name = "TextboxEmail"
        Me.TextboxEmail.Size = New System.Drawing.Size(229, 24)
        Me.TextboxEmail.TabIndex = 5
        '
        'TextboxTelefono
        '
        Me.TextboxTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxTelefono.Location = New System.Drawing.Point(178, 120)
        Me.TextboxTelefono.Name = "TextboxTelefono"
        Me.TextboxTelefono.Size = New System.Drawing.Size(229, 24)
        Me.TextboxTelefono.TabIndex = 3
        '
        'TextboxDireccion
        '
        Me.TextboxDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxDireccion.Location = New System.Drawing.Point(178, 72)
        Me.TextboxDireccion.Name = "TextboxDireccion"
        Me.TextboxDireccion.Size = New System.Drawing.Size(229, 24)
        Me.TextboxDireccion.TabIndex = 2
        '
        'TextboxNombre
        '
        Me.TextboxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxNombre.Location = New System.Drawing.Point(178, 28)
        Me.TextboxNombre.Name = "TextboxNombre"
        Me.TextboxNombre.Size = New System.Drawing.Size(229, 24)
        Me.TextboxNombre.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(21, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Metodo de pago"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(21, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(21, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(21, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dataProductos)
        Me.Panel1.Location = New System.Drawing.Point(571, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 364)
        Me.Panel1.TabIndex = 17
        '
        'dataProductos
        '
        Me.dataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.dataProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataProductos.ColumnHeadersHeight = 30
        Me.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Marca, Me.Precio, Me.Tipo})
        Me.dataProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataProductos.EnableHeadersVisualStyles = False
        Me.dataProductos.GridColor = System.Drawing.Color.SteelBlue
        Me.dataProductos.Location = New System.Drawing.Point(0, 0)
        Me.dataProductos.Name = "dataProductos"
        Me.dataProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataProductos.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dataProductos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataProductos.Size = New System.Drawing.Size(468, 364)
        Me.dataProductos.TabIndex = 1
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre.HeaderText = "     Nombre     "
        Me.Nombre.MinimumWidth = 30
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 125
        '
        'Marca
        '
        Me.Marca.HeaderText = "     Marca     "
        Me.Marca.Name = "Marca"
        Me.Marca.Width = 113
        '
        'Precio
        '
        Me.Precio.HeaderText = "     Tipo     "
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 98
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "     Precio     "
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 112
        '
        'Express
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1064, 576)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Textboxproducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Express"
        Me.Text = "Express"
        Me.Textboxproducto.ResumeLayout(False)
        Me.Textboxproducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dataProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Textboxproducto As GroupBox
    Friend WithEvents TextboxEmail As TextBox
    Friend WithEvents TextboxTelefono As TextBox
    Friend WithEvents TextboxDireccion As TextBox
    Friend WithEvents TextboxNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxPago As ComboBox
    Friend WithEvents TextProducto As TextBox
    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dataProductos As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
End Class
