Public Class PK5
    Public PID As UInteger
    '00 00
    Public Checksum As UShort
    Public Dex As UShort
    Public Item As UShort
    Public TID As UShort
    Public SID As UShort
    Public Exp As UInteger
    Public Friendship As Byte 'Egg Steps
    Public Ability As Byte
    Public Markings As Byte
    Public Language As Byte
    Public EVs(5) As Byte '{HP, Atk, Def, Spe, SpA, SpD} Individual
    Public ContestValues(5) As Byte '{Cool, Beauty, Cute, Smart, Tough, Sheen} Individual
    Public SinnohRibbons1(1) As Byte
    Public UnovaRibbons(1) As Byte
    Public Moves(3) As UShort
    Public CurrentPP(3) As Byte
    Public MovesPPUp(3) As Byte
    Public BlocIV As UInteger
    Public HoennRibbons1(1) As Byte
    Public HoennRibbons2(1) As Byte
    Public Forms As Byte
    Public Nature As Byte
    Public HAN As Byte
    '00
    '00 00 00 00
    Public Nickname As String '0x14
    'FF FF
    '00
    Public Origin As Byte
    Public SinnohRibbons3(1) As Byte
    Public SinnohRibbons4(1) As Byte
    '00 00 00 00
    Public OT_Name As String '0xE
    'FF FF
    Public EggYear As Byte
    Public EggMonth As Byte
    Public EggDay As Byte
    Public MetYear As Byte
    Public MetMonth As Byte
    Public MetDay As Byte
    Public EggMet As UShort
    Public Met As UShort
    Public Pokerus As Boolean
    Public Ball As Byte
    Public BlocOTG As Byte
    Public EncounterType As Byte
    '00 00
    Public Status As Byte
    '00
    '00 00
    Public Level As Byte
    Public Seals As Byte
    Public CurrentStats(5) As UShort '{Current HP, Max HP, Atk, Def, Spe, SpA, SpD}
    Public Mail As String '0x2A + OT_Name
    '00 00 00 00 00 00 00 00
End Class
