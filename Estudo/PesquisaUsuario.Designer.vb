<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaUsuario
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
        lblNome = New Label()
        txtNome = New TextBox()
        DataGridViewUsuario = New DataGridView()
        btnExtrato = New Button()
        CType(DataGridViewUsuario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.Location = New Point(23, 24)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(43, 15)
        lblNome.TabIndex = 0
        lblNome.Text = "Nome:"
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(23, 53)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(453, 23)
        txtNome.TabIndex = 1
        ' 
        ' DataGridViewUsuario
        ' 
        DataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewUsuario.Location = New Point(23, 128)
        DataGridViewUsuario.Name = "DataGridViewUsuario"
        DataGridViewUsuario.Size = New Size(614, 310)
        DataGridViewUsuario.TabIndex = 2
        ' 
        ' btnExtrato
        ' 
        btnExtrato.Location = New Point(696, 52)
        btnExtrato.Name = "btnExtrato"
        btnExtrato.Size = New Size(75, 23)
        btnExtrato.TabIndex = 3
        btnExtrato.Text = "Extrato"
        btnExtrato.UseVisualStyleBackColor = True
        ' 
        ' PesquisaUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExtrato)
        Controls.Add(DataGridViewUsuario)
        Controls.Add(txtNome)
        Controls.Add(lblNome)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "PesquisaUsuario"
        Text = "Pesquisa de Usuario"
        CType(DataGridViewUsuario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents DataGridViewUsuario As DataGridView
    Friend WithEvents btnExtrato As Button
End Class
