' ***********************************************************************
'  Module:  Chofer.vb
'  Author:  jhon vargas
'  Purpose: Definition of the Class Chofer
' ***********************************************************************
Option Strict Off

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class Chofer
    Inherits LCD.CAD

#Region "Atributos"
    Private _Nombre As String
    Private _NroDoc As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Activo As Boolean
    Private _FechaAct As Date
    Private _Ubicacion As Integer

#End Region

#Region "Propiedades"

    Public Property NroDoc As String
        Get
            Return _NroDoc
        End Get
        Set(ByVal Value As String)
            If (_NroDoc <> Value) Then
                _NroDoc = Value
            End If
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal Value As String)
            If (_Nombre <> Value) Then
                _Nombre = Value
            End If
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(ByVal Value As String)
            If (_Direccion <> Value) Then
                _Direccion = Value
            End If
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(ByVal Value As String)
            If (_Telefono <> Value) Then
                _Telefono = Value
            End If
        End Set
    End Property

    Public Property Activo As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal Value As Boolean)
            If (_Activo <> Value) Then
                _Activo = Value
            End If
        End Set
    End Property

    Public Property FechaAct As String
        Get
            Return _FechaAct
        End Get
        Set(ByVal value As String)
            _FechaAct = value
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

#Region "Metodos"

    Public Sub New()
        ' CONSTRUCTOR 1
    End Sub

    Public Sub New(ByVal Nombre As String,
                    ByVal NroDoc As String,
                    ByVal Direccion As String,
                    ByVal Telefono As String,
                    ByVal Activo As Boolean,
                    ByVal FechaAct As Date,
                    ByVal Ubicacion As Integer)

        Me.Nombre = Nombre
        Me.NroDoc = NroDoc
        Me.Direccion = Direccion
        Me.Telefono = Telefono
        Me.Activo = Activo
        Me.FechaAct = FechaAct
        Me.Ubicacion = Ubicacion

    End Sub
    Public Function Guardar() As Boolean
        Try

            IniciarSP("Chofer_Insert")
            AddParametro("@NroDoc", NroDoc)
            AddParametro("@Nombre", Nombre)
            AddParametro("@Direccion", Direccion)
            AddParametro("@Telefono", Telefono)
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

    Public Function Editar() As Boolean
        Try

            IniciarSP("Chofer_Update")
            AddParametro("@NroDoc", _NroDoc)
            AddParametro("@Nombre", Nombre)
            AddParametro("@Direccion", Direccion)
            AddParametro("@Telefono", Telefono)
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

    Public Function Eliminar() As Boolean
        Try

            IniciarSP("Chofer_Delete")
            AddParametro("@NroDoc", NroDoc)

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

    Public Function Busqueda(ByVal Nombre As String, ByVal Activo As Boolean) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Chofer_Select")
        AddParametro("@Nombre", Nombre)
        AddParametro("@Activo", Activo)

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

    Public Function BusquedaByCI(ByVal NroDoc As Integer) As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Chofer_SelectByCI")
        AddParametro("@NroDoc", NroDoc)

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
