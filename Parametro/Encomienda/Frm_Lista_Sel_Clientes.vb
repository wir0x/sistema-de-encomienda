Public Class Frm_Lista_Sel_Clientes

    Public Cliente As String = ""
    Public ID_CLiente As String = ""
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
        Me.CargarGrid(True, Me.txt_buscar.Text)
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Me.CargarGrid(True, Me.txt_buscar.Text)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub dgv_listaclientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaclientes.CellDoubleClick
        If Me.dgv_listaclientes.CurrentRow.Selected = True Then
            Me.Cliente = Me.dgv_listaclientes.CurrentRow.Cells("Nombre").Value
            Me.ID_CLiente = Me.dgv_listaclientes.CurrentRow.Cells("NroDoc").Value
            Me.Close()
        End If
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
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click

    End Sub

    Private Sub btm_Seleccionar_Click(sender As Object, e As EventArgs) Handles btm_Seleccionar.Click
      
    End Sub

    Private Sub dgv_listaclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaclientes.CellContentClick

    End Sub
End Class