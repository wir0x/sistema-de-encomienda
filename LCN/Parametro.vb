Imports System.Data.SqlClient


Public Class Parametro
    Inherits LCD.CAD

#Region "Atributos"

    Private _idParam As Integer
    Private _precioMin As Decimal
    Private _precioKil As Decimal
    Private _precioVol As Decimal
    Private _activo As Boolean
    Private _fecha As DateTime


#End Region

#Region "Propiedades"

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    ''' <summary>
    ''' Identificador del la tabla Parametro 
    ''' </summary>
    ''' <value>Ingresar el Id del Parametro</value>
    ''' <returns>Retorna el Id del parametro</returns>
    ''' <remarks></remarks>
    Public Property IdParam() As Integer
        Get
            Return _idParam
        End Get
        Set(value As Integer)
            _idParam = value
        End Set
    End Property

    ''' <summary>
    ''' Precio Minimo de la tabla Parametro
    ''' </summary>
    ''' <value>Ingresar Precio minimo de la tabla Parametro</value>
    ''' <returns>Retorna el precio minimo de la tabla Parametro</returns>
    ''' <remarks></remarks>
    Public Property PrecioMin() As Decimal
        Get
            Return _precioMin
        End Get
        Set(ByVal value As Decimal)
            _precioMin = value
        End Set
    End Property

    ''' <summary>
    ''' Precio Kilo de la tabla Parametro
    ''' </summary>
    ''' <value>Set Precio por Kilo</value>
    ''' <returns>Get Precio por Kilo</returns>
    ''' <remarks></remarks>
    Public Property PrecioKil() As Decimal

        Get
            Return _precioKil
        End Get
        Set(ByVal value As Decimal)
            _precioKil = value
        End Set
    End Property

    ''' <summary>
    ''' Precio por Volumen
    ''' </summary>
    ''' <value>Set Precio por volumen</value>
    ''' <returns>Get Precio por volumen</returns>
    ''' <remarks></remarks>
    Public Property PrecioVol() As Decimal
        Get
            Return _precioVol
        End Get
        Set(ByVal value As Decimal)
            _precioVol = value
        End Set
    End Property

    ''' <summary>
    ''' Activo: Todo parametro que esta 
    ''' Descativo: no elimina la base de datos
    ''' </summary>
    ''' <value>Set Activo</value>
    ''' <returns>Get Activo</returns>
    ''' <remarks></remarks>
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    ''' <summary>
    ''' La fecha se registra automaticamente el la base de datos
    ''' </summary>
    ''' <value>Set Fecha de registro</value>
    ''' <returns>Get fecha registro</returns>
    ''' <remarks></remarks>
    Public Property Fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Constructur del la clase parametro
    ''' </summary>
    ''' <param name="PrecioMin">Precio Minimo</param>
    ''' <param name="PrecioKil">Precio Kilo</param>
    ''' <param name="PrecioVol">Precio Volumen</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal PrecioMin As Decimal,
                   ByVal PrecioKil As Decimal,
                   ByVal PrecioVol As Decimal)
        Me.PrecioMin = PrecioMin
        Me.PrecioKil = PrecioKil
        Me.PrecioVol = PrecioVol

    End Sub

    ''' <summary>
    ''' Crear un nuevo registro el la clase parametro
    ''' </summary>
    ''' <returns>retorna un boolean true si el la registro se ejecuto exitosamente</returns>
    ''' <remarks></remarks>
    Public Function CreateParametro() As Boolean

        Dim flag As Boolean = False

        Try
            IniciarSP("Parametro_SetForUser")

            AddParametro("@PrecioMinimo", _precioMin)
            AddParametro("@PrecioKilo", _precioKil)
            AddParametro("@PrecioVolumen", _precioVol)

            If EjecutarTransaccion() Then
                flag = True
            End If

        Catch ex As Exception
            MsgBox("Error al insertar Parametro -->" & ex.Message)
        End Try

        Return flag

    End Function


    ''' <summary>
    ''' Lee toda los registro de la tabla Parametro para el Usuario
    ''' </summary>
    ''' <returns>Retorna en una tabla todos los registro </returns>
    ''' <remarks></remarks>
    Public Function ReadAllParameters() As DataTable
        Dim tabla As New DataTable

        IniciarSP("Parametro_GetAllForUser")

        If EjecutarTransaccion() Then
            If getTabla(tabla) Then
                Return tabla
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function


    ''' <summary>
    ''' Actualiza el ultimo parametro Activado
    ''' </summary>
    ''' <returns>Retorna el ultimo parametro modificado</returns>
    ''' <remarks></remarks>
    Public Function UpdateParametro() As Boolean

        Dim flag As Boolean = False
        Try
            IniciarSP("Parametro_UpdateForUser")
            AddParametro("@PrecioMinimo", PrecioMin)
            AddParametro("@PrecioKilo", PrecioKil)
            AddParametro("@PrecioVolumen", PrecioVol)
            AddParametro("@Activo", Activo)

            If EjecutarTransaccion() Then
                flag = True

            End If
        Catch ex As Exception
            MsgBox("Error al Actualizar Parametro -->" & ex.Message)

        End Try
        Return flag
    End Function
#End Region

End Class
