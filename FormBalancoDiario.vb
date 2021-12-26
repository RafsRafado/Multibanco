Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormBalancoDiario
    Dim con As New MySqlConnection("server=eu-cdbr-west-03.cleardb.net;user=b871201390eafb;password=256c88f0;database=heroku_4710e77cd0c7a29")
    Dim cmd As New MySqlCommand
    Dim sda As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim Table As String = "vbnet_mysql_mb_baldiario"
    Dim Data As Integer
    Private Sub FormBalancoDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbdata.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão com a base de dados", "Mensagem de erro")
            Exit Sub
        End Try
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Dia, Valor, quant5,quant10,quant20,quant50,quantransf from " & Table & " where Dia LIKE'" & lbdata.Text & "'"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        dt = New DataTable
        Data = sda.Fill(dt)
        If Data <> 0 Then
            lbquant.Text = "Quantidade Levantamentos (€): " & dt.Rows(0)(1) & "€"
            lbquantef.Text = "Quantidade de levantamentos efetuados: " & dt.Rows(0)(6)
            lb5.Text = "5€ : " & dt.Rows(0)(2)
            lb10.Text = "10€ : " & dt.Rows(0)(3)
            lb20.Text = "20€ : " & dt.Rows(0)(4)
            lb50.Text = "50€ : " & dt.Rows(0)(5)
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MessageBox.Show("Não existem registos para hoje (" & lbdata.Text & ")")
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
End Class