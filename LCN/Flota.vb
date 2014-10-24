Imports System.Data.SqlClient

Public Class Flota

    Inherits LCD.CAD

#Region "ATRIBUTOS"
    Private _id_Flota As Integer
    Private _marca As String
    Private _modelo As String
    Private _Año As Integer
    Private _placa As String
    Private _volumenCarga As Double
    Private _peso_carga As Double
    Private _activo As Boolean
    Private _fecha_act As DateTime
    Private _Ubicacion As Integer

#End Region

#Region "PROPIEDADES"


    Public Property id_Flota() As Integer
        Get
            Return _id_Flota
        End Get
        Set(ByVal value As Integer)
            _id_Flota = value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
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

    Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property
    Public Property VolumenCarga() As Double
        Get
            Return _volumenCarga
        End Get
        Set(ByVal value As Double)
            _volumenCarga = value
        End Set
    End Property
    Public Property PesoCarga() As Double
        Get
            Return _peso_carga
        End Get
        Set(ByVal value As Double)
            _peso_carga = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Public Property fecha_act() As DateTime
        Get
            Return _fecha_act
        End Get
        Set(ByVal value As DateTime)
            _fecha_act = value
        End Set
    End Property

    Public Property Ubicacion() As Integer
        Get
            Return _Ubicacion
        End Get
        Set(ByVal value As Integer)
            _Ubicacion = value
        End Set
    End Property

#End Region

#Region "METODOS"

    Sub New()
        ' CONSTRUCTOR 1
    End Sub

    Public Sub New(ByVal id_Flota As Integer,
                   ByVal Marca As String,
                   ByVal Modelo As String,
                   ByVal Año As Integer,
                   ByVal Placa As String,
                   ByVal Volumen_carga As Double,
                   ByVal Peso_carga As Double,
                   ByVal Activo As Boolean,
                   ByVal fecha_act As DateTime,
                   ByVal Ubicacion As Integer)
        'CONSTRUCTOR 2
        Me.id_Flota = id_Flota
        Me.Marca = Marca
        Me.Modelo = Modelo
        Me.Año = Año
        Me.Placa = Placa
        Me.VolumenCarga = Volumen_carga
        Me.PesoCarga = Peso_carga
        Me.Activo = Activo
        Me.fecha_act = fecha_act
        Me.Ubicacion = Ubicacion

    End Sub

    ''' <summary>
    ''' Guarda todos los datos de un cliente
    ''' </summary>
    Public Function Guardar() As Boolean
        Try

            IniciarSP("Flota_Insert")
            AddParametro("@Marca", Marca)
            AddParametro("@Modelo", Modelo)
            AddParametro("@año", Año)
            AddParametro("@Placa", Placa)
            AddParametro("@VolumenCarga", VolumenCarga)
            AddParametro("@PesoCarga", PesoCarga)
            AddParametro("@Activo", Activo)
            AddParametro("@Ubicacion", Ubicacion)


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
    ''' Guarda todos los datos de un cliente
    ''' </summary>
    Public Function Editar() As Boolean
        Try

            IniciarSP("Flota_Update")
            AddParametro("@id_Flota", id_Flota)
            AddParametro("@Marca", Marca)
            AddParametro("@Modelo", Modelo)
            AddParametro("@año", Año)
            AddParametro("@Placa", Placa)
            AddParametro("@Volumen", VolumenCarga)
            AddParametro("@Peso", PesoCarga)
            AddParametro("@Activo", Activo)
            AddParametro("@Ubicacion", Ubicacion)


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

    ''' <summary>
    ''' Obtiene un cliente por su ID
    ''' </summary>
    ''' <param name="id_Flota">ID del cliente</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ClienteGetByID(ByVal id_Flota As Integer) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Cliente_Select")
        AddParametro("@id_Flota", id_Flota)

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
