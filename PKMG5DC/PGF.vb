Public Class PGF
    Public Data(&HCB) As Byte
    Public Property TID As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H0)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H0)
        End Set
    End Property
    Public Property SID As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H2)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H2)
        End Set
    End Property
    Public Property Origin As Byte
        Get
            Return Data(&H4)
        End Get
        Set(ByVal value As Byte)
            Data(&H4) = value
        End Set
    End Property
    '00 00 00
    Public Property PID As UInteger
        Get
            Return BitConverter.ToUInt32(Data, &H8)
        End Get
        Set(ByVal value As UInteger)
            BitConverter.GetBytes(value).CopyTo(Data, &H8)
        End Set
    End Property
    Public Property Ribbons1 As Byte
        Get
            Return Data(&HC)
        End Get
        Set(ByVal value As Byte)
            Data(&HC) = value
        End Set
    End Property
    Public Property Ribbons2 As Byte
        Get
            Return Data(&HD)
        End Get
        Set(ByVal value As Byte)
            Data(&HD) = value
        End Set
    End Property
#Region "Ribbons"
    Public Property RibbonCountry As Boolean
        Get
            Return (Ribbons1 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Ribbons1 = CByte((Ribbons1 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonNational As Boolean
        Get
            Return (Ribbons1 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Ribbons1 = CByte((Ribbons1 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonEarth As Boolean
        Get
            Return (Ribbons1 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Ribbons1 = CByte((Ribbons1 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonWorld As Boolean
        Get
            Return (Ribbons1 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Ribbons1 = CByte((Ribbons1 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonClassic As Boolean
        Get
            Return (Ribbons1 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Ribbons1 = CByte((Ribbons1 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonPremier As Boolean
        Get
            Return (Ribbons1 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Ribbons1 = CByte((Ribbons1 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonEvent As Boolean
        Get
            Return (Ribbons1 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Ribbons1 = CByte((Ribbons1 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonBirthday As Boolean
        Get
            Return (Ribbons1 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Ribbons1 = CByte((Ribbons1 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonSpecial As Boolean
        Get
            Return (Ribbons2 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Ribbons2 = CByte((Ribbons2 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonSouvenir As Boolean
        Get
            Return (Ribbons2 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Ribbons2 = CByte((Ribbons2 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonWishing As Boolean
        Get
            Return (Ribbons2 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Ribbons2 = CByte((Ribbons2 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonChampionBattle As Boolean
        Get
            Return (Ribbons2 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Ribbons2 = CByte((Ribbons2 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonChampionRegional As Boolean
        Get
            Return (Ribbons2 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Ribbons2 = CByte((Ribbons2 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonChampionNational As Boolean
        Get
            Return (Ribbons2 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Ribbons2 = CByte((Ribbons2 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonChampionWorld As Boolean
        Get
            Return (Ribbons2 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Ribbons2 = CByte((Ribbons2 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
#End Region
    Public Property Ball As Byte
        Get
            Return Data(&HE)
        End Get
        Set(ByVal value As Byte)
            Data(&HE) = value
        End Set
    End Property
    '00
    Public Property Item As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H10)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H10)
        End Set
    End Property
    Public Property Move1 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H12)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H12)
        End Set
    End Property
    Public Property Move2 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H14)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H14)
        End Set
    End Property
    Public Property Move3 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H16)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H16)
        End Set
    End Property
    Public Property Move4 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H18)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H18)
        End Set
    End Property
    Public Property Dex As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H1A)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H1A)
        End Set
    End Property
    '00
    Public Property Language As Byte
        Get
            Return Data(&H1D)
        End Get
        Set(ByVal value As Byte)
            Data(&H1D) = value
        End Set
    End Property
    Public Property Nickname As String '0x14
        Get
            Return GetString(Data, &H1E, 20)
        End Get
        Set(ByVal value As String)
            SetString(value, 10).CopyTo(Data, &H1E)
        End Set
    End Property
    'FF FF
    Public Property Nature As Byte
        Get
            Return Data(&H34)
        End Get
        Set(value As Byte)
            Data(&H34) = value
        End Set
    End Property
    Public Property Gender As Byte
        Get
            Return Data(&H35)
        End Get
        Set(value As Byte)
            Data(&H35) = value
        End Set
    End Property
    Public Property Ability As Byte
        Get
            Return Data(&H36)
        End Get
        Set(ByVal value As Byte)
            Data(&H36) = value
        End Set
    End Property
    Public Property Shiny As Byte
        Get
            Return Data(&H37)
        End Get
        Set(ByVal value As Byte)
            Data(&H37) = value
        End Set
    End Property
    Public Property EggMet As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H38)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H38)
        End Set
    End Property
    Public Property Met As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H3A)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H3A)
        End Set
    End Property
    Public Property Level As Byte
        Get
            Return Data(&H5B)
        End Get
        Set(ByVal value As Byte)
            Data(&H3C) = value
            Data(&H5B) = value
        End Set
    End Property
    Public Property CV_Cool As Byte
        Get
            Return Data(&H3D)
        End Get
        Set(ByVal value As Byte)
            Data(&H3D) = value
        End Set
    End Property
    Public Property CV_Beauty As Byte
        Get
            Return Data(&H3E)
        End Get
        Set(ByVal value As Byte)
            Data(&H3E) = value
        End Set
    End Property
    Public Property CV_Cute As Byte
        Get
            Return Data(&H3F)
        End Get
        Set(ByVal value As Byte)
            Data(&H3F) = value
        End Set
    End Property
    Public Property CV_Smart As Byte
        Get
            Return Data(&H40)
        End Get
        Set(ByVal value As Byte)
            Data(&H40) = value
        End Set
    End Property
    Public Property CV_Tough As Byte
        Get
            Return Data(&H41)
        End Get
        Set(ByVal value As Byte)
            Data(&H41) = value
        End Set
    End Property
    Public Property CV_Sheen As Byte
        Get
            Return Data(&H42)
        End Get
        Set(ByVal value As Byte)
            Data(&H42) = value
        End Set
    End Property
    Public Property IV_HP As Byte
        Get
            Return Data(&H43)
        End Get
        Set(ByVal value As Byte)
            Data(&H43) = value
        End Set
    End Property
    Public Property IV_ATK As Byte
        Get
            Return Data(&H44)
        End Get
        Set(ByVal value As Byte)
            Data(&H44) = value
        End Set
    End Property
    Public Property IV_DEF As Byte
        Get
            Return Data(&H45)
        End Get
        Set(ByVal value As Byte)
            Data(&H45) = value
        End Set
    End Property
    Public Property IV_SPE As Byte
        Get
            Return Data(&H46)
        End Get
        Set(ByVal value As Byte)
            Data(&H46) = value
        End Set
    End Property
    Public Property IV_SPA As Byte
        Get
            Return Data(&H47)
        End Get
        Set(ByVal value As Byte)
            Data(&H47) = value
        End Set
    End Property
    Public Property IV_SPD As Byte
        Get
            Return Data(&H48)
        End Get
        Set(ByVal value As Byte)
            Data(&H48) = value
        End Set
    End Property
    '00
    Public Property OT_Name As String '0xE
        Get
            Return GetString(Data, &H4A, &HE)
        End Get
        Set(ByVal value As String)
            SetString(value, 7).CopyTo(Data, &H4A)
        End Set
    End Property
    'FF FF
    Public Property OT_Gender As Byte
        Get
            Return Data(&H5A)
        End Get
        Set(ByVal value As Byte)
            Data(&H5A) = value
        End Set
    End Property
    'Level
    Public Property Egg As Byte
        Get
            Return Data(&H5C)
        End Get
        Set(ByVal value As Byte)
            Data(&H5C) = value
        End Set
    End Property
    '00 00 00
    Public Property EventTitle As String '0x48
        Get
            Return GetString(Data, &H60, &H48)
        End Get
        Set(ByVal value As String)
            SetString(value, 36).CopyTo(Data, &H60)
        End Set
    End Property
    'FF FF
    '00 00
    Public Property RecieveDay As Byte
        Get
            Return Data(&HAC)
        End Get
        Set(ByVal value As Byte)
            Data(&HAC) = value
        End Set
    End Property
    Public Property RecieveMonth As Byte
        Get
            Return Data(&HAD)
        End Get
        Set(ByVal value As Byte)
            Data(&HAD) = value
        End Set
    End Property
    Public Property RecieveYear As UShort
        Get
            Return BitConverter.ToUInt16(Data, &HAE)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &HAE)
        End Set
    End Property
    Public Property CardID As UShort
        Get
            Return BitConverter.ToUInt16(Data, &HB0)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &HB0)
        End Set
    End Property
    Public Property CardFrom As Byte
        Get
            Return Data(&HB2)
        End Get
        Set(ByVal value As Byte)
            Data(&HB2) = value
        End Set
    End Property
    Public Property CardType As Byte
        Get
            Return Data(&HB3)
        End Get
        Set(ByVal value As Byte)
            Data(&HB3) = value
        End Set
    End Property
    Public Property Status As Byte
        Get
            Return Data(&HB4)
        End Get
        Set(ByVal value As Byte)
            Data(&HB4) = value
        End Set
    End Property
    '00 for 0x17
End Class
