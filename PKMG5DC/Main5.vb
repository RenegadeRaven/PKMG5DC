Imports System.IO

Public Class Main5
#Region "Variables"
    Public Shared ReadOnly apppath As String = My.Application.Info.DirectoryPath 'Path to .exe directory
    Public Shared ReadOnly res As String = Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") 'Path to Project Resources
    Public Shared ReadOnly TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp" 'Path to Temp
    Public Shared ReadOnly Local As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Regnum\PKMG5DC" 'Path to Local folder
    Dim OpenFile As New OpenFileDialog 'Open File Window
    Dim SaveFile As New SaveFileDialog 'Save File Window
    ReadOnly langCksm As UShort() = {&H83BC, &H9D36, &H39AA, &H4418, &HE061, &HF57A} 'List of Language Checksums
    ReadOnly langs As Byte() = {&H2, &H3, &H4, &H5, &H7} 'List of Language values
    Public mySettings As New IniFile 'Settings.ini File
    Dim pn_Settings As New Pnl_Settings 'Panel Settings
    Dim doneLoad As Boolean = False 'Has Load finished?
    Dim WC As New PGF 'Wondercard
    Public Shared Card As New Card5 'Distro Card
    Public ToolVer As String = Application.ProductVersion
#End Region

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckLocal()
        CheckTicket()
        UpdateChk()
        Dim tools(,) = {{"\tools\ndstool.exe", My.Resources.ndstool}, {"\tools\extract.bat", "C:
cd " & Local & "\tools
ndstool.exe -x ..\ticket.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin"}, {"\tools\compile.bat", "C:
cd " & Local & "\tools
ndstool.exe -c ..\ticket2.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin"}, {"\tools\clean.bat", "C:
cd " & Local & "\tools
rd /S/Q data
del arm9.bin arm7.bin banner.bin header.bin"}}
        If ToolVer <> Application.ProductVersion Then Directory.Delete(Local & "\tools", True)
        CheckLocal()
        CreateFiles(tools)
        ToolVer = Application.ProductVersion
        'For i = 0 To 7
        '    File.WriteAllBytes(Local & "\cards\Card " & (i + 1) & ".bin", CardPiece.data)
        'Next
        Tp_Add_Enter(sender, e)
        doneLoad = True
        cb_Region.SelectedIndex = My.Settings.Region
        SyncRegion()
        bt_Build.Enabled = False
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        WriteIni()
    End Sub

#Region "Essentials"
    'Checks For Update
    Private Sub UpdateChk()
        If File.Exists(TempPath & "\vsn.txt") Then File.Delete(TempPath & "\vsn.txt")
        If File.Exists(TempPath & "\dt.txt") Then File.Delete(TempPath & "\dt.txt")
#If DEBUG Then
        File.WriteAllText(apppath & "..\..\..\version.txt", My.Application.Info.Version.ToString)
        File.WriteAllText(apppath & "..\..\..\version.json", "{
    " & ControlChars.Quote & "version" & ControlChars.Quote & ": " & ControlChars.Quote & My.Application.Info.Version.ToString & ControlChars.Quote & "
    }")
        If My.Computer.Network.IsAvailable Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/master/PKMG5DC/version.txt", TempPath & "\vsn.txt")
            Dim Reader As New IO.StreamReader(TempPath & "\vsn.txt")
            Dim v As String = Reader.ReadToEnd
            Reader.Close()
            File.Delete(TempPath & "\vsn.txt")
            If Application.ProductVersion <> v Then File.WriteAllText(res & "/date.txt", (System.DateTime.Today.Year & "/" & System.DateTime.Today.Month & "/" & System.DateTime.Today.Day))
        End If
        lklb_Update.Hide()
        MenuStrip1.Location = New Point(0, 0)
#Else
        File.WriteAllText(TempPath & "\date.txt", My.Resources._date)
            Dim dat As String = File.ReadAllText(TempPath & "\date.txt")
            Me.Text = "PKMG5DC (" & dat & ")"
            If My.Computer.Network.IsAvailable Then
                Try
                    My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/master/PKMG5DC/Resources/date.txt", TempPath & "\dt.txt")
                Catch
                    File.WriteAllText(TempPath & "\dt.txt", " ")
                End Try
                Dim Reader As New IO.StreamReader(TempPath & "\dt.txt")
                Dim dtt As String = Reader.ReadToEnd
                Reader.Close()
                File.Delete(TempPath & "\dt.txt")
                If dat <> dtt Then
                    lklb_Update.Text = "New Update Available! " & dtt
                MenuStrip1.Location = New Point(175, 0)
                pb_Donate.Location = New Point(119, 427)
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

    'Link to Update version
    Private Sub Lklb_Update_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_Update.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://github.com/PlasticJustice/PKMG5DC/releases/latest")
        Else
            MsgBox("No Internet connection!
    You can not update at the moment.", vbOKOnly, "Error 404")
        End If
    End Sub

    'Link the Author's, yours truly, Github Page
    Private Sub Lklb_Author_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_Author.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://github.com/PlasticJustice")
        Else
            MsgBox("No Internet connection!" & "
" & "You can look me up later.", 1, "OK",,, "Error" & " 404")
        End If
    End Sub

    'PayPal Donate Button
    Private Sub Pb_Donate_Click(sender As Object, e As EventArgs) Handles pb_Donate.Click
        System.Threading.Thread.Sleep(200)
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UGSCC5VGSGN3E")
        Else
            MsgBox("No Internet connection!" & "
" & "I appreciate the gesture.", 1, "OK",,, "Error" & " 404")
        End If
    End Sub
    Private Sub Pb_Donate_MouseDown(sender As Object, e As MouseEventArgs) Handles pb_Donate.MouseDown
        pb_Donate.Image = My.Resources.ppdbs
    End Sub
    Private Sub Pb_Donate_MouseUp(sender As Object, e As MouseEventArgs) Handles pb_Donate.MouseUp
        pb_Donate.Image = Nothing
    End Sub
#End Region
#Region "Startup"
    'Creates Local Files and Folders
    Private Sub CreateFolders(ByVal dirs As String())
        Try
            For i = 0 To UBound(dirs) Step 1
                If Not dirs(i).Contains(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) Then dirs(i) = Local & dirs(i)
                Do While Not Directory.Exists(dirs(i))
                    If Not Directory.Exists(dirs(i)) Then Directory.CreateDirectory(dirs(i))
                Loop
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CreateFiles(ByVal files(,))
        Try
            For i = 0 To UBound(files) Step 1
                If Not files(i, 0).Contains(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) Then files(i, 0) = Local & files(i, 0)
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
            MsgBox(ex.Message)
        End Try
    End Sub

    'Checks Local Folders
    Private Sub CheckLocal()
        Dim locals As String() = {Local.Replace("\PKMG5DC", ""), Local, Local & "\tools"} ', Local & "\cards"}
        CreateFolders(locals)
        If Not File.Exists(Local & "\settings.ini") Then
            File.WriteAllText(Local & "\settings.ini", "")
            WriteIni()
        End If
        ReadIni()
        tscb_Region.SelectedIndex = My.Settings.Region
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
        Dim ans = MsgBox("This program requires a clean copy of the Liberty Ticket Distribution ROM. Do you have one?", 2, "Yes", "No",, "Need Liberty Ticket ROM")
        Select Case ans
            Case 6
                ans = MsgBox("Can you select it for me?", 2, "Sure", "Not sure",, "Need Liberty Ticket ROM")
                Select Case ans
                    Case 6
                        Dim FileSelect As New OpenFileDialog With {
                        .Filter = "Event ROM (*.nds)|*.nds|All files (*.*)|*.*"}
                        Dim res As DialogResult = FileSelect.ShowDialog()
                        If res = Windows.Forms.DialogResult.Cancel Then
                            Close()
                        Else
                            Dim myFile As String = FileSelect.FileName
                            If System.IO.File.Exists(Local & "\ticket.nds") Then System.IO.File.Delete(Local & "\ticket.nds")
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
        If Not l.Contains("POKWBLIBERTYY8KP01") Then
            MsgBox("Error: Invaild File", 1, "OK",,, "ERROR FOUND")
            File.Delete(My.Settings.ticket)
            Close()
        End If
    End Sub
    Private Sub DeSmuME_Check()
        Dim Everest_Registry As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey("Applications\DeSmuME.exe")
        Dim Everest_Registry2 As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey("Applications\DeSmuME_0.9.11_x64.exe")
        If Everest_Registry IsNot Nothing And Everest_Registry2 IsNot Nothing Then
            Dim gen As New Random
            Dim n = gen.Next(1, 26)
            Dim f = gen.Next(0, 2)
            If (n Mod (System.DateTime.Today.Day Mod 3)) = f Then
                If My.Computer.Network.IsAvailable Then
                    Dim ans = MsgBox("Google is your friend.", 2, "I know", "How so?")
                    If ans = 7 Then Process.Start("https://www.google.com/search?q=pokemon+liberty+ticket+distribution+rom")
                End If
            Else
                MsgBox("Google is your friend.", 1, "OK")
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
#Region "Menu"
    Private Sub Tscb_Region_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscb_Region.SelectedIndexChanged
        My.Settings.Region = tscb_Region.SelectedIndex
    End Sub

    Private Sub Tsmi_About_Click(sender As Object, e As EventArgs) Handles tsmi_About.Click
        About.ShowDialog()
    End Sub

    'Donate within the Options tab
    Private Sub ToolStripMenuItem2_MouseHover(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.MouseHover
        ToolStripMenuItem2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    End Sub
    Private Sub ToolStripMenuItem2_MouseLeave(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.MouseLeave
        ToolStripMenuItem2.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub
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
        tc_Cards.SelectedTab = NewTab
        cb_Region.SelectedIndex = My.Settings.Region
        SyncRegion()
    End Sub

    'Moves the panel and load the settings
    Private Sub MovePanel()
        tc_Cards.SelectedTab.Controls.Add(Me.pnl_EditCard)
        With pn_Settings
            lb_PGF.Text = .pnl_Strings(tc_Cards.SelectedIndex)
            Select Case .pnl_Strings(tc_Cards.SelectedIndex)
                Case ""
                    EnDisAble(False)
                Case Else
                    EnDisAble(True)
            End Select
            rtb_EventMsg.Text = .pnl_Strings(tc_Cards.SelectedIndex + 8)
            cb_Region.SelectedIndex = .region(tc_Cards.SelectedIndex)
            SyncRegion()
            If .dates(tc_Cards.SelectedIndex) <> Nothing Then StartDatePicker.Value = .dates(tc_Cards.SelectedIndex)
            If .dates(tc_Cards.SelectedIndex + 8) <> Nothing Then EndDatePicker.Value = .dates(tc_Cards.SelectedIndex + 8)
            cb_MaxLimit.Checked = .maxLimit(tc_Cards.SelectedIndex)
        End With
        If doneLoad Then
            cb_Black.Checked = Card.Black(tc_Cards.SelectedIndex)
            cb_White.Checked = Card.White(tc_Cards.SelectedIndex)
            cb_Black2.Checked = Card.Black2(tc_Cards.SelectedIndex)
            cb_White2.Checked = Card.White2(tc_Cards.SelectedIndex)
        End If
    End Sub

    'Saves Panel settings
    Private Sub SavePanel()
        With pn_Settings
            .pnl_Strings(tc_Cards.SelectedIndex) = lb_PGF.Text
            .pnl_Strings(tc_Cards.SelectedIndex + 8) = rtb_EventMsg.Text
            .region(tc_Cards.SelectedIndex) = cb_Region.SelectedIndex
            If doneLoad Then .dates(tc_Cards.SelectedIndex) = StartDatePicker.Value
            If doneLoad Then .dates(tc_Cards.SelectedIndex + 8) = EndDatePicker.Value
            .maxLimit(tc_Cards.SelectedIndex) = cb_MaxLimit.Checked
        End With
    End Sub

    'Panel Settings
    Private Class Pnl_Settings
        Public pnl_Strings(15) As String
        Public maxLimit(7) As Boolean
        Public region(7) As Byte
        Public dates(15) As Date
    End Class
#End Region
#Region "Controls"
    Private Sub Bt_PGF_Click(sender As Object, e As EventArgs) Handles bt_PGF.Click
        OpenFile.Filter = "Gen 5 Wondercard (*.pgf)|*.pgf;*.wc5|All files (*.*)|*.*"
        Dim res As DialogResult = OpenFile.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            Dim myFile As String = Path.GetFileName(OpenFile.FileName)
            lb_PGF.Text = myFile
            WC.Data = File.ReadAllBytes(OpenFile.FileName)
            With WC
                .RecieveDay = 0
                .RecieveMonth = 0
                .RecieveYear = 0
            End With
            Card.Wondercards(tc_Cards.SelectedIndex) = WC.Data
            WC = New PGF
        End If
        EnDisAble(True)
        bt_Build.Enabled = True
    End Sub

    Private Sub Bt_Custom_Click(sender As Object, e As EventArgs) Handles bt_Custom.Click
        PGFCreator.ShowDialog()
        Select Case lb_PGF.Text
            Case "", Nothing
            Case Else
                EnDisAble(True)
                bt_Build.Enabled = True
        End Select
    End Sub

    Private Sub EnDisAble(Enable As Boolean)
        gb_GameComp.Enabled = Enable
        gb_Region.Enabled = Enable
        gb_DateLimit.Enabled = Enable
        rtb_EventMsg.Enabled = Enable
        lb_EventMsg.Enabled = Enable
    End Sub

    Private Sub Cb_Black_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Black.CheckedChanged
        Select Case cb_Black.Checked
            Case True
                Card.Black(tc_Cards.SelectedIndex) = True
            Case False
                Card.Black(tc_Cards.SelectedIndex) = False
        End Select
    End Sub
    Private Sub Cb_White_CheckedChanged(sender As Object, e As EventArgs) Handles cb_White.CheckedChanged
        Select Case cb_White.Checked
            Case True
                Card.White(tc_Cards.SelectedIndex) = True
            Case False
                Card.White(tc_Cards.SelectedIndex) = False
        End Select
    End Sub
    Private Sub Cb_Black2_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Black2.CheckedChanged
        Select Case cb_Black2.Checked
            Case True
                Card.Black2(tc_Cards.SelectedIndex) = True
            Case False
                Card.Black2(tc_Cards.SelectedIndex) = False
        End Select
    End Sub
    Private Sub Cb_White2_CheckedChanged(sender As Object, e As EventArgs) Handles cb_White2.CheckedChanged
        Select Case cb_White2.Checked
            Case True
                Card.White2(tc_Cards.SelectedIndex) = True
            Case False
                Card.White2(tc_Cards.SelectedIndex) = False
        End Select
    End Sub

    Private Sub Cb_Region_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Region.SelectedIndexChanged
        If doneLoad Then SyncRegion()
    End Sub
    Private Sub SyncRegion()
        Select Case cb_Region.SelectedIndex
            Case < 5
                Card.LangChecksum(tc_Cards.SelectedIndex) = langCksm(cb_Region.SelectedIndex)
                Card.Language(tc_Cards.SelectedIndex) = langs(cb_Region.SelectedIndex)
            Case 5
                Card.LangChecksum(tc_Cards.SelectedIndex) = langCksm(cb_Region.SelectedIndex)
                Card.Language(tc_Cards.SelectedIndex) = langs(0)
            Case Else
                Card.LangChecksum(tc_Cards.SelectedIndex) = langCksm(cb_Region.SelectedIndex - 1)
                Card.Language(tc_Cards.SelectedIndex) = langs(0)
        End Select
    End Sub
    Private Sub StartDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles StartDatePicker.ValueChanged, cb_MaxLimit.CheckedChanged
        If doneLoad Then
            Card.StartDays(tc_Cards.SelectedIndex) = StartDatePicker.Value.Day
            Card.StartMonths(tc_Cards.SelectedIndex) = StartDatePicker.Value.Month
            Card.StartYears(tc_Cards.SelectedIndex) = StartDatePicker.Value.Year
        End If
    End Sub

    Private Sub EndDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles EndDatePicker.ValueChanged, cb_MaxLimit.CheckedChanged
        If doneLoad Then
            Card.EndDays(tc_Cards.SelectedIndex) = EndDatePicker.Value.Day
            Card.EndMonths(tc_Cards.SelectedIndex) = EndDatePicker.Value.Month
            Card.EndYears(tc_Cards.SelectedIndex) = EndDatePicker.Value.Year
        End If
    End Sub

    Private Sub Cb_MaxLimit_CheckedChanged(sender As Object, e As EventArgs) Handles cb_MaxLimit.CheckedChanged
        Select Case cb_MaxLimit.Checked
            Case True
                lb_Start.Enabled = False
                lb_End.Enabled = False
                pn_Settings.dates(tc_Cards.SelectedIndex) = StartDatePicker.Value
                pn_Settings.dates(tc_Cards.SelectedIndex + 8) = EndDatePicker.Value
                StartDatePicker.Value = New DateTime(1753, 1, 1)
                EndDatePicker.Value = New DateTime(9998, 12, 31)
                StartDatePicker.Enabled = False
                EndDatePicker.Enabled = False
            Case False
                lb_Start.Enabled = True
                lb_End.Enabled = True
                If pn_Settings.dates(tc_Cards.SelectedIndex) <> Nothing Then StartDatePicker.Value = pn_Settings.dates(tc_Cards.SelectedIndex)
                If pn_Settings.dates(tc_Cards.SelectedIndex + 8) <> Nothing Then EndDatePicker.Value = pn_Settings.dates(tc_Cards.SelectedIndex + 8)
                StartDatePicker.Enabled = True
                EndDatePicker.Enabled = True
        End Select
    End Sub

    Private Sub Rtb_EventMsg_TextChanged(sender As Object, e As EventArgs) Handles rtb_EventMsg.TextChanged
        Card.EventText(tc_Cards.SelectedIndex) = rtb_EventMsg.Text.Replace(vbLf, ChrW(&HFFFE))
    End Sub

    Private Sub Bt_Build_Click(sender As Object, e As EventArgs) Handles bt_Build.Click
        File.WriteAllBytes(Local & "\outputCard.bin", Card.Data)
        Try
            Process.Start(Local & "\tools\extract.bat").WaitForExit()
            If File.Exists(Local & "\tools\data\data.bin") Then File.Delete(Local & "\tools\data\data.bin")
            File.Copy(Local & "\outputCard.bin", Local & "\tools\data\data.bin")
            Process.Start(Local & "\tools\compile.bat").WaitForExit()
            Process.Start(Local & "\tools\clean.bat").WaitForExit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SaveFile.Filter = "NDS ROM (*.nds)|*.nds|All files (*.*)|*.*"
        Dim res As DialogResult = SaveFile.ShowDialog()
        If res <> Windows.Forms.DialogResult.Cancel Then
            If File.Exists(SaveFile.FileName) Then File.Delete(SaveFile.FileName)
            File.Move(Local & "\ticket2.nds", SaveFile.FileName)
        End If
    End Sub
#End Region
End Class