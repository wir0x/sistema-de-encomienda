' ***********************************************************************
'  Module:  HojaRuta.vb
'  Author:  CASA
'  Purpose: Definition of the Class HojaRuta
' ***********************************************************************
Option Strict Off

Imports Microsoft.VisualBasic
Imports System

Public Class HojaRuta
    Inherits LCD.CAD

#Region "Atributos"

    Private _IdHojaRuta As Integer
    Private _IdFlota As Integer
    Private _NroDoc As String
    Private _IdOrigen As Integer
    Private _IdDestino As Integer
    Private _FechaSalida As DateTime
    Private _FechaLlegada As DateTime
    Private _Activo As Boolean
    Private _FechaAct As DateTime

#End Region

#Region "Propiedades"

    Public Property IdHojaRuta As Integer
        Get
            Return _IdHojaRuta
        End Get
        Set(ByVal Value As Integer)
            If (_IdHojaRuta <> Value) Then
                _IdHojaRuta = Value
            End If
        End Set
    End Property

    Public Property IdFlota As Integer
        Get
            Return _IdFlota
        End Get
        Set(ByVal Value As Integer)
            If (_IdFlota <> Value) Then
                _IdFlota = Value
            End If
        End Set
    End Property

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

    Public Property IdOrigen As Integer
        Get
            Return _IdOrigen
        End Get
        Set(ByVal Value As Integer)
            If (_IdOrigen <> Value) Then
                _IdOrigen = Value
            End If
        End Set
    End Property

    Public Property IdDestino As Integer
        Get
            Return _IdDestino
        End Get
        Set(ByVal Value As Integer)
            If (_IdDestino <> Value) Then
                _IdDestino = Value
            End If
        End Set
    End Property

    Public Property FechaSalida As Date
        Get
            Return _FechaSalida
        End Get
        Set(ByVal Value As Date)
            If (_FechaSalida <> Value) Then
                _FechaSalida = Value
            End If
        End Set
    End Property

    Public Property FechaLlegada As Date
        Get
            Return _FechaLlegada
        End Get
        Set(ByVal Value As Date)
            If (_FechaLlegada <> Value) Then
                _FechaLlegada = Value
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

    Public Property FechaAct As Date
        Get
            Return _FechaAct
        End Get
        Set(ByVal Value As Date)
            If (_FechaAct <> Value) Then
                _FechaAct = Value
            End If
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Guardar() As Boolean
        Try
            IniciarSP("HojaRuta_Insert")
            AddParametro("@ID_flota", IdFlota)
            AddParametro("@NroDoc", NroDoc)
            AddParametro("@ID_Origen", IdOrigen)
            AddParametro("@ID_Destino", IdDestino)
            AddParametro("@FechaSalida", FechaSalida)
            AddParametro("@FechaLlegada", FechaLlegada)
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
            AddParametro("@ID_HojaRuta", IdHojaRuta)
            AddParametro("@ID_flota", IdFlota)
            AddParametro("@NroDoc", NroDoc)
            AddParametro("@ID_Origen", IdOrigen)
            AddParametro("@ID_Destino", IdDestino)
            AddParametro("@FechaSalida", FechaSalida)
            AddParametro("@FechaLlegada", FechaLlegada)

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

            IniciarSP("HojaRuta_Delete")
            AddParametro("@ID_HojaRuta", IdHojaRuta)

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

    Public Function BusquedaPuntos() As DataTable

        Dim Tabla As New DataTable

        IniciarSP("Punto_Select")

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

    Public Function Busqueda() As DataTable

        Dim Tabla As New DataTable

        IniciarSP("ListaRutas")

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
