' ***********************************************************************
'  Module:  HistorialRuta.vb
'  Author:  CASA
'  Purpose: Definition of the Class HistorialRuta
' ***********************************************************************
Option Strict Off

Imports Microsoft.VisualBasic
Imports System


Public Class HistorialRuta
    Inherits LCD.CAD


#Region "Atributos"
    Private _IdHistorialRuta As Integer
    Private _IdHojaRuta As Integer
    Private _IdUsuario As Integer
    Private _Estado As Integer
    Private _Fecha As DateTime
#End Region

#Region "Propiedades"

    Public Property IdHistorialRuta As Integer
        Get
            Return _IdHistorialRuta
        End Get
        Set(ByVal Value As Integer)
            If (_IdHistorialRuta <> Value) Then
                _IdHistorialRuta = Value
            End If
        End Set
    End Property

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

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(ByVal Value As Integer)
            If (_IdUsuario <> Value) Then
                _IdUsuario = Value
            End If
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _Estado
        End Get
        Set(ByVal Value As Integer)
            If (_Estado <> Value) Then
                _Estado = Value
            End If
        End Set
    End Property

    Public Property Fecha As DateTime
        Get
            Return _Fecha
        End Get
        Set(ByVal Value As DateTime)
            If (_Fecha <> Value) Then
                _Fecha = Value
            End If
        End Set
    End Property

#End Region

    Public Function Guardar() As Boolean
        Try
            IniciarSP("HistorialRuta_Insert")
            AddParametro("@ID_Usuario", IdUsuario)

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

End Class
