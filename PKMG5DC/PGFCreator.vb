Imports System.IO
Public Class PGFCreator
    Dim WC As New PGF 'Wondercard
    Dim InputPK5 As New PK5 'Pokemon Data
    Dim OpenFile As New OpenFileDialog
    ReadOnly Natures() As String = {"勤奋", "怕寂寞", "勇敢", "固执", "顽皮", "大胆", "坦率", "悠闲", "淘气", "乐天", "胆小", "急躁", "认真", "爽朗", "天真", "内敛",
        "慢吞吞", "冷静", "害羞", "马虎", "温和", "温顺", "自大", "慎重", "浮躁"} 'List of Natures
    Private Sub PGFCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG Then
        Me.Size = New Size(1344, 579)
#Else
            Me.Size = New Size(452, 579)
        cb_CardType.Items.Remove("释出之力")
        CenterToScreen()
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
        WC.EventTitle = ""
        EnDisAblePKM(False)
    End Sub

    'Enables/Disables controls until a .pk5 is given
    Private Sub EnDisAblePKM(Enable As Boolean)
        cb_AbilitySlot.Enabled = Enable
        cb_Gender.Enabled = Enable
        cb_Nature.Enabled = Enable
        cb_OTGender.Enabled = Enable
        cb_Shiny.Enabled = Enable
        cx_IV.Enabled = Enable
        cx_Lang.Enabled = Enable
        cx_Origin.Enabled = Enable
        cx_PID.Enabled = Enable
        nud_Level.Enabled = Enable
        lbl_AbilitySlot.Enabled = Enable
        lbl_Gender.Enabled = Enable
        lbl_Level.Enabled = Enable
        lbl_Nature.Enabled = Enable
        lbl_OTGender.Enabled = Enable
        lbl_Shiny.Enabled = Enable
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
        Cx_Origin_CheckedChanged(sender, e)
    End Sub

    'Grabs values from PK5
    Private Sub GrabValues()
        Try
            With WC
                Select Case WC.CardType
                    Case 1
                        If lbl_PK5Name.Text <> "打开.pk5文件 ------->" Then
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
                            nud_Level.Value = InputPK5.Level
                            ConvertValues()
                            Desc()
                        End If
                    Case Else
                End Select
                WC.CardFrom = &H44
                WC.Status = 1
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
            lbl_IVs.Text = "个体值: " & .IV_HP & "/" & .IV_ATK & "/" & .IV_DEF & "/" & .IV_SPA & "/" & .IV_SPD & "/" & .IV_SPE
            lbl_Ability.Text = "特性: " & GetAbilityName(.Ability)
            lbl_Natures.Text = "性格: " & Natures(.Nature)
            lbl_Move1.Text = GetMoveName(.Move1)
            lbl_Move2.Text = GetMoveName(.Move2)
            lbl_Move3.Text = GetMoveName(.Move3)
            lbl_Move4.Text = GetMoveName(.Move4)
            TypeMove(lbl_Move1, lbl_Move1.Text)
            TypeMove(lbl_Move2, lbl_Move2.Text)
            TypeMove(lbl_Move3, lbl_Move3.Text)
            TypeMove(lbl_Move4, lbl_Move4.Text)
            gb_PKDetails.Visible = True
        End With
    End Sub

    'Figures out Language
    Private Function Language(id As Byte)
        Select Case id
            Case &H1
                Return "日本語 (Japan)"
            Case &H2
                Return "English (US/UK/AU)"
            Case &H3
                Return "Français (France/Québec)"
            Case &H4
                Return "Italiano (Italy)"
            Case &H5
                Return "Deutsch (Germany)"
            Case &H7
                Return "Español (Spain/Latin Americas)"
            Case &H8
                Return "한국어 (South Korea)"
            Case Else
                Return ""
        End Select
    End Function
    'Figures out Origin
    Private Function Origin(id As Byte)
        Select Case id
            Case &H1
                Return "蓝宝石"
            Case &H2
                Return "红宝石"
            Case &H3
                Return "绿宝石"
            Case &H4
                Return "火红"
            Case &H5
                Return "叶绿"
            Case &HF
                Return "圆形竞技场/XD"
            Case &HA
                Return "钻石"
            Case &HB
                Return "珍珠"
            Case &HC
                Return "白金"
            Case &H7
                Return "心金"
            Case &H8
                Return "魂银"
            Case &H14
                Return "白"
            Case &H15
                Return "黑"
            Case &H16
                Return "白2"
            Case &H17
                Return "黑2"
            Case Else
                Return ""
        End Select
    End Function
