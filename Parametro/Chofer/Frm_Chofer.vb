Public Class Frm_Chofer

    Public nuevo As New Boolean
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
        If txt_nrodoc.Text.Length > 0 And txt_nombre.Text.Length > 0 And txt_direccion.Text.Length > 0 And txt_telefono.Text.Length > 0 Then
            Chof.Guardar()
            txt_nrodoc.Clear()
            txt_nombre.Clear()
            txt_telefono.Clear()
            txt_direccion.Clear()
            MsgBox("Chofer guardado de forma correcta!", vbInformation, "DANIEL ROMERO")
        Else
            MsgBox("Faltan Campos Obligatorios", MsgBoxStyle.Critical)
            If txt_nrodoc.Text.Length = 0 Then
                txt_nrodoc.Focus()
            ElseIf txt_nombre.Text.Length = 0 Then
                txt_nombre.Focus()
            ElseIf txt_direccion.Text.Length = 0 Then
                txt_direccion.Focus()
            ElseIf txt_telefono.Text.Length = 0 Then
                txt_telefono.Focus()
            End If
        End If
    End Sub

    Private Sub Frm_Chofer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If nuevo = True Then
            Me.Llenar_Ubicacion()
        End If
    End Sub

    Sub Llenar_Ubicacion()
        Dim Tabla As New DataTable
        Dim Punto As New LCN.Puntos

        Tabla = Punto.Obtener(1, "")
        Me.cmbUbicacion.DataSource = Tabla
        Me.cmbUbicacion.ValueMember = "ID_Punto"
        Me.cmbUbicacion.DisplayMember = "Descripcion"
    End Sub

    Private Sub txt_nrodoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nrodoc.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class