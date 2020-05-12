Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Main
#Region "Variables"
    Dim apppath As String = My.Application.Info.DirectoryPath 'Path to .exe directory
    Dim res As String = Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") 'Path to Project Resources
    Dim TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp" 'Path to Temp
    Public Shared Local As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Regnum\PKMG5DC" 'Path to Local folder
    Dim Gen As Byte = 5
    Dim card1 As New Card5
    Dim langCksm As UShort() = {&H83BC, &H9D36, &H39AA, &H4418, &HE061, &HF57A}
    Dim langs As Byte() = {&H2, &H3, &H4, &H5, &H6}
#End Region

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CheckGen()
        CheckLocal()
        CheckTicket()
        UpdateChk()
        Dim pgf As String = "3E0200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000470065007400200074006800650020004C00690062006500720074007900200050006100730073002100FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000403DB07FE074402010000000000000000000000000000000000000000000000"
        ''''
        With card1
            .numberOfCards = &H8
            .wonderCard = {pgf, pgf, pgf, pgf, pgf, pgf, pgf, pgf}
            .gameCompatability = {&HF0, &HC0, &H30, &H20, &H10, &HA0, &H50, &HD0}

            .language = {langs(0), langs(1), langs(2), langs(3), langs(4), langs(0), langs(0), &H8}
            .langChecksum = {langCksm(0), langCksm(1), langCksm(2), langCksm(3), langCksm(4), langCksm(5), langCksm(5), &HA986}
            .startYear = &H7E4
            .startMonth = &H3
            .startDay = &H14
            .endYear = .startYear + 1
            .endMonth = .startMonth
            .endDay = .startDay
        End With
        card1.endMonth = 4
        Output()
    End Sub
    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim myIniFile As New IniFile
        With myIniFile
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

    'Private Sub CheckGen()
    '    Dim n As String = Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule.FileName)
    '    If n.Contains("G4") Then
    '        Gen = 4
    '    Else
    '        Gen = 5
    '    End If
    'End Sub
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
        Dim locals As String() = {Local.Replace("\PKMG5DC", ""), Local, Local & "\tools"}
        CreateFolders(locals)
        File.WriteAllBytes(Local & "\Database.accdb", My.Resources.Database)
        If Not File.Exists(Local & "\settings.ini") Then
            File.Create(Local & "\settings.ini")
        End If
        Dim myIniFile As New IniFile
        With myIniFile
            .Filename = Local & "\settings.ini"
            If .OpenIniFile() Then
                My.Settings.ticket = .GetValue("Ticket")
                '.SetValue("Ticket", My.Settings.ticket)
                If Not .SaveIni Then
                    MessageBox.Show("Trouble by writing Ini-File")
                End If
            Else
                MessageBox.Show("No Ini-File found")
            End If
        End With
    End Sub
#End Region
#Region "Startup"
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
#End Region

    Private Sub Output()
        Dim cc As String = Hex_Zeros(Hex(card1.numberOfCards), 2) & "000000"
        For n = 0 To card1.numberOfCards - 1 Step 1
            cc &= card1.wonderCard(n) & "0000" & Hex(card1.gameCompatability(n)) & "00"
            For i = 0 To &H1F7 Step 1
                cc &= "FF"
            Next i
            cc &= "FFFF00" & Hex_Zeros(card1.language(n), 2) & "0000" & Little_Endian(Hex(card1.langChecksum(n)), 4)
        Next n
        For i = 0 To (&H13AF - ((card1.numberOfCards - 1) * &H2D0)) Step 1 '0x1eef
            cc &= "00"
        Next i
        For i = 0 To card1.numberOfCards - 1 Step 1
            cc &= Little_Endian(Hex(card1.startYear), 4) & Hex_Zeros(Hex(card1.startMonth), 2) & Hex_Zeros(Hex(card1.startDay), 2) &
        Little_Endian(Hex(card1.endYear), 4) & Hex_Zeros(Hex(card1.endMonth), 2) & Hex_Zeros(Hex(card1.endDay), 2)
        Next i
        For i = 0 To (&H3B - ((card1.numberOfCards - 1) * &H8)) Step 1 '0x5b
            cc &= "00"
        Next i
        cc &= "1400000000000000"
        RichTextBox1.Text = cc
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim tools(,) = {{"\tools\ndstool.exe", My.Resources.ndstool}, {"\tools\extract.bat", "cd " & Local & "\tools
ndstool.exe -x ..\ticket.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin"}, {"\tools\compile.bat", "cd " & Local & "\tools
ndstool.exe -c ..\ticket2.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin"}, {"\tools\clean.bat", "cd " & Local & "\tools
rd /S/Q data
del arm9.bin arm7.bin banner.bin header.bin"}}
            CreateFiles(tools)

            '            File.WriteAllBytes(Local & "\tools\ndstool.exe", My.Resources.ndstool)
            '            File.WriteAllText(Local & "\tools\extract.bat", "cd " & Local & "\tools
            'ndstool.exe -x ..\ticket.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin")
            '            File.WriteAllText(Local & "\tools\compile.bat", "cd " & Local & "\tools
            'ndstool.exe -c ..\ticket2.nds -9 arm9.bin -7 arm7.bin -d data -t banner.bin -h header.bin")
            '            File.WriteAllText(Local & "\tools\clean.bat", "cd " & Local & "\tools
            'rd /S/Q data
            'del arm9.bin arm7.bin banner.bin header.bin")
            Process.Start(Local & "\tools\extract.bat").WaitForExit()
            File.Delete(Local & "\tools\data\data.bin")
            Save(Local & "\tools\data\data.bin", RichTextBox1.Text)
            Process.Start(Local & "\tools\compile.bat").WaitForExit()
            Process.Start(Local & "\tools\clean.bat").WaitForExit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class