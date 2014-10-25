Imports LCD.CAD
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

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Me.txt_idpunto.Text <> "" Then
            Dim pun As New LCN.Puntos(Me.txt_idpunto.Text, Me.txt_descripcion.Text, Me.txt_instancia.Text, Me.txt_basededatos.Text, True, Now)

            If pun.Guardar Then
                MsgBox("Punto creado de forma correcta", MsgBoxStyle.Information, "ENCOMIENDAS")
            Else
                MsgBox("Error al intentar crear un nuevo punto", MsgBoxStyle.Critical, "ENCOMIENDAS")
            End If
        Else
            MsgBox("Debe especificar el ID del punto a crear", MsgBoxStyle.Critical, "ENCOMIENDAS")
            Me.txt_idpunto.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim punto As New LCN.Puntos
        Dim Ser As New LCD.CAD
        Me.Cursor = Cursors.WaitCursor
        If punto.ActualizarSevidoresPunto(Ser.db_host) = True Then
            MsgBox("Servidores actualidos de forma correcta!", MsgBoxStyle.Information, "ENCOMIENDAS")
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class