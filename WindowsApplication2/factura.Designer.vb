<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class factura
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
        Me.comboTarjeta = New System.Windows.Forms.ComboBox()
        Me.radioFectivo = New System.Windows.Forms.RadioButton()
        Me.radioTarjeta = New System.Windows.Forms.RadioButton()
        Me.labelMonto = New System.Windows.Forms.Label()
        Me.textMonto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'comboTarjeta
        '
        Me.comboTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTarjeta.FormattingEnabled = True
        Me.comboTarjeta.Items.AddRange(New Object() {"Master Card", "Visa"})
        Me.comboTarjeta.Location = New System.Drawing.Point(417, 187)
        Me.comboTarjeta.Name = "comboTarjeta"
        Me.comboTarjeta.Size = New System.Drawing.Size(216, 33)
        Me.comboTarjeta.TabIndex = 0
        Me.comboTarjeta.Text = "Tipo de tarjeta"
        Me.comboTarjeta.Visible = False
        '
        'radioFectivo
        '
        Me.radioFectivo.AutoSize = True
        Me.radioFectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFectivo.Location = New System.Drawing.Point(283, 57)
        Me.radioFectivo.Name = "radioFectivo"
        Me.radioFectivo.Size = New System.Drawing.Size(94, 28)
        Me.radioFectivo.TabIndex = 1
        Me.radioFectivo.TabStop = True
        Me.radioFectivo.Text = "Efectivo"
        Me.radioFectivo.UseVisualStyleBackColor = True
        '
        'radioTarjeta
        '
        Me.radioTarjeta.AutoSize = True
        Me.radioTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioTarjeta.Location = New System.Drawing.Point(506, 57)
        Me.radioTarjeta.Name = "radioTarjeta"
        Me.radioTarjeta.Size = New System.Drawing.Size(85, 28)
        Me.radioTarjeta.TabIndex = 2
        Me.radioTarjeta.TabStop = True
        Me.radioTarjeta.Text = "Tarjeta"
        Me.radioTarjeta.UseVisualStyleBackColor = True
        '
        'labelMonto
        '
        Me.labelMonto.AutoSize = True
        Me.labelMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMonto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelMonto.Location = New System.Drawing.Point(279, 140)
        Me.labelMonto.Name = "labelMonto"
        Me.labelMonto.Size = New System.Drawing.Size(115, 24)
        Me.labelMonto.TabIndex = 3
        Me.labelMonto.Text = "Digite Monto"
        Me.labelMonto.Visible = False
        '
        'textMonto
        '
        Me.textMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textMonto.Location = New System.Drawing.Point(417, 135)
        Me.textMonto.Name = "textMonto"
        Me.textMonto.Size = New System.Drawing.Size(174, 29)
        Me.textMonto.TabIndex = 4
        Me.textMonto.Visible = False
        '
        'factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(928, 471)
        Me.Controls.Add(Me.textMonto)
        Me.Controls.Add(Me.labelMonto)
        Me.Controls.Add(Me.radioTarjeta)
        Me.Controls.Add(Me.radioFectivo)
        Me.Controls.Add(Me.comboTarjeta)
        Me.Name = "factura"
        Me.Text = "factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboTarjeta As ComboBox
    Friend WithEvents radioFectivo As RadioButton
    Friend WithEvents radioTarjeta As RadioButton
    Friend WithEvents labelMonto As Label
    Friend WithEvents textMonto As TextBox
End Class
