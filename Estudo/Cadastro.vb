Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports Windows.Win32.System

Public Class Cadastro
    ' conexão com o banco de dados
    Dim connectionString As String = "Server=NomeServidor;Database=estudo;Integrated Security=True;"


    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        Using connection As New SqlConnection(connectionString)

            Try
                connection.Open()

                'Se com txtIdUsuario.Text não estiver vazaio ou nulo (significa que o cadastro já existe), faz o update
                If Not String.IsNullOrEmpty(txtIdUsuario.Text) Then
                    Dim queryUpdate As String = "UPDATE cadastro
                                                SET nome = @nome, endereco = @endereco, numero = @numero, cidade = @cidade, estado = @estado, email = @email, senha = @senha
                                                WHERE  id = @id"
                    Using Command As New SqlCommand(queryUpdate, connection)

                        Command.Parameters.AddWithValue("@id", txtIdUsuario.Text)
                        Command.Parameters.AddWithValue("@nome", txtNome.Text)
                        Command.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                        Command.Parameters.AddWithValue("@numero", txtNumero.Text)
                        Command.Parameters.AddWithValue("@cidade", txtCidade.Text)
                        Command.Parameters.AddWithValue("@estado", cmbEstado.Text)
                        Command.Parameters.AddWithValue("@email", txtEmail.Text)
                        Command.Parameters.AddWithValue("@senha", txtSenha.Text)

                        Command.ExecuteNonQuery()

                        MessageBox.Show("Cadastro atualizado com sucesso")

                        ValidarCampos()
                        LimpaCampos()

                    End Using

                Else

                    ' verificar se o nome digitado já existe no banco de dados
                    Dim query = "SELECT COUNT(*) FROM cadastro WHERE nome = @nome"

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
                            Dim queryInsert = "INSERT INTO cadastro (nome,endereco,numero,cidade,estado,email,senha) 
                                               VALUES (@nome2,@endereco,@numero,@cidade,@estado,@email,@senha)"

                            Using Command2 As New SqlCommand(queryInsert, connection)

                                Dim numero As Integer
                                ' Converter o numero.text em int para salvar no banco de dados
                                If Integer.TryParse(txtNumero.Text, numero) Then
                                    Command2.Parameters.AddWithValue("@numero", txtNumero.Text)
                                    Command2.Parameters.AddWithValue("@nome2", txtNome.Text)
                                    Command2.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                                    Command2.Parameters.AddWithValue("@cidade", txtCidade.Text)
                                    Command2.Parameters.AddWithValue("estado", cmbEstado.Text)
                                    Command2.Parameters.AddWithValue("email", txtEmail.Text)
                                    Command2.Parameters.AddWithValue("@senha", txtSenha.Text)

                                    Command2.ExecuteNonQuery()

                                    MessageBox.Show("Dados salvos com sucesso!")

                                    btnCadastrar.Enabled = False
                                Else

                                    MessageBox.Show("Campo número inválido")
                                    Return

                                End If
                            End Using

                            ValidarCampos()

                            LimpaCampos()

                        End If

                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message)

            End Try

        End Using
    End Sub
    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltar.Visible = False
        LimpaCampos()

    End Sub
    Private Function TodosCamposPreenchidos() As Boolean ' Fução para verificar se todos os campos estão preenchidos

        ' String.IsNullOrEmpty(txtNome.Text) verifica se o texto no campo txtNome está vazio ou é Nothing (nulo)
        ' OrElse operador lógico, se o primeiro operando for verdadeiro, o segundo operando não é avaliado 
        '' Not inverte o resultado, então a função retorna True apenas se nenhum campo estiver vazio
        'Return Not (String.IsNullOrEmpty(txtNome.Text) OrElse
        '    String.IsNullOrEmpty(txtEndereco.Text) OrElse
        '    String.IsNullOrEmpty(txtNumero.Text) OrElse
        '    String.IsNullOrEmpty(txtCidade.Text) OrElse
        '    String.IsNullOrEmpty(txtSenha.Text))

        ' Verifica se algum campo é ReadOnly ou está vazio
        Return Not (String.IsNullOrEmpty(txtNome.Text) OrElse
            String.IsNullOrEmpty(txtEndereco.Text) OrElse
            String.IsNullOrEmpty(txtNumero.Text) OrElse
            String.IsNullOrEmpty(cmbEstado.Text) OrElse
            String.IsNullOrEmpty(txtCidade.Text) OrElse
            String.IsNullOrEmpty(txtEmail.Text) OrElse
            String.IsNullOrEmpty(txtSenha.Text) OrElse
            txtNome.ReadOnly OrElse
            txtEndereco.ReadOnly OrElse
            txtNumero.ReadOnly OrElse
            cmbEstado.Enabled = False OrElse
            txtCidade.ReadOnly OrElse
            txtSenha.ReadOnly)
    End Function
    Private Sub ValidarCampos()
        If TodosCamposPreenchidos() Then
            btnCadastrar.Enabled = True
        Else
            btnCadastrar.Enabled = False
        End If
    End Sub
    Private Sub txtEndereco_TextChanged(sender As Object, e As EventArgs) Handles txtEndereco.TextChanged
        ValidarCampos()
    End Sub
    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        ValidarCampos()
    End Sub
    Private Sub txtCidade_TextChanged(sender As Object, e As EventArgs) Handles txtCidade.TextChanged
        ValidarCampos()
    End Sub
    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs) Handles txtSenha.TextChanged
        ValidarCampos()
    End Sub
    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        PesquisaUsuario.Show()
    End Sub
    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        ValidarCampos()
    End Sub

    Private Sub Cadastro_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ValidarCampos()
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        txtNome.ReadOnly = False
        txtEndereco.ReadOnly = False
        txtNumero.ReadOnly = False
        txtCidade.ReadOnly = False
        cmbEstado.Enabled = True
        txtEmail.ReadOnly = False
        txtSenha.ReadOnly = False

        btnCancelar.Enabled = True
        btnExcluir.Enabled = True
        btnNovo.Enabled = False

        ValidarCampos()

    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        ValidarCampos()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ValidarCampos()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtNome.ReadOnly = False
        txtEndereco.ReadOnly = False
        txtNumero.ReadOnly = False
        txtCidade.ReadOnly = False
        cmbEstado.Enabled = True
        txtEmail.ReadOnly = False
        txtSenha.ReadOnly = False

        btnCancelar.Enabled = True
        btnExcluir.Enabled = False

        ValidarCampos()
    End Sub

    Private Sub LimpaCampos()
        txtIdUsuario.ReadOnly = True
        txtNome.ReadOnly = True
        txtEndereco.ReadOnly = True
        txtNumero.ReadOnly = True
        cmbEstado.Enabled = False
        txtCidade.ReadOnly = True
        txtEmail.ReadOnly = True
        txtSenha.ReadOnly = True

        txtIdUsuario.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCidade.Text = ""
        cmbEstado.SelectedIndex = -1
        txtEmail.Text = ""
        txtSenha.Text = ""

        btnCadastrar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
        btnNovo.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaCampos()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Using connection As New SqlConnection(connectionString)

            Dim resultado As DialogResult

            resultado = MessageBox.Show("Tem certeza que quer excluir esse usuário?", "Excluir:", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then

                Try
                    connection.Open()

                    Dim query As String = "DELETE cadastro WHERE ID = @id"

                    Using Command As New SqlCommand(query, connection)

                        Command.Parameters.AddWithValue("@id", txtIdUsuario.Text)

                        Command.ExecuteNonQuery()

                        MessageBox.Show("Usuário excluido com sucesso")
                    End Using
                    LimpaCampos()
                Catch ex As Exception
                    MessageBox.Show("Erro banco de dados " & ex.Message)
                End Try
            End If
        End Using
    End Sub
End Class

