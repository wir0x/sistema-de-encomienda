<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_lista_ruta_Origen
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_lista_ruta_Origen))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btm_Seleccionar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_listaHojaR = New System.Windows.Forms.DataGridView()
        Me.ID_HojaRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesoDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VolumenDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_listaHojaR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btm_Seleccionar)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Location = New System.Drawing.Point(7, 455)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 56)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'btm_Seleccionar
        '
        Me.btm_Seleccionar.BackColor = System.Drawing.Color.Gainsboro
        Me.btm_Seleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btm_Seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.btm_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btm_Seleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btm_Seleccionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btm_Seleccionar.Image = Global.Parametro.My.Resources.Resources._018
        Me.btm_Seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btm_Seleccionar.Location = New System.Drawing.Point(259, 15)
        Me.btm_Seleccionar.Name = "btm_Seleccionar"
        Me.btm_Seleccionar.Padding = New System.Windows.Forms.Padding(7, 0, 5, 0)
        Me.btm_Seleccionar.Size = New System.Drawing.Size(149, 33)
        Me.btm_Seleccionar.TabIndex = 2
        Me.btm_Seleccionar.Text = "Selecionar"
        Me.btm_Seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btm_Seleccionar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancelar.Image = Global.Parametro.My.Resources.Resources._exit
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(425, 15)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(7, 1, 5, 1)
        Me.btn_cancelar.Size = New System.Drawing.Size(112, 34)
        Me.btn_cancelar.TabIndex = 0
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_listaHojaR)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Location = New System.Drawing.Point(7, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(566, 372)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Parametros"
        '
        'dgv_listaHojaR
        '
        Me.dgv_listaHojaR.AllowUserToAddRows = False
        Me.dgv_listaHojaR.AllowUserToDeleteRows = False
        Me.dgv_listaHojaR.AllowUserToResizeColumns = False
        Me.dgv_listaHojaR.AllowUserToResizeRows = False
        Me.dgv_listaHojaR.BackgroundColor = System.Drawing.Color.Snow
        Me.dgv_listaHojaR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_listaHojaR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_listaHojaR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_HojaRuta, Me.PuO, Me.PuD, Me.PesoDisponible, Me.VolumenDisponible})
        Me.dgv_listaHojaR.Location = New System.Drawing.Point(8, 31)
        Me.dgv_listaHojaR.Name = "dgv_listaHojaR"
        Me.dgv_listaHojaR.ReadOnly = True
        Me.dgv_listaHojaR.RowHeadersVisible = False
        Me.dgv_listaHojaR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listaHojaR.Size = New System.Drawing.Size(547, 333)
        Me.dgv_listaHojaR.TabIndex = 0
        '
        'ID_HojaRuta
        '
        Me.ID_HojaRuta.DataPropertyName = "ID_HojaRuta"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson
        Me.ID_HojaRuta.DefaultCellStyle = DataGridViewCellStyle1
        Me.ID_HojaRuta.HeaderText = "Cod"
        Me.ID_HojaRuta.Name = "ID_HojaRuta"
        Me.ID_HojaRuta.ReadOnly = True
        Me.ID_HojaRuta.Visible = False
        Me.ID_HojaRuta.Width = 80
        '
        'PuO
        '
        Me.PuO.DataPropertyName = "PuO"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PuO.DefaultCellStyle = DataGridViewCellStyle2
        Me.PuO.HeaderText = "Origen"
        Me.PuO.Name = "PuO"
        Me.PuO.ReadOnly = True
        Me.PuO.Width = 180
        '
        'PuD
        '
        Me.PuD.DataPropertyName = "PuD"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PuD.DefaultCellStyle = DataGridViewCellStyle3
        Me.PuD.HeaderText = "Destino"
        Me.PuD.Name = "PuD"
        Me.PuD.ReadOnly = True
        Me.PuD.Width = 180
        '
        'PesoDisponible
        '
        Me.PesoDisponible.DataPropertyName = "PesoDisponible"
        Me.PesoDisponible.HeaderText = "Peso D."
        Me.PesoDisponible.Name = "PesoDisponible"
        Me.PesoDisponible.ReadOnly = True
        Me.PesoDisponible.Width = 80
        '
        'VolumenDisponible
        '
        Me.VolumenDisponible.DataPropertyName = "VolumenDisponible"
        Me.VolumenDisponible.HeaderText = "Vol. D."
        Me.VolumenDisponible.Name = "VolumenDisponible"
        Me.VolumenDisponible.ReadOnly = True
        Me.VolumenDisponible.Width = 80
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(141, 19)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(314, 33)
        Me.lbl_titulo.TabIndex = 27
        Me.lbl_titulo.Text = "Lista de Hoja De Rutas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Controls.Add(Me.lbl_titulo)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(4, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 70)
        Me.Panel2.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Frm_lista_ruta_Origen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 516)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_lista_ruta_Origen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_lista_ruta_Origen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_listaHojaR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btm_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaHojaR As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ID_HojaRuta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PuO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PuD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesoDisponible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumenDisponible As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
