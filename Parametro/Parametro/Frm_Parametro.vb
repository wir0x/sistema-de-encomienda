Imports System.Globalization


Public Class Frm_Parametro


    '*Instancia de la Clase Parametro
    Dim parametro As New LCN.Parametro

    '*Variable que verifica si va a guardar o Actualizar
    Dim nuevo As Boolean = True



#Region "Metodos Auxiliares"


    '*Inicio ConfiguracionRegional*
    Sub configuracionRegional()

        Dim myCulture As CultureInfo
        myCulture = Application.CurrentCulture.Clone()
        myCulture.NumberFormat.NumberDecimalSeparator = "."
        myCulture.NumberFormat.NumberGroupSeparator = ","
        Application.CurrentCulture = myCulture

    End Sub '*Fin ConfiguracionRegional*



    '*Inicio LimpiarFormulario*
    Sub LimpiarFormulario()

        nud_precioMin.Value = vbEmpty
        nud_precioKil.Value = vbEmpty
        nud_precioVol.Value = vbEmpty

    End Sub '*Fin LimpiarFormulario*



    '*Inicio CrearParametro*
    Sub CrearParametro()

        parametro.PrecioMin = nud_precioMin.Value
        parametro.PrecioKil = nud_precioKil.Value
        parametro.PrecioVol = nud_precioVol.Value

        If parametro.CreateParametro() Then
            MsgBox("Parametro guardado existosamemten!!!", MsgBoxStyle.Information)

        Else
            MsgBox("Salio algo mal", MsgBoxStyle.Critical)

        End If

        LimpiarFormulario()

    End Sub '*Fin CrearParametro*


    '*Inicio Actualizar Parametro
    Sub ActualizarParametro()

        parametro.PrecioMin = nud_precioMin.Value
        parametro.PrecioKil = nud_precioKil.Value
        parametro.PrecioVol = nud_precioVol.Value
        parametro.Activo = chb_activo.Checked

        If parametro.UpdateParametro() Then
            MsgBox("Parametro Actualizado Existosamente", MsgBoxStyle.Information)
        Else
            MsgBox("Salio algo mal", MsgBoxStyle.Critical)
        End If

    End Sub '*Fin Actualizar Parametro


    '*Inicio Procedimiento CargarDataGrid
    Sub CargarDataGrid()

        Dim tablaParametro As New DataTable
        tablaParametro = parametro.ReadAllParameters()

        If Not IsNothing(tablaParametro) Then
            Me.dgv_parametro.DataSource = tablaParametro
        Else
            For i As Integer = 0 To Me.dgv_parametro.Rows.Count - 1
                Me.dgv_parametro.Rows.RemoveAt(0)
            Next
        End If
    End Sub 'Fin Procedimiento CargarDataGrid

#End Region


    '*Formulario Parametro Evento Load
    Private Sub Frm_Parametro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDataGrid()
        configuracionRegional()
    End Sub


    '*Boton Cancelar Evento Click
    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub


    '*DataGridView Parametro Evento MouseDown
    Private Sub DataGridView1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgv_parametro.MouseDown

        If e.Button = MouseButtons.Right Then
            With Me.dgv_parametro
                Dim Hitest As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)

                If Hitest.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = .Rows(Hitest.RowIndex).Cells(Hitest.ColumnIndex)
                    .ContextMenuStrip = Me.ContextMenuStrip1

                End If
            End With
        Else
            Me.dgv_parametro.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub


    '*ToolStripMenu Modificar Evento Click
    Private Sub ModificarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarToolStripMenuItem.Click

        If Me.dgv_parametro.CurrentRow.Cells("Activo").Value Then
            nud_precioMin.Value = Me.dgv_parametro.CurrentRow.Cells("PrecioMinimo").Value
            nud_precioKil.Value = Me.dgv_parametro.CurrentRow.Cells("PrecioKilo").Value
            nud_precioVol.Value = Me.dgv_parametro.CurrentRow.Cells("PrecioVolumen").Value
            chb_activo.Checked = Me.dgv_parametro.CurrentRow.Cells("Activo").Value
            nuevo = False
        Else
            MsgBox("No puedes modificar un Parametro no activo", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btn_guardar_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        If nuevo Then
            CrearParametro()

        Else
            ActualizarParametro()
        End If

        CargarDataGrid()
        LimpiarFormulario()
    End Sub
End Class