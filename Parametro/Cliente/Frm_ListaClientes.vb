Public Class Frm_ListaClientes

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_buscar.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_buscar.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub


    Sub CargarGrid(ByVal Estado As Boolean, ByVal Nombre As String)
        Dim TablaClientes As New DataTable
        Dim cli As New LCN.Clientes

        TablaClientes = cli.Obtener(Estado, Nombre)


        If Not IsNothing(TablaClientes) Then
            Me.dgv_listaclientes.DataSource = TablaClientes
        Else
            For i As Integer = 0 To Me.dgv_listaclientes.Rows.Count - 1
                Me.dgv_listaclientes.Rows.RemoveAt(0)
            Next
        End If
        Me.dgv_listaclientes.ClearSelection()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub Frm_ListaClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cmb_estado.SelectedIndex = 1
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim frm As New Frm_Cliente
        frm.ShowDialog()
        Me.CargarGrid(Me.cmb_estado.SelectedIndex, Me.txt_buscar.Text)
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Me.CargarGrid(Me.cmb_estado.SelectedIndex, Me.txt_buscar.Text)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim frm As New Frm_Cliente
        'frm.NroDoc_Anterior = Me.dgClientes.CurrentRow.Cells("NroDoc").Value
        frm.txt_nrodoc.Text = Me.dgv_listaclientes.CurrentRow.Cells("NroDoc").Value
        frm.txt_nombre.Text = Me.dgv_listaclientes.CurrentRow.Cells("Nombre").Value
        frm.txt_direccion.Text = Me.dgv_listaclientes.CurrentRow.Cells("Direccion").Value
        frm.txt_telefono.Text = Me.dgv_listaclientes.CurrentRow.Cells("Telefono").Value
        frm.cmb_estado.SelectedIndex = Me.dgv_listaclientes.CurrentRow.Cells("Activo").Value
        frm.actualizar = True
        frm.ShowDialog()
        Me.CargarGrid(Me.cmb_estado.SelectedIndex, Me.txt_buscar.Text)
    End Sub

    Private Sub dgv_listaclientes_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_listaclientes.MouseDown
        If e.Button = MouseButtons.Right Then
            With Me.dgv_listaclientes
                Dim Hitest As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                If Hitest.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = .Rows(Hitest.RowIndex).Cells(Hitest.ColumnIndex)
                    .ContextMenuStrip = Me.ContextMenuStrip1
                End If
            End With
        Else
            Me.dgv_listaclientes.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

    End Sub

    Private Sub cmb_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_estado.SelectedIndexChanged
        CargarGrid(Me.cmb_estado.SelectedIndex, Me.txt_buscar.Text)
    End Sub
End Class