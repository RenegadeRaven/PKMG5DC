'Card Classes
Public Class Card5P
    Public data(&H2D8) As Byte
    Public Property Wondercard As Byte() '0xCC
        Get
            Return data.Take(&HCC)
        End Get
        Set(value As Byte())
            value.CopyTo(data, &H0)
            Output()
        End Set
    End Property
    '00 00
    Public Property GameCompatibility As Byte
        Get
            Return data(&HCE)
        End Get
        Set(ByVal value As Byte)
            data(&HCE) = value
            Output()
        End Set
    End Property
    Public Property White As Boolean
        Get
            Return (GameCompatibility And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            GameCompatibility = CByte((GameCompatibility And Not (1 << 4)) Or If(value, 1 << 4, 0))
            Output()
        End Set
    End Property
    Public Property Black As Boolean
        Get
            Return (GameCompatibility And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            GameCompatibility = CByte((GameCompatibility And Not (1 << 5)) Or If(value, 1 << 5, 0))
            Output()
        End Set
    End Property
    Public Property White2 As Boolean
        Get
            Return (GameCompatibility And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            GameCompatibility = CByte((GameCompatibility And Not (1 << 6)) Or If(value, 1 << 6, 0))
            Output()
        End Set
    End Property
    Public Property Black2 As Boolean
        Get
            Return (GameCompatibility And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            GameCompatibility = CByte((GameCompatibility And Not (1 << 7)) Or If(value, 1 << 7, 0))
            Output()
        End Set
    End Property
    '00
    Public Property EventText As String '0x1F8
        Get
            Return GetString(data, &HD0, 504)
        End Get
        Set(ByVal value As String)
            SetString(value, 252).CopyTo(data, &HD0)
            Output()
        End Set
    End Property
    'FF FF
    '00
    Public Property Language As Byte
        Get
            Return data(&H2CB)
        End Get
        Set(ByVal value As Byte)
            data(&H2CB) = value
            Output()
        End Set
    End Property
    '00 00
    Public Property LangChecksum As UShort
        Get
            Return BitConverter.ToUInt16(data, &H2CE)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(data, &H2CE)
            Output()
        End Set
    End Property
    '00 for 0x1EF0
    Public Property StartYear As UShort
        Get
            Return BitConverter.ToUInt16(data, &H2D0)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(data, &H2D0)
            Output()
        End Set
    End Property
    Public Property StartMonth As Byte
        Get
            Return data(&H2D2)
        End Get
        Set(ByVal value As Byte)
            data(&H2D2) = value
            Output()
        End Set
    End Property
    Public Property StartDay As Byte
        Get
            Return data(&H2D3)
        End Get
        Set(ByVal value As Byte)
            data(&H2D3) = value
            Output()
        End Set
    End Property
    Public Property EndYear As UShort
        Get
            Return BitConverter.ToUInt16(data, &H2D4)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(data, &H2D4)
            Output()
        End Set
    End Property
    Public Property EndMonth As Byte
        Get
            Return data(&H2D6)
        End Get
        Set(ByVal value As Byte)
            data(&H2D6) = value
            Output()
        End Set
    End Property
    Public Property EndDay As Byte
        Get
            Return data(&H2D7)
        End Get
        Set(ByVal value As Byte)
            data(&H2D7) = value
            Output()
        End Set
    End Property

    Public Sub Output()
        System.IO.File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Regnum\PKMG5DC" & "\cards\" & Main5.tc_Cards.SelectedTab.Text & ".bin", data)
    End Sub
End Class
Public Class Card5
    Public Data(&H16CF) As Byte

    Public Property NumberOfCards As Byte
        Get
            Return Data(&H0)
        End Get
        Set(ByVal value As Byte)
            Data(&H0) = value
        End Set
    End Property
    '00 00 00
    Public Property Cards(n As Byte) As Byte()
        Get
            Return Data.Skip(&H4 + (n * &H2D0)).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H4 + (n * &H2D0))
        End Set
    End Property
    Public Property Card_1 As Byte()
        Get
            Return Data.Skip(&H4).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H4)
        End Set
    End Property
    Public Property Card_2 As Byte()
        Get
            Return Data.Skip(&H2D4).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H2D4)
        End Set
    End Property
    Public Property Card_3 As Byte()
        Get
            Return Data.Skip(&H5A4).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H5A4)
        End Set
    End Property
    Public Property Card_4 As Byte()
        Get
            Return Data.Skip(&H874).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H874)
        End Set
    End Property
    Public Property Card_5 As Byte()
        Get
            Return Data.Skip(&HB44).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &HB44)
        End Set
    End Property
    Public Property Card_6 As Byte()
        Get
            Return Data.Skip(&HE14).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &HE14)
        End Set
    End Property
    Public Property Card_7 As Byte()
        Get
            Return Data.Skip(&H10E4).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H10E4)
        End Set
    End Property
    Public Property Card_8 As Byte()
        Get
            Return Data.Skip(&H13B4).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H13B4)
        End Set
    End Property
    Public Property StartYears(n As Byte) As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H1684 + (n * &H8))
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H1684 + (n * &H8))
        End Set
    End Property
    Public Property StartMonths(n As Byte) As Byte
        Get
            Return Data(&H1686 + (n * &H8))
        End Get
        Set(ByVal value As Byte)
            Data(&H1686 + (n * &H8)) = value
        End Set
    End Property
    Public Property StartDays(n As Byte) As Byte
        Get
            Return Data(&H1687 + (n * &H8))
        End Get
        Set(ByVal value As Byte)
            Data(&H1687 + (n * &H8)) = value
        End Set
    End Property
    Public Property EndYears(n As Byte) As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H1688 + (n * &H8))
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H1688 + (n * &H8))
        End Set
    End Property
    Public Property EndMonths(n As Byte) As Byte
        Get
            Return Data(&H168A + (n * &H8))
        End Get
        Set(ByVal value As Byte)
            Data(&H168A + (n * &H8)) = value
        End Set
    End Property
    Public Property EndDays(n As Byte) As Byte
        Get
            Return Data(&H168B + (n * &H8))
        End Get
        Set(ByVal value As Byte)
            Data(&H168B + (n * &H8)) = value
        End Set
    End Property

