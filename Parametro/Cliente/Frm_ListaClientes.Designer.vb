<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_listaclientes = New System.Windows.Forms.DataGridView()
        Me.NroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaAct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_listaclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_listaclientes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 372)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Parametros"
        '
        'dgv_listaclientes
        '
        Me.dgv_listaclientes.AllowUserToAddRows = False
        Me.dgv_listaclientes.AllowUserToDeleteRows = False
        Me.dgv_listaclientes.AllowUserToResizeColumns = False
        Me.dgv_listaclientes.AllowUserToResizeRows = False
        Me.dgv_listaclientes.BackgroundColor = System.Drawing.Color.Snow
        Me.dgv_listaclientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_listaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_listaclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroDoc, Me.Nombre, Me.Telefono, Me.Direccion, Me.Activo, Me.FechaAct})
        Me.dgv_listaclientes.Location = New System.Drawing.Point(8, 31)
        Me.dgv_listaclientes.Name = "dgv_listaclientes"
        Me.dgv_listaclientes.ReadOnly = True
        Me.dgv_listaclientes.RowHeadersVisible = False
        Me.dgv_listaclientes.Size = New System.Drawing.Size(755, 333)
        Me.dgv_listaclientes.TabIndex = 0
        '
        'NroDoc
        '
        Me.NroDoc.DataPropertyName = "NroDoc"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson
        Me.NroDoc.DefaultCellStyle = DataGridViewCellStyle1
        Me.NroDoc.HeaderText = "Nr. Doc. (CI)"
        Me.NroDoc.Name = "NroDoc"
        Me.NroDoc.ReadOnly = True
        Me.NroDoc.Width = 80
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.Nombre.HeaderText = "Nombres"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Telefono.DefaultCellStyle = DataGridViewCellStyle3
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 80
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Direccion.DefaultCellStyle = DataGridViewCellStyle4
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 200
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.NullValue = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Activo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        Me.Activo.Width = 48
        '
        'FechaAct
        '
        Me.FechaAct.DataPropertyName = "FechaAct"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson
        Me.FechaAct.DefaultCellStyle = DataGridViewCellStyle6
        Me.FechaAct.HeaderText = "Fecha Actualizado"
        Me.FechaAct.Name = "FechaAct"
        Me.FechaAct.ReadOnly = True
        Me.FechaAct.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FechaAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaAct.Width = 135
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_estado)
        Me.GroupBox3.Controls.Add(Me.txt_buscar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox3.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(770, 60)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parametros de Buscqueda"
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Items.AddRange(New Object() {"Inactivo", "Activo"})
        Me.cmb_estado.Location = New System.Drawing.Point(87, 23)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(201, 23)
        Me.cmb_estado.TabIndex = 0
        '
        'txt_buscar
        '
        Me.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_buscar.Location = New System.Drawing.Point(418, 24)
        Me.txt_buscar.Multiline = True
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(228, 24)
        Me.txt_buscar.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(341, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Buscar : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Estado :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_reporte)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 532)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = Global.Parametro.My.Resources.Resources.file
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(354, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(7, 0, 5, 0)
        Me.Button1.Size = New System.Drawing.Size(112, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.btn_cancelar.Location = New System.Drawing.Point(640, 14)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(7, 1, 5, 1)
        Me.btn_cancelar.Size = New System.Drawing.Size(112, 34)
        Me.btn_cancelar.TabIndex = 0
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_reporte
        '
        Me.btn_reporte.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reporte.Image = Global.Parametro.My.Resources.Resources.insert_template
        Me.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reporte.Location = New System.Drawing.Point(497, 14)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Padding = New System.Windows.Forms.Padding(7, 0, 5, 0)
        Me.btn_reporte.Size = New System.Drawing.Size(112, 33)
        Me.btn_reporte.TabIndex = 1
        Me.btn_reporte.Text = "Reporte"
        Me.btn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reporte.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Controls.Add(Me.lbl_titulo)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(868, 59)
        Me.Panel2.TabIndex = 22
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Ubuntu Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(270, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(192, 35)
        Me.lbl_titulo.TabIndex = 3
        Me.lbl_titulo.Text = "Lista de Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Image = Global.Parametro.My.Resources.Resources.boys1
        Me.PictureBox1.Location = New System.Drawing.Point(21, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 48)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Frm_ListaClientes
        '
        Me.AcceptButton = Me.btn_reporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(792, 596)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ListaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ListaClientes"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_listaclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_listaclientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FechaAct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
End Class
