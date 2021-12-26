<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdministrador
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
        Me.btnGestNotas = New System.Windows.Forms.Button()
        Me.btnSQL = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnBalancodiar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGestNotas
        '
        Me.btnGestNotas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnGestNotas.BackColor = System.Drawing.Color.Transparent
        Me.btnGestNotas.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnGestNotas.FlatAppearance.BorderSize = 0
        Me.btnGestNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGestNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGestNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestNotas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestNotas.ForeColor = System.Drawing.Color.Black
        Me.btnGestNotas.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.btnGestNotas.Location = New System.Drawing.Point(-7, 86)
        Me.btnGestNotas.Name = "btnGestNotas"
        Me.btnGestNotas.Size = New System.Drawing.Size(190, 64)
        Me.btnGestNotas.TabIndex = 11
        Me.btnGestNotas.Text = "Gestão Notas"
        Me.btnGestNotas.UseVisualStyleBackColor = False
        '
        'btnSQL
        '
        Me.btnSQL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSQL.BackColor = System.Drawing.Color.Transparent
        Me.btnSQL.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnSQL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSQL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSQL.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSQL.ForeColor = System.Drawing.Color.Black
        Me.btnSQL.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.btnSQL.Location = New System.Drawing.Point(612, 86)
        Me.btnSQL.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSQL.Name = "btnSQL"
        Me.btnSQL.Size = New System.Drawing.Size(190, 64)
        Me.btnSQL.TabIndex = 2
        Me.btnSQL.Text = "Base De Dados"
        Me.btnSQL.UseVisualStyleBackColor = False
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
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 4500
        '
        'btnSair
        '
        Me.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.btnSair.Location = New System.Drawing.Point(316, 538)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(191, 61)
        Me.btnSair.TabIndex = 12
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnBalancodiar
        '
        Me.btnBalancodiar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBalancodiar.BackColor = System.Drawing.Color.Transparent
        Me.btnBalancodiar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnBalancodiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBalancodiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBalancodiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalancodiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalancodiar.ForeColor = System.Drawing.Color.Black
        Me.btnBalancodiar.Image = Global.MultiBanco.My.Resources.Resources.botao
        Me.btnBalancodiar.Location = New System.Drawing.Point(612, 421)
        Me.btnBalancodiar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBalancodiar.Name = "btnBalancodiar"
        Me.btnBalancodiar.Size = New System.Drawing.Size(190, 64)
        Me.btnBalancodiar.TabIndex = 13
        Me.btnBalancodiar.Text = "Balanço Diário"
        Me.btnBalancodiar.UseVisualStyleBackColor = False
        '
        'FormAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(798, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBalancodiar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnGestNotas)
        Me.Controls.Add(Me.btnSQL)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAdministrador"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSQL As Button
    Friend WithEvents btnGestNotas As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSair As Button
    Friend WithEvents btnBalancodiar As Button
End Class
