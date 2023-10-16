Public Class WC7Full
    Public Data(&H310) As Byte
    Public Sub New()
        Data(&H206) = &H46
        Data(&H207) = &H46
    End Sub
    Public Property GameCompatibilities As Byte
        Get
            Return Data(&H0)
        End Get
        Set(ByVal value As Byte)
            Data(&H0) = value
        End Set
    End Property
    Public Property Sun As Boolean
        Get
            Return (GameCompatibilities And (1 << 0)) = (1 << 0)
        End Get
        Set(value As Boolean)
            GameCompatibilities = CByte((GameCompatibilities And Not (1 << 0)) Or If(value, 1 << 0, 0))
        End Set
    End Property
    Public Property Moon As Boolean
        Get
            Return (GameCompatibilities And (1 << 1)) = (1 << 1)
        End Get
        Set(value As Boolean)
            GameCompatibilities = CByte((GameCompatibilities And Not (1 << 1)) Or If(value, 1 << 1, 0))
        End Set
    End Property
    Public Property USun As Boolean
        Get
            Return (GameCompatibilities And (1 << 2)) = (1 << 2)
        End Get
        Set(value As Boolean)
            GameCompatibilities = CByte((GameCompatibilities And Not (1 << 2)) Or If(value, 1 << 2, 0))
        End Set
    End Property
    Public Property UMoon As Boolean
        Get
            Return (GameCompatibilities And (1 << 3)) = (1 << 3)
        End Get
        Set(value As Boolean)
            GameCompatibilities = CByte((GameCompatibilities And Not (1 << 3)) Or If(value, 1 << 3, 0))
        End Set
    End Property
    '00 00 00
    Public Property EventText As String '0x1FA
        Get
            Return GetString(Data, &H4, &H1FA)
        End Get
        Set(ByVal value As String)
            SetString(value, 252).CopyTo(Data, &H4)
        End Set
    End Property
    Public Property Background As Byte
        Get
            Return Data(&H1FE)
        End Get
        Set(value As Byte)
            Data(&H1FE) = value
        End Set
    End Property
    Public Property Language As Byte
        Get
            Return Data(&H1FF)
        End Get
        Set(value As Byte)
            Data(&H1FF) = value
        End Set
    End Property
    Public Property Multiple As Boolean
        Get
            Return Data(&H200) = 1
        End Get
        Set(value As Boolean)
            Data(&H200) = If(value, 1, 0)
        End Set
    End Property
    Public Property SubID As Byte
        Get
            Return Data(&H201)
        End Get
        Set(value As Byte)
            Data(&H201) = value
        End Set
    End Property
    Public Property Checksum As UShort
        Get
            Return Data(&H202)
        End Get
        Set(value As UShort)
            Data(&H202) = value
        End Set
    End Property
    Public Property SetCount As Byte
        Get
            Return Data(&H204)
        End Get
        Set(value As Byte)
            Data(&H204) = value
        End Set
    End Property
    Public Property Rarity As Byte
        Get
            Return Data(&H205)
        End Get
        Set(value As Byte)
            Data(&H205) = value
        End Set
    End Property
    '46 46
    Public Property WC7 As Byte()
        Get
            Return Data.Skip(&H208).Take(&H108)
        End Get
        Set(value As Byte())
            value.CopyTo(Data, &H208)
        End Set
    End Property
End Class
