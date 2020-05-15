Public Class PK5
    Public InputPK5 As Byte()
    'Private Shared ReadOnly Unused As UShort() = {&H87, &H42, &H43, &H44, &H45, &H46, &H47, &H5E, &H63, &H64, &H65, &H66, &H67, &H86}
    Public Property PID As UInteger
        Get
            Return BitConverter.ToUInt32(InputPK5, &H0)
        End Get
        Set(ByVal value As UInteger)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H0)
        End Set
    End Property
    '00 00
    Public Property Checksum As UShort
        Get
            Return BitConverter.ToUInt16(InputPK5, &H6)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H6)
        End Set
    End Property
    Public Property Dex As UShort
        Get
            Return BitConverter.ToUInt16(InputPK5, &H8)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H8)
        End Set
    End Property
    Public Property Item As UShort
        Get
            Return BitConverter.ToUInt16(InputPK5, &HA)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &HA)
        End Set
    End Property
    Public Property TID As UShort
        Get
            Return BitConverter.ToUInt16(InputPK5, &HC)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &HC)
        End Set
    End Property
    Public Property SID As UShort
        Get
            Return BitConverter.ToUInt16(InputPK5, &HE)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &HE)
        End Set
    End Property
    Public Property Exp As UInteger
        Get
            Return BitConverter.ToUInt32(InputPK5, &H10)
        End Get
        Set(ByVal value As UInteger)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H10)
        End Set
    End Property
    Public Property Friendship As Byte 'Egg Steps
        Get
            Return InputPK5(&H14)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H14) = value
        End Set
    End Property
    Public Property Ability As Byte
        Get
            Return InputPK5(&H15)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H15) = value
        End Set
    End Property
    Public Property Markings As Byte
        Get
            Return InputPK5(&H16)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H16) = value
        End Set
    End Property
    Public Property Language As Byte
        Get
            Return InputPK5(&H17)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H17) = value
        End Set
    End Property
    Public Property EV_HP As Byte
        Get
            Return InputPK5(&H18)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H18) = value
        End Set
    End Property
    Public Property EV_ATK As Byte
        Get
            Return InputPK5(&H19)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H19) = value
        End Set
    End Property
    Public Property EV_DEF As Byte
        Get
            Return InputPK5(&H1A)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H1A) = value
        End Set
    End Property
    Public Property EV_SPE As Byte
        Get
            Return InputPK5(&H1B)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H1B) = value
        End Set
    End Property
    Public Property EV_SPA As Byte
        Get
            Return InputPK5(&H1C)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H1C) = value
        End Set
    End Property
    Public Property EV_SPD As Byte
        Get
            Return InputPK5(&H1D)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H1D) = value
        End Set
    End Property
    Public Property CV_Cool As Byte
        Get
            Return InputPK5(&H1E)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H18) = value
        End Set
    End Property
    Public Property CV_Beauty As Byte
        Get
            Return InputPK5(&H1F)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H19) = value
        End Set
    End Property
    Public Property CV_Cute As Byte
        Get
            Return InputPK5(&H20)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H20) = value
        End Set
    End Property
    Public Property CV_Smart As Byte
        Get
            Return InputPK5(&H21)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H21) = value
        End Set
    End Property
    Public Property CV_Tough As Byte
        Get
            Return InputPK5(&H22)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H22) = value
        End Set
    End Property
    Public Property CV_Sheen As Byte
        Get
            Return InputPK5(&H23)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H23) = value
        End Set
    End Property
    Public Property Sinnoh1_Ribbons1 As Byte
        Get
            Return InputPK5(&H24)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H24) = value
        End Set
    End Property
    Public Property Sinnoh1_Ribbons2 As Byte
        Get
            Return InputPK5(&H25)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H25) = value
        End Set
    End Property
    Public Property Unova_Ribbons1 As Byte
        Get
            Return InputPK5(&H26)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H26) = value
        End Set
    End Property
    Public Property Unova_Ribbons2 As Byte
        Get
            Return InputPK5(&H27)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H27) = value
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
            Return BitConverter.ToUInt16(InputPK5, &H28)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H28)
        End Set
    End Property
    Public Property Move2 As UShort
        Get
            Return BitConverter.ToUInt16(InputPK5, &H2A)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H2A)
        End Set
    End Property
    Public Property Move3 As UShort
        Get
            Return BitConverter.ToUInt16(InputPK5, &H2C)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H2C)
        End Set
    End Property
    Public Property Move4 As UShort
        Get
            Return BitConverter.ToUInt16(InputPK5, &H2E)
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H2E)
        End Set
    End Property
    Public Property Move1_PP As Byte
        Get
            Return BitConverter.ToUInt16(InputPK5, &H30)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H30)
        End Set
    End Property
    Public Property Move2_PP As Byte
        Get
            Return BitConverter.ToUInt16(InputPK5, &H31)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H31)
        End Set
    End Property
    Public Property Move3_PP As Byte
        Get
            Return BitConverter.ToUInt16(InputPK5, &H32)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H32)
        End Set
    End Property
    Public Property Move4_PP As Byte
        Get
            Return BitConverter.ToUInt16(InputPK5, &H33)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H33)
        End Set
    End Property
    Public Property Move1_PPUps As Byte
        Get
            Return BitConverter.ToUInt16(InputPK5, &H34)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H34)
        End Set
    End Property
    Public Property Move2_PPUps As Byte
        Get
            Return BitConverter.ToUInt16(InputPK5, &H35)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H35)
        End Set
    End Property
    Public Property Move3_PPUps As Byte
        Get
            Return BitConverter.ToUInt16(InputPK5, &H36)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H36)
        End Set
    End Property
    Public Property Move4_PPUps As Byte
        Get
            Return BitConverter.ToUInt16(InputPK5, &H37)
        End Get
        Set(ByVal value As Byte)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H37)
        End Set
    End Property
    Public Property BlocIV As UInteger
        Get
            Return BitConverter.ToUInt32(InputPK5, &H38)
        End Get
        Set(ByVal value As UInteger)
            BitConverter.GetBytes(value).CopyTo(InputPK5, &H38)
        End Set
    End Property
    Public Property IV_HP As Byte
        Get
            Return CByte((BlocIV >> 0) And &H1F)
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 0)) Or (If(value > 31, 31UI, value) << 0))
        End Set
    End Property
    Public Property IV_ATK As Byte
        Get
            Return CByte((BlocIV >> 5) And &H1F)
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 5)) Or (If(value > 31, 31UI, value) << 5))
        End Set
    End Property
    Public Property IV_DEF As Byte
        Get
            Return CByte((BlocIV >> 10) And &H1F)
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 10)) Or (If(value > 31, 31UI, value) << 10))
        End Set
    End Property
    Public Property IV_SPE As Byte
        Get
            Return CByte((BlocIV >> 15) And &H1F)
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 15)) Or (If(value > 31, 31UI, value) << 15))
        End Set
    End Property
    Public Property IV_SPA As Byte
        Get
            Return CByte((BlocIV >> 20) And &H1F)
        End Get
        Set(value As Byte)
            BlocIV = ((BlocIV And Not (&H1FUI << 20)) Or (If(value > 31, 31UI, value) << 20))
        End Set
    End Property
    Public Property IV_SPD As Byte
        Get
            Return CByte((BlocIV >> 25) And &H1F)
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
            Return InputPK5(&H3C)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H3C) = value
        End Set
    End Property
    Public Property Hoenn1_Ribbons2 As Byte
        Get
            Return InputPK5(&H3D)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H3D) = value
        End Set
    End Property
    Public Property Hoenn2_Ribbons1 As Byte
        Get
            Return InputPK5(&H3E)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H3E) = value
        End Set
    End Property
    Public Property Hoenn2_Ribbons2 As Byte
        Get
            Return InputPK5(&H3F)
        End Get
        Set(ByVal value As Byte)
            InputPK5(&H3F) = value
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
            Return (InputPK5(&H40) And 1) = 1
        End Get
        Set(value As Boolean)
            InputPK5(&H40) = CByte((InputPK5(&H40) And Not (&H1)) Or If(value, 1, 0))
        End Set
    End Property
    Public Property Gender As Byte
        Get
            Return (InputPK5(&H40) >> 1) And &H3
        End Get
        Set(value As Byte)
            InputPK5(&H40) = CByte((InputPK5(&H40) And Not (&H6)) Or (value << 1))
        End Set
    End Property
    Public Property Forms As Byte '{  set => Data[0x40] = (byte)((Data[0x40] & 0x07) | (value << 3)); }
        Get
            Return (InputPK5(&H40) >> 3)
        End Get
        Set(value As Byte)
            InputPK5(&H40) = CByte((InputPK5(&H40) And (&H7)) Or (value << 3))
        End Set
    End Property
    Public Property Nature As Byte
        Get
            Return InputPK5(&H41)
        End Get
        Set(value As Byte)
            InputPK5(&H41) = CByte(value)
        End Set
    End Property
    Public Property HA As Boolean
        Get
            Return (InputPK5(&H42) And 1) = 1
        End Get
        Set(value As Boolean)
            InputPK5(&H42) = CByte((InputPK5(&H40) And Not (&H1)) Or If(value, 1, 0))
        End Set
    End Property
    Public Property N As Boolean
        Get
            Return (InputPK5(&H42) And 2) = 2
        End Get
        Set(value As Boolean)
            InputPK5(&H42) = CByte((InputPK5(&H40) And Not (&H2)) Or If(value, 2, 0))
        End Set
    End Property
    '00
    '00 00 00 00
    Public Property Nickname As String '0x14
    'FF FF
    '00
    Public Property Origin As Byte
    Public Property SinnohRibbons3(1) As Byte
    Public Property SinnohRibbons4(1) As Byte
    '00 00 00 00
    Public Property OT_Name As String '0xE
    'FF FF
    Public Property EggYear As Byte
    Public Property EggMonth As Byte
    Public Property EggDay As Byte
    Public Property MetYear As Byte
    Public Property MetMonth As Byte
    Public Property MetDay As Byte
    Public Property EggMet As UShort
    Public Property Met As UShort
    Public Property Pokerus As Boolean
    Public Property Ball As Byte
    Public Property BlocOTG As Byte
    Public Property EncounterType As Byte
    '00 00
    Public Property Status As Byte
    '00
    '00 00
    Public Property Level As Byte
    Public Property Seals As Byte
    Public Property CurrentStats(5) As UShort '{Current HP, Max HP, Atk, Def, Spe, SpA, SpD}
    Public Property Mail As String '0x2A + OT_Name
    '00 00 00 00 00 00 00 00
End Class
