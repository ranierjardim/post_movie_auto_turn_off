Public Class WndTests
    Private Sub BtnAgendarDesligamento_Click(sender As Object, e As EventArgs) Handles BtnAgendarDesligamento.Click
        Dim info As New ProcessStartInfo("cmd.exe")
        info.Arguments = "/C shutdown /s /t 20"
        info.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(info)
        MsgBox("agendado")
    End Sub

    Private Sub BtnCancelarAgendamento_Click(sender As Object, e As EventArgs) Handles BtnCancelarAgendamento.Click
        Dim info As New ProcessStartInfo("cmd.exe")
        info.Arguments = "/C shutdown /a"
        info.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(info)
        MsgBox("cancelado")
    End Sub

    Private Sub WndTests_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class