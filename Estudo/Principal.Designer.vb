<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        MenuStrip1 = New MenuStrip()
        MenuCadastro = New ToolStripMenuItem()
        MenuCadastroUsuario = New ToolStripMenuItem()
        MenuCadastroClientes = New ToolStripMenuItem()
        MenuCadastroProdutos = New ToolStripMenuItem()
        PedidosToolStripMenuItem = New ToolStripMenuItem()
        PedidoDeVendaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuCadastro, PedidosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuCadastro
        ' 
        MenuCadastro.DropDownItems.AddRange(New ToolStripItem() {MenuCadastroUsuario, MenuCadastroClientes, MenuCadastroProdutos})
        MenuCadastro.Name = "MenuCadastro"
        MenuCadastro.Size = New Size(71, 20)
        MenuCadastro.Text = "Cadastros"
        ' 
        ' MenuCadastroUsuario
        ' 
        MenuCadastroUsuario.Name = "MenuCadastroUsuario"
        MenuCadastroUsuario.Size = New Size(122, 22)
        MenuCadastroUsuario.Text = "Usuários"
        ' 
        ' MenuCadastroClientes
        ' 
        MenuCadastroClientes.Name = "MenuCadastroClientes"
        MenuCadastroClientes.Size = New Size(122, 22)
        MenuCadastroClientes.Text = "Clientes"
        ' 
        ' MenuCadastroProdutos
        ' 
        MenuCadastroProdutos.Name = "MenuCadastroProdutos"
        MenuCadastroProdutos.Size = New Size(122, 22)
        MenuCadastroProdutos.Text = "Produtos"
        ' 
        ' PedidosToolStripMenuItem
        ' 
        PedidosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PedidoDeVendaToolStripMenuItem})
        PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        PedidosToolStripMenuItem.Size = New Size(56, 20)
        PedidosToolStripMenuItem.Text = "Vendas"
        ' 
        ' PedidoDeVendaToolStripMenuItem
        ' 
        PedidoDeVendaToolStripMenuItem.Name = "PedidoDeVendaToolStripMenuItem"
        PedidoDeVendaToolStripMenuItem.Size = New Size(180, 22)
        PedidoDeVendaToolStripMenuItem.Text = "Pedido de Venda"
        ' 
        ' Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Principal"
        Text = "Principal"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuCadastro As ToolStripMenuItem
    Friend WithEvents MenuCadastroUsuario As ToolStripMenuItem
    Friend WithEvents MenuCadastroProdutos As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuCadastroClientes As ToolStripMenuItem
    Friend WithEvents PedidoDeVendaToolStripMenuItem As ToolStripMenuItem
End Class
