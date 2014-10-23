Imports LCN

Public Class Frm_Cliente
    Public actualizar As New Boolean

    Private Sub PierdeFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_nrodoc.LostFocus, txt_nombre.LostFocus, txt_telefono.LostFocus, txt_direccion.LostFocus
        sender.BackColor = Color.White
        sender.SelectAll()
    End Sub

    Private Sub AgarraFoco(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles txt_nrodoc.GotFocus, txt_nombre.GotFocus, txt_telefono.GotFocus, txt_direccion.GotFocus
        sender.BackColor = Color.LightCyan
        sender.SelectAll()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        MsgBox("prueba")
        Me.Close()
    End Sub


    Sub Limpiar()
        Try

            Me.txt_nombre.Clear()
            Me.txt_direccion.Clear()
            Me.txt_telefono.Clear()
            Me.txt_nrodoc.Clear()
            Me.txt_nrodoc.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Begin Method Registrar Cliente
    Sub RegistrarCliente()
        Try

            If Me.txt_nombre.Text <> "" Then
                If Me.txt_nrodoc.Text <> "" Then
                    If Me.txt_direccion.Text <> "" Then
                        Dim Cli As New LCN.Clientes(Me.txt_nrodoc.Text, Me.txt_nombre.Text, Me.txt_direccion.Text, Me.txt_telefono.Text, Me.cmb_estado.SelectedIndex, Now)

                        If Cli.Guardar() = True Then
                            If vbYes = MsgBox("Cliente registrado de forma correcta.!" + vbNewLine + "¿Desea agregar otro cliente.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then
                                Me.Limpiar()
                            Else
                                Me.Close()
                            End If
                        Else
                            MsgBox("Error al registrar el cliente", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Debe especificar la dirección del cliente", MsgBoxStyle.Critical)
                        Me.txt_direccion.Focus()
                    End If
                Else
                    MsgBox("Debe especificar el número de documento", MsgBoxStyle.Critical)
                    Me.txt_nrodoc.Focus()
                End If
            Else
                MsgBox("Debe especificar el nombre del cliente", MsgBoxStyle.Critical)
                Me.txt_nombre.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Begin Method Modificar Cliente
    Sub ModificarCliente()
        Try

            If Me.txt_nombre.Text <> "" Then
                If Me.txt_nrodoc.Text <> "" Then
                    If Me.txt_direccion.Text <> "" Then
                        Dim Cli As New Clientes(Me.txt_nrodoc.Text, Me.txt_nombre.Text, Me.txt_direccion.Text, Me.txt_telefono.Text, Me.cmb_estado.SelectedIndex, Now)

                        If Cli.Actualizar(txt_nrodoc.Text) = True Then
                            If vbYes = MsgBox("Cliente actualizado de forma correcta.!" + vbNewLine + "¿Desea agregar otro cliente.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then
                                Me.Limpiar()
                            Else
                                Me.Close()
                            End If
                        Else
                            MsgBox("Error al actualizar el cliente", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Debe especificar la dirección del cliente", MsgBoxStyle.Critical)
                        Me.txt_direccion.Focus()
                    End If
                Else
                    MsgBox("Debe especificar el número de documento", MsgBoxStyle.Critical)
                    Me.txt_nrodoc.Focus()
                End If
            Else
                MsgBox("Debe especificar el nombre del cliente", MsgBoxStyle.Critical)
                Me.txt_nombre.Focus()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If actualizar Then
            ModificarCliente()
        Else
            RegistrarCliente()
        End If

    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class