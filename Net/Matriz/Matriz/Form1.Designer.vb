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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvMatriz1 = New System.Windows.Forms.DataGridView()
        Me.txtFilas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtColumnas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvMatriz2 = New System.Windows.Forms.DataGridView()
        Me.dgvRespuesta = New System.Windows.Forms.DataGridView()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnResta = New System.Windows.Forms.Button()
        CType(Me.dgvMatriz1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMatriz2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRespuesta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(791, 165)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(79, 36)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvMatriz1
        '
        Me.dgvMatriz1.AllowUserToAddRows = False
        Me.dgvMatriz1.AllowUserToDeleteRows = False
        Me.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatriz1.Location = New System.Drawing.Point(66, 56)
        Me.dgvMatriz1.Name = "dgvMatriz1"
        Me.dgvMatriz1.Size = New System.Drawing.Size(269, 190)
        Me.dgvMatriz1.TabIndex = 1
        '
        'txtFilas
        '
        Me.txtFilas.Location = New System.Drawing.Point(741, 128)
        Me.txtFilas.Name = "txtFilas"
        Me.txtFilas.Size = New System.Drawing.Size(65, 20)
        Me.txtFilas.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MATRIZ "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(677, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DIGITE EL TAMAÑO DE SUS MATRICES"
        '
        'txtColumnas
        '
        Me.txtColumnas.Location = New System.Drawing.Point(841, 128)
        Me.txtColumnas.Name = "txtColumnas"
        Me.txtColumnas.Size = New System.Drawing.Size(65, 20)
        Me.txtColumnas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(750, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FILAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(836, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "COLUMNAS"
        '
        'dgvMatriz2
        '
        Me.dgvMatriz2.AllowUserToAddRows = False
        Me.dgvMatriz2.AllowUserToDeleteRows = False
        Me.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatriz2.Location = New System.Drawing.Point(392, 56)
        Me.dgvMatriz2.Name = "dgvMatriz2"
        Me.dgvMatriz2.Size = New System.Drawing.Size(269, 190)
        Me.dgvMatriz2.TabIndex = 8
        '
        'dgvRespuesta
        '
        Me.dgvRespuesta.AllowUserToAddRows = False
        Me.dgvRespuesta.AllowUserToDeleteRows = False
        Me.dgvRespuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRespuesta.Location = New System.Drawing.Point(226, 252)
        Me.dgvRespuesta.Name = "dgvRespuesta"
        Me.dgvRespuesta.ReadOnly = True
        Me.dgvRespuesta.Size = New System.Drawing.Size(269, 190)
        Me.dgvRespuesta.TabIndex = 9
        '
        'btnSuma
        '
        Me.btnSuma.Enabled = False
        Me.btnSuma.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(56, 35)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(49, 50)
        Me.btnSuma.TabIndex = 10
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(791, 207)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(79, 36)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(791, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 36)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSuma)
        Me.GroupBox1.Controls.Add(Me.btnResta)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(556, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 174)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones Basicas"
        '
        'btnResta
        '
        Me.btnResta.Enabled = False
        Me.btnResta.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(56, 108)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(49, 50)
        Me.btnResta.TabIndex = 14
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 447)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.dgvRespuesta)
        Me.Controls.Add(Me.dgvMatriz2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtColumnas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilas)
        Me.Controls.Add(Me.dgvMatriz1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvMatriz1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMatriz2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRespuesta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvMatriz1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFilas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtColumnas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvMatriz2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvRespuesta As System.Windows.Forms.DataGridView
    Friend WithEvents btnSuma As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnResta As System.Windows.Forms.Button

End Class
