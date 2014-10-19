<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Confirmar
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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_parametro = New System.Windows.Forms.DataGridView()
        Me.PrecioMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_parametro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(143, 40)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(228, 24)
        Me.TextBox5.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_parametro)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox3.Location = New System.Drawing.Point(9, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(471, 300)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parametros de Confirmacion"
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
        Me.dgv_parametro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrecioMinimo, Me.Activo, Me.Fecha})
        Me.dgv_parametro.Location = New System.Drawing.Point(6, 20)
        Me.dgv_parametro.Name = "dgv_parametro"
        Me.dgv_parametro.ReadOnly = True
        Me.dgv_parametro.RowHeadersVisible = False
        Me.dgv_parametro.Size = New System.Drawing.Size(454, 274)
        Me.dgv_parametro.TabIndex = 1
        '
        'PrecioMinimo
        '
        Me.PrecioMinimo.DataPropertyName = "PrecioMinimo"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson
        Me.PrecioMinimo.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioMinimo.HeaderText = "Nro. Guía"
        Me.PrecioMinimo.Name = "PrecioMinimo"
        Me.PrecioMinimo.ReadOnly = True
        Me.PrecioMinimo.Width = 200
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Activo.DefaultCellStyle = DataGridViewCellStyle2
        Me.Activo.HeaderText = "Estado"
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        Me.Activo.Width = 60
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.Fecha.HeaderText = "Fecha Actualizado"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 40)
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
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(9, 465)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 56)
        Me.GroupBox1.TabIndex = 2
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
        Me.btn_cancelar.Location = New System.Drawing.Point(348, 16)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(7, 1, 5, 1)
        Me.btn_cancelar.Size = New System.Drawing.Size(112, 34)
        Me.btn_cancelar.TabIndex = 0
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
        Me.btn_guardar.Location = New System.Drawing.Point(216, 17)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Padding = New System.Windows.Forms.Padding(7, 0, 5, 0)
        Me.btn_guardar.Size = New System.Drawing.Size(112, 33)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 59)
        Me.Panel2.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Image = Global.Parametro.My.Resources.Resources.administration1
        Me.PictureBox1.Location = New System.Drawing.Point(17, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(130, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Confirmacion de Entrega"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_buscar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Location = New System.Drawing.Point(9, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 60)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parametros de Buscqueda"
        '
        'txt_buscar
        '
        Me.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_buscar.Location = New System.Drawing.Point(172, 26)
        Me.txt_buscar.Multiline = True
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(199, 24)
        Me.txt_buscar.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(68, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Buscar : "
        '
        'Frm_Confirmar
        '
        Me.AcceptButton = Me.btn_guardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(492, 531)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Confirmar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Confirmar"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_parametro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents dgv_parametro As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrecioMinimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
