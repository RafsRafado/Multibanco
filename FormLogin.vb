Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormLogin

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Dim con As New MySqlConnection("server=eu-cdbr-west-03.cleardb.net;user=b871201390eafb;password=256c88f0;database=heroku_4710e77cd0c7a29")
        Dim cmd As New MySqlCommand
        Dim sda As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim Data As Integer
        If txtNome.Text = "" Then
            MsgBox("Porfavor, introduza o Nome.")
            Exit Sub
        ElseIf Txtpin.Text = "" Then
            MsgBox("Porfavor, introduza o pin.")
            Exit Sub
        End If
        Try
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select Nome, Pin, Dinheiro,Id from vbnet_mysql_mb_table where Pin LIKE '" & Txtpin.Text & "' and Nome LIKE '" & txtNome.Text & "'"
            sda = New MySqlDataAdapter(cmd.CommandText, con)
            dt = New DataTable
            Data = sda.Fill(dt)
            If Data = 0 Then
                MessageBox.Show("Utilizador ou Pin incorretos.")
                Exit Sub
            End If
            If Data > 0 And (dt.Rows(0)(0) = "Admin" Or dt.Rows(0)(0) = "admin") Then
                FormAdministrador.Show()
                txtNome.Clear()
                Txtpin.Clear()
                Exit Sub
            End If
            If (Data > 0) Then
                FormUtilizador.Show()
                FormUtilizador.lblBemVindo.Text += dt.Rows(0)(0)
                FormUtilizador.IDutilizador = dt.Rows(0)(3)
                FormUtilizador.nomeutilizador = dt.Rows(0)(0)
                txtNome.Clear()
                Txtpin.Clear()
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("Erro de conexão !" & vbCrLf & "Porfavor, verifique o servidor !", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "1"
        Else
            Txtpin.Text = Txtpin.Text + "1"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "2"
        Else
            Txtpin.Text = Txtpin.Text + "2"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "3"
        Else
            Txtpin.Text = Txtpin.Text + "3"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "4"
        Else
            Txtpin.Text = Txtpin.Text + "4"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "5"
        Else
            Txtpin.Text = Txtpin.Text + "5"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "6"
        Else
            Txtpin.Text = Txtpin.Text + "6"
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "7"
        Else
            Txtpin.Text = Txtpin.Text + "7"
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "8"
        Else
            Txtpin.Text = Txtpin.Text + "8"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "9"
        Else
            Txtpin.Text = Txtpin.Text + "9"
        End If
    End Sub
    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles ButtonApagar.Click
        If Txtpin.Text = "" Then
            MessageBox.Show("Não podes apagar quando não tem nada escrito.")
        Else
            Txtpin.Text = Txtpin.Text.Substring(0, Txtpin.Text.Length - 1)
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        If Txtpin.Text = "" Then
            Txtpin.Text = "0"
        Else
            Txtpin.Text = Txtpin.Text + "0"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtpin.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpin.TextChanged
        Txtpin.UseSystemPasswordChar = False
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
