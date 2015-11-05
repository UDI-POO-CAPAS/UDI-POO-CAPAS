Imports System.Data.OleDb

Public Class frmProvincia

    Public vSeEdito As Boolean
    Private vIdProvincia As String

    Public Sub New(ByVal pIdProvincia As String)
        InitializeComponent()

        vIdProvincia = pIdProvincia

        Call CargarPaises()

        If pIdProvincia.Equals("") = False Then
            oProvincias.TraerProvincia(pIdProvincia)

            txtId.Enabled = False

            txtId.Text = oProvincias.IdProvincia
            txtNombre.Text = oProvincias.Nombre

            For i As Integer = 0 To cboPais.Items.Count - 1
                cboPais.SelectedIndex = i
                If cboPais.Items(cboPais.SelectedIndex).ItemData = oProvincias.IdPais Then Exit For
            Next

            vSeEdito = False
        End If
    End Sub

    Private Sub CargarPaises()
        Dim drPaises As OleDbDataReader = oPaises.TraerPaises("")

        cboPais.Items.Clear()

        While drPaises.Read()
            cboPais.Items.Add(New Combo_ItemData(Trim(drPaises("idPais")) & " - " & Trim(drPaises("nombre")), Trim(drPaises("idPais"))))
        End While

        drPaises.Close()
        drPaises = Nothing
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

        If cboPais.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un Pais.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboPais.Focus()
            Exit Function
        End If

        Validar = True
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Validar() = False Then Exit Sub

        If vIdProvincia.Equals("") Then

            If oProvincias.ExisteProvincia(Trim(txtId.Text)) Then
                MessageBox.Show("Ya existe una provincia con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtId.Focus()
                Exit Sub
            End If

            oProvincias.IdProvincia = Trim(txtId.Text)
            oProvincias.Nombre = Trim(txtNombre.Text)
            oProvincias.IdPais = CStr(cboPais.Items(cboPais.SelectedIndex).ItemData)

            oProvincias.Insertar()

        Else

            oProvincias.Nombre = Trim(txtNombre.Text)
            oProvincias.IdPais = CStr(cboPais.Items(cboPais.SelectedIndex).ItemData)
            oProvincias.Actualizar()

        End If

        vSeEdito = True

        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class