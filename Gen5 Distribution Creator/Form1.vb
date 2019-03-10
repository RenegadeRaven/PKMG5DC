Imports System.Threading
Public Class Form1
#Region "Variables"
    Dim appPath As String = My.Application.Info.DirectoryPath
    'Dim res As String = My.Resources.ResourceManager.BaseName
    Dim res As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
    Dim TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
    Dim Games(4) As Integer
    Dim dt As Boolean = False
    Dim temp_startDate As Date
    Dim temp_endDate As Date
    Dim hexRegion As String = My.Settings.Region
    Dim description As String
    Dim header As String
    Dim code As String

    Dim rtd As String = "Input Event Text Here.

This textbox is sized perfectly, so what fits in
this box is all you can fit. A maximum of 7 
lines, max 36 characters per line, and a 
maximum of 252 characters total.
Make sure you put the new lines(ENTER key)"
    Dim rdd As String = "Input Description Here.
This textbox is also sized perfectly.
4 lines, 24 chars/line, 96 chars.
Be sure to put the new lines again."
    Dim desd As String = "50h,6Fh,6Bh,0E9h,6Dh,6Fh,6Eh,0Ah,47h,65h,6Eh,65h,72h,61h,74h,69h,6Fh,6Eh,20h,35h,0Ah,43h,75h,73h,74h,6Fh,6Dh,20h,4Dh,61h,64h,65h,20h,44h,69h,73h,74h,72h,69h,62h,75h,74h,69h,6Fh,6Eh,0Ah,50h,4Bh,4Dh,47h,35h,44h,43h,0h"
    Dim headd As String = "50h,4Bh,4Dh,43h,55h,53h,54h,4Fh,4Dh,52h,4Fh,4Dh"
    Dim coded As String = "47h,35h,44h,43h"
    Dim Yes As String = "Yes"
    Dim No As String = "No"
    Dim tl As String = "Need Liberty Ticket ROM"
    Dim msl As String = "This program requires a clean copy of the Liberty Ticket Distribution ROM. Do you have one?"
#End Region
#Region "System Menu"
    Public Const WM_SYSCOMMAND As Int32 = &H112
    Public Const MF_BYPOSITION As Int32 = &H400
    Public Const MYMENU1 As Int32 = 1000
    Public Const MYMENU2 As Int32 = 1001
    'Public Const MYMENU3 As Int32 = 1002

    Dim hSysMenu As Integer

    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
    Public Declare Function InsertMenu Lib "user32" Alias "InsertMenuA" _
       (ByVal hMenu As IntPtr, ByVal nPosition As Integer, ByVal wFlags As Integer, ByVal wIDNewItem As Integer, ByVal lpNewItem As String) As Boolean

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If (m.Msg = WM_SYSCOMMAND) Then
            Select Case m.WParam.ToInt32
                Case MYMENU1
                    Dim about As New Form2
                    about.ShowDialog()
                Case MYMENU2
                    Dim options As New options
                    options.ShowDialog()
            End Select
        End If
    End Sub
#End Region 'Adds options to right-click titlebar
#Region "Startup"
    'Checks for Liberty Ticket Distribution ROM
    Private Sub Check_Ticket()
