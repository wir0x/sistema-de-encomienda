Public Class Frm_HojaRuta

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_flota.LostFocus, txt_chofer.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_flota.GotFocus, txt_chofer.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub btn_flota_Click(sender As System.Object, e As System.EventArgs) Handles btn_flota.Click
        Dim frm As New Frm_ListaFlotas
        frm.ShowDialog()
    End Sub

    Private Sub btn_chofer_Click(sender As System.Object, e As System.EventArgs) Handles btn_chofer.Click
        Dim frm As New Frm_ListaChoferes
        frm.ShowDialog()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class