Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormHistTransferenciasRecebidas
    Dim con As New MySqlConnection("server=eu-cdbr-west-03.cleardb.net;user=b871201390eafb;password=256c88f0;database=heroku_4710e77cd0c7a29")
    Dim cmd, cmdnome, cmdsaldo As New MySqlCommand
    Dim sda, sdanome, sdasaldo As New MySqlDataAdapter
    Dim dt, dtnome, dtsaldo As New DataTable
    Dim Table As String = "vbnet_mysql_transf_table"
    Dim Data As Integer
    Dim i As Integer
    Dim j, h As Integer
    Dim pag As Integer = 1

    Private Sub FormHistTransferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select ID_Remetente, ID_Destinatario, Valor_Enviado, Dia_Envio, Hora_Envio from " & Table & " where ID_Destinatario LIKE '" & FormUtilizador.IDutilizador & "'" & "ORDER BY Dia_Envio DESC, Hora_Envio DESC"
            sda = New MySqlDataAdapter(cmd.CommandText, con)
            dt = New DataTable
            Data = sda.Fill(dt)
            h = Data - 1
            If Data = 0 Then
                Transf1.Visible = False
                Transf2.Visible = False
                Transf3.Visible = False
                Timer1.Start()
                Exit Sub
            End If
            If Data = 1 Then
                Transf2.Visible = False
                Transf3.Visible = False
            ElseIf Data = 2 Then
                Transf3.Visible = False
            ElseIf (Data - 1) > 3 Then
                If (Data - 1) / 3 <> (Data - 1) \ 3 Then
                    i = (Data - 1) \ 3 + 1
                Else
                    i = (Data - 1) / 3
                End If
            End If
        Catch ex As Exception
            Timer1.Start()
        End Try
        sda.Fill(dt)
        cmdsaldo.CommandType = CommandType.Text
        cmdsaldo.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE '" & FormUtilizador.IDutilizador & "'"
        sdasaldo = New MySqlDataAdapter(cmdsaldo.CommandText, con)
        dtsaldo = New DataTable
        sdasaldo.Fill(dtsaldo)
        lblSaldo.Text = "Saldo da Conta: " & dtsaldo.Rows(0)(2) & " €"
        grupo1auto()
        If Transf2.Visible = True Then
            grupo2auto()
        End If
        If Transf3.Visible = True Then
            grupo3auto()
        End If
        If i > 0 Then
            LabelPag.Text = "1 / " & i
            btnseguinte.Enabled = True
        Else
            LabelPag.Text = "1 / 1"
        End If
        Exit Sub
    End Sub

    Private Sub btnseguinte_Click(sender As Object, e As EventArgs) Handles btnseguinte.Click
        h = h - 3
        pag += 1
        LabelPag.Text = pag & " / " & i
        If btnanterior.Enabled = False Then
            btnanterior.Enabled = True
        End If
        If pag = i Then
            btnseguinte.Enabled = False
        End If
        j += 3
        If h >= 1 Then
            grupo1()
        Else
            Transf1.Visible = False
            Transf2.Visible = False
            Transf3.Visible = False
            Exit Sub
        End If
        If h >= 2 Then
            grupo2()
        Else
            Transf2.Visible = False
            Transf3.Visible = False
            Exit Sub
        End If
        If h >= 2 Then
            grupo3()
        Else
            Transf3.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If Data = 0 Then
            MessageBox.Show("Não foi encontrada qualquer transferência enviada.")
            Me.Close()
        Else
            MessageBox.Show("Erro de conexão com a base de dados", "Mensagem de erro")
            Me.Close()
        End If

    End Sub

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click
        Transf2.Visible = True
        Transf3.Visible = True
        pag -= 1
        h += 3
        LabelPag.Text = pag & " / " & i
        If btnseguinte.Enabled = False Then
            btnseguinte.Enabled = True
        End If
        If pag = 1 Then
            btnanterior.Enabled = False
        End If
        j -= 3
        grupo1()
        grupo2()
        grupo3()
    End Sub
    Private Sub grupo1auto()
        cmdnome.CommandType = CommandType.Text
        cmdnome.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE '" & dt.Rows(0)(0) & "'"
        sdanome = New MySqlDataAdapter(cmdnome.CommandText, con)
        dtnome = New DataTable


        sdanome.Fill(dtnome)
        Label1NomeDestinatario.Text = dtnome.Rows(0)(0)
        Label1Valorenviado.Text = dt.Rows(0)(2) & "€"
        Label1DiaEnvio.Text = dt.Rows(0)(3)
        Label1HoradoEnvio.Text = dt.Rows(0)(4)
    End Sub
    Private Sub grupo2auto()
        cmdnome.CommandType = CommandType.Text
        cmdnome.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE '" & dt.Rows(1)(0) & "'"
        sdanome = New MySqlDataAdapter(cmdnome.CommandText, con)
        dtnome = New DataTable
        sdanome.Fill(dtnome)
        cmdnome.CommandType = CommandType.Text
        cmdnome.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE '" & dt.Rows(1)(0) & "'"
        sdanome = New MySqlDataAdapter(cmdnome.CommandText, con)
        dtnome = New DataTable


        sdanome.Fill(dtnome)
        Label2NomeDestinatario.Text = dtnome.Rows(0)(0)
        Label2Valorenviado.Text = dt.Rows(1)(2) & "€"
        Label2DiaEnvio.Text = dt.Rows(1)(3)
        Label2HoradoEnvio.Text = dt.Rows(1)(4)
    End Sub
    Private Sub grupo3auto()
        cmdnome.CommandType = CommandType.Text
        cmdnome.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE '" & dt.Rows(2)(0) & "'"
        sdanome = New MySqlDataAdapter(cmdnome.CommandText, con)
        dtnome = New DataTable


        sdanome.Fill(dtnome)
        Label3NomeDestinatario.Text = dtnome.Rows(0)(0)
        Label3Valorenviado.Text = dt.Rows(2)(2) & "€"
        Label3DiaEnvio.Text = dt.Rows(j + 1)(3)
        Label3HoradoEnvio.Text = dt.Rows(2)(4)
    End Sub
    Private Sub grupo1()
        cmdnome.CommandType = CommandType.Text
        cmdnome.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE '" & dt.Rows(j)(0) & "'"
        sdanome = New MySqlDataAdapter(cmdnome.CommandText, con)
        dtnome = New DataTable


        sdanome.Fill(dtnome)
        Label1NomeDestinatario.Text = dtnome.Rows(0)(0)
        Label1Valorenviado.Text = dt.Rows(j)(2) & "€"
        Label1DiaEnvio.Text = dt.Rows(j)(3)
        Label1HoradoEnvio.Text = dt.Rows(j)(4)
    End Sub
    Private Sub grupo2()
        cmdnome.CommandType = CommandType.Text
        cmdnome.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE '" & dt.Rows(j + 1)(0) & "'"
        sdanome = New MySqlDataAdapter(cmdnome.CommandText, con)
        dtnome = New DataTable


        sdanome.Fill(dtnome)
        Label2NomeDestinatario.Text = dtnome.Rows(0)(0)
        Label2Valorenviado.Text = dt.Rows(j + 1)(2) & "€"
        Label2DiaEnvio.Text = dt.Rows(j + 1)(3)
        Label2HoradoEnvio.Text = dt.Rows(j + 1)(4)
    End Sub
    Private Sub grupo3()
        cmdnome.CommandType = CommandType.Text
        cmdnome.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where ID LIKE '" & dt.Rows(j + 2)(0) & "'"
        sdanome = New MySqlDataAdapter(cmdnome.CommandText, con)
        dtnome = New DataTable


        sdanome.Fill(dtnome)
        Label3NomeDestinatario.Text = dtnome.Rows(0)(0)
        Label3Valorenviado.Text = dt.Rows(j + 2)(2) & "€"
        Label3DiaEnvio.Text = dt.Rows(j + 2)(3)
        Label3HoradoEnvio.Text = dt.Rows(j + 2)(4)
    End Sub
End Class