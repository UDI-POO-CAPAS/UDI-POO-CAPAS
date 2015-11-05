Public Class frmPais

    Public vSeEdito As Boolean
    Private vIdPais As String

    Public Sub New(ByVal pIdPais As String)
        InitializeComponent()

        vIdPais = pIdPais

        If pIdPais.Equals("") = False Then
            oPaises.TraerPais(pIdPais)

            txtId.Enabled = False

            txtId.Text = oPaises.IdPais
            txtNombre.Text = oPaises.Nombre

            vSeEdito = False
        End If
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

        Validar = True
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Validar() = False Then Exit Sub

        If vIdPais.Equals("") Then

            If oPaises.ExistePais(Trim(txtId.Text)) Then
                MessageBox.Show("Ya existe un pais con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtId.Focus()
                Exit Sub
            End If

            oPaises.IdPais = Trim(txtId.Text)
            oPaises.Nombre = Trim(txtNombre.Text)
            oPaises.Insertar()

        Else

            oPaises.Nombre = Trim(txtNombre.Text)
            oPaises.Actualizar()

        End If

        vSeEdito = True

        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class