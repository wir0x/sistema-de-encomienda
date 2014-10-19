Imports System.Data.SqlClient

Public Class Clientes

    Inherits LCD.CAD

#Region "ATRIBUTOS"
    Private _nroDoc As String
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String
    Private _activo As Boolean
    Private _fechaAct As Date

#End Region

#Region "PROPIEDADES"

    Public Property NroDoc() As String
        Get
            Return _nroDoc
        End Get
        Set(ByVal value As String)
            _nroDoc = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
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

    Public Property FechaAct() As String
        Get
            Return _FechaAct
        End Get
        Set(ByVal value As String)
            _FechaAct = value
        End Set
    End Property


#End Region

#Region "METODOS"

    Sub New()
        ' CONSTRUCTOR 1
    End Sub

    Public Sub New(ByVal Nro_Doc As String,
                   ByVal Nombre As String,
                   ByVal Direccion As String,
                   ByVal Telefono As String,
                   ByVal Activo As Boolean,
                   ByVal FechaAct As Date)
        'CONSTRUCTOR 2
        Me.NroDoc = Nro_Doc
        Me.Nombre = Nombre
        Me.Direccion = Direccion
        Me.Telefono = Telefono
        Me.Activo = Activo
        Me.FechaAct = FechaAct
    End Sub

    ''' <summary>
    ''' Guarda todos los datos de un cliente
    ''' </summary>
    Public Function Guardar() As Boolean
        Try

            IniciarSP("Cliente_Insert")
            AddParametro("@Nombre", Nombre)
            AddParametro("@NroDoc", NroDoc)
            AddParametro("@Direccion", Direccion)
            AddParametro("@Telefono", Telefono)
            AddParametro("@Activo", Activo)
            AddParametro("@FechaAct", FechaAct)

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

    ''' <summary>
    ''' Obtiene todos los clientes segun su nombre
    ''' </summary>
    ''' <param name="Estado">Estado del cliente (Activo/Inactivo)</param>
    ''' <param name="Nombre">Cliente que desea buscar</param>

    Public Function Obtener(ByVal Estado As Boolean, ByVal Nombre As String) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Cliente_SelectAll")
        AddParametro("@Estado", Estado)
        AddParametro("@Nombre", Nombre)

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
    ''' <param name="ID_Cliente">ID del cliente</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ClienteGetByID(ByVal ID_Cliente As Integer) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Cliente_Select")
        AddParametro("@ID_Cliente", ID_Cliente)

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
    ''' Actualiza los datos de un cliente incluyendo si ID
    ''' </summary>
    ''' <param name="NroDoc_Anterior">ID Anterior del cliente</param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function Actualizar(ByVal NroDoc_Anterior As String) As Boolean

        IniciarSP("Cliente_Update")
        AddParametro("@NroDoc_Anterior", NroDoc_Anterior)
        AddParametro("@NroDoc_Nuevo", NroDoc)
        AddParametro("@Nombre", Nombre)
        AddParametro("@Direccion", Direccion)
        AddParametro("@Telefono", Telefono)
        AddParametro("@Activo", Activo)
        AddParametro("@FechaAct", FechaAct)

        If EjecutarTransaccion() = True Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

  
End Class
