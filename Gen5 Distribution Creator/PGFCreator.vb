Imports System.IO

Public Class PGFCreator
    Dim WC As New PGF
    Dim InputPK5 As New PK5

    Private Sub PGFCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateItems(ComboBox1)
        ComboBox2.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub OpenPK5_Click(sender As Object, e As EventArgs) Handles OpenPK5.Click
        Dim OpenFile As New OpenFileDialog With {
            .Filter = "Gen 5 PKM (*.pk5)|*.pk5|All files (*.*)|*.*"
        }
        Dim res As DialogResult = OpenFile.ShowDialog()
        If res <> Windows.Forms.DialogResult.Cancel Then
            Dim myFile As String = Path.GetFileName(OpenFile.FileName)
            PK5Name.Text = myFile
            InputPK5.Data = File.ReadAllBytes(OpenFile.FileName)
            GrabValues()
        End If
    End Sub

    Private Sub GrabValues()
        Try
            With WC
                Select Case WC.CardType
                    Case 1
                        .TID = InputPK5.TID
                        .SID = InputPK5.SID
                        .Origin = InputPK5.Origin
                        .PID = InputPK5.PID
                        .Ball = InputPK5.Ball
                        .Item = InputPK5.Item
                        .Move1 = InputPK5.Move1
                        .Move2 = InputPK5.Move2
                        .Move3 = InputPK5.Move3
                        .Move4 = InputPK5.Move4
                        .Dex = InputPK5.Dex
                        .Language = InputPK5.Language
                        .Nickname = InputPK5.Nickname
                        .Nature = InputPK5.Nature
                        .EggMet = InputPK5.EggMet
                        .Met = InputPK5.Met
                        .IV_HP = InputPK5.IV_HP
                        .IV_ATK = InputPK5.IV_ATK
                        .IV_DEF = InputPK5.IV_DEF
                        .IV_SPE = InputPK5.IV_SPE
                        .IV_SPA = InputPK5.IV_SPA
                        .IV_SPD = InputPK5.IV_SPD
                        .Egg = InputPK5.IsEgg
                        .OT_Name = InputPK5.OT_Name
                        .OT_Gender = InputPK5.OT_Gender
                        .Gender = InputPK5.Gender
                        .Level = InputPK5.Level
                        ConvertValues()
                        Desc()
                    Case 2
                        .TID = GetItemID(ComboBox1.Text)
                    Case 3

                End Select
                .EventTitle = "A special Zoroark!"
                .CardID = CUShort(nud_CardID.Value)
                .CardFrom = &H44
                .Status = 1
                'ability, shiny, event title, cardID, cardType
            End With

        Catch ex As Exception
        End Try
    End Sub
    Private Sub ConvertValues()
        'Ribbons
        With WC
            .RibbonBirthday = InputPK5.RibbonBirthday
            .RibbonEvent = InputPK5.RibbonEvent
            .RibbonPremier = InputPK5.RibbonPremier
            .RibbonClassic = InputPK5.RibbonClassic
            .RibbonWorld = InputPK5.RibbonWorld
            .RibbonEarth = InputPK5.RibbonEarth
            .RibbonNational = InputPK5.RibbonNational
            .RibbonCountry = InputPK5.RibbonCountry
            .RibbonChampionWorld = InputPK5.RibbonChampionWorld
            .RibbonChampionNational = InputPK5.RibbonChampionNational
            .RibbonChampionRegional = InputPK5.RibbonChampionRegional
            .RibbonChampionBattle = InputPK5.RibbonChampionBattle
            .RibbonWishing = InputPK5.RibbonWishing
            .RibbonSouvenir = InputPK5.RibbonSouvenir
            .RibbonSpecial = InputPK5.RibbonSpecial
        End With

    End Sub
    Private Sub Desc()
        With InputPK5
            lbl_Species.Text = GetPokeName(.Dex) & " @ " & GetItemName(.Item)
            lbl_IVs.Text = "IVs: " & .IV_HP & "/" & .IV_ATK & "/" & .IV_DEF & "/" & .IV_SPA & "/" & .IV_SPD & "/" & .IV_SPE
            lbl_Ability.Text = "Ability: " & GetAbilityName(.Ability)
            lbl_Nature.Text = "Nature: " & GetNature(.Nature)
            lbl_Move1.Text = GetMoveName(.Move1)
            lbl_Move2.Text = GetMoveName(.Move2)
            lbl_Move3.Text = GetMoveName(.Move3)
            lbl_Move4.Text = GetMoveName(.Move4)
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Pokémon"
                GroupBox3.Enabled = False
                GroupBox2.Enabled = True
                Array.Clear(WC.Data, 0, &H5F)
                WC.CardType = 1
            Case "Item"
                GroupBox3.Enabled = True
                GroupBox2.Enabled = False
                Array.Clear(WC.Data, 0, &H5F)
                WC.CardType = 2
            Case "Power"
                GroupBox3.Enabled = True
                GroupBox2.Enabled = False
                Array.Clear(WC.Data, 0, &H5F)
                WC.CardType = 3
        End Select
        GrabValues()
        'Debug.Print(GetMoveID(ComboBox2.SelectedItem.ToString))
        'TypeMove(lbl_Species, ComboBox2.SelectedItem.ToString)
    End Sub

    Private Sub Nud_CardID_ValueChanged(sender As Object, e As EventArgs) Handles nud_CardID.ValueChanged
        WC.CardID = nud_CardID.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllBytes(Main.Local & "\output.pgf", WC.Data, False)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        WC.TID = GetItemID(ComboBox1.Text)
    End Sub
End Class