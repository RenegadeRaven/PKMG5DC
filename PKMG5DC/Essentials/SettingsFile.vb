Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Module SettingsFile
    Dim Settings As JObject

    Public Sub ReadSettings()
        Dim lang As String = File.ReadAllText(Main5.Local & "\settings.json")
        If lang IsNot Nothing Then Settings = JObject.Parse(lang)
        'LangData("New Update Available! ").ToString()
        My.Settings.ticket = Settings("Ticket").ToString.Replace("/", "\")
        My.Settings.Region = Settings("Region")
        Main5.ToolVer = Settings("ToolVersion")
    End Sub
    Public Sub WriteSettings()
        If Not File.Exists(Main5.Local & "\settings.json") Then CreateSettings()
        Dim lang As String = File.ReadAllText(Main5.Local & "\settings.json")
        If lang IsNot Nothing Then Settings = JObject.Parse(lang)
        Settings("Ticket") = My.Settings.ticket.Replace("\", "/")
        My.Settings.ticket.Replace("\", "/")
        Settings("Region") = My.Settings.Region
        Settings("ToolVersion") = Main5.ToolVer
        File.WriteAllText(Main5.Local & "\settings.json", Settings.ToString)
    End Sub
    Public Sub CreateSettings()
        Dim dSettings As Object = New JObject()
        dSettings.Ticket = My.Settings.ticket.Replace("\", "/")
        dSettings.Region = My.Settings.Region
        dSettings.ToolVersion = Main5.ToolVer
        File.WriteAllText(Main5.Local & "\settings.json", dSettings.ToString)
    End Sub
End Module
