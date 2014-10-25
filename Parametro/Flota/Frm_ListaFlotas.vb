Public Class Frm_ListaFlotas

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_buscar.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub
    Sub CargarGrid(ByVal Estado As Boolean, ByVal Nombre As String)
        Dim TablaFlota As New DataTable
        Dim Flo As New LCN.Flota

        TablaFlota = Flo.Obtener(Nombre, Estado)


        If Not IsNothing(TablaFlota) Then
            Me.dgFlotas.DataSource = TablaFlota
        Else
            For i As Integer = 0 To Me.dgFlotas.Rows.Count - 1
                Me.dgFlotas.Rows.RemoveAt(0)
            Next
        End If
        Me.dgFlotas.ClearSelection()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_buscar.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub
    Private Sub dgFlotas_MouseDown(sender As Object, e As MouseEventArgs) Handles dgFlotas.MouseDown
        If e.Button = MouseButtons.Right Then
            With Me.dgFlotas
                Dim Hitest As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                If Hitest.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = .Rows(Hitest.RowIndex).Cells(Hitest.ColumnIndex)
                    .ContextMenuStrip = Me.ContextMenuStrip1
                End If
            End With
        Else
            Me.dgFlotas.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Frm_ListaFlotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbEstado.SelectedIndex = 1
    End Sub

    Private Sub cmbEstado_GotFocus(sender As Object, e As EventArgs) Handles cmbEstado.GotFocus
        Me.cmbEstado.BackColor = Color.Cyan
    End Sub

    Private Sub cmbEstado_LostFocus(sender As Object, e As EventArgs) Handles cmbEstado.LostFocus
        Me.cmbEstado.BackColor = Color.White
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        Me.CargarGrid(Me.cmbEstado.SelectedIndex, Me.txt_buscar.Text)
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Me.CargarGrid(Me.cmbEstado.SelectedIndex, Me.txt_buscar.Text)
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim frm As New Frm_Flota
        frm.ShowDialog()
        Me.CargarGrid(True, "")
    End Sub

    Public Placa As String = ""
    Public ID_Flota As New Integer

    Private Sub dgFlotas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFlotas.CellDoubleClick
        MsgBox("ok")
        If Me.dgFlotas.CurrentRow.Selected = False Then
            Me.Placa = Me.dgFlotas.CurrentRow.Cells("Pla").Value
            Me.ID_Flota = Me.dgFlotas.CurrentRow.Cells("ID").Value
            Me.Close()
        End If
    End Sub

    Private Sub tsmiModificar_Click(sender As Object, e As EventArgs) Handles tsmiModificar.Click

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim pun As New LCN.Puntos
        Dim con As New LCD.CAD
        Me.Cursor = Cursors.WaitCursor
        If pun.ActualizarSevidoresPunto(con.db_host) Then
            MsgBox("Flotas Actualizadas de forma correcta!", MsgBoxStyle.Information, "ENCOMIENDAS")
        End If
        Me.Cursor = Cursors.Default

    End Sub
End Class