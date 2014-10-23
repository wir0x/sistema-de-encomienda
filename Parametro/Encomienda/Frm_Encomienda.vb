Public Class Frm_Encomienda
    Private idsucursal As Integer
    Private idremitente As String
    Private iddestinatario As String

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
            Dim frm As New Frm_Lista_Sel_Clientes
            frm.lbl_titulo.Text = "Lista de Remitentes"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_destinatario_Click(sender As Object, e As EventArgs) Handles btn_destinatario.Click
        Try
            Dim frm As New Frm_Lista_Sel_Clientes
            frm.lbl_titulo.Text = "Lista de Destinatarios"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lbl_datetime.Text = DateAndTime.Now
    End Sub

    Private Sub Frm_Encomienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbl_datetime.Text = DateAndTime.Now
    End Sub

    Private Sub PierdeFoco(sender As Object, e As EventArgs) Handles txt_ruta.LostFocus, txt_remitente.LostFocus, txt_destinatario.LostFocus, txt_descripcion.LostFocus

    End Sub

    Private Sub AgarraFoco(sender As Object, e As EventArgs) Handles txt_ruta.GotFocus, txt_remitente.GotFocus, txt_destinatario.GotFocus, txt_descripcion.GotFocus

    End Sub
    Private Sub cal_vol()
        Dim volumen As Double
        volumen = Me.Num_alto.Value * Me.Num_ancho.Value * Num_base.Value
        Me.nud_vol.Value = volumen
    End Sub

    Private Sub Num_alto_ValueChanged(sender As Object, e As EventArgs) Handles Num_alto.ValueChanged
        Me.cal_vol()
    End Sub

    Private Sub Num_ancho_ValueChanged(sender As Object, e As EventArgs) Handles Num_ancho.ValueChanged
        Me.cal_vol()
    End Sub

    Private Sub Num_base_ValueChanged(sender As Object, e As EventArgs) Handles Num_base.ValueChanged
        Me.cal_vol()
    End Sub
End Class