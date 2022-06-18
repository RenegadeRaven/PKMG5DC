Public Class CustomMessageBox
    Public Sub New(ByVal message As String, Optional ByVal numB As Integer = 1, Optional ByVal button1Name As String = "OK", Optional ByVal button2name As String = "Cancel", Optional ByVal button3name As String = "", Optional ByVal header As String = "")
        InitializeComponent()
        Label1.Text = message
        If numB = 0 Then
            numB = 1
        End If
        If numB = 1 Then
            Button1.Text = button1Name
            Button1.Location = New Point(104, 80)
            Button2.Hide()
            Button3.Hide()
        ElseIf numB = 2 Then
            Button1.Text = button1Name
            Button2.Text = button2name
            Button1.Location = New Point(37, 80)
            Button2.Location = New Point(163, 80)
            Button3.Hide()
        ElseIf numB = 3 Then
            Button1.Text = button1Name
            Button2.Text = button2name
            Button3.Text = button3name
            Button1.Location = New Point(10, 80)
            Button2.Location = New Point(104, 80)
            Button3.Location = New Point(197, 80)
        End If
        Me.Text = header
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogResult = Windows.Forms.DialogResult.No
        Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub
End Class