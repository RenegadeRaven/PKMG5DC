Imports System.Text
Module PKMStrings
    Public Function GetString(data As Byte(), offset As Byte, count As UShort)
        Return Encoding.Unicode.GetString(data, offset, count).Replace(ChrW(&HFFFF), "").Replace(ChrW(&H0), "").Replace(ChrW(&HFFFE), vbLf)
    End Function
    Public Function SetString(ByVal value As String, ByVal maxLength As Integer)
        ' value = value.Replace(vbLf, ChrW(&HFFFE))
        If value.Length > maxLength Then value = value.Substring(0, maxLength)
        Do While value.Length < maxLength
            value &= ChrW(&HFFFF)
        Loop
        Dim temp As String = value & ChrW(&HFFFF)
        Return Encoding.Unicode.GetBytes(temp)
    End Function
End Module
