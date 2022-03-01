Public Class WndConfiguration

    Private Sub MyBase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Home AndAlso e.Modifiers = Keys.Control) Then
            WndTests.ShowDialog()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WndConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class