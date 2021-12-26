<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestaoSQL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnGerarID = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtdinheiro = New System.Windows.Forms.TextBox()
        Me.lbSaldo = New System.Windows.Forms.Label()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtprocurar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAtual = New System.Windows.Forms.Button()
        Me.btnapagar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.btnSair)
        Me.GroupBox2.Controls.Add(Me.btnGerarID)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.txtdinheiro)
        Me.GroupBox2.Controls.Add(Me.lbSaldo)
        Me.GroupBox2.Controls.Add(Me.txtpin)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtnome)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(829, 172)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adicionar/Atualizar Cliente"
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Image = Global.MultiBanco.My.Resources.Resources.Sair
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(623, 28)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(125, 70)
        Me.btnSair.TabIndex = 10
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnGerarID
        '
        Me.btnGerarID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerarID.ForeColor = System.Drawing.Color.Black
        Me.btnGerarID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGerarID.Location = New System.Drawing.Point(375, 96)
        Me.btnGerarID.Name = "btnGerarID"
        Me.btnGerarID.Size = New System.Drawing.Size(70, 26)
        Me.btnGerarID.TabIndex = 9
        Me.btnGerarID.Text = "Gerar Id"
        Me.btnGerarID.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(90, 100)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(279, 20)
        Me.txtID.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Id"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = Global.MultiBanco.My.Resources.Resources.icon_guardar1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(476, 28)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 70)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtdinheiro
        '
        Me.txtdinheiro.Location = New System.Drawing.Point(90, 74)
        Me.txtdinheiro.Name = "txtdinheiro"
        Me.txtdinheiro.Size = New System.Drawing.Size(279, 20)
        Me.txtdinheiro.TabIndex = 5
        '
        'lbSaldo
        '
        Me.lbSaldo.AutoSize = True
        Me.lbSaldo.Location = New System.Drawing.Point(6, 77)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.Size = New System.Drawing.Size(34, 13)
        Me.lbSaldo.TabIndex = 4
        Me.lbSaldo.Text = "Saldo"
        '
        'txtpin
        '
        Me.txtpin.Location = New System.Drawing.Point(90, 51)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(279, 20)
        Me.txtpin.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Pin"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(90, 25)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(279, 20)
        Me.txtnome.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nome"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.txtprocurar)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.btnAtual)
        Me.GroupBox3.Controls.Add(Me.btnapagar)
        Me.GroupBox3.Controls.Add(Me.btnEditar)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(17, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(829, 227)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pesquisar Dados"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(381, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(441, 186)
        Me.DataGridView1.TabIndex = 17
        '
        'txtprocurar
        '
        Me.txtprocurar.Location = New System.Drawing.Point(96, 68)
        Me.txtprocurar.Name = "txtprocurar"
        Me.txtprocurar.Size = New System.Drawing.Size(279, 20)
        Me.txtprocurar.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Procurar (Nome):"
        '
        'btnAtual
        '
        Me.btnAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtual.ForeColor = System.Drawing.Color.Black
        Me.btnAtual.Image = Global.MultiBanco.My.Resources.Resources.icon_atualizar
        Me.btnAtual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtual.Location = New System.Drawing.Point(252, 151)
        Me.btnAtual.Name = "btnAtual"
        Me.btnAtual.Size = New System.Drawing.Size(125, 70)
        Me.btnAtual.TabIndex = 15
        Me.btnAtual.Text = "Atualizar"
        Me.btnAtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtual.UseVisualStyleBackColor = True
        '
        'btnapagar
        '
        Me.btnapagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapagar.ForeColor = System.Drawing.Color.Black
        Me.btnapagar.Image = Global.MultiBanco.My.Resources.Resources.Icon_apagar
        Me.btnapagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnapagar.Location = New System.Drawing.Point(129, 151)
        Me.btnapagar.Name = "btnapagar"
        Me.btnapagar.Size = New System.Drawing.Size(125, 70)
        Me.btnapagar.TabIndex = 14
        Me.btnapagar.Text = "Apagar"
        Me.btnapagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnapagar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Image = Global.MultiBanco.My.Resources.Resources.icon_editar
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(6, 151)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(125, 70)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'FormGestaoSQL
        '
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(851, 439)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormGestaoSQL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtdinheiro As TextBox
    Friend WithEvents lbSaldo As Label
    Friend WithEvents txtpin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAtual As Button
    Friend WithEvents btnapagar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtprocurar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnGerarID As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSair As Button
End Class
