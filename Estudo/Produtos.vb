Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports Windows.Win32.System

Public Class Produtos
    Dim connectionString As String = "Server=NomeServidor;Database=estudo;Integrated Security=True;"
    Private Sub lblDescricao_Click(sender As Object, e As EventArgs) Handles lblDescricao.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtValorUni.TextChanged
        ValidaCampos()
    End Sub

    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' texto que aparece ao abrir o form
        txtValorUni.Text = "0,00"

        btnCadastrarProd.Enabled = False
    End Sub

    Private Sub txtValorUni_Enter(sender As Object, e As EventArgs) Handles txtValorUni.Enter
        ' Ao clicar no txtValorUni verifica se é "0,00". Se for, limpa o campo
        If txtValorUni.Text = "0,00" Then
            txtValorUni.Text = ","
        End If
    End Sub

    Private Sub txtValorUni_Leave(sender As Object, e As EventArgs) Handles txtValorUni.Leave ' Evento é acionado quando txtValorUni perde o foco (Leave) 
        ' String.IsNullOrWhiteSpace(txtPreco.Text) Verifica se está vazio
        If String.IsNullOrWhiteSpace(txtValorUni.Text) Then
            txtValorUni.Text = "0,00"

            'senão estiver vazio (else)  
        Else
            Dim valor As Decimal
            ' converter o valor inserido em decimal (Decimal.TryParse).
            If Decimal.TryParse(txtValorUni.Text, valor) Then
                txtValorUni.Text = valor.ToString("0.00")
            Else
                txtValorUni.Text = "0,00"
            End If
        End If

    End Sub

    Private Sub txtValorUni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorUni.KeyPress ' Acionado sempre que uma tecla é pressionada
        ' Char.IsDigit verifica se é um dígito numérico de 0 a 9.
        ' e.KeyChar representa o caractere que foi pressionado pelo usuário.
        ' e.KeyChar = "," Verifica se é uma vírgula (",").
        ' Char.IsControl(e.KeyChar) Verifica se o é uma tecla de controle (backspace, delete, setas Do teclado...)
        ' Not para inverter a lógica. Ou seja, se não for um dígito, nem uma vírgula, nem uma tecla de controle, então 
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "," OrElse Char.IsControl(e.KeyChar)) Then
            'indica que deve ignorar o caractere que foi pressionado (não será exibido)
            e.Handled = True

        End If
    End Sub

    Private Sub mtbValorUni_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCadastrarProd.Click
        Using connection As New SqlConnection(connectionString)

            Try
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM produtos WHERE produto = @produto"

                Using Command As New SqlCommand(query, connection)

                    Command.Parameters.AddWithValue("@produto", txtNomeProduto.Text)
                    Command.ExecuteNonQuery()

                    Dim resultado = Convert.ToInt32(Command.ExecuteScalar())

                    If resultado = 1 Then
                        MessageBox.Show("Produto já cadastrado!")
                        Me.btnCadastrarProd.Enabled = False
                    Else

                        Dim queryInsert As String = "INSERT INTO produtos (produto, descricao, valor_unitario) VALUES (@produto, @descricao, @valor)"

                        Using Command2 As New SqlCommand(queryInsert, connection)

                            Command2.Parameters.AddWithValue("@produto", txtNomeProduto.Text)
                            Command2.Parameters.AddWithValue("@descricao", txtDescricao.Text)

                            ' variavel decimal
                            Dim valor As Decimal
                            ' substitui a , por . e armazena na variavel valorText
                            Dim valorText As String = txtValorUni.Text.Replace(",", ".")

                            ' Esse trecho garante que o valor fornecido pelo usuário é um número decimal válido antes de tentar inseri-lo no banco de dados,
                            ' prevenindo erros e mantendo a integridade dos dados.
                            ' Decimal.TryParse - converte a string (valorText) e armazena em decimal (valor)
                            ' Globalization.NumberStyles.Number - especifica o formato do número a ser aceito (permite números com separadores decimais e outros caracteres numéricos padrão)
                            ' Globalization.CultureInfo.InvariantCulture:
                            ' - IFormatProvider define a cultura para interpretação do número
                            ' - InvariantCulture usa ponto (.) como separador decimal e é independente da configuração regional do sistema.
                            If Decimal.TryParse(valorText, Globalization.NumberStyles.Number, Globalization.CultureInfo.InvariantCulture, valor) Then
                                Command2.Parameters.AddWithValue("@valor", valor)
                            Else
                                MessageBox.Show("Valor inserido não é válido")

                                ' Interrompe a execução do método atual. Previne que o código continue e tente executar o comando SQL com um valor inválido.
                                Return

                            End If

                            Command2.ExecuteNonQuery()

                            MessageBox.Show("Produto cadastrado com sucesso")

                            txtNomeProduto.Text = ""
                            txtDescricao.Text = ""
                            txtValorUni.Text = "0,00"

                        End Using
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Erro com banco de dados: " & ex.Message)
            End Try

        End Using

    End Sub

    Private Sub txtNomeProduto_TextChanged(sender As Object, e As EventArgs) Handles txtNomeProduto.TextChanged
        'Using connection As New SqlConnection(connectionString)

        '    Try

        '        connection.Open()

        '        Dim query As String = "SELECT COUNT(*) FROM produtos WHERE produto = @produto"

        '        Using Command As New SqlCommand(query, connection)

        '            Command.Parameters.AddWithValue("@produto", txtNomeProduto.Text)
        '            Command.ExecuteNonQuery()

        '            Dim resualtado = Convert.ToInt32(Command.ExecuteScalar())

        '            If resualtado = 1 Then
        '                MessageBox.Show("Produto já cadastrado!")
        '                Me.btnCadastrarProd.Enabled = False
        '            Else
        '                Me.btnCadastrarProd.Enabled = True
        '            End If

        '        End Using

        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try

        'End Using

        'ValidaCampos()
    End Sub

    Private Sub bntPesquisa_Click(sender As Object, e As EventArgs) Handles bntPesquisa.Click
        Dim pedidoVenda As New PedidoDeVenda("PedidoDeVenda") ' ou obter a instância existente
        Dim pesquisaProdutos As New PesquisaProdutos("PesquisaProduto", pedidoVenda)
        pesquisaProdutos.Show()
        Me.Hide()

    End Sub

    Private Function TodosCamposPreenchidos() As Boolean

        Dim valorUni As Decimal

        ' Verifica se os campos de texto não estão vazios 
        Return Not (String.IsNullOrEmpty(txtNomeProduto.Text) OrElse
                    String.IsNullOrEmpty(txtDescricao.Text) OrElse
                    Not Decimal.TryParse(txtValorUni.Text, valorUni) OrElse 'converte txtValorUni.Text para um número decimal e armazena na variavel valorUni
                    valorUni <= 0) 'verifica se o valor é maior ou igual a zero
    End Function

    Private Sub ValidaCampos()
        If TodosCamposPreenchidos() Then
            btnCadastrarProd.Enabled = True
        Else
            btnCadastrarProd.Enabled = False
        End If
    End Sub

    Private Sub txtDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtDescricao.TextChanged
        ValidaCampos()
    End Sub
End Class