1:
        If System.IO.File.Exists(appPath & "/ticket.nds") Then
            Dim myFile As String = appPath & "/ticket.nds"
            Dim l = System.IO.File.ReadAllText(myFile)
            If l.Contains("POKWBLIBERTYY8KP01") Then
                My.Settings.ticket = appPath & "/ticket.nds"
            Else
                MsgB("Error: Invaild File", 1, "OK",,, "ERROR FOUND")
                Close()
            End If
        Else
            If My.Settings.ticket = appPath & "/ticket.nds" And System.IO.File.Exists(My.Settings.ticket) Then
                Dim myFile As String = My.Settings.ticket
                Dim l = System.IO.File.ReadAllText(myFile)
                If l.Contains("POKWBLIBERTYY8KP01") Then
                Else
                    MsgB("Error: Invaild File", 1, "OK",,, "ERROR FOUND")
                    Close()
                End If
            ElseIf My.Settings.ticket <> appPath & "/ticket.nds" And My.Settings.ticket <> Nothing And System.IO.File.Exists(My.Settings.ticket) Then
                Dim myFile As String = My.Settings.ticket
                If System.IO.File.Exists(appPath & "/ticket.nds") Then
                    System.IO.File.Delete(appPath & "/ticket.nds")
                End If
                System.IO.File.Copy(myFile, appPath & "/ticket.nds")
                My.Settings.ticket = appPath & "/ticket.nds"
            ElseIf My.Settings.ticket <> Nothing And (System.IO.File.Exists(My.Settings.ticket) = False) Then
                My.Settings.ticket = Nothing
                GoTo 1
            ElseIf My.Settings.ticket = Nothing Then
                Dim ans = MsgB(msl, 2, Yes, No,, tl)
                Select Case ans
                    Case 6
                        ans = MsgB("Can you select it for me?", 2, "Yeah, it's right here", "Umm, I don't know where I put it",, tl)
                        Select Case ans
                            Case 6
                                Dim FileSelect As New OpenFileDialog With {
                                .Filter = "Event ROM (*.nds)|*.nds|All files (*.*)|*.*"}
                                Dim res As DialogResult = FileSelect.ShowDialog()
                                If res = Windows.Forms.DialogResult.Cancel Then
                                    Close()
                                Else
                                    Dim myFile As String = FileSelect.FileName
                                    Dim l = System.IO.File.ReadAllText(myFile)
                                    If l.Contains("POKWBLIBERTYY8KP01") Then
                                        If System.IO.File.Exists(appPath & "/ticket.nds") Then
                                            System.IO.File.Delete(appPath & "/ticket.nds")
                                        End If
                                        System.IO.File.Copy(myFile, appPath & "/ticket.nds")
                                        My.Settings.ticket = appPath & "/ticket.nds"
                                    Else
                                        MsgB("Error: Invaild File", 1, "OK",,, "ERROR FOUND")
                                        Close()
                                    End If
                                End If
                            Case 7
                                Close()
                        End Select
                    Case 7
                        DeSmuME_Check()
                        Close()
                End Select
            End If
        End If
    End Sub

    'Checks if DeSmuME is installed
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

    'Set Language
    Private Sub Lang()
        Select Case My.Settings.Language
            Case "E"
                RadioButton1.PerformClick()
            Case "F"
                RadioButton2.PerformClick()
            Case "I"
                RadioButton3.PerformClick()
            Case "G"
                RadioButton4.PerformClick()
            Case "S"
                RadioButton5.PerformClick()
            Case "J"
                RadioButton6.PerformClick()
            Case "K"
                RadioButton7.PerformClick()
        End Select
    End Sub

    'Checks for, well what do you know, Updates
    Private Sub Check_Updates()
        If My.Computer.Network.IsAvailable Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/master/Gen5%20Distribution%20Creator/Resources/date.txt", TempPath & "\PKMG5DC-dt.txt")
            Dim Reader As New IO.StreamReader(TempPath & "\PKMG5DC-dt.txt")
            Dim dtt As String = Reader.ReadToEnd
            Reader.Close()
            System.IO.File.Delete(TempPath & "\PKMG5DC-dt.txt")
            Dim dat As String = System.IO.File.ReadAllText(TempPath & "\PKMG5DC-date.txt")
            If dat <> dtt Then
                LinkLabel1.Text = "New Update Available! " & dtt
                LinkLabel1.Show()
            Else
                LinkLabel1.Hide()
            End If
        Else
            LinkLabel1.Hide()
        End If
    End Sub

    'Startup
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check_Ticket()
        If System.IO.File.Exists(TempPath & "\PKMG5DC-vsn.txt") Then
            System.IO.File.Delete(TempPath & "\PKMG5DC-vsn.txt")
        End If
        If System.IO.File.Exists(TempPath & "\PKMG5DC-date.txt") Then
            System.IO.File.Delete(TempPath & "\PKMG5DC-date.txt")
        End If
        If System.IO.File.Exists(TempPath & "\PKMG5DC-dt.txt") Then
            System.IO.File.Delete(TempPath & "\PKMG5DC-dt.txt")
        End If
