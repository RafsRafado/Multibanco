<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLevantar
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
        Me.components = New System.ComponentModel.Container()
        Me.lbsaldo = New System.Windows.Forms.Label()
        Me.txtLevantar = New System.Windows.Forms.TextBox()
        Me.btnLevantar = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.lbvalor = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbsaldo
        '
        Me.lbsaldo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbsaldo.AutoSize = True
        Me.lbsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsaldo.Location = New System.Drawing.Point(375, 25)
        Me.lbsaldo.Name = "lbsaldo"
        Me.lbsaldo.Size = New System.Drawing.Size(57, 16)
        Me.lbsaldo.TabIndex = 3
        Me.lbsaldo.Text = "Saldo: "
        '
        'txtLevantar
        '
        Me.txtLevantar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLevantar.Enabled = False
        Me.txtLevantar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevantar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLevantar.Location = New System.Drawing.Point(344, 140)
        Me.txtLevantar.Name = "txtLevantar"
        Me.txtLevantar.Size = New System.Drawing.Size(185, 26)
        Me.txtLevantar.TabIndex = 44
        '
        'btnLevantar
        '
        Me.btnLevantar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLevantar.Location = New System.Drawing.Point(390, 588)
        Me.btnLevantar.Name = "btnLevantar"
        Me.btnLevantar.Size = New System.Drawing.Size(82, 29)
        Me.btnLevantar.TabIndex = 45
        Me.btnLevantar.Text = "Levantar"
        Me.btnLevantar.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.ForeColor = System.Drawing.Color.Blue
        Me.btn5.Image = Global.MultiBanco.My.Resources.Resources._5
        Me.btn5.Location = New System.Drawing.Point(12, 113)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(165, 100)
        Me.btn5.TabIndex = 50
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn10.ForeColor = System.Drawing.Color.Blue
        Me.btn10.Image = Global.MultiBanco.My.Resources.Resources._10
        Me.btn10.Location = New System.Drawing.Point(12, 338)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(165, 100)
        Me.btn10.TabIndex = 51
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn20.ForeColor = System.Drawing.Color.Blue
        Me.btn20.Image = Global.MultiBanco.My.Resources.Resources._20
        Me.btn20.Location = New System.Drawing.Point(705, 104)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(165, 100)
        Me.btn20.TabIndex = 52
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn50.ForeColor = System.Drawing.Color.Blue
        Me.btn50.Image = Global.MultiBanco.My.Resources.Resources._502
        Me.btn50.Location = New System.Drawing.Point(705, 338)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(165, 100)
        Me.btn50.TabIndex = 53
        Me.btn50.UseVisualStyleBackColor = True
        '
        'lbvalor
        '
        Me.lbvalor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbvalor.AutoSize = True
        Me.lbvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbvalor.Location = New System.Drawing.Point(353, 121)
        Me.lbvalor.Name = "lbvalor"
        Me.lbvalor.Size = New System.Drawing.Size(161, 16)
        Me.lbvalor.TabIndex = 54
        Me.lbvalor.Text = "Valor a ser levantado:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 4500
        '
        'btnlimpar
        '
        Me.btnlimpar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlimpar.Location = New System.Drawing.Point(390, 184)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(82, 29)
        Me.btnlimpar.TabIndex = 55
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSair.Location = New System.Drawing.Point(764, 563)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(106, 54)
        Me.btnSair.TabIndex = 56
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'FormLevantar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(882, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.lbvalor)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btnLevantar)
        Me.Controls.Add(Me.txtLevantar)
        Me.Controls.Add(Me.lbsaldo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLevantar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbsaldo As Label
    Friend WithEvents txtLevantar As TextBox
    Friend WithEvents btnLevantar As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btn20 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents lbvalor As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnlimpar As Button
    Friend WithEvents btnSair As Button
End Class
