Public Class Frm_lista_ruta_Origen
    Public idSucursal As Integer
    Private Sub btm_Seleccionar_Click(sender As Object, e As EventArgs) Handles btm_Seleccionar.Click

    End Sub

    Sub CargarGrid()
        Dim TablaHoja As New DataTable
        Dim listaHojaR As New LCN.HojaRuta

        TablaHoja = listaHojaR.BusquedaHojaRutaOrigen(Me.idSucursal)


        If Not IsNothing(TablaHoja) Then
            Me.dgv_listaclientes.DataSource = TablaHoja
        Else
            For i As Integer = 0 To Me.dgv_listaclientes.Rows.Count - 1
                Me.dgv_listaclientes.Rows.RemoveAt(0)
            Next
        End If
        Me.dgv_listaclientes.ClearSelection()
    End Sub

    Private Sub Frm_lista_ruta_Origen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class