Imports System.IO
Public Class FormAdministrador
    Dim i As Integer
    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub BtnSQL_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnSQL.MouseEnter
        If i = 0 Then
            btnSQL.Image = My.Resources.botao_hover
        End If
    End Sub

    Private Sub BtnSQL_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSQL.MouseLeave
        If i = 0 Then
            btnSQL.Image = My.Resources.botao
        End If
    End Sub
    Private Sub BtnGestNotas_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnGestNotas.MouseEnter
        If i = 0 Then
            btnGestNotas.Image = My.Resources.botao_hover
        End If
    End Sub

    Private Sub BtnGestNotas_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnGestNotas.MouseLeave
        If i = 0 Then
            btnGestNotas.Image = My.Resources.botao
        End If
    End Sub
    Private Sub btnBalancodiar_MouseEnter(sender As System.Object, e As System.EventArgs) Handles btnBalancodiar.MouseEnter
        If i = 0 Then
            btnBalancodiar.Image = My.Resources.botao_hover
        End If
    End Sub

    Private Sub btnBalancodiar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnBalancodiar.MouseLeave
        If i = 0 Then
            btnBalancodiar.Image = My.Resources.botao
        End If
    End Sub
    Private Sub btnSair_MouseEnter(sender As Object, e As EventArgs) Handles btnSair.MouseEnter
        btnSair.Image = My.Resources.botao_hover
    End Sub
    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles btnSair.MouseLeave
        btnSair.Image = My.Resources.botao
    End Sub
    Private Sub btnSQL_Click(sender As Object, e As EventArgs) Handles btnSQL.Click
        btnGestNotas.Image = My.Resources.botao_gif
        btnBalancodiar.Image = My.Resources.botao_gif2
        btnSQL.Image = My.Resources.botao_zoom
        FormGestaoSQL.Show()
        btnGestNotas.Text = ""
        btnBalancodiar.Text = ""
        Timer1.Start()
        i = 2
        Exit Sub
    End Sub

    Private Sub btnGestNotas_Click(sender As Object, e As EventArgs) Handles btnGestNotas.Click
        btnSQL.Image = My.Resources.botao_gif2
        btnBalancodiar.Image = My.Resources.botao_gif2
        btnGestNotas.Image = My.Resources.botao_zoom
        FormGestaoNotas.Show()
        btnSQL.Text = ""
        btnBalancodiar.Text = ""
        Timer1.Start()
        i = 1
        Exit Sub
    End Sub

    Private Sub btnBalancodiar_Click(sender As Object, e As EventArgs) Handles btnBalancodiar.Click
        btnSQL.Image = My.Resources.botao_gif2
        btnBalancodiar.Image = My.Resources.botao_zoom
        btnGestNotas.Image = My.Resources.botao_gif
        FormBalancoDiario.Show()
        btnSQL.Text = ""
        btnGestNotas.Text = ""
        Timer1.Start()
        i = 3
        Exit Sub
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i = 1 Then
            FormGestaoNotas.TopMost = True
            btnSQL.Image = My.Resources.botao
            btnGestNotas.Image = My.Resources.botao
            btnBalancodiar.Image = My.Resources.botao
            btnBalancodiar.Text = "Balanço Diário"
            btnSQL.Text = "Base de Dados"
            i = 0
            Timer1.Stop()
            Exit Sub
        ElseIf i = 2 Then
            FormGestaoSQL.TopMost = True
            btnGestNotas.Image = My.Resources.botao
            btnSQL.Image = My.Resources.botao
            btnBalancodiar.Image = My.Resources.botao
            btnBalancodiar.Text = "Balanço Diário"
            btnGestNotas.Text = "Gestão Notas"
            i = 0
            Timer1.Stop()
            Exit Sub
        ElseIf i = 3 Then
            FormBalancoDiario.TopMost = True
            btnGestNotas.Image = My.Resources.botao
            btnSQL.Image = My.Resources.botao
            btnBalancodiar.Image = My.Resources.botao
            btnSQL.Text = "Base de Dados"
            btnGestNotas.Text = "Gestão Notas"
            i = 0
            Timer1.Stop()
        End If
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class