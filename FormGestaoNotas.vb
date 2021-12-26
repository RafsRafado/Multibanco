Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormGestaoNotas
    Dim con As New MySqlConnection(("server=eu-cdbr-west-03.cleardb.net;user=b871201390eafb;password=256c88f0;database=heroku_4710e77cd0c7a29"))
    Dim cmd, cmdbald As New MySqlCommand
    Dim sda, sdabald As New MySqlDataAdapter
    Dim dt, dtbald As New DataTable
    Dim Table As String = "vbnet_mysql_notas_table"
    Dim Data, databald As Integer
    Private Sub FormGestaoNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Notas_5, Notas_10, Notas_20, Notas_50 from " & Table
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão com a base de dados", "Mensagem de erro")
            Exit Sub
        End Try
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        dt = New DataTable
        Data = sda.Fill(dt)
        If Data = 0 Then
            txt5.Text = "0"
            txt10.Text = "0"
            txt20.Text = "0"
            txt50.Text = "0"
        Else
            txt5.Text = dt.Rows(0)(0)
            txt10.Text = dt.Rows(0)(1)
            txt20.Text = dt.Rows(0)(2)
            txt50.Text = dt.Rows(0)(3)
        End If
        txt5.Focus()
    End Sub
    Private Sub Btnaplicar_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnAplicar.MouseEnter
        btnAplicar.Image = My.Resources.botao_hover
    End Sub

    Private Sub Btnaplicar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAplicar.MouseLeave
        btnAplicar.Image = My.Resources.botao
    End Sub
    Private Sub Btnsair_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnSair.MouseEnter
        btnSair.Image = My.Resources.botao_hover
    End Sub

    Private Sub Btnsair_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSair.MouseLeave
        btnSair.Image = My.Resources.botao
    End Sub
    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Try
            Convert.ToInt32(txt5.Text)
        Catch ex As Exception
            MessageBox.Show("Porfavor, Introduza um número na nota de 5, se não tiver introduza 0.")
            Exit Sub
        End Try
        Try
            Convert.ToInt32(txt10.Text)
        Catch ex As Exception
            MessageBox.Show("Porfavor, Introduza um número na nota de 10, se não tiver introduza 0.")
            Exit Sub
        End Try
        Try
            Convert.ToInt32(txt20.Text)
        Catch ex As Exception
            MessageBox.Show("Porfavor, Introduza um número na nota de 20, se não tiver introduza 0.")
            Exit Sub
        End Try
        Try
            Convert.ToInt32(txt50.Text)
        Catch ex As Exception
            MessageBox.Show("Porfavor, Introduza um número na nota de 50, se não tiver introduza 0.")
            Exit Sub
        End Try

        If Data = 0 Then
            Try
                cmd = New MySqlCommand
                With cmd
                    .CommandText = "INSERT INTO " & Table & " SET  Notas_5=@notas5,Notas_10=@notas10,Notas_20=@notas20,Notas_50=@notas50"
                    .Connection = con
                    .Parameters.AddWithValue("@notas5", txt5.Text)
                    .Parameters.AddWithValue("@notas10", txt10.Text)
                    .Parameters.AddWithValue("@notas20", txt20.Text)
                    .Parameters.AddWithValue("@notas50", txt50.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Dados guardados Corretamente", MsgBoxStyle.Information, "Informação")
            Catch ex As Exception
                MsgBox("Erro na gravação de dados !" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensagem de Erro")
                con.Close()
                Return
            End Try
            con.Close()
            Exit Sub
        Else
            Try
                cmd = New MySqlCommand
                With cmd
                    .CommandText = "UPDATE " & Table & " SET  Notas_5=@notas5,Notas_10=@notas10,Notas_20=@notas20,Notas_50=@notas50"
                    .Connection = con
                    .Parameters.AddWithValue("@notas5", txt5.Text)
                    .Parameters.AddWithValue("@notas10", txt10.Text)
                    .Parameters.AddWithValue("@notas20", txt20.Text)
                    .Parameters.AddWithValue("@notas50", txt50.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Dados guardados Corretamente", MsgBoxStyle.Information, "Informação")
            Catch ex As Exception
                MsgBox("Erro de atualização de dados !" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensagem de erro")
                con.Close()
                Return
            End Try
            con.Close()
        End If
        Try
            con.Open()
            cmdbald.CommandType = CommandType.Text
            cmdbald.CommandText = "select Dia, Valor, quant5, quant10, quant20, quant50 from vbnet_mysql_mb_baldiario where Dia LIKE '" & DateTime.Now.ToString("dd/MM/yyyy") & "'"
            sdabald = New MySqlDataAdapter(cmdbald.CommandText, con)
            dtbald = New DataTable
            databald = sdabald.Fill(dtbald)
            If databald = 0 Then
                With cmd
                    .CommandText = "INSERT INTO vbnet_mysql_mb_baldiario SET  Dia=@dia,Valor=@Valor,quant5=@quant5,quant10=@quant10,quant20=@quant20,quant50=@quant50"
                    .Connection = con
                    .Parameters.AddWithValue("@dia", DateTime.Now.ToString("dd/MM/yyyy"))
                    .Parameters.AddWithValue("@valor", 0)
                    .Parameters.AddWithValue("@quant5", Val(txt5.Text))
                    .Parameters.AddWithValue("@quant10", Val(txt10.Text))
                    .Parameters.AddWithValue("@quant20", Val(txt20.Text))
                    .Parameters.AddWithValue("@quant50", Val(txt50.Text))
                    .ExecuteNonQuery()
                End With
            Else
                With cmd
                    .CommandText = "UPDATE vbnet_mysql_mb_baldiario SET  Dia=@dia,Valor=@Valor,quant5=@quant5,quant10=@quant10,quant20=@quant20,quant50=@quant50"
                    .Connection = con
                    .Parameters.AddWithValue("@dia", DateTime.Now.ToString("dd/MM/yyyy"))
                    .Parameters.AddWithValue("@valor", dtbald.Rows(0)(1))
                    .Parameters.AddWithValue("@quant5", Val(txt5.Text))
                    .Parameters.AddWithValue("@quant10", Val(txt10.Text))
                    .Parameters.AddWithValue("@quant20", Val(txt20.Text))
                    .Parameters.AddWithValue("@quant50", Val(txt50.Text))
                    .ExecuteNonQuery()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar/atualizar registo do balanço diário.")
        End Try

        Dim result As DialogResult = MsgBox("Registo adicionado com sucesso, Deseja sair?", vbYesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class