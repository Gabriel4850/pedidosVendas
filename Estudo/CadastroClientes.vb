Imports System.Data.SqlClient

Public Class CadastroClientes
    Dim connectionString As String = "Server=NomeServidor;Database=estudo;Integrated Security=True;"
    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Using connection As New SqlConnection(connectionString)

            Try
                connection.Open()

                If Not String.IsNullOrEmpty(txtIdUsuario.Text) Then
                    Dim queryUpdate As String = "UPDATE clientes
                                                SET nome = @nome, endereco = @endereco, numero = @numero, cidade = @cidade, estado = @estado, email = @email
                                                WHERE  Id = @id"

                    Using Command As New SqlCommand(queryUpdate, connection)
                        Command.Parameters.AddWithValue("@id", txtIdUsuario.Text)
                        Command.Parameters.AddWithValue("@nome", txtNome.Text)
                        Command.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                        Command.Parameters.AddWithValue("@numero", txtNumero.Text)
                        Command.Parameters.AddWithValue("@cidade", txtCidade.Text)
                        Command.Parameters.AddWithValue("@estado", cmbEstado.Text)
                        Command.Parameters.AddWithValue("@email", txtEmail.Text)

                        Command.ExecuteNonQuery()

                        MessageBox.Show("Cadastro atualizado com sucesso")

                        btnEditar.Enabled = False
                        btnNovo.Enabled = True
                        btnCancelar.Enabled = False
                        btnExcluir.Enabled = False

                        LimpaCampos()
                    End Using
                Else

                    ' verificar se o nome digitado já existe no banco de dados
                    Dim query = "SELECT COUNT(*) FROM clientes WHERE nome = @nome"

                    Using Command As New SqlCommand(query, connection)

                        ' executa a query
                        ' @nome vai receber o conteudo de txtNome.text
                        Command.Parameters.AddWithValue("@nome", txtNome.Text)
                        'Command.ExecuteScalar()

                        ' convert o resultado da query p/ int p/ usar no if
                        Dim resultado = Convert.ToInt32(Command.ExecuteScalar)
                        ' query retornar 1 (tem registro desse nome no banco)
                        If resultado = 1 Then
                            MessageBox.Show("Nome de usuário já existe")
                            ' Bloqueia o botão de cadastrar
                            btnCadastrar.Enabled = False
                        Else

                            Dim queryInsert = "INSERT INTO clientes (nome,endereco,numero,cidade,estado,email) VALUES (@nome2,@endereco,@numero,@cidade,@estado,@email)"

                            Using Command2 As New SqlCommand(queryInsert, connection)

                                Dim numero As Integer

                                If Integer.TryParse(txtNumero.Text, numero) Then
                                    Command2.Parameters.AddWithValue("@numero", txtNumero.Text)
                                    Command2.Parameters.AddWithValue("@nome2", txtNome.Text)
                                    Command2.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                                    Command2.Parameters.AddWithValue("@cidade", txtCidade.Text)
                                    Command2.Parameters.AddWithValue("@estado", cmbEstado.Text)
                                    Command2.Parameters.AddWithValue("@email", txtEmail.Text)

                                    Command2.ExecuteNonQuery

                                    MessageBox.Show("Dados cadastrados com sucesso")

                                    btnCadastrar.Enabled = False
                                Else
                                    MessageBox.Show("Número inválido")
                                    Return
                                End If

                                LimpaCampos()

                                btnCadastrar.Enabled = False

                            End Using

                            validaCampos
                        End If
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Erro de conexão com banco de dados " & ex.Message)
            End Try

        End Using

    End Sub

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged

        validaCampos()

    End Sub

    Private Sub txtEndereco_TextChanged(sender As Object, e As EventArgs) Handles txtEndereco.TextChanged
        validaCampos()
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        Dim pedidoVendaInstance As New PedidoDeVenda("PedidoDeVenda")
        Dim pesquisaCliente As New PesquisaCliente("CadastroCliente", pedidoVendaInstance)
        pesquisaCliente.Show()
    End Sub

    Private Function TodosCamposPreenchidos() As Boolean
        'Return Not (String.IsNullOrEmpty(txtNome.Text) OrElse
        '    String.IsNullOrEmpty(txtEndereco.Text) OrElse
        '    String.IsNullOrEmpty(txtNumero.Text) OrElse
        '    String.IsNullOrEmpty(cmbEstado.Text) OrElse
        '    String.IsNullOrEmpty(txtCidade.Text))

        ' Verifica se algum campo é ReadOnly ou está vazio
        Return Not (String.IsNullOrEmpty(txtNome.Text) OrElse
            String.IsNullOrEmpty(txtEndereco.Text) OrElse
            String.IsNullOrEmpty(txtNumero.Text) OrElse
            String.IsNullOrEmpty(cmbEstado.Text) OrElse
            String.IsNullOrEmpty(txtCidade.Text) OrElse
            txtNome.ReadOnly OrElse
            txtEndereco.ReadOnly OrElse
            txtNumero.ReadOnly OrElse
            cmbEstado.Enabled = False OrElse
            txtCidade.ReadOnly)
    End Function

    Private Sub validaCampos()
        If TodosCamposPreenchidos() Then
            btnCadastrar.Enabled = True
        Else
            btnCadastrar.Enabled = False
        End If
    End Sub

    Private Sub LimpaCampos()
        txtNome.Enabled = False
        txtEndereco.Enabled = False
        txtNumero.Enabled = False
        txtCidade.Enabled = False
        cmbEstado.Enabled = False
        txtEmail.Enabled = False
        txtIdUsuario.Enabled = False

        txtIdUsuario.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCidade.Text = ""
        cmbEstado.SelectedIndex = -1
        txtEmail.Text = ""
    End Sub

    Private Sub CadastroClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpaCampos()
        validaCampos()
        btnVoltar.Visible = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False

    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        validaCampos()
    End Sub

    Private Sub txtCidade_TextChanged(sender As Object, e As EventArgs) Handles txtCidade.TextChanged
        validaCampos()
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        validaCampos()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub CadastroClientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        validaCampos()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtNome.Enabled = True
        txtEndereco.Enabled = True
        txtNumero.Enabled = True
        txtCidade.Enabled = True
        cmbEstado.Enabled = True
        txtEmail.Enabled = True

        txtIdUsuario.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCidade.Text = ""
        cmbEstado.SelectedIndex = -1 ' Limpa a seleção do ComboBox
        txtEmail.Text = ""

        btnCancelar.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaCampos()

        btnCancelar.Enabled = False
        btnEditar.Enabled = False
        btnNovo.Enabled = True
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtNome.Enabled = True
        txtEndereco.Enabled = True
        txtNumero.Enabled = True
        txtCidade.Enabled = True
        cmbEstado.Enabled = True
        txtEmail.Enabled = True

        btnCancelar.Enabled = True
        btnExcluir.Enabled = True
        btnNovo.Enabled = False

        validaCampos()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim resultado As DialogResult

                resultado = MessageBox.Show("Tem certeza que quer excluir o cadastro desse cliente?", "Excluir:", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resultado = DialogResult.Yes Then

                    Dim query As String = "DELETE clientes WHERE id = @id"

                    Using Command As New SqlCommand(query, connection)
                        Command.Parameters.AddWithValue("@id", txtIdUsuario.Text)
                        Command.ExecuteNonQuery()

                        MessageBox.Show("Cadastro excluido com sucesso")

                        btnEditar.Enabled = False
                        btnCancelar.Enabled = False
                        btnExcluir.Enabled = False
                        btnNovo.Enabled = True

                        LimpaCampos()
                    End Using

                End If
            Catch ex As Exception
                MessageBox.Show("Erro banco de dados: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

    End Sub
End Class
