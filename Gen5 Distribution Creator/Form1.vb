Public Class Form1
#Region "Variables"
    Dim apppath As String = My.Application.Info.DirectoryPath
    'Dim res As String = My.Resources.ResourceManager.BaseName
    Dim res As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
    Dim TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
    Dim comp(4) As Integer
    Dim dt As Boolean = False
    Dim t As Date
    Dim t2 As Date
    Dim r As String = My.Settings.Region
    Dim des As String
    Dim head As String
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
#End Region
#Region "Syncs"
    Private Sub comp_ch()
        comp(4) = (comp(0) Xor comp(1) Xor comp(2) Xor comp(3))
        Dim co As String = Hex(comp(4))
        If co.Length < 2 Then
            co = "0" & co
        End If
        RichTextBox1.Text = RichTextBox1.Text.Remove(420, 2)
        RichTextBox1.Text = RichTextBox1.Text.Insert(420, co)
    End Sub
    Private Sub reg()
        RichTextBox1.Text = RichTextBox1.Text.Remove(1438, 10)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1438, r)
    End Sub
    Private Sub RT_ch(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
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
    Private Sub RichTextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox2.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 127 Then
            e.Handled = True
        End If
    End Sub
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label2.Text = "Open .pgf ------->" Then
            MsgB("No .pgf file.", 1, "OK", "", "", "Error")
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False Then
            MsgB("No compatible game.", 1, "OK", "", "", "Error")
        ElseIf TextBox2.Text.Length < 12 Then
            MsgB("ROM Header is too short.", 1, "OK", "", "", "Error")
        ElseIf TextBox3.Text.Length < 4 Then
            MsgB("ROM Code is too short.", 1, "OK", "", "", "Error")
        ElseIf RichTextBox3.Text = rdd Then
            MsgB("ROM description is missing.", 1, "OK", "", "", "Error")
        Else
            build()
        End If
    End Sub
    Private Shared Sub Main(ByVal args As String())
        If My.Settings.Delay = Nothing Or My.Settings.Delay = 0 Then
            My.Settings.Delay = 300
        End If
        Dim del As Integer = My.Settings.Delay
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
        startInfo.UseShellExecute = False
        startInfo.RedirectStandardInput = True
        startInfo.FileName = "12distro.bat"
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
    Private Sub build()
        System.IO.Directory.CreateDirectory(apppath & "\cards\")
        save(apppath & "\cards\01.bin")
        System.IO.Directory.CreateDirectory(apppath & "\tools\")
        System.IO.File.Copy(My.Settings.ticket, apppath & "\tools\ticket.nds")
        'System.IO.File.WriteAllText(apppath & "\tools\12distro.asm", My.Resources._12distro1)
        System.IO.File.WriteAllText(apppath & "\tools\12distro.asm", My.Resources._12distro_)
        Dim d12 As String = System.IO.File.ReadAllText(apppath & "\tools\12distro.asm")
        d12 = d12 & "
.open banner.bin,0h

.org 2h
	dcw 8B9Fh

.org 240h
	dcw " & des & "

.org 340h
	dcw " & des & "
    
.org 440h
	dcw " & des & "
    
.org 540h
	dcw " & des & "
    
.org 640h
	dcw " & des & "
    
.org 740h
	dcw " & des & "
    
.close
.open header.bin,0h

.org 0h
    dcb " & head & "
    
.org 0Ch
    dcb " & code & "
    
.close"
        System.IO.File.Delete(apppath & "\tools\12distro.asm")
        System.IO.File.WriteAllText(apppath & "\tools\12distro.asm", d12)
        System.IO.File.WriteAllText(apppath & "\tools\options.asm", My.Resources.options)
        System.IO.File.WriteAllText(apppath & "\tools\armips_readme.txt", My.Resources.armips_readme)
        System.IO.File.WriteAllBytes(apppath & "\tools\ndstool.exe", My.Resources.ndstool)
        System.IO.File.WriteAllBytes(apppath & "\tools\armips.exe", My.Resources.armips)
        System.IO.File.WriteAllText(apppath & "\readme.txt", My.Resources.readme)
        System.IO.File.WriteAllText(apppath & "\12distro.bat", My.Resources._12distro)

        'System.Threading.Thread.Sleep(15000)
        Dim p As String() = {"3", "
"}
        Timer1.Interval = My.Settings.Delay + 2000
        Timer1.Start()
        Main(p)
        Timer1.Stop()
        System.IO.File.Delete(apppath & "\12distro.bat")
        System.IO.File.Delete(apppath & "\12distro.nds")
        System.IO.File.Delete(apppath & "\readme.txt")
        System.IO.Directory.Delete(apppath & "\tools\", True)
        System.IO.Directory.Delete(apppath & "\cards\", True)
        System.IO.File.Move(apppath & "\compiled.nds", apppath & "\" & TextBox1.Text & ".nds")
        MsgBox("Built as " & TextBox1.Text & ".nds", 0)
        Shell("explorer /select, " & apppath & "\" & TextBox1.Text & ".nds", AppWinStyle.NormalFocus)

        'dt = False
        'Label2.Text = "Open .pgf ------->"
        'CheckBox5.Checked = False
        'RichTextBox1.Text = Nothing
        'initial()
        'dt = True
        'News()

        Application.Restart()
    End Sub
#End Region
    Private Sub tickchk()
1:
        If System.IO.File.Exists(apppath & "/ticket.nds") Then
            Dim myFile As String = apppath & "/ticket.nds"
            Dim l = System.IO.File.ReadAllText(myFile)
            If l.Contains("POKWBLIBERTYY8KP01") Then
                My.Settings.ticket = apppath & "/ticket.nds"
            Else
                MsgBox("Error: Invaild File", 0)
                Close()
            End If
        Else
            If My.Settings.ticket = apppath & "/ticket.nds" And System.IO.File.Exists(My.Settings.ticket) Then
                Dim myFile As String = My.Settings.ticket
                Dim l = System.IO.File.ReadAllText(myFile)
                If l.Contains("POKWBLIBERTYY8KP01") Then
                Else
                    MsgBox("Error: Invaild File", 0)
                    Close()
                End If
            ElseIf My.Settings.ticket <> apppath & "/ticket.nds" And My.Settings.ticket <> Nothing And System.IO.File.Exists(My.Settings.ticket) Then
                Dim myFile As String = My.Settings.ticket
                If System.IO.File.Exists(apppath & "/ticket.nds") Then
                    System.IO.File.Delete(apppath & "/ticket.nds")
                End If
                System.IO.File.Copy(myFile, apppath & "/ticket.nds")
                My.Settings.ticket = apppath & "/ticket.nds"
            ElseIf My.Settings.ticket <> Nothing And (System.IO.File.Exists(My.Settings.ticket) = False) Then
                My.Settings.ticket = Nothing
                GoTo 1
            ElseIf My.Settings.ticket = Nothing Then
                Dim a = MsgB(msl, 2, Yes, No, "", tl)
                If a = 6 Then
                    MsgBox("Can you select it for me?", 0)
                    'OpenFileDialog1.Filter = "Event ROM (*.nds)|*.nds|All files (*.*)|*.*"
                    Dim b As New OpenFileDialog '1.ShowDialog()
                    b.Filter = "Event ROM (*.nds)|*.nds|All files (*.*)|*.*"
                    Dim res As DialogResult = b.ShowDialog()
                    If res = Windows.Forms.DialogResult.Cancel Then
                        Close()
                    Else
                        Dim myFile As String = b.FileName 'OpenFileDialog1.FileName
                        Dim l = System.IO.File.ReadAllText(myFile)
                        If l.Contains("POKWBLIBERTYY8KP01") Then
                            If System.IO.File.Exists(apppath & "/ticket.nds") Then
                                System.IO.File.Delete(apppath & "/ticket.nds")
                            End If
                            System.IO.File.Copy(myFile, apppath & "/ticket.nds")
                            My.Settings.ticket = apppath & "/ticket.nds"
                        Else
                            MsgBox("Error: Invaild File", 0)
                            Close()
                        End If
                    End If
                ElseIf a = 7 Then
                    chkDeS()
                    Close()
                End If
            End If
        End If
    End Sub
    Private Sub chkDeS()
        Dim Everest_Registry As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey("Applications\DeSmuME.exe")
        Dim Everest_Registry2 As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey("Applications\DeSmuME_0.9.11_x64.exe")
        If Everest_Registry Is Nothing And Everest_Registry2 Is Nothing Then
        Else
            Dim gen As New Random
            Dim n = gen.Next(1, 26)
            Dim f = gen.Next(0, 2)
            If (n Mod (System.DateTime.Today.Day Mod 3)) = f Then
                If My.Computer.Network.IsAvailable Then
                    MsgBox("Google is your friend.", 0)
                    Process.Start("https://www.google.com/search?q=pokemon+liberty+ticket+distribution+rom")
                End If
            Else
                MsgBox("Google is your friend.", 0)
            End If
        End If
    End Sub
    Private Sub lang()
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
    Private Function MsgB(ByVal mes As String, ByVal numB As Integer, ByVal But1 As String, ByVal But2 As String, ByVal But3 As String, ByVal head As String)
        Dim msg As New CustomMessageBox(mes, numB, But1, But2, But3, head)
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
    End Function 'custom MsgBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tickchk()
        If System.IO.File.Exists(TempPath & "\vsn.txt") Then
            System.IO.File.Delete(TempPath & "\vsn.txt")
        End If
#If DEBUG Then
        Size = New Size(838, 490)
        System.IO.File.WriteAllText(apppath & "/version.txt", My.Application.Info.Version.ToString)
        System.IO.File.WriteAllText(apppath & "/version.json", "{
" & ControlChars.Quote & "version" & ControlChars.Quote & ": " & ControlChars.Quote & My.Application.Info.Version.ToString & ControlChars.Quote & "
}")
        If My.Computer.Network.IsAvailable Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/master/Gen5%20Distribution%20Creator/bin/Debug/version.txt", TempPath & "\vsn.txt")
            Dim Reader As New IO.StreamReader(TempPath & "\vsn.txt")
            Dim v As String = Reader.ReadToEnd
            Reader.Close()
            System.IO.File.Delete(TempPath & "\vsn.txt")
            If Application.ProductVersion <> v Then
                System.IO.File.WriteAllText(res & "/date.txt", (System.DateTime.Today.Year & "/" & System.DateTime.Today.Month & "/" & System.DateTime.Today.Day))
            End If
        End If
        LinkLabel1.Hide()
        Button7.Text = "<<"
#Else
        Size = New Size(452, 490)
        Me.CenterToScreen()
        Label13.Hide()
        Label1.Hide()
        System.IO.File.WriteAllText(TempPath & "\date.txt", My.Resources._date)
        Dim dat As String = System.IO.File.ReadAllText(TempPath & "\date.txt")
        Me.Text = "Gen 5 Distribution Creator (" & dat & ")"
        If My.Computer.Network.IsAvailable Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/PlasticJustice/PKMG5DC/master/Gen5%20Distribution%20Creator/Resources/date.txt", TempPath & "\dt.txt")
            Dim Reader As New IO.StreamReader(TempPath & "\dt.txt")
            Dim dtt As String = Reader.ReadToEnd
            Reader.Close()
            System.IO.File.Delete(TempPath & "\dt.txt")
            If dat <> dtt Then
                LinkLabel1.Text = "New Update Available! " & dtt
                LinkLabel1.Show()
            Else
                LinkLabel1.Hide()
            End If
        Else
            LinkLabel1.Hide()
        End If
        System.IO.File.Delete(TempPath & "\date.txt")
#End If
        'Button4.Location = New Point(296, 296)
        initial()
        dt = True
        lang()
        reg()
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
    Private Sub initial()
        Dim st As String = Nothing
        For n = 0 To 17503 Step 1
            st = st & "0"
        Next n
        RichTextBox1.Text = st
        RichTextBox1.Text = RichTextBox1.Text.Remove(1, 1)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1, "1")
        Dim f As Integer = RichTextBox1.Text.Length - 16
        RichTextBox1.Text = RichTextBox1.Text.Remove(f, 2)
        RichTextBox1.Text = RichTextBox1.Text.Insert(f, "14")
        RichTextBox1.Text = RichTextBox1.Text.Remove(1438, 2)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1438, "02")
        DateTimePicker1.Value = System.DateTime.Today
        DateTimePicker2.Value = System.DateTime.Today
        lim()
        Dim ft As String = ""
        Dim mx As Integer = 1012
        For i = 0 To mx - 1 Step 1
            ft = ft & "F"
        Next i
        RichTextBox1.Text = RichTextBox1.Text.Remove(424, mx)
        RichTextBox1.Text = RichTextBox1.Text.Insert(424, ft)
    End Sub
    Private Function lted(ByVal int As Integer)
        Dim s As String
        If Hex(int).Length < 4 Then
            s = "0" & Hex(int)
        Else
            s = Hex(int)
        End If
        Dim s2 As String = s.Skip(2).ToArray() & s.Remove(2, 2).ToArray()
        Return s2
    End Function
    Private Sub lim()
        Dim d As Integer = DateTimePicker1.Value.Date.Day
        Dim m As Integer = DateTimePicker1.Value.Date.Month
        Dim y As Integer = DateTimePicker1.Value.Date.Year
        Dim d2 As Integer = DateTimePicker2.Value.Date.Day
        Dim m2 As Integer = DateTimePicker2.Value.Date.Month
        Dim y2 As Integer = DateTimePicker2.Value.Date.Year
        Dim hm As String = Hex(m)
        Dim hd As String = Hex(d)
        Dim s As String = lted(y)
        Dim hm2 As String = Hex(m2)
        Dim hd2 As String = Hex(d2)
        Dim s2 As String = lted(y2)
        If hm.Length < 2 Then
            hm = "0" & hm
        End If
        If hm2.Length < 2 Then
            hm2 = "0" & hm2
        End If
        If hd.Length < 2 Then
            hd = "0" & hd
        End If
        If hd2.Length < 2 Then
            hd2 = "0" & hd2
        End If
        RichTextBox1.Text = RichTextBox1.Text.Remove(17288, 16)
        RichTextBox1.Text = RichTextBox1.Text.Insert(17288, (s & hm & hd & s2 & hm2 & hd2))
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.ShowDialog()
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
    Private Sub open(ByVal myFile As String)
        Dim myBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(myFile)
        Dim txtTemp As New System.Text.StringBuilder()
        For Each myByte As Byte In myBytes
            txtTemp.Append(myByte.ToString("X2"))
        Next
        RichTextBox1.Text = txtTemp.ToString()
    End Sub
    Private Sub save(myFile)
        Dim myBytes As Byte() = HexStringToByteArray(RichTextBox1.Text)
        My.Computer.FileSystem.WriteAllBytes(myFile, myBytes, False)
    End Sub
#End Region
#Region "Settings"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim b As New OpenFileDialog
        b.Filter = "Gen 5 Event Files (*.pgf)|*.pgf|All files (*.*)|*.*"
        Dim res As DialogResult = b.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then

        Else
            Dim myFile As String = b.FileName
            Dim Fn() As String = myFile.Split("\")
            Dim fn2 As String = Fn(UBound(Fn))
            Label2.Text = fn2
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
        'OpenFileDialog1.Filter = "Gen 5 Event Files (*.pgf)|*.pgf|All files (*.*)|*.*"
        'OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            comp(0) = 32
        Else
            comp(0) = 0
        End If
        comp_ch()
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            comp(1) = 16
        Else
            comp(1) = 0
        End If
        comp_ch()
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            comp(2) = 128
        Else
            comp(2) = 0
        End If
        comp_ch()
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            comp(3) = 64
        Else
            comp(3) = 0
        End If
        comp_ch()
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Label3.Enabled = False
            Label4.Enabled = False
            t = DateTimePicker1.Value
            t2 = DateTimePicker2.Value
            DateTimePicker1.Value = New DateTime(1753, 1, 1)
            DateTimePicker2.Value = New DateTime(9998, 12, 31)
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        ElseIf CheckBox5.Checked = False Then
            Label3.Enabled = True
            Label4.Enabled = True
            DateTimePicker1.Value = t
            DateTimePicker2.Value = t2
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
    End Sub
    Private Sub dtch(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If dt = True Then
            lim()
        End If
    End Sub
    Private Sub dt2ch(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If dt = True Then
            lim()
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            r = "020000BC83"
            reg()
            My.Settings.Language = "E"
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            r = "030000369D"
            reg()
            My.Settings.Language = "F"
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            r = "040000AA39"
            reg()
            My.Settings.Language = "I"
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            r = "0500001844"
            reg()
            My.Settings.Language = "G"
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            r = "06000061E0"
            reg()
            My.Settings.Language = "S"
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            r = "0200007AF5"
            reg()
            My.Settings.Language = "J"
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            r = "0200007AF5"
            reg()
            My.Settings.Language = "K"
        Else
            r = Nothing
        End If
    End Sub
    Private Sub evnttxt()
        If RichTextBox2.Text <> "" Then
            Dim ch As Char() = RichTextBox2.Text.ToCharArray
            Dim ft As String = Nothing
            Dim n As Integer = 0
            For n = 0 To UBound(ch) Step 1
                Dim t As String = Hex(Asc(ch(n)))
                If t.Length < 2 Then
                    t = "0" & t
                End If
                ft = ft & t & "00"
            Next n
            If ft.Contains("0A00") Then
                ft = ft.Replace("0A00", "FEFF")
            End If
            Dim mx As Integer = 1012
            Dim mn As Integer = ft.Length
            Dim req As Integer = mx - mn
            For n = 0 To req - 1 Step 1
                ft = ft & "F"
            Next n
            RichTextBox1.Text = RichTextBox1.Text.Remove(424, mx)
            RichTextBox1.Text = RichTextBox1.Text.Insert(424, ft)
        Else
            Dim ft As String = ""
            Dim mx As Integer = 1012
            For i = 0 To mx - 1 Step 1
                ft = ft & "F"
            Next i
            RichTextBox1.Text = RichTextBox1.Text.Remove(424, mx)
            RichTextBox1.Text = RichTextBox1.Text.Insert(424, ft)
        End If
    End Sub
    Private Function asm(ByVal src As String)
        Dim ft As String = Nothing
        If src <> "" Then
            Dim ch As Char() = src.ToCharArray
            Dim n As Integer = 0
            For n = 0 To UBound(ch) Step 1
                Dim t As String = Hex(Asc(ch(n)))
                t = t.ToUpper
                If t.Length < 2 Then
                    t = "0" & t
                End If
                If t = "E9" Then
                    t = "0" & t
                End If
                ft = ft & t & "h,"
            Next n
            ft = ft & "0h"
        Else
            ft = "default"
        End If
        Return ft
    End Function
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
    Private Sub rt2ch(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox2.TextChanged
        RichTextBox2.ForeColor = Color.Black
        evnttxt()
    End Sub
    Private Sub rt3ch(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox3.TextChanged
        RichTextBox3.ForeColor = Color.Black
        Dim s As String = Nothing
        If RichTextBox3.Text = rdd Then
            s = ""
        Else
            s = RichTextBox3.Text
        End If
        des = asm(s)
        If des = "default" Then
            des = desd
        End If
    End Sub
    Private Sub t2ch(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.ForeColor = Color.Black
        TextBox2.Text = TextBox2.Text.ToUpper
        TextBox2.SelectionStart = TextBox2.TextLength
        TextBox2.ScrollToCaret()
        head = asm(TextBox2.Text)
        If head = "default" Then
            head = headd
        End If
    End Sub
    Private Sub t3ch(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.ForeColor = Color.Black
        TextBox3.Text = TextBox3.Text.ToUpper
        TextBox3.SelectionStart = TextBox3.TextLength
        TextBox3.ScrollToCaret()
        code = asm(TextBox3.Text)
        If code = "default" Then
            code = coded
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox2.Text = Nothing
        Dim ft As String = ""
        Dim mx As Integer = 1012
        For i = 0 To mx - 1 Step 1
            ft = ft & "F"
        Next i
        RichTextBox1.Text = RichTextBox1.Text.Remove(424, mx)
        RichTextBox1.Text = RichTextBox1.Text.Insert(424, ft)
        RichTextBox2.ForeColor = Color.Black
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://github.com/PlasticJustice/PKMG5DC/releases/latest")
        Else
            MsgB("No Internet connection!
You can not update at the moment.", 1, "OK", "", "", "Error 404")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox3.Text = Nothing
        RichTextBox3.ForeColor = Color.Black
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://github.com/PlasticJustice")
        Else
            MsgB("No Internet connection!
You can look me up later.", 1, "OK", "", "", "Error 404")
        End If
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If My.Computer.Network.IsAvailable Then
            Process.Start("https://paypal.me/PJMinesAndCrafts")
        Else
            MsgB("No Internet connection!
I appreciate the gesture.", 1, "OK", "", "", "Error 404")
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.Text = ">>" Then
            Size = New Size(838, 490)
            Button7.Text = "<<"
        ElseIf Button7.Text = "<<" Then
            Size = New Size(452, 490)
            Button7.Text = ">>"
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MsgBox("It seems your computer is a little slow. You'll have to increase the delay.", MsgBoxStyle.OkOnly, "Increase Delay")
        Dim options As New options
        options.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RichTextBox3.Text = "Pokémon
Generation 5
Custom Made Distribution
PKMG5DC"
    End Sub
#End Region
End Class