#Region "Dates 1"
    Public Property StartYear_1 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H1684)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H1684)
        End Set
    End Property
    Public Property StartMonth_1 As Byte
        Get
            Return Data(&H1686)
        End Get
        Set(ByVal value As Byte)
            Data(&H1686) = value
        End Set
    End Property
    Public Property StartDay_1 As Byte
        Get
            Return Data(&H1687)
        End Get
        Set(ByVal value As Byte)
            Data(&H1687) = value
        End Set
    End Property
    Public Property EndYear_1 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H1688)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H1688)
        End Set
    End Property
    Public Property EndMonth_1 As Byte
        Get
            Return Data(&H168A)
        End Get
        Set(ByVal value As Byte)
            Data(&H168A) = value
        End Set
    End Property
    Public Property EndDay_1 As Byte
        Get
            Return Data(&H168B)
        End Get
        Set(ByVal value As Byte)
            Data(&H168B) = value
        End Set
    End Property
#End Region
#Region "Dates 2"
    Public Property StartYear_2 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H168C)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H168C)
        End Set
    End Property
    Public Property StartMonth_2 As Byte
        Get
            Return Data(&H168E)
        End Get
        Set(ByVal value As Byte)
            Data(&H168E) = value
        End Set
    End Property
    Public Property StartDay_2 As Byte
        Get
            Return Data(&H168F)
        End Get
        Set(ByVal value As Byte)
            Data(&H168F) = value
        End Set
    End Property
    Public Property EndYear_2 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H1690)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H1690)
        End Set
    End Property
    Public Property EndMonth_2 As Byte
        Get
            Return Data(&H1692)
        End Get
        Set(ByVal value As Byte)
            Data(&H1692) = value
        End Set
    End Property
    Public Property EndDay_2 As Byte
        Get
            Return Data(&H1693)
        End Get
        Set(ByVal value As Byte)
            Data(&H1693) = value
        End Set
    End Property
#End Region
#Region "Dates 3"
    Public Property StartYear_3 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H1694)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H1694)
        End Set
    End Property
    Public Property StartMonth_3 As Byte
        Get
            Return Data(&H1696)
        End Get
        Set(ByVal value As Byte)
            Data(&H1696) = value
        End Set
    End Property
    Public Property StartDay_3 As Byte
        Get
            Return Data(&H1697)
        End Get
        Set(ByVal value As Byte)
            Data(&H1697) = value
        End Set
    End Property
    Public Property EndYear_3 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H1698)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H1698)
        End Set
    End Property
    Public Property EndMonth_3 As Byte
        Get
            Return Data(&H169A)
        End Get
        Set(ByVal value As Byte)
            Data(&H168A) = value
        End Set
    End Property
    Public Property EndDay_3 As Byte
        Get
            Return Data(&H169B)
        End Get
        Set(ByVal value As Byte)
            Data(&H169B) = value
        End Set
    End Property
