
Imports System.Data.SqlClient

Public Class Puntos

    Inherits LCD.CAD

#Region "ATRIBUTOS"
    Private _id_Punto As Integer
    Private _descripcion As String
    Private _instancia As String
    Private _baseDatos As String
    Private _activo As Boolean
    Private _fechaAct As Date

#End Region

#Region "PROPIEDADES"

    Public Property ID_Punto() As String
        Get
            Return _id_Punto
        End Get
        Set(ByVal value As String)
            _id_Punto = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Instancia() As String
        Get
            Return _instancia
        End Get
        Set(ByVal value As String)
            _instancia = value
        End Set
    End Property

    Public Property BaseDatos() As String
        Get
            Return _baseDatos
        End Get
        Set(ByVal value As String)
            _baseDatos = value
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
            Return _fechaAct
        End Get
        Set(ByVal value As String)
            _fechaAct = value
        End Set
    End Property

#End Region

#Region "METODOS"

    Sub New()

    End Sub

    Sub New(ByVal ID_Punto As Integer,
            ByVal Descripcion As String,
            ByVal Instancia As String,
            ByVal BaseDatos As String,
            ByVal Activo As Boolean,
            ByVal FechaAct As Date)

        Me.ID_Punto = ID_Punto
        Me.Descripcion = Descripcion
        Me.Instancia = Instancia
        Me.BaseDatos = BaseDatos
        Me.Activo = Activo
        Me.FechaAct = FechaAct
    End Sub

    ''' <summary>
    ''' Guarda un Punto
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar() As Boolean
        Try
            IniciarSP("Pun_Insert")
            AddParametro("@ID_Punto", ID_Punto)
            AddParametro("@Descripcion", Descripcion)
            AddParametro("@Instancia", Instancia)
            AddParametro("@BaseDatos", BaseDatos)
            AddParametro("@Activo", Activo)
            AddParametro("@FechaAct", FechaAct)

            If EjecutarTransaccion() Then
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
    ''' Actualiza los datos de un punto incluso su ID
    ''' </summary>
    ''' <param name="ID_Anterior"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Actualizar(ByVal ID_Anterior As Integer) As Boolean
        Try
            IniciarSP("Pun_Update")
            AddParametro("ID_Anterior", ID_Anterior)
            AddParametro("@ID_Punto", ID_Punto)
            AddParametro("@Descripcion", Descripcion)
            AddParametro("@Instancia", Instancia)
            AddParametro("@BaseDatos", BaseDatos)
            AddParametro("@Activo", Activo)
            AddParametro("@FechaAct", FechaAct)


            If EjecutarTransaccion() Then
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
    ''' Actualiza el estado de un punto a inactivo
    ''' </summary>
    ''' <param name="ID_Punto">ID del punto</param>
    ''' <param name="EstadoNuevo">Estado a cambiar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CambiarEstado(ByVal ID_Punto As Integer, ByVal EstadoNuevo As Boolean) As Boolean
        Try
            IniciarSP("Pun_Delete")
            AddParametro("@ID_Punto", ID_Punto)
            AddParametro("@Estado", EstadoNuevo)

            If EjecutarTransaccion() Then
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
    ''' Obtiene un punto por su ID
    ''' </summary>
    ''' <param name="ID_Punto">ID del punto</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal ID_Punto As Integer) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Pun_GetByID")
        AddParametro("@ID_Punto", ID_Punto)

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
    ''' Obtiene todos los puntos segun su estado y su descripcion
    ''' </summary>
    ''' <param name="Activo">Estado</param>
    ''' <param name="Descripcion">Descripcion</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Activo As Boolean, ByVal Descripcion As String) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Pun_GetAll")
        AddParametro("@Activo", Activo)
        AddParametro("@Descripcion", Descripcion)

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
    ''' Actualiza los puntos de todos los servidores vinculados
    ''' </summary>
    ''' <param name="InstanciaRecibida">Instacia del cliente</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ActualizarSevidoresPunto(ByVal InstanciaRecibida As String) As Boolean
        Try
            IniciarSP("ActualizaPunto")
            '  AddParametro("@InstanciaRecibida", InstanciaRecibida)

            If EjecutarTransaccion() Then
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
