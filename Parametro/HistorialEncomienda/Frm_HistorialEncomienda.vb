Public Class Frm_HistorialEncomienda

    Private Sub btn_guardar_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub btn_cancelar_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Lista_Flotas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Lista_Flotas_Click_1(sender As Object, e As EventArgs)
        Dim frm As New Frm_ListaRutas
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Frm_ListaRutas
        frm.ShowDialog()
    End Sub
End Class