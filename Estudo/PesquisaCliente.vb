Imports System.Data.SqlClient
Public Class PesquisaCliente
    Dim connectionString As String = "Server=PC-TNESCRITORIO\MSSQLSERVER02;Database=estudo;Integrated Security=True;"

    ' Variável para armazenar o tipo do formulário
    Private TipoForm As String

    ' Referência à instância do formulário PedidoDeVenda
    Private PedidoVendaInstance As PedidoDeVenda

    Public Sub New(tipo As String, pedidoVenda As PedidoDeVenda)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        TipoForm = tipo
        'Adicione qualquer inicialização após a chamada InitializeComponent().

        PedidoVendaInstance = pedidoVenda ' Atribui a instância de PedidoDeVenda
    End Sub
    Private Sub btnExtrato_Click(sender As Object, e As EventArgs) Handles btnExtrato.Click
        Using connection As New SqlConnection(connectionString)

            Try
                connection.Open()

                Dim query As String = "SELECT * FROM clientes WHERE nome like @nome"

                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@nome", "%" & txtNome.Text & "%")
                    command.ExecuteNonQuery()

                    ' Cria um adaptador de dados e um DataTable para armazenar os resultados
                    Dim DataAdapter As New SqlDataAdapter(command)
                    Dim DataTable As New DataTable

                    ' Preenche o DataTable com os resultados da consulta
                    DataAdapter.Fill(DataTable)

                    DataTable.Columns("id").ColumnName = "ID"
                    DataTable.Columns("nome").ColumnName = "Nome"
                    DataTable.Columns("endereco").ColumnName = "Endereço"
                    DataTable.Columns("numero").ColumnName = "Número"
                    DataTable.Columns("cidade").ColumnName = "Cidade"
                    DataTable.Columns("estado").ColumnName = "Estado"
                    DataTable.Columns("email").ColumnName = "E-mail"

                    ' Define a fonte de dados do DataGridView para o DataTable preenchido
                    DataGridViewCliente.DataSource = DataTable

                End Using

            Catch ex As Exception
                MessageBox.Show("Erro banco de dados " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DataGridViewCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCliente.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim nomeColuna As String = "Nome"

            If DataGridViewCliente.Columns(e.ColumnIndex).HeaderText = nomeColuna Then
                Dim Row As DataGridViewRow = DataGridViewCliente.Rows(e.RowIndex)

                Dim nomeCliente As String = Row.Cells("Nome").Value.ToString()

                ' Ações dependendo do tipo de formulário

                If TipoForm = "CadastroCliente" Then 'Se abriu a pesquisa de cliente atravez do formCadastroCliente
                    ' Preenche os campos do formulário de cadastro com os dados do cliente selecionado
                    CadastroClientes.txtIdUsuario.Text = Row.Cells("ID").Value.ToString
                    CadastroClientes.txtNome.Text = Row.Cells("Nome").Value.ToString
                    CadastroClientes.txtEndereco.Text = Row.Cells("Endereço").Value.ToString
                    CadastroClientes.txtNumero.Text = Row.Cells("Número").Value.ToString
                    CadastroClientes.txtCidade.Text = Row.Cells("Cidade").Value.ToString
                    CadastroClientes.cmbEstado.Text = Row.Cells("Estado").Value.ToString
                    CadastroClientes.txtEmail.Text = Row.Cells("E-mail").Value.ToString


                    CadastroClientes.btnEditar.Enabled = True
                    CadastroClientes.btnCancelar.Enabled = True
                    CadastroClientes.btnNovo.Enabled = False

                    Me.Hide()
                ElseIf TipoForm = "PedidoDeVenda" Then 'Se abriu a pesquisa de cliente atravez do formPedidoDeVenda
                    PedidoVendaInstance.txtNomeCliente.Text = nomeCliente
                    PedidoVendaInstance.txtIdCliente.Text = Row.Cells("ID").Value.ToString
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub PesquisaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridViewCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCliente.CellContentClick

    End Sub
End Class