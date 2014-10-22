Imports LCN
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

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try

            Dim Flota As New Flota(0, Me.txt_marca.Text, Me.txt_modelo.Text, Me.txt_anio.Text, Me.txt_placa.Text, Me.nud_volcarga.Text, Me.nud_pescarga.Text, True, DateTime.Now)

            If Flota.Guardar() = True Then
                MsgBox("ok")
            Else
                MsgBox("no")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class