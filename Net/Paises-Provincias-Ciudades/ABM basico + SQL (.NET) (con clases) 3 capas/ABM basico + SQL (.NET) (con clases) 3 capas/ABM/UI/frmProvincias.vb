Imports System.Data.OleDb

Public Class frmProvincias

    Private Sub ConfigurarGrilla()
        With lvProvincias
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

    Private Sub CargarProvincias(ByVal pNombre As String)

        Dim vIdPais As String = ""

        If cboPais.SelectedIndex <> -1 Then
            vIdPais = CStr(cboPais.Items(cboPais.SelectedIndex).ItemData)
        End If

        Dim oLV As ListViewItem
        Dim drProvincias As OleDbDataReader = oProvincias.TraerProvincias(vIdPais, pNombre)

        lvProvincias.Visible = False
        lvProvincias.Items.Clear()

        While drProvincias.Read()
            oLV = New ListViewItem(Trim(drProvincias("idProvincia")))
            oLV.SubItems.Add(Trim(drProvincias("nombre")))
            oLV.BackColor = Drawing.Color.BlanchedAlmond

            lvProvincias.Items.Add(oLV)
        End While

        drProvincias.Close()
        drProvincias = Nothing

        lvProvincias.Visible = True

        If lvProvincias.Items.Count > 0 Then
            lvProvincias.Items(0).Selected = True
            lblCantidad.Text = "Cantidad de Provincias: " & lvProvincias.Items.Count
            mnuEliminar.Enabled = True
            mnuEditar.Enabled = True
        Else
            lblCantidad.Text = "No Hay Provincias"
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

    Private Sub Editar()
        If lvProvincias.SelectedIndices.Count > 0 Then

            Dim vForm As New frmProvincia(CStr(lvProvincias.Items(lvProvincias.SelectedIndices.Item(0)).SubItems(0).Text()))

            vForm.Text = "Editando '" & CStr(lvProvincias.Items(lvProvincias.SelectedIndices.Item(0)).SubItems(1).Text() & "'")
            vForm.ShowDialog()

            If vForm.vSeEdito = True Then
                Call CargarProvincias(Trim(txtNombre.Text))
            End If
        Else
            MessageBox.Show("Debe seleccionar una Provincia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Agregar()
        Dim vForm As New frmProvincia("")
        vForm.Text = "Nueva Provincia"
        vForm.ShowDialog()

        If vForm.vSeEdito = True Then
            Call CargarProvincias(Trim(txtNombre.Text))
        End If
    End Sub

    Private Sub Eliminar()
        If lvProvincias.SelectedIndices.Count > 0 Then

            If MessageBox.Show("¿ Desea borrar la Provincia ? " & Chr(13) & Strings.StrDup(30, "-") & Chr(13) & _
                "ID: " & CStr(lvProvincias.Items(lvProvincias.SelectedIndices.Item(0)).SubItems(0).Text) & Chr(13) & _
                "Nombre: " & CStr(lvProvincias.Items(lvProvincias.SelectedIndices.Item(0)).SubItems(1).Text), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If oProvincias.Eliminar(CStr(lvProvincias.Items(lvProvincias.SelectedIndices.Item(0)).SubItems(0).Text)) Then
                    Call CargarProvincias(Trim(txtNombre.Text))
                End If
            End If

        Else
            MessageBox.Show("Debe seleccionar una Provincia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmProvincias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConfigurarGrilla()
        Call CargarPaises()
        Call CargarProvincias("")

        picImagen.Parent = picTitulo
    End Sub

    Private Sub lvProvincias_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvProvincias.DoubleClick
        Call Editar()
    End Sub

    Private Sub lvProvincias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvProvincias.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call Eliminar()
        End If
    End Sub

    Private Sub lvProvincias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvProvincias.KeyPress
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
        Call CargarProvincias(Trim(txtNombre.Text))
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call CargarProvincias(Trim(txtNombre.Text))
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = String.Empty
        cboPais.SelectedIndex = -1
    End Sub
End Class