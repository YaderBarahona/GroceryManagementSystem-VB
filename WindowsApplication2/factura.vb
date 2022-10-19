Public Class factura
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radioFectivo.CheckedChanged
        labelMonto.Visible = True
        textMonto.Visible = True
        comboTarjeta.Visible = False
    End Sub

    Private Sub radioTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles radioTarjeta.CheckedChanged
        labelMonto.Visible = False
        textMonto.Visible = False
        comboTarjeta.Visible = True
    End Sub
End Class