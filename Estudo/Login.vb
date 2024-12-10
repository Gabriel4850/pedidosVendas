Imports System.Data.SqlClient

Public Class Login

    Dim connectionString As String = "Server=NomeServidor;Database=estudo;Integrated Security=True;"
    Private Sub lblUsuario_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        'Dim pedidos As New Pedidos
        'Trim = remover espaços em branco digitados acidentalmente pelo usuário
        Dim usuario As String = txtUsuario.Text.Trim
        Dim senha As String = txtSenha.Text.Trim

        ' COUNT = retorna o numero de consulta encontrado
        Dim query As String = "SELECT COUNT(*) FROM cadastro WHERE nome = @nome and senha = @senha"

        ' O bloco Using é usado para garantir que os recursos sejam liberados corretamente após o término de seu uso (End Using)
        ' Maneira segura de estabelecer uma conexão com um banco de dados SQL Server
        Using connection As New SqlConnection(connectionString)

            ' cria um objeto (SqlCommand) que representa um comando SQL a ser executado no banco de dados
            ' query = string contendo o comando SQL
            ' connection = conexão com o banco de dados
            Using Command As New SqlCommand(query, connection)
                Command.Parameters.AddWithValue("@nome", txtUsuario.Text)
                Command.Parameters.AddWithValue("@senha", txtSenha.Text)

                Try
                    connection.Open()

                    'ExecuteScalar() é um método de SqlCommand que é usado quando você espera que sua consulta SQL retorne um único valor (COUNT(*))
                    ' ExecuteScalar() retorna um objeto Object, que precisa ser convertido para o tipo desejado
                    ' Convert.ToInt32() = converter o resultado retornado por ExecuteScalar() em Integer
                    Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())

                    If resultado = 1 Then
                        Principal.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Usuário ou Senha incorretos.")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Erro ao conectar ao banco de dados" & ex.Message)
                End Try
            End Using
        End Using



    End Sub

    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs) Handles txtSenha.TextChanged

    End Sub
End Class
