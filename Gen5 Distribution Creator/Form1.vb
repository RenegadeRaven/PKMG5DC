Public Class Form1
    Dim apppath As String = My.Application.Info.DirectoryPath
    Dim comp(4) As Integer
    Dim dt As Boolean = False
    Dim t As Date
    Dim t2 As Date
    Dim r As String = "BC83"
    Dim rtd As String = "Input Event Text Here.

This textbox is sized perfectly, so what fits in
this box is all you can fit. A maximum of 7 
lines, max 36 characters per line, and a 
maximum of 252 characters total.
Make sure you put the new lines(ENTER key)"

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
        RichTextBox1.Text = RichTextBox1.Text.Remove(1444, 4)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1444, r)
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
        'save(apppath & "\work.bin")
    End Sub
    Private Shared Sub Main(ByVal args As String())
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
        startInfo.UseShellExecute = False
        startInfo.RedirectStandardInput = True
        startInfo.FileName = "12distro.bat"
        Dim process As Process = New Process()
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        process.StartInfo = startInfo
        process.Start()
        process.StandardInput.WriteLine("1")
        System.Threading.Thread.Sleep(2000)
        process.StandardInput.WriteLine("3")
        System.Threading.Thread.Sleep(2000)
        process.StandardInput.WriteLine("4")
        process.WaitForExit()
    End Sub
    Private Sub build()
        System.IO.Directory.CreateDirectory(apppath & "\cards\")
        save(apppath & "\cards\01.bin")
        System.IO.File.Delete(apppath & "\work.bin")
        System.IO.Directory.CreateDirectory(apppath & "\tools\")
        System.IO.File.Copy(My.Settings.ticket, apppath & "\tools\ticket.nds")
        System.IO.File.WriteAllText(apppath & "\tools\12distro.asm", My.Resources._12distro1)
        System.IO.File.WriteAllText(apppath & "\tools\options.asm", My.Resources.options)
        System.IO.File.WriteAllText(apppath & "\tools\armips_readme.txt", My.Resources.armips_readme)
        System.IO.File.WriteAllBytes(apppath & "\tools\ndstool.exe", My.Resources.ndstool)
        System.IO.File.WriteAllBytes(apppath & "\tools\armips.exe", My.Resources.armips)
        System.IO.File.WriteAllText(apppath & "\readme.txt", My.Resources.readme)
        System.IO.File.WriteAllText(apppath & "\12distro.bat", My.Resources._12distro)
        Dim p As String() = {"3", "
"}
        Main(p)

        System.IO.File.Delete(apppath & "\12distro.bat")
        System.IO.File.Delete(apppath & "\12distro.nds")
        System.IO.File.Delete(apppath & "\readme.txt")
        System.IO.Directory.Delete(apppath & "\tools\", True)
        System.IO.Directory.Delete(apppath & "\cards\", True)
        System.IO.File.Move(apppath & "\compiled.nds", apppath & "\" & TextBox1.Text & ".nds")
        MsgBox("Built as " & TextBox1.Text & ".nds", 0)
        Application.Restart()
    End Sub
    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        System.IO.File.Delete(apppath & "\work.bin")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
1:
        If My.Settings.ticket = Nothing Then
            Dim a = MsgBox("This program requires a clean copy of the Liberty Ticket Distribution ROM. Do you have one?", MsgBoxStyle.YesNo, "Need Liberty Ticket ROM")
            If a = 6 Then
                MsgBox("Can you select it for me?", 0)
                OpenFileDialog1.Filter = "Event ROM (*.nds)|*.nds|All files (*.*)|*.*"
                OpenFileDialog1.ShowDialog()
                Dim myFile As String = OpenFileDialog1.FileName
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
            ElseIf a = 7 Then
                MsgBox("Google is your friend.", 0)
                Close()
            End If
        Else
            If System.IO.File.Exists(My.Settings.ticket) Then
            Else
                My.Settings.ticket = Nothing
                GoTo 1
            End If
        End If
        System.IO.File.WriteAllBytes(apppath & "/work.bin", My.Resources.data)
        open(apppath & "/work.bin")
        initial()
        dt = True
        RadioButton1.PerformClick()
        reg()
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        save(apppath & "\work.bin")
    End Sub
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
        'OpenFileDialog1.Filter = "All Supported Files (FULLWonderCards, *.ek#)|*.wc7full;*.wc6full;*.pcd;*.ek7;*.ek6;*.ek5;*.ek4|WonderCards (*.wc7full, *.wc6full, *.pcd)|*.wc7full;*.wc6full;*.pcd|Encrypted PK Files (*.ek#)|*.ek7;*.ek6;*.ek5;*.ek4;*.ek3;*.ek2;*.ek1|All files (*.*)|*.*"
        'OpenFileDialog1.ShowDialog()
        'Dim myFile As String = OpenFileDialog1.FileName
        'Dim ext() As String = myFile.Split(".")

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
    Private Sub initial()
        RichTextBox1.Text = RichTextBox1.Text.Remove(1, 1)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1, "1")
        Dim f As Integer = RichTextBox1.Text.Length - 16
        RichTextBox1.Text = RichTextBox1.Text.Remove(f, 2)
        RichTextBox1.Text = RichTextBox1.Text.Insert(f, "14")
        RichTextBox1.Text = RichTextBox1.Text.Remove(1438, 2)
        RichTextBox1.Text = RichTextBox1.Text.Insert(1438, "02")
        save(apppath & "/work.bin")
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
        save(apppath & "\work.bin")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Gen 5 Event Files (*.pgf)|*.pgf|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Dim myFile As String = OpenFileDialog1.FileName
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
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Label3.Enabled = False
            Label4.Enabled = False
            t = DateTimePicker1.Value
            t2 = DateTimePicker2.Value
            DateTimePicker1.Value = "1/1/1753"
            DateTimePicker2.Value = "12/31/9998"
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
            r = "BC83"
            reg()
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            r = "369D"
            reg()
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            r = "AA39"
            reg()
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            r = "1844"
            reg()
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            r = "61E0"
            reg()
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            r = "7AF5"
            reg()
        Else
            r = Nothing
        End If
    End Sub
    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            r = "7AF5"
            reg()
        Else
            r = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        RichTextBox2.Text = rtd
        RichTextBox2.ForeColor = Color.Gray
        TextBox1.Text = "compiled"
        TextBox1.ForeColor = Color.Gray

        'RichTextBox2.Enter += New EventHandler(AddressOf richTextBox2_GotFocus)
        'RichTextBox2.LostFocus += New EventHandler(AddressOf richTextBox2_LostFocus)
    End Sub

    Private Sub richTextBox2_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox2.Leave
        If RichTextBox2.Text = Nothing Then
            RichTextBox2.Text = rtd
            RichTextBox2.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub richTextBox2_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox2.Enter
        If RichTextBox2.Text = rtd Then
            RichTextBox2.Text = Nothing
            RichTextBox2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub rt2ch(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox2.TextChanged
        RichTextBox2.ForeColor = Color.Black
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        build()
    End Sub

    'Public Sub New()
    '    InitializeComponent()
    '    TextBox1.Text = "compiled"
    '    TextBox1.ForeColor = Color.Gray

    '    'RichTextBox2.Enter += New EventHandler(AddressOf richTextBox2_GotFocus)
    '    'RichTextBox2.LostFocus += New EventHandler(AddressOf richTextBox2_LostFocus)
    'End Sub

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.ShowDialog()
    End Sub
End Class
