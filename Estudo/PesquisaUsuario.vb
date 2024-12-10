Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class PesquisaUsuario
    Dim connectionString As String = "Server=NomeServidor;Database=estudo;Integrated Security=True;"

    Private Sub btnExtrato_Click(sender As Object, e As EventArgs) Handles btnExtrato.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Consulta para buscar os dados do usuário
                Dim query As String = "SELECT id, nome, endereco, numero, cidade, estado, email, senha FROM cadastro WHERE nome LIKE @nome"
                Dim command As New SqlCommand(query, connection)
                'concatena % antes e depois para usar o like na consulta
                command.Parameters.AddWithValue("@nome", "%" & txtNome.Text & "%")

                ' Preenche um DataTable com os resultados da consulta
                Dim dataTable As New DataTable
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                ' Mascara a senha com asteriscos
                For Each row As DataRow In dataTable.Rows
                    row("senha") = New String("*"c, row("senha").ToString.Length)
                Next

                'Ajusta como os nomes das colunas vão aparecer para o usuario
                dataTable.Columns("id").ColumnName = "ID"
                dataTable.Columns("nome").ColumnName = "Nome"
                dataTable.Columns("endereco").ColumnName = "Endereço"
                dataTable.Columns("numero").ColumnName = "Número"
                dataTable.Columns("cidade").ColumnName = "Cidade"
                dataTable.Columns("estado").ColumnName = "Estado"
                dataTable.Columns("email").ColumnName = "E-mail"
                dataTable.Columns("senha").ColumnName = "Senha"

                ' Atribui o DataTable ao DataGridView
                DataGridViewUsuario.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar dados: " & ex.Message)
        End Try
    End Sub
    Private Sub DataGridViewUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUsuario.CellClick
        'verifica se o clique foi dentro de uma célula válida, e não no cabeçalho da DataGridView.
        'indice da linha (e.RowIndex) e índice da coluna (e.ColumnIndex) devem ser maiores ou iguais a zero.
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            'define o nome da coluna que deseja verificar se foi clicada.
            Dim nomeColuna As String = "Nome"

            'compara o nome da coluna clicada com o nome da coluna de interesse (nomeColuna)
            If DataGridViewUsuario.Columns(e.ColumnIndex).HeaderText = nomeColuna Then

                'variável row do tipo DataGridViewRow, atribui a linha correspondente ao índice e.RowIndex (linha onde ocorreu o clique)
                Dim row As DataGridViewRow = DataGridViewUsuario.Rows(e.RowIndex)

                'Obtém o valor da célula na coluna "Nome" da linha clicada e o converte para uma string para exibição na caixa de texto txtNome
                Cadastro.txtNome.Text = row.Cells("Nome").Value.ToString
                Cadastro.txtEndereco.Text = row.Cells("Endereço").Value.ToString
                Cadastro.txtNumero.Text = row.Cells("Número").Value.ToString
                Cadastro.txtCidade.Text = row.Cells("Cidade").Value.ToString
                Cadastro.cmbEstado.Text = row.Cells("Estado").Value.ToString
                Cadastro.txtEmail.Text = row.Cells("E-mail").Value.ToString
                Cadastro.txtSenha.Text = row.Cells("Senha").Value.ToString
                Cadastro.txtIdUsuario.Text = row.Cells("ID").Value.ToString

                'deixa o campo como somente leitura
                Cadastro.txtNome.ReadOnly = True
                Cadastro.txtEndereco.ReadOnly = True
                Cadastro.txtNumero.ReadOnly = True
                Cadastro.txtCidade.ReadOnly = True
                Cadastro.cmbEstado.Enabled = False
                Cadastro.txtEmail.ReadOnly = True
                Cadastro.txtSenha.ReadOnly = True
                Cadastro.txtIdUsuario.ReadOnly = True

                Cadastro.btnEditar.Enabled = True
                Cadastro.btnNovo.Enabled = False
                Cadastro.btnCancelar.Enabled = True
                Cadastro.btnExcluir.Enabled = False

                Me.Hide()

            End If
        End If
    End Sub


    'Private Function HashPassword(password As String) As String
    '    ' Utiliza o algoritmo SHA-256 para gerar um hash da senha
    '    Using sha256 As New SHA256Managed()
    '        Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
    '        Return Convert.ToBase64String(hashedBytes)
    '    End Using
    'End Function
End Class
