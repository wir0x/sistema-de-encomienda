<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tss_fecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncomiendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaEncomiendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChoferToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeChoferesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaRutaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaFlotaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaFlotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.tss_fecha})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 599)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(897, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusLabel2.Text = "Estado:"
        '
        'tss_fecha
        '
        Me.tss_fecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tss_fecha.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tss_fecha.ForeColor = System.Drawing.Color.Gray
        Me.tss_fecha.Name = "tss_fecha"
        Me.tss_fecha.Size = New System.Drawing.Size(41, 17)
        Me.tss_fecha.Text = "Fecha"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Beige
        Me.MenuStrip1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EncomiendaToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.ConfiguracionToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(897, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesiónToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(69, 22)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'IniciarSesiónToolStripMenuItem
        '
        Me.IniciarSesiónToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.open99
        Me.IniciarSesiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.IniciarSesiónToolStripMenuItem.Name = "IniciarSesiónToolStripMenuItem"
        Me.IniciarSesiónToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.IniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.padlock18
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.login6
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EncomiendaToolStripMenuItem
        '
        Me.EncomiendaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaEncomiendaToolStripMenuItem, Me.ConToolStripMenuItem})
        Me.EncomiendaToolStripMenuItem.Name = "EncomiendaToolStripMenuItem"
        Me.EncomiendaToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.EncomiendaToolStripMenuItem.Text = "Encomienda"
        '
        'NuevaEncomiendaToolStripMenuItem
        '
        Me.NuevaEncomiendaToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.gift
        Me.NuevaEncomiendaToolStripMenuItem.Name = "NuevaEncomiendaToolStripMenuItem"
        Me.NuevaEncomiendaToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NuevaEncomiendaToolStripMenuItem.Text = "Nueva Encomienda"
        '
        'ConToolStripMenuItem
        '
        Me.ConToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.checkmark2
        Me.ConToolStripMenuItem.Name = "ConToolStripMenuItem"
        Me.ConToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ConToolStripMenuItem.Text = "Confirma Encomienda"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.ListaDeClientesToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(65, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.user2
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Nuevo Cliente"
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.address_book
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ListaDeClientesToolStripMenuItem.Text = "Lista de Clientes"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem1, Me.ChoferToolStripMenuItem1})
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem1, Me.ListaDeUsuariosToolStripMenuItem})
        Me.UsuarioToolStripMenuItem1.Image = Global.Parametro.My.Resources.Resources.user4
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.UsuarioToolStripMenuItem1.Text = "Usuario"
        '
        'AgregarToolStripMenuItem1
        '
        Me.AgregarToolStripMenuItem1.Image = Global.Parametro.My.Resources.Resources._018
        Me.AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        Me.AgregarToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.AgregarToolStripMenuItem1.Text = "Agregar"
        '
        'ListaDeUsuariosToolStripMenuItem
        '
        Me.ListaDeUsuariosToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.address_book1
        Me.ListaDeUsuariosToolStripMenuItem.Name = "ListaDeUsuariosToolStripMenuItem"
        Me.ListaDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ListaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios"
        '
        'ChoferToolStripMenuItem1
        '
        Me.ChoferToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem3, Me.ListaDeChoferesToolStripMenuItem})
        Me.ChoferToolStripMenuItem1.Image = Global.Parametro.My.Resources.Resources.user41
        Me.ChoferToolStripMenuItem1.Name = "ChoferToolStripMenuItem1"
        Me.ChoferToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ChoferToolStripMenuItem1.Text = "Chofer"
        '
        'AgregarToolStripMenuItem3
        '
        Me.AgregarToolStripMenuItem3.Image = Global.Parametro.My.Resources.Resources._018
        Me.AgregarToolStripMenuItem3.Name = "AgregarToolStripMenuItem3"
        Me.AgregarToolStripMenuItem3.Size = New System.Drawing.Size(184, 22)
        Me.AgregarToolStripMenuItem3.Text = "Agregar"
        '
        'ListaDeChoferesToolStripMenuItem
        '
        Me.ListaDeChoferesToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.address_book2
        Me.ListaDeChoferesToolStripMenuItem.Name = "ListaDeChoferesToolStripMenuItem"
        Me.ListaDeChoferesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ListaDeChoferesToolStripMenuItem.Text = "Lista de Choferes"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametroToolStripMenuItem, Me.PuntosToolStripMenuItem, Me.HojaRutaToolStripMenuItem, Me.FlotaToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(67, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Edición"
        '
        'ParametroToolStripMenuItem
        '
        Me.ParametroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem})
        Me.ParametroToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.coin
        Me.ParametroToolStripMenuItem.Name = "ParametroToolStripMenuItem"
        Me.ParametroToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ParametroToolStripMenuItem.Text = "Parametro"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources._021
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar "
        '
        'PuntosToolStripMenuItem
        '
        Me.PuntosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem2})
        Me.PuntosToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.location
        Me.PuntosToolStripMenuItem.Name = "PuntosToolStripMenuItem"
        Me.PuntosToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PuntosToolStripMenuItem.Text = "Puntos"
        '
        'AgregarToolStripMenuItem2
        '
        Me.AgregarToolStripMenuItem2.Name = "AgregarToolStripMenuItem2"
        Me.AgregarToolStripMenuItem2.Size = New System.Drawing.Size(128, 22)
        Me.AgregarToolStripMenuItem2.Text = "Agregar"
        '
        'HojaRutaToolStripMenuItem
        '
        Me.HojaRutaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem6})
        Me.HojaRutaToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.location2
        Me.HojaRutaToolStripMenuItem.Name = "HojaRutaToolStripMenuItem"
        Me.HojaRutaToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.HojaRutaToolStripMenuItem.Text = "Hoja Ruta"
        '
        'AgregarToolStripMenuItem6
        '
        Me.AgregarToolStripMenuItem6.Name = "AgregarToolStripMenuItem6"
        Me.AgregarToolStripMenuItem6.Size = New System.Drawing.Size(128, 22)
        Me.AgregarToolStripMenuItem6.Text = "Agregar"
        '
        'FlotaToolStripMenuItem
        '
        Me.FlotaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaFlotaToolStripMenuItem1, Me.ListaFlotasToolStripMenuItem})
        Me.FlotaToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.truck
        Me.FlotaToolStripMenuItem.Name = "FlotaToolStripMenuItem"
        Me.FlotaToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.FlotaToolStripMenuItem.Text = "Flota"
        '
        'NuevaFlotaToolStripMenuItem1
        '
        Me.NuevaFlotaToolStripMenuItem1.Image = Global.Parametro.My.Resources.Resources.plus
        Me.NuevaFlotaToolStripMenuItem1.Name = "NuevaFlotaToolStripMenuItem1"
        Me.NuevaFlotaToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.NuevaFlotaToolStripMenuItem1.Text = "Nueva Flota"
        '
        'ListaFlotasToolStripMenuItem
        '
        Me.ListaFlotasToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.list2
        Me.ListaFlotasToolStripMenuItem.Name = "ListaFlotasToolStripMenuItem"
        Me.ListaFlotasToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ListaFlotasToolStripMenuItem.Text = "Lista Flotas"
        '
        'ConfiguracionToolStripMenuItem1
        '
        Me.ConfiguracionToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosToolStripMenuItem, Me.TipoDeUsuarioToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem1.Name = "ConfiguracionToolStripMenuItem1"
        Me.ConfiguracionToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.ConfiguracionToolStripMenuItem1.Text = "Configuración"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem4})
        Me.PermisosToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.cog2
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'AgregarToolStripMenuItem4
        '
        Me.AgregarToolStripMenuItem4.Image = Global.Parametro.My.Resources.Resources.plus1
        Me.AgregarToolStripMenuItem4.Name = "AgregarToolStripMenuItem4"
        Me.AgregarToolStripMenuItem4.Size = New System.Drawing.Size(128, 22)
        Me.AgregarToolStripMenuItem4.Text = "Agregar"
        '
        'TipoDeUsuarioToolStripMenuItem
        '
        Me.TipoDeUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem5})
        Me.TipoDeUsuarioToolStripMenuItem.Image = Global.Parametro.My.Resources.Resources.users21
        Me.TipoDeUsuarioToolStripMenuItem.Name = "TipoDeUsuarioToolStripMenuItem"
        Me.TipoDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TipoDeUsuarioToolStripMenuItem.Text = "Tipo de Usuario"
        '
        'AgregarToolStripMenuItem5
        '
        Me.AgregarToolStripMenuItem5.Name = "AgregarToolStripMenuItem5"
        Me.AgregarToolStripMenuItem5.Size = New System.Drawing.Size(128, 22)
        Me.AgregarToolStripMenuItem5.Text = "Agregar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(73, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 69)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sistema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(176, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 69)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "de"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(12, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(486, 69)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Encomiendas"
        '
        'Timer1
        '
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.Parametro.My.Resources.Resources.Thumbnail
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(897, 621)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDIPrincipal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Encomienda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParametroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncomiendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaEncomiendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChoferToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuntosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HojaRutaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tss_fecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TipoDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeChoferesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaFlotaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaFlotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
