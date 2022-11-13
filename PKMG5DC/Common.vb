Module Common
    Public Sub ReadIni()
        With Main5.mySettings
            .Filename = Main5.Local & "\settings.ini"
            If .OpenIniFile() Then
                My.Settings.ticket = .GetValue("Ticket")
                My.Settings.Region = .GetValue("Region")
                Main5.ToolVer = .GetValue("Tool Version")
                '.SetValue("Ticket", My.Settings.ticket)
                If Not .SaveIni Then
                    MsgBox("Trouble writing Ini-File")
                End If
            Else
                MsgBox("No Ini-File found")
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
                .SetValue("Tool Version", Main5.ToolVer)
                If Not .SaveIni Then
                    MsgBox("Trouble by writing Ini-File")
                End If
            Else
                MsgBox("No Ini-File found")
            End If
        End With
    End Sub
End Module
