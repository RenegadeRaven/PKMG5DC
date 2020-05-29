Imports System.IO
Public Class PGFCreator
    Dim WC As New PGF 'Wondercard
    Dim InputPK5 As New PK5 'Pokemon Data
    Dim OpenFile As New OpenFileDialog
    ReadOnly Natures() As String = {"Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest",
        "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky"} 'List of Natures
    Private Sub PGFCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG Then
        Me.Size = New Size(1387, 579)
#Else
            Me.Size = New Size(483, 579)
            cb_CardType.Items.Remove("Pass Power")
#End If
        PopulateItems(cb_Item)
        Defaults()
    End Sub

    'Sets Default Settings
    Private Sub Defaults()
        cb_CardType.SelectedIndex = 0
        cb_Gender.SelectedIndex = 2
        cb_OTGender.SelectedIndex = 2
        cb_AbilitySlot.SelectedIndex = 3
        cb_Shiny.SelectedIndex = 1
        cb_Nature.SelectedIndex = 0
        cx_Lang.Checked = True
        cx_Origin.Checked = True
        cb_Item.SelectedIndex = 0
    End Sub

    'Updates the WC with selected settings
    Private Sub UpdateValues(sender As Object, e As EventArgs)
        cb_Gender_SelectedIndexChanged(sender, e)
        cb_OTGender_SelectedIndexChanged(sender, e)
        cb_AbilitySlot_SelectedIndexChanged(sender, e)
        nud_Level_ValueChanged(sender, e)
        cb_Shiny_SelectedIndexChanged(sender, e)
        cb_Nature_SelectedIndexChanged(sender, e)
        cx_PID_CheckedChanged(sender, e)
        cx_IV_CheckedChanged(sender, e)
        cx_Lang_CheckedChanged(sender, e)
        cx_Origin_CheckedChanged(sender, e)
    End Sub

    'Grabs values from PK5
    Private Sub GrabValues()
        Try
            With WC
                Select Case WC.CardType
                    Case 1
                        .TID = InputPK5.TID
                        .SID = InputPK5.SID
                        If cx_Origin.Checked = False Then .Origin = InputPK5.Origin
                        If cx_PID.Checked = True Then .PID = InputPK5.PID
                        .Ball = InputPK5.Ball
                        .Item = InputPK5.Item
                        .Move1 = InputPK5.Move1
                        .Move2 = InputPK5.Move2
                        .Move3 = InputPK5.Move3
                        .Move4 = InputPK5.Move4
                        .Dex = InputPK5.Dex
                        If cx_Lang.Checked = False Then .Language = InputPK5.Language
                        If InputPK5.IsNicknamed = True Then .Nickname = InputPK5.Nickname Else .Nickname = ""
                        .Nature = InputPK5.Nature
                        .EggMet = InputPK5.EggMet
                        .Met = InputPK5.Met
                        If cx_IV.Checked = True Then .IV_HP = InputPK5.IV_HP
                        If cx_IV.Checked = True Then .IV_ATK = InputPK5.IV_ATK
                        If cx_IV.Checked = True Then .IV_DEF = InputPK5.IV_DEF
                        If cx_IV.Checked = True Then .IV_SPE = InputPK5.IV_SPE
                        If cx_IV.Checked = True Then .IV_SPA = InputPK5.IV_SPA
                        If cx_IV.Checked = True Then .IV_SPD = InputPK5.IV_SPD
                        .Egg = InputPK5.IsEgg
                        .OT_Name = InputPK5.OT_Name
                        .OT_Gender = InputPK5.OT_Gender
                        .Gender = InputPK5.Gender
                        .Level = InputPK5.Level
                        ConvertValues()
                        Desc()
                    Case 2
                        .TID = GetItemID(cb_Item.Text)
                    Case 3
                End Select
                .CardFrom = &H44
                .Status = 1
            End With
        Catch ex As Exception
        End Try
    End Sub

    'Converts value format
    'Currently just Ribbons
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

    'Generates Pokemon Description
    Private Sub Desc()
        With InputPK5
            lbl_Species.Text = GetPokeName(.Dex) & " @ " & GetItemName(.Item)
            lbl_IVs.Text = "IVs: " & .IV_HP & "/" & .IV_ATK & "/" & .IV_DEF & "/" & .IV_SPA & "/" & .IV_SPD & "/" & .IV_SPE
            lbl_Ability.Text = "Ability: " & GetAbilityName(.Ability)
            lbl_Natures.Text = "Nature: " & Natures(.Nature)
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
#Region "Controls"
    'Change Card Type
    Private Sub Cb_CardType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_CardType.SelectedIndexChanged
        Select Case cb_CardType.Text
            Case "Pokémon"
                gb_Item.Enabled = False
                gb_Power.Enabled = False
                gb_Pokemon.Enabled = True
                gb_Pokemon.Location = New Point(16, 59)
                gb_Item.Location = New Point(471, 59)
                gb_Power.Location = New Point(922, 59)
                Array.Clear(WC.Data, 0, &H5F)
                WC.CardType = 1
            Case "Item"
                gb_Item.Enabled = True
                gb_Pokemon.Enabled = False
                gb_Power.Enabled = False
                gb_Pokemon.Location = New Point(471, 59)
                gb_Item.Location = New Point(16, 59)
                gb_Power.Location = New Point(922, 59)
                Array.Clear(WC.Data, 0, &H5F)
                WC.CardType = 2
            Case "Pass Power"
                gb_Item.Enabled = False
                gb_Pokemon.Enabled = False
                gb_Power.Enabled = True
                gb_Pokemon.Location = New Point(922, 59)
                gb_Item.Location = New Point(471, 59)
                gb_Power.Location = New Point(16, 59)
                Array.Clear(WC.Data, 0, &H5F)
                WC.CardType = 3
        End Select
    End Sub

    'Change Card ID
    Private Sub Nud_CardID_ValueChanged(sender As Object, e As EventArgs) Handles nud_CardID.ValueChanged
        WC.CardID = nud_CardID.Value
    End Sub

    'Change Card Title
    Private Sub Tb_CardTitle_TextChanged(sender As Object, e As EventArgs) Handles tb_CardTitle.TextChanged
        WC.EventTitle = tb_CardTitle.Text
    End Sub

    'Loads the PK5 file
    Private Sub Btn_OpenPK5_Click(sender As Object, e As EventArgs) Handles btn_OpenPK5.Click
        OpenFile.Filter = "Gen 5 PKM (*.pk5)|*.pk5|All files (*.*)|*.*"
        Dim res As DialogResult = OpenFile.ShowDialog()
        If res <> Windows.Forms.DialogResult.Cancel Then
            Dim myFile As String = Path.GetFileName(OpenFile.FileName)
            lbl_PK5Name.Text = myFile
            InputPK5.Data = File.ReadAllBytes(OpenFile.FileName)
        End If
        GrabValues()
        UpdateValues(sender, e)
    End Sub

    'Choose Gender
    Private Sub Cb_Gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Gender.SelectedIndexChanged
        WC.Gender = cb_Gender.SelectedIndex
    End Sub

    'Choose OT Gender
    Private Sub Cb_OTGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_OTGender.SelectedIndexChanged
        Select Case cb_OTGender.SelectedIndex
            Case 0, 1
                WC.OT_Gender = cb_OTGender.SelectedIndex
            Case 2
                WC.OT_Gender = cb_OTGender.SelectedIndex + 1
        End Select
    End Sub

    'Choose Ability
    Private Sub Cb_AbilitySlot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_AbilitySlot.SelectedIndexChanged
        WC.Ability = cb_AbilitySlot.SelectedIndex
    End Sub

    'Choose Level
    Private Sub Nud_Level_ValueChanged(sender As Object, e As EventArgs) Handles nud_Level.ValueChanged
        WC.Level = nud_Level.Value
    End Sub

    'Choose Shiny Possibility
    Private Sub Cb_Shiny_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Shiny.SelectedIndexChanged
        WC.Shiny = cb_Shiny.SelectedIndex
    End Sub

    'Choose Nature
    Private Sub Cb_Nature_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Nature.SelectedIndexChanged
        Select Case cb_Nature.Text
            Case "Random"
                WC.Nature = &HFF
            Case Else
                WC.Nature = Array.IndexOf(Natures, cb_Nature.Text)
        End Select
    End Sub

    'Select whether PID is random or taken from pk5
    Private Sub Cx_PID_CheckedChanged(sender As Object, e As EventArgs) Handles cx_PID.CheckedChanged
        Select Case cx_PID.Checked
            Case True
                WC.PID = InputPK5.PID
                cx_PID.Text = "Set PID"
            Case False
                WC.PID = &H0
                cx_PID.Text = "Random PID"
        End Select
    End Sub

    'Select whether IVs are random or taken from pk5
    Private Sub Cx_IV_CheckedChanged(sender As Object, e As EventArgs) Handles cx_IV.CheckedChanged
        Select Case cx_IV.Checked
            Case True
                WC.IV_HP = InputPK5.IV_HP
                WC.IV_ATK = InputPK5.IV_ATK
                WC.IV_DEF = InputPK5.IV_DEF
                WC.IV_SPE = InputPK5.IV_SPE
                WC.IV_SPA = InputPK5.IV_SPA
                WC.IV_SPD = InputPK5.IV_SPD
                cx_IV.Text = "Set IVs"
            Case False
                WC.IV_HP = &HFF
                WC.IV_ATK = &HFF
                WC.IV_DEF = &HFF
                WC.IV_SPE = &HFF
                WC.IV_SPA = &HFF
                WC.IV_SPD = &HFF
                cx_IV.Text = "Random IVs"
        End Select
    End Sub

    'Select whether language is random or taken from pk5
    Private Sub Cx_Lang_CheckedChanged(sender As Object, e As EventArgs) Handles cx_Lang.CheckedChanged
        Select Case cx_Lang.Checked
            Case True
                WC.Language = &H0
                cx_Lang.Text = "Recipient Language"
            Case False
                WC.Language = InputPK5.Language
                cx_Lang.Text = "Set Language"
        End Select
    End Sub

    'Select whether origin is random or taken from pk5
    Private Sub Cx_Origin_CheckedChanged(sender As Object, e As EventArgs) Handles cx_Origin.CheckedChanged
        Select Case cx_Origin.Checked
            Case True
                WC.Origin = &H0
                cx_Lang.Text = "Recipient Origin Game"
            Case False
                WC.Origin = InputPK5.Origin
                cx_Lang.Text = "Set Origin Game"
        End Select
    End Sub

    'Choose Item
    Private Sub Cb_Item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Item.SelectedIndexChanged
        WC.TID = GetItemID(cb_Item.Text)
    End Sub

    'Choose Pass Power ID
    'No Known Info on this
    Private Sub Nud_Power_ValueChanged(sender As Object, e As EventArgs) Handles nud_Power.ValueChanged
        WC.TID = nud_Power.Value
    End Sub

    'Output Button
    Private Sub Btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        My.Computer.FileSystem.WriteAllBytes(Main.Local & "\output.pgf", WC.Data, False)
    End Sub
#End Region
End Class