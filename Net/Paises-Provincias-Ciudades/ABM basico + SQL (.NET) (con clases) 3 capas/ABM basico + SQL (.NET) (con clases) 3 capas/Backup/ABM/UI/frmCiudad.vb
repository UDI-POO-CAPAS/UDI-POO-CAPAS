Imports System.Data.OleDb

Public Class frmCiudad

    Public vSeEdito As Boolean
    Private vIdCiudad As String

    Public Sub New(ByVal pIdCiudad As String)
        InitializeComponent()

        vIdCiudad = pIdCiudad

        Call CargarProvincias()

        If pIdCiudad.Equals("") = False Then
            oCiudades.TraerCiudad(pIdCiudad)

            txtId.Enabled = False
            txtId.Text = oCiudades.IdProvincia
            txtNombre.Text = oCiudades.Nombre

            For i As Integer = 0 To cboProvincia.Items.Count - 1
                cboProvincia.SelectedIndex = i
                If cboProvincia.Items(cboProvincia.SelectedIndex).ItemData = oCiudades.IdProvincia Then Exit For
            Next

            vSeEdito = False
        End If
    End Sub

    Private Sub CargarProvincias()
        Dim drProvincias As OleDbDataReader = oProvincias.TraerProvincias("", "")

        cboProvincia.Items.Clear()

        While drProvincias.Read()
            cboProvincia.Items.Add(New Combo_ItemData(Trim(drProvincias("idProvincia")) & " - " & Trim(drProvincias("nombre")), Trim(drProvincias("idProvincia"))))
        End While

        drProvincias.Close()
        drProvincias = Nothing
    End Sub

    Private Function Validar() As Boolean
        Validar = False

        If txtId.Text.Equals("") Then
            MessageBox.Show("Debe escribir un ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId.Focus()
            Exit Function
        End If

        If txtNombre.Text.Equals("") Then
            MessageBox.Show("Debe escribir un nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Focus()
            Exit Function
        End If

        If cboProvincia.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una Provincia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboProvincia.Focus()
            Exit Function
        End If

        Validar = True
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Validar() = False Then Exit Sub

        If vIdCiudad.Equals("") Then

            If oCiudades.ExisteCiudad(Trim(txtId.Text)) Then
                MessageBox.Show("Ya existe una ciudad con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtId.Focus()
                Exit Sub
            End If

            oCiudades.IdCiudad = Trim(txtId.Text)
            oCiudades.Nombre = Trim(txtNombre.Text)
            oCiudades.IdProvincia = CStr(cboProvincia.Items(cboProvincia.SelectedIndex).ItemData)

            oCiudades.Insertar()

        Else

            oCiudades.Nombre = Trim(txtNombre.Text)
            oCiudades.IdProvincia = CStr(cboProvincia.Items(cboProvincia.SelectedIndex).ItemData)
            oCiudades.Actualizar()

        End If

        vSeEdito = True

        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class