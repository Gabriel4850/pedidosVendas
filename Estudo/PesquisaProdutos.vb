Imports System.Data.SqlClient
Imports System.Text
Public Class PesquisaProdutos
    Dim connectionString As String = "Server=NomeServidor;Database=estudo;Integrated Security=True;"

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
    Private Sub lblNomeProduto_Click(sender As Object, e As EventArgs) Handles lblNomeProduto.Click

    End Sub

    Private Sub txtNomeProduto_TextChanged(sender As Object, e As EventArgs) Handles txtNomeProduto.TextChanged
        validaCampos()
    End Sub

    Private Sub btnExtrato_Click(sender As Object, e As EventArgs) Handles btnExtrato.Click
        'Dim query As String = "SELECT * FROM produtos"


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                'Dim consultaLike As String = txtNomeProduto.Text & "%"
                Dim query As String = "SELECT * FROM produtos WHERE produto like @nome_produto"

                Using Command As New SqlCommand(query, connection)

                    Command.Parameters.AddWithValue("@nome_produto", "%" & txtNomeProduto.Text & "%")
                    Command.ExecuteNonQuery()
                    'SqlDataAdapter preenche um DataTable com os dados do banco de dados
                    Dim dataAdapter As New SqlDataAdapter(Command)
                    'Classe que representa uma tabela de dados em memória. Pode conter colunas e linhas que representam dados retornados da consulta SQL.
                    Dim dataTable As New DataTable
                    'Fill - método do SqlDataAdapter que preenche o DataTable com dados da consulta SQL.
                    'Após essa chamada o DataTable conterá as linhas e colunas retornadas pela consulta.
                    dataAdapter.Fill(dataTable)

                    ' Alterando como o nome das colunas aparecem na grid
                    dataTable.Columns("id").ColumnName = "Código"
                    dataTable.Columns("produto").ColumnName = "Produto"
                    dataTable.Columns("descricao").ColumnName = "Descrição"
                    dataTable.Columns("valor_unitario").ColumnName = "Valor Unitário"

                    'Atribui o DataTable a DataGridView1
                    DataGridView1.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao carregar dados " & ex.Message)
            End Try

        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick 'CellClick em vez de CellContentClick: CellClick é mais confiável para capturar cliques em células.
        txtNomeProduto.Enabled = False
        txtDescricao.Enabled = False
        txtValorAtual.Enabled = False
        btnEditar.Enabled = True
        btnSalvar.Enabled = False
        btnCancelar.Enabled = True
        btnAdd.Enabled = True
        btnExtrato.Enabled = True

        'verifica se o clique foi dentro de uma célula válida, e não no cabeçalho da DataGridView.
        'indice da linha (e.RowIndex) e índice da coluna (e.ColumnIndex) devem ser maiores ou iguais a zero.
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            'define o nome da coluna que deseja verificar se foi clicada.
            Dim NomeColuna As String = "Produto"

            'compara o nome da coluna clicada com o nome da coluna de interesse (NomeColuna)
            If DataGridView1.Columns(e.ColumnIndex).HeaderText = NomeColuna Then
                Dim Row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                Dim nomeProduto As String = Row.Cells("Produto").Value.ToString()

                If TipoForm = "PesquisaProduto" Then
                    'Obtém o valor da célula na coluna "Produto" da linha clicada e o converte para uma string para exibição na caixa de texto txtNomeProduto
                    txtNomeProduto.Text = Row.Cells("Produto").Value.ToString
                    txtDescricao.Text = Row.Cells("Descrição").Value.ToString
                    txtValorAtual.Text = Row.Cells("Valor Unitário").Value.ToString
                    txtIdProduto.Text = Row.Cells("Código").Value.ToString
                ElseIf TipoForm = "PedidoDeVenda" Then

                    PedidoVendaInstance.txtNomeProduto.Text = nomeProduto
                    PedidoVendaInstance.txtValorUnitario.Text = Row.Cells("Valor Unitário").Value.ToString
                    PedidoVendaInstance.txtIdProduto.Text = Row.Cells("Código").Value.ToString
                    PedidoVendaInstance.txtValorTotal.Text = Row.Cells("Valor Unitário").Value.ToString
                    PedidoVendaInstance.nudQuantidade.Enabled = True
                    Me.Hide()
                End If

            End If
        End If

        validaCampos()
    End Sub

    Private Sub PesquisaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEditar.Enabled = False
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        btnExcluir.Enabled = False

        validaCampos()
        LimpaCampo()
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Produtos.Show()

        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtValorNovo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtNomeProduto.Enabled = True
        txtDescricao.Enabled = True
        txtValorAtual.Enabled = True
        txtNomeProduto.ReadOnly = False
        txtDescricao.ReadOnly = False
        txtValorAtual.ReadOnly = False

        btnAdd.Enabled = False
        btnExtrato.Enabled = False
        btnSalvar.Enabled = True
        btnCancelar.Enabled = True
        btnExcluir.Enabled = True

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Using conection As New SqlConnection(connectionString)
            Try
                conection.Open()

                Dim query As String = "UPDATE produtos SET produto = @produto, descricao = @descricao, valor_unitario = @valor_novo WHERE id = @id"

                Using Command As New SqlCommand(query, conection)

                    Command.Parameters.AddWithValue("@produto", txtNomeProduto.Text)
                    Command.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                    Command.Parameters.AddWithValue("@id", txtIdProduto.Text)

                    Dim valor As Decimal

                    Dim valorText As String = txtValorAtual.Text.Replace(",", ".")

                    If Decimal.TryParse(valorText, Globalization.NumberStyles.Number, Globalization.CultureInfo.InvariantCulture, valor) Then

                        Command.Parameters.AddWithValue("@valor_novo", valor)
                    Else
                        MessageBox.Show("Valor inserido não é válido")

                        ' Interrompe a execução do método atual. Previne que o código continue e tente executar o comando SQL com um valor inválido.
                        Return

                    End If

                    Command.ExecuteNonQuery()

                    MessageBox.Show("Cadastrado atualizado com sucesso")

                    LimpaCampo()

                End Using
            Catch ex As Exception
                MessageBox.Show("Erro banco de dados" & ex.Message)
            End Try
        End Using

        btnExtrato.Enabled = True
        btnAdd.Enabled = True
        btnEditar.Enabled = False
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        btnExcluir.Enabled = False

    End Sub

    Private Sub txtValorNovo_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "," OrElse Char.IsControl(e.KeyChar)) Then
            'indica que deve ignorar o caractere que foi pressionado (não será exibido)
            e.Handled = True

        End If
    End Sub

    Private Sub btnPesquisa_Click_1(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        txtNomeProduto.ReadOnly = False
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Using conection As New SqlConnection(connectionString)
            Dim resultado As DialogResult

            resultado = MessageBox.Show("Tem certeza que quer exluir o cadastro desse produto?", "Excluir:", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then

                Try
                    conection.Open()

                    Dim query As String = "DELETE produtos WHERE id = @id"

                    Using Command As New SqlCommand(query, conection)
                        Command.Parameters.AddWithValue("@id", txtIdProduto.Text)
                        Command.ExecuteNonQuery()

                        MessageBox.Show("Produto excluído com sucesso")
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Erro banco de dados" & ex.Message)
                End Try

                btnEditar.Enabled = False
                btnSalvar.Enabled = False
                btnExcluir.Enabled = False
                btnCancelar.Enabled = False
                btnExtrato.Enabled = True
                btnAdd.Enabled = True

                LimpaCampo()
            End If
        End Using
    End Sub

    Private Sub LimpaCampo()
        txtNomeProduto.Text = ""
        txtDescricao.Text = ""
        txtIdProduto.Text = ""
        txtValorAtual.Text = "0,00"

        txtNomeProduto.ReadOnly = True
        txtDescricao.ReadOnly = True
        txtValorAtual.ReadOnly = True
        txtIdProduto.ReadOnly = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnExtrato.Enabled = True
        btnAdd.Enabled = True
        btnEditar.Enabled = False
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        btnExcluir.Enabled = False

        LimpaCampo()
    End Sub

    Private Sub PesquisaProdutos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If btnSalvar.Enabled = False Then
            LimpaCampo()
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        End If
    End Sub

    Private Function TodosCamposPreenchidos() As Boolean
        Dim valor As Decimal

        Return Not (String.IsNullOrEmpty(txtNomeProduto.Text) OrElse
                    String.IsNullOrEmpty(txtDescricao.Text) OrElse
                    Not Decimal.TryParse(txtValorAtual.Text, valor) OrElse
                    valor <= 0)
    End Function

    Private Sub validaCampos()
        If TodosCamposPreenchidos() Then
            btnSalvar.Enabled = True
        Else
            btnSalvar.Enabled = False
        End If
    End Sub

    Private Sub txtDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtDescricao.TextChanged
        validaCampos()
    End Sub

    Private Sub txtValorAtual_TextChanged(sender As Object, e As EventArgs) Handles txtValorAtual.TextChanged
        validaCampos()
    End Sub
End Class
