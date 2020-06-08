Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Main5
#Region "Variables"
    Public Shared ReadOnly apppath As String = My.Application.Info.DirectoryPath 'Path to .exe directory
    Public Shared ReadOnly res As String = Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") 'Path to Project Resources
    Public Shared ReadOnly TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp" 'Path to Temp
    Public Shared ReadOnly Local As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Regnum\PKMG5DC" 'Path to Local folder
    Dim OpenFile As New OpenFileDialog
    ReadOnly langCksm As UShort() = {&H83BC, &H9D36, &H39AA, &H4418, &HE061, &HF57A} 'List of Language Checksums
    ReadOnly langs As Byte() = {&H2, &H3, &H4, &H5, &H6} 'List of Language values
    Dim mySettings As New IniFile 'Settings.ini File
    Dim pn_Settings As New Pnl_Settings 'Panel Settings
    Dim doneLoad As Boolean = False
    Dim WC As New PGF
    Dim CardPiece As New Card5P
    'Dim cardPieces(7) As String
    Dim Card As New Card5
    Dim tempDate(15) As Date
#End Region

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckLocal()
        CheckTicket()
        UpdateChk()
        Dim tools(,) = {{"\tools\ndstool.exe", My.Resources.ndstool}, {"\tools\extract.bat", "cd " & Local & "\tools
    ndstool.exe -x ..\ticket.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin"}, {"\tools\compile.bat", "cd " & Local & "\tools
    ndstool.exe -c ..\ticket2.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin"}, {"\tools\clean.bat", "cd " & Local & "\tools
    rd /S/Q data
    del arm9.bin arm7.bin banner.bin header.bin"}}
        CreateFiles(tools)
        For i = 0 To 7
            File.WriteAllBytes(Local & "\cards\Card " & (i + 1) & ".bin", CardPiece.data)
        Next
        'Process.Start(Local & "\tools\extract.bat").WaitForExit()
        'File.Delete(Local & "\tools\data\data.bin")
        'Save(Local & "\tools\data\data.bin", RichTextBox1.Text)
        'Process.Start(Local & "\tools\compile.bat").WaitForExit()
        'Process.Start(Local & "\tools\clean.bat").WaitForExit()
        'cardPieces = {CardPiece.data, CardPiece.data, CardPiece.data, CardPiece.data, CardPiece.data, CardPiece.data, CardPiece.data, CardPiece.data}
        Tp_Add_Enter(sender, e)
        doneLoad = True
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        With mySettings
            .Filename = Local & "\settings.ini"
            If .OpenIniFile() Then
                'Dim MyValue As String = .GetValue("MyKey")
                .SetValue("Ticket", My.Settings.ticket)
                If Not .SaveIni Then
                    MessageBox.Show("Trouble by writing Ini-File")
                End If
            Else
                MessageBox.Show("No Ini-File found")
            End If
        End With
    End Sub
#Region "Esentials"
    'Checks For Update
    Private Sub UpdateChk()
        If File.Exists(TempPath & "\vsn.txt") Then
            File.Delete(TempPath & "\vsn.txt")
        End If
        If File.Exists(TempPath & "\dt.txt") Then
            File.Delete(TempPath & "\dt.txt")
        End If
#If DEBUG Then
        File.WriteAllText(apppath & "/version.txt", My.Application.Info.Version.ToString)
        File.WriteAllText(apppath & "/version.json", "{
    " & ControlChars.Quote & "version" & ControlChars.Quote & ": " & ControlChars.Quote & My.Application.Info.Version.ToString & ControlChars.Quote & "
    }")
        If My.Computer.Network.IsAvailable Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/master/Gen5%20Distribution%20Creator/bin/Debug/version.txt", TempPath & "\vsn.txt")
            Dim Reader As New IO.StreamReader(TempPath & "\vsn.txt")
            Dim v As String = Reader.ReadToEnd
            Reader.Close()
            File.Delete(TempPath & "\vsn.txt")
            If Application.ProductVersion <> v Then
                File.WriteAllText(res & "/date.txt", (System.DateTime.Today.Year & "/" & System.DateTime.Today.Month & "/" & System.DateTime.Today.Day))
            End If
        End If
        lklb_Update.Hide()
        MenuStrip1.Location = New Point(0, 0)
#Else
            File.WriteAllText(TempPath & "\date.txt", My.Resources._date)
            Dim dat As String = File.ReadAllText(TempPath & "\date.txt")
            Me.Text = "PKMG5DC (" & dat & ")"
            If My.Computer.Network.IsAvailable Then
                Try
                    My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/master/Gen5%20Distribution%20Creator/Resources/date.txt", TempPath & "\dt.txt")
                Catch
                    File.WriteAllText(TempPath & "\dt.txt", " ")
                End Try
                Dim Reader As New IO.StreamReader(TempPath & "\dt.txt")
                Dim dtt As String = Reader.ReadToEnd
                Reader.Close()
                File.Delete(TempPath & "\dt.txt")
                If dat <> dtt Then
                    lklb_Update.Text = "New Update Available! " & dtt
                    MenuStrip1.Location = New Point(170, 0)
                    lklb_Update.Show()
                Else
                    lklb_Update.Hide()
                    MenuStrip1.Location = New Point(0, 0)
                End If
            Else
                lklb_Update.Hide()
            End If
            File.Delete(TempPath & "\date.txt")
#End If
    End Sub
    Private Sub Lklb_Update_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_Update.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/releases/latest")
        Else
            MsgBox("No Internet connection!
    You can not update at the moment.", vbOKOnly, "Error 404")
        End If
    End Sub

#End Region
#Region "Startup"
    Private Sub CreateFolders(ByVal dirs As String())
        Try
            For i = 0 To UBound(dirs) Step 1
                If dirs(i).Contains(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) Then
                Else
                    dirs(i) = Local & dirs(i)
                End If
                Do While Not Directory.Exists(dirs(i))
                    If Not Directory.Exists(dirs(i)) Then
                        Directory.CreateDirectory(dirs(i))
                    End If
                Loop
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CreateFiles(ByVal files(,))
        Try
            For i = 0 To UBound(files) Step 1
                If files(i, 0).Contains(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) Then
                Else
                    files(i, 0) = Local & files(i, 0)
                End If
                Do While Not File.Exists(files(i, 0))
                    If Not File.Exists(files(i, 0)) Then
                        If TypeOf files(i, 1) Is String Then
                            File.WriteAllText(files(i, 0), files(i, 1))
                        Else
                            File.WriteAllBytes(files(i, 0), files(i, 1))
                        End If
                    End If
                Loop
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Checks Local Folders
    Private Sub CheckLocal()
        Dim locals As String() = {Local.Replace("\PKMG5DC", ""), Local, Local & "\tools", Local & "\cards"}
        CreateFolders(locals)
        If Not File.Exists(Local & "\settings.ini") Then
            File.Create(Local & "\settings.ini")
        End If
        With mySettings
            .Filename = Local & "\settings.ini"
            If .OpenIniFile() Then
                My.Settings.ticket = .GetValue("Ticket")
                '.SetValue("Ticket", My.Settings.ticket)
                If Not .SaveIni Then
                    MsgB("Trouble writing Ini-File")
                End If
            Else
                MsgB("No Ini-File found")
            End If
        End With
    End Sub
    'Checks for Ticket
    Private Sub CheckTicket()
        If My.Settings.ticket <> Nothing Then
            If File.Exists(My.Settings.ticket) Then
                VerifyTicket()
            Else
                GetTicket()
            End If
        ElseIf My.Settings.ticket = Nothing Then
            GetTicket()
        End If
    End Sub
    Private Sub GetTicket()
        Dim ans = MsgB("This program requires a clean copy of the Liberty Ticket Distribution ROM. Do you have one?", 2, "Yes", "No",, "Need Liberty Ticket ROM")
        Select Case ans
            Case 6
                ans = MsgB("Can you select it for me?", 2, "Sure", "Not sure",, "Need Liberty Ticket ROM")
                Select Case ans
                    Case 6
                        Dim FileSelect As New OpenFileDialog With {
                        .Filter = "Event ROM (*.nds)|*.nds|All files (*.*)|*.*"}
                        Dim res As DialogResult = FileSelect.ShowDialog()
                        If res = Windows.Forms.DialogResult.Cancel Then
                            Close()
                        Else
                            Dim myFile As String = FileSelect.FileName
                            If System.IO.File.Exists(Local & "\ticket.nds") Then
                                System.IO.File.Delete(Local & "\ticket.nds")
                            End If
                            System.IO.File.Copy(myFile, Local & "\ticket.nds")
                            My.Settings.ticket = Local & "\ticket.nds"
                            VerifyTicket()
                        End If
                    Case 7
                        Close()
                End Select
            Case 7
                DeSmuME_Check()
                Close()
        End Select
    End Sub
    Private Sub VerifyTicket()
        Dim myFile As String = My.Settings.ticket
        Dim l = System.IO.File.ReadAllText(myFile)
        If l.Contains("POKWBLIBERTYY8KP01") Then
        Else
            MsgB("Error: Invaild File", 1, "OK",,, "ERROR FOUND")
            File.Delete(My.Settings.ticket)
            Close()
        End If
    End Sub
    Private Sub DeSmuME_Check()
        Dim Everest_Registry As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey("Applications\DeSmuME.exe")
        Dim Everest_Registry2 As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey("Applications\DeSmuME_0.9.11_x64.exe")
        If Everest_Registry Is Nothing And Everest_Registry2 Is Nothing Then
        Else
            Dim gen As New Random
            Dim n = gen.Next(1, 26)
            Dim f = gen.Next(0, 2)
            If (n Mod (System.DateTime.Today.Day Mod 3)) = f Then
                If My.Computer.Network.IsAvailable Then
                    Dim ans = MsgB("Google is your friend.", 2, "I know", "How so?")
                    If ans = 7 Then
                        Process.Start("https://www.google.com/search?q=pokemon+liberty+ticket+distribution+rom")
                    End If
                End If
            Else
                MsgB("Google is your friend.", 1, "OK")
            End If
        End If
    End Sub

    'Private Sub CheckGen()
    '    Dim n As String = Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule.FileName)
    '    If n.Contains("G4") Then
    '        Gen = 4
    '    Else
    '        Gen = 5
    '    End If
    'End Sub
#End Region

#Region "Tab and Panel"
    'Adds New Tab
    Private Sub Tp_Add_Enter(sender As Object, e As EventArgs) Handles tp_Add.Enter
        Dim DelTab As TabPage = tc_Cards.SelectedTab
        Dim NewTab As New TabPage()
        With NewTab
            .Location = New System.Drawing.Point(4, 22)
            .Name = "tp_Card" & (DelTab.TabIndex + 1)
            .Padding = New System.Windows.Forms.Padding(3)
            .Size = New Size(278, 315)
            .TabIndex = DelTab.TabIndex
            .Text = "Card " & (DelTab.TabIndex + If(doneLoad = False, 0, 1))
            .UseVisualStyleBackColor = True
        End With
        tc_Cards.TabPages.Add(NewTab)
        AddHandler NewTab.Leave, AddressOf Me.SavePanel
        AddHandler NewTab.Enter, AddressOf Me.MovePanel
        Card.NumberOfCards += 1
        Dim NewAddTab As New TabPage()
        With NewAddTab
            .Location = New System.Drawing.Point(4, 22)
            .Text = "    +"
            .Name = "tp_Add"
            .Padding = New System.Windows.Forms.Padding(0)
            .Size = New System.Drawing.Size(278, 315)
            .TabIndex = tc_Cards.TabPages.Count - 1
            .UseVisualStyleBackColor = True
        End With
        tc_Cards.TabPages.Remove(DelTab)
        If tc_Cards.TabCount < 8 Then
            tc_Cards.TabPages.Add(NewAddTab)
            AddHandler NewAddTab.Enter, AddressOf Me.Tp_Add_Enter
        End If
    End Sub

    'Moves the panel and load the settings
    Private Sub MovePanel()
        CardPiece.data = File.ReadAllBytes(Local & "\cards\" & tc_Cards.SelectedTab.Text & ".bin")
        tc_Cards.SelectedTab.Controls.Add(Me.pnl_EditCard)
        With pn_Settings
            lb_PGF.Text = .pnl_Strings(tc_Cards.SelectedIndex)
            rtb_EventMsg.Text = .pnl_Strings(tc_Cards.SelectedIndex + 8)
            cb_MaxLimit.Checked = .maxLimit(tc_Cards.SelectedIndex)
            cb_Region.SelectedIndex = .region(tc_Cards.SelectedIndex)
            If .dates(tc_Cards.SelectedIndex) <> Nothing Then StartDatePicker.Value = .dates(tc_Cards.SelectedIndex)
            If .dates(tc_Cards.SelectedIndex + 8) <> Nothing Then EndDatePicker.Value = .dates(tc_Cards.SelectedIndex + 8)
        End With
        If doneLoad Then
            'If cardPieces(tc_Cards.SelectedIndex) IsNot Nothing Then CardPiece.data = HexStringToByteArray(cardPieces(tc_Cards.SelectedIndex))
            cb_Black.Checked = CardPiece.Black
            cb_White.Checked = CardPiece.White
            cb_Black2.Checked = CardPiece.Black2
            cb_White2.Checked = CardPiece.White2
        End If
    End Sub

    'Saves Panel settings
    Private Sub SavePanel()
        'File.WriteAllBytes(Local & "\cards\" & tc_Cards.SelectedTab.Text & ".bin", CardPiece.data)
        With pn_Settings
            .pnl_Strings(tc_Cards.SelectedIndex) = lb_PGF.Text
            .pnl_Strings(tc_Cards.SelectedIndex + 8) = rtb_EventMsg.Text
            .maxLimit(tc_Cards.SelectedIndex) = cb_MaxLimit.Checked
            .region(tc_Cards.SelectedIndex) = cb_Region.SelectedIndex
            If doneLoad Then .dates(tc_Cards.SelectedIndex) = StartDatePicker.Value
            If doneLoad Then .dates(tc_Cards.SelectedIndex + 8) = EndDatePicker.Value
        End With
        'Dim t(&H2D8) As Byte
        'For i = 0 To &H2D8
        't(i) = 0
        'Next
        'CardPiece.data = t
    End Sub

    'Panel Settings
    Private Class Pnl_Settings
        Public pnl_Strings(15) As String
        Public maxLimit(7) As Boolean
        Public region(7) As Byte
        Public dates(15) As Date
    End Class
#End Region

    Private Sub Bt_PGF_Click(sender As Object, e As EventArgs) Handles bt_PGF.Click
        OpenFile.Filter = "Gen 5 Wondercard (*.pgf)|*.pgf;*.wc5|All files (*.*)|*.*"
        Dim res As DialogResult = OpenFile.ShowDialog()
        If res <> Windows.Forms.DialogResult.Cancel Then
            Dim myFile As String = Path.GetFileName(OpenFile.FileName)
            lb_PGF.Text = myFile
            CardPiece.Wondercard = File.ReadAllBytes(OpenFile.FileName)
            File.WriteAllBytes(Local & "\testCP.bin", CardPiece.data)
        End If
        'Enable/Disable controls
    End Sub

    Private Sub Cb_Black_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Black.CheckedChanged
        Select Case cb_Black.Checked
            Case True
                CardPiece.Black = True
            Case False
                CardPiece.Black = False
        End Select
    End Sub
    Private Sub Cb_White_CheckedChanged(sender As Object, e As EventArgs) Handles cb_White.CheckedChanged
        Select Case cb_White.Checked
            Case True
                CardPiece.White = True
            Case False
                CardPiece.White = False
        End Select
    End Sub
    Private Sub Cb_Black2_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Black2.CheckedChanged
        Select Case cb_Black2.Checked
            Case True
                CardPiece.Black2 = True
            Case False
                CardPiece.Black2 = False
        End Select
    End Sub
    Private Sub Cb_White2_CheckedChanged(sender As Object, e As EventArgs) Handles cb_White2.CheckedChanged
        Select Case cb_White2.Checked
            Case True
                CardPiece.White2 = True
            Case False
                CardPiece.White2 = False
        End Select
    End Sub

    Private Sub Cb_Region_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Region.SelectedIndexChanged
        If doneLoad Then
            Select Case cb_Region.SelectedIndex
                Case < 5
                    CardPiece.LangChecksum = langCksm(cb_Region.SelectedIndex)
                    CardPiece.Language = langs(cb_Region.SelectedIndex)
                Case 5
                    CardPiece.LangChecksum = langCksm(cb_Region.SelectedIndex)
                    CardPiece.Language = langs(0)
                Case Else
                    CardPiece.LangChecksum = langCksm(cb_Region.SelectedIndex - 1)
                    CardPiece.Language = langs(0)
            End Select
        End If
    End Sub

    Private Sub StartDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles StartDatePicker.ValueChanged
        If doneLoad Then
            CardPiece.StartDay = StartDatePicker.Value.Day
            CardPiece.StartMonth = StartDatePicker.Value.Month
            CardPiece.StartYear = StartDatePicker.Value.Year
        End If
    End Sub

    Private Sub EndDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles EndDatePicker.ValueChanged
        If doneLoad Then
            CardPiece.EndDay = EndDatePicker.Value.Day
            CardPiece.EndMonth = EndDatePicker.Value.Month
            CardPiece.EndYear = EndDatePicker.Value.Year
        End If
    End Sub

    Private Sub Cb_MaxLimit_CheckedChanged(sender As Object, e As EventArgs) Handles cb_MaxLimit.CheckedChanged
        Select Case cb_MaxLimit.Checked
            Case True
                lb_Start.Enabled = False
                lb_End.Enabled = False
                tempDate(tc_Cards.SelectedIndex) = StartDatePicker.Value
                tempDate(tc_Cards.SelectedIndex + 8) = EndDatePicker.Value
                StartDatePicker.Value = New DateTime(1753, 1, 1)
                EndDatePicker.Value = New DateTime(9998, 12, 31)
                StartDatePicker.Enabled = False
                EndDatePicker.Enabled = False
            Case False
                lb_Start.Enabled = True
                lb_End.Enabled = True
                StartDatePicker.Value = tempDate(tc_Cards.SelectedIndex)
                EndDatePicker.Value = tempDate(tc_Cards.SelectedIndex + 8)
                StartDatePicker.Enabled = True
                EndDatePicker.Enabled = True
        End Select
    End Sub

    Private Sub Rtb_EventMsg_TextChanged(sender As Object, e As EventArgs) Handles rtb_EventMsg.TextChanged
        CardPiece.EventText = rtb_EventMsg.Text.Replace(ChrW(&HA00), ChrW(&HFEFF))
        'File.WriteAllBytes(Local & "\cards\" & tc_Cards.SelectedTab.Text & ".bin", CardPiece.data)
        SavePanel()
    End Sub

    Private Sub Bt_Build_Click(sender As Object, e As EventArgs) Handles bt_Build.Click
        SavePanel()
        'File.WriteAllBytes(Local & "\testCP.bin", HexStringToByteArray(cardPieces(0)))
        With Card
            'Dim listOfCards As New List(Of Byte())({ .Card_1, .Card_2, .Card_3, .Card_4, .Card_5, .Card_6, .Card_7, .Card_8})
            'Dim listOfDates As New List(Of UShort)({ .StartDay_1, .StartDay_2, .StartDay_3, .StartDay_4, .StartDay_5, .StartDay_6, .StartDay_7, .StartDay_8})
            'Dim n = 0
            'For Each i As Byte() In listOfCards
            '    i = cardPieces(n).Take(&H2D0)
            '    n += 1
            'Next i
            'For n = 0 To .NumberOfCards - 1 Step 1
            '    If cardPieces(n) IsNot Nothing Then
            '        CardPiece.data = HexStringToByteArray(cardPieces(n))
            '        .Cards(n) = CardPiece.data.Take(&H2D0).ToArray()
            '        .StartYears(n) = CardPiece.StartYear
            '        .StartMonths(n) = CardPiece.StartMonth
            '        .StartDays(n) = CardPiece.StartDay
            '        .EndYears(n) = CardPiece.EndYear
            '        .EndMonths(n) = CardPiece.EndMonth
            '        .EndDays(n) = CardPiece.EndDay
            '        .NumberOfCards += 1
            '        CardPiece = New Card5P
            '    End If
            'Next n
            'File.WriteAllBytes(Local & "\outputCard.bin", .Data)

            Dim listOfCards As New List(Of String)({"Card 1.bin", "Card 2.bin", "Card 3.bin", "Card 4.bin", "Card 5.bin", "Card 6.bin", "Card 7.bin", "Card 8.bin"})
            For Each i As String In listOfCards
                If File.Exists(Local & "\cards\" & i) Then
                    CardPiece.data = File.ReadAllBytes(Local & "\cards\" & i)
                    Dim n = listOfCards.IndexOf(i)
                    .Cards(n) = CardPiece.data.Take(&H2D0).ToArray()
                    .StartYears(n) = CardPiece.StartYear
                    .StartMonths(n) = CardPiece.StartMonth
                    .StartDays(n) = CardPiece.StartDay
                    .EndYears(n) = CardPiece.EndYear
                    .EndMonths(n) = CardPiece.EndMonth
                    .EndDays(n) = CardPiece.EndDay
                    CardPiece = New Card5P
                End If
            Next i
            File.WriteAllBytes(Local & "\outputCard.bin", .Data)
        End With
    End Sub
End Class