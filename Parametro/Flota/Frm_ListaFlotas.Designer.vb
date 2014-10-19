<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaFlotas
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.dgv_parametro = New System.Windows.Forms.DataGridView()
        Me.ParametroId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioKilo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVolumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VolumenCarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_parametro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(87, 30)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(201, 25)
        Me.cmb_estado.TabIndex = 10
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
        Me.dgv_parametro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParametroId, Me.PrecioMinimo, Me.PrecioKilo, Me.PrecioVolumen, Me.Direccion, Me.VolumenCarga, Me.Peso, Me.Activo, Me.Fecha})
        Me.dgv_parametro.Location = New System.Drawing.Point(8, 31)
        Me.dgv_parametro.Name = "dgv_parametro"
        Me.dgv_parametro.ReadOnly = True
        Me.dgv_parametro.RowHeadersVisible = False
        Me.dgv_parametro.Size = New System.Drawing.Size(673, 277)
        Me.dgv_parametro.TabIndex = 6
        '
        'ParametroId
        '
        Me.ParametroId.DataPropertyName = "ParametroId"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson
        Me.ParametroId.DefaultCellStyle = DataGridViewCellStyle7
        Me.ParametroId.HeaderText = "ID. Flota"
        Me.ParametroId.Name = "ParametroId"
        Me.ParametroId.ReadOnly = True
        Me.ParametroId.Width = 80
        '
        'PrecioMinimo
        '
        Me.PrecioMinimo.DataPropertyName = "PrecioMinimo"
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PrecioMinimo.DefaultCellStyle = DataGridViewCellStyle8
        Me.PrecioMinimo.HeaderText = "Marca"
        Me.PrecioMinimo.Name = "PrecioMinimo"
        Me.PrecioMinimo.ReadOnly = True
        Me.PrecioMinimo.Width = 120
        '
        'PrecioKilo
        '
        Me.PrecioKilo.DataPropertyName = "PrecioKilo"
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PrecioKilo.DefaultCellStyle = DataGridViewCellStyle9
        Me.PrecioKilo.HeaderText = "Modelo"
        Me.PrecioKilo.Name = "PrecioKilo"
        Me.PrecioKilo.ReadOnly = True
        Me.PrecioKilo.Width = 80
        '
        'PrecioVolumen
        '
        Me.PrecioVolumen.DataPropertyName = "PrecioVolumen"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PrecioVolumen.DefaultCellStyle = DataGridViewCellStyle10
        Me.PrecioVolumen.HeaderText = "Año"
        Me.PrecioVolumen.Name = "PrecioVolumen"
        Me.PrecioVolumen.ReadOnly = True
        Me.PrecioVolumen.Width = 50
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Placa"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 50
        '
        'VolumenCarga
        '
        Me.VolumenCarga.HeaderText = "Vol Carga"
        Me.VolumenCarga.Name = "VolumenCarga"
        Me.VolumenCarga.ReadOnly = True
        Me.VolumenCarga.Width = 50
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso Carga"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        Me.Peso.Width = 50
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
        Me.Fecha.HeaderText = "Fecha Actualizado"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 135
        '
        'txt_buscar
        '
        Me.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_buscar.Location = New System.Drawing.Point(453, 30)
        Me.txt_buscar.Multiline = True
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(228, 24)
        Me.txt_buscar.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_estado)
        Me.GroupBox3.Controls.Add(Me.txt_buscar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox3.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(693, 68)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parametros de Buscqueda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(367, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Buscar :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Estado :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_reporte)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 497)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 56)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_nuevo.Image = Global.Parametro.My.Resources.Resources.file
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.Location = New System.Drawing.Point(283, 17)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Padding = New System.Windows.Forms.Padding(7, 0, 5, 0)
        Me.btn_nuevo.Size = New System.Drawing.Size(112, 33)
        Me.btn_nuevo.TabIndex = 8
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.UseVisualStyleBackColor = False
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
        Me.btn_cancelar.Image = Global.Parametro.My.Resources.Resources._exit
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(569, 16)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(7, 1, 5, 1)
        Me.btn_cancelar.Size = New System.Drawing.Size(112, 34)
        Me.btn_cancelar.TabIndex = 7
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
        Me.btn_reporte.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_reporte.Image = Global.Parametro.My.Resources.Resources.insert_template
        Me.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reporte.Location = New System.Drawing.Point(426, 16)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Padding = New System.Windows.Forms.Padding(7, 0, 5, 0)
        Me.btn_reporte.Size = New System.Drawing.Size(112, 33)
        Me.btn_reporte.TabIndex = 6
        Me.btn_reporte.Text = "Reporte"
        Me.btn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reporte.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_parametro)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 319)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Flotas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 59)
        Me.Panel2.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Image = Global.Parametro.My.Resources.Resources.bus451
        Me.PictureBox1.Location = New System.Drawing.Point(19, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(287, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Lista de Flotas"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(87, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Frm_ListaFlotas
        '
        Me.AcceptButton = Me.btn_reporte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(719, 565)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ListaFlotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ListaFlotas"
        CType(Me.dgv_parametro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_parametro As System.Windows.Forms.DataGridView
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ParametroId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioMinimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioKilo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVolumen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumenCarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
