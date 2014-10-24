Public Class Encomienda_año
    Inherits LCD.CAD
#Region "ATRIBUTOS"
    Private _ID_Encomienda As Integer
    Private _Año As Integer
    Private _Correlativo As Integer
#End Region

#Region "PROPIEDADES"
    Public Property ID_Encomienda()
        Get
            Return _ID_Encomienda
        End Get
        Set(ByVal value)
            _ID_Encomienda = value
        End Set
    End Property

    Public Property Año() As Integer
        Get
            Return _Año
        End Get
        Set(ByVal value As Integer)
            _Año = value
        End Set
    End Property
    Public Property Correlativo() As Integer
        Get
            Return _Correlativo
        End Get
        Set(ByVal value As Integer)
            _Correlativo = value
        End Set
    End Property

#End Region

#Region "METODOS"

    Sub New()
        ' CONSTRUCTOR 1
    End Sub

    Public Sub New(ByVal id_enc_a As Integer,
                   ByVal ano As Integer,
                   ByVal corelativo As Integer)
        'CONSTRUCTOR 2
        Me.ID_Encomienda = id_enc_a
        Me.Año = ano
        Me.Correlativo = corelativo
    End Sub
    Public Function Obtenercodigo(ByVal año As Integer) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("ID_CorrelativoGet")
        AddParametro("@año", año)

        If EjecutarTransaccion() = True Then
            If getTabla(Tabla) = True Then
                Return Tabla
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If

    End Function

    Public Function ActualizarCorrelativo(ByVal Año As Integer) As Boolean
        Try

            IniciarSP("ID_CorrelativoUpdate")
            AddParametro("@Año", Año)

            If EjecutarTransaccion() = True Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error en : " & ex.Message & vbNewLine & "Desde : " & ex.Source & ex.ToString, MsgBoxStyle.Critical, "DANIEL ROMERO BACOTICH")
            Return False
        End Try
    End Function


#End Region

End Class