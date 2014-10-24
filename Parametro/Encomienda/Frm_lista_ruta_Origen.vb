Public Class Frm_lista_ruta_Origen
    Public idSucursal As Integer
    Public id_hoja_ruta As Integer
    Public peso_dis_h As Double
    Public vol_dis_h As Double
    Public ori_des As String
    Private Sub btm_Seleccionar_Click(sender As Object, e As EventArgs) Handles btm_Seleccionar.Click

    End Sub

    Sub CargarGrid()
        Dim TablaHoja As New DataTable
        Dim listaHojaR As New LCN.HojaRuta

        TablaHoja = listaHojaR.BusquedaHojaRutaOrigen(Me.idSucursal)


        If Not IsNothing(TablaHoja) Then
            Me.dgv_listaHojaR.DataSource = TablaHoja
        Else
            For i As Integer = 0 To Me.dgv_listaHojaR.Rows.Count - 1
                Me.dgv_listaHojaR.Rows.RemoveAt(0)
            Next
        End If
        Me.dgv_listaHojaR.ClearSelection()
    End Sub

    Private Sub Frm_lista_ruta_Origen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarGrid()
    End Sub

    Private Sub dgv_listaHojaR_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaHojaR.CellDoubleClick
        If Me.dgv_listaHojaR.CurrentRow.Selected = True Then
            Me.id_hoja_ruta = Me.dgv_listaHojaR.CurrentRow.Cells("ID_HojaRuta").Value
            Me.peso_dis_h = Me.dgv_listaHojaR.CurrentRow.Cells("PesoDisponible").Value
            Me.vol_dis_h = Me.dgv_listaHojaR.CurrentRow.Cells("VolumenDisponible").Value
            Me.ori_des = Me.dgv_listaHojaR.CurrentRow.Cells("PuO").Value + " - " + Me.dgv_listaHojaR.CurrentRow.Cells("PuD").Value
            Me.Close()
        End If
    End Sub
End Class