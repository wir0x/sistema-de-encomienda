Public Class Frm_ListaChoferes

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles cmb_estado.LostFocus, txt_buscar.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles cmb_estado.GotFocus, txt_buscar.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub dgv_parametro_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_parametro.CellContentClick

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class