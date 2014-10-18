Public Class Frm_Punto

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_idpunto.LostFocus, txt_instancia.LostFocus, txt_basededatos.LostFocus, txt_descripcion.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_idpunto.GotFocus, txt_instancia.GotFocus, txt_basededatos.GotFocus, txt_descripcion.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub


    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class