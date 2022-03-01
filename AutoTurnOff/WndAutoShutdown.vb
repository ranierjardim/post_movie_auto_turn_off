Imports System.ComponentModel

Public Class WndAutoShutdown
    Private Sub WndAutoShutdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WndAutoShutdown_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        Process.Start("https://postmovieautoturnoff.ranierjardim.com/help")
        MessageBox.Show("Foi/será aberta uma página de ajuda", "Ajuda aberta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim info As New ProcessStartInfo("cmd.exe")
        info.Arguments = "/C shutdown /a"
        info.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(info)
        'MsgBox("cancelado")
    End Sub

    Private Sub BtnSetShutdownTimeout_Click(sender As Object, e As EventArgs) Handles BtnSetShutdownTimeout.Click
        Dim time As Integer = (NbbHours.CurrencyAsInt * 60 * 60) + (NbbMinutes.CurrencyAsInt * 60)
        If time < 60 Then
            MessageBox.Show("É necessário definir um tempo maior que um minuto para agendar o desligamento.", "Tempo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Dim info As New ProcessStartInfo("cmd.exe")
        info.Arguments = "/C shutdown /s /t " & time.ToString
        info.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(info)
        'MsgBox("agendado")
    End Sub

    Private Sub WndAutoShutdown_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class