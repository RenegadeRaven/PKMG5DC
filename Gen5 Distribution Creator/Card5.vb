'Card Class
Public Class Card5
    Public numberOfCards As Byte
    '00 00 00
    Public wonderCard(7) As String '0xCC
    '00 00
    Public gameCompatability(7) As Byte
    '00
    Public eventText As String '0x1F8
    'FF FF
    '00
    Public language(7) As Byte
    '00 00
    Public langChecksum(7) As UShort
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
