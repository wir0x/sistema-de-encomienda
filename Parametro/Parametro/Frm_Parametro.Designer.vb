<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Parametro
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_parametro = New System.Windows.Forms.DataGridView()
        Me.ParametroId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioKilo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVolumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nud_precioMin = New System.Windows.Forms.NumericUpDown()
        Me.nud_precioVol = New System.Windows.Forms.NumericUpDown()
        Me.nud_precioKil = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chb_activo = New System.Windows.Forms.CheckBox()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv_parametro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_precioMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_precioVol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_precioKil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_parametro
        '
        Me.dgv_parametro.AllowUserToAddRows = False
        Me.dgv_parametro.AllowUserToDeleteRows = False
        Me.dgv_parametro.AllowUserToResizeColumns = False
        Me.dgv_parametro.AllowUserToResizeRows = False
        Me.dgv_parametro.BackgroundColor = System.Drawing.Color.Snow
        Me.dgv_parametro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_parametro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_parametro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParametroId, Me.PrecioMinimo, Me.PrecioKilo, Me.PrecioVolumen, Me.Activo, Me.Fecha})
        Me.dgv_parametro.GridColor = System.Drawing.Color.Gray
        Me.dgv_parametro.Location = New System.Drawing.Point(11, 33)
        Me.dgv_parametro.Name = "dgv_parametro"
        Me.dgv_parametro.ReadOnly = True
        Me.dgv_parametro.RowHeadersVisible = False
        Me.dgv_parametro.Size = New System.Drawing.Size(518, 209)
        Me.dgv_parametro.TabIndex = 6
        '
        'ParametroId
        '
        Me.ParametroId.DataPropertyName = "ParametroId"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson
        Me.ParametroId.DefaultCellStyle = DataGridViewCellStyle7
        Me.ParametroId.HeaderText = "ID"
        Me.ParametroId.Name = "ParametroId"
        Me.ParametroId.ReadOnly = True
        Me.ParametroId.Width = 40
        '
        'PrecioMinimo
        '
        Me.PrecioMinimo.DataPropertyName = "PrecioMinimo"
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PrecioMinimo.DefaultCellStyle = DataGridViewCellStyle8
        Me.PrecioMinimo.HeaderText = "Precio Minimo"
        Me.PrecioMinimo.Name = "PrecioMinimo"
        Me.PrecioMinimo.ReadOnly = True
        Me.PrecioMinimo.Width = 95
        '
        'PrecioKilo
        '
        Me.PrecioKilo.DataPropertyName = "PrecioKilo"
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PrecioKilo.DefaultCellStyle = DataGridViewCellStyle9
        Me.PrecioKilo.HeaderText = "Precio Kilo"
        Me.PrecioKilo.Name = "PrecioKilo"
        Me.PrecioKilo.ReadOnly = True
        Me.PrecioKilo.Width = 80
        '
        'PrecioVolumen
        '
        Me.PrecioVolumen.DataPropertyName = "PrecioVolumen"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PrecioVolumen.DefaultCellStyle = DataGridViewCellStyle10
        Me.PrecioVolumen.HeaderText = "Precio Volumen"
        Me.PrecioVolumen.Name = "PrecioVolumen"
        Me.PrecioVolumen.ReadOnly = True
        Me.PrecioVolumen.Width = 103
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.NullValue = False
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Activo.DefaultCellStyle = DataGridViewCellStyle11
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        Me.Activo.Width = 45
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle12
        Me.Fecha.HeaderText = "Fecha y Hora"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 135
        '
        'nud_precioMin
        '
        Me.nud_precioMin.DecimalPlaces = 2
        Me.nud_precioMin.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_precioMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nud_precioMin.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nud_precioMin.Location = New System.Drawing.Point(79, 48)
        Me.nud_precioMin.Name = "nud_precioMin"
        Me.nud_precioMin.Size = New System.Drawing.Size(62, 21)
        Me.nud_precioMin.TabIndex = 0
        '
        'nud_precioVol
        '
        Me.nud_precioVol.DecimalPlaces = 2
        Me.nud_precioVol.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_precioVol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nud_precioVol.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nud_precioVol.Location = New System.Drawing.Point(385, 48)
        Me.nud_precioVol.Name = "nud_precioVol"
        Me.nud_precioVol.Size = New System.Drawing.Size(62, 21)
        Me.nud_precioVol.TabIndex = 2
        '
        'nud_precioKil
        '
        Me.nud_precioKil.DecimalPlaces = 2
        Me.nud_precioKil.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_precioKil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nud_precioKil.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nud_precioKil.Location = New System.Drawing.Point(231, 48)
        Me.nud_precioKil.Name = "nud_precioKil"
        Me.nud_precioKil.Size = New System.Drawing.Size(62, 21)
        Me.nud_precioKil.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(76, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Precio Minimo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(382, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Precio Volumen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(228, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Precio Kilo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Location = New System.Drawing.Point(13, 458)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 52)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancelar.Image = Global.Parametro.My.Resources.Resources.cancel_circle
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(417, 12)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(7, 1, 5, 1)
        Me.btn_cancelar.Size = New System.Drawing.Size(112, 34)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_guardar.Image = Global.Parametro.My.Resources.Resources.box_add1
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(285, 12)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Padding = New System.Windows.Forms.Padding(7, 0, 5, 0)
        Me.btn_guardar.Size = New System.Drawing.Size(112, 33)
        Me.btn_guardar.TabIndex = 5
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_parametro)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Location = New System.Drawing.Point(13, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 257)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Parametros"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chb_activo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.nud_precioKil)
        Me.GroupBox3.Controls.Add(Me.nud_precioVol)
        Me.GroupBox3.Controls.Add(Me.nud_precioMin)
        Me.GroupBox3.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox3.Location = New System.Drawing.Point(11, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 84)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Atributos Parametro"
        '
        'chb_activo
        '
        Me.chb_activo.AutoSize = True
        Me.chb_activo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chb_activo.Location = New System.Drawing.Point(479, 49)
        Me.chb_activo.Name = "chb_activo"
        Me.chb_activo.Size = New System.Drawing.Size(62, 21)
        Me.chb_activo.TabIndex = 9
        Me.chb_activo.Text = "Active"
        Me.chb_activo.UseVisualStyleBackColor = True
        Me.chb_activo.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 26)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(567, 59)
        Me.Panel2.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Image = Global.Parametro.My.Resources.Resources.cash15
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(151, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Registro de Parametros"
        '
        'Frm_Parametro
        '
        Me.AcceptButton = Me.btn_guardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(565, 521)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Parametro"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Parametro"
        CType(Me.dgv_parametro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_precioMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_precioVol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_precioKil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_parametro As System.Windows.Forms.DataGridView
    Friend WithEvents nud_precioMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_precioVol As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_precioKil As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ParametroId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioMinimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioKilo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVolumen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chb_activo As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
End Class
