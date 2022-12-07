Imports System.Xml
Module SettingsFile
    Dim Settings As XmlDocument

    Public Sub ReadSettings()
        Settings = New XmlDocument
        Settings.Load(Main5.Local & "\settings.xml")
        'My.Settings.Language = GetValue("Language")
        My.Settings.ticket = GetValue("Ticket").ToString.Replace("/", "\")
        My.Settings.Region = GetValue("Region")
        Main5.ToolVer = GetValue("ToolVersion")
    End Sub
    Private Function GetValue(SettingName) As String
        Return Settings.SelectSingleNode("Settings/" & SettingName).InnerText
    End Function

    Public Sub WriteSettings()
        If Not IO.File.Exists(Main5.Local & "\settings.xml") Then CreateSettings()
        'SetValue("Language", My.Settings.Language)
        SetValue("Ticket", My.Settings.ticket.Replace("\", "/"))
        SetValue("Region", My.Settings.Region)
        SetValue("ToolVersion", Main5.ToolVer)
        Settings.Save(Main5.Local & "\settings.xml")
    End Sub
    Private Sub SetValue(SettingName As String, SettingValue As String)
        Dim SettingNode As XmlElement
        Try
            SettingNode = DirectCast(Settings.SelectSingleNode("Settings/" & SettingName), XmlElement)
        Catch
            SettingNode = Nothing
        End Try
        If Not SettingNode Is Nothing Then
            SettingNode.InnerText = SettingValue
        Else
            SettingNode = Settings.CreateElement(SettingName)
            SettingNode.InnerText = SettingValue
            Settings.SelectSingleNode("Settings").AppendChild(SettingNode)
        End If
    End Sub
    Private Sub CreateSettings()
        Settings = New XmlDocument
        Dim dec As XmlDeclaration = Settings.CreateXmlDeclaration("1.0", "utf-8", String.Empty)
        Settings.AppendChild(dec)

        Dim nodeRoot As XmlNode
        nodeRoot = Settings.CreateNode(XmlNodeType.Element, "Settings", "")
        Settings.AppendChild(nodeRoot)
    End Sub
End Module
