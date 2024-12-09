Imports System.Data.SqlClient

Public Class PedidoDeVenda
    Dim connectionString As String = "Server=PC-TNESCRITORIO\MSSQLSERVER02;Database=estudo;Integrated Security=True;"

    ' Variável para armazenar o tipo do formulário
    Private TipoForm As String

    ' Construtor da classe que inicializa o componente e define o tipo do formulário
    Public Sub New(tipo As String)
        InitializeComponent() ' Inicializa os componentes da interface
        TipoForm = tipo ' Atribui o tipo recebido ao atributo TipoForm
    End Sub

    Private Function TodosCamposPreenchidos() As Boolean
        Return Not (String.IsNullOrEmpty(txtNomeCliente.Text) OrElse
            String.IsNullOrEmpty(txtNomeProduto.Text))
    End Function

    Private Sub ValidaCampos()
        If TodosCamposPreenchidos() Then
            btnSalvar.Enabled = True
        Else
            btnSalvar.Enabled = False
        End If
    End Sub

    Private Sub LimapaCampos()
        lblIdCliente.Visible = False
        txtIdCliente.Visible = False
        lblIdProduto.Visible = False
        txtIdProduto.Visible = False

        txtIdPedido.Enabled = False
        txtValorUnitario.ReadOnly = True
        txtNomeCliente.ReadOnly = True
        txtNomeProduto.ReadOnly = True
        txtDataEmissao.ReadOnly = True
        txtDataAlteracao.ReadOnly = True
        txtNumeroPedido.ReadOnly = True
        txtValorTotal.ReadOnly = True
        nudQuantidade.Enabled = False

        btnEditar.Enabled = False
        btnSalvar.Enabled = False
        btnExcluir.Enabled = False
        btnPesquisaCliente.Enabled = False
        btnPesquisaProduto.Enabled = False

        txtIdPedido.Text = ""
        txtValorUnitario.Text = ""
        txtNomeCliente.Text = ""
        txtNomeProduto.Text = ""
        txtDataEmissao.Text = ""
        txtNumeroPedido.Text = ""
        txtValorTotal.Text = ""
        nudQuantidade.Value = 1
        txtIdCliente.Text = ""
        txtIdProduto.Text = ""
        txtNumeroPedido.Text = ""


    End Sub

    Private isFromPesquisaPedidos As Boolean

    Public Sub New(isFromPesquisaPedidos As Boolean)
        ' Este método é chamado ao instanciar o formulário
        InitializeComponent()
        Me.isFromPesquisaPedidos = isFromPesquisaPedidos
    End Sub

    Private Sub PedidoDeVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Verifica se o pedido foi aberto a partir do PesquisaProduto
        If Not isFromPesquisaPedidos Then
            LimapaCampos()

        End If

        txtDataAlteracao.Visible = False
        lblDataAlteracao.Visible = False
    End Sub

    Private Sub txtDataEmissao_TextChanged(sender As Object, e As EventArgs) Handles txtDataEmissao.TextChanged

    End Sub

    Private Sub btnPesquisaCliente_Click(sender As Object, e As EventArgs) Handles btnPesquisaCliente.Click
        ' Cria uma nova instância da pesquisa de cliente, passando o tipo de pedido e a referência do formulário atual
        Dim pesquisaCliente As New PesquisaCliente("PedidoDeVenda", Me)
        pesquisaCliente.Show()
    End Sub

    Private Sub btnPesquisaProduto_Click(sender As Object, e As EventArgs) Handles btnPesquisaProduto.Click

        Dim pesquisaProdutos As New PesquisaProdutos("PedidoDeVenda", Me)
        pesquisaProdutos.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtIdProduto.TextChanged

    End Sub

    Private Sub lblIdCliente_Click(sender As Object, e As EventArgs) Handles lblIdCliente.Click

    End Sub

    'evento ValueChanged, ganrante que ação de calcular o valor total ocorra toda vez que o usuário clicar nas setas de nudQuantidade (ou usar as setas do teclado)
    Private Sub nudQuantidade_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantidade.ValueChanged
        'declarando variveis do tipo Decimal para armazenar em numeric no sqlServer
        Dim resultado As Decimal
        Dim valorUnitario As Decimal
        Dim quantidade As Decimal


        'Se txtValorUnitario não for Null, nem vazio ou conter apenas espaço em branco
        'AndAlso, validador booleano. Ambas expressões tem que ser verdadeira
        'Decimal.TryParse converte o valor de txtValorUnitario para Decimal e armazena na variavel valorUnitario
        If Not String.IsNullOrWhiteSpace(txtValorUnitario.Text) AndAlso Decimal.TryParse(txtValorUnitario.Text, valorUnitario) Then
            'atribui o valor de nudQuantidade a varivel quantidade
            quantidade = nudQuantidade.Value 'nudQuantidade.valeu já é decimal

            'operação para calcular o valor total do produto
            resultado = valorUnitario * quantidade

            'Exibe o valor total no campo txtValorTotal
            txtValorTotal.Text = resultado.ToString

        Else
            'se der erro e não entrar no IF o valor total fica zerado
            txtValorTotal.Text = "0,00"
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        btnPesquisaProduto.Enabled = True
        btnPesquisaCliente.Enabled = True
        nudQuantidade.Enabled = True

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                'Select tras o maior numero de pedido e soma mais um
                Dim query As String = "SELECT MAX(numero_pedido) + 1 FROM pedidos"

                Using command As New SqlCommand(query, connection)

                    'armazena o resultado do select na variavel resultado
                    Dim resultado As Object = command.ExecuteScalar

                    'exibe resultado no txtNumeroPedido
                    txtNumeroPedido.Text = resultado
                End Using

                ValidaCampos()

            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message)
            End Try

        End Using

        Dim dataEmissao As DateTime = DateTime.Now ' Obtém a data atual (puxa da maquina que está rodando o projeto)

        txtDataEmissao.Text = dataEmissao.ToString("dd/MM/yyyy") ' Formata a data de emissão e a exibe no campo de texto


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimapaCampos()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                If Not String.IsNullOrEmpty(txtIdPedido.Text) Then
                    Dim queryUpdate As String = "UPDATE pedidos 
                                                 SET id_cliente = @id_cliente, id_produto = @id_produto, quantidade = @quantidade, valor_unitario = @valor_unitario,
                                                     valor_total = @valor_total, nome_cliente = @nome_cliente, nome_produto = @nome_produto, data_alteracao = @data_alteracao
                                                 WHERE id = @id"

                    Using Command As New SqlCommand(queryUpdate, connection)

                        Command.Parameters.AddWithValue("@id", txtIdPedido.Text)
                        Command.Parameters.AddWithValue("@id_cliente", txtIdCliente.Text)
                        Command.Parameters.AddWithValue("@id_produto", txtIdProduto.Text)
                        Command.Parameters.AddWithValue("@quantidade", nudQuantidade.Value)
                        Command.Parameters.AddWithValue("@nome_cliente", txtNomeCliente.Text)
                        Command.Parameters.AddWithValue("@nome_produto", txtNomeProduto.Text)
                        Command.Parameters.AddWithValue("@data_alteracao", txtDataAlteracao.Text)

                        Dim vUni As Decimal

                        Dim vTotal As Decimal

                        Dim vaUni As String = txtValorUnitario.Text.Replace(",", ".")

                        Dim vaTotal As String = txtValorTotal.Text.Replace(",", ".")

                        If Decimal.TryParse(vaUni, Globalization.NumberStyles.Number, Globalization.CultureInfo.InvariantCulture, vUni) And Decimal.TryParse(vaTotal, Globalization.NumberStyles.Number, Globalization.CultureInfo.InvariantCulture, vTotal) Then

                            Command.Parameters.AddWithValue("@valor_unitario", vUni)
                            Command.Parameters.AddWithValue("@valor_total", vTotal)
                        Else
                            MessageBox.Show("Erro nos valores")
                        End If

                        Command.ExecuteNonQuery()

                        MessageBox.Show("Pedido atualizado com sucesso.")
                    End Using

                    LimapaCampos()

                Else
                    Dim query As String = "INSERT INTO pedidos (id_cliente, id_produto, quantidade, valor_unitario, valor_total, nome_cliente, nome_produto, data_emissao, numero_pedido)
                                           VALUES (@id_cliente, @id_produto, @quantidade, @valor_unitario, @valor_total, @nome_cliente, @nome_produto, @data_emissao, @numero_pedido)"

                    Using Command As New SqlCommand(query, connection)

                        Dim idCliente As Integer
                        Dim idProduto As Integer

                        If Integer.TryParse(txtIdCliente.Text, idCliente) And Integer.TryParse(txtIdProduto.Text, idProduto) Then

                            Command.Parameters.AddWithValue("@id_cliente", idCliente)
                            Command.Parameters.AddWithValue("@id_produto", idProduto)
                            Command.Parameters.AddWithValue("@quantidade", nudQuantidade.Value)
                            Command.Parameters.AddWithValue("@nome_cliente", txtNomeCliente.Text)
                            Command.Parameters.AddWithValue("@nome_produto", txtNomeProduto.Text)
                            Command.Parameters.AddWithValue("@data_emissao", txtDataEmissao.Text)
                            Command.Parameters.AddWithValue("@numero_pedido", txtNumeroPedido.Text)

                            Dim valorUni As Decimal

                            Dim ValorTo As Decimal

                            Dim valorUnitario As String = txtValorUnitario.Text.Replace(",", ".")

                            Dim valorTotal As String = txtValorTotal.Text.Replace(",", ".")

                            If Decimal.TryParse(valorUnitario, Globalization.NumberStyles.Number, Globalization.CultureInfo.InvariantCulture, valorUni) And Decimal.TryParse(valorTotal, Globalization.NumberStyles.Number, Globalization.CultureInfo.InvariantCulture, ValorTo) Then
                                Command.Parameters.AddWithValue("@valor_unitario", valorUni)
                                Command.Parameters.AddWithValue("@valor_total", ValorTo)

                            Else
                                MessageBox.Show("Erro nos valores")
                            End If
                        End If
                        Command.ExecuteNonQuery()

                        MessageBox.Show("Pedido cadastrado com sucesso.")
                    End Using
                    LimapaCampos()
                End If
            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub txtNomeCliente_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCliente.TextChanged
        ValidaCampos()
    End Sub

    Private Sub txtNomeProduto_TextChanged(sender As Object, e As EventArgs) Handles txtNomeProduto.TextChanged
        ValidaCampos()
    End Sub

    Private Sub txtDataAlteracao_TextChanged(sender As Object, e As EventArgs) Handles txtDataAlteracao.TextChanged

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        lblDataAlteracao.Visible = True
        txtDataAlteracao.Visible = True
        txtDataAlteracao.ReadOnly = True

        btnPesquisaCliente.Enabled = True
        btnPesquisaProduto.Enabled = True
        nudQuantidade.Enabled = True


        Dim dataEmissao As DateTime = DateTime.Now
        txtDataAlteracao.Text = dataEmissao.ToString("dd/MM/yyyy")
    End Sub

    Private Sub bntPesquisar_Click(sender As Object, e As EventArgs) Handles bntPesquisar.Click
        PesquisaPedidos.Show()
        Me.Hide()
    End Sub

    Private Sub PedidoDeVenda_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "DELETE FROM pedidos WHERE id = @id"

                Using Command As New SqlCommand(query, connection)

                    Command.Parameters.AddWithValue("@id", txtIdPedido.Text)

                    Command.ExecuteNonQuery()

                    MessageBox.Show("Pedido " & txtIdPedido.Text & " excluído com sucesso")


                End Using

                LimapaCampos()
            Catch ex As Exception
                MessageBox.Show("Erro ao excluir pedido de venda: " & ex.Message)
            End Try
        End Using
    End Sub
End Class