<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        txtNome = New TextBox()
        txtEndereco = New TextBox()
        txtNumero = New TextBox()
        txtCidade = New TextBox()
        lblNome = New Label()
        lblEndereco = New Label()
        lblNumero = New Label()
        lblCidade = New Label()
        lblEstado = New Label()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblSenha = New Label()
        txtSenha = New TextBox()
        cmbEstado = New ComboBox()
        btnVoltar = New Button()
        btnCadastrar = New Button()
        btnPesquisa = New Button()
        btnNovo = New Button()
        btnEditar = New Button()
        btnExcluir = New Button()
        btnCancelar = New Button()
        lblCodigo = New Label()
        txtIdUsuario = New TextBox()
        SuspendLayout()
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(26, 74)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(416, 23)
        txtNome.TabIndex = 0
        ' 
        ' txtEndereco
        ' 
        txtEndereco.Location = New Point(26, 139)
        txtEndereco.Name = "txtEndereco"
        txtEndereco.Size = New Size(416, 23)
        txtEndereco.TabIndex = 1
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(457, 139)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(78, 23)
        txtNumero.TabIndex = 2
        ' 
        ' txtCidade
        ' 
        txtCidade.Location = New Point(26, 207)
        txtCidade.Name = "txtCidade"
        txtCidade.Size = New Size(358, 23)
        txtCidade.TabIndex = 3
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Location = New Point(26, 56)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(43, 15)
        lblNome.TabIndex = 5
        lblNome.Text = "Nome:"
        ' 
        ' lblEndereco
        ' 
        lblEndereco.AutoSize = True
        lblEndereco.Location = New Point(26, 121)
        lblEndereco.Name = "lblEndereco"
        lblEndereco.Size = New Size(59, 15)
        lblEndereco.TabIndex = 6
        lblEndereco.Text = "Endereço:"
        ' 
        ' lblNumero
        ' 
        lblNumero.AutoSize = True
        lblNumero.Location = New Point(457, 121)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New Size(54, 15)
        lblNumero.TabIndex = 7
        lblNumero.Text = "Número:"
        ' 
        ' lblCidade
        ' 
        lblCidade.AutoSize = True
        lblCidade.Location = New Point(26, 189)
        lblCidade.Name = "lblCidade"
        lblCidade.Size = New Size(47, 15)
        lblCidade.TabIndex = 8
        lblCidade.Text = "Cidade:"
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(390, 189)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(45, 15)
        lblEstado.TabIndex = 9
        lblEstado.Text = "Estado:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(26, 282)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(44, 15)
        lblEmail.TabIndex = 10
        lblEmail.Text = "E-mail:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(26, 306)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(416, 23)
        txtEmail.TabIndex = 5
        ' 
        ' lblSenha
        ' 
        lblSenha.AutoSize = True
        lblSenha.Location = New Point(26, 354)
        lblSenha.Name = "lblSenha"
        lblSenha.Size = New Size(42, 15)
        lblSenha.TabIndex = 12
        lblSenha.Text = "Senha:"
        ' 
        ' txtSenha
        ' 
        txtSenha.Location = New Point(26, 372)
        txtSenha.Name = "txtSenha"
        txtSenha.PasswordChar = "*"c
        txtSenha.Size = New Size(283, 23)
        txtSenha.TabIndex = 6
        ' 
        ' cmbEstado
        ' 
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstado.FormattingEnabled = True
        cmbEstado.Items.AddRange(New Object() {"AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF"})
        cmbEstado.Location = New Point(390, 207)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(52, 23)
        cmbEstado.TabIndex = 4
        ' 
        ' btnVoltar
        ' 
        btnVoltar.BackColor = Color.Transparent
        btnVoltar.FlatStyle = FlatStyle.Flat
        btnVoltar.Image = My.Resources.Resources.icons8_voltar_24
        btnVoltar.Location = New Point(12, 12)
        btnVoltar.Name = "btnVoltar"
        btnVoltar.Size = New Size(40, 21)
        btnVoltar.TabIndex = 15
        btnVoltar.UseVisualStyleBackColor = False
        ' 
        ' btnCadastrar
        ' 
        btnCadastrar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCadastrar.Location = New Point(578, 189)
        btnCadastrar.Name = "btnCadastrar"
        btnCadastrar.Size = New Size(112, 38)
        btnCadastrar.TabIndex = 7
        btnCadastrar.Text = "Cadastrar"
        btnCadastrar.UseVisualStyleBackColor = True
        ' 
        ' btnPesquisa
        ' 
        btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), Image)
        btnPesquisa.Location = New Point(457, 74)
        btnPesquisa.Name = "btnPesquisa"
        btnPesquisa.Size = New Size(40, 23)
        btnPesquisa.TabIndex = 16
        btnPesquisa.UseVisualStyleBackColor = True
        ' 
        ' btnNovo
        ' 
        btnNovo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNovo.Location = New Point(578, 63)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(112, 38)
        btnNovo.TabIndex = 17
        btnNovo.Text = "Novo"
        btnNovo.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditar.Location = New Point(578, 128)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(112, 38)
        btnEditar.TabIndex = 18
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExcluir.Location = New Point(578, 317)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(112, 38)
        btnExcluir.TabIndex = 19
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(578, 259)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(112, 38)
        btnCancelar.TabIndex = 20
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Location = New Point(316, 29)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New Size(49, 15)
        lblCodigo.TabIndex = 21
        lblCodigo.Text = "Código:"
        ' 
        ' txtIdUsuario
        ' 
        txtIdUsuario.Location = New Point(371, 26)
        txtIdUsuario.Name = "txtIdUsuario"
        txtIdUsuario.Size = New Size(71, 23)
        txtIdUsuario.TabIndex = 22
        ' 
        ' Cadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(704, 421)
        Controls.Add(txtIdUsuario)
        Controls.Add(lblCodigo)
        Controls.Add(btnCancelar)
        Controls.Add(btnExcluir)
        Controls.Add(btnEditar)
        Controls.Add(btnNovo)
        Controls.Add(btnPesquisa)
        Controls.Add(btnCadastrar)
        Controls.Add(btnVoltar)
        Controls.Add(cmbEstado)
        Controls.Add(txtSenha)
        Controls.Add(lblSenha)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(lblEstado)
        Controls.Add(lblCidade)
        Controls.Add(lblNumero)
        Controls.Add(lblEndereco)
        Controls.Add(lblNome)
        Controls.Add(txtCidade)
        Controls.Add(txtNumero)
        Controls.Add(txtEndereco)
        Controls.Add(txtNome)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Cadastro"
        Text = "Cadastro de Usuários"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtIdUsuario As TextBox
End Class
