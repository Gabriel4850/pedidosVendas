<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroClientes))
        btnCadastrar = New Button()
        btnVoltar = New Button()
        cmbEstado = New ComboBox()
        txtEmail = New TextBox()
        lblEmail = New Label()
        lblEstado = New Label()
        lblCidade = New Label()
        lblNumero = New Label()
        lblEndereco = New Label()
        lblNome = New Label()
        txtCidade = New TextBox()
        txtNumero = New TextBox()
        txtEndereco = New TextBox()
        txtNome = New TextBox()
        btnPesquisa = New Button()
        btnCancelar = New Button()
        btnExcluir = New Button()
        btnEditar = New Button()
        btnNovo = New Button()
        txtIdUsuario = New TextBox()
        lblCodigo = New Label()
        SuspendLayout()
        ' 
        ' btnCadastrar
        ' 
        btnCadastrar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCadastrar.Location = New Point(564, 175)
        btnCadastrar.Name = "btnCadastrar"
        btnCadastrar.Size = New Size(112, 38)
        btnCadastrar.TabIndex = 25
        btnCadastrar.Text = "Cadastrar"
        btnCadastrar.UseVisualStyleBackColor = True
        ' 
        ' btnVoltar
        ' 
        btnVoltar.BackColor = Color.Transparent
        btnVoltar.FlatStyle = FlatStyle.Flat
        btnVoltar.Image = My.Resources.Resources.icons8_voltar_24
        btnVoltar.Location = New Point(16, 12)
        btnVoltar.Name = "btnVoltar"
        btnVoltar.Size = New Size(40, 21)
        btnVoltar.TabIndex = 31
        btnVoltar.UseVisualStyleBackColor = False
        ' 
        ' cmbEstado
        ' 
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstado.FormattingEnabled = True
        cmbEstado.Items.AddRange(New Object() {"AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF"})
        cmbEstado.Location = New Point(394, 207)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(52, 23)
        cmbEstado.TabIndex = 20
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(30, 306)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(416, 23)
        txtEmail.TabIndex = 21
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(30, 282)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(44, 15)
        lblEmail.TabIndex = 29
        lblEmail.Text = "E-mail:"
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(394, 189)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(45, 15)
        lblEstado.TabIndex = 28
        lblEstado.Text = "Estado:"
        ' 
        ' lblCidade
        ' 
        lblCidade.AutoSize = True
        lblCidade.Location = New Point(30, 189)
        lblCidade.Name = "lblCidade"
        lblCidade.Size = New Size(47, 15)
        lblCidade.TabIndex = 27
        lblCidade.Text = "Cidade:"
        ' 
        ' lblNumero
        ' 
        lblNumero.AutoSize = True
        lblNumero.Location = New Point(461, 121)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New Size(54, 15)
        lblNumero.TabIndex = 26
        lblNumero.Text = "Número:"
        ' 
        ' lblEndereco
        ' 
        lblEndereco.AutoSize = True
        lblEndereco.Location = New Point(30, 121)
        lblEndereco.Name = "lblEndereco"
        lblEndereco.Size = New Size(59, 15)
        lblEndereco.TabIndex = 24
        lblEndereco.Text = "Endereço:"
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Location = New Point(30, 56)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(43, 15)
        lblNome.TabIndex = 22
        lblNome.Text = "Nome:"
        ' 
        ' txtCidade
        ' 
        txtCidade.Location = New Point(30, 207)
        txtCidade.Name = "txtCidade"
        txtCidade.Size = New Size(358, 23)
        txtCidade.TabIndex = 19
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(461, 139)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(78, 23)
        txtNumero.TabIndex = 18
        ' 
        ' txtEndereco
        ' 
        txtEndereco.Location = New Point(30, 139)
        txtEndereco.Name = "txtEndereco"
        txtEndereco.Size = New Size(416, 23)
        txtEndereco.TabIndex = 17
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(30, 74)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(416, 23)
        txtNome.TabIndex = 16
        ' 
        ' btnPesquisa
        ' 
        btnPesquisa.Image = CType(resources.GetObject("btnPesquisa.Image"), Image)
        btnPesquisa.Location = New Point(461, 73)
        btnPesquisa.Name = "btnPesquisa"
        btnPesquisa.Size = New Size(40, 23)
        btnPesquisa.TabIndex = 32
        btnPesquisa.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(564, 236)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(112, 38)
        btnCancelar.TabIndex = 37
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExcluir.Location = New Point(564, 295)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(112, 38)
        btnExcluir.TabIndex = 36
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditar.Location = New Point(564, 120)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(112, 38)
        btnEditar.TabIndex = 35
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnNovo
        ' 
        btnNovo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNovo.Location = New Point(564, 63)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(112, 38)
        btnNovo.TabIndex = 34
        btnNovo.Text = "Novo"
        btnNovo.UseVisualStyleBackColor = True
        ' 
        ' txtIdUsuario
        ' 
        txtIdUsuario.Location = New Point(375, 24)
        txtIdUsuario.Name = "txtIdUsuario"
        txtIdUsuario.Size = New Size(71, 23)
        txtIdUsuario.TabIndex = 39
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Location = New Point(320, 27)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New Size(49, 15)
        lblCodigo.TabIndex = 38
        lblCodigo.Text = "Código:"
        ' 
        ' CadastroClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(692, 363)
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
        MaximizeBox = False
        Name = "CadastroClientes"
        Text = "Cadastro de Clientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents txtIdUsuario As TextBox
    Friend WithEvents lblCodigo As Label
End Class
