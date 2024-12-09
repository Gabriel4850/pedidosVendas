<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaCliente
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
        txtNome = New TextBox()
        lblNome = New Label()
        btnExtrato = New Button()
        DataGridViewCliente = New DataGridView()
        CType(DataGridViewCliente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(21, 56)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(453, 23)
        txtNome.TabIndex = 3
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Location = New Point(21, 27)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(43, 15)
        lblNome.TabIndex = 2
        lblNome.Text = "Nome:"
        ' 
        ' btnExtrato
        ' 
        btnExtrato.Location = New Point(685, 55)
        btnExtrato.Name = "btnExtrato"
        btnExtrato.Size = New Size(75, 23)
        btnExtrato.TabIndex = 4
        btnExtrato.Text = "Extrato"
        btnExtrato.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewCliente
        ' 
        DataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCliente.Location = New Point(21, 128)
        DataGridViewCliente.Name = "DataGridViewCliente"
        DataGridViewCliente.Size = New Size(614, 310)
        DataGridViewCliente.TabIndex = 5
        ' 
        ' PesquisaCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridViewCliente)
        Controls.Add(btnExtrato)
        Controls.Add(txtNome)
        Controls.Add(lblNome)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "PesquisaCliente"
        Text = "Pesquisa de Clientes"
        CType(DataGridViewCliente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents btnExtrato As Button
    Friend WithEvents DataGridViewCliente As DataGridView
End Class
