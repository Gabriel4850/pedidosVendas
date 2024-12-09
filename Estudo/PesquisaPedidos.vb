Imports System.Data.SqlClient

Public Class PesquisaPedidos
    Dim connectionString As String = "Server=PC-TNESCRITORIO\MSSQLSERVER02;Database=estudo;Integrated Security=True;"

    Private Sub btnExtrato_Click(sender As Object, e As EventArgs) Handles btnExtrato.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                If Not String.IsNullOrEmpty(txtNomeCliente.Text) Then
                    Dim query As String = "SELECT id, numero_pedido, id_cliente, nome_cliente, id_produto, nome_produto, valor_unitario, quantidade, valor_total, data_emissao, data_alteracao
                                           FROM pedidos 
                                           WHERE nome_cliente like @nome_cliente"

                    Using Command As New SqlCommand(query, connection)
                        Command.Parameters.AddWithValue("@nome_cliente", "%" & txtNomeCliente.Text & "%")
                        Command.ExecuteNonQuery()

                        ' Cria um adaptador de dados e um DataTable para armazenar os resultados
                        Dim DataAdapter As New SqlDataAdapter(Command)
                        Dim DataTable As New DataTable

                        ' Preenche o DataTable com os resultados da consulta
                        DataAdapter.Fill(DataTable)

                        DataTable.Columns("id").ColumnName = "ID"
                        DataTable.Columns("numero_pedido").ColumnName = "Número do Pedido"
                        DataTable.Columns("id_cliente").ColumnName = "Código do Cliente"
                        DataTable.Columns("nome_cliente").ColumnName = "Cliente"
                        DataTable.Columns("id_produto").ColumnName = "Código do Produto"
                        DataTable.Columns("nome_produto").ColumnName = "Produto"
                        DataTable.Columns("valor_unitario").ColumnName = "Valor Unitário"
                        DataTable.Columns("quantidade").ColumnName = "Quantidade"
                        DataTable.Columns("valor_total").ColumnName = "Valor Total"
                        DataTable.Columns("data_emissao").ColumnName = "Data de Emissão"
                        DataTable.Columns("data_alteracao").ColumnName = "Data de Alteração"

                        DataGridView1.DataSource = DataTable

                    End Using

                ElseIf Not String.IsNullOrEmpty(txtNumeroPedido.Text) Then
                    Dim query As String = "SELECT id, numero_pedido, id_cliente, nome_cliente, id_produto, nome_produto, valor_unitario, quantidade, valor_total, data_emissao, data_alteracao
                                           FROM pedidos 
                                           WHERE numero_pedido like @numero_pedido"

                    Using Command As New SqlCommand(query, connection)
                        Command.Parameters.AddWithValue("@numero_pedido", "%" & txtNumeroPedido.Text & "%")
                        Command.ExecuteNonQuery()

                        ' Cria um adaptador de dados e um DataTable para armazenar os resultados
                        Dim DataAdapter As New SqlDataAdapter(Command)
                        Dim DataTable As New DataTable

                        ' Preenche o DataTable com os resultados da consulta
                        DataAdapter.Fill(DataTable)

                        DataTable.Columns("id").ColumnName = "ID"
                        DataTable.Columns("numero_pedido").ColumnName = "Número do Pedido"
                        DataTable.Columns("id_cliente").ColumnName = "Código do Cliente"
                        DataTable.Columns("nome_cliente").ColumnName = "Cliente"
                        DataTable.Columns("id_produto").ColumnName = "Código do Produto"
                        DataTable.Columns("nome_produto").ColumnName = "Produto"
                        DataTable.Columns("valor_unitario").ColumnName = "Valor Unitário"
                        DataTable.Columns("quantidade").ColumnName = "Quantidade"
                        DataTable.Columns("valor_total").ColumnName = "Valor Total"
                        DataTable.Columns("data_emissao").ColumnName = "Data de Emissão"
                        DataTable.Columns("data_alteracao").ColumnName = "Data de Alteração"

                        DataGridView1.DataSource = DataTable

                    End Using
                Else
                    Dim query As String = "SELECT id, numero_pedido, id_cliente, nome_cliente, id_produto, nome_produto, valor_unitario, quantidade, valor_total, data_emissao, data_alteracao
                                           FROM pedidos"

                    Using Command As New SqlCommand(query, connection)

                        Command.ExecuteNonQuery()

                        ' Cria um adaptador de dados e um DataTable para armazenar os resultados
                        Dim DataAdapter As New SqlDataAdapter(Command)
                        Dim DataTable As New DataTable

                        ' Preenche o DataTable com os resultados da consulta
                        DataAdapter.Fill(DataTable)

                        DataTable.Columns("id").ColumnName = "ID"
                        DataTable.Columns("numero_pedido").ColumnName = "Número do Pedido"
                        DataTable.Columns("id_cliente").ColumnName = "Código do Cliente"
                        DataTable.Columns("nome_cliente").ColumnName = "Cliente"
                        DataTable.Columns("id_produto").ColumnName = "Código do Produto"
                        DataTable.Columns("nome_produto").ColumnName = "Produto"
                        DataTable.Columns("valor_unitario").ColumnName = "Valor Unitário"
                        DataTable.Columns("quantidade").ColumnName = "Quantidade"
                        DataTable.Columns("valor_total").ColumnName = "Valor Total"
                        DataTable.Columns("data_emissao").ColumnName = "Data de Emissão"
                        DataTable.Columns("data_alteracao").ColumnName = "Data de Alteração"

                        DataGridView1.DataSource = DataTable

                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim coluna As String = "Número do Pedido"

            If DataGridView1.Columns(e.ColumnIndex).HeaderText = coluna Then

                Dim Row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                Dim numeroPedido As String = Row.Cells("Número do Pedido").Value.ToString

                Dim pedidoDeVenda As New PedidoDeVenda(True)


                pedidoDeVenda.txtIdPedido.Text = Row.Cells("ID").Value.ToString
                pedidoDeVenda.txtNumeroPedido.Text = Row.Cells("Número do Pedido").Value.ToString
                pedidoDeVenda.txtIdCliente.Text = Row.Cells("Código do Cliente").Value.ToString
                pedidoDeVenda.txtNomeCliente.Text = Row.Cells("Cliente").Value.ToString
                pedidoDeVenda.txtIdProduto.Text = Row.Cells("Código do Produto").Value.ToString
                pedidoDeVenda.txtNomeProduto.Text = Row.Cells("Produto").Value.ToString
                pedidoDeVenda.txtValorUnitario.Text = Row.Cells("Valor Unitário").Value.ToString
                pedidoDeVenda.nudQuantidade.Value = Row.Cells("Quantidade").Value.ToString
                pedidoDeVenda.txtValorTotal.Text = Row.Cells("Valor Total").Value.ToString
                pedidoDeVenda.txtDataEmissao.Text = Row.Cells("Data de Emissão").Value.ToString
                pedidoDeVenda.txtDataAlteracao.Text = Row.Cells("Data de Alteração").Value.ToString

                ' Verifique se o valor da célula "Data de Alteração" é NULL (DBNull)
                If Row.Cells("Data de Alteração").Value IsNot DBNull.Value Then
                    ' Se não for nulo, converta para DateTime e atribua ao controle
                    pedidoDeVenda.txtDataAlteracao.Text = Convert.ToDateTime(Row.Cells("Data de Alteração").Value).ToString("dd/MM/yyyy")
                Else
                    ' Se for nulo, você pode atribuir um valor padrão (ou uma string vazia)
                    pedidoDeVenda.txtDataAlteracao.Text = ""  ' Ou "Data não disponível"

                End If

                pedidoDeVenda.txtIdPedido.ReadOnly = True
                pedidoDeVenda.txtNumeroPedido.ReadOnly = True
                pedidoDeVenda.txtIdCliente.Visible = False
                pedidoDeVenda.txtIdProduto.Visible = False
                pedidoDeVenda.txtNomeCliente.ReadOnly = True
                pedidoDeVenda.txtNomeProduto.ReadOnly = True
                pedidoDeVenda.txtValorUnitario.ReadOnly = True
                pedidoDeVenda.txtValorTotal.ReadOnly = True
                pedidoDeVenda.txtDataEmissao.ReadOnly = True
                pedidoDeVenda.nudQuantidade.Enabled = False
                pedidoDeVenda.btnNovo.Enabled = False
                pedidoDeVenda.btnPesquisaCliente.Enabled = False
                pedidoDeVenda.btnPesquisaProduto.Enabled = False



                Me.Hide()

                'Dim pedidoDeVenda As New PedidoDeVenda(True)
                pedidoDeVenda.Show()

            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class