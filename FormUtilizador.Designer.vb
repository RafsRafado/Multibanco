<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtilizador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblBemVindo = New System.Windows.Forms.Label()
        Me.btnHistTransfRec = New System.Windows.Forms.Button()
        Me.btnLevantar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHistTransfEnv = New System.Windows.Forms.Button()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBemVindo
        '
        Me.lblBemVindo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBemVindo.AutoSize = True
        Me.lblBemVindo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBemVindo.Location = New System.Drawing.Point(253, -3)
        Me.lblBemVindo.Name = "lblBemVindo"
        Me.lblBemVindo.Size = New System.Drawing.Size(222, 16)
        Me.lblBemVindo.TabIndex = 2
        Me.lblBemVindo.Text = "Bem vindo à caixa Multibanco, "
        '
        'btnHistTransfRec
        '
        Me.btnHistTransfRec.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnHistTransfRec.BackColor = System.Drawing.Color.Transparent
        Me.btnHistTransfRec.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnHistTransfRec.FlatAppearance.BorderSize = 0
        Me.btnHistTransfRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHistTransfRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHistTransfRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistTransfRec.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistTransfRec.ForeColor = System.Drawing.Color.Black
        Me.btnHistTransfRec.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.btnHistTransfRec.Location = New System.Drawing.Point(612, 86)
        Me.btnHistTransfRec.Name = "btnHistTransfRec"
        Me.btnHistTransfRec.Size = New System.Drawing.Size(190, 64)
        Me.btnHistTransfRec.TabIndex = 3
        Me.btnHistTransfRec.Text = "Histórico Transferencias Recebidas"
        Me.btnHistTransfRec.UseVisualStyleBackColor = False
        '
        'btnLevantar
        '
        Me.btnLevantar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnLevantar.BackColor = System.Drawing.Color.Transparent
        Me.btnLevantar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnLevantar.FlatAppearance.BorderSize = 0
        Me.btnLevantar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLevantar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLevantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLevantar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevantar.ForeColor = System.Drawing.Color.Black
        Me.btnLevantar.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.btnLevantar.Location = New System.Drawing.Point(-5, 421)
        Me.btnLevantar.Name = "btnLevantar"
        Me.btnLevantar.Size = New System.Drawing.Size(190, 64)
        Me.btnLevantar.TabIndex = 1
        Me.btnLevantar.Text = "Levantar Dinheiro"
        Me.btnLevantar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.MultiBanco.My.Resources.Resources.Adobe_Pho
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(49, -156)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(690, 865)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnHistTransfEnv
        '
        Me.btnHistTransfEnv.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnHistTransfEnv.BackColor = System.Drawing.Color.Transparent
        Me.btnHistTransfEnv.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnHistTransfEnv.FlatAppearance.BorderSize = 0
        Me.btnHistTransfEnv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHistTransfEnv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHistTransfEnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistTransfEnv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistTransfEnv.ForeColor = System.Drawing.Color.Black
        Me.btnHistTransfEnv.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.btnHistTransfEnv.Location = New System.Drawing.Point(612, 421)
        Me.btnHistTransfEnv.Name = "btnHistTransfEnv"
        Me.btnHistTransfEnv.Size = New System.Drawing.Size(190, 64)
        Me.btnHistTransfEnv.TabIndex = 5
        Me.btnHistTransfEnv.Text = "Histórico Transferencias Enviadas"
        Me.btnHistTransfEnv.UseVisualStyleBackColor = False
        '
        'btnTransferir
        '
        Me.btnTransferir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnTransferir.BackColor = System.Drawing.Color.Transparent
        Me.btnTransferir.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnTransferir.FlatAppearance.BorderSize = 0
        Me.btnTransferir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTransferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransferir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferir.ForeColor = System.Drawing.Color.Black
        Me.btnTransferir.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.btnTransferir.Location = New System.Drawing.Point(-5, 86)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(190, 64)
        Me.btnTransferir.TabIndex = 6
        Me.btnTransferir.Text = "Transferir Dinheiro"
        Me.btnTransferir.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnSair.BackColor = System.Drawing.Color.Transparent
        Me.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnSair.FlatAppearance.BorderSize = 0
        Me.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.Black
        Me.BtnSair.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.BtnSair.Location = New System.Drawing.Point(285, 534)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(190, 64)
        Me.BtnSair.TabIndex = 7
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 4500
        '
        'FormUtilizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(798, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.btnTransferir)
        Me.Controls.Add(Me.btnHistTransfEnv)
        Me.Controls.Add(Me.btnHistTransfRec)
        Me.Controls.Add(Me.lblBemVindo)
        Me.Controls.Add(Me.btnLevantar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormUtilizador"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLevantar As Button
    Friend WithEvents lblBemVindo As Label
    Friend WithEvents btnHistTransfRec As Button
    Friend WithEvents btnHistTransfEnv As Button
    Friend WithEvents btnTransferir As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents Timer1 As Timer
End Class