#If DEBUG Then
        Size = New Size(838, 490)
        System.IO.File.WriteAllText(appPath & "/version.txt", My.Application.Info.Version.ToString)
        System.IO.File.WriteAllText(appPath & "/version.json", "{
" & ControlChars.Quote & "version" & ControlChars.Quote & ": " & ControlChars.Quote & My.Application.Info.Version.ToString & ControlChars.Quote & "
}")
        If My.Computer.Network.IsAvailable Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/master/Gen5%20Distribution%20Creator/bin/Debug/version.txt", TempPath & "\PKMG5DC-vsn.txt")
            Dim Reader As New IO.StreamReader(TempPath & "\PKMG5DC-vsn.txt")
            Dim v As String = Reader.ReadToEnd
            Reader.Close()
            System.IO.File.Delete(TempPath & "\PKMG5DC-vsn.txt")
            If Application.ProductVersion <> v Then
                System.IO.File.WriteAllText(res & "/PKMG5DC-date.txt", (System.DateTime.Today.Year & "/" & System.DateTime.Today.Month & "/" & System.DateTime.Today.Day))
            End If
        End If
        LinkLabel1.Hide()
        Button7.Text = "<<"
#Else
        Size = New Size(452, 490)
        Me.CenterToScreen()
        Label13.Hide()
        Label1.Hide()
        System.IO.File.WriteAllText(TempPath & "\PKMG5DC-date.txt", My.Resources._date)
        Dim dat As String = System.IO.File.ReadAllText(TempPath & "\PKMG5DC-date.txt")
        Me.Text = "Gen 5 Distribution Creator (" & dat & ")"
        Check_Updates()
        System.IO.File.Delete(TempPath & "\PKMG5DC-date.txt")
#End If
        'Button4.Location = New Point(296, 296)
        Initial()
        dt = True
        Lang()
        SetRegion()
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True

        Dim Pth As New System.Drawing.Drawing2D.GraphicsPath
        Pth.AddEllipse(New Rectangle(5, 3, 17, 17))
        Dim Regb As New Region(Pth)
        Button7.Region = Regb
        Pth.Dispose()
        Regb.Dispose()

        'LinkLabel1.Hide()
        hSysMenu = GetSystemMenu(Me.Handle, False)
        InsertMenu(hSysMenu, 5.5, MF_BYPOSITION, MYMENU1, "About...")
        InsertMenu(hSysMenu, 6, MF_BYPOSITION, MYMENU2, "Options...")
    End Sub

    'Snaps to to preset sizes when being resize
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.Size.Height <> 490 Then
            Size = New Size(Me.Size.Width, 490)
        End If
        If Me.Size.Width < 452 Then
            Size = New Size(452, Me.Size.Height)

        ElseIf Me.Size.Width > 838 Then
            Size = New Size(838, Me.Size.Height)
        End If
    End Sub

    'Creates initial file
    Private Sub Initial()
        Dim Str As String = Nothing
        For n = 0 To 17503 Step 1
            Str = Str & "0"
        Next n
        RichTextBox1.Text = Str
        RichTextBox1.Text = RichTextBox1.Text.Remove(1, 1)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1, "1")
        RichTextBox1.Text = RichTextBox1.Text.Remove((RichTextBox1.Text.Length - 16), 2)
        RichTextBox1.Text = RichTextBox1.Text.Insert((RichTextBox1.Text.Length - 16), "14")
        RichTextBox1.Text = RichTextBox1.Text.Remove(1438, 2)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1438, "02")
        DateTimePicker1.Value = System.DateTime.Today
        DateTimePicker2.Value = System.DateTime.Today
        DateLimit()
        Dim tempStr As String = ""
        For i = 0 To 1011 Step 1
            tempStr = tempStr & "F"
        Next i
        RichTextBox1.Text = RichTextBox1.Text.Remove(424, 1012)
        RichTextBox1.Text = RichTextBox1.Text.Insert(424, tempStr)
    End Sub

    'Sets the, if it wasn't clear enough, Date Limit
    Private Sub DateLimit()
        Dim startDay As String = Hex_Zeros(Hex(DateTimePicker1.Value.Date.Day), 2)
        Dim startMonth As String = Hex_Zeros(Hex(DateTimePicker1.Value.Date.Month), 2)
        Dim startYear As String = Little_Endian(Hex(DateTimePicker1.Value.Date.Year), 4)
        Dim endDay As String = Hex_Zeros(Hex(DateTimePicker2.Value.Date.Day), 2)
        Dim endMonth As String = Hex_Zeros(Hex(DateTimePicker2.Value.Date.Month), 2)
        Dim endYear As String = Little_Endian(Hex(DateTimePicker2.Value.Date.Year), 4)
        RichTextBox1.Text = RichTextBox1.Text.Remove(17288, 16)
        RichTextBox1.Text = RichTextBox1.Text.Insert(17288, (startYear & startMonth & startDay & endYear & endMonth & endDay))
    End Sub
