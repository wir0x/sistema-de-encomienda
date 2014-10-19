Public Class Frm_ListaRutas



    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PierdeFoco(sender As System.Object, e As System.EventArgs) Handles cmb_ruta.LostFocus

    End Sub

    Private Sub AgarraFoco(sender As System.Object, e As System.EventArgs) Handles cmb_ruta.GotFocus

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class