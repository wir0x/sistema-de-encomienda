Public Class Form1

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles cmb_ruta.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles cmb_ruta.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PierdeFoco(sender As System.Object, e As System.EventArgs) Handles cmb_ruta.LostFocus

    End Sub

    Private Sub AgarraFoco(sender As System.Object, e As System.EventArgs) Handles cmb_ruta.GotFocus

    End Sub
End Class