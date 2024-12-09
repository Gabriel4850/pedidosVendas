<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoDeVenda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblCodigo = New Label()
        txtIdPedido = New TextBox()
        lblNumeroPedido = New Label()
        txtNumeroPedido = New TextBox()
        lblNomeCliente = New Label()
        txtNomeCliente = New TextBox()
        btnPesquisaCliente = New Button()
        lblNomeProduto = New Label()
        txtNomeProduto = New TextBox()
        btnPesquisaProduto = New Button()
        txtDataEmissao = New TextBox()
        lblDataEmissao = New Label()
        lblValorUnitario = New Label()
        txtValorUnitario = New TextBox()
        lblQuantidade = New Label()
        nudQuantidade = New NumericUpDown()
        lblValorTotal = New Label()
        txtValorTotal = New TextBox()
        lblIdCliente = New Label()
        txtIdCliente = New TextBox()
        txtIdProduto = New TextBox()
        lblIdProduto = New Label()
        btnNovo = New Button()
        btnEditar = New Button()
        btnSalvar = New Button()
        btnCancelar = New Button()
        btnExcluir = New Button()
        bntPesquisar = New Button()
        lblDataAlteracao = New Label()
        txtDataAlteracao = New TextBox()
        CType(nudQuantidade, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Location = New Point(12, 9)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New Size(49, 15)
        lblCodigo.TabIndex = 0
        lblCodigo.Text = "Código:"
        ' 
        ' txtIdPedido
        ' 
        txtIdPedido.Location = New Point(67, 6)
        txtIdPedido.Name = "txtIdPedido"
        txtIdPedido.Size = New Size(75, 23)
        txtIdPedido.TabIndex = 1
        txtIdPedido.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblNumeroPedido
        ' 
        lblNumeroPedido.AutoSize = True
        lblNumeroPedido.Location = New Point(12, 47)
        lblNumeroPedido.Name = "lblNumeroPedido"
        lblNumeroPedido.Size = New Size(54, 15)
        lblNumeroPedido.TabIndex = 2
        lblNumeroPedido.Text = "Número:"
        lblNumeroPedido.UseMnemonic = False
        ' 
        ' txtNumeroPedido
        ' 
        txtNumeroPedido.Location = New Point(67, 44)
        txtNumeroPedido.Name = "txtNumeroPedido"
        txtNumeroPedido.Size = New Size(75, 23)
        txtNumeroPedido.TabIndex = 3
        txtNumeroPedido.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblNomeCliente
        ' 
        lblNomeCliente.AutoSize = True
        lblNomeCliente.Location = New Point(12, 106)
        lblNomeCliente.Name = "lblNomeCliente"
        lblNomeCliente.Size = New Size(47, 15)
        lblNomeCliente.TabIndex = 4
        lblNomeCliente.Text = "Cliente:"
        ' 
        ' txtNomeCliente
        ' 
        txtNomeCliente.Location = New Point(67, 103)
        txtNomeCliente.Name = "txtNomeCliente"
        txtNomeCliente.Size = New Size(413, 23)
        txtNomeCliente.TabIndex = 5
        ' 
        ' btnPesquisaCliente
        ' 
        btnPesquisaCliente.Location = New Point(486, 102)
        btnPesquisaCliente.Name = "btnPesquisaCliente"
        btnPesquisaCliente.Size = New Size(35, 23)
        btnPesquisaCliente.TabIndex = 6
        btnPesquisaCliente.Text = "..."
        btnPesquisaCliente.UseVisualStyleBackColor = True
        ' 
        ' lblNomeProduto
        ' 
        lblNomeProduto.AutoSize = True
        lblNomeProduto.Location = New Point(12, 190)
        lblNomeProduto.Name = "lblNomeProduto"
        lblNomeProduto.Size = New Size(53, 15)
        lblNomeProduto.TabIndex = 7
        lblNomeProduto.Text = "Produto:"
        ' 
        ' txtNomeProduto
        ' 
        txtNomeProduto.Location = New Point(67, 187)
        txtNomeProduto.Name = "txtNomeProduto"
        txtNomeProduto.Size = New Size(413, 23)
        txtNomeProduto.TabIndex = 8
        ' 
        ' btnPesquisaProduto
        ' 
        btnPesquisaProduto.Location = New Point(486, 187)
        btnPesquisaProduto.Name = "btnPesquisaProduto"
        btnPesquisaProduto.Size = New Size(35, 23)
        btnPesquisaProduto.TabIndex = 9
        btnPesquisaProduto.Text = "..."
        btnPesquisaProduto.UseVisualStyleBackColor = True
        ' 
        ' txtDataEmissao
        ' 
        txtDataEmissao.Location = New Point(256, 6)
        txtDataEmissao.Name = "txtDataEmissao"
        txtDataEmissao.Size = New Size(71, 23)
        txtDataEmissao.TabIndex = 10
        txtDataEmissao.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblDataEmissao
        ' 
        lblDataEmissao.AutoSize = True
        lblDataEmissao.Location = New Point(170, 9)
        lblDataEmissao.Name = "lblDataEmissao"
        lblDataEmissao.Size = New Size(80, 15)
        lblDataEmissao.TabIndex = 11
        lblDataEmissao.Text = "Data emissão:"
        ' 
        ' lblValorUnitario
        ' 
        lblValorUnitario.AutoSize = True
        lblValorUnitario.Location = New Point(13, 283)
        lblValorUnitario.Name = "lblValorUnitario"
        lblValorUnitario.Size = New Size(81, 15)
        lblValorUnitario.TabIndex = 12
        lblValorUnitario.Text = "Valor Unitário:"
        ' 
        ' txtValorUnitario
        ' 
        txtValorUnitario.Location = New Point(100, 280)
        txtValorUnitario.Name = "txtValorUnitario"
        txtValorUnitario.Size = New Size(100, 23)
        txtValorUnitario.TabIndex = 13
        ' 
        ' lblQuantidade
        ' 
        lblQuantidade.AutoSize = True
        lblQuantidade.Location = New Point(257, 283)
        lblQuantidade.Name = "lblQuantidade"
        lblQuantidade.Size = New Size(72, 15)
        lblQuantidade.TabIndex = 14
        lblQuantidade.Text = "Quantidade:"
        ' 
        ' nudQuantidade
        ' 
        nudQuantidade.Location = New Point(335, 280)
        nudQuantidade.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudQuantidade.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudQuantidade.Name = "nudQuantidade"
        nudQuantidade.Size = New Size(74, 23)
        nudQuantidade.TabIndex = 15
        nudQuantidade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblValorTotal
        ' 
        lblValorTotal.AutoSize = True
        lblValorTotal.Location = New Point(13, 373)
        lblValorTotal.Name = "lblValorTotal"
        lblValorTotal.Size = New Size(64, 15)
        lblValorTotal.TabIndex = 16
        lblValorTotal.Text = "Valor Total:"
        ' 
        ' txtValorTotal
        ' 
        txtValorTotal.Location = New Point(100, 365)
        txtValorTotal.Name = "txtValorTotal"
        txtValorTotal.Size = New Size(100, 23)
        txtValorTotal.TabIndex = 17
        ' 
        ' lblIdCliente
        ' 
        lblIdCliente.AutoSize = True
        lblIdCliente.Location = New Point(13, 147)
        lblIdCliente.Name = "lblIdCliente"
        lblIdCliente.Size = New Size(58, 15)
        lblIdCliente.TabIndex = 18
        lblIdCliente.Text = "id cliente:"
        ' 
        ' txtIdCliente
        ' 
        txtIdCliente.Location = New Point(77, 144)
        txtIdCliente.Name = "txtIdCliente"
        txtIdCliente.Size = New Size(76, 23)
        txtIdCliente.TabIndex = 19
        ' 
        ' txtIdProduto
        ' 
        txtIdProduto.Location = New Point(77, 229)
        txtIdProduto.Name = "txtIdProduto"
        txtIdProduto.Size = New Size(76, 23)
        txtIdProduto.TabIndex = 21
        ' 
        ' lblIdProduto
        ' 
        lblIdProduto.AutoSize = True
        lblIdProduto.Location = New Point(13, 232)
        lblIdProduto.Name = "lblIdProduto"
        lblIdProduto.Size = New Size(66, 15)
        lblIdProduto.TabIndex = 20
        lblIdProduto.Text = "Id Produto:"
        ' 
        ' btnNovo
        ' 
        btnNovo.Location = New Point(609, 44)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(75, 23)
        btnNovo.TabIndex = 22
        btnNovo.Text = "Novo"
        btnNovo.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(609, 98)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 23
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnSalvar
        ' 
        btnSalvar.Location = New Point(609, 147)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(75, 23)
        btnSalvar.TabIndex = 24
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(609, 200)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 25
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Location = New Point(609, 255)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(75, 23)
        btnExcluir.TabIndex = 26
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' bntPesquisar
        ' 
        bntPesquisar.Location = New Point(446, 43)
        bntPesquisar.Name = "bntPesquisar"
        bntPesquisar.Size = New Size(75, 23)
        bntPesquisar.TabIndex = 27
        bntPesquisar.Text = "Pesquisar"
        bntPesquisar.UseVisualStyleBackColor = True
        ' 
        ' lblDataAlteracao
        ' 
        lblDataAlteracao.AutoSize = True
        lblDataAlteracao.Location = New Point(170, 47)
        lblDataAlteracao.Name = "lblDataAlteracao"
        lblDataAlteracao.Size = New Size(85, 15)
        lblDataAlteracao.TabIndex = 28
        lblDataAlteracao.Text = "Data alteração:"
        ' 
        ' txtDataAlteracao
        ' 
        txtDataAlteracao.Location = New Point(258, 43)
        txtDataAlteracao.Name = "txtDataAlteracao"
        txtDataAlteracao.Size = New Size(71, 23)
        txtDataAlteracao.TabIndex = 29
        txtDataAlteracao.TextAlign = HorizontalAlignment.Right
        ' 
        ' PedidoDeVenda
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(710, 419)
        Controls.Add(txtDataAlteracao)
        Controls.Add(lblDataAlteracao)
        Controls.Add(bntPesquisar)
        Controls.Add(btnExcluir)
        Controls.Add(btnCancelar)
        Controls.Add(btnSalvar)
        Controls.Add(btnEditar)
        Controls.Add(btnNovo)
        Controls.Add(txtIdProduto)
        Controls.Add(lblIdProduto)
        Controls.Add(txtIdCliente)
        Controls.Add(lblIdCliente)
        Controls.Add(txtValorTotal)
        Controls.Add(lblValorTotal)
        Controls.Add(nudQuantidade)
        Controls.Add(lblQuantidade)
        Controls.Add(txtValorUnitario)
        Controls.Add(lblValorUnitario)
        Controls.Add(lblDataEmissao)
        Controls.Add(txtDataEmissao)
        Controls.Add(btnPesquisaProduto)
        Controls.Add(txtNomeProduto)
        Controls.Add(lblNomeProduto)
        Controls.Add(btnPesquisaCliente)
        Controls.Add(txtNomeCliente)
        Controls.Add(lblNomeCliente)
        Controls.Add(txtNumeroPedido)
        Controls.Add(lblNumeroPedido)
        Controls.Add(txtIdPedido)
        Controls.Add(lblCodigo)
        Name = "PedidoDeVenda"
        Text = "PedidoDeVenda"
        CType(nudQuantidade, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtIdPedido As TextBox
    Friend WithEvents lblNumeroPedido As Label
    Friend WithEvents txtNumeroPedido As TextBox
    Friend WithEvents lblNomeCliente As Label
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents btnPesquisaCliente As Button
    Friend WithEvents lblNomeProduto As Label
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents btnPesquisaProduto As Button
    Friend WithEvents txtDataEmissao As TextBox
    Friend WithEvents lblDataEmissao As Label
    Friend WithEvents lblValorUnitario As Label
    Friend WithEvents txtValorUnitario As TextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents nudQuantidade As NumericUpDown
    Friend WithEvents lblValorTotal As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents lblIdCliente As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtIdProduto As TextBox
    Friend WithEvents lblIdProduto As Label
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents bntPesquisar As Button
    Friend WithEvents lblDataAlteracao As Label
    Friend WithEvents txtDataAlteracao As TextBox
End Class
