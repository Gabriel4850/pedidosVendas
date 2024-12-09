<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produtos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produtos))
        lblNomeProduto = New Label()
        txtNomeProduto = New TextBox()
        lblDescricao = New Label()
        txtDescricao = New TextBox()
        txtValorUni = New TextBox()
        lblValorUni = New Label()
        btnCadastrarProd = New Button()
        bntPesquisa = New Button()
        SuspendLayout()
        ' 
        ' lblNomeProduto
        ' 
        lblNomeProduto.AutoSize = True
        lblNomeProduto.Location = New Point(22, 30)
        lblNomeProduto.Name = "lblNomeProduto"
        lblNomeProduto.Size = New Size(43, 15)
        lblNomeProduto.TabIndex = 0
        lblNomeProduto.Text = "Nome:"
        ' 
        ' txtNomeProduto
        ' 
        txtNomeProduto.Location = New Point(22, 67)
        txtNomeProduto.Name = "txtNomeProduto"
        txtNomeProduto.Size = New Size(497, 23)
        txtNomeProduto.TabIndex = 1
        ' 
        ' lblDescricao
        ' 
        lblDescricao.AutoSize = True
        lblDescricao.Location = New Point(22, 119)
        lblDescricao.Name = "lblDescricao"
        lblDescricao.Size = New Size(61, 15)
        lblDescricao.TabIndex = 2
        lblDescricao.Text = "Descrição:"
        ' 
        ' txtDescricao
        ' 
        txtDescricao.Location = New Point(22, 151)
        txtDescricao.Multiline = True
        txtDescricao.Name = "txtDescricao"
        txtDescricao.Size = New Size(497, 122)
        txtDescricao.TabIndex = 3
        ' 
        ' txtValorUni
        ' 
        txtValorUni.Location = New Point(22, 338)
        txtValorUni.Name = "txtValorUni"
        txtValorUni.Size = New Size(100, 23)
        txtValorUni.TabIndex = 4
        txtValorUni.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblValorUni
        ' 
        lblValorUni.AutoSize = True
        lblValorUni.Location = New Point(22, 303)
        lblValorUni.Name = "lblValorUni"
        lblValorUni.Size = New Size(80, 15)
        lblValorUni.TabIndex = 5
        lblValorUni.Text = "Valor unitário:"
        ' 
        ' btnCadastrarProd
        ' 
        btnCadastrarProd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCadastrarProd.Location = New Point(393, 391)
        btnCadastrarProd.Name = "btnCadastrarProd"
        btnCadastrarProd.Size = New Size(126, 47)
        btnCadastrarProd.TabIndex = 6
        btnCadastrarProd.Text = "CADASTRAR"
        btnCadastrarProd.UseVisualStyleBackColor = True
        ' 
        ' bntPesquisa
        ' 
        bntPesquisa.Image = CType(resources.GetObject("bntPesquisa.Image"), Image)
        bntPesquisa.Location = New Point(479, 30)
        bntPesquisa.Name = "bntPesquisa"
        bntPesquisa.Size = New Size(40, 23)
        bntPesquisa.TabIndex = 7
        bntPesquisa.UseVisualStyleBackColor = True
        ' 
        ' Produtos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(552, 450)
        Controls.Add(bntPesquisa)
        Controls.Add(btnCadastrarProd)
        Controls.Add(lblValorUni)
        Controls.Add(txtValorUni)
        Controls.Add(txtDescricao)
        Controls.Add(lblDescricao)
        Controls.Add(txtNomeProduto)
        Controls.Add(lblNomeProduto)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Produtos"
        Text = "Cadastro de Produtos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNomeProduto As Label
    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtValorUni As TextBox
    Friend WithEvents lblValorUni As Label
    Friend WithEvents btnCadastrarProd As Button
    Friend WithEvents bntPesquisa As Button
End Class
