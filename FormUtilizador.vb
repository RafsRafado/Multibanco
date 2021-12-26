Public Class FormUtilizador
    Public IDutilizador As Integer
    Public nomeutilizador As String
    Dim i As Integer
    Private Sub btnSair_MouseEnter(sender As Object, e As EventArgs) Handles BtnSair.MouseEnter
        BtnSair.Image = My.Resources.botao_hover
    End Sub
    Private Sub btnSair_MouseLeave(sender As Object, e As EventArgs) Handles BtnSair.MouseLeave
        BtnSair.Image = My.Resources.botao
    End Sub
    Private Sub btnlevantar_MouseEnter(sender As Object, e As EventArgs) Handles btnLevantar.MouseEnter
        btnLevantar.Image = My.Resources.botao_hover
    End Sub
    Private Sub btnlevantar_MouseLeave(sender As Object, e As EventArgs) Handles btnLevantar.MouseLeave
        btnLevantar.Image = My.Resources.botao
    End Sub
    Private Sub btntransferir_MouseEnter(sender As Object, e As EventArgs) Handles btnTransferir.MouseEnter
        btnTransferir.Image = My.Resources.botao_hover
    End Sub
    Private Sub btnTransferir_MouseLeave(sender As Object, e As EventArgs) Handles btnTransferir.MouseLeave
        btnTransferir.Image = My.Resources.botao
    End Sub
    Private Sub btnHistTransfEnv_MouseEnter(sender As Object, e As EventArgs) Handles btnHistTransfEnv.MouseEnter
        btnHistTransfEnv.Image = My.Resources.botao_hover
    End Sub
    Private Sub btnHistTransfEnv_MouseLeave(sender As Object, e As EventArgs) Handles btnHistTransfEnv.MouseLeave
        btnHistTransfEnv.Image = My.Resources.botao
    End Sub
    Private Sub btnHistTransfRec_MouseEnter(sender As Object, e As EventArgs) Handles btnHistTransfRec.MouseEnter
        btnHistTransfRec.Image = My.Resources.botao_hover
    End Sub
    Private Sub btnHistTransfRec_MouseLeave(sender As Object, e As EventArgs) Handles btnHistTransfRec.MouseLeave
        btnHistTransfRec.Image = My.Resources.botao
    End Sub


    Private Sub btnLevantar_Click(sender As Object, e As EventArgs) Handles btnLevantar.Click
        btnTransferir.Image = My.Resources.botao_gif
        btnLevantar.Image = My.Resources.botao_zoom
        btnHistTransfEnv.Image = My.Resources.botao_gif2
        btnHistTransfRec.Image = My.Resources.botao_gif2
        FormLevantar.Show()
        btnTransferir.Text = ""
        btnHistTransfEnv.Text = ""
        btnHistTransfRec.Text = ""
        Timer1.Start()
        i = 1
        Exit Sub
    End Sub

    Private Sub btntransfrec_Click(sender As Object, e As EventArgs) Handles btnHistTransfRec.Click
        btnTransferir.Image = My.Resources.botao_gif
        btnLevantar.Image = My.Resources.botao_gif
        btnHistTransfEnv.Image = My.Resources.botao_gif2
        btnHistTransfRec.Image = My.Resources.botao_zoom
        FormHistTransferenciasRecebidas.Show()
        btnTransferir.Text = ""
        btnHistTransfEnv.Text = ""
        btnLevantar.Text = ""
        Timer1.Start()
        i = 2
        Exit Sub
    End Sub


    Private Sub Btnhisttransfenv_Click(sender As Object, e As EventArgs) Handles btnHistTransfEnv.Click
        btnTransferir.Image = My.Resources.botao_gif
        btnLevantar.Image = My.Resources.botao_gif
        btnHistTransfEnv.Image = My.Resources.botao_zoom
        btnHistTransfRec.Image = My.Resources.botao_gif2
        FormHistTransferenciasEnviadas.Show()
        btnTransferir.Text = ""
        btnHistTransfRec.Text = ""
        btnLevantar.Text = ""
        Timer1.Start()
        i = 3
        Exit Sub
    End Sub

    Private Sub btnTransferir_Click(sender As Object, e As EventArgs) Handles btnTransferir.Click
        btnTransferir.Image = My.Resources.botao_zoom
        btnLevantar.Image = My.Resources.botao_gif
        btnHistTransfEnv.Image = My.Resources.botao_gif2
        btnHistTransfRec.Image = My.Resources.botao_gif2
        FormTransferir.Show()
        btnHistTransfRec.Text = ""
        btnHistTransfEnv.Text = ""
        btnLevantar.Text = ""
        Timer1.Start()
        i = 4
        Exit Sub
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If i = 1 Then
            FormLevantar.TopMost = True
            botao()
            i = 0
            Timer1.Stop()
            Exit Sub
        ElseIf i = 2 Then
            FormHistTransferenciasRecebidas.TopMost = True
            botao()
            i = 0
            Timer1.Stop()
            Exit Sub
        ElseIf i = 3 Then
            FormHistTransferenciasEnviadas.TopMost = True
            botao()
            i = 0
            Timer1.Stop()
            Exit Sub
        ElseIf i = 4 Then
            FormTransferir.TopMost = True
            botao()
            i = 0
            Timer1.Stop()
            Exit Sub
        End If
    End Sub
    Private Sub botao()
        btnHistTransfRec.Image = My.Resources.botao
        btnHistTransfEnv.Image = My.Resources.botao
        btnLevantar.Image = My.Resources.botao
        btnTransferir.Image = My.Resources.botao
        btnHistTransfEnv.Text = "Histórico Transferencias Enviadas"
        btnHistTransfRec.Text = "Histórico Transferencias Recebidas"
        btnLevantar.Text = "Levantar Dinheiro"
        btnTransferir.Text = "Transferir Dinheiro"
    End Sub

    Private Sub FormUtilizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class