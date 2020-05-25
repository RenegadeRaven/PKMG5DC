Imports System.Text

Module Common
    'Custom MsgBox
    Public Function MsgB(ByVal mes As String, Optional ByVal numB As Integer = 1, Optional ByVal but1 As String = "OK", Optional ByVal but2 As String = "Cancel", Optional ByVal but3 As String = "", Optional ByVal head As String = "")
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
            'Form4.Close()
            Form.ActiveForm.Close()
        End If
        Return Ans
    End Function

    'Adds needed zeros to hex string
    Public Function Hex_Zeros(ByVal hex_value As String, ByVal length As Integer)
        Dim Str As String = hex_value.ToUpper
        Do While Str.Length < length
            Str = "0" & Str
        Loop
        Return Str
    End Function

    'Encrypts hex string with, you guessed it, Little Endian
    Public Function Little_Endian(ByVal hex_value As String, ByVal length As Integer)
        Dim startStr As String = Hex_Zeros(hex_value, length)
        Dim endStr As String = Nothing
        If length = 8 Then
            endStr = startStr.Skip(6).ToArray() & startStr.Remove(6, 2).ToArray().Skip(4).ToArray() & startStr.Remove(4, 4).ToArray().Skip(2).ToArray() & startStr.Remove(2, 6).ToArray()
        ElseIf length = 4 Then
            endStr = startStr.Skip(2).ToArray() & startStr.Remove(2, 2).ToArray()
        End If
        Return endStr
    End Function

    Public Function HexStringToByteArray(ByRef strInput As String) As Byte()
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
    Public Sub Save(myFile, data)
        Dim myBytes As Byte() = HexStringToByteArray(Main.RichTextBox1.Text)
        My.Computer.FileSystem.WriteAllBytes(myFile, myBytes, False)
    End Sub

    Public Function ByteArrayToHexString(ByVal myFile As String)
        Dim myBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(myFile)
        Dim txtTemp As New System.Text.StringBuilder()
        For Each myByte As Byte In myBytes
            txtTemp.Append(myByte.ToString("X2"))
        Next
        Return txtTemp.ToString()
    End Function
    Public Function GetString(data As Byte(), offset As Byte, count As UShort)
        Return Encoding.Unicode.GetString(data, offset, count).Replace(ChrW(&HFFFF), "").Replace(ChrW(&H0), "")
    End Function
    Public Function SetString(ByVal value As String, ByVal maxLength As Integer)
        If value.Length > maxLength Then value = value.Substring(0, maxLength)
        Do While value.Length < maxLength
            value &= ChrW(&HFFFF)
        Loop
        Dim temp As String = value & ChrW(&HFFFF)
        Return Encoding.Unicode.GetBytes(temp)
    End Function
End Module
