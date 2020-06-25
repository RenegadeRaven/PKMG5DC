Imports System.Text

Module Common
    'Custom MsgBox
    Public Function MsgB(ByVal mes As String, Optional ByVal numB As Integer = 1, Optional ByVal but1 As String = "OK", Optional ByVal but2 As String = "Cancel", Optional ByVal but3 As String = "", Optional ByVal head As String = "")
        Dim msg As New CustomMessageBox(mes, numB, but1, but2, but3, head)
        Dim result = msg.ShowDialog()
        Dim Ans As Integer
        If result = Windows.Forms.DialogResult.Yes Then
            'user clicked "B1"
            Ans = 6
        ElseIf result = Windows.Forms.DialogResult.No Then
            'user clicked "B2"
            Ans = 7
        ElseIf result = Windows.Forms.DialogResult.Cancel Then
            'user clicked "B3"
            Ans = 8
        Else
            'user closed the window without clicking a button
            Ans = -1
            'Form4.Close()
            Form.ActiveForm.Close()
        End If
        Return Ans
    End Function

    Public Function GetString(data As Byte(), offset As Byte, count As UShort)
        Return Encoding.Unicode.GetString(data, offset, count).Replace(ChrW(&HFFFF), "").Replace(ChrW(&H0), "").Replace(ChrW(&HFFFE), vbLf)
    End Function
    Public Function SetString(ByVal value As String, ByVal maxLength As Integer)
        ' value = value.Replace(vbLf, ChrW(&HFFFE))
        If value.Length > maxLength Then value = value.Substring(0, maxLength)
        Do While value.Length < maxLength
            value &= ChrW(&HFFFF)
        Loop
        Dim temp As String = value & ChrW(&HFFFF)
        Return Encoding.Unicode.GetBytes(temp)
    End Function
    Public Sub ReadIni()
        With Main5.mySettings
            .Filename = Main5.Local & "\settings.ini"
            If .OpenIniFile() Then
                My.Settings.ticket = .GetValue("Ticket")
                My.Settings.Region = .GetValue("Region")
                '.SetValue("Ticket", My.Settings.ticket)
                If Not .SaveIni Then
                    MsgB("Trouble writing Ini-File")
                End If
            Else
                MsgB("No Ini-File found")
            End If
        End With
    End Sub
    Public Sub WriteIni()
        With Main5.mySettings
            .Filename = Main5.Local & "\settings.ini"
            If .OpenIniFile() Then
                'Dim MyValue As String = .GetValue("MyKey")
                .SetValue("Ticket", My.Settings.ticket)
                .SetValue("Region", My.Settings.Region)
                If Not .SaveIni Then
                    MsgB("Trouble by writing Ini-File")
                End If
            Else
                MsgB("No Ini-File found")
            End If
        End With
    End Sub
End Module
