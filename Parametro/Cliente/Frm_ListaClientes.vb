Public Class Frm_ListaClientes

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles cmb_estado.LostFocus, txt_buscar.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles cmb_estado.GotFocus, txt_buscar.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub


    Private Sub ToolStripStatusLabel2_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub Frm_ListaClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub
End Class