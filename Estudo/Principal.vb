Public Class Principal
    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuCadastro.Click

    End Sub

    Private Sub MenuCadastroUsuario_Click(sender As Object, e As EventArgs) Handles MenuCadastroUsuario.Click
        Cadastro.Show()
    End Sub

    Private Sub MenuCadastroProdutos_Click(sender As Object, e As EventArgs) Handles MenuCadastroProdutos.Click
        Produtos.Show()
    End Sub

    Private Sub PesquisarProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pedidoVenda As New PedidoDeVenda("PedidoDeVenda") ' ou obter a instância existente
        Dim pesquisaProdutos As New PesquisaProdutos("PesquisaProduto", pedidoVenda)
        pesquisaProdutos.Show()

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MenuCadastroClientes.Click
        CadastroClientes.Show()

    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PedidoDeVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoDeVendaToolStripMenuItem.Click
        Dim pedidoVenda As New PedidoDeVenda("PedidoDeVenda")
        pedidoVenda.Show()
    End Sub
End Class