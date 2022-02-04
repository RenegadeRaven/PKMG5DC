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
    Dim doneLoad As Boolean = False 'Has Load finished?
    Dim WC As New PGF 'Wondercard
    Public Shared Card As New Card5 'Distro Card
    Public ToolVer As String = Application.ProductVersion
    Public Shared customName As String
    Dim currItem As Integer
    Dim selectedLang(11) As Integer
    Dim multipleCardsArr(11)
    Dim TempCard As New Card5
#End Region

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckLocal()
        CheckTicket()
        UpdateChk()
        Dim tools As Object = {
            {"\tools\ndstool.exe", My.Resources.ndstool},
            {"\tools\armips.exe", My.Resources.armips},
            {"\tools\options.asm", My.Resources.optionsasm},
            {"\tools\12distro.asm", My.Resources._12distroasm},
            {
                "\tools\firstBatch.bat",
                "C:" & Environment.NewLine &
                "cd " & Local & "\tools" & Environment.NewLine &
                "armips.exe 12distro.asm -erroronwarning" & Environment.NewLine &
                "ndstool.exe -c 12distro.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin" & Environment.NewLine &
                "rd /S/Q data" & Environment.NewLine &
                "del arm9.bin arm7.bin banner.bin header.bin" & Environment.NewLine &
                "ndstool.exe -x 12distro.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin"
            },
            {
                "\tools\secondBatch.bat",
                "C:" & Environment.NewLine &
                "cd " & Local & "\tools" & Environment.NewLine &
                "ndstool.exe -c ..\ticket2.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin" & Environment.NewLine &
                "rd /S/Q data" & Environment.NewLine &
                "del arm9.bin arm7.bin banner.bin header.bin"
            },
            {
                "\tools\extract.bat",
                "C:" & Environment.NewLine &
                "cd " & Local & "\tools" & Environment.NewLine &
                "ndstool.exe -x ..\ticket.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin"
            }
        }

        If ToolVer <> Application.ProductVersion Then Directory.Delete(Local & "\tools", True)

        CheckLocal()
        CreateFiles(tools)
        ToolVer = Application.ProductVersion
        doneLoad = True
        StateChanger(False)
        bt_Build.Enabled = False
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        WriteSettings()
    End Sub

#Region "Essentials"
    'Checks For Update
    Private Sub UpdateChk()
        If File.Exists(TempPath & "\vsn.txt") Then File.Delete(TempPath & "\vsn.txt")
        If File.Exists(TempPath & "\dt.txt") Then File.Delete(TempPath & "\dt.txt")
    End Sub

    'Link to Update version
    Private Sub Lklb_Update_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_Update.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://github.com/PlasticJustice/PKMG5DC/releases/latest")
        Else
            MsgBox("No Internet connection!" & Environment.NewLine & "You can not update at the moment.", vbOKOnly, "Error 404")
        End If
    End Sub

    'Link the Author's, yours truly, Github Page
    Private Sub Lklb_Author_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_Author.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://github.com/PlasticJustice")
        Else
            MsgBox("No Internet connection!" & Environment.NewLine & "You can look me up later.", 1, "OK",,, "Error" & " 404")
        End If
    End Sub

    'PayPal Donate Button
    Private Sub Pb_Donate_Click(sender As Object, e As EventArgs) Handles pb_Donate.Click
        System.Threading.Thread.Sleep(200)
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UGSCC5VGSGN3E")
        Else
            MsgBox("No Internet connection!" & Environment.NewLine & "I appreciate the gesture.", 1, "OK",,, "Error" & " 404")
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
        Dim locals As String() = {Local.Replace("\PKMG5DC", ""), Local, Local & "\tools"}
        CreateFolders(locals)

        If File.Exists(Local & "\settings.ini") Then
            ReadIni()
            File.Delete(Local & "\settings.ini")
        End If
        If Not File.Exists(Local & "\settings.json") Then
            WriteSettings()
        End If

        ReadSettings()
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
        Else
            WriteSettings()
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
#End Region

