<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        lblUsuario = New Label()
        lblSenha = New Label()
        txtUsuario = New TextBox()
        txtSenha = New TextBox()
        btnEntrar = New Button()
        SuspendLayout()
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsuario.Location = New Point(141, 39)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(56, 17)
        lblUsuario.TabIndex = 0
        lblUsuario.Text = "Usuário:"
        ' 
        ' lblSenha
        ' 
        lblSenha.AutoSize = True
        lblSenha.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSenha.Location = New Point(141, 154)
        lblSenha.Name = "lblSenha"
        lblSenha.Size = New Size(46, 17)
        lblSenha.TabIndex = 1
        lblSenha.Text = "Senha:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(30, 76)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(292, 23)
        txtUsuario.TabIndex = 2
        ' 
        ' txtSenha
        ' 
        txtSenha.Location = New Point(30, 191)
        txtSenha.Name = "txtSenha"
        txtSenha.Size = New Size(292, 23)
        txtSenha.TabIndex = 3
        txtSenha.UseSystemPasswordChar = True
        ' 
        ' btnEntrar
        ' 
        btnEntrar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEntrar.Location = New Point(115, 274)
        btnEntrar.Name = "btnEntrar"
        btnEntrar.Size = New Size(112, 38)
        btnEntrar.TabIndex = 4
        btnEntrar.Text = "ENTRAR"
        btnEntrar.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(354, 362)
        Controls.Add(btnEntrar)
        Controls.Add(txtSenha)
        Controls.Add(txtUsuario)
        Controls.Add(lblSenha)
        Controls.Add(lblUsuario)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnEntrar As Button
End Class
