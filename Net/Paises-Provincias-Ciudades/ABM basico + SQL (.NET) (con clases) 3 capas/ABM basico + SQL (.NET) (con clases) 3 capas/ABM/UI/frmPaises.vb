Imports System.Data.OleDb

Public Class frmPaises

    Private Sub ConfigurarGrilla()
        With lvPaises
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

    Private Sub CargarPaises(ByVal pNombre As String)

        Dim oLV As ListViewItem
        Dim drPaises As OleDbDataReader = oPaises.TraerPaises(pNombre)

        lvPaises.Visible = False
        lvPaises.Items.Clear()

        While drPaises.Read()
            oLV = New ListViewItem(Trim(drPaises("idPais")))
            oLV.SubItems.Add(Trim(drPaises("nombre")))
            oLV.BackColor = Drawing.Color.BlanchedAlmond

            lvPaises.Items.Add(oLV)
        End While

        drPaises.Close()
        drPaises = Nothing

        lvPaises.Visible = True

        If lvPaises.Items.Count > 0 Then
            lvPaises.Items(0).Selected = True
            lblCantidad.Text = "Cantidad de Paises: " & lvPaises.Items.Count
            mnuEliminar.Enabled = True
            mnuEditar.Enabled = True
        Else
            lblCantidad.Text = "No Hay Paises"
            mnuEliminar.Enabled = False
            mnuEditar.Enabled = False
        End If
    End Sub

    Private Sub Editar()
        If lvPaises.SelectedIndices.Count > 0 Then

            Dim vForm As New frmPais(CStr(lvPaises.Items(lvPaises.SelectedIndices.Item(0)).SubItems(0).Text()))

            vForm.Text = "Editando '" & CStr(lvPaises.Items(lvPaises.SelectedIndices.Item(0)).SubItems(1).Text() & "'")
            vForm.ShowDialog()

            If vForm.vSeEdito = True Then
                Call CargarPaises(Trim(txtNombre.Text))
            End If
        Else
            MessageBox.Show("Debe seleccionar un Pais.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Agregar()
        Dim vForm As New frmPais("")
        vForm.Text = "Nuevo Pais"
        vForm.ShowDialog()

        If vForm.vSeEdito = True Then
            Call CargarPaises(Trim(txtNombre.Text))
        End If
    End Sub

    Private Sub Eliminar()
        If lvPaises.SelectedIndices.Count > 0 Then

            If MessageBox.Show("¿ Desea borrar el Pais ? " & Chr(13) & Strings.StrDup(30, "-") & Chr(13) & _
                "ID: " & CStr(lvPaises.Items(lvPaises.SelectedIndices.Item(0)).SubItems(0).Text) & Chr(13) & _
                "Nombre: " & CStr(lvPaises.Items(lvPaises.SelectedIndices.Item(0)).SubItems(1).Text), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If oPaises.Eliminar(CStr(lvPaises.Items(lvPaises.SelectedIndices.Item(0)).SubItems(0).Text)) Then
                    Call CargarPaises(Trim(txtNombre.Text))
                End If
            End If

        Else
            MessageBox.Show("Debe seleccionar un Pais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmPaises_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConfigurarGrilla()
        Call CargarPaises("")

        picImagen.Parent = picTitulo
    End Sub

    Private Sub lvPaises_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPaises.DoubleClick
        Call Editar()
    End Sub

    Private Sub lvPaises_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvPaises.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call Eliminar()
        End If
    End Sub

    Private Sub lvPaises_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvPaises.KeyPress
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
        Call CargarPaises(Trim(txtNombre.Text))
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call CargarPaises(Trim(txtNombre.Text))
        End If
    End Sub
End Class