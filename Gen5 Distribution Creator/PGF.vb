Public Class PGF
    Public TID As UShort
    Public SID As UShort
    Public Origin As Byte
    '00 00 00
    Public PID As UInteger
    Public Ribbons(1) As Byte
    Public Ball As Byte
    '00
    Public Item As UShort
    Public Moves(3) As UShort
    Public Dex As UShort
    '00
    Public Language As Byte
    Public Nickname As String '0x14
    'FF FF
    Public Nature As Byte
    Public Gender As Byte
    Public Ability As Byte
    Public Shiny As Byte
    Public EggMet As UShort
    Public Met As UShort
    Public Level As Byte
    Public ContestStats As String '0x5
    Public Sheen As Byte
    Public IVs(5) As Byte '{HP, ATK, DEF, SPE, SpA, SpD}
    '00
    Public OT_Name As String '0xE
    'FF FF
    Public OT_Gender As Byte
    'Level
    Public Egg As Byte
    '00 00 00
    Public EventTitle As String '0x48
    'FF FF
    '00 00
    Public RecieveDay As Byte = 0
    Public RecieveMonth As Byte = 0
    Public RecieveYear As UShort = 0
    Public CardID As UShort
    Public CardFrom As Byte = &H44
    Public CardType As Byte
    Public Status As Byte = 1
    '00 for 0x17
End Class
