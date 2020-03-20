Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Form4
#Region "Variables"
    Dim apppath As String = My.Application.Info.DirectoryPath 'Path to .exe directory
    Dim res As String = Path.GetFullPath(Application.StartupPath & "\..\..\Resources\") 'Path to Project Resources
    Dim TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp" 'Path to Temp
    Dim Local As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Regnum\PKMG5DC" 'Path to Local folder
    Dim card1 As New Card
#End Region

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckLocal()
        CheckTicket()
        UpdateChk()

        ''''
        With card1
            .numberOfCards = &H1
            .wonderCard = "3E0200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000470065007400200074006800650020004C00690062006500720074007900200050006100730073002100FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000403DB07FE074402010000000000000000000000000000000000000000000000"
            .gameCompatability = &HF0

            .language = &H2
            .langChecksum = &H83BC
            .startYear = &H7E4
            .startMonth = &H3
            .startDay = &H14
            .endYear = .startYear
            .endMonth = .startMonth
            .endDay = .startDay
        End With
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

    'Checks Local Folders
    Private Sub CheckLocal()
        Try
            Dim locals As String() = {Local.Replace("\PKMG5DC", ""), Local}
            For i = 0 To 1 Step 1
                Do While Not Directory.Exists(locals(i))
                    If Not Directory.Exists(locals(i)) Then
                        Directory.CreateDirectory(locals(i))
                    End If
                Loop
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
#Region "Functions"

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

    'Card Class
    Public Class Card
        Public numberOfCards As Byte
        '00 00 00
        Public wonderCard As String '0xCC
        '00 00
        Public gameCompatability As Byte
        '00
        Public eventText As String '0x1F8
        'FF FF
        '00
        Public language As Byte
        '00 00
        Public langChecksum As UShort
        '00 for 0x1EF0
        Public startYear As UShort
        Public startMonth As Byte
        Public startDay As Byte
        Public endYear As UShort
        Public endMonth As Byte
        Public endDay As Byte
        '00 for 0x5C
        '14 ????
        '00 00 00 00 00 00 00
    End Class
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
        Dim cc As String = Hex_Zeros(Hex(card1.numberOfCards), 2) & "000000" & card1.wonderCard & "0000" & Hex(card1.gameCompatability) & "00"
        For i = 0 To &H1F7 Step 1
            cc &= "FF"
        Next i
        cc &= "FFFF00" & Hex_Zeros(card1.language, 2) & "0000" & Little_Endian(Hex(card1.langChecksum), 4)
        For i = 0 To &H1EEF Step 1
            cc &= "00"
        Next i
        cc &= Little_Endian(Hex(card1.startYear), 4) & Hex_Zeros(Hex(card1.startMonth), 2) & Hex_Zeros(Hex(card1.startDay), 2) &
        Little_Endian(Hex(card1.endYear), 4) & Hex_Zeros(Hex(card1.endMonth), 2) & Hex_Zeros(Hex(card1.endDay), 2)
        For i = 0 To &H5B Step 1
            cc &= "00"
        Next i
        cc &= "1400000000000000"
        RichTextBox1.Text = cc
    End Sub

End Class