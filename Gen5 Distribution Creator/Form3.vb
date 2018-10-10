Public Class Form3
#Region "Variables"
    Dim tid As String
    Dim sid As String
    Dim ori As String
    Dim rib As String
    Dim ball As String
    Dim item As String
    Dim moves As String
    Dim dex As String
    Dim lang As String
    Dim nick As String
    Dim nat As String
    Dim emet As String
    Dim met As String
    Dim bloc As String
    Dim iv(5) As Integer '{HP, ATK, DEF, SPE, SpATK, SpDEF}
    Dim hiv(5) As String '^
    Dim otn As String
    Dim otg As String
    Dim egg As String

    Dim lvl As String = "00"
    Dim gen As String = "02"
    Dim abl As String = "04"
    Dim shy As String = "01"

    Dim fl(1) As String
    Dim id As Integer = 0

    Dim sender As Object
    Dim e As EventArgs

    Dim st As Boolean = True
#End Region
    Private Function lted(ByVal int As String, ByVal b As Integer)
        Dim s As String = Nothing
        Dim s2 As String = Nothing
        If int.Length < b Then
            s = "0" & int
        Else
            s = int
        End If
        If b = 8 Then
            s2 = s.Skip(6).ToArray() & s.Remove(6, 2).ToArray().Skip(4).ToArray() & s.Remove(4, 4).ToArray().Skip(2).ToArray() & s.Remove(2, 6).ToArray()
        ElseIf b = 4 Then
            s2 = s.Skip(2).ToArray() & s.Remove(2, 2).ToArray()
        End If
        Return s2
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Gen 5 PKM Files (*.pk5)|*.pk5|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Dim myFile As String = OpenFileDialog1.FileName
        Dim Fn() As String = myFile.Split("\")
        Dim fn2 As String = Fn(UBound(Fn))
        Label2.Text = fn2

        'RichTextBox1.Text = RichTextBox1.Text.Remove(8, 408)

        Dim myBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(myFile)
        Dim txtTemp As New System.Text.StringBuilder()
        For Each myByte As Byte In myBytes
            txtTemp.Append(myByte.ToString("X2"))
        Next
        RichTextBox1.Text = txtTemp.ToString()

        store()
        RichTextBox1.Text = Nothing
        construct()

        GroupBox1.Enabled = True
        TextBox1.Enabled = True
        NumericUpDown1.Enabled = True
        Label1.Enabled = True
        Label3.Enabled = True
        checks()
        'RichTextBox1.Text = RichTextBox1.Text.Insert(8, txtTemp.ToString())
        'RichTextBox1.Text = RichTextBox1.Text.Remove(352, 8)
        'RichTextBox1.Text = RichTextBox1.Text.Insert(352, "00000000")
    End Sub
    Private Function tgh(ByVal int As Integer, ByVal suplen As Integer)
        Dim gh As String = Hex(int)
        If gh.Length < suplen Then
            For i = 0 To suplen - gh.Length - 1 Step 1
                gh = "0" & gh
            Next i
        End If
        Return gh
    End Function
    Private Sub checks()
        If otg = "00" Then
            RadioButton4.PerformClick()
        ElseIf otg = "01" Then
            RadioButton5.PerformClick()
        End If
        If fl(0) = "1" Then
            RadioButton3.PerformClick()
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
        ElseIf fl(1) = "0" And fl(0) = "0" Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton1.PerformClick()
        ElseIf fl(1) = "1" And fl(0) = "0" Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton2.PerformClick()
        End If
        Dim at As Integer = Convert.ToInt32(nat, 16)
        ComboBox1.SelectedIndex = at
        RadioButton8.PerformClick()
        RadioButton13.PerformClick()
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
    End Sub
    Private Sub construct()
        If CheckBox1.Checked = True Then
            hiv(0) = tgh(iv(0), 2)
        ElseIf CheckBox1.Checked = False Then
            hiv(0) = "FF"
        End If
        If CheckBox2.Checked = True Then
            hiv(1) = tgh(iv(1), 2)
        ElseIf CheckBox2.Checked = False Then
            hiv(1) = "FF"
        End If
        If CheckBox3.Checked = True Then
            hiv(2) = tgh(iv(2), 2)
        ElseIf CheckBox3.Checked = False Then
            hiv(2) = "FF"
        End If
        If CheckBox6.Checked = True Then
            hiv(3) = tgh(iv(3), 2)
        ElseIf CheckBox6.Checked = False Then
            hiv(3) = "FF"
        End If
        If CheckBox4.Checked = True Then
            hiv(4) = tgh(iv(4), 2)
        ElseIf CheckBox4.Checked = False Then
            hiv(4) = "FF"
        End If
        If CheckBox5.Checked = True Then
            hiv(5) = tgh(iv(5), 2)
        ElseIf CheckBox5.Checked = False Then
            hiv(5) = "FF"
        End If
        Dim sat As String = Nothing
        If CheckBox7.Checked = True Then
            sat = "FF"
            ComboBox1.Enabled = False
        ElseIf CheckBox7.Checked = False Then
            sat = nat
            ComboBox1.Enabled = True
        End If

        RichTextBox1.Text = tid & sid & ori & "000000" & "00000000" & rib & ball & "00" & item & moves & dex & "00" & lang &
            nick & sat & gen & abl & shy & emet & met & lvl & "000000000000" & hiv(0) & hiv(1) & hiv(2) & hiv(3) & hiv(4) &
            hiv(5) & "00" & otn & otg & lvl & egg & "000000"
        'Dim ft As String = Nothing
        Dim mx As Integer = 148
        For i = 0 To mx - 2 Step 1
            'ft = ft & "F"
            RichTextBox1.Text = RichTextBox1.Text & "F"
        Next i
        'RichTextBox1.Text = RichTextBox1.Text & ft
        Dim hid As String = Hex(id)
        If hid.Length < 4 Then
            For i = 0 To 4 - hid.Length - 1 Step 1
                hid = "0" & hid
            Next i
        End If
        RichTextBox1.Text = RichTextBox1.Text & "0000" & "00000000" & lted(hid, 4) & "44" & "01" & "01" &
            "0000000000000000000000000000000000000000000000"
        st = False
        TextBox1_TextChanged(sender, e)
    End Sub
    Private Sub store()
        tid = RichTextBox1.Text.Remove(28).ToArray().Skip(24).ToArray()
        sid = RichTextBox1.Text.Remove(32).ToArray().Skip(28).ToArray()
        ori = RichTextBox1.Text.Remove(192).ToArray().Skip(190).ToArray()
        rib = RichTextBox1.Text.Remove(80).ToArray().Skip(76).ToArray()
        ball = RichTextBox1.Text.Remove(264).ToArray().Skip(262).ToArray()
        item = RichTextBox1.Text.Remove(24).ToArray().Skip(20).ToArray()
        moves = RichTextBox1.Text.Remove(96).ToArray().Skip(80).ToArray()
        dex = RichTextBox1.Text.Remove(20).ToArray().Skip(16).ToArray()
        lang = RichTextBox1.Text.Remove(48).ToArray().Skip(46).ToArray()
        nick = RichTextBox1.Text.Remove(188).ToArray().Skip(144).ToArray()
        nat = RichTextBox1.Text.Remove(132).ToArray().Skip(130).ToArray()
        emet = RichTextBox1.Text.Remove(256).ToArray().Skip(252).ToArray()
        met = RichTextBox1.Text.Remove(260).ToArray().Skip(256).ToArray()
        'lvl = RichTextBox1.Text.Remove().ToArray().Skip().ToArray()
        bloc = RichTextBox1.Text.Remove(120).ToArray().Skip(112).ToArray()
        Dim bl As String = lted(bloc, 8)
        Dim bi As Integer = Convert.ToInt32(bl, 16)
        Dim bb As String = Convert.ToString(bi, 2)
        If bb.Length < 32 Then
            For i = 0 To 32 - bb.Length - 1 Step 1
                bb = "0" & bb
            Next i
        End If
        iv(0) = Convert.ToInt32(bb.Skip(27).ToArray(), 2)
        iv(1) = Convert.ToInt32(bb.Remove(27).ToArray().Skip(22).ToArray(), 2)
        iv(2) = Convert.ToInt32(bb.Remove(22).ToArray().Skip(17).ToArray(), 2)
        iv(3) = Convert.ToInt32(bb.Remove(17).ToArray().Skip(12).ToArray(), 2)
        iv(4) = Convert.ToInt32(bb.Remove(12).ToArray().Skip(7).ToArray(), 2)
        iv(5) = Convert.ToInt32(bb.Remove(7).ToArray().Skip(2).ToArray(), 2)
        egg = "0" & bb.Remove(3).ToArray().Skip(1).ToArray()
        otn = RichTextBox1.Text.Remove(240).ToArray().Skip(208).ToArray()
        Dim o As String = RichTextBox1.Text.Remove(266).ToArray().Skip(264).ToArray()
        Dim oi As Integer = Convert.ToInt32(o, 16)
        Dim ob As String = Convert.ToString(oi, 2)
        If ob.Length < 8 Then
            For i = 0 To 8 - ob.Length - 1 Step 1
                ob = "0" & ob
            Next i
        End If
        otg = "0" & ob.Remove(1)
        Debug.Print(ob)

        Dim wf As String = RichTextBox1.Text.Remove(130).ToArray().Skip(128).ToArray()
        Dim wi As Integer = Convert.ToInt32(wf, 16)
        Dim wb As String = Convert.ToString(wi, 2)
        If wb.Length < 8 Then
            For i = 0 To 8 - wb.Length - 1 Step 1
                wb = "0" & wb
            Next i
        End If
        fl(1) = Convert.ToInt32(wb.Remove(7).ToArray().Skip(6).ToArray(), 2)
        fl(0) = Convert.ToInt32(wb.Remove(6).ToArray().Skip(5).ToArray(), 2)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If st = False Then
            If TextBox1.Text <> "" Then
                Dim ch As Char() = TextBox1.Text.ToCharArray
                Dim ft As String = Nothing
                Dim n As Integer = 0
                For n = 0 To UBound(ch) Step 1
                    Dim t As String = Hex(Asc(ch(n)))
                    If t.Length < 2 Then
                        t = "0" & t
                    End If
                    ft = ft & t & "00"
                Next n
                'If ft.Contains("0A00") Then
                '    ft = ft.Replace("0A00", "FEFF")
                'End If
                Dim mx As Integer = 148
                Dim mn As Integer = ft.Length
                Dim req As Integer = mx - mn

                For n = 0 To req - 1 Step 1
                    ft = ft & "F"
                Next n

                RichTextBox1.Text = RichTextBox1.Text.Remove(192, mx)
                RichTextBox1.Text = RichTextBox1.Text.Insert(192, ft)
            Else
                Dim ft As String = ""
                Dim mx As Integer = 148
                For i = 0 To mx - 1 Step 1
                    ft = ft & "F"
                Next i
                RichTextBox1.Text = RichTextBox1.Text.Remove(192, mx)
                RichTextBox1.Text = RichTextBox1.Text.Insert(192, ft)
            End If
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        id = NumericUpDown1.Value
        construct()
    End Sub
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        lvl = Hex(NumericUpDown2.Value)
        If lvl.Length < 2 Then
            lvl = "0" & lvl
        End If
        construct()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            gen = "00"
        End If
        construct()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            gen = "01"
        End If
        construct()
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            gen = "02"
        End If
        construct()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            otg = "00"
        End If
        construct()
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            otg = "01"
        End If
        construct()
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            otg = "03"
        End If
        construct()
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            shy = "00"
        End If
        construct()
    End Sub
    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            shy = "01"
        End If
        construct()
    End Sub
    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            shy = "02"
        End If
        construct()
    End Sub
    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            abl = "00"
        End If
        construct()
    End Sub
    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            abl = "01"
        End If
        construct()
    End Sub
    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            abl = "02"
        End If
        construct()
    End Sub
    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            abl = "03"
        End If
        construct()
    End Sub
    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            abl = "04"
        End If
        construct()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG Then
        Size = New Size(876, 489)
#Else
        Size = New Size(488, 489)
#End If
        GroupBox1.Enabled = False
        TextBox1.Enabled = False
        NumericUpDown1.Enabled = False
        Label1.Enabled = False
        Label3.Enabled = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        construct()
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        construct()
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        construct()
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        construct()
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        construct()
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        construct()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        nat = tgh(ComboBox1.SelectedIndex, 2)
        construct()
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        construct()
    End Sub
    Public Sub New()
        InitializeComponent()
        TextBox1.Text = "Custom"
        TextBox1.ForeColor = Color.Gray
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = Nothing Then
            TextBox1.Text = "Custom"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Custom" Then
            TextBox1.Text = Nothing
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.RichTextBox1.Text = Form1.RichTextBox1.Text.Remove(8, 408)
        Form1.RichTextBox1.Text = Form1.RichTextBox1.Text.Insert(8, RichTextBox1.Text)
        Form1.RichTextBox1.Text = Form1.RichTextBox1.Text.Remove(352, 8)
        Form1.RichTextBox1.Text = Form1.RichTextBox1.Text.Insert(352, "00000000")
        Form1.Label2.Text = NumericUpDown1.Value & " - " & TextBox1.Text & " (Custom)"
        Close()
    End Sub
End Class