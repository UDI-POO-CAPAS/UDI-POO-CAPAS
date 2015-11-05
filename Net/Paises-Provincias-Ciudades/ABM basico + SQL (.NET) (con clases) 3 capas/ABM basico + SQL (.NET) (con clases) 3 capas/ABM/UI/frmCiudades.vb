Imports System.Data.OleDb

Public Class frmCiudades

    Private Sub ConfigurarGrilla()
        With lvCiudades
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .HotTracking = False
            .HoverSelection = False
            .Columns.Clear()
            .Activation = ItemActivation.OneClick
            .Columns.Add("ID", 40, HorizontalAlignment.Right)
            .Columns.Add("Nombre", -2, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub CargarCiudades(ByVal pNombre As String)

        Dim vIdPais As String = ""
        If cboPais.SelectedIndex <> -1 Then
            vIdPais = CStr(cboPais.Items(cboPais.SelectedIndex).ItemData)
        End If

        Dim vIdProvincia As String = ""
        If cboProvincia.SelectedIndex <> -1 Then
            vIdProvincia = CStr(cboProvincia.Items(cboProvincia.SelectedIndex).ItemData)
        End If

        Dim oLV As ListViewItem
        Dim drCiudades As OleDbDataReader = oCiudades.TraerCiudades(vIdPais, vIdProvincia, pNombre)

        lvCiudades.Visible = False
        lvCiudades.Items.Clear()

        While drCiudades.Read()
            oLV = New ListViewItem(Trim(drCiudades("idCiudad")))
            oLV.SubItems.Add(Trim(drCiudades("nombre")))
            oLV.BackColor = Drawing.Color.BlanchedAlmond

            lvCiudades.Items.Add(oLV)
        End While

        drCiudades.Close()
        drCiudades = Nothing

        lvCiudades.Visible = True

        If lvCiudades.Items.Count > 0 Then
            lvCiudades.Items(0).Selected = True
            lblCantidad.Text = "Cantidad de Ciudades: " & lvCiudades.Items.Count
            mnuEliminar.Enabled = True
            mnuEditar.Enabled = True
        Else
            lblCantidad.Text = "No Hay Ciudades"
            mnuEliminar.Enabled = False
            mnuEditar.Enabled = False
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

    Private Sub CargarProvincias(ByVal pIdPais As String)
        Dim drProvincias As OleDbDataReader = oProvincias.TraerProvincias(pIdPais, "")

        cboProvincia.Items.Clear()

        While drProvincias.Read()
            cboProvincia.Items.Add(New Combo_ItemData(Trim(drProvincias("idProvincia")) & " - " & Trim(drProvincias("nombre")), Trim(drProvincias("idProvincia"))))
        End While

        drProvincias.Close()
        drProvincias = Nothing
    End Sub

    Private Sub Editar()
        If lvCiudades.SelectedIndices.Count > 0 Then

            Dim vForm As New frmCiudad(CStr(lvCiudades.Items(lvCiudades.SelectedIndices.Item(0)).SubItems(0).Text()))

            vForm.Text = "Editando '" & CStr(lvCiudades.Items(lvCiudades.SelectedIndices.Item(0)).SubItems(1).Text() & "'")
            vForm.ShowDialog()

            If vForm.vSeEdito = True Then
                Call CargarCiudades(Trim(txtNombre.Text))
            End If
        Else
            MessageBox.Show("Debe seleccionar una Ciudad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Agregar()
        Dim vForm As New frmCiudad("")
        vForm.Text = "Nueva Ciudad"
        vForm.ShowDialog()

        If vForm.vSeEdito = True Then
            Call CargarCiudades(Trim(txtNombre.Text))
        End If
    End Sub

    Private Sub Eliminar()
        If lvCiudades.SelectedIndices.Count > 0 Then

            If MessageBox.Show("¿ Desea borrar la Ciudad ? " & Chr(13) & Strings.StrDup(30, "-") & Chr(13) & _
                "ID: " & CStr(lvCiudades.Items(lvCiudades.SelectedIndices.Item(0)).SubItems(0).Text) & Chr(13) & _
                "Nombre: " & CStr(lvCiudades.Items(lvCiudades.SelectedIndices.Item(0)).SubItems(1).Text), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If oCiudades.Eliminar(CStr(lvCiudades.Items(lvCiudades.SelectedIndices.Item(0)).SubItems(0).Text)) Then
                    Call CargarCiudades(Trim(txtNombre.Text))
                End If
            End If

        Else
            MessageBox.Show("Debe seleccionar una Ciudad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmCiudades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConfigurarGrilla()
        Call CargarPaises()
        'Call CargarProvincias("")
        Call CargarCiudades("")

        picImagen.Parent = picTitulo
    End Sub

    Private Sub lvCiudades_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCiudades.DoubleClick
        Call Editar()
    End Sub

    Private Sub lvCiudades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvCiudades.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call Eliminar()
        End If
    End Sub

    Private Sub lvCiudades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvCiudades.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call Editar()
        End If
    End Sub

    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Call Eliminar()
    End Sub

    Private Sub mnuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar.Click
        Call Editar()
    End Sub

    Private Sub mnuAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAgregar.Click
        Call Agregar()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Call CargarCiudades(Trim(txtNombre.Text))
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call CargarCiudades(Trim(txtNombre.Text))
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        cboPais.SelectedIndex = -1
        cboProvincia.Items.Clear()
        cboProvincia.SelectedIndex = -1
        txtNombre.Text = ""
    End Sub

    Private Sub cboPais_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPais.SelectedIndexChanged
        If cboPais.SelectedIndex = -1 Then Exit Sub
        Call CargarProvincias(CStr(cboPais.Items(cboPais.SelectedIndex).ItemData))
    End Sub

End Class