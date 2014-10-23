Public Class Encomienda_año
    Inherits LCD.CAD
#Region "ATRIBUTOS"
    Private _id_enc_a As Integer
    Private _ano As Integer
    Private _corelativo As Integer
#End Region

#Region "PROPIEDADES"
    Public Property id_enc_a() As Integer
        Get
            Return _id_enc_a
        End Get
        Set(ByVal value As Integer)
            _id_enc_a = value
        End Set
    End Property
    Public Property ano() As Integer
        Get
            Return _ano
        End Get
        Set(ByVal value As Integer)
            _ano = value
        End Set
    End Property
    Public Property corelativo() As Integer
        Get
            Return _corelativo
        End Get
        Set(ByVal value As Integer)
            _corelativo = value
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
        Me.id_enc_a = id_enc_a
        Me.ano = ano
        Me.corelativo = corelativo
    End Sub
    Public Function Obtenercodigo(ByVal año As Integer) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("generar_nroguia")
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

#End Region

End Class