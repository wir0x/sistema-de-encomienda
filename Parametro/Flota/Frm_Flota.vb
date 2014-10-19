Public Class Frm_Flota
    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_id.LostFocus, txt_marca.LostFocus, txt_modelo.LostFocus, txt_anio.LostFocus, txt_placa.LostFocus, nud_pescarga.LostFocus, nud_volcarga.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_id.GotFocus, txt_marca.GotFocus, txt_modelo.GotFocus, txt_anio.GotFocus, txt_placa.GotFocus, nud_pescarga.GotFocus, nud_volcarga.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class