#End Region
#Region "Dates 4"
    Public Property StartYear_4 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H169C)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H169C)
        End Set
    End Property
    Public Property StartMonth_4 As Byte
        Get
            Return Data(&H169E)
        End Get
        Set(ByVal value As Byte)
            Data(&H169E) = value
        End Set
    End Property
    Public Property StartDay_4 As Byte
        Get
            Return Data(&H169F)
        End Get
        Set(ByVal value As Byte)
            Data(&H169F) = value
        End Set
    End Property
    Public Property EndYear_4 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16A0)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16A0)
        End Set
    End Property
    Public Property EndMonth_4 As Byte
        Get
            Return Data(&H16A2)
        End Get
        Set(ByVal value As Byte)
            Data(&H16A2) = value
        End Set
    End Property
    Public Property EndDay_4 As Byte
        Get
            Return Data(&H16A3)
        End Get
        Set(ByVal value As Byte)
            Data(&H16A3) = value
        End Set
    End Property
#End Region
#Region "Dates 5"
    Public Property StartYear_5 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16A4)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16A4)
        End Set
    End Property
    Public Property StartMonth_5 As Byte
        Get
            Return Data(&H16A6)
        End Get
        Set(ByVal value As Byte)
            Data(&H16A6) = value
        End Set
    End Property
    Public Property StartDay_5 As Byte
        Get
            Return Data(&H16A7)
        End Get
        Set(ByVal value As Byte)
            Data(&H16A7) = value
        End Set
    End Property
    Public Property EndYear_5 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16A8)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16A8)
        End Set
    End Property
    Public Property EndMonth_5 As Byte
        Get
            Return Data(&H16AA)
        End Get
        Set(ByVal value As Byte)
            Data(&H16AA) = value
        End Set
    End Property
    Public Property EndDay_5 As Byte
        Get
            Return Data(&H16AB)
        End Get
        Set(ByVal value As Byte)
            Data(&H16AB) = value
        End Set
    End Property
#End Region
#Region "Dates 6"
    Public Property StartYear_6 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16AC)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16AC)
        End Set
    End Property
    Public Property StartMonth_6 As Byte
        Get
            Return Data(&H16AE)
        End Get
        Set(ByVal value As Byte)
            Data(&H16AE) = value
        End Set
    End Property
    Public Property StartDay_6 As Byte
        Get
            Return Data(&H16AF)
        End Get
        Set(ByVal value As Byte)
            Data(&H16AF) = value
        End Set
    End Property
    Public Property EndYear_6 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16B0)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16B0)
        End Set
    End Property
    Public Property EndMonth_6 As Byte
        Get
            Return Data(&H16B2)
        End Get
        Set(ByVal value As Byte)
            Data(&H16B2) = value
        End Set
    End Property
    Public Property EndDay_6 As Byte
        Get
            Return Data(&H16B3)
        End Get
        Set(ByVal value As Byte)
            Data(&H16B3) = value
        End Set
    End Property
#End Region
#Region "Dates 7"
    Public Property StartYear_7 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16B4)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16B4)
        End Set
    End Property
    Public Property StartMonth_7 As Byte
        Get
            Return Data(&H16B6)
        End Get
        Set(ByVal value As Byte)
            Data(&H16B6) = value
        End Set
    End Property
    Public Property StartDay_7 As Byte
        Get
            Return Data(&H16B7)
        End Get
        Set(ByVal value As Byte)
            Data(&H16B7) = value
        End Set
    End Property
    Public Property EndYear_7 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16B8)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16B8)
        End Set
    End Property
    Public Property EndMonth_7 As Byte
        Get
            Return Data(&H16BA)
        End Get
        Set(ByVal value As Byte)
            Data(&H16BA) = value
        End Set
    End Property
    Public Property EndDay_7 As Byte
        Get
            Return Data(&H16BB)
        End Get
        Set(ByVal value As Byte)
            Data(&H16BB) = value
        End Set
    End Property
#End Region
#Region "Dates 8"
    Public Property StartYear_8 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16BC)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16BC)
        End Set
    End Property
    Public Property StartMonth_8 As Byte
        Get
            Return Data(&H16BE)
        End Get
        Set(ByVal value As Byte)
            Data(&H16BE) = value
        End Set
    End Property
    Public Property StartDay_8 As Byte
        Get
            Return Data(&H16BF)
        End Get
        Set(ByVal value As Byte)
            Data(&H16BF) = value
        End Set
    End Property
    Public Property EndYear_8 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16C0)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16C0)
        End Set
    End Property
    Public Property EndMonth_8 As Byte
        Get
            Return Data(&H16C2)
        End Get
        Set(ByVal value As Byte)
            Data(&H16C2) = value
        End Set
    End Property
    Public Property EndDay_8 As Byte
        Get
            Return Data(&H16C3)
        End Get
        Set(ByVal value As Byte)
            Data(&H16C3) = value
        End Set
    End Property
#End Region
    '00 for 0x5C
    '14 ????
    '00 00 00 00 00 00 00
End Class
