Imports LCN

Imports System.Data.SqlClient
Public Class Frm_Encomienda
    Private idsucursal As Integer
    Private idremitente As String
    Private iddestinatario As String
    Private pre_minimo As Integer
    Private pre_kilo As Integer
    Private pre_vol As Integer
    Private kilo As Double
    Private volumen As Double

    Private Sub traer_parametros()
        Dim tablaParametro As DataTable
        Dim param As New LCN.Parametro

        tablaParametro = param.ReadAllParameters()

        Me.pre_minimo = tablaParametro.Rows(0).Item(1)
        Me.pre_kilo = tablaParametro.Rows(0).Item(2)
        Me.pre_vol = tablaParametro.Rows(0).Item(3)

        Me.nud_monto.Value = Me.pre_minimo
    End Sub

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
        Me.traer_parametros()
        Me.cal_kilo()
        Me.cal_vol()
        Me.cal_precio()
    End Sub

    Private Sub PierdeFoco(sender As Object, e As EventArgs) Handles txt_ruta.LostFocus, txt_remitente.LostFocus, txt_destinatario.LostFocus, txt_descripcion.LostFocus

    End Sub

    Private Sub AgarraFoco(sender As Object, e As EventArgs) Handles txt_ruta.GotFocus, txt_remitente.GotFocus, txt_destinatario.GotFocus, txt_descripcion.GotFocus

    End Sub
    Private Sub cal_precio()
        Dim pre As Double
        pre = Me.volumen + Me.kilo
        If pre >= Me.pre_minimo Then
            Me.nud_monto.Value = pre
        Else
            Me.nud_monto.Value = Me.pre_minimo
        End If
    End Sub
    Private Sub cal_vol()
        Dim vol As Double
        vol = (((Me.Num_alto.Value * Me.Num_ancho.Value * Me.Num_base.Value) / 100) / 100) / 100
        Me.nud_vol.Value = vol
        Me.volumen = vol * Me.pre_vol
    End Sub
    Private Sub cal_kilo()
        kilo = Me.nud_peso.Value * Me.pre_kilo
    End Sub

    Private Sub Num_alto_ValueChanged(sender As Object, e As EventArgs) Handles Num_alto.ValueChanged
        Me.cal_vol()
        Me.cal_precio()
    End Sub

    Private Sub Num_ancho_ValueChanged(sender As Object, e As EventArgs) Handles Num_ancho.ValueChanged
        Me.cal_vol()
        Me.cal_precio()
    End Sub

    Private Sub Num_base_ValueChanged(sender As Object, e As EventArgs) Handles Num_base.ValueChanged
        Me.cal_vol()
        Me.cal_precio()
    End Sub

    Private Sub MessageBox(p1 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub nud_peso_ValueChanged(sender As Object, e As EventArgs) Handles nud_peso.ValueChanged
        Me.cal_kilo()
        Me.cal_precio()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Dim TablaGuia As DataTable
        Dim Guia As New LCN.Encomienda_año
        Dim Codigo As Integer

        TablaGuia = Guia.Obtenercodigo(19)
        Codigo = TablaGuia.Rows(0).Item(0).ToString
        Guia.ActualizarCorrelativo(19)

        MsgBox(codigo)
    End Sub
End Class