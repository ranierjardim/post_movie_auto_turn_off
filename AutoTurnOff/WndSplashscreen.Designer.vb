<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WndSplashscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WndSplashscreen))
        Me.NtfMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CmsNtfMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblMain = New System.Windows.Forms.Label()
        Me.CmsNtfMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'NtfMain
        '
        Me.NtfMain.ContextMenuStrip = Me.CmsNtfMain
        Me.NtfMain.Icon = CType(resources.GetObject("NtfMain.Icon"), System.Drawing.Icon)
        Me.NtfMain.Text = "NtfMain"
        Me.NtfMain.Visible = True
        '
        'CmsNtfMain
        '
        Me.CmsNtfMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmOpen, Me.TsmConfig, Me.TsmClose})
        Me.CmsNtfMain.Name = "CmsNtfMain"
        Me.CmsNtfMain.Size = New System.Drawing.Size(181, 92)
        '
        'TsmOpen
        '
        Me.TsmOpen.Enabled = False
        Me.TsmOpen.Image = CType(resources.GetObject("TsmOpen.Image"), System.Drawing.Image)
        Me.TsmOpen.Name = "TsmOpen"
        Me.TsmOpen.Size = New System.Drawing.Size(180, 22)
        Me.TsmOpen.Text = Global.AutoTurnOff.My.Resources.Resources.NtfMainOpen
        '
        'TsmConfig
        '
        Me.TsmConfig.Enabled = False
        Me.TsmConfig.Image = CType(resources.GetObject("TsmConfig.Image"), System.Drawing.Image)
        Me.TsmConfig.Name = "TsmConfig"
        Me.TsmConfig.Size = New System.Drawing.Size(180, 22)
        Me.TsmConfig.Text = Global.AutoTurnOff.My.Resources.Resources.NtfMainConfig
        '
        'TsmClose
        '
        Me.TsmClose.Image = CType(resources.GetObject("TsmClose.Image"), System.Drawing.Image)
        Me.TsmClose.Name = "TsmClose"
        Me.TsmClose.Size = New System.Drawing.Size(180, 22)
        Me.TsmClose.Text = Global.AutoTurnOff.My.Resources.Resources.NtfMainClose
        '
        'LblMain
        '
        Me.LblMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMain.Location = New System.Drawing.Point(12, 9)
        Me.LblMain.Name = "LblMain"
        Me.LblMain.Size = New System.Drawing.Size(220, 18)
        Me.LblMain.TabIndex = 0
        Me.LblMain.Text = "Loading Post Movie Auto Turn Off..."
        Me.LblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WndSplashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 36)
        Me.Controls.Add(Me.LblMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WndSplashscreen"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splashscreen"
        Me.CmsNtfMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NtfMain As NotifyIcon
    Friend WithEvents LblMain As Label
    Friend WithEvents CmsNtfMain As ContextMenuStrip
    Friend WithEvents TsmOpen As ToolStripMenuItem
    Friend WithEvents TsmConfig As ToolStripMenuItem
    Friend WithEvents TsmClose As ToolStripMenuItem
End Class
