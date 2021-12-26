Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormGestaoSQL
    Dim con As New MySqlConnection("server=eu-cdbr-west-03.cleardb.net;user=b871201390eafb;password=256c88f0;database=heroku_4710e77cd0c7a29")
    Dim cmd As New MySqlCommand
    Dim sda As New MySqlDataAdapter
    Dim DT As New DataTable

    Dim Table As String = "vbnet_mysql_mb_table"
    Dim Data As Integer

    Dim IDRam, NomeRam, PinRam, DinheiroRam, EditarPIN As String
    Dim StatusInput As String = "Guardar"
    Dim SqlCmdSearchstr As String
    Dim Col0Ram As Integer = 0

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim mstream As New System.IO.MemoryStream()

        If txtnome.Text = "" Then
            MessageBox.Show("Porfavor, Introduza o Nome do cliente", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf (txtnome.Text = "admin" Or txtnome.Text = "Admin") And StatusInput = "Guardar" Then
            MessageBox.Show("Não pode adicionar um utilizador com o nome Admin.")
            Exit Sub
        End If
        If txtpin.Text = "" Then
            MessageBox.Show("Porfavor, introduza o Pin do cliente", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtdinheiro.Text = "" Then
            MessageBox.Show("Porfavor, introduza o dinheiro do cliente  ", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf StatusInput = "Atualizar" And (txtnome.Text = "admin" Or txtnome.Text = "Admin") And txtdinheiro.Text > 0 Then
            MessageBox.Show("Não pode editar o dinheiro da conta do administrador")
            Exit Sub
        End If
        If txtID.Text = "" Then
            MessageBox.Show("Porfavor, gere o ID do cliente  ", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        For Each row As DataGridViewRow In DataGridView1.Rows
            If StatusInput = "Guardar" Then
                If row.Cells(3).Value.ToString = txtID.Text Then
                    MessageBox.Show("O id " & txtID.Text & " é um id repetido, para que funcione gere um id novo, obrigado.")
                    Exit Sub
                End If
            End If
        Next
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão  " & vbCrLf & "Porfavor, verifique o servidor  ", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        If StatusInput = "Guardar" Then
            Try
                cmd = New MySqlCommand
                With cmd
                    .CommandText = "INSERT INTO " & Table & " SET  ID=@id,Nome=@nome,Pin=@pin,Dinheiro=@dinheiro"
                    .Connection = con
                    .Parameters.AddWithValue("@nome", txtnome.Text)
                    .Parameters.AddWithValue("@pin", txtpin.Text)
                    .Parameters.AddWithValue("@dinheiro", txtdinheiro.Text)
                    .Parameters.AddWithValue("@id", txtID.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Dados guardados Corretamente", MsgBoxStyle.Information, "Informação")
                LimparTXT()
            Catch ex As Exception
                MessageBox.Show("Erro na gravação de dados  " & vbCr & ex.Message, "Mensagem de Erro")
                con.Close()
                Return
            End Try
            con.Close()

        Else

            Try
                cmd = New MySqlCommand
                With cmd
                    .CommandText = "UPDATE " & Table & " SET  ID=@id,Nome=@nome,Pin=@pin,Dinheiro=@dinheiro  WHERE ID=@id"
                    .Connection = con
                    .Parameters.AddWithValue("@nome", txtnome.Text)
                    .Parameters.AddWithValue("@pin", txtpin.Text)
                    .Parameters.AddWithValue("@dinheiro", txtdinheiro.Text)
                    .Parameters.AddWithValue("@id", txtID.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Dados atualizada com sucesso!", MsgBoxStyle.Information, "Informação")
                btnGuardar.Text = "Guardar"
                If StatusInput = "Atualizar" Then
                    txtID.Enabled = True
                    btnGerarID.Enabled = True
                End If
                LimparTXT()
            Catch ex As Exception
                MsgBox("Erro de atualização de dados  " & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensagem de erro")
                con.Close()
                Return
            End Try
            con.Close()
        End If
        StatusInput = "Guardar"
        ShowData()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DataGridView1.RowCount = 1 Then
            txtnome.Text = NomeRam
            txtpin.Text = PinRam
            txtdinheiro.Text = DinheiroRam
            txtID.Text = IDRam
            btnGuardar.Text = "Atualizar"
            StatusInput = "Atualizar"
            txtID.Enabled = False
            btnGerarID.Enabled = False
            Exit Sub
        End If

        If AllCellsSelected(DataGridView1) = False Then
            txtnome.Text = NomeRam
            txtpin.Text = PinRam
            txtdinheiro.Text = DinheiroRam
            txtID.Text = IDRam
            btnGuardar.Text = "Atualizar"
            StatusInput = "Atualizar"
            txtID.Enabled = False
            btnGerarID.Enabled = False
            Exit Sub
        Else
            MsgBox("Erro ao tentar editar   " & vbCr & "Please choose one to edit.", MsgBoxStyle.Critical, "Mensagem de erro")
        End If
    End Sub

    Private Sub FormGestaoSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Private Sub ShowData()
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão  " & vbCrLf & "Porfavor, verifique o servidor  ", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Nome, Pin, Dinheiro,Id FROM " & Table & " ORDER BY Nome"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        DT = New DataTable
        Data = sda.Fill(DT)
        If Data > 0 Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = DT
            DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black
            DataGridView1.ClearSelection()
        End If

        DT = Nothing
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAtual.Click
        ShowData()
    End Sub

    Private Sub Btnapagar_Click(sender As Object, e As EventArgs) Handles btnapagar.Click
        Dim i As Boolean = False
        If IDRam = 0 Then
            MessageBox.Show("Não é possível apagar o login do administrador.")
            Exit Sub
        End If
        If DataGridView1.RowCount = 0 Then
            MsgBox("Impossível apagar pois, não existe elementos na base de dados.", MsgBoxStyle.Critical, "Mensagem de Erro")
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Imossível apagar pois, não selecionou nenhuma coluna na tabela.", MsgBoxStyle.Critical, "Mensagem de Erro")
            Return
        End If

        If MsgBox("Deseja apagar?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Cancel Then Return

        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão  " & vbCrLf & "Porfavor, verifique o servidor  ", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        If DataGridView1.RowCount = 1 And DataGridView1.SelectedRows.Count = 1 Then
            i = True
        End If
        Try
            If AllCellsSelected(DataGridView1) = True Then
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM " & Table
                cmd.Connection = con
                cmd.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "DELETE FROM " & Table & " WHERE ID='" & IDRam & "'"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                End If
            Next
            If i = True Then
                DataGridView1.DataSource = Nothing
                DataGridView1.Rows.Clear()
                i = False
            End If
        Catch ex As Exception
            MsgBox("Erro ao apagar" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensagem de erro")
            con.Close()
        End Try
        con.Close()
        ShowData()
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Try
            If AllCellsSelected(DataGridView1) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView1
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            IDRam = .Rows(i).Cells("ID").Value.ToString
                            NomeRam = .Rows(i).Cells("Nome").Value.ToString
                            PinRam = .Rows(i).Cells("Pin").Value.ToString
                            DinheiroRam = .Rows(i).Cells("Dinheiro").Value.ToString
                            ShowData()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtpin_TextChanged(sender As Object, e As EventArgs) Handles txtpin.TextChanged
        If txtpin.TextLength > 4 Then
            txtpin.Text = txtpin.Text.Substring(0, txtpin.Text.Length - 1)
            MessageBox.Show("Máximo de 4 dígitos para o PIN.")
        End If
    End Sub

    Private Sub txtprocurar_TextChanged(sender As Object, e As EventArgs) Handles txtprocurar.TextChanged
        If txtprocurar.Text = Nothing Then
            SqlCmdSearchstr = "SELECT Nome, Pin, Dinheiro, ID FROM " & Table & " ORDER BY Nome"
        Else
            SqlCmdSearchstr = "SELECT Nome, Pin, Dinheiro, ID FROM " & Table & " WHERE Nome LIKE'" & txtprocurar.Text & "%'"
        End If
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão  " & vbCrLf & "Porfavor, verifique se o servidor está pronto  ", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            sda = New MySqlDataAdapter(SqlCmdSearchstr, con)
            DT = New DataTable
            Data = sda.Fill(DT)
            If Data > 0 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = DT
                DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.ClearSelection()
            Else
                DataGridView1.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("Erro na pesquisa" & vbCr & ex.Message, MsgBoxStyle.Critical, "Mensagem de Erro")
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub BtnGerarID_Click(sender As Object, e As EventArgs) Handles btnGerarID.Click
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão  " & vbCrLf & "Porfavor, verifique o servidor  ", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            Dim r As Random = New Random
            Dim num As Integer
            num = (r.Next(1, 9999))
            Dim IDMaker As String = Strings.Right("0000" & num.ToString(), 4)
            txtID.Text = "1" & IDMaker

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT ID FROM " & Table & " WHERE ID LIKE " & txtID.Text
            sda = New MySqlDataAdapter(cmd.CommandText, con)
            DT = New DataTable
            Data = sda.Fill(DT)
            If Data > 0 Then
                BtnGerarID_Click(sender, e)
            End If
        Catch ex As Exception
            txtID.Text = ""
            MessageBox.Show("Erro ao gerar ID  " & vbCr & ex.Message, "Mensagem de Erro")
            DT = Nothing
            con.Close()
            Return
        End Try

        DT = Nothing
        con.Close()
    End Sub

    Private Sub LimparTXT()
        txtnome.Text = ""
        txtpin.Text = ""
        txtdinheiro.Text = ""
        txtID.Text = ""
    End Sub
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function
End Class