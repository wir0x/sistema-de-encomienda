Imports System.Data.SqlClient

Public Class HistorialEncomienda
    Inherits LCD.CAD

#Region "ATRIBUTOS"
    Private _idHistorialEncomienda As Integer
    Private _idEncomienda As Integer
    Private _idUsuario As Integer
    Private _estado As Integer
    Private _fecha As Date
#End Region


#Region "PROPIEDADES"
    Public Property IdHistorialEncomienda() As String
        Get
            Return _idHistorialEncomienda
        End Get
        Set(ByVal value As String)
            _idHistorialEncomienda = value
        End Set
    End Property


    Public Property IdEncomienda() As String
        Get
            Return _idEncomienda
        End Get
        Set(ByVal value As String)
            _idEncomienda = value
        End Set
    End Property


    Public Property IdUsuario() As String
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As String)
            _idUsuario = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property


    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

#End Region

#Region "METODOS"


    ''' <summary>
    ''' Constructur del la clase parametro
    ''' </summary>
    ''' <param name="PrecioMin">Precio Minimo</param>
    ''' <param name="PrecioKil">Precio Kilo</param>
    ''' <param name="PrecioVol">Precio Volumen</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal IdHistorialEncomienda As Integer,
                   ByVal IdEncomienda As Integer,
                   ByVal IdUsuario As Integer,
                   ByVal Estado As Integer,
                   ByVal Fecha As Date)
        Me.IdHistorialEncomienda = IdHistorialEncomienda
        Me.IdEncomienda = IdEncomienda
        Me.IdUsuario = IdUsuario
        Me.Estado = Estado
        Me.Fecha = Fecha

    End Sub

    ''' <summary>
    ''' Crear un nuevo registro el la clase parametro
    ''' </summary>
    ''' <returns>retorna un boolean true si el la registro se ejecuto exitosamente</returns>
    ''' <remarks></remarks>
    Public Function CrearHistorial() As Boolean

        Dim flag As Boolean = False

        Try
            IniciarSP("HistorialEncomienda_SetForUser")

            AddParametro("@_idEncomienda", IdEncomienda)
            AddParametro("@_idUsuario", IdUsuario)
            AddParametro("@_estado", Estado)

            If EjecutarTransaccion() Then
                flag = True
            End If

        Catch ex As Exception
            MsgBox("Error al insertar Parametro -->" & ex.Message)
        End Try

        Return flag

    End Function


#End Region




End Class