#Region "Menu"
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

#Region "Controls"
    'Check if combobox has changed and update form
    Private Sub cb_Cards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Cards.SelectedIndexChanged
        currItem = cb_Cards.SelectedIndex()
        Card = multipleCardsArr(currItem)

        rtb_EventTitle.Text = Card.EventTitle(0)
        rtb_EventMsg.Text = Card.EventText(0)
        lb_CharCountNumber.Text = rtb_EventMsg.TextLength

        StartDatePicker.Value = New DateTime(Card.StartYears(0), Card.StartMonths(0), Card.StartDays(0))
        EndDatePicker.Value = New DateTime(Card.EndYears(0), Card.EndMonths(0), Card.EndDays(0))

        cb_MaxLimit.Checked = False

        cb_Black.Checked = Card.Black(0)
        cb_White.Checked = Card.White(0)
        cb_Black2.Checked = Card.Black2(0)
        cb_White2.Checked = Card.White2(0)

        cb_Region.SelectedIndex = selectedLang(currItem)

        multipleCardsArr(currItem) = Card
        Card = New Card5
    End Sub

    Private Sub StateChanger(Enable As Boolean)
        gb_Cards.Enabled = Enable
        gb_GameComp.Enabled = Enable
        gb_Region.Enabled = Enable
        gb_DateLimit.Enabled = Enable
        gb_Text.Enabled = Enable
        bt_Build.Enabled = Enable
    End Sub

    'Handles PGF cards
    Private Sub Bt_PGF_Click(sender As Object, e As EventArgs) Handles bt_PGF.Click
        OpenFile.Filter = "Gen 5 Wondercard (*.pgf)|*.pgf;*.wc5|All files (*.*)|*.*"
        Dim res As DialogResult = OpenFile.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            Card = New Card5
            Dim myFile As String = Path.GetFileName(OpenFile.FileName)
            WC.Data = File.ReadAllBytes(OpenFile.FileName)
            With WC
                .ReceiveDay = 0
                .ReceiveMonth = 0
                .ReceiveYear = 0
            End With
            Card.Wondercards(0) = WC.Data
            Card.NumberOfCards = 1

            rtb_EventTitle.Text = ""
            rtb_EventMsg.Text = ""

            WC = New PGF

            If cb_Cards.SelectedIndex() = -1 Then
                multipleCardsArr(cb_Cards.Items.Count) = Card
            ElseIf cb_Cards.SelectedIndex() <> cb_Cards.Items.Count - 1 Then
                multipleCardsArr(cb_Cards.Items.Count) = Card
            Else
                multipleCardsArr(cb_Cards.SelectedIndex() + 1) = Card
            End If

            cb_Cards.SelectedIndex = cb_Cards.Items.Add(myFile)

            If cb_Cards.Items.Count = 12 Then
                bt_PGF.Enabled = False
                bt_Custom.Enabled = False
            End If
        End If
        StateChanger(True)
    End Sub

    'Handles custom pokemon
    Private Sub Bt_Custom_Click(sender As Object, e As EventArgs) Handles bt_Custom.Click
        Card = New Card5

        Dim res As DialogResult = PGFCreator.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            Card.NumberOfCards = 1

            rtb_EventTitle.Text = ""
            rtb_EventMsg.Text = ""

            If cb_Cards.SelectedIndex() = -1 Then
                multipleCardsArr(cb_Cards.Items.Count) = Card
                cb_Cards.SelectedIndex = cb_Cards.Items.Add(customName)
            ElseIf cb_Cards.SelectedIndex() <> cb_Cards.Items.Count - 1 Then
                multipleCardsArr(cb_Cards.Items.Count) = Card
                cb_Cards.SelectedIndex = cb_Cards.Items.Add(customName)
            Else
                multipleCardsArr(cb_Cards.SelectedIndex() + 1) = Card
                cb_Cards.SelectedIndex = cb_Cards.Items.Add(customName)
            End If

            If cb_Cards.Items.Count = 12 Then
                bt_PGF.Enabled = False
                bt_Custom.Enabled = False
            End If
        End If
        StateChanger(True)
    End Sub

    'Set and reset states
    Private Sub bt_SetRegion_Click(sender As Object, e As EventArgs) Handles bt_SetRegion.Click
        Card = multipleCardsArr(currItem)
        SyncRegion()
        multipleCardsArr(currItem) = Card
    End Sub

    Private Sub SyncRegion()
        selectedLang(currItem) = cb_Region.SelectedIndex
        Select Case cb_Region.SelectedIndex
            Case < 5
                Card.LangChecksum(0) = langCksm(cb_Region.SelectedIndex)
                Card.Language(0) = langs(cb_Region.SelectedIndex)
            Case 5
                Card.LangChecksum(0) = langCksm(cb_Region.SelectedIndex)
                Card.Language(0) = langs(0)
            Case Else
                Card.LangChecksum(0) = langCksm(cb_Region.SelectedIndex - 1)
                Card.Language(0) = langs(0)
        End Select
    End Sub

    Private Sub bt_ResetRegion_Click(sender As Object, e As EventArgs) Handles bt_ResetRegion.Click
        Card = multipleCardsArr(currItem)
        cb_Region.SelectedIndex = 0
        Card.LangChecksum(0) = langCksm(0)
        Card.Language(0) = langs(0)
        multipleCardsArr(currItem) = Card
    End Sub

    Private Sub bt_SetCompatibility_Click(sender As Object, e As EventArgs) Handles bt_SetCompatibility.Click
        Card = multipleCardsArr(currItem)
        Card.Black(0) = cb_Black.Checked
        Card.White(0) = cb_White.Checked
        Card.Black2(0) = cb_Black2.Checked
        Card.White2(0) = cb_White2.Checked
        multipleCardsArr(currItem) = Card
    End Sub

    Private Sub bt_ResetCompatibility_Click(sender As Object, e As EventArgs) Handles bt_ResetCompatibility.Click
        Card = multipleCardsArr(currItem)
        Card.Black(0) = False
        cb_Black.Checked = False

        Card.White(0) = False
        cb_White.Checked = False

        Card.Black2(0) = False
        cb_Black2.Checked = False

        Card.White2(0) = False
        cb_White2.Checked = False
        multipleCardsArr(currItem) = Card
    End Sub

    Private Sub bt_SetDate_Click(sender As Object, e As EventArgs) Handles bt_SetDate.Click
        Card = multipleCardsArr(currItem)
        'Set Start Date if user changed anything
        Card.StartDays(0) = StartDatePicker.Value.Day
        Card.StartMonths(0) = StartDatePicker.Value.Month
        Card.StartYears(0) = StartDatePicker.Value.Year

        'Set End Date if user changed anything
        Card.EndDays(0) = EndDatePicker.Value.Day
        Card.EndMonths(0) = EndDatePicker.Value.Month
        Card.EndYears(0) = EndDatePicker.Value.Year
        multipleCardsArr(currItem) = Card
    End Sub

    Private Sub bt_ResetDate_Click(sender As Object, e As EventArgs) Handles bt_ResetDate.Click
        Card = multipleCardsArr(currItem)
        If cb_MaxLimit.Checked Then
            cb_MaxLimit.Checked = False
        End If

        StartDatePicker.Value = Date.Today
        EndDatePicker.Value = Date.Today
        Card.StartDays(0) = Date.Today.Day
        Card.StartMonths(0) = Date.Today.Month
        Card.StartYears(0) = Date.Today.Year
        Card.EndDays(0) = Date.Today.Day
        Card.EndMonths(0) = Date.Today.Month
        Card.EndYears(0) = Date.Today.Year
        multipleCardsArr(currItem) = Card
    End Sub

    Private Sub Cb_MaxLimit_CheckedChanged(sender As Object, e As EventArgs) Handles cb_MaxLimit.CheckedChanged
        'Set Min Start Date and Max End Date if user marked checkbox
        Select Case cb_MaxLimit.Checked
            Case True
                lb_Start.Enabled = False
                lb_End.Enabled = False
                StartDatePicker.Value = New DateTime(1753, 1, 1)
                EndDatePicker.Value = New DateTime(9998, 12, 31)
                StartDatePicker.Enabled = False
                EndDatePicker.Enabled = False
            Case False
                lb_Start.Enabled = True
                lb_End.Enabled = True
                StartDatePicker.Enabled = True
                EndDatePicker.Enabled = True
        End Select
    End Sub

    Private Sub rtb_EventMsg_TextChanged(sender As Object, e As EventArgs) Handles rtb_EventMsg.TextChanged
        lb_CharCountNumber.Text = rtb_EventMsg.TextLength
    End Sub

    Private Sub bt_SetEventMsg_Click(sender As Object, e As EventArgs) Handles bt_SetEventMsg.Click
        Card = multipleCardsArr(currItem)
        'Set event text if user pressed button
        Card.EventTitle(0) = rtb_EventTitle.Text.Replace(vbLf, ChrW(&HFFFE))
        Card.EventText(0) = rtb_EventMsg.Text.Replace(vbLf, ChrW(&HFFFE))
        multipleCardsArr(currItem) = Card
    End Sub

    Private Sub bt_ResetEventMsg_Click(sender As Object, e As EventArgs) Handles bt_ResetEventMsg.Click
        Card = multipleCardsArr(currItem)
        'Reset event text if user pressed button
        rtb_EventTitle.Text = "Event title here!"
        rtb_EventMsg.Text = ""
        Card.EventTitle(0) = "Event title here!"
        Card.EventText(0) = ""
        multipleCardsArr(currItem) = Card
    End Sub

    'Build ROM
    Private Sub Bt_Build_Click(sender As Object, e As EventArgs) Handles bt_Build.Click
        'Verify if the text inside textbox is empty then set all the bytes to FF
        For index As Integer = 1 To cb_Cards.Items.Count
            Card = multipleCardsArr(index - 1)
            Dim text As String = Card.EventText(0)

            If text.Length < 1 Or text.Contains(vbNullChar) Then
                Card.EventText(0) = ""
            End If

            'Create binary based on selected wondercard
            If index < 10 Then
                File.WriteAllBytes(Local & "\0" & index & ".bin", Card.Data)
            Else
                File.WriteAllBytes(Local & "\" & index & ".bin", Card.Data)
            End If
        Next

        'Edit assembly file based on user input
        Dim options = File.ReadAllLines(Local & "\tools\options.asm")
        options(1) = ".definelabel amount," & cb_Cards.Items.Count
        File.WriteAllLines(Local & "\tools\options.asm", options)

        'Decompile and compile ROM based on wondercard
        Try
            Process.Start(Local & "\tools\extract.bat").WaitForExit()
            If File.Exists(Local & "\tools\data\data.bin") Then File.Delete(Local & "\tools\data\data.bin")
            Process.Start(Local & "\tools\firstBatch.bat").WaitForExit()
            For index As Integer = 1 To cb_Cards.Items.Count
                If index < 10 Then
                    File.Copy(Local & "\0" & index & ".bin", Local & "\tools\data\0" & index & ".bin")
                Else
                    File.Copy(Local & "\" & index & ".bin", Local & "\tools\data\" & index & ".bin")
                End If
            Next
            Process.Start(Local & "\tools\secondBatch.bat").WaitForExit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Save generated file
        SaveFile.Filter = "NDS ROM (*.nds)|*.nds|All files (*.*)|*.*"
        Dim res As DialogResult = SaveFile.ShowDialog()
        If res <> Windows.Forms.DialogResult.Cancel Then
            If File.Exists(SaveFile.FileName) Then File.Delete(SaveFile.FileName)
            File.Move(Local & "\ticket2.nds", SaveFile.FileName)
            MsgBox("Your file has been saved successfully!", 1, "OK", "", "", "File saved")
        End If
    End Sub
#End Region
End Class