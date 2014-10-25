Public Class frmListaEncomiendas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pun As New LCN.Puntos
        Dim con As New LCD.CAD
        Me.Cursor = Cursors.WaitCursor
        If pun.migrarencomiendas(con.db_host) Then
            MsgBox("Encomiendas migradas de forma correcta!", MsgBoxStyle.Information, "ENCOMIENDAS")
        End If
        Me.Llenar_dgEncomiendas("25/10/2014", "25/10/2014")
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmListaEncomiendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Llenar_dgEncomiendas("25/10/2014", "25/10/2014")

    End Sub

    Sub Llenar_dgEncomiendas(ByVal FechaInicio As Date, ByVal FechaFin As Date)
        Try
            Dim Encom As New LCN.Encomienda
            Dim Tabla As New DataTable

            FechaInicio = FechaInicio.Date + " 00:00:00"
            FechaFin = FechaFin.Date + " 23:59:59"

            Tabla = Encom.encomiendasGetByDia(FechaInicio, FechaFin)

            If Not IsNothing(Tabla) Then
                Me.dg_Encomiendas.DataSource = Tabla
                Me.dg_Encomiendas.ClearSelection()

            Else
                For i As Integer = 0 To Me.dg_Encomiendas.RowCount - 1
                    Me.dg_Encomiendas.Rows.RemoveAt(0)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
     
    End Sub
End Class