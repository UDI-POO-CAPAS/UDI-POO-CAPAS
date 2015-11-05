<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPaises = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProvincias = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCiudades = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSeparador = New System.Windows.Forms.ToolStripSeparator
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(293, 24)
        Me.mnuPrincipal.TabIndex = 1
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaises, Me.mnuProvincias, Me.mnuCiudades, Me.mnuSeparador, Me.mnuSalir})
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.mnuArchivo.Text = "Archivo"
        '
        'mnuPaises
        '
        Me.mnuPaises.Image = CType(resources.GetObject("mnuPaises.Image"), System.Drawing.Image)
        Me.mnuPaises.Name = "mnuPaises"
        Me.mnuPaises.ShowShortcutKeys = False
        Me.mnuPaises.Size = New System.Drawing.Size(152, 22)
        Me.mnuPaises.Text = "Paises"
        Me.mnuPaises.ToolTipText = "Paises"
        '
        'mnuProvincias
        '
        Me.mnuProvincias.Image = CType(resources.GetObject("mnuProvincias.Image"), System.Drawing.Image)
        Me.mnuProvincias.Name = "mnuProvincias"
        Me.mnuProvincias.ShowShortcutKeys = False
        Me.mnuProvincias.Size = New System.Drawing.Size(152, 22)
        Me.mnuProvincias.Text = "Provincias"
        Me.mnuProvincias.ToolTipText = "Provincias"
        '
        'mnuCiudades
        '
        Me.mnuCiudades.Image = CType(resources.GetObject("mnuCiudades.Image"), System.Drawing.Image)
        Me.mnuCiudades.Name = "mnuCiudades"
        Me.mnuCiudades.ShowShortcutKeys = False
        Me.mnuCiudades.Size = New System.Drawing.Size(152, 22)
        Me.mnuCiudades.Text = "Ciudades"
        Me.mnuCiudades.ToolTipText = "Ciudades"
        '
        'mnuSeparador
        '
        Me.mnuSeparador.Name = "mnuSeparador"
        Me.mnuSeparador.Size = New System.Drawing.Size(149, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.ShowShortcutKeys = False
        Me.mnuSalir.Size = New System.Drawing.Size(152, 22)
        Me.mnuSalir.Text = "Salir"
        Me.mnuSalir.ToolTipText = "Salir"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 227)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Basico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaises As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProvincias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCiudades As System.Windows.Forms.ToolStripMenuItem

End Class
