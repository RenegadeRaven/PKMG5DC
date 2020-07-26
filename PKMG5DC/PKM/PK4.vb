Public Class PK4
    Public Data As Byte()
    Public Property PID As UInteger
        Get
            Return BitConverter.ToUInt32(Data, &H0)
        End Get
        Set(ByVal value As UInteger)
            BitConverter.GetBytes(value).CopyTo(Data, &H0)
        End Set
    End Property
    '00 00
    Public Property Checksum As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H6)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H6)
        End Set
    End Property
    Public Property Dex As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H8)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H8)
        End Set
    End Property
    Public Property Item As UShort
        Get
            Return BitConverter.ToUInt16(Data, &HA)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &HA)
        End Set
    End Property
    Public Property TID As UShort
        Get
            Return BitConverter.ToUInt16(Data, &HC)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &HC)
        End Set
    End Property
    Public Property SID As UShort
        Get
            Return BitConverter.ToUInt16(Data, &HE)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &HE)
        End Set
    End Property
    Public Property Exp As UInteger
        Get
            Return BitConverter.ToUInt32(Data, &H10)
        End Get
        Set(ByVal value As UInteger)
            BitConverter.GetBytes(value).CopyTo(Data, &H10)
        End Set
    End Property
    Public Property Friendship As Byte 'Egg Steps
        Get
            Return Data(&H14)
        End Get
        Set(ByVal value As Byte)
            Data(&H14) = value
        End Set
    End Property
    Public Property Ability As Byte
        Get
            Return Data(&H15)
        End Get
        Set(ByVal value As Byte)
            Data(&H15) = value
        End Set
    End Property
    Public Property Markings As Byte
        Get
            Return Data(&H16)
        End Get
        Set(ByVal value As Byte)
            Data(&H16) = value
        End Set
    End Property
    Public Property Language As Byte
        Get
            Return Data(&H17)
        End Get
        Set(ByVal value As Byte)
            Data(&H17) = value
        End Set
    End Property
    Public Property EV_HP As Byte
        Get
            Return Data(&H18)
        End Get
        Set(ByVal value As Byte)
            Data(&H18) = value
        End Set
    End Property
    Public Property EV_ATK As Byte
        Get
            Return Data(&H19)
        End Get
        Set(ByVal value As Byte)
            Data(&H19) = value
        End Set
    End Property
    Public Property EV_DEF As Byte
        Get
            Return Data(&H1A)
        End Get
        Set(ByVal value As Byte)
            Data(&H1A) = value
        End Set
    End Property
    Public Property EV_SPE As Byte
        Get
            Return Data(&H1B)
        End Get
        Set(ByVal value As Byte)
            Data(&H1B) = value
        End Set
    End Property
    Public Property EV_SPA As Byte
        Get
            Return Data(&H1C)
        End Get
        Set(ByVal value As Byte)
            Data(&H1C) = value
        End Set
    End Property
    Public Property EV_SPD As Byte
        Get
            Return Data(&H1D)
        End Get
        Set(ByVal value As Byte)
            Data(&H1D) = value
        End Set
    End Property
    Public Property CV_Cool As Byte
        Get
            Return Data(&H1E)
        End Get
        Set(ByVal value As Byte)
            Data(&H18) = value
        End Set
    End Property
    Public Property CV_Beauty As Byte
        Get
            Return Data(&H1F)
        End Get
        Set(ByVal value As Byte)
            Data(&H19) = value
        End Set
    End Property
    Public Property CV_Cute As Byte
        Get
            Return Data(&H20)
        End Get
        Set(ByVal value As Byte)
            Data(&H20) = value
        End Set
    End Property
    Public Property CV_Smart As Byte
        Get
            Return Data(&H21)
        End Get
        Set(ByVal value As Byte)
            Data(&H21) = value
        End Set
    End Property
    Public Property CV_Tough As Byte
        Get
            Return Data(&H22)
        End Get
        Set(ByVal value As Byte)
            Data(&H22) = value
        End Set
    End Property
    Public Property CV_Sheen As Byte
        Get
            Return Data(&H23)
        End Get
        Set(ByVal value As Byte)
            Data(&H23) = value
        End Set
    End Property
    Public Property Sinnoh1_Ribbons1 As Byte
        Get
            Return Data(&H24)
        End Get
        Set(ByVal value As Byte)
            Data(&H24) = value
        End Set
    End Property
    Public Property Sinnoh1_Ribbons2 As Byte
        Get
            Return Data(&H25)
        End Get
        Set(ByVal value As Byte)
            Data(&H25) = value
        End Set
    End Property
    Public Property Unova_Ribbons1 As Byte
        Get
            Return Data(&H26)
        End Get
        Set(ByVal value As Byte)
            Data(&H26) = value
        End Set
    End Property
    Public Property Unova_Ribbons2 As Byte
        Get
            Return Data(&H27)
        End Get
        Set(ByVal value As Byte)
            Data(&H27) = value
        End Set
    End Property
