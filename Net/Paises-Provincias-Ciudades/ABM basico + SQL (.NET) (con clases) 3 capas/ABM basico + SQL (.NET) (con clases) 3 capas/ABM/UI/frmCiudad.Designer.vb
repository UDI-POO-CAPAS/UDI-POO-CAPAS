﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCiudad
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
        Me.gbPais = New System.Windows.Forms.GroupBox
        Me.cboProvincia = New System.Windows.Forms.ComboBox
        Me.lblProvincia = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblIdPais = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.gbPais.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPais
        '
        Me.gbPais.Controls.Add(Me.cboProvincia)
        Me.gbPais.Controls.Add(Me.lblProvincia)
        Me.gbPais.Controls.Add(Me.txtNombre)
        Me.gbPais.Controls.Add(Me.txtId)
        Me.gbPais.Controls.Add(Me.lblNombre)
        Me.gbPais.Controls.Add(Me.lblIdPais)
        Me.gbPais.Location = New System.Drawing.Point(12, 12)
        Me.gbPais.Name = "gbPais"
        Me.gbPais.Size = New System.Drawing.Size(358, 108)
        Me.gbPais.TabIndex = 6
        Me.gbPais.TabStop = False
        '
        'cboProvincia
        '
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(62, 69)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(171, 21)
        Me.cboProvincia.TabIndex = 6
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(6, 72)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.lblProvincia.TabIndex = 3
        Me.lblProvincia.Text = "Provincia"
        '
        'txtNombre
        '
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(62, 43)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(290, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.ForeColor = System.Drawing.Color.Blue
        Me.txtId.Location = New System.Drawing.Point(62, 18)
        Me.txtId.MaxLength = 3
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(52, 20)
        Me.txtId.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(13, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblIdPais
        '
        Me.lblIdPais.AutoSize = True
        Me.lblIdPais.Location = New System.Drawing.Point(39, 21)
        Me.lblIdPais.Name = "lblIdPais"
        Me.lblIdPais.Size = New System.Drawing.Size(18, 13)
        Me.lblIdPais.TabIndex = 0
        Me.lblIdPais.Text = "ID"
        '
        'btnAceptar
        '
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(214, 126)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(295, 126)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 155)
        Me.Controls.Add(Me.gbPais)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCiudad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbPais.ResumeLayout(False)
        Me.gbPais.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPais As System.Windows.Forms.GroupBox
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblIdPais As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
