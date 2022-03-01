Public Class NumberBox
    Inherits System.Windows.Forms.TextBox

    Private _CurrencyAsInt As Integer = 0
    Public Property CurrencyAsInt() As Integer
        Get
            Return _CurrencyAsInt
        End Get
        Set(value As Integer)
            _CurrencyAsInt = value
            FormatInput()
        End Set
    End Property

    Public Sub New()
        Me.HideSelection = True
        FormatInput()
    End Sub

    Private Sub CurrencyTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        e.SuppressKeyPress = True
        If (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then 'Teclado numerico topo e lateral
            If CurrencyAsInt * 10 > 10000000 Then
                'MessageBox.Show("Não é possível definir um valor maior que 100 mil reais.")
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
            Else
                CurrencyAsInt = CurrencyAsInt * 10
                If (e.KeyValue >= 48 And e.KeyValue <= 57) Then 'Teclado numerico topo teclado
                    CurrencyAsInt = CurrencyAsInt + (e.KeyValue - 48)
                ElseIf (e.KeyValue >= 96 And e.KeyValue <= 105) Then 'Teclado numerico lateral
                    CurrencyAsInt = CurrencyAsInt + (e.KeyValue - 96)
                End If

            End If
        ElseIf e.KeyValue = 8 Then 'Delete
            If CurrencyAsInt.ToString.Length > 1 Then
                CurrencyAsInt = Convert.ToInt32(Strings.Left(CurrencyAsInt.ToString, CurrencyAsInt.ToString.Length - 1))
            Else
                CurrencyAsInt = 0
            End If
        End If
        FormatInput()
    End Sub

    Public Sub FormatInput()
        If CurrencyAsInt.ToString.Length > 0 Then
            Me.Text = CurrencyAsInt.ToString
        Else
            CurrencyAsInt = 0
        End If
        Me.SelectionStart = Me.Text.Length
    End Sub


    Private Sub CurrencyTextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Me.SelectionStart = Me.Text.Length
    End Sub
End Class
