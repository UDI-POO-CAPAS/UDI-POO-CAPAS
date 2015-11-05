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
        Me.btnCuadrado = New System.Windows.Forms.Button()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnRectangulo = New System.Windows.Forms.Button()
        Me.btnTriangulo = New System.Windows.Forms.Button()
        Me.btnCirculo = New System.Windows.Forms.Button()
        Me.txtRadio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCuadrado
        '
        Me.btnCuadrado.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuadrado.Location = New System.Drawing.Point(286, 46)
        Me.btnCuadrado.Name = "btnCuadrado"
        Me.btnCuadrado.Size = New System.Drawing.Size(75, 32)
        Me.btnCuadrado.TabIndex = 0
        Me.btnCuadrado.Text = "Cuadrado"
        Me.btnCuadrado.UseVisualStyleBackColor = True
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(194, 58)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(55, 20)
        Me.txtBase.TabIndex = 1
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(111, 58)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(39, 24)
        Me.lblBase.TabIndex = 2
        Me.lblBase.Text = "Base"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(194, 85)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(55, 20)
        Me.txtAltura.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Altura"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(194, 160)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(167, 20)
        Me.txtResultado.TabIndex = 5
        '
        'btnRectangulo
        '
        Me.btnRectangulo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRectangulo.Location = New System.Drawing.Point(286, 124)
        Me.btnRectangulo.Name = "btnRectangulo"
        Me.btnRectangulo.Size = New System.Drawing.Size(88, 32)
        Me.btnRectangulo.TabIndex = 6
        Me.btnRectangulo.Text = "Rectangulo"
        Me.btnRectangulo.UseVisualStyleBackColor = True
        '
        'btnTriangulo
        '
        Me.btnTriangulo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTriangulo.Location = New System.Drawing.Point(286, 85)
        Me.btnTriangulo.Name = "btnTriangulo"
        Me.btnTriangulo.Size = New System.Drawing.Size(75, 33)
        Me.btnTriangulo.TabIndex = 7
        Me.btnTriangulo.Text = "Triangulo"
        Me.btnTriangulo.UseVisualStyleBackColor = True
        '
        'btnCirculo
        '
        Me.btnCirculo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCirculo.Location = New System.Drawing.Point(286, 186)
        Me.btnCirculo.Name = "btnCirculo"
        Me.btnCirculo.Size = New System.Drawing.Size(75, 33)
        Me.btnCirculo.TabIndex = 8
        Me.btnCirculo.Text = "Circulo"
        Me.btnCirculo.UseVisualStyleBackColor = True
        '
        'txtRadio
        '
        Me.txtRadio.Location = New System.Drawing.Point(194, 196)
        Me.txtRadio.Name = "txtRadio"
        Me.txtRadio.Size = New System.Drawing.Size(60, 20)
        Me.txtRadio.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Radio Circunferencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "AREA DE FIGURAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(472, 260)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRadio)
        Me.Controls.Add(Me.btnCirculo)
        Me.Controls.Add(Me.btnTriangulo)
        Me.Controls.Add(Me.btnRectangulo)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.btnCuadrado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCuadrado As System.Windows.Forms.Button
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents btnRectangulo As System.Windows.Forms.Button
    Friend WithEvents btnTriangulo As System.Windows.Forms.Button
    Friend WithEvents btnCirculo As System.Windows.Forms.Button
    Friend WithEvents txtRadio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
