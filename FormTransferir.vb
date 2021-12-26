Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormTransferir
    Dim con As New MySqlConnection("server=eu-cdbr-west-03.cleardb.net;user=b871201390eafb;password=256c88f0;database=heroku_4710e77cd0c7a29")
    Dim cmd As New MySqlCommand
    Dim sda As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim Table As String = "vbnet_mysql_mb_table"
    Dim Data As Integer
    Dim dinheiro As Integer
    Dim dinheiroDestinatario As Integer
    Private Sub FormTransferir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão com a base de dados", "Mensagem de erro")
            Exit Sub
        End Try
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE'" & FormUtilizador.IDutilizador & "'"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        dt = New DataTable
        Data = sda.Fill(dt)
        dinheiro = dt.Rows(0)(2)
        lblSaldo.Text = "Saldo da Conta: " & dinheiro & "€"
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        If dinheiro - Val(txtValor.Text) >= 0 Then
            Try
                Convert.ToInt32(txtID.Text)
            Catch ex As Exception
                MessageBox.Show("Certifique-se que o ID inserido é um número.", "Erro de introdução de dados.")
                Exit Sub
            End Try
            Try
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE'" & txtID.Text & "'"
                sda = New MySqlDataAdapter(cmd.CommandText, con)
                dt = New DataTable
                Data = sda.Fill(dt)
                dinheiroDestinatario = dt.Rows(0)(2)
            Catch ex As Exception

            End Try
            Try
                Convert.ToInt32(txtValor.Text)
            Catch ex As Exception
                MessageBox.Show("Certifique-se que o valor inserido é um número.", "Erro de introdução de dados.")
                Exit Sub
            End Try
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE'" & txtID.Text & "'"
            sda = New MySqlDataAdapter(cmd.CommandText, con)
            dt = New DataTable
            Data = sda.Fill(dt)
            If Data = 0 Then
                MessageBox.Show("O id introduzido não foi encontrado na base de dados porfavor verifique.", "Erro de introdução de dados")
                Exit Sub
            Else
                Try
                    cmd = New MySqlCommand
                    With cmd
                        .CommandText = "INSERT INTO vbnet_mysql_transf_table SET  ID_Remetente=@id_remetente,ID_Destinatario=@id_destinatario,Valor_Enviado=@valor_enviado,Dia_Envio=@dia_envio,Hora_Envio=@hora_envio"
                        .Connection = con
                        .Parameters.AddWithValue("@id_remetente", FormUtilizador.IDutilizador)
                        .Parameters.AddWithValue("@id_destinatario", txtID.Text)
                        .Parameters.AddWithValue("@valor_enviado", txtValor.Text)
                        .Parameters.AddWithValue("@dia_envio", DateTime.Now.ToString("dd/MM/yyyy"))
                        .Parameters.AddWithValue("@hora_envio", DateTime.Now.ToString("HH:mm"))
                        .ExecuteNonQuery()
                    End With
                    cmd = New MySqlCommand
                    With cmd
                        .CommandText = "UPDATE " & Table & " SET  ID=@id,Dinheiro=@dinheiro  WHERE ID=@id"
                        .Connection = con
                        .Parameters.AddWithValue("@dinheiro", dinheiro - txtValor.Text)
                        .Parameters.AddWithValue("@id", FormUtilizador.IDutilizador)
                        .ExecuteNonQuery()
                    End With
                    cmd = New MySqlCommand
                    With cmd
                        .CommandText = "UPDATE " & Table & " SET  ID=@id,Dinheiro=@dinheiro  WHERE ID=@id"
                        .Connection = con
                        .Parameters.AddWithValue("@dinheiro", dinheiroDestinatario + txtValor.Text)
                        .Parameters.AddWithValue("@id", txtID.Text)
                        .ExecuteNonQuery()
                    End With
                    MessageBox.Show("Transferência efetuada corretamente.", "Informação")
                    dinheiro -= txtValor.Text
                    lblSaldo.Text = "Saldo da Conta: " & dinheiro & "€"
                Catch ex As Exception
                    MessageBox.Show("Erro na transferência  " & vbCr & ex.Message, "Mensagem de Erro")
                    con.Close()
                    Exit Sub
                End Try
            End If
        Else
            MessageBox.Show("Não tem dinheiro suficiente para a transferência.")
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class