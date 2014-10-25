Public Class MDIPrincipal

    Private Sub AgregarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Dim frm As New Frm_Parametro
        frm.ShowDialog()
    End Sub

    Private Sub TiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub NuevaEncomiendaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaEncomiendaToolStripMenuItem.Click
        Dim frm As New Frm_Encomienda
        frm.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        Dim frm As New Frm_Cliente
        frm.ShowDialog()
    End Sub

    Private Sub IniciarSesiónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IniciarSesiónToolStripMenuItem.Click
        Dim frm As New Frm_Login
        frm.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem1.Click
        Dim frm As New Frm_Usuario
        frm.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem3.Click
        Dim frm As New Frm_Chofer
        frm.ShowDialog()
    End Sub

    Private Sub NuevaFlotaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New Frm_Flota
        frm.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem2.Click
        Dim frm As New Frm_Punto
        frm.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem6.Click
        Dim frm As New Frm_HojaRuta
        frm.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem5.Click
        Dim frm As New Frm_TipoUsuario
        frm.ShowDialog()
    End Sub

    Private Sub AgregarToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem4.Click
        Dim frm As New Frm_Permisos
        frm.ShowDialog()
    End Sub

    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        Dim frm As New Frm_ListaClientes
        frm.ShowDialog()
    End Sub

    Private Sub MDIPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tss_fecha.Text = Date.Now()
        Timer1.Start()
    End Sub

    Private Sub ListaDeFlotasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New Frm_ListaFlotas
        frm.ShowDialog()
    End Sub

    Private Sub ListaDeChoferesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeChoferesToolStripMenuItem.Click
        Dim frm As New Frm_ListaChoferes
        frm.ShowDialog()
    End Sub

    Private Sub ListaDeUsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeUsuariosToolStripMenuItem.Click
        Dim frm As New Frm_ListaUsuarios
        frm.ShowDialog()
    End Sub

    Private Sub ConToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConToolStripMenuItem.Click
        Dim frm As New Frm_Confirmar
        frm.ShowDialog()
    End Sub

    Private Sub NuevaFlotaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles NuevaFlotaToolStripMenuItem1.Click
        Dim frm As New Frm_Flota
        frm.ShowDialog()
    End Sub

    Private Sub ListaFlotasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaFlotasToolStripMenuItem.Click
        Dim frm As New Frm_ListaFlotas
        frm.ShowDialog()
    End Sub

    'Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
    '    tss_fecha.Text = Date.Now()
    'End Sub

    Private Sub HistorialEncomiendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialEncomiendaToolStripMenuItem.Click
        Dim frm As New Frm_HistorialEncomienda
        frm.ShowDialog()
    End Sub
End Class