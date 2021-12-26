<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBalancoDiario
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
        Me.lbquant = New System.Windows.Forms.Label()
        Me.lbnotas = New System.Windows.Forms.Label()
        Me.lb5 = New System.Windows.Forms.Label()
        Me.lb10 = New System.Windows.Forms.Label()
        Me.lb20 = New System.Windows.Forms.Label()
        Me.lb50 = New System.Windows.Forms.Label()
        Me.lbdata = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbquantef = New System.Windows.Forms.Label()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbquant
        '
        Me.lbquant.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbquant.AutoSize = True
        Me.lbquant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbquant.Location = New System.Drawing.Point(252, 34)
        Me.lbquant.Name = "lbquant"
        Me.lbquant.Size = New System.Drawing.Size(223, 16)
        Me.lbquant.TabIndex = 4
        Me.lbquant.Text = "Quantidade Levantamentos (€):"
        '
        'lbnotas
        '
        Me.lbnotas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbnotas.AutoSize = True
        Me.lbnotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnotas.Location = New System.Drawing.Point(291, 86)
        Me.lbnotas.Name = "lbnotas"
        Me.lbnotas.Size = New System.Drawing.Size(139, 16)
        Me.lbnotas.TabIndex = 5
        Me.lbnotas.Text = "Notas Disponíveis:"
        '
        'lb5
        '
        Me.lb5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lb5.AutoSize = True
        Me.lb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb5.ForeColor = System.Drawing.Color.Aqua
        Me.lb5.Location = New System.Drawing.Point(184, 128)
        Me.lb5.Name = "lb5"
        Me.lb5.Size = New System.Drawing.Size(55, 29)
        Me.lb5.TabIndex = 6
        Me.lb5.Text = "5€ :"
        '
        'lb10
        '
        Me.lb10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lb10.AutoSize = True
        Me.lb10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb10.ForeColor = System.Drawing.Color.Aqua
        Me.lb10.Location = New System.Drawing.Point(278, 128)
        Me.lb10.Name = "lb10"
        Me.lb10.Size = New System.Drawing.Size(69, 29)
        Me.lb10.TabIndex = 7
        Me.lb10.Text = "10€ :"
        '
        'lb20
        '
        Me.lb20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lb20.AutoSize = True
        Me.lb20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb20.ForeColor = System.Drawing.Color.Aqua
        Me.lb20.Location = New System.Drawing.Point(388, 128)
        Me.lb20.Name = "lb20"
        Me.lb20.Size = New System.Drawing.Size(69, 29)
        Me.lb20.TabIndex = 8
        Me.lb20.Text = "20€ :"
        '
        'lb50
        '
        Me.lb50.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lb50.AutoSize = True
        Me.lb50.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb50.ForeColor = System.Drawing.Color.Aqua
        Me.lb50.Location = New System.Drawing.Point(495, 128)
        Me.lb50.Name = "lb50"
        Me.lb50.Size = New System.Drawing.Size(69, 29)
        Me.lb50.TabIndex = 9
        Me.lb50.Text = "50€ :"
        '
        'lbdata
        '
        Me.lbdata.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbdata.AutoSize = True
        Me.lbdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdata.Location = New System.Drawing.Point(248, 368)
        Me.lbdata.Name = "lbdata"
        Me.lbdata.Size = New System.Drawing.Size(0, 42)
        Me.lbdata.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 4500
        '
        'lbquantef
        '
        Me.lbquantef.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbquantef.AutoSize = True
        Me.lbquantef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbquantef.Location = New System.Drawing.Point(217, 59)
        Me.lbquantef.Name = "lbquantef"
        Me.lbquantef.Size = New System.Drawing.Size(292, 16)
        Me.lbquantef.TabIndex = 11
        Me.lbquantef.Text = "Quantidade de levantamentos efetuados:"
        '
        'btnsair
        '
        Me.btnsair.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnsair.Location = New System.Drawing.Point(337, 508)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(93, 41)
        Me.btnsair.TabIndex = 12
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'FormBalancoDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.lbquantef)
        Me.Controls.Add(Me.lbdata)
        Me.Controls.Add(Me.lb50)
        Me.Controls.Add(Me.lb20)
        Me.Controls.Add(Me.lb10)
        Me.Controls.Add(Me.lb5)
        Me.Controls.Add(Me.lbnotas)
        Me.Controls.Add(Me.lbquant)
        Me.Name = "FormBalancoDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbquant As Label
    Friend WithEvents lbnotas As Label
    Friend WithEvents lb5 As Label
    Friend WithEvents lb10 As Label
    Friend WithEvents lb20 As Label
    Friend WithEvents lb50 As Label
    Friend WithEvents lbdata As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbquantef As Label
    Friend WithEvents btnsair As Button
End Class
