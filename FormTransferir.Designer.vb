<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransferir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTransferir = New System.Windows.Forms.Button()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Destinatário:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor a transferir:"
        '
        'txtValor
        '
        Me.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtValor.Location = New System.Drawing.Point(369, 271)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(165, 20)
        Me.txtValor.TabIndex = 6
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Location = New System.Drawing.Point(369, 202)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(165, 20)
        Me.txtID.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(515, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "€"
        '
        'btnTransferir
        '
        Me.btnTransferir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTransferir.BackColor = System.Drawing.Color.LimeGreen
        Me.btnTransferir.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnTransferir.FlatAppearance.BorderSize = 0
        Me.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransferir.Location = New System.Drawing.Point(198, 325)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(140, 49)
        Me.btnTransferir.TabIndex = 9
        Me.btnTransferir.Text = "Transferir"
        Me.btnTransferir.UseVisualStyleBackColor = False
        '
        'lblSaldo
        '
        Me.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(252, 132)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(134, 18)
        Me.lblSaldo.TabIndex = 14
        Me.lblSaldo.Text = "Saldo da Conta: "
        '
        'btnSair
        '
        Me.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSair.BackColor = System.Drawing.Color.Red
        Me.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSair.Location = New System.Drawing.Point(394, 325)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(140, 49)
        Me.btnSair.TabIndex = 15
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'FormTransferir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(784, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.btnTransferir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransferir"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTransferir As Button
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSair As Button
End Class
