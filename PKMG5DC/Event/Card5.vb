'Card Class
Public Class Card5
    Public Data(&H222F) As Byte

    Public Sub New()
        Unknown14 = &H14
    End Sub
    Public Property NumberOfCards As Byte
        Get
            Return Data(&H0)
        End Get
        Set(ByVal value As Byte)
            Data(&H0) = value
        End Set
    End Property
    '00 00 00
    Public Property Wondercards(n As Byte) As Byte() '0xCC
        Get
            Return Data.Skip(&H4 + (n * &H2D0)).Take(&HCC)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H4 + (n * &H2D0))
        End Set
    End Property
    '00 00
    Public Property GameCompatibilities(n As Byte) As Byte
        Get
            Return Data(&HCE + &H4 + (n * &H2D0))
        End Get
        Set(ByVal value As Byte)
            Data(&HCE + &H4 + (n * &H2D0)) = value
        End Set
    End Property
    Public Property White(n As Byte) As Boolean
        Get
            Return (GameCompatibilities(n) And (1 << 4)) = (1 << 4)
        End Get
        Set(value As Boolean)
            GameCompatibilities(n) = CByte((GameCompatibilities(n) And Not (1 << 4)) Or If(value, 1 << 4, 0))
        End Set
    End Property
    Public Property Black(n As Byte) As Boolean
        Get
            Return (GameCompatibilities(n) And (1 << 5)) = (1 << 5)
        End Get
        Set(value As Boolean)
            GameCompatibilities(n) = CByte((GameCompatibilities(n) And Not (1 << 5)) Or If(value, 1 << 5, 0))
        End Set
    End Property
    Public Property White2(n As Byte) As Boolean
        Get
            Return (GameCompatibilities(n) And (1 << 6)) = (1 << 6)
        End Get
        Set(value As Boolean)
            GameCompatibilities(n) = CByte((GameCompatibilities(n) And Not (1 << 6)) Or If(value, 1 << 6, 0))
        End Set
    End Property
    Public Property Black2(n As Byte) As Boolean
        Get
            Return (GameCompatibilities(n) And (1 << 7)) = (1 << 7)
        End Get
        Set(value As Boolean)
            GameCompatibilities(n) = CByte((GameCompatibilities(n) And Not (1 << 7)) Or If(value, 1 << 7, 0))
        End Set
    End Property

    Public Property EventTitle(n As Byte) As String
        Get
            Return GetString(Data, &H60 + &H4 + (n * &H2D0), 48)
        End Get
        Set(value As String)
            SetString(value, 24).CopyTo(Data, &H60 + &H4 + (n * &H2D0))
        End Set
    End Property
    '00
    Public Property EventText(n As Byte) As String '0x1F8
        Get
            Return GetString(Data, &HD0 + &H4 + (n * &H2D0), 504)
        End Get
        Set(ByVal value As String)
            SetString(value, 252).CopyTo(Data, &HD0 + &H4 + (n * &H2D0))
        End Set
    End Property
    'FF FF
    '00
    Public Property Language(n As Byte) As Byte
        Get
            Return Data(&H2CB + &H4 + (n * &H2D0))
        End Get
        Set(ByVal value As Byte)
            Data(&H2CB + &H4 + (n * &H2D0)) = value
        End Set
    End Property
    '00 00
    Public Property LangChecksum(n As Byte) As UShort
        Get
            Return BitConverter.ToUInt16(Data, &H2CE + &H4 + (n * &H2D0))
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H2CE + &H4 + (n * &H2D0))
        End Set
    End Property
    Public Property Cards(n As Byte) As Byte()
        Get
            Return Data.Skip(&H4 + (n * &H2D0)).Take(&H2D0)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H4 + (n * &H2D0))
        End Set
    End Property
    Public Property StartYears(n As Byte) As UShort
        Get
            Dim year As UShort = BitConverter.ToUInt16(Data, &H21C4 + (n * &H8))

            If year = 0 Then
                year = Date.Today.Year
            End If

            Return year
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H21C4 + (n * &H8))
        End Set
    End Property
    Public Property StartMonths(n As Byte) As Byte
        Get
            Dim month As UShort = Data(&H21C6 + (n * &H8))

            If month = 0 Then
                month = Date.Today.Month
            End If

            Return month
        End Get
        Set(ByVal value As Byte)
            Data(&H21C6 + (n * &H8)) = value
        End Set
    End Property
    Public Property StartDays(n As Byte) As Byte
        Get
            Dim day As UShort = Data(&H21C7 + (n * &H8))

            If day = 0 Then
                day = Date.Today.Day
            End If

            Return day
        End Get
        Set(ByVal value As Byte)
            Data(&H21C7 + (n * &H8)) = value
        End Set
    End Property
    Public Property EndYears(n As Byte) As UShort
        Get
            Dim year As UShort = BitConverter.ToUInt16(Data, &H21C8 + (n * &H8))

            If year = 0 Then
                year = Date.Today.Year
            End If

            Return year
        End Get
        Set(ByVal value As UShort)
            BitConverter.GetBytes(value).CopyTo(Data, &H21C8 + (n * &H8))
        End Set
    End Property
    Public Property EndMonths(n As Byte) As Byte
        Get
            Dim month As UShort = Data(&H21CA + (n * &H8))

            If month = 0 Then
                month = Date.Today.Month
            End If

            Return month
        End Get
        Set(ByVal value As Byte)
            Data(&H21CA + (n * &H8)) = value
        End Set
    End Property
    Public Property EndDays(n As Byte) As Byte
        Get
            Dim day As UShort = Data(&H21CB + (n * &H8))

            If day = 0 Then
                day = Date.Today.Day
            End If

            Return day
        End Get
        Set(ByVal value As Byte)
            Data(&H21CB + (n * &H8)) = value
        End Set
    End Property

    '00 for 0x5C
    '14 ????
    Public Property Unknown14 As Byte
        Get
            Return Data(&H2228)
        End Get
        Set(value As Byte)
            Data(&H2228) = value
        End Set
    End Property
    '00 00 00 00 00 00 00
End Class
