Imports MySql.Data.MySqlClient
Public Class FormLevantar
    Dim con As New MySqlConnection("server=eu-cdbr-west-03.cleardb.net;user=b871201390eafb;password=256c88f0;database=heroku_4710e77cd0c7a29")
    Dim cmd, cmdnotas, cmdbald As New MySqlCommand
    Dim sda, sdanotas, sdabald As New MySqlDataAdapter
    Dim dt, dtnotas, dtbald As New DataTable
    Dim Data, dinheiro, databald As Integer
    Dim levantar As Integer
    Dim nota5, nota10, nota20, nota50 As Integer

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        txtLevantar.Clear()
    End Sub

    Dim quantn5, quantn10, quantn20, quantn50 As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If dtnotas.Rows(0)(0) = 0 And dtnotas.Rows(0)(1) = 0 And dtnotas.Rows(0)(2) = 0 And dtnotas.Rows(0)(3) = 0 Then
            MessageBox.Show("Não existem notas na caixa multibanco, não vai ser possível fazer o levantamento.")
            Me.Close()
            Exit Sub
        End If

        If dtnotas.Rows(0)(0) = 0 Then
            MessageBox.Show("Não existem notas de 5€ disponíveis!")
            btn5.Visible = False

        End If
        If dtnotas.Rows(0)(1) = 0 Then
            MessageBox.Show("Não existem notas de 10€ disponíveis!")

        End If
        If dtnotas.Rows(0)(2) = 0 Then
            MessageBox.Show("Não existem notas de 20€ disponíveis!")

        End If
        If dtnotas.Rows(0)(3) = 0 Then
            MessageBox.Show("Não existem notas de 50€ disponíveis!")

        End If
    End Sub


    Private Sub FormLevantar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select Nome, Pin, dinheiro, Id from vbnet_mysql_mb_table where Id Like '" & FormUtilizador.IDutilizador & "'"
            sda = New MySqlDataAdapter(cmd.CommandText, con)
            dt = New DataTable
            Data = sda.Fill(dt)
            If (Data > 0) Then
                lbsaldo.Text = "Saldo: " & dt.Rows(0)(2) & " €"
                dinheiro = dt.Rows(0)(2)
            End If
            cmdnotas.CommandType = CommandType.Text
            cmdnotas.CommandText = "select Notas_5, Notas_10, Notas_20, Notas_50 from vbnet_mysql_notas_table"
            sdanotas = New MySqlDataAdapter(cmdnotas.CommandText, con)
            dtnotas = New DataTable
            sdanotas.Fill(dtnotas)
            quantn50 = dtnotas.Rows(0)(3)
            quantn20 = dtnotas.Rows(0)(2)
            quantn10 = dtnotas.Rows(0)(1)
            quantn5 = dtnotas.Rows(0)(0)
        Catch ex As Exception
            MessageBox.Show("Erro de conexão !" & vbCrLf & "Porfavor, verifique o servidor !", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        If dtnotas.Rows(0)(0) = 0 Then
            Timer1.Start()
            btn5.Enabled = False
            Exit Sub
        End If
        If dtnotas.Rows(0)(1) = 0 Then
            Timer1.Start()
            Exit Sub
        End If
        If dtnotas.Rows(0)(2) = 0 Then
            Timer1.Start()
            Exit Sub

        End If
        If dtnotas.Rows(0)(3) = 0 Then
            Timer1.Start()
            Exit Sub

        End If
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If dinheiro >= Val(txtLevantar.Text) + 5 Then
            levantar += 5
            txtLevantar.Text = levantar
        Else
            MsgBox("Não tem dinheiro suficiente para adicionar mais 5€")
            Exit Sub
        End If
    End Sub
    Private Sub Btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If dinheiro >= Val(txtLevantar.Text) + 10 Then
            levantar += 10
            txtLevantar.Text = levantar
        Else
            MsgBox("Não tem dinheiro suficiente para adicionar mais 10€")
            Exit Sub
        End If
    End Sub

    Private Sub Btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        If dinheiro >= Val(txtLevantar.Text) + 20 Then
            levantar += 20
            txtLevantar.Text = levantar
        Else
            MsgBox("Não tem dinheiro suficiente para adicionar mais 20€")
            Exit Sub
        End If
    End Sub

    Private Sub Btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        If dinheiro >= Val(txtLevantar.Text) + 50 Then
            levantar += 50
            txtLevantar.Text = levantar
        Else
            MsgBox("Não tem dinheiro suficiente para adicionar mais 50€")
        End If
    End Sub

    Private Sub BtnLevantar_Click(sender As Object, e As EventArgs) Handles btnLevantar.Click
        If Val(txtLevantar.Text) > 0 Then
            Do While levantar <> 0
                If levantar >= 50 And quantn50 > 0 Then
                    nota50 = nota50 + 1
                    levantar = levantar - 50
                    quantn50 = quantn50 - 1
                ElseIf levantar >= 20 And quantn20 > 0 Then
                    nota20 = nota20 + 1
                    levantar = levantar - 20
                    quantn20 = quantn20 - 1
                ElseIf levantar >= 10 And quantn10 > 0 Then
                    nota10 = nota10 + 1
                    levantar = levantar - 10
                    quantn10 = quantn10 - 1

                ElseIf levantar >= 5 And quantn5 > 0 Then
                    nota5 = nota5 + 1
                    levantar = levantar - 5
                    quantn5 = quantn5 - 1
                ElseIf quantn5 = 0 And quantn10 = 0 And quantn20 = 0 And quantn50 = 0 And levantar <> 0 Then
                    MessageBox.Show("Foi possível levantar apenas " & txtLevantar.Text - levantar & "€ pois acabaram-se as notas na caixa mutlibanco , pedimos desculpa.")
                    txtLevantar.Text = Val(txtLevantar.Text) - levantar
                    levantar = 0
                End If
            Loop
            dinheiro = dinheiro - Val(txtLevantar.Text)
            Try
                con.Open()
                cmd = New MySqlCommand
                With cmd
                    .CommandText = "UPDATE vbnet_mysql_notas_table SET  Notas_5=@notas5,Notas_10=@notas10,Notas_20=@notas20,Notas_50=@notas50"
                    .Connection = con
                    .Parameters.AddWithValue("@notas5", dtnotas.Rows(0)(0) - nota5)
                    .Parameters.AddWithValue("@notas10", dtnotas.Rows(0)(1) - nota10)
                    .Parameters.AddWithValue("@notas20", dtnotas.Rows(0)(2) - nota20)
                    .Parameters.AddWithValue("@notas50", dtnotas.Rows(0)(3) - nota50)
                    .ExecuteNonQuery()
                End With
                con.Close()
            Catch ex As Exception
                MsgBox("Erro no processo de levantamento tente novamente mais tarde ou contacte um administrador. Obrigado." & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensagem de Erro")
                con.Close()
                Exit Sub
            End Try
            Try
                con.Open()
                With cmd
                    .CommandText = "UPDATE vbnet_mysql_mb_table SET  ID=@id,Nome=@nome,Pin=@pin,Dinheiro=@dinheiro  WHERE ID=@id"
                    .Connection = con
                    .Parameters.AddWithValue("@nome", dt.Rows(0)(0))
                    .Parameters.AddWithValue("@pin", dt.Rows(0)(1))
                    .Parameters.AddWithValue("@dinheiro", dinheiro)
                    .Parameters.AddWithValue("@id", FormUtilizador.IDutilizador)
                    .ExecuteNonQuery()
                End With
                con.Close()
            Catch ex As Exception
                MsgBox("Erro no processo de levantamento tente novamente mais tarde ou contacte um administrador. Obrigado." & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensagem de Erro")
                con.Open()
                cmd = New MySqlCommand
                With cmd
                    .CommandText = "UPDATE vbnet_mysql_notas_table SET  Notas_5=@notas5,Notas_10=@notas10,Notas_20=@notas20,Notas_50=@notas50"
                    .Connection = con
                    .Parameters.AddWithValue("@notas5", dtnotas.Rows(0)(0) + nota5)
                    .Parameters.AddWithValue("@notas10", dtnotas.Rows(0)(1) + nota10)
                    .Parameters.AddWithValue("@notas20", dtnotas.Rows(0)(2) + nota20)
                    .Parameters.AddWithValue("@notas50", dtnotas.Rows(0)(3) + nota50)
                    .ExecuteNonQuery()
                End With
                con.Close()
                Exit Sub
            End Try
            Try
                con.Open()
                cmdbald.CommandType = CommandType.Text
                cmdbald.CommandText = "select Dia, Valor, quant5, quant10, quant20, quant50,quantransf from vbnet_mysql_mb_baldiario where Dia LIKE '" & DateTime.Now.ToString("dd/MM/yyyy") & "'"
                sdabald = New MySqlDataAdapter(cmdbald.CommandText, con)
                dtbald = New DataTable
                databald = sdabald.Fill(dtbald)
                If databald > 0 Then
                    With cmd
                        .CommandText = "UPDATE vbnet_mysql_mb_baldiario SET  Dia=@dia,Valor=@valor,quant5=@quant5,quant10=@quant10,quant20=@quant20,quant50=@quant50,quantransf=@quantransf"
                        .Connection = con
                        .Parameters.AddWithValue("@dia", DateTime.Now.ToString("dd/MM/yyyy"))
                        .Parameters.AddWithValue("@valor", dtbald.Rows(0)(1) + txtLevantar.Text)
                        .Parameters.AddWithValue("@quant5", quantn5)
                        .Parameters.AddWithValue("@quant10", quantn10)
                        .Parameters.AddWithValue("@quant20", quantn20)
                        .Parameters.AddWithValue("@quant50", quantn50)
                        .Parameters.AddWithValue("@quantransf", dtbald.Rows(0)(6) + 1)
                        .ExecuteNonQuery()
                    End With
                Else
                    With cmd
                        .CommandText = "INSERT INTO vbnet_mysql_mb_baldiario SET  Dia=@dia,Valor=@Valor,quant5=@quant5,quant10=@quant10,quant20=@quant20,quant50=@quant50,quantransf=@quantransf"
                        .Connection = con
                        .Parameters.AddWithValue("@dia", DateTime.Now.ToString("dd/MM/yyyy"))
                        .Parameters.AddWithValue("@valor", txtLevantar.Text)
                        .Parameters.AddWithValue("@quant5", quantn5)
                        .Parameters.AddWithValue("@quant10", quantn10)
                        .Parameters.AddWithValue("@quant20", quantn20)
                        .Parameters.AddWithValue("@quant50", quantn50)
                        .Parameters.AddWithValue("@quantransf", "1")
                        .ExecuteNonQuery()
                    End With
                End If
            Catch ex As Exception
            End Try
            con.Close()
            MessageBox.Show("Levantou " & nota5 & " notas de 5€ " & nota10 & " notas de 10€ " & nota20 & " notas de 20€ e " & nota50 & " notas de 50€.")
            nota5 = 0
            nota10 = 0
            nota20 = 0
            nota50 = 0
            lbsaldo.Text = "Saldo: " & dinheiro & " €"
            txtLevantar.Clear()
            Exit Sub
        Else
            MessageBox.Show("Não é possível levantar 0€ escolha uma quantia antes de clicar em ""levantar"".")
            Exit Sub
        End If
    End Sub


End Class