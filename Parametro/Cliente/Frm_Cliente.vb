Public Class Frm_Cliente

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_nrodoc.LostFocus, txt_nombre.LostFocus, txt_telefono.LostFocus, txt_direccion.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_nrodoc.GotFocus, txt_nombre.GotFocus, txt_telefono.GotFocus, txt_direccion.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class