#Region "Ribbons"
    Public Property RibbonChampionSinnoh As Boolean
        Get
            Return (Sinnoh1_Ribbons1 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons1 = CByte((Sinnoh1_Ribbons1 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonAbility As Boolean
        Get
            Return (Sinnoh1_Ribbons1 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons1 = CByte((Sinnoh1_Ribbons1 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonAbilityGreat As Boolean
        Get
            Return (Sinnoh1_Ribbons1 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons1 = CByte((Sinnoh1_Ribbons1 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonAbilityDouble As Boolean
        Get
            Return (Sinnoh1_Ribbons1 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons1 = CByte((Sinnoh1_Ribbons1 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonAbilityMulti As Boolean
        Get
            Return (Sinnoh1_Ribbons1 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons1 = CByte((Sinnoh1_Ribbons1 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonAbilityPair As Boolean
        Get
            Return (Sinnoh1_Ribbons1 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons1 = CByte((Sinnoh1_Ribbons1 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonAbilityWorld As Boolean
        Get
            Return (Sinnoh1_Ribbons1 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons1 = CByte((Sinnoh1_Ribbons1 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonAlert As Boolean
        Get
            Return (Sinnoh1_Ribbons1 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons1 = CByte((Sinnoh1_Ribbons1 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonShock As Boolean
        Get
            Return (Sinnoh1_Ribbons2 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons2 = CByte((Sinnoh1_Ribbons2 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonDowncast As Boolean
        Get
            Return (Sinnoh1_Ribbons2 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons2 = CByte((Sinnoh1_Ribbons2 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonCareless As Boolean
        Get
            Return (Sinnoh1_Ribbons2 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons2 = CByte((Sinnoh1_Ribbons2 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonRelax As Boolean
        Get
            Return (Sinnoh1_Ribbons2 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons2 = CByte((Sinnoh1_Ribbons2 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonSnooze As Boolean
        Get
            Return (Sinnoh1_Ribbons2 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons2 = CByte((Sinnoh1_Ribbons2 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonSmile As Boolean
        Get
            Return (Sinnoh1_Ribbons2 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons2 = CByte((Sinnoh1_Ribbons2 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonGorgeous As Boolean
        Get
            Return (Sinnoh1_Ribbons2 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons2 = CByte((Sinnoh1_Ribbons2 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonRoyal As Boolean
        Get
            Return (Sinnoh1_Ribbons2 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Sinnoh1_Ribbons2 = CByte((Sinnoh1_Ribbons2 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonGorgeousRoyal As Boolean
        Get
            Return (Unova_Ribbons1 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Unova_Ribbons1 = CByte((Unova_Ribbons1 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonFootprint As Boolean
        Get
            Return (Unova_Ribbons1 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Unova_Ribbons1 = CByte((Unova_Ribbons1 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonRecord As Boolean
        Get
            Return (Unova_Ribbons1 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Unova_Ribbons1 = CByte((Unova_Ribbons1 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonEvent As Boolean
        Get
            Return (Unova_Ribbons1 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Unova_Ribbons1 = CByte((Unova_Ribbons1 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonLegend As Boolean
        Get
            Return (Unova_Ribbons1 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Unova_Ribbons1 = CByte((Unova_Ribbons1 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonChampionWorld As Boolean
        Get
            Return (Unova_Ribbons1 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Unova_Ribbons1 = CByte((Unova_Ribbons1 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonBirthday As Boolean
        Get
            Return (Unova_Ribbons1 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Unova_Ribbons1 = CByte((Unova_Ribbons1 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonSpecial As Boolean
        Get
            Return (Unova_Ribbons1 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Unova_Ribbons1 = CByte((Unova_Ribbons1 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonSouvenir As Boolean
        Get
            Return (Unova_Ribbons2 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Unova_Ribbons2 = CByte((Unova_Ribbons2 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonWishing As Boolean
        Get
            Return (Unova_Ribbons2 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Unova_Ribbons2 = CByte((Unova_Ribbons2 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonClassic As Boolean
        Get
            Return (Unova_Ribbons2 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Unova_Ribbons2 = CByte((Unova_Ribbons2 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonPremier As Boolean
        Get
            Return (Unova_Ribbons2 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Unova_Ribbons2 = CByte((Unova_Ribbons2 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
#End Region
    Public Property Move1 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H28)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H28)
        End Set
    End Property
    Public Property Move2 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H2A)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H2A)
        End Set
    End Property
    Public Property Move3 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H2C)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H2C)
        End Set
    End Property
    Public Property Move4 As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H2E)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H2E)
        End Set
    End Property
    Public Property Move1_PP As Byte
        Get
            Return BitConverter.ToUInt16(Data, &H30)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(Data, &H30)
        End Set
    End Property
    Public Property Move2_PP As Byte
        Get
            Return BitConverter.ToUInt16(Data, &H31)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(Data, &H31)
        End Set
    End Property
    Public Property Move3_PP As Byte
        Get
            Return BitConverter.ToUInt16(Data, &H32)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(Data, &H32)
        End Set
    End Property
    Public Property Move4_PP As Byte
        Get
            Return BitConverter.ToUInt16(Data, &H33)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(Data, &H33)
        End Set
    End Property
    Public Property Move1_PPUps As Byte
        Get
            Return BitConverter.ToUInt16(Data, &H34)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(Data, &H34)
        End Set
    End Property
    Public Property Move2_PPUps As Byte
        Get
            Return BitConverter.ToUInt16(Data, &H35)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(Data, &H35)
        End Set
    End Property
    Public Property Move3_PPUps As Byte
        Get
            Return BitConverter.ToUInt16(Data, &H36)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(Data, &H36)
        End Set
    End Property
    Public Property Move4_PPUps As Byte
        Get
            Return BitConverter.ToUInt16(Data, &H37)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(Data, &H37)
        End Set
    End Property
    Public Property BlocIV As UInteger
        Get
            Return BitConverter.ToUInt32(Data, &H38)
        End Get
        Set(ByVal value As UInteger)
            BitConverter.GetBytes(value).CopyTo(Data, &H38)
        End Set
    End Property
    Public Property IV_HP As Byte
        Get
            Return (BlocIV >> 0) And &H1F
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 0)) Or (If(value > 31, 31UI, value) << 0))
        End Set
    End Property
    Public Property IV_ATK As Byte
        Get
            Return (BlocIV >> 5) And &H1F
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 5)) Or (If(value > 31, 31UI, value) << 5))
        End Set
    End Property
    Public Property IV_DEF As Byte
        Get
            Return (BlocIV >> 10) And &H1F
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 10)) Or (If(value > 31, 31UI, value) << 10))
        End Set
    End Property
    Public Property IV_SPE As Byte
        Get
            Return (BlocIV >> 15) And &H1F
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 15)) Or (If(value > 31, 31UI, value) << 15))
        End Set
    End Property
    Public Property IV_SPA As Byte
        Get
            Return (BlocIV >> 20) And &H1F
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 20)) Or (If(value > 31, 31UI, value) << 20))
        End Set
    End Property
    Public Property IV_SPD As Byte
        Get
            Return (BlocIV >> 25) And &H1F
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 25)) Or (If(value > 31, 31UI, value) << 25))
        End Set
    End Property
    Public Property IsEgg As Boolean
        Get
            Return ((BlocIV >> 30) And 1) = 1
        End Get
        Set(value As Boolean)
            BlocIV = ((BlocIV And Not (&H40000000UI)) Or If(value, &H40000000UI, 0UI))
        End Set
    End Property
    Public Property IsNicknamed As Boolean
        Get
            Return ((BlocIV >> 31) And 1) = 1
        End Get
        Set(value As Boolean)
            BlocIV = ((BlocIV And (&H7FFFFFFFUI)) Or If(value, &H80000000UI, 0UI))
        End Set
    End Property
    Public Property Hoenn1_Ribbons1 As Byte
        Get
            Return Data(&H3C)
        End Get
        Set(ByVal value As Byte)
            Data(&H3C) = value
        End Set
    End Property
    Public Property Hoenn1_Ribbons2 As Byte
        Get
            Return Data(&H3D)
        End Get
        Set(ByVal value As Byte)
            Data(&H3D) = value
        End Set
    End Property
    Public Property Hoenn2_Ribbons1 As Byte
        Get
            Return Data(&H3E)
        End Get
        Set(ByVal value As Byte)
            Data(&H3E) = value
        End Set
    End Property
    Public Property Hoenn2_Ribbons2 As Byte
        Get
            Return Data(&H3F)
        End Get
        Set(ByVal value As Byte)
            Data(&H3F) = value
        End Set
    End Property
#Region "Hoenn Ribbons"
    Public Property RibbonG3Cool As Boolean
        Get
            Return (Hoenn1_Ribbons1 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons1 = CByte((Hoenn1_Ribbons1 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonG3CoolSuper As Boolean
        Get
            Return (Hoenn1_Ribbons1 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons1 = CByte((Hoenn1_Ribbons1 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonG3CoolHyper As Boolean
        Get
            Return (Hoenn1_Ribbons1 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons1 = CByte((Hoenn1_Ribbons1 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonG3CoolMaster As Boolean
        Get
            Return (Hoenn1_Ribbons1 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons1 = CByte((Hoenn1_Ribbons1 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonG3Beauty As Boolean
        Get
            Return (Hoenn1_Ribbons1 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons1 = CByte((Hoenn1_Ribbons1 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonG3BeautySuper As Boolean
        Get
            Return (Hoenn1_Ribbons1 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons1 = CByte((Hoenn1_Ribbons1 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonG3BeautyHyper As Boolean
        Get
            Return (Hoenn1_Ribbons1 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons1 = CByte((Hoenn1_Ribbons1 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonG3BeautyMaster As Boolean
        Get
            Return (Hoenn1_Ribbons1 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons1 = CByte((Hoenn1_Ribbons1 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonG3Cute As Boolean
        Get
            Return (Hoenn1_Ribbons2 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons2 = CByte((Hoenn1_Ribbons2 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonG3CuteSuper As Boolean
        Get
            Return (Hoenn1_Ribbons2 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons2 = CByte((Hoenn1_Ribbons2 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonG3CuteHyper As Boolean
        Get
            Return (Hoenn1_Ribbons2 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons2 = CByte((Hoenn1_Ribbons2 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonG3CuteMaster As Boolean
        Get
            Return (Hoenn1_Ribbons2 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons2 = CByte((Hoenn1_Ribbons2 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonG3Smart As Boolean
        Get
            Return (Hoenn1_Ribbons2 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons2 = CByte((Hoenn1_Ribbons2 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonG3SmartSuper As Boolean
        Get
            Return (Hoenn1_Ribbons2 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons2 = CByte((Hoenn1_Ribbons2 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonG3SmartHyper As Boolean
        Get
            Return (Hoenn1_Ribbons2 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons2 = CByte((Hoenn1_Ribbons2 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonG3SmartMaster As Boolean
        Get
            Return (Hoenn1_Ribbons2 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Hoenn1_Ribbons2 = CByte((Hoenn1_Ribbons2 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonG3Tough As Boolean
        Get
            Return (Hoenn2_Ribbons1 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons1 = CByte((Hoenn2_Ribbons1 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonG3ToughSuper As Boolean
        Get
            Return (Hoenn2_Ribbons1 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons1 = CByte((Hoenn2_Ribbons1 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonG3ToughHyper As Boolean
        Get
            Return (Hoenn2_Ribbons1 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons1 = CByte((Hoenn2_Ribbons1 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonG3ToughMaster As Boolean
        Get
            Return (Hoenn2_Ribbons1 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons1 = CByte((Hoenn2_Ribbons1 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonChampionG3Hoenn As Boolean
        Get
            Return (Hoenn2_Ribbons1 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons1 = CByte((Hoenn2_Ribbons1 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonWinning As Boolean
        Get
            Return (Hoenn2_Ribbons1 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons1 = CByte((Hoenn2_Ribbons1 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonVictory As Boolean
        Get
            Return (Hoenn2_Ribbons1 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons1 = CByte((Hoenn2_Ribbons1 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonArtist As Boolean
        Get
            Return (Hoenn2_Ribbons1 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons1 = CByte((Hoenn2_Ribbons1 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonEffort As Boolean
        Get
            Return (Hoenn2_Ribbons2 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons2 = CByte((Hoenn2_Ribbons2 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonChampionBattle As Boolean
        Get
            Return (Hoenn2_Ribbons2 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons2 = CByte((Hoenn2_Ribbons2 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonChampionRegional As Boolean
        Get
            Return (Hoenn2_Ribbons2 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons2 = CByte((Hoenn2_Ribbons2 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonChampionNational As Boolean
        Get
            Return (Hoenn2_Ribbons2 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons2 = CByte((Hoenn2_Ribbons2 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonCountry As Boolean
        Get
            Return (Hoenn2_Ribbons2 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons2 = CByte((Hoenn2_Ribbons2 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonNational As Boolean
        Get
            Return (Hoenn2_Ribbons2 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons2 = CByte((Hoenn2_Ribbons2 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonEarth As Boolean
        Get
            Return (Hoenn2_Ribbons2 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons2 = CByte((Hoenn2_Ribbons2 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonWorld As Boolean
        Get
            Return (Hoenn2_Ribbons2 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Hoenn2_Ribbons2 = CByte((Hoenn2_Ribbons2 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
#End Region
    Public Property FatefulEncounter As Boolean
        Get
            Return (Data(&H40) And 1) = 1
        End Get
        Set(value As Boolean)
            Data(&H40) = CByte((Data(&H40) And Not (&H1)) Or If(value, 1, 0))
        End Set
    End Property
    Public Property Gender As Byte
        Get
            Return (Data(&H40) >> 1) And &H3
        End Get
        Set(value As Byte)
            Data(&H40) = CByte((Data(&H40) And Not (&H6)) Or (value << 1))
        End Set
    End Property
    Public Property Forms As Byte
        Get
            Return (Data(&H40) >> 3)
        End Get
        Set(value As Byte)
            Data(&H40) = CByte((Data(&H40) And (&H7)) Or (value << 3))
        End Set
    End Property
    Public Property ShinyLeaf As Byte
        Get
            Return Data(&H41)
        End Get
        Set(value As Byte)
            Data(&H41) = value
        End Set
    End Property
    '00 00
    '00
    '00 00 00 00
    Public Property Nickname As String '0x14
        Get
            Return GetString(Data, &H48, 20)
        End Get
        Set(ByVal value As String)
            SetString(value, 10).CopyTo(Data, &H48)
        End Set
    End Property
    'FF FF
    '00
    Public Property Origin As Byte
        Get
            Return Data(&H5F)
        End Get
        Set(ByVal value As Byte)
            Data(&H5F) = value
        End Set
    End Property
    Public Property Sinnoh3_Ribbons1 As Byte
        Get
            Return Data(&H60)
        End Get
        Set(ByVal value As Byte)
            Data(&H60) = value
        End Set
    End Property
    Public Property Sinnoh3_Ribbons2 As Byte
        Get
            Return Data(&H61)
        End Get
        Set(ByVal value As Byte)
            Data(&H61) = value
        End Set
    End Property
    Public Property Sinnoh4_Ribbons1 As Byte
        Get
            Return Data(&H62)
        End Get
        Set(ByVal value As Byte)
            Data(&H62) = value
        End Set
    End Property
    Public Property Sinnoh4_Ribbons2 As Byte
        Get
            Return Data(&H63)
        End Get
        Set(ByVal value As Byte)
            Data(&H63) = value
        End Set
    End Property
#Region "Sinnoh Ribbons"
    Public Property RibbonG4Cool As Boolean
        Get
            Return (Sinnoh3_Ribbons1 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons1 = CByte((Sinnoh3_Ribbons1 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonG4CoolGreat As Boolean
        Get
            Return (Sinnoh3_Ribbons1 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons1 = CByte((Sinnoh3_Ribbons1 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonG4CoolUltra As Boolean
        Get
            Return (Sinnoh3_Ribbons1 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons1 = CByte((Sinnoh3_Ribbons1 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonG4CoolMaster As Boolean
        Get
            Return (Sinnoh3_Ribbons1 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons1 = CByte((Sinnoh3_Ribbons1 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonG4Beauty As Boolean
        Get
            Return (Sinnoh3_Ribbons1 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons1 = CByte((Sinnoh3_Ribbons1 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonG4BeautyGreat As Boolean
        Get
            Return (Sinnoh3_Ribbons1 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons1 = CByte((Sinnoh3_Ribbons1 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonG4BeautyUltra As Boolean
        Get
            Return (Sinnoh3_Ribbons1 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons1 = CByte((Sinnoh3_Ribbons1 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonG4BeautyMaster As Boolean
        Get
            Return (Sinnoh3_Ribbons1 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons1 = CByte((Sinnoh3_Ribbons1 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonG4Cute As Boolean
        Get
            Return (Sinnoh3_Ribbons2 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons2 = CByte((Sinnoh3_Ribbons2 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonG4CuteGreat As Boolean
        Get
            Return (Sinnoh3_Ribbons2 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons2 = CByte((Sinnoh3_Ribbons2 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonG4CuteUltra As Boolean
        Get
            Return (Sinnoh3_Ribbons2 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons2 = CByte((Sinnoh3_Ribbons2 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonG4CuteMaster As Boolean
        Get
            Return (Sinnoh3_Ribbons2 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons2 = CByte((Sinnoh3_Ribbons2 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    Public Property RibbonG4Smart As Boolean
        Get
            Return (Sinnoh3_Ribbons2 And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons2 = CByte((Sinnoh3_Ribbons2 And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property RibbonG4SmartGreat As Boolean
        Get
            Return (Sinnoh3_Ribbons2 And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons2 = CByte((Sinnoh3_Ribbons2 And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property RibbonG4SmartUltra As Boolean
        Get
            Return (Sinnoh3_Ribbons2 And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons2 = CByte((Sinnoh3_Ribbons2 And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property RibbonG4SmartMaster As Boolean
        Get
            Return (Sinnoh3_Ribbons2 And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            Sinnoh3_Ribbons2 = CByte((Sinnoh3_Ribbons2 And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property
    Public Property RibbonG4Tough As Boolean
        Get
            Return (Sinnoh4_Ribbons1 And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            Sinnoh4_Ribbons1 = CByte((Sinnoh4_Ribbons1 And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property RibbonG4ToughGreat As Boolean
        Get
            Return (Sinnoh4_Ribbons1 And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            Sinnoh4_Ribbons1 = CByte((Sinnoh4_Ribbons1 And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property RibbonG4ToughUltra As Boolean
        Get
            Return (Sinnoh4_Ribbons1 And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            Sinnoh4_Ribbons1 = CByte((Sinnoh4_Ribbons1 And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property RibbonG4ToughMaster As Boolean
        Get
            Return (Sinnoh4_Ribbons1 And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            Sinnoh4_Ribbons1 = CByte((Sinnoh4_Ribbons1 And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
#End Region
    '00 00 00 00
    Public Property OT_Name As String '0xE
        Get
            Return GetString(Data, &H68, &HE)
        End Get
        Set(ByVal value As String)
            SetString(value, 7).CopyTo(Data, &H68)
        End Set
    End Property
    'FF FF
    Public Property EggYear As Byte
        Get
            Return Data(&H78)
        End Get
        Set(ByVal value As Byte)
            Data(&H78) = value
        End Set
    End Property
    Public Property EggMonth As Byte
        Get
            Return Data(&H79)
        End Get
        Set(ByVal value As Byte)
            Data(&H79) = value
        End Set
    End Property
    Public Property EggDay As Byte
        Get
            Return Data(&H7A)
        End Get
        Set(ByVal value As Byte)
            Data(&H7A) = value
        End Set
    End Property
    Public Property MetYear As Byte
        Get
            Return Data(&H7B)
        End Get
        Set(ByVal value As Byte)
            Data(&H7B) = value
        End Set
    End Property
    Public Property MetMonth As Byte
        Get
            Return Data(&H7C)
        End Get
        Set(ByVal value As Byte)
            Data(&H7C) = value
        End Set
    End Property
    Public Property MetDay As Byte
        Get
            Return Data(&H7D)
        End Get
        Set(ByVal value As Byte)
            Data(&H7D) = value
        End Set
    End Property
    Public Property EggMet As UShort
        Get
            If (BitConverter.ToUInt16(Data, &H44) <> 0) Then Return BitConverter.ToUInt16(Data, &H44)
            Return BitConverter.ToUInt16(Data, &H7E)
        End Get
        Set(ByVal value As UShort)
            If (value = 0) Then
                BitConverter.GetBytes(CUShort(0)).CopyTo(Data, &H44)
                BitConverter.GetBytes(CUShort(0)).CopyTo(Data, &H7E)
            ElseIf ((value < 2000 AndAlso value > 111) Or (2010 < value AndAlso value < 3000)) Then
                ' Met location Not in DP, set to Faraway Place
                BitConverter.GetBytes(CUShort(value)).CopyTo(Data, &H44)
                BitConverter.GetBytes(CUShort(&HBBA)).CopyTo(Data, &H7E)
            Else
                Dim pthgss As Integer = If(Origin = &HA OrElse &HB OrElse &HC, value, 0) ' only set to PtHGSS loc if encountered in game
                BitConverter.GetBytes(CUShort(pthgss)).CopyTo(Data, &H44)
                BitConverter.GetBytes(CUShort(value)).CopyTo(Data, &H7E)
            End If
            'BitConverter.GetBytes(value).CopyTo(Data, &H7E)
        End Set
    End Property
    Public Property Met As UShort
        Get
            If (BitConverter.ToUInt16(Data, &H46) <> 0) Then Return BitConverter.ToUInt16(Data, &H46)
            Return BitConverter.ToUInt16(Data, &H80)
        End Get
        Set(ByVal value As UShort)
            If (value = 0) Then
                BitConverter.GetBytes(CUShort(0)).CopyTo(Data, &H46)
                BitConverter.GetBytes(CUShort(0)).CopyTo(Data, &H80)
            ElseIf ((111 < value AndAlso value < 2000) Or (2010 < value AndAlso value < 3000)) Then
                ' Met location Not in DP, set to Faraway Place
                BitConverter.GetBytes(CUShort(value)).CopyTo(Data, &H46)
                BitConverter.GetBytes(CUShort(&HBBA)).CopyTo(Data, &H80)
            Else
                Dim pthgss As Integer = If(Origin = &HA OrElse &HB OrElse &HC, value, 0) ' only set to PtHGSS loc if encountered in game
                BitConverter.GetBytes(CUShort(pthgss)).CopyTo(Data, &H46)
                BitConverter.GetBytes(CUShort(value)).CopyTo(Data, &H80)
            End If
            'BitConverter.GetBytes(value).CopyTo(Data, &H80)
        End Set
    End Property
    Public Property Pokerus As Byte
        Get
            Return Data(&H82)
        End Get
        Set(ByVal value As Byte)
            Data(&H82) = value
        End Set
    End Property
    Public Property Pokerus_Strain As Byte
        Get
            Return Pokerus >> 4
        End Get
        Set(ByVal value As Byte)
            Pokerus = CByte((Pokerus And &HF) Or (value << 4))
        End Set
    End Property
    Public Property Pokerus_Days As Byte
        Get
            Return (Pokerus And &HF)
        End Get
        Set(ByVal value As Byte)
            Pokerus = CByte((Pokerus And Not (&HF)) And value)
        End Set
    End Property
    Public Property Ball As Byte
        Get
            Return Math.Max(Data(&H86), Data(&H83))
        End Get
        Set(ByVal value As Byte)
            ' Ball to display in DPPt
            Data(&H83) = CByte(If(value <= &H10, value, 4)) ' Cap at Cherish Ball

            ' HGSS Exclusive Balls
            If (value > &H10 Or (If(Origin = &HB OrElse &HC, True, False) And Not FatefulEncounter)) Then
                Data(&H86) = CByte(If(value <= &H18, value, 4)) ' Cap at Comp Ball
            Else
                Data(&H86) = 0 ' Unused
            End If

            'Data(&H83) = value
        End Set
    End Property
    Public Property OT_Gender As Byte
        Get
            Return Data(&H84) >> 7
        End Get
        Set(ByVal value As Byte)
            Data(&H84) = CByte((Data(&H84) And Not &H80) Or (value << 7))
        End Set
    End Property
    Public Property Met_Level As Byte
        Get
            Return Data(&H84) And Not (&H80)
        End Get
        Set(ByVal value As Byte)
            Data(&H84) = CByte((Data(&H84) And &H80) Or value)
        End Set
    End Property
    Public Property EncounterType As Byte
        Get
            Return Data(&H85)
        End Get
        Set(ByVal value As Byte)
            Data(&H85) = value
        End Set
    End Property
    '00
    Public Property PokéathlonStat As Byte
        Get
            Return Data(&H87)
        End Get
        Set(ByVal value As Byte)
            Data(&H87) = value
        End Set
    End Property
    Public Property Status As Byte
        Get
            Return Data(&H88)
        End Get
        Set(ByVal value As Byte)
            Data(&H88) = value
        End Set
    End Property
    '00
    '00 00
    Public Property Level As Byte
        Get
            Return Data(&H8C)
        End Get
        Set(ByVal value As Byte)
            Data(&H8C) = value
        End Set
    End Property
    Public Property Seals As Byte
        Get
            Return Data(&H8D)
        End Get
        Set(ByVal value As Byte)
            Data(&H8D) = value
        End Set
    End Property
    Public Property Stat_CurrentHP As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H8E)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H8E)
        End Set
    End Property
    Public Property Stat_MaxHP As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H90)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H90)
        End Set
    End Property
    Public Property Stat_ATK As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H92)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H92)
        End Set
    End Property
    Public Property Stat_DEF As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H94)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H94)
        End Set
    End Property
    Public Property Stat_SPE As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H96)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H96)
        End Set
    End Property
    Public Property Stat_SPA As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H98)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H98)
        End Set
    End Property
    Public Property Stat_SPD As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H9A)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H9A)
        End Set
    End Property
    Public Property Mail As Byte() '0x2A + OT_Name
        Get
            Return Data.Skip(&H9C).Take(&H38).ToArray()
        End Get
        Set(ByVal value As Byte())
            value.CopyTo(Data, &H9C)
        End Set
    End Property
    '00 00 00 00 00 00 00 00
End Class