#End Region
#Region "Functions"
    'Custom MsgBox
    Private Function MsgB(ByVal mes As String, Optional ByVal numB As Integer = 1, Optional ByVal but1 As String = "OK", Optional ByVal but2 As String = "Cancel", Optional ByVal but3 As String = "", Optional ByVal head As String = "")
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
            Close()
        End If
        Return Ans
    End Function

    'Adds needed zeros to hex string
    Private Function Hex_Zeros(ByVal hex_value As String, ByVal length As Integer)
        Dim Str As String = hex_value.ToUpper
        Do While Str.Length < length
            Str = "0" & Str
        Loop
        Return Str
    End Function

    'Encrypts hex string with, you guessed it, Little Endian
    Private Function Little_Endian(ByVal hex_value As String, ByVal length As Integer)
        Dim startStr As String = Hex_Zeros(hex_value, length)
        Dim endStr As String = Nothing
        If length = 8 Then
            endStr = startStr.Skip(6).ToArray() & startStr.Remove(6, 2).ToArray().Skip(4).ToArray() & startStr.Remove(4, 4).ToArray().Skip(2).ToArray() & startStr.Remove(2, 6).ToArray()
        ElseIf length = 4 Then
            endStr = startStr.Skip(2).ToArray() & startStr.Remove(2, 2).ToArray()
        End If
        Return endStr
    End Function
