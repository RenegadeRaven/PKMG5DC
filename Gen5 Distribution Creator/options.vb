Public Class Options
    Dim f As Boolean = False
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If f = True Then
            My.Settings.Delay = (NumericUpDown1.Value * 1000)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If My.Settings.Delay = Nothing Or My.Settings.Delay = 0 Then
        '    My.Settings.Delay = 300
        'End If
        NumericUpDown1.Value = (My.Settings.Delay / 1000)
        f = True
        NumericUpDown1_ValueChanged(sender, e)
        Me.Refresh()
    End Sub
End Class