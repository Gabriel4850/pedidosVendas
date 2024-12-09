<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesquisaProdutos))
        lblValorAtual = New Label()
        txtValorAtual = New TextBox()
        txtDescricao = New TextBox()
        lblDescricao = New Label()
        txtNomeProduto = New TextBox()
        lblNomeProduto = New Label()
        DataGridView1 = New DataGridView()
        btnExtrato = New Button()
        btnAdd = New Button()
        btnEditar = New Button()
        btnExcluir = New Button()
        btnCancelar = New Button()
        btnSalvar = New Button()
        lblIdProduto = New Label()
        txtIdProduto = New TextBox()
        btnPesquisa = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblValorAtual
        ' 
        lblValorAtual.AutoSize = True
        lblValorAtual.Location = New Point(12, 280)
        lblValorAtual.Name = "lblValorAtual"
        lblValorAtual.Size = New Size(36, 15)
        lblValorAtual.TabIndex = 11
        lblValorAtual.Text = "Valor:"
        ' 
        ' txtValorAtual
        ' 
        txtValorAtual.Location = New Point(12, 315)
        txtValorAtual.Name = "txtValorAtual"
        txtValorAtual.Size = New Size(100, 23)
        txtValorAtual.TabIndex = 10
        txtValorAtual.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtDescricao
        ' 
        txtDescricao.Location = New Point(12, 128)
        txtDescricao.Multiline = True
        txtDescricao.Name = "txtDescricao"
        txtDescricao.Size = New Size(497, 122)
        txtDescricao.TabIndex = 9
        ' 
        ' lblDescricao
        ' 
        lblDescricao.AutoSize = True
        lblDescricao.Location = New Point(12, 96)
        lblDescricao.Name = "lblDescricao"
        lblDescricao.Size = New Size(61, 15)
        lblDescricao.TabIndex = 8
        lblDescricao.Text = "Descrição:"
        ' 
        ' txtNomeProduto
        ' 
        txtNomeProduto.Location = New Point(12, 44)
        txtNomeProduto.Name = "txtNomeProduto"
        txtNomeProduto.Size = New Size(497, 23)
        txtNomeProduto.TabIndex = 7
        ' 
        ' lblNomeProduto
        ' 
        lblNomeProduto.AutoSize = True
        lblNomeProduto.Location = New Point(12, 7)
        lblNomeProduto.Name = "lblNomeProduto"
        lblNomeProduto.Size = New Size(43, 15)
        lblNomeProduto.TabIndex = 6
        lblNomeProduto.Text = "Nome:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 361)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(497, 251)
        DataGridView1.TabIndex = 14
        ' 
        ' btnExtrato
        ' 
        btnExtrato.Location = New Point(568, 44)
        btnExtrato.Name = "btnExtrato"
        btnExtrato.Size = New Size(75, 23)
        btnExtrato.TabIndex = 15
        btnExtrato.Text = "Extrato"
        btnExtrato.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(568, 88)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 16
        btnAdd.Text = "Adicionar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(568, 128)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 17
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Location = New Point(568, 261)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(75, 23)
        btnExcluir.TabIndex = 18
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(568, 216)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 19
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnSalvar
        ' 
        btnSalvar.Location = New Point(568, 172)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(75, 23)
        btnSalvar.TabIndex = 20
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' lblIdProduto
        ' 
        lblIdProduto.AutoSize = True
        lblIdProduto.Location = New Point(371, 12)
        lblIdProduto.Name = "lblIdProduto"
        lblIdProduto.Size = New Size(49, 15)
        lblIdProduto.TabIndex = 21
        lblIdProduto.Text = "Código:"
        ' 
        ' txtIdProduto
        ' 
        txtIdProduto.Location = New Point(437, 9)
        txtIdProduto.Name = "txtIdProduto"
        txtIdProduto.Size = New Size(72, 23)
        txtIdProduto.TabIndex = 22
        ' 
        ' btnPesquisa
        ' 
        btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), Image)
        btnPesquisa.Location = New Point(515, 44)
        btnPesquisa.Name = "btnPesquisa"
        btnPesquisa.Size = New Size(40, 23)
        btnPesquisa.TabIndex = 23
        btnPesquisa.UseVisualStyleBackColor = True
        ' 
        ' PesquisaProdutos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(673, 631)
        Controls.Add(btnPesquisa)
        Controls.Add(txtIdProduto)
        Controls.Add(lblIdProduto)
        Controls.Add(btnSalvar)
        Controls.Add(btnCancelar)
        Controls.Add(btnExcluir)
        Controls.Add(btnEditar)
        Controls.Add(btnAdd)
        Controls.Add(btnExtrato)
        Controls.Add(DataGridView1)
        Controls.Add(lblValorAtual)
        Controls.Add(txtValorAtual)
        Controls.Add(txtDescricao)
        Controls.Add(lblDescricao)
        Controls.Add(txtNomeProduto)
        Controls.Add(lblNomeProduto)
        Name = "PesquisaProdutos"
        Text = "Produtos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblValorAtual As Label
    Friend WithEvents txtValorAtual As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents lblNomeProduto As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnExtrato As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents lblIdProduto As Label
    Friend WithEvents txtIdProduto As TextBox
    Friend WithEvents btnPesquisa As Button
End Class
