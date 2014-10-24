Public Class Frm_Chofer
    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_nrodoc.LostFocus, txt_nombre.LostFocus, txt_telefono.LostFocus, txt_direccion.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_nrodoc.GotFocus, txt_nombre.GotFocus, txt_telefono.GotFocus, txt_direccion.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim Chof As New LCN.Chofer(Me.txt_nombre.Text, Me.txt_nrodoc.Text, Me.txt_direccion.Text, Me.txt_telefono.Text, True, Now, Me.cmbUbicacion.SelectedValue)
        Chof.Guardar()
        MsgBox("Chofer guardado de forma correcta!", vbInformation, "DANIEL ROMERO")
    End Sub

    Private Sub Frm_Chofer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Llenar_Ubicacion()
    End Sub

    Sub Llenar_Ubicacion()
        Dim Tabla As New DataTable
        Dim Punto As New LCN.Puntos

        Tabla = Punto.Obtener(1, "")
        Me.cmbUbicacion.DataSource = Tabla
        Me.cmbUbicacion.ValueMember = "ID_Punto"
        Me.cmbUbicacion.DisplayMember = "Descripcion"
    End Sub
End Class