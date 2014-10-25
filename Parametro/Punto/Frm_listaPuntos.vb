Public Class Frm_listaPuntos

    Private Sub Frm_listaPuntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Llenar_dgPuntos(True, "")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim pun As New LCN.Puntos
        Dim con As New LCD.CAD
        Me.Cursor = Cursors.WaitCursor
        If pun.ActualizarSevidoresPunto(con.db_host) Then
            MsgBox("Actualizado de forma correcta!", MsgBoxStyle.Information, "ENCOMIENDAS")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim frm As New Frm_Punto
        frm.ShowDialog()
        Me.Llenar_dgPuntos(Me.cmb_estado.SelectedIndex, Me.txt_buscar.Text)
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Me.Llenar_dgPuntos(Me.cmb_estado.SelectedIndex, Me.txt_buscar.Text)
    End Sub

    Private Sub cmb_estado_GotFocus(sender As Object, e As EventArgs) Handles cmb_estado.GotFocus
        Me.cmb_estado.BackColor = Color.Cyan

    End Sub

    Private Sub cmb_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_estado.SelectedIndexChanged

    End Sub

    Private Sub cmb_estado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_estado.SelectionChangeCommitted
        Me.Llenar_dgPuntos(Me.cmb_estado.SelectedIndex, Me.txt_buscar.Text)
    End Sub
    Sub Llenar_dgPuntos(ByVal Activo As Boolean, ByVal Descripcion As String)
        Dim pun As New LCN.Puntos
        Dim Tabla As New DataTable

        Tabla = pun.Obtener(Activo, Descripcion)

        If Not IsNothing(Tabla) Then
            Me.dgv_parametro.DataSource = Tabla
            Me.dgv_parametro.ClearSelection()
        Else
            For i As Integer = 0 To Me.dgv_parametro.RowCount - 1
                Me.dgv_parametro.Rows.RemoveAt(0)
            Next
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class