#Region "Controls"
    'Change Card Type
    Private Sub Cb_CardType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_CardType.SelectedIndexChanged
        Select Case cb_CardType.Text
            Case "宝可梦"
                gb_Item.Enabled = False
                gb_Power.Enabled = False
                gb_Pokemon.Enabled = True
                gb_Pokemon.Location = New Point(16, 59)
                gb_Item.Location = New Point(471, 59)
                gb_Power.Location = New Point(922, 59)
                Array.Clear(WC.Data, 0, &H5F)
                WC.CardType = 1
            Case "道具"
                gb_Item.Enabled = True
                gb_Pokemon.Enabled = False
                gb_Power.Enabled = False
                gb_Pokemon.Location = New Point(471, 59)
                gb_Item.Location = New Point(16, 59)
                gb_Power.Location = New Point(922, 59)
                Array.Clear(WC.Data, 0, &H5F)
                WC.CardType = 2
            Case "释出之力"
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
        EnDisAblePKM(True)
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
            Case "随机"
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
                cx_PID.Text = "固定PID"
                HoverInfo.SetToolTip(cx_PID, "PID将按.pk5文件中的设置
PID: " & Hex(InputPK5.PID))
            Case False
                WC.PID = &H0
                cx_PID.Text = "随机PID"
                HoverInfo.SetToolTip(cx_PID, "PID将在接收游戏中随机生成")
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
                cx_IV.Text = "固定IVs"
                HoverInfo.SetToolTip(cx_IV, "个体值将按.pk5文件中的设置
" & lbl_IVs.Text)
            Case False
                WC.IV_HP = &HFF
                WC.IV_ATK = &HFF
                WC.IV_DEF = &HFF
                WC.IV_SPE = &HFF
                WC.IV_SPA = &HFF
                WC.IV_SPD = &HFF
                cx_IV.Text = "随机个体值"
                HoverInfo.SetToolTip(cx_IV, "个体值将在接收游戏中随机生成")
        End Select
    End Sub

    'Select whether language is random or taken from pk5
    Private Sub Cx_Lang_CheckedChanged(sender As Object, e As EventArgs) Handles cx_Lang.CheckedChanged
        Select Case cx_Lang.Checked
            Case True
                WC.Language = &H0
                cx_Lang.Text = "自适应设定为接收方的语种"
                HoverInfo.SetToolTip(cx_Lang, "语种将为接收的游戏的语种设置")
            Case False
                WC.Language = InputPK5.Language
                cx_Lang.Text = "固定语种"
                HoverInfo.SetToolTip(cx_Lang, "语种将按.pk5文件中的设置
语种: " & Language(InputPK5.Language))
        End Select
    End Sub

    'Select whether origin is random or taken from pk5
    Private Sub Cx_Origin_CheckedChanged(sender As Object, e As EventArgs) Handles cx_Origin.CheckedChanged
        Select Case cx_Origin.Checked
            Case True
                WC.Origin = &H0
                cx_Origin.Text = "自适应设定为接收方的游戏版本"
                HoverInfo.SetToolTip(cx_Origin, "语种将为接收的游戏的游戏版本设置")
            Case False
                WC.Origin = InputPK5.Origin
                cx_Origin.Text = "固定游戏版本"
                HoverInfo.SetToolTip(cx_Origin, "游戏版本按.pk5文件中的设置
游戏版本: " & Origin(InputPK5.Origin))
        End Select
    End Sub

    'Choose Item
    Private Sub Cb_Item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Item.SelectedIndexChanged
        WC.TID = GetItemID(cb_Item.Text)
        GrabValues()
    End Sub

    'Choose Pass Power ID
    'No Known Info on this
    Private Sub Nud_Power_ValueChanged(sender As Object, e As EventArgs) Handles nud_Power.ValueChanged
        WC.TID = nud_Power.Value
        GrabValues()
    End Sub
    Private Function Checks(ctl As Control, lbl As Label)
        Dim missing As Boolean
        Select Case ctl.Text
            Case "", Nothing
                missing = True
                lbl.ForeColor = Color.Red
            Case Else
                missing = False
                lbl.ForeColor = DefaultForeColor
        End Select
        Return missing
    End Function

    'Output Button
    Private Sub Btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        'My.Computer.FileSystem.WriteAllBytes(Main5.Local & "\output.pgf", WC.Data, False)
        Dim chk As Boolean = False
        Dim ctrls As Control() = {tb_CardTitle, lbl_CardTitle}
        For i = 0 To 1 Step 2
            Select Case chk
                Case False
                    chk = Checks(ctrls(0), ctrls(1))
                Case True
                    Exit For
            End Select
        Next i
        Select Case chk
            Case True
                MsgB("缺少字段",,,,, "错误")
            Case Else
                Main5.Card.Wondercards(Main5.tc_Cards.SelectedIndex) = WC.Data
                Main5.lb_PGF.Text = nud_CardID.Value & " - " & tb_CardTitle.Text & " (自定义)"
                Close()
        End Select
    End Sub
#End Region
End Class