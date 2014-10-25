Imports LCN

Public Class Frm_HojaRuta

    Private Sub Frm_HojaRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDestino()
        CargarOrigen()
    End Sub

    Dim hr As New HojaRuta

    Sub CargarOrigen()
        Dim TablaPuntos As New DataTable
        TablaPuntos = hr.BusquedaPuntos()
        If Not IsNothing(TablaPuntos) Then
            Me.cbOrigen.DataSource = TablaPuntos
            Me.cbOrigen.DisplayMember = "Descripcion"
            Me.cbOrigen.ValueMember = "ID_Punto"
        Else
        End If
    End Sub

    Sub CargarDestino()
        Dim TablaPuntos As New DataTable
        TablaPuntos = hr.BusquedaPuntos()
        If Not IsNothing(TablaPuntos) Then
            Me.cbDestino.DataSource = TablaPuntos
            Me.cbDestino.DisplayMember = "Descripcion"
            Me.cbDestino.ValueMember = "ID_Punto"
        Else
        End If
    End Sub

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_Flota.LostFocus, txt_Chofer.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_Flota.GotFocus, txt_Chofer.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

    End Sub

    Public IDFlota As New Integer
    Private Sub Btn_Lista_Flotas_Click_1(sender As Object, e As EventArgs) Handles Btn_Lista_Flotas.Click
        Try
            Dim frm As New Frm_ListaFlotas
            frm.ShowDialog()
            Me.txt_Flota.Text = frm.Placa
            Me.IDFlota = frm.ID_Flota
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Ci As New Integer
    Private Sub BtnChoferes_Click(sender As Object, e As EventArgs) Handles BtnChoferes.Click
        Try
            Dim frm As New Frm_ListaChoferes
            frm.ShowDialog()
            Me.txt_Chofer.Text = frm.Nom
            Me.Ci = frm.Ci
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class