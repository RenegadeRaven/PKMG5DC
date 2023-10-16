Public Class WC7
    Public Data(&H108) As Byte
    Public Sub New()
        Data(&H26E) = &HFF
    End Sub
    Public Property CardID As UShort
        Get
            Return Data(&H0)
        End Get
        Set(value As UShort)
            Data(&H0) = value
        End Set
    End Property
    Public Property CardTitle As String '0x4A
        Get
            Return GetString(Data, &H2, &H4A)
        End Get
        Set(value As String)
            SetString(value, 36).CopyTo(Data, &H2)
        End Set
    End Property
    Public Property ReceiveDate As UInt32
        Get
            Return Data(&H4C)
        End Get
        Set(value As UInt32)
            Data(&H4C) = value
        End Set
    End Property
    Public Property ReceiveYear As Byte
        Get
            Return Math.Floor(Data(&H4C) / 10000)
        End Get
        Set(value As Byte)
            Data(&H4C) = (value * 10000) + ReceiveMonth + ReceiveDay
        End Set
    End Property
    Public Property ReceiveMonth As Byte
        Get
            Return Math.Floor((Data(&H4C) Mod 10000) / 100)
        End Get
        Set(value As Byte)
            Data(&H4C) = ReceiveYear + (value * 100) + ReceiveDay
        End Set
    End Property
    Public Property ReceiveDay As Byte
        Get
            Return Data(&H4C) Mod 100
        End Get
        Set(value As Byte)
            Data(&H4C) = ReceiveYear + ReceiveMonth + value
        End Set
    End Property
    Public Property Location As Byte
        Get
            Return Data(&H50)
        End Get
        Set(value As Byte)
            Data(&H50) = value
        End Set
    End Property
    Public Property CardType As Byte
        Get
            Return Data(&H51)
        End Get
        Set(value As Byte)
            Data(&H51) = value
        End Set
    End Property
    Public Property Status As Byte
        Get
            Return Data(&H52)
        End Get
        Set(value As Byte)
            Data(&H52) = value
        End Set
    End Property
    Public Property Background As Byte
        Get
            Return Data(&H53)
        End Get
        Set(value As Byte)
            Data(&H53) = value
        End Set
    End Property
End Class
