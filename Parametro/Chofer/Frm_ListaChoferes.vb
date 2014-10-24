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
End Class