Public Class CustomMessageBox
    Public Sub New(ByVal message As String, Optional ByVal numberOfButtons As Integer = 1, Optional ByVal button1Text As String = "OK", Optional ByVal button2Text As String = "Cancel", Optional ByVal button3Text As String = "", Optional ByVal header As String = "")
        InitializeComponent()
        lb_Message.Text = message
        If numberOfButtons = 0 Then numberOfButtons = 1
        If numberOfButtons = 1 Then
            bt_First.Text = button1Text
            bt_First.Location = New Point(104, 80)
            bt_Second.Hide()
            bt_Third.Hide()
        ElseIf numberOfButtons = 2 Then
            bt_First.Text = button1Text
            bt_Second.Text = button2Text
            bt_First.Location = New Point(37, 80)
            bt_Second.Location = New Point(163, 80)
            bt_Third.Hide()
        ElseIf numberOfButtons = 3 Then
            bt_First.Text = button1Text
            bt_Second.Text = button2Text
            bt_Third.Text = button3Text
            bt_First.Location = New Point(10, 80)
            bt_Second.Location = New Point(104, 80)
            bt_Third.Location = New Point(197, 80)
        End If
        Me.Text = header
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub
    Private Sub Bt_First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_First.Click
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub
    Private Sub Bt_Second_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Second.Click
        DialogResult = Windows.Forms.DialogResult.No
        Close()
    End Sub
    Private Sub Bt_Third_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Third.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub
End Class
Module CustomMsgBox
    'Custom MsgBox
    Public Function MsgBox(ByVal message As String, Optional ByVal numberOfButtons As Integer = 1, Optional ByVal button1Text As String = "OK", Optional ByVal button2Text As String = "Cancel", Optional ByVal button3Text As String = "", Optional ByVal header As String = "")
        Dim msg As New CustomMessageBox(message, numberOfButtons, button1Text, button2Text, button3Text, header)
        Dim result = msg.ShowDialog()
        If result = Windows.Forms.DialogResult.Yes Then
            'user clicked "B1"
            Return 6
        ElseIf result = Windows.Forms.DialogResult.No Then
            'user clicked "B2"
            Return 7
        ElseIf result = Windows.Forms.DialogResult.Cancel Then
            'user clicked "B3"
            Return 8
        Else
            'user closed the window without clicking a button
            Form.ActiveForm.Close()
            Return -1
        End If
    End Function
End Module