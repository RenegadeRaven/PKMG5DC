Module Cryption
    Friend Const SIZE_4PARTY As Integer = 236
    Friend Const SIZE_4STORED As Integer = 136
    Friend Const SIZE_4BLOCK As Integer = 32

    Friend Const SIZE_5PARTY As Integer = 220
    Friend Const SIZE_5STORED As Integer = 136
    Friend Const SIZE_5BLOCK As Integer = 32


    Private ReadOnly BlockPosition As Byte() =
        {
            0, 1, 2, 3,
            0, 1, 3, 2,
            0, 2, 1, 3,
            0, 3, 1, 2,
            0, 2, 3, 1,
            0, 3, 2, 1,
            1, 0, 2, 3,
            1, 0, 3, 2,
            2, 0, 1, 3,
            3, 0, 1, 2,
            2, 0, 3, 1,
            3, 0, 2, 1,
            1, 2, 0, 3,
            1, 3, 0, 2,
            2, 1, 0, 3,
            3, 1, 0, 2,
            2, 3, 0, 1,
            3, 2, 0, 1,
            1, 2, 3, 0,
            1, 3, 2, 0,
            2, 1, 3, 0,
            3, 1, 2, 0,
            2, 3, 1, 0,
            3, 2, 1, 0,
            0, 1, 2, 3,
            0, 1, 3, 2,
            0, 2, 1, 3,
            0, 3, 1, 2,
            0, 2, 3, 1,
            0, 3, 2, 1,
            1, 0, 2, 3,
            1, 0, 3, 2
        }
    Friend ReadOnly blockPositionInvert As Byte() =
        {
            0, 1, 2, 4, 3, 5, 6, 7, 12, 18, 13, 19, 8, 10, 14, 20, 16, 22, 9, 11, 15, 21, 17, 23,
            0, 1, 2, 4, 3, 5, 6, 7
        }

    Public Function ShuffleArray(ByVal data As Byte(), ByVal sv As UInteger, ByVal blockSize As Integer) As Byte()
        Dim sdata As Byte() = CType(data.Clone(), Byte())
        Dim Index As UInteger = sv * 4
        Const start As Integer = 8
        For block As Integer = 0 To 3 Step 1
            Dim ofs As Integer = BlockPosition(Index + block)
            Array.Copy(data, start + (blockSize * ofs), sdata, start + (blockSize * block), blockSize)
        Next
        Return sdata
    End Function

    Public Function DecryptArray45(ekm As Byte())
        Dim pv As UInteger = BitConverter.ToUInt32(ekm, 0)
        Dim chk As UInteger = BitConverter.ToUInt16(ekm, 6)
        Dim sv As UInteger = pv >> 13 And 31
        CryptPKM45(ekm, pv, chk, SIZE_4BLOCK)
        Return ShuffleArray(ekm, sv, SIZE_4BLOCK)
    End Function

    Public Function EncryptArray45(pkm As Byte())
        Dim pv As UInteger = BitConverter.ToUInt32(pkm, 0)
        Dim chk As UInteger = BitConverter.ToUInt16(pkm, 6)
        Dim sv As UInteger = pv >> 13 And 31
        Dim ekm As Byte() = ShuffleArray(pkm, blockPositionInvert(sv), SIZE_4BLOCK)
        CryptPKM45(ekm, pv, chk, SIZE_4BLOCK)
        Return ekm
    End Function

    Private Sub CryptPKM45(data As Byte(), pv As UInteger, chk As UInteger, blockSize As Integer)
        Const start As Integer = 8
        Dim endBlock As Integer = (4 * blockSize) + start
        CryptArray(data, chk, start, endBlock)
        If (data.Length > endBlock) Then CryptArray(data, pv, endBlock, data.Length)
    End Sub

    Public Sub CryptArray(data As Byte(), ByRef seed As UInteger, start As Integer, endBlock As Integer)
        Dim i As Integer = start
        Do While (i < endBlock)
            Crypt(data, seed, i)
            i += 2
            Crypt(data, seed, i)
            i += 2
        Loop
    End Sub

    Private Sub Crypt(data As Byte(), ByRef seed As UInteger, i As Integer)
        seed = ((&H41C64E6D * seed) + &H6073) Mod &H100000000
        data(i) = data(i) Xor CByte((seed >> 16) Mod &H100)
        data(i + 1) = data(i + 1) Xor CByte((seed >> 24) Mod &H100)
    End Sub

    Public Function DecryptIfEncrypted45(ByRef ekm As Byte())
        If (BitConverter.ToUInt32(ekm, &H64) <> 0) Then Return DecryptArray45(ekm)
        Return 0
    End Function
    Public Function EncryptIfDecrypted45(pkm As Byte())
        Return EncryptArray45(pkm)
    End Function
End Module
