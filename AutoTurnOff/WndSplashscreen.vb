Public Class WndSplashscreen
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TsmClose_Click(sender As Object, e As EventArgs) Handles TsmClose.Click
        If MessageBox.Show(My.Resources.WndSplashscreen_TsmClose_Click_Text, My.Resources.WndSplashscreen_TsmClose_Click_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub NtfMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NtfMain.MouseDoubleClick
        WndAutoShutdown.Show()
    End Sub

    Private Sub TsmOpen_Click(sender As Object, e As EventArgs) Handles TsmOpen.Click
        WndAutoShutdown.Show()
    End Sub

    Private Sub TsmConfig_Click(sender As Object, e As EventArgs) Handles TsmConfig.Click
        WndConfiguration.Show()
    End Sub

    Private Sub WndSplashscreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
        WndAutoShutdown.Show()
    End Sub

    Private Sub WndSplashscreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        NtfMain.Text = My.Resources.WndSplashscreen_NtfMain_Text
    End Sub
End Class
