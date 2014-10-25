<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaEncomiendas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dg_Encomiendas = New System.Windows.Forms.DataGridView()
        CType(Me.dg_Encomiendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "MIGRAR ENCOMIENDAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dg_Encomiendas
        '
        Me.dg_Encomiendas.AllowUserToAddRows = False
        Me.dg_Encomiendas.AllowUserToDeleteRows = False
        Me.dg_Encomiendas.AllowUserToResizeColumns = False
        Me.dg_Encomiendas.AllowUserToResizeRows = False
        Me.dg_Encomiendas.BackgroundColor = System.Drawing.Color.White
        Me.dg_Encomiendas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_Encomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_Encomiendas.Location = New System.Drawing.Point(12, 23)
        Me.dg_Encomiendas.Name = "dg_Encomiendas"
        Me.dg_Encomiendas.ReadOnly = True
        Me.dg_Encomiendas.RowHeadersVisible = False
        Me.dg_Encomiendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Encomiendas.Size = New System.Drawing.Size(547, 333)
        Me.dg_Encomiendas.TabIndex = 1
        '
        'frmListaEncomiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 408)
        Me.Controls.Add(Me.dg_Encomiendas)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmListaEncomiendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTA DE ENCOMIENDAS"
        CType(Me.dg_Encomiendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dg_Encomiendas As System.Windows.Forms.DataGridView
End Class
