<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btbnBuscar = New System.Windows.Forms.Button()
        Me.grpoBoxDatos = New System.Windows.Forms.GroupBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.gpoBoxCatalogo = New System.Windows.Forms.GroupBox()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.columnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grpoBoxDatos.SuspendLayout()
        Me.gpoBoxCatalogo.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(574, 121)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 37)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btbnBuscar
        '
        Me.btbnBuscar.Location = New System.Drawing.Point(574, 78)
        Me.btbnBuscar.Name = "btbnBuscar"
        Me.btbnBuscar.Size = New System.Drawing.Size(93, 37)
        Me.btbnBuscar.TabIndex = 14
        Me.btbnBuscar.Text = "&Buscar"
        Me.btbnBuscar.UseVisualStyleBackColor = True
        '
        'grpoBoxDatos
        '
        Me.grpoBoxDatos.Controls.Add(Me.lblPrecio)
        Me.grpoBoxDatos.Controls.Add(Me.txtPrecio)
        Me.grpoBoxDatos.Controls.Add(Me.lblMarca)
        Me.grpoBoxDatos.Controls.Add(Me.txtMarca)
        Me.grpoBoxDatos.Controls.Add(Me.lblDescripcion)
        Me.grpoBoxDatos.Controls.Add(Me.txtDescripcion)
        Me.grpoBoxDatos.Controls.Add(Me.lblId)
        Me.grpoBoxDatos.Controls.Add(Me.txtId)
        Me.grpoBoxDatos.Location = New System.Drawing.Point(3, 5)
        Me.grpoBoxDatos.Name = "grpoBoxDatos"
        Me.grpoBoxDatos.Size = New System.Drawing.Size(565, 142)
        Me.grpoBoxDatos.TabIndex = 13
        Me.grpoBoxDatos.TabStop = False
        Me.grpoBoxDatos.Text = "Datos del Producto"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(13, 109)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(78, 106)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(111, 20)
        Me.txtPrecio.TabIndex = 7
        Me.txtPrecio.Text = "0.00"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(13, 83)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 6
        Me.lblMarca.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(78, 80)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(340, 20)
        Me.txtMarca.TabIndex = 5
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 57)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(78, 54)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(340, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(13, 31)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(16, 13)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(78, 28)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(111, 20)
        Me.txtId.TabIndex = 1
        Me.txtId.Text = "0"
        '
        'gpoBoxCatalogo
        '
        Me.gpoBoxCatalogo.Controls.Add(Me.dgvDatos)
        Me.gpoBoxCatalogo.Location = New System.Drawing.Point(3, 153)
        Me.gpoBoxCatalogo.Name = "gpoBoxCatalogo"
        Me.gpoBoxCatalogo.Size = New System.Drawing.Size(565, 246)
        Me.gpoBoxCatalogo.TabIndex = 12
        Me.gpoBoxCatalogo.TabStop = False
        Me.gpoBoxCatalogo.Text = "Catalogo Productos"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnId, Me.columnDescripcion, Me.columnMarca, Me.columnPrecio})
        Me.dgvDatos.Location = New System.Drawing.Point(8, 16)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(551, 222)
        Me.dgvDatos.TabIndex = 2
        '
        'columnId
        '
        Me.columnId.HeaderText = "Id"
        Me.columnId.Name = "columnId"
        Me.columnId.ReadOnly = True
        Me.columnId.Width = 70
        '
        'columnDescripcion
        '
        Me.columnDescripcion.HeaderText = "Descripción"
        Me.columnDescripcion.Name = "columnDescripcion"
        Me.columnDescripcion.ReadOnly = True
        Me.columnDescripcion.Width = 200
        '
        'columnMarca
        '
        Me.columnMarca.HeaderText = "Marca"
        Me.columnMarca.Name = "columnMarca"
        Me.columnMarca.ReadOnly = True
        Me.columnMarca.Width = 152
        '
        'columnPrecio
        '
        Me.columnPrecio.HeaderText = "Precio"
        Me.columnPrecio.Name = "columnPrecio"
        Me.columnPrecio.ReadOnly = True
        Me.columnPrecio.Width = 85
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(574, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(93, 37)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(670, 403)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btbnBuscar)
        Me.Controls.Add(Me.grpoBoxDatos)
        Me.Controls.Add(Me.gpoBoxCatalogo)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpoBoxDatos.ResumeLayout(False)
        Me.grpoBoxDatos.PerformLayout()
        Me.gpoBoxCatalogo.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Private WithEvents btbnBuscar As System.Windows.Forms.Button
    Private WithEvents grpoBoxDatos As System.Windows.Forms.GroupBox
    Private WithEvents lblPrecio As System.Windows.Forms.Label
    Private WithEvents txtPrecio As System.Windows.Forms.TextBox
    Private WithEvents lblMarca As System.Windows.Forms.Label
    Private WithEvents txtMarca As System.Windows.Forms.TextBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents lblId As System.Windows.Forms.Label
    Private WithEvents txtId As System.Windows.Forms.TextBox
    Private WithEvents gpoBoxCatalogo As System.Windows.Forms.GroupBox
    Private WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Private WithEvents columnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents columnDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents columnMarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents columnPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents btnAgregar As System.Windows.Forms.Button
End Class
