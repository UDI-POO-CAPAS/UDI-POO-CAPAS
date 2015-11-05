<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboBD = New System.Windows.Forms.ComboBox()
        Me.cboTabla = New System.Windows.Forms.ComboBox()
        Me.Registros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistros = New System.Windows.Forms.DataGridView()
        Me.Registros.SuspendLayout()
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base de Datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tabla"
        '
        'cboBD
        '
        Me.cboBD.FormattingEnabled = True
        Me.cboBD.Location = New System.Drawing.Point(145, 29)
        Me.cboBD.Name = "cboBD"
        Me.cboBD.Size = New System.Drawing.Size(121, 21)
        Me.cboBD.TabIndex = 2
        '
        'cboTabla
        '
        Me.cboTabla.FormattingEnabled = True
        Me.cboTabla.Location = New System.Drawing.Point(148, 64)
        Me.cboTabla.Name = "cboTabla"
        Me.cboTabla.Size = New System.Drawing.Size(121, 21)
        Me.cboTabla.TabIndex = 3
        '
        'Registros
        '
        Me.Registros.Controls.Add(Me.dgvRegistros)
        Me.Registros.Location = New System.Drawing.Point(23, 117)
        Me.Registros.Name = "Registros"
        Me.Registros.Size = New System.Drawing.Size(576, 164)
        Me.Registros.TabIndex = 4
        Me.Registros.TabStop = False
        Me.Registros.Text = "Registros"
        '
        'dgvRegistros
        '
        Me.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistros.Location = New System.Drawing.Point(12, 19)
        Me.dgvRegistros.Name = "dgvRegistros"
        Me.dgvRegistros.Size = New System.Drawing.Size(548, 133)
        Me.dgvRegistros.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 303)
        Me.Controls.Add(Me.Registros)
        Me.Controls.Add(Me.cboTabla)
        Me.Controls.Add(Me.cboBD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ADO.NET"
        Me.Registros.ResumeLayout(False)
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboBD As System.Windows.Forms.ComboBox
    Friend WithEvents cboTabla As System.Windows.Forms.ComboBox
    Friend WithEvents Registros As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRegistros As System.Windows.Forms.DataGridView

End Class
