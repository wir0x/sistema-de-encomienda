Imports System.Data
Imports System.Data.SqlClient

Public Class CAD

    Private db_host As String = "ENVY\SQL08R2_ENVY"
    Private db_name As String = "BDEncomiendas"
    Private db_user As String = "sa"
    Private db_pass As String = "chkdsk"
    Private cnx As New SqlConnection
    Private Comando As New SqlCommand


    Public Function Conectar() As Boolean
        Dim band As Boolean = False

        Try
            cnx.ConnectionString = "Data Source =" & db_host &
                                    "; initial catalog =" & db_name &
                                    "; user id=" & db_user &
                                    "; Password=" & db_pass & ""

            cnx.Open()
            band = True

        Catch ex As Exception
            MsgBox("Error al Conectar ::= " & ex.Message)
            Return False
            Exit Function

        End Try
        Return band

    End Function


    Public Function Desconectar() As Boolean
        Dim band As Boolean = False
        Try
            SqlConnection.ClearPool(cnx)
            cnx.Close()
            band = True
        Catch ex As Exception
            MsgBox("Error al Desconectar ::= " & ex.Message)
        End Try
        Return band
    End Function


    Public Function getCnx() As SqlConnection
        Return cnx
    End Function


    Sub AddParametro(ByVal Nom As String, ByVal Valor As String)
        Dim Param As New SqlParameter
        Param.ParameterName = Nom
        Param.Value = Valor
        comando.Parameters.Add(Param)
    End Sub

    Sub AddParametro1(ByVal Comando As SqlCommand, ByVal Nom As String, ByVal Valor As String)
        Dim Param As New SqlParameter
        Param.ParameterName = Nom
        Param.Value = Valor
        Comando.Parameters.Add(Param)
    End Sub


    Public Function ComenzarTransaccion() As SqlTransaction
        Conectar()
        cnx = getCnx()
        Return cnx.BeginTransaction()
        Desconectar()
    End Function


    Sub IniciarSP(ByVal SP As String)
        Comando = New SqlCommand(SP, getCnx)
        Comando.CommandType = CommandType.StoredProcedure
        Comando.CommandText = SP
    End Sub

    Public Function EjecutarTransaccion() As Boolean

        Dim band As Boolean = False

        If Conectar() = True Then
            Dim transaccion As SqlTransaction
            transaccion = cnx.BeginTransaction
            Comando.Connection = cnx
            Comando.Transaction = transaccion

            Try
                Comando.ExecuteNonQuery()
                transaccion.Commit()
                band = True
                EjecutarTransaccion = band

            Catch ex As Exception
                MsgBox("El Error es :: " & ex.Message)
                Try
                    transaccion.Rollback()
                    Return band
                Catch ex2 As Exception
                    MsgBox("El Error es :: " & ex2.Message)
                    Return band
                End Try

            Finally
                Desconectar()
            End Try
        Else
            Return band
        End If

    End Function


    Public Function getTabla(ByRef Tabla As DataTable) As Boolean
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim MensajeError As String
        Try

            adapter.SelectCommand = Comando
            adapter.Fill(ds)
            If adapter.Fill(ds, "tabla") > 0 Then
                Tabla = ds.Tables("tabla")
                getTabla = True

            Else
                getTabla = False
            End If

        Catch ex As Exception
            'MensajeError = "Error. " + ex.Message + ". Desde " + ex.Source
            MensajeError = "No hay Datos para ese criterio de búsqueda"
            MsgBox(MensajeError, MsgBoxStyle.Critical, "Sistema RB")
            Return Nothing
        End Try

    End Function


    Public Function getTabla2(ByRef Tabla As DataTable) As Boolean
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim MensajeError As String
        Try

            adapter.SelectCommand = Comando
            adapter.Fill(ds)
            If adapter.Fill(ds, "tabla") >= 0 Then
                Tabla = ds.Tables("tabla")
                getTabla2 = True
            Else
                getTabla2 = False
            End If

        Catch ex As Exception
            'MensajeError = "Error. " + ex.Message + ". Desde " + ex.Source
            MensajeError = "No hay Datos para ese criterio de búsqueda"
            MsgBox(MensajeError, MsgBoxStyle.Critical, "Sistema RB")
            Return Nothing
        End Try
    End Function

End Class