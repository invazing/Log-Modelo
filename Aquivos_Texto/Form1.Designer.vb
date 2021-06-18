<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Texto = New System.Windows.Forms.TextBox()
        Me.Gravar = New System.Windows.Forms.Button()
        Me.Ler = New System.Windows.Forms.Button()
        Me.Proximo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(12, 41)
        Me.Texto.Multiline = True
        Me.Texto.Name = "Texto"
        Me.Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Texto.Size = New System.Drawing.Size(349, 208)
        Me.Texto.TabIndex = 0
        '
        'Gravar
        '
        Me.Gravar.Location = New System.Drawing.Point(12, 12)
        Me.Gravar.Name = "Gravar"
        Me.Gravar.Size = New System.Drawing.Size(75, 23)
        Me.Gravar.TabIndex = 1
        Me.Gravar.Text = "Gravar"
        Me.Gravar.UseVisualStyleBackColor = True
        '
        'Ler
        '
        Me.Ler.Location = New System.Drawing.Point(93, 12)
        Me.Ler.Name = "Ler"
        Me.Ler.Size = New System.Drawing.Size(75, 23)
        Me.Ler.TabIndex = 2
        Me.Ler.Text = "Ler"
        Me.Ler.UseVisualStyleBackColor = True
        '
        'Proximo
        '
        Me.Proximo.Location = New System.Drawing.Point(286, 12)
        Me.Proximo.Name = "Proximo"
        Me.Proximo.Size = New System.Drawing.Size(75, 23)
        Me.Proximo.TabIndex = 3
        Me.Proximo.Text = "Nova linha"
        Me.Proximo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 261)
        Me.Controls.Add(Me.Proximo)
        Me.Controls.Add(Me.Ler)
        Me.Controls.Add(Me.Gravar)
        Me.Controls.Add(Me.Texto)
        Me.Name = "Form1"
        Me.Text = "Gravando arquivos de Texto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Texto As System.Windows.Forms.TextBox
    Friend WithEvents Gravar As System.Windows.Forms.Button
    Friend WithEvents Ler As System.Windows.Forms.Button
    Friend WithEvents Proximo As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
