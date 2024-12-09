<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaPedidos
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
        txtNomeCliente = New TextBox()
        btnExtrato = New Button()
        DataGridView1 = New DataGridView()
        lblNomeCliente = New Label()
        lblNumeroPedido = New Label()
        txtNumeroPedido = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNomeCliente
        ' 
        txtNomeCliente.Location = New Point(87, 40)
        txtNomeCliente.Name = "txtNomeCliente"
        txtNomeCliente.Size = New Size(453, 23)
        txtNomeCliente.TabIndex = 0
        ' 
        ' btnExtrato
        ' 
        btnExtrato.Location = New Point(672, 40)
        btnExtrato.Name = "btnExtrato"
        btnExtrato.Size = New Size(75, 23)
        btnExtrato.TabIndex = 1
        btnExtrato.Text = "Extrato"
        btnExtrato.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(34, 128)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(614, 310)
        DataGridView1.TabIndex = 2
        ' 
        ' lblNomeCliente
        ' 
        lblNomeCliente.AutoSize = True
        lblNomeCliente.Location = New Point(34, 44)
        lblNomeCliente.Name = "lblNomeCliente"
        lblNomeCliente.Size = New Size(47, 15)
        lblNomeCliente.TabIndex = 3
        lblNomeCliente.Text = "Cliente:"
        ' 
        ' lblNumeroPedido
        ' 
        lblNumeroPedido.AutoSize = True
        lblNumeroPedido.Location = New Point(34, 85)
        lblNumeroPedido.Name = "lblNumeroPedido"
        lblNumeroPedido.Size = New Size(111, 15)
        lblNumeroPedido.TabIndex = 4
        lblNumeroPedido.Text = "Número do Pedido:"
        ' 
        ' txtNumeroPedido
        ' 
        txtNumeroPedido.Location = New Point(151, 82)
        txtNumeroPedido.Name = "txtNumeroPedido"
        txtNumeroPedido.Size = New Size(100, 23)
        txtNumeroPedido.TabIndex = 5
        ' 
        ' PesquisaPedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(781, 450)
        Controls.Add(txtNumeroPedido)
        Controls.Add(lblNumeroPedido)
        Controls.Add(lblNomeCliente)
        Controls.Add(DataGridView1)
        Controls.Add(btnExtrato)
        Controls.Add(txtNomeCliente)
        Name = "PesquisaPedidos"
        Text = "PesquisaPedidos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents btnExtrato As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNomeCliente As Label
    Friend WithEvents lblNumeroPedido As Label
    Friend WithEvents txtNumeroPedido As TextBox
End Class
