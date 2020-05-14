Imports System.IO

Public Class PGFCreator
    Dim WC As New PGF
    Dim InputPK5 As String
    Dim a As New List(Of Items)

    Private Sub PGFCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateMoves(ComboBox2)
    End Sub

    Private Sub OpenPK5_Click(sender As Object, e As EventArgs) Handles OpenPK5.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Gen 5 PKM (*.pk5)|*.pk5|All files (*.*)|*.*"
        Dim res As DialogResult = OpenFile.ShowDialog()
        If res <> Windows.Forms.DialogResult.Cancel Then
            Dim myFile As String = Path.GetFileName(OpenFile.FileName)
            PK5Name.Text = myFile
            InputPK5 = ByteArrayToHexString(OpenFile.FileName)
            GrabValues()
        End If
    End Sub

    Private Sub GrabValues()
        Try
            With WC
                .TID = Convert.ToUInt16(Little_Endian(InputPK5.Remove(28).ToArray().Skip(24).ToArray(), 4), 16)
                .SID = Convert.ToUInt16(Little_Endian(InputPK5.Remove(32).ToArray().Skip(28).ToArray(), 4), 16)
                .Origin = Convert.ToUInt16(InputPK5.Remove(192).ToArray().Skip(190).ToArray(), 16)
                .Ribbons(0) = Convert.ToUInt16(InputPK5.Remove(78).ToArray().Skip(76).ToArray(), 16)
                .Ribbons(1) = Convert.ToUInt16(InputPK5.Remove(80).ToArray().Skip(78).ToArray(), 16)
                .Ball = Convert.ToUInt16(InputPK5.Remove(264).ToArray().Skip(262).ToArray(), 16)
                .Item = Convert.ToUInt16(Little_Endian(InputPK5.Remove(24).ToArray().Skip(20).ToArray(), 4), 16)
                .Moves(0) = Convert.ToUInt16(Little_Endian(InputPK5.Remove(84).ToArray().Skip(80).ToArray(), 4), 16)
                .Moves(1) = Convert.ToUInt16(Little_Endian(InputPK5.Remove(88).ToArray().Skip(84).ToArray(), 4), 16)
                .Moves(2) = Convert.ToUInt16(Little_Endian(InputPK5.Remove(92).ToArray().Skip(88).ToArray(), 4), 16)
                .Moves(3) = Convert.ToUInt16(Little_Endian(InputPK5.Remove(96).ToArray().Skip(92).ToArray(), 4), 16)
                .Dex = Convert.ToUInt16(Little_Endian(InputPK5.Remove(20).ToArray().Skip(16).ToArray(), 4), 16)
                .Language = Convert.ToUInt16(InputPK5.Remove(48).ToArray().Skip(46).ToArray(), 16)
                .Nickname = InputPK5.Remove(188).ToArray().Skip(144).ToArray()
                .Nature = Convert.ToUInt16(InputPK5.Remove(132).ToArray().Skip(130).ToArray(), 16)
                .EggMet = Convert.ToUInt16(Little_Endian(InputPK5.Remove(256).ToArray().Skip(252).ToArray(), 4), 16)
                .Met = Convert.ToUInt16(Little_Endian(InputPK5.Remove(260).ToArray().Skip(256).ToArray(), 4), 16)
                Dim bloc As String = Hex_Zeros(Convert.ToString(Convert.ToUInt32(Little_Endian(InputPK5.Remove(120).ToArray().Skip(112).ToArray(), 8), 16), 2), 32)
                .IVs(0) = Convert.ToInt32(bloc.Skip(27).ToArray(), 2)
                .IVs(1) = Convert.ToInt32(bloc.Remove(27).ToArray().Skip(22).ToArray(), 2)
                .IVs(2) = Convert.ToInt32(bloc.Remove(22).ToArray().Skip(17).ToArray(), 2)
                .IVs(3) = Convert.ToInt32(bloc.Remove(17).ToArray().Skip(12).ToArray(), 2)
                .IVs(4) = Convert.ToInt32(bloc.Remove(12).ToArray().Skip(7).ToArray(), 2)
                .IVs(5) = Convert.ToInt32(bloc.Remove(7).ToArray().Skip(2).ToArray(), 2)
                .Egg = Convert.ToUInt16(bloc.Remove(3).ToArray().Skip(1).ToArray(), 2)
                .OT_Name = InputPK5.Remove(240).ToArray().Skip(208).ToArray()
                .OT_Gender = Convert.ToUInt16(Hex_Zeros(Convert.ToString(Convert.ToUInt16(InputPK5.Remove(266).ToArray().Skip(264).ToArray(), 16), 2), 8).ToString.Remove(1), 2)
                .Gender = Convert.ToUInt16(Hex_Zeros(Convert.ToString(Convert.ToUInt16(InputPK5.Remove(130).ToArray().Skip(128).ToArray(), 16), 2), 8).ToString.Remove(7).ToArray().Skip(6).ToArray(), 2)

            End With
            ConvertValues()
            Desc()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ConvertValues()
        'Ribbons
        Dim hr As Char() = Hex_Zeros(Convert.ToString(Convert.ToUInt16(InputPK5.Remove(128).ToArray().Skip(126).ToArray(), 16), 2), 8).ToString.ToCharArray()
        Dim bits As Char() = Hex_Zeros(Convert.ToString(WC.Ribbons(0), 2), 8).ToString.ToCharArray
        Dim bits2 As Char() = Hex_Zeros(Convert.ToString(WC.Ribbons(1), 2), 8).ToString.ToCharArray
        WC.Ribbons(0) = Convert.ToUInt16(bits(1) & bits(4) & bits2(4) & bits2(5) & hr(0) & hr(1) & hr(2) & hr(3), 2)
        WC.Ribbons(1) = Convert.ToUInt16("0" & bits(2) & hr(4) & hr(5) & hr(6) & bits2(6) & bits2(7) & bits(0), 2)
    End Sub
    Private Sub Desc()
        With WC
            lbl_Species.Text = GetPokeName(.Dex) & " @ " & GetItemName(.Item)
            lbl_IVs.Text = "IVs: " & .IVs(0) & "/" & .IVs(1) & "/" & .IVs(2) & "/" & .IVs(4) & "/" & .IVs(5) & "/" & .IVs(3)
            Dim abl As UShort = Convert.ToUInt16(InputPK5.Remove(44).ToArray().Skip(42).ToArray(), 16)
            lbl_Ability.Text = "Ability: " & GetAbilityName(abl)
            lbl_Nature.Text = "Nature: " & GetNature(.Nature)
            lbl_Move1.Text = GetMoveName(.Moves(0))
            lbl_Move2.Text = GetMoveName(.Moves(1))
            lbl_Move3.Text = GetMoveName(.Moves(2))
            lbl_Move4.Text = GetMoveName(.Moves(3))
            TypeMove(lbl_Move1, lbl_Move1.Text)
            TypeMove(lbl_Move2, lbl_Move2.Text)
            TypeMove(lbl_Move3, lbl_Move3.Text)
            TypeMove(lbl_Move4, lbl_Move4.Text)
            Me.Refresh()
        End With
    End Sub
    Private Function GetNature(Num As Byte)
        Dim Natures() As String = {"Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest",
        "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky"}
        Return Natures(Num)
    End Function

    'Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
    '    Debug.Print(GetMoveID(ComboBox2.SelectedItem.ToString))
    '    TypeMove(lbl_Species, ComboBox2.SelectedItem.ToString)
    'End Sub
End Class