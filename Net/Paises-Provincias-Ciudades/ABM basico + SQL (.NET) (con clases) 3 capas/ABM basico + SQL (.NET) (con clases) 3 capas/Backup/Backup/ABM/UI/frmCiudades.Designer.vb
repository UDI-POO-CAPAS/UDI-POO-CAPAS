<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCiudades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCiudades))
        Me.cboPais = New System.Windows.Forms.ComboBox
        Me.lvCiudades = New System.Windows.Forms.ListView
        Me.lblPais = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.gbBusqueda = New System.Windows.Forms.GroupBox
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.cboProvincia = New System.Windows.Forms.ComboBox
        Me.lblProvincia = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.tlsMenu = New System.Windows.Forms.ToolStrip
        Me.mnuAgregar = New System.Windows.Forms.ToolStripButton
        Me.mnuEditar = New System.Windows.Forms.ToolStripButton
        Me.mnuEliminar = New System.Windows.Forms.ToolStripButton
        Me.mnuSalir = New System.Windows.Forms.ToolStripButton
        Me.picImagen = New System.Windows.Forms.PictureBox
        Me.tlbEstado = New System.Windows.Forms.StatusStrip
        Me.lblCantidad = New System.Windows.Forms.ToolStripStatusLabel
        Me.picTitulo = New System.Windows.Forms.PictureBox
        Me.gbCiudades = New System.Windows.Forms.GroupBox
        Me.gbBusqueda.SuspendLayout()
        Me.tlsMenu.SuspendLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlbEstado.SuspendLayout()
        CType(Me.picTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCiudades.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboPais
        '
        Me.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPais.FormattingEnabled = True
        Me.cboPais.Location = New System.Drawing.Point(64, 15)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Size = New System.Drawing.Size(179, 21)
        Me.cboPais.TabIndex = 1
        '
        'lvCiudades
        '
        Me.lvCiudades.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvCiudades.BackColor = System.Drawing.Color.White
        Me.lvCiudades.Location = New System.Drawing.Point(6, 16)
        Me.lvCiudades.MultiSelect = False
        Me.lvCiudades.Name = "lvCiudades"
        Me.lvCiudades.Size = New System.Drawing.Size(342, 251)
        Me.lvCiudades.TabIndex = 0
        Me.lvCiudades.UseCompatibleStateImageBehavior = False
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(31, 18)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(27, 13)
        Me.lblPais.TabIndex = 0
        Me.lblPais.Text = "Pais"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(14, 72)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.btnLimpiar)
        Me.gbBusqueda.Controls.Add(Me.cboProvincia)
        Me.gbBusqueda.Controls.Add(Me.lblProvincia)
        Me.gbBusqueda.Controls.Add(Me.cboPais)
        Me.gbBusqueda.Controls.Add(Me.lblPais)
        Me.gbBusqueda.Controls.Add(Me.lblNombre)
        Me.gbBusqueda.Controls.Add(Me.txtNombre)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(373, 99)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(251, 273)
        Me.gbBusqueda.TabIndex = 33
        Me.gbBusqueda.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(64, 95)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 37)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cboProvincia
        '
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(64, 42)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(179, 21)
        Me.cboProvincia.TabIndex = 5
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(7, 45)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.lblProvincia.TabIndex = 4
        Me.lblProvincia.Text = "Provincia"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(64, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(179, 20)
        Me.txtNombre.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(173, 95)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 37)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Black
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(61, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(153, 32)
        Me.lblTitulo.TabIndex = 34
        Me.lblTitulo.Text = "Ciudades"
        '
        'tlsMenu
        '
        Me.tlsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgregar, Me.mnuEditar, Me.mnuEliminar, Me.mnuSalir})
        Me.tlsMenu.Location = New System.Drawing.Point(0, 57)
        Me.tlsMenu.Name = "tlsMenu"
        Me.tlsMenu.Size = New System.Drawing.Size(630, 39)
        Me.tlsMenu.TabIndex = 31
        Me.tlsMenu.Text = "ToolStrip1"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Image = CType(resources.GetObject("mnuAgregar.Image"), System.Drawing.Image)
        Me.mnuAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.Size = New System.Drawing.Size(85, 36)
        Me.mnuAgregar.Text = "Agregar"
        '
        'mnuEditar
        '
        Me.mnuEditar.Image = CType(resources.GetObject("mnuEditar.Image"), System.Drawing.Image)
        Me.mnuEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEditar.Name = "mnuEditar"
        Me.mnuEditar.Size = New System.Drawing.Size(73, 36)
        Me.mnuEditar.Text = "Editar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = CType(resources.GetObject("mnuEliminar.Image"), System.Drawing.Image)
        Me.mnuEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(86, 36)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'mnuSalir
        '
        Me.mnuSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
        Me.mnuSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(65, 36)
        Me.mnuSalir.Text = "Salir"
        '
        'picImagen
        '
        Me.picImagen.BackColor = System.Drawing.Color.Transparent
        Me.picImagen.Image = CType(resources.GetObject("picImagen.Image"), System.Drawing.Image)
        Me.picImagen.Location = New System.Drawing.Point(12, 12)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(32, 32)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picImagen.TabIndex = 37
        Me.picImagen.TabStop = False
        '
        'tlbEstado
        '
        Me.tlbEstado.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tlbEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCantidad})
        Me.tlbEstado.Location = New System.Drawing.Point(0, 379)
        Me.tlbEstado.Name = "tlbEstado"
        Me.tlbEstado.Size = New System.Drawing.Size(630, 22)
        Me.tlbEstado.SizingGrip = False
        Me.tlbEstado.TabIndex = 35
        '
        'lblCantidad
        '
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(0, 17)
        '
        'picTitulo
        '
        Me.picTitulo.BackColor = System.Drawing.Color.Black
        Me.picTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.picTitulo.Location = New System.Drawing.Point(0, 0)
        Me.picTitulo.Name = "picTitulo"
        Me.picTitulo.Size = New System.Drawing.Size(630, 57)
        Me.picTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitulo.TabIndex = 36
        Me.picTitulo.TabStop = False
        '
        'gbCiudades
        '
        Me.gbCiudades.Controls.Add(Me.lvCiudades)
        Me.gbCiudades.Location = New System.Drawing.Point(12, 99)
        Me.gbCiudades.Name = "gbCiudades"
        Me.gbCiudades.Size = New System.Drawing.Size(355, 273)
        Me.gbCiudades.TabIndex = 32
        Me.gbCiudades.TabStop = False
        '
        'frmCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 401)
        Me.Controls.Add(Me.gbBusqueda)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tlsMenu)
        Me.Controls.Add(Me.picImagen)
        Me.Controls.Add(Me.tlbEstado)
        Me.Controls.Add(Me.picTitulo)
        Me.Controls.Add(Me.gbCiudades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCiudades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Basico"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.tlsMenu.ResumeLayout(False)
        Me.tlsMenu.PerformLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlbEstado.ResumeLayout(False)
        Me.tlbEstado.PerformLayout()
        CType(Me.picTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCiudades.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboPais As System.Windows.Forms.ComboBox
    Friend WithEvents lvCiudades As System.Windows.Forms.ListView
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tlsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents picImagen As System.Windows.Forms.PictureBox
    Friend WithEvents tlbEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents lblCantidad As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents picTitulo As System.Windows.Forms.PictureBox
    Friend WithEvents gbCiudades As System.Windows.Forms.GroupBox
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