#End Region
#Region "Syncs"
    'Changes compatable game(s)
    Private Sub Game_compatability()
        Games(4) = (Games(0) Xor Games(1) Xor Games(2) Xor Games(3))
        Dim hexStr As String = Hex_Zeros(Hex(Games(4)), 2)
        RichTextBox1.Text = RichTextBox1.Text.Remove(420, 2)
        RichTextBox1.Text = RichTextBox1.Text.Insert(420, hexStr)
    End Sub

    'Sets Region
    Private Sub SetRegion()
        RichTextBox1.Text = RichTextBox1.Text.Remove(1438, 10)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1438, hexRegion)
    End Sub

    'Check length of the editor(RichTextBox) and makes sure it's the correct length
    Private Sub Edit_check(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Label1.Text = RichTextBox1.Text.Length & " / 17504"
        If RichTextBox1.Text.Length > 17504 Then
            Label1.ForeColor = Color.Red
            Label1.Font = New Font(Label1.Font, FontStyle.Bold)
        ElseIf RichTextBox1.Text.Length < 17504 Then
            Label1.ForeColor = Color.Indigo
            Label1.Font = New Font(Label1.Font, FontStyle.Bold)
        ElseIf RichTextBox1.Text.Length = 17504 Then
            Label1.ForeColor = Color.Green
            Label1.Font = New Font(Label1.Font, FontStyle.Regular)
        End If
    End Sub

    'Restricts Header input to valid characters
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 Then
                    If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region "Builder"
    'Build Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label2.Text = "Open .pgf ------->" Then
            MsgB("No .pgf file.", 1, "OK",,, "Error")
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False Then
            MsgB("No compatible game.", 1, "OK",,, "Error")
        ElseIf TextBox2.Text.Length < 12 Then
            MsgB("ROM Header is too short.", 1, "OK",,, "Error")
        ElseIf TextBox3.Text.Length < 4 Then
            MsgB("ROM Code is too short.", 1, "OK",,, "Error")
        ElseIf RichTextBox3.Text = rdd Then
            MsgB("ROM description is missing.", 1, "OK",,, "Error")
        Else
            Build()
        End If
    End Sub

    'Interact with BATCH file
    Private Shared Sub Main(ByVal args As String())
        If My.Settings.Delay = Nothing Or My.Settings.Delay = 0 Then
            My.Settings.Delay = 500
        End If
        Dim del As Integer = My.Settings.Delay
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {
        .UseShellExecute = False,
        .RedirectStandardInput = True,
        .FileName = "12distro.bat"
        }
        Dim process As Process = New Process()
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        process.StartInfo = startInfo
        process.Start()
        process.StandardInput.WriteLine("1")
        System.Threading.Thread.Sleep(del)
        process.StandardInput.WriteLine("3")
        System.Threading.Thread.Sleep(del)
        process.StandardInput.WriteLine("4")
        process.WaitForExit()
    End Sub

    'Build ROM process
    Private Sub Build()
        System.IO.Directory.CreateDirectory(appPath & "\cards\")
        Save(appPath & "\cards\01.bin")
        System.IO.Directory.CreateDirectory(appPath & "\tools\")
        System.IO.File.Copy(My.Settings.ticket, appPath & "\tools\ticket.nds")
        'System.IO.File.WriteAllText(apppath & "\tools\12distro.asm", My.Resources._12distro1)
        System.IO.File.WriteAllText(appPath & "\tools\12distro.asm", My.Resources._12distro_)
        Dim d12 As String = System.IO.File.ReadAllText(appPath & "\tools\12distro.asm")
        d12 = d12 & "
.open banner.bin,0h

.org 2h
	dcw 8B9Fh

.org 240h
	dcw " & description & "

.org 340h
	dcw " & description & "
    
.org 440h
	dcw " & description & "
    
.org 540h
	dcw " & description & "
    
.org 640h
	dcw " & description & "
    
.org 740h
	dcw " & description & "
    
.close
.open header.bin,0h

.org 0h
    dcb " & header & "
    
.org 0Ch
    dcb " & code & "
    
.close"
        System.IO.File.Delete(appPath & "\tools\12distro.asm")
        System.IO.File.WriteAllText(appPath & "\tools\12distro.asm", d12)
        System.IO.File.WriteAllText(appPath & "\tools\options.asm", My.Resources.options)
        System.IO.File.WriteAllText(appPath & "\tools\armips_readme.txt", My.Resources.armips_readme)
        System.IO.File.WriteAllBytes(appPath & "\tools\ndstool.exe", My.Resources.ndstool)
        System.IO.File.WriteAllBytes(appPath & "\tools\armips.exe", My.Resources.armips)
        System.IO.File.WriteAllText(appPath & "\readme.txt", My.Resources.readme)
        System.IO.File.WriteAllText(appPath & "\12distro.bat", My.Resources._12distro)

        Dim p As String() = {"3", "
"}
        Timer1.Interval = My.Settings.Delay + 2000
        Timer1.Start()
        Main(p)
        Timer1.Stop()
        System.IO.File.Delete(appPath & "\12distro.bat")
        System.IO.File.Delete(appPath & "\12distro.nds")
        System.IO.File.Delete(appPath & "\readme.txt")
        System.IO.Directory.Delete(appPath & "\tools\", True)
        System.IO.Directory.Delete(appPath & "\cards\", True)
        System.IO.File.Move(appPath & "\compiled.nds", appPath & "\" & TextBox1.Text & ".nds")
        MsgBox("Built as " & TextBox1.Text & ".nds", 0)
        Shell("explorer /select, " & appPath & "\" & TextBox1.Text & ".nds", AppWinStyle.NormalFocus)

        'dt = False
        'Label2.Text = "Open .pgf ------->"
        'CheckBox5.Checked = False
        'RichTextBox1.Text = Nothing
        'initial()
        'dt = True
        'News()

        Application.Restart()
    End Sub

    'Timer to make sure build is working
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MsgBox("It seems your computer is a little slow. You'll have to increase the delay.", MsgBoxStyle.OkOnly, "Increase Delay")
        Dim options As New options
        options.ShowDialog()
    End Sub
#End Region

    'About Button
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.ShowDialog()
    End Sub

    'Button to snap window size
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = ">>" Then
            Size = New Size(838, 490)
            Button7.Text = "<<"
        ElseIf Button7.Text = "<<" Then
            Size = New Size(452, 490)
            Button7.Text = ">>"
        End If
    End Sub

#Region "File Care"
    Private Shared Function HexStringToByteArray(ByRef strInput As String) As Byte()
        Dim length As Integer
        Dim bOutput As Byte()
        Dim c(1) As Integer
        length = strInput.Length / 2
        ReDim bOutput(length - 1)
        For i As Integer = 0 To (length - 1)
            For j As Integer = 0 To 1
                c(j) = Asc(strInput.Chars(i * 2 + j))
                If ((c(j) >= Asc("0")) And (c(j) <= Asc("9"))) Then
                    c(j) = c(j) - Asc("0")
                ElseIf ((c(j) >= Asc("A")) And (c(j) <= Asc("F"))) Then
                    c(j) = c(j) - Asc("A") + &HA
                ElseIf ((c(j) >= Asc("a")) And (c(j) <= Asc("f"))) Then
                    c(j) = c(j) - Asc("a") + &HA
                End If
            Next j
            bOutput(i) = (c(0) * &H10 + c(1))
        Next i
        Return (bOutput)
    End Function
    Private Sub Open(ByVal myFile As String)
        Dim myBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(myFile)
        Dim txtTemp As New System.Text.StringBuilder()
        For Each myByte As Byte In myBytes
            txtTemp.Append(myByte.ToString("X2"))
        Next
        RichTextBox1.Text = txtTemp.ToString()
    End Sub
    Private Sub Save(myFile)
        Dim myBytes As Byte() = HexStringToByteArray(RichTextBox1.Text)
        My.Computer.FileSystem.WriteAllBytes(myFile, myBytes, False)
    End Sub
#End Region 'Open, put into the editor, and save work
#Region "Settings"
    'Adds PGF event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FileSelect As New OpenFileDialog With {
        .Filter = "Gen 5 Event Files (*.pgf)|*.pgf|All files (*.*)|*.*"}
        Dim res As DialogResult = FileSelect.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then
        Else
            Dim myFile As String = FileSelect.FileName
            Label2.Text = myFile.Substring(myFile.LastIndexOf("\") + 1)
            RichTextBox1.Text = RichTextBox1.Text.Remove(8, 408)
            Dim myBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(myFile)
            Dim txtTemp As New System.Text.StringBuilder()
            For Each myByte As Byte In myBytes
                txtTemp.Append(myByte.ToString("X2"))
            Next
            RichTextBox1.Text = RichTextBox1.Text.Insert(8, txtTemp.ToString())
            RichTextBox1.Text = RichTextBox1.Text.Remove(352, 8)
            RichTextBox1.Text = RichTextBox1.Text.Insert(352, "00000000")
        End If
    End Sub

    'Adds Black Compatability
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Games(0) = 32
        Else
            Games(0) = 0
        End If
        Game_compatability()
    End Sub

    'Adds White Compatability
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Games(1) = 16
        Else
            Games(1) = 0
        End If
        Game_compatability()
    End Sub

    'Adds Black 2 Compatability
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Games(2) = 128
        Else
            Games(2) = 0
        End If
        Game_compatability()
    End Sub

    'Adds White 2 Compatability
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Games(3) = 64
        Else
            Games(3) = 0
        End If
        Game_compatability()
    End Sub

    'Maxes Date Limit
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Label3.Enabled = False
            Label4.Enabled = False
            temp_startDate = DateTimePicker1.Value
            temp_endDate = DateTimePicker2.Value
            DateTimePicker1.Value = New DateTime(1753, 1, 1)
            DateTimePicker2.Value = New DateTime(9998, 12, 31)
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        ElseIf CheckBox5.Checked = False Then
            Label3.Enabled = True
            Label4.Enabled = True
            DateTimePicker1.Value = temp_startDate
            DateTimePicker2.Value = temp_endDate
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
    End Sub

    'Updates Start Date when changed
    Private Sub StartDate_Changed(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If dt = True Then
            DateLimit()
        End If
    End Sub

    'Updates End Date when changed
    Private Sub EndDate_Changed(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If dt = True Then
            DateLimit()
        End If
    End Sub

    'Sets Region to English
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            hexRegion = "020000BC83"
            SetRegion()
            My.Settings.Language = "E"
        Else
            hexRegion = Nothing
        End If
    End Sub

    'Sets Region to French
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            hexRegion = "030000369D"
            SetRegion()
            My.Settings.Language = "F"
        Else
            hexRegion = Nothing
        End If
    End Sub

    'Sets Region to Italian
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            hexRegion = "040000AA39"
            SetRegion()
            My.Settings.Language = "I"
        Else
            hexRegion = Nothing
        End If
    End Sub

    'Sets Region to German
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            hexRegion = "0500001844"
            SetRegion()
            My.Settings.Language = "G"
        Else
            hexRegion = Nothing
        End If
    End Sub

    'Sets Region to Spanish
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            hexRegion = "06000061E0"
            SetRegion()
            My.Settings.Language = "S"
        Else
            hexRegion = Nothing
        End If
    End Sub

    'Sets Region to Japanese
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            hexRegion = "0200007AF5"
            SetRegion()
            My.Settings.Language = "J"
        Else
            hexRegion = Nothing
        End If
    End Sub

    'Sets Region to Korean
    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            hexRegion = "0200007AF5"
            SetRegion()
            My.Settings.Language = "K"
        Else
            hexRegion = Nothing
        End If
    End Sub

    'Sets Event Message
    Private Sub EventText()
        If RichTextBox2.Text <> "" Then
            Dim StrToChars As Char() = RichTextBox2.Text.ToCharArray
            Dim tempText As String = Nothing
            For n = 0 To UBound(StrToChars) Step 1
                Dim tempStr As String = Hex_Zeros(Hex(Asc(StrToChars(n))), 2)
                tempText = tempText & tempStr & "00"
            Next n
            If tempText.Contains("0A00") Then
                tempText = tempText.Replace("0A00", "FEFF")
            End If
            Dim mn As Integer = tempText.Length
            Dim req As Integer = 1012 - mn
            For n = 0 To req - 1 Step 1
                tempText = tempText & "F"
            Next n
            RichTextBox1.Text = RichTextBox1.Text.Remove(424, 1012)
            RichTextBox1.Text = RichTextBox1.Text.Insert(424, tempText)
        Else
            Dim tempText As String = ""
            For i = 0 To 1011 Step 1
                tempText = tempText & "F"
            Next i
            RichTextBox1.Text = RichTextBox1.Text.Remove(424, 1012)
            RichTextBox1.Text = RichTextBox1.Text.Insert(424, tempText)
        End If
    End Sub

    'Converts Text to Assembly for Code, Header, and Description
    Private Function TextToAssembly(ByVal src As String)
        Dim tempStr As String = Nothing
        If src <> "" Then
            Dim StrToChars As Char() = src.ToCharArray
            For n = 0 To UBound(StrToChars) Step 1
                Dim tempChar As String = Hex_Zeros(Hex(Asc(StrToChars(n))), 2)
                If tempChar = "E9" Then
                    tempChar = "0" & tempChar
                End If
                tempStr = tempStr & tempChar & "h,"
            Next n
            tempStr = tempStr & "0h"
        Else
            tempStr = "default"
        End If
        Return tempStr
    End Function

    'Sets Default texts
    Public Sub News()
        InitializeComponent()
        RichTextBox2.Text = rtd
        RichTextBox2.ForeColor = Color.Gray
        RichTextBox3.Text = rdd
        RichTextBox3.ForeColor = Color.Gray
        TextBox1.Text = "compiled"
        TextBox1.ForeColor = Color.Gray
        TextBox2.Text = "PKMCUSTOMROM"
        TextBox2.ForeColor = Color.Gray
        TextBox3.Text = "G5DC"
        TextBox3.ForeColor = Color.Gray
        'RichTextBox2.Enter += New EventHandler(AddressOf richTextBox2_GotFocus)
        'RichTextBox2.LostFocus += New EventHandler(AddressOf richTextBox2_LostFocus)
    End Sub

    'Calls the setting of default texts
    Public Sub New()
        News()
    End Sub

    Private Sub RichTextBox2_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox2.Leave
        If RichTextBox2.Text = Nothing Then
            RichTextBox2.Text = rtd
            RichTextBox2.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub RichTextBox2_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox2.Enter
        If RichTextBox2.Text = rtd Then
            RichTextBox2.Text = Nothing
            RichTextBox2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub RichTextBox3_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox3.Leave
        If RichTextBox3.Text = Nothing Then
            RichTextBox3.Text = rdd
            RichTextBox3.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub RichTextBox3_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox3.Enter
        If RichTextBox3.Text = rdd Then
            RichTextBox3.Text = Nothing
            RichTextBox3.ForeColor = Color.Black
        End If
    End Sub

    'Checks if Event Message changed
    Private Sub RichTextBox2_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox2.TextChanged
        RichTextBox2.ForeColor = Color.Black
        EventText()
    End Sub

    'Checks if ROM description changed
    Private Sub RichTextBox3_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox3.TextChanged
        RichTextBox3.ForeColor = Color.Black
        Dim tempStr As String = Nothing
        If RichTextBox3.Text = rdd Then
            tempStr = ""
        Else
            tempStr = RichTextBox3.Text
        End If
        description = TextToAssembly(tempStr)
        If description = "default" Then
            description = desd
        End If
    End Sub

    'Checks if ROM header changed
    Private Sub TextBox2_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.ForeColor = Color.Black
        TextBox2.Text = TextBox2.Text.ToUpper
        TextBox2.SelectionStart = TextBox2.TextLength
        TextBox2.ScrollToCaret()
        header = TextToAssembly(TextBox2.Text)
        If header = "default" Then
            header = headd
        End If
    End Sub

    'Checks if ROM code changed
    Private Sub TextBox3_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.ForeColor = Color.Black
        TextBox3.Text = TextBox3.Text.ToUpper
        TextBox3.SelectionStart = TextBox3.TextLength
        TextBox3.ScrollToCaret()
        code = TextToAssembly(TextBox3.Text)
        If code = "default" Then
            code = coded
        End If
    End Sub

    'Clears Event Message
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox2.Text = Nothing
        EventText()
        RichTextBox2.ForeColor = Color.Black
    End Sub

    'Clears ROM description
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox3.Text = Nothing
        RichTextBox3.ForeColor = Color.Black
    End Sub

    'Set ROM description to default text
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RichTextBox3.Text = "Pokémon
Generation 5
Custom Made Distribution
PKMG5DC"
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = Nothing Then
            TextBox1.Text = "compiled"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "compiled" Then
            TextBox1.Text = Nothing
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = Nothing Then
            TextBox2.Text = "PKMCUSTOMROM"
            TextBox2.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "PKMCUSTOMROM" Then
            TextBox2.Text = Nothing
            TextBox2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = Nothing Then
            TextBox3.Text = "G5DC"
            TextBox3.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.Enter
        If TextBox3.Text = "G5DC" Then
            TextBox3.Text = Nothing
            TextBox3.ForeColor = Color.Black
        End If
    End Sub

    'Opens PGF Creator
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.ShowDialog()
    End Sub

    'Link to Update version
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://github.com/PlasticJustice/PKMG5DC/releases/latest")
        Else
            MsgB("No Internet connection!
You can not update at the moment.", 1, "OK",,, "Error 404")
        End If
    End Sub

    'Link the Author's, yours truly, Github Page
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://github.com/PlasticJustice")
        Else
            MsgB("No Internet connection!
You can look me up later.", 1, "OK",,, "Error 404")
        End If
    End Sub

    'PayPal Donate Button
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Thread.Sleep(200)
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UGSCC5VGSGN3E")
        Else
            MsgB("No Internet connection!
I appreciate the gesture.", 1, "OK",,, "Error 404")
        End If
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Image = My.Resources.ppdbs
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Image = Nothing
    End Sub
#End Region
End Class