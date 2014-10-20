Public Class Frm_Encomienda

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_remitente.LostFocus, txt_destinatario.LostFocus, txt_ruta.LostFocus, txt_descripcion.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_remitente.GotFocus, txt_destinatario.GotFocus, txt_ruta.GotFocus, txt_descripcion.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub btn_remitente_Click(sender As Object, e As EventArgs) Handles btn_remitente.Click
        Try
            Dim frm As New Frm_ListaClientes
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_destinatario_Click(sender As Object, e As EventArgs) Handles btn_destinatario.Click
        Try
            Dim frm As New Frm_ListaClientes
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class