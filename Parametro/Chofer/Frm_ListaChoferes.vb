Imports LCN

Public Class Frm_ListaChoferes

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles cmb_estado.LostFocus, txt_buscar.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles cmb_estado.GotFocus, txt_buscar.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub dgv_parametro_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Choferes.CellContentClick

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Frm_ListaChoferes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_estado.SelectedIndex = 1
        Me.Llenar_dgChoferes(Me.txt_buscar.Text, Me.cmb_estado.SelectedIndex)
    End Sub

    Sub Llenar_dgChoferes(ByVal Nombre As String, ByVal Activo As Integer)
        Try
            Dim Chof As New LCN.Chofer
            Dim Tabla As New DataTable


            Tabla = Chof.Busqueda(Nombre, Activo)

            If Not IsNothing(Tabla) Then
                Me.dgv_Choferes.DataSource = Tabla
                Me.dgv_Choferes.ClearSelection()
            Else
                For i As Integer = 0 To Me.dgv_Choferes.RowCount - 1
                    Me.dgv_Choferes.Rows.RemoveAt(0)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmb_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_estado.SelectedIndexChanged

        Me.Llenar_dgChoferes(Me.txt_buscar.Text, Me.cmb_estado.SelectedIndex)
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim frm As New Frm_Chofer
        frm.ShowDialog()
        Me.Llenar_dgChoferes(Me.txt_buscar.Text, Me.cmb_estado.SelectedIndex)
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Me.Llenar_dgChoferes(Me.txt_buscar.Text, Me.cmb_estado.SelectedIndex)
    End Sub

    Private Sub dgv_Choferes_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Choferes.MouseDown
        If cmb_estado.Text = "ACTIVOS" Then
            If e.Button = MouseButtons.Right Then
                With Me.dgv_Choferes
                    Dim Hitest As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)

                    If Hitest.Type = DataGridViewHitTestType.Cell Then
                        .CurrentCell = .Rows(Hitest.RowIndex).Cells(Hitest.ColumnIndex)
                        .ContextMenuStrip = Me.ContextMenuStrip1

                    End If
                End With
            Else
                Me.dgv_Choferes.ContextMenuStrip = Nothing
            End If
        Else
            Me.dgv_Choferes.ContextMenuStrip = Nothing
        End If
    End Sub

    Dim frm As New Frm_Chofer

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        frm.txt_nrodoc.Text = Me.dgv_Choferes.CurrentRow.Cells("NroDoc").Value
        frm.txt_nombre.Text = Me.dgv_Choferes.CurrentRow.Cells("Nombre").Value
        frm.txt_direccion.Text = Me.dgv_Choferes.CurrentRow.Cells("Direccion").Value
        frm.txt_telefono.Text = Me.dgv_Choferes.CurrentRow.Cells("Telefono").Value
        frm.cmbUbicacion.Text = (Me.dgv_Choferes.CurrentRow.Cells("Ubicacion").Value)
        frm.nuevo = False
        frm.ShowDialog()
        Me.Llenar_dgChoferes(Me.txt_buscar.Text, 1)
    End Sub

    Dim ch As New Chofer

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If vbYes = MsgBox("¿Está seguro que desea eliminar un registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then
            ch.NroDoc = Me.dgv_Choferes.CurrentRow.Cells("NroDoc").Value
            If ch.Eliminar() Then
                Me.Llenar_dgChoferes(Me.txt_buscar.Text, 1)
                MsgBox("Eliminado Satisfactoriamente", MsgBoxStyle.Information, "CHOFERES")
            Else
                MsgBox("Ocurrio algun problema", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Public Nom As String = ""
    Public Ci As New Integer

    Private Sub dgv_Choferes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Choferes.CellDoubleClick
        MsgBox("ok")
        If Me.dgv_Choferes.CurrentRow.Selected = False Then
            Me.Nom = Me.dgv_Choferes.CurrentRow.Cells("Nombre").Value
            Me.Ci = Me.dgv_Choferes.CurrentRow.Cells("NroDoc").Value
            Me.Close()
        End If
    End Sub
End Class