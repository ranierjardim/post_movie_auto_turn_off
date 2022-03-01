<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WndTests
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
        Me.BtnAgendarDesligamento = New System.Windows.Forms.Button()
        Me.BtnCancelarAgendamento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAgendarDesligamento
        '
        Me.BtnAgendarDesligamento.Location = New System.Drawing.Point(12, 12)
        Me.BtnAgendarDesligamento.Name = "BtnAgendarDesligamento"
        Me.BtnAgendarDesligamento.Size = New System.Drawing.Size(159, 23)
        Me.BtnAgendarDesligamento.TabIndex = 0
        Me.BtnAgendarDesligamento.Text = "Agendar desligamento"
        Me.BtnAgendarDesligamento.UseVisualStyleBackColor = True
        '
        'BtnCancelarAgendamento
        '
        Me.BtnCancelarAgendamento.Location = New System.Drawing.Point(12, 51)
        Me.BtnCancelarAgendamento.Name = "BtnCancelarAgendamento"
        Me.BtnCancelarAgendamento.Size = New System.Drawing.Size(159, 23)
        Me.BtnCancelarAgendamento.TabIndex = 1
        Me.BtnCancelarAgendamento.Text = "Cancelar agendamentos"
        Me.BtnCancelarAgendamento.UseVisualStyleBackColor = True
        '
        'WndTests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCancelarAgendamento)
        Me.Controls.Add(Me.BtnAgendarDesligamento)
        Me.Name = "WndTests"
        Me.Text = "WndTests"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAgendarDesligamento As Button
    Friend WithEvents BtnCancelarAgendamento As Button
End Class
