Public Class Encomienda
    Inherits LCD.CAD
#Region "ATRIBUTOS"
    Private _ID_Encomienda As String
    Private _Fecha As DateTime
    Private _NroDoc_Remitente As String
    Private _NroDoc_Destinatario As String
    Private _ID_HojaRuta As Integer
    Private _Descripcion As String
    Private _Fragil As Boolean
    Private _Volumen As Double
    Private _Peso As Double
    Private _Monto As Double
    Private _Pagado As Boolean
    Private _Activo As Boolean
    Private _FechaAct As DateTime
#End Region

#Region "PROPIEDADES"
    Public Property ID_Encomienda() As String
        Get
            Return _ID_Encomienda
        End Get
        Set(ByVal value As String)
            _ID_Encomienda = value
        End Set
    End Property
    Public Property Fecha() As DateTime
        Get
            Return _Fecha
        End Get
        Set(ByVal value As DateTime)
            _Fecha = value
        End Set
    End Property
    Public Property NroDoc_Remitente() As String
        Get
            Return _NroDoc_Remitente
        End Get
        Set(ByVal value As String)
            _NroDoc_Remitente = value
        End Set
    End Property
    Public Property NroDoc_Destinatario() As String
        Get
            Return _NroDoc_Destinatario
        End Get
        Set(ByVal value As String)
            _NroDoc_Destinatario = value
        End Set
    End Property
    Public Property ID_HojaRuta() As Integer
        Get
            Return _ID_HojaRuta
        End Get
        Set(ByVal value As Integer)
            _ID_HojaRuta = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property Fragil() As Boolean
        Get
            Return _Fragil
        End Get
        Set(ByVal value As Boolean)
            _Fragil = value
        End Set
    End Property
    Public Property Volumen() As Double
        Get
            Return _Volumen
        End Get
        Set(ByVal value As Double)
            _Volumen = value
        End Set
    End Property
    Public Property Peso() As Double
        Get
            Return _Peso
        End Get
        Set(ByVal value As Double)
            _Peso = value
        End Set
    End Property
    Public Property Monto() As Double
        Get
            Return _Monto
        End Get
        Set(ByVal value As Double)
            _Monto = value
        End Set
    End Property
    Public Property Pagado() As Boolean
        Get
            Return _Pagado
        End Get
        Set(ByVal value As Boolean)
            _Pagado = value
        End Set
    End Property
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property
    Public Property FechaAct() As DateTime
        Get
            Return _FechaAct
        End Get
        Set(ByVal value As DateTime)
            _FechaAct = value
        End Set
    End Property

#End Region

#Region "METODOS"

    Sub New()
        ' CONSTRUCTOR 1
    End Sub

    Public Sub New(ByVal ID_Encomienda As String,
                   ByVal Fecha As DateTime,
                   ByVal NroDoc_Remitente As String,
                   ByVal NroDoc_Destinatario As String,
                   ByVal ID_HojaRuta As Integer,
                   ByVal Fragil As Boolean,
                   ByVal Volumen As Double,
                   ByVal Peso As Double,
                   ByVal Monto As Double,
                   ByVal Pagado As Boolean,
                   ByVal Activo As Boolean,
                   ByVal fecha_act As DateTime)
        'CONSTRUCTOR 2
        Me.ID_Encomienda = ID_Encomienda
        Me.Fecha = Fecha
        Me.NroDoc_Remitente = NroDoc_Remitente
        Me.NroDoc_Destinatario = NroDoc_Remitente
        Me.ID_HojaRuta = ID_HojaRuta
        Me.Descripcion = Descripcion
        Me.Fragil = Fragil
        Me.Volumen = Volumen
        Me.Peso = Peso
        Me.Monto = Monto
        Me.Pagado = Pagado
        Me.Activo = Activo
        Me.FechaAct = fecha_act
    End Sub

    ''' <summary>
    ''' Guarda todos los datos de un cliente
    ''' </summary>
    Public Function Guardarencomienda(ByVal codenc As String, ByVal nrodocre As String, ByVal nrodocdes As String, ByVal idhojaru As Integer, ByVal des As String, ByVal fragil As Boolean, ByVal volum As Double, ByVal pes As Double, ByVal mont As Double, ByVal pag As Boolean, ByVal idusu As Integer) As Boolean
        Try

            IniciarSP("encomienda_Insert")
            AddParametro("@idenco", codenc)
            AddParametro("@nrodoc_re", nrodocre)
            AddParametro("@nrodoc_des", nrodocdes)
            AddParametro("@idhojaruta", idhojaru)
            AddParametro("@descrip", des)
            AddParametro("@fragil", fragil)
            AddParametro("@volumen", volum)
            AddParametro("@Peso", pes)
            AddParametro("@monto", mont)
            AddParametro("@pagado", pag)
            AddParametro("@idusu", idusu)

            If EjecutarTransaccion() = True Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Obtiene todos las Flotas segun su placa
    ''' </summary>
    ''' <param name="Placa">Flota que desea buscar</param>
    Public Function Obtener(ByVal Placa As String, ByVal activo As Boolean) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Flota_SelectAll")
        AddParametro("@Placa", Placa)
        AddParametro("@activo", activo)

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

    Public Function encomiendasGetByDia(ByVal FechaInicio As Date, ByVal FechaFin As Date) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("encomiendasGetByDia")
        AddParametro("@FechaInicio", FechaInicio)
        AddParametro("@FechaFin", FechaFin)

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
