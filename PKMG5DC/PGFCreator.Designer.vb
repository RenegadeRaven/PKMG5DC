﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PGFCreator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PGFCreator))
        Me.lbl_PK5Name = New System.Windows.Forms.Label()
        Me.btn_OpenPKM = New System.Windows.Forms.Button()
        Me.gb_PKDetails = New System.Windows.Forms.GroupBox()
        Me.lbl_Move4 = New System.Windows.Forms.Label()
        Me.lbl_Move3 = New System.Windows.Forms.Label()
        Me.lbl_Move2 = New System.Windows.Forms.Label()
        Me.lbl_Move1 = New System.Windows.Forms.Label()
        Me.lbl_IVs = New System.Windows.Forms.Label()
        Me.lbl_Natures = New System.Windows.Forms.Label()
        Me.lbl_Ability = New System.Windows.Forms.Label()
        Me.lbl_Species = New System.Windows.Forms.Label()
        Me.cb_CardType = New System.Windows.Forms.ComboBox()
        Me.HoverInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.gb_Pokemon = New System.Windows.Forms.GroupBox()
        Me.cx_Origin = New System.Windows.Forms.CheckBox()
        Me.cx_Lang = New System.Windows.Forms.CheckBox()
        Me.cx_IV = New System.Windows.Forms.CheckBox()
        Me.cx_PID = New System.Windows.Forms.CheckBox()
        Me.lbl_Nature = New System.Windows.Forms.Label()
        Me.cb_Nature = New System.Windows.Forms.ComboBox()
        Me.lbl_Shiny = New System.Windows.Forms.Label()
        Me.cb_Shiny = New System.Windows.Forms.ComboBox()
        Me.lbl_Level = New System.Windows.Forms.Label()
        Me.nud_Level = New System.Windows.Forms.NumericUpDown()
        Me.lbl_OTGender = New System.Windows.Forms.Label()
        Me.cb_OTGender = New System.Windows.Forms.ComboBox()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.cb_Gender = New System.Windows.Forms.ComboBox()
        Me.lbl_AbilitySlot = New System.Windows.Forms.Label()
        Me.cb_AbilitySlot = New System.Windows.Forms.ComboBox()
        Me.gb_Item = New System.Windows.Forms.GroupBox()
        Me.lbl_Simple = New System.Windows.Forms.Label()
        Me.cb_Item = New System.Windows.Forms.ComboBox()
        Me.lbl_CardID = New System.Windows.Forms.Label()
        Me.nud_CardID = New System.Windows.Forms.NumericUpDown()
        Me.lbl_CardType = New System.Windows.Forms.Label()
        Me.btn_Done = New System.Windows.Forms.Button()
        Me.lbl_CardTitle = New System.Windows.Forms.Label()
        Me.tb_CardTitle = New System.Windows.Forms.TextBox()
        Me.gb_Power = New System.Windows.Forms.GroupBox()
        Me.nud_Power = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Simple1 = New System.Windows.Forms.Label()
        Me.gb_PKDetails.SuspendLayout()
        Me.gb_Pokemon.SuspendLayout()
        CType(Me.nud_Level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Item.SuspendLayout()
        CType(Me.nud_CardID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Power.SuspendLayout()
        CType(Me.nud_Power, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_PK5Name
        '
        Me.lbl_PK5Name.AutoEllipsis = True
        Me.lbl_PK5Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_PK5Name.Location = New System.Drawing.Point(17, 27)
        Me.lbl_PK5Name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.lbl_PK5Name.Name = "lbl_PK5Name"
        Me.lbl_PK5Name.Size = New System.Drawing.Size(376, 21)
        Me.lbl_PK5Name.TabIndex = 10
        Me.lbl_PK5Name.Text = "Open .pkm ------->"
        Me.lbl_PK5Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_OpenPKM
        '
        Me.btn_OpenPKM.Location = New System.Drawing.Point(401, 23)
        Me.btn_OpenPKM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_OpenPKM.Name = "btn_OpenPKM"
        Me.btn_OpenPKM.Size = New System.Drawing.Size(100, 28)
        Me.btn_OpenPKM.TabIndex = 9
        Me.btn_OpenPKM.Text = "Open .pkm"
        Me.btn_OpenPKM.UseVisualStyleBackColor = True
        '
        'gb_PKDetails
        '
        Me.gb_PKDetails.Controls.Add(Me.lbl_Move4)
        Me.gb_PKDetails.Controls.Add(Me.lbl_Move3)
        Me.gb_PKDetails.Controls.Add(Me.lbl_Move2)
        Me.gb_PKDetails.Controls.Add(Me.lbl_Move1)
        Me.gb_PKDetails.Controls.Add(Me.lbl_IVs)
        Me.gb_PKDetails.Controls.Add(Me.lbl_Natures)
        Me.gb_PKDetails.Controls.Add(Me.lbl_Ability)
        Me.gb_PKDetails.Controls.Add(Me.lbl_Species)
        Me.gb_PKDetails.Location = New System.Drawing.Point(81, 230)
        Me.gb_PKDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_PKDetails.Name = "gb_PKDetails"
        Me.gb_PKDetails.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_PKDetails.Size = New System.Drawing.Size(360, 283)
        Me.gb_PKDetails.TabIndex = 12
        Me.gb_PKDetails.TabStop = False
        Me.gb_PKDetails.Text = "Pokémon Info"
        Me.gb_PKDetails.Visible = False
        '
        'lbl_Move4
        '
        Me.lbl_Move4.AutoSize = True
        Me.lbl_Move4.Location = New System.Drawing.Point(17, 252)
        Me.lbl_Move4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Move4.Name = "lbl_Move4"
        Me.lbl_Move4.Size = New System.Drawing.Size(14, 16)
        Me.lbl_Move4.TabIndex = 7
        Me.lbl_Move4.Text = "- "
        '
        'lbl_Move3
        '
        Me.lbl_Move3.AutoSize = True
        Me.lbl_Move3.Location = New System.Drawing.Point(17, 222)
        Me.lbl_Move3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Move3.Name = "lbl_Move3"
        Me.lbl_Move3.Size = New System.Drawing.Size(14, 16)
        Me.lbl_Move3.TabIndex = 6
        Me.lbl_Move3.Text = "- "
        '
        'lbl_Move2
        '
        Me.lbl_Move2.AutoSize = True
        Me.lbl_Move2.Location = New System.Drawing.Point(17, 191)
        Me.lbl_Move2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Move2.Name = "lbl_Move2"
        Me.lbl_Move2.Size = New System.Drawing.Size(14, 16)
        Me.lbl_Move2.TabIndex = 5
        Me.lbl_Move2.Text = "- "
        '
        'lbl_Move1
        '
        Me.lbl_Move1.AutoSize = True
        Me.lbl_Move1.Location = New System.Drawing.Point(17, 160)
        Me.lbl_Move1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Move1.Name = "lbl_Move1"
        Me.lbl_Move1.Size = New System.Drawing.Size(14, 16)
        Me.lbl_Move1.TabIndex = 4
        Me.lbl_Move1.Text = "- "
        '
        'lbl_IVs
        '
        Me.lbl_IVs.AutoSize = True
        Me.lbl_IVs.Location = New System.Drawing.Point(17, 117)
        Me.lbl_IVs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_IVs.Name = "lbl_IVs"
        Me.lbl_IVs.Size = New System.Drawing.Size(32, 16)
        Me.lbl_IVs.TabIndex = 3
        Me.lbl_IVs.Text = "IVs: "
        Me.HoverInfo.SetToolTip(Me.lbl_IVs, "HP/Atk/Def/SpA/SpD/Spe")
        '
        'lbl_Natures
        '
        Me.lbl_Natures.AutoSize = True
        Me.lbl_Natures.Location = New System.Drawing.Point(17, 86)
        Me.lbl_Natures.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Natures.Name = "lbl_Natures"
        Me.lbl_Natures.Size = New System.Drawing.Size(53, 16)
        Me.lbl_Natures.TabIndex = 2
        Me.lbl_Natures.Text = "Nature: "
        '
        'lbl_Ability
        '
        Me.lbl_Ability.AutoSize = True
        Me.lbl_Ability.Location = New System.Drawing.Point(17, 55)
        Me.lbl_Ability.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Ability.Name = "lbl_Ability"
        Me.lbl_Ability.Size = New System.Drawing.Size(49, 16)
        Me.lbl_Ability.TabIndex = 1
        Me.lbl_Ability.Text = "Ability: "
        '
        'lbl_Species
        '
        Me.lbl_Species.AutoSize = True
        Me.lbl_Species.Location = New System.Drawing.Point(17, 25)
        Me.lbl_Species.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Species.Name = "lbl_Species"
        Me.lbl_Species.Size = New System.Drawing.Size(89, 16)
        Me.lbl_Species.TabIndex = 0
        Me.lbl_Species.Text = "Name @ Item"
        '
        'cb_CardType
        '
        Me.cb_CardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CardType.FormattingEnabled = True
        Me.cb_CardType.Items.AddRange(New Object() {"Pokémon", "Item", "Pass Power"})
        Me.cb_CardType.Location = New System.Drawing.Point(21, 39)
        Me.cb_CardType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_CardType.Name = "cb_CardType"
        Me.cb_CardType.Size = New System.Drawing.Size(124, 24)
        Me.cb_CardType.TabIndex = 13
        '
        'gb_Pokemon
        '
        Me.gb_Pokemon.Controls.Add(Me.cx_Origin)
        Me.gb_Pokemon.Controls.Add(Me.cx_Lang)
        Me.gb_Pokemon.Controls.Add(Me.cx_IV)
        Me.gb_Pokemon.Controls.Add(Me.cx_PID)
        Me.gb_Pokemon.Controls.Add(Me.lbl_Nature)
        Me.gb_Pokemon.Controls.Add(Me.cb_Nature)
        Me.gb_Pokemon.Controls.Add(Me.lbl_Shiny)
        Me.gb_Pokemon.Controls.Add(Me.cb_Shiny)
        Me.gb_Pokemon.Controls.Add(Me.lbl_Level)
        Me.gb_Pokemon.Controls.Add(Me.gb_PKDetails)
        Me.gb_Pokemon.Controls.Add(Me.nud_Level)
        Me.gb_Pokemon.Controls.Add(Me.lbl_OTGender)
        Me.gb_Pokemon.Controls.Add(Me.cb_OTGender)
        Me.gb_Pokemon.Controls.Add(Me.lbl_Gender)
        Me.gb_Pokemon.Controls.Add(Me.cb_Gender)
        Me.gb_Pokemon.Controls.Add(Me.lbl_AbilitySlot)
        Me.gb_Pokemon.Controls.Add(Me.cb_AbilitySlot)
        Me.gb_Pokemon.Controls.Add(Me.lbl_PK5Name)
        Me.gb_Pokemon.Controls.Add(Me.btn_OpenPKM)
        Me.gb_Pokemon.Location = New System.Drawing.Point(21, 73)
        Me.gb_Pokemon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_Pokemon.Name = "gb_Pokemon"
        Me.gb_Pokemon.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_Pokemon.Size = New System.Drawing.Size(536, 529)
        Me.gb_Pokemon.TabIndex = 14
        Me.gb_Pokemon.TabStop = False
        Me.gb_Pokemon.Text = "Pokémon"
        '
        'cx_Origin
        '
        Me.cx_Origin.AutoSize = True
        Me.cx_Origin.Location = New System.Drawing.Point(301, 194)
        Me.cx_Origin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cx_Origin.Name = "cx_Origin"
        Me.cx_Origin.Size = New System.Drawing.Size(164, 20)
        Me.cx_Origin.TabIndex = 35
        Me.cx_Origin.Text = "Recipient Origin Game"
        Me.cx_Origin.UseVisualStyleBackColor = True
        '
        'cx_Lang
        '
        Me.cx_Lang.AutoSize = True
        Me.cx_Lang.Location = New System.Drawing.Point(61, 194)
        Me.cx_Lang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cx_Lang.Name = "cx_Lang"
        Me.cx_Lang.Size = New System.Drawing.Size(150, 20)
        Me.cx_Lang.TabIndex = 34
        Me.cx_Lang.Text = "Recipient Language"
        Me.cx_Lang.UseVisualStyleBackColor = True
        '
        'cx_IV
        '
        Me.cx_IV.AutoSize = True
        Me.cx_IV.Location = New System.Drawing.Point(409, 149)
        Me.cx_IV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cx_IV.Name = "cx_IV"
        Me.cx_IV.Size = New System.Drawing.Size(103, 20)
        Me.cx_IV.TabIndex = 33
        Me.cx_IV.Text = "Random IVs"
        Me.cx_IV.UseVisualStyleBackColor = True
        '
        'cx_PID
        '
        Me.cx_PID.AutoSize = True
        Me.cx_PID.Location = New System.Drawing.Point(285, 149)
        Me.cx_PID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cx_PID.Name = "cx_PID"
        Me.cx_PID.Size = New System.Drawing.Size(106, 20)
        Me.cx_PID.TabIndex = 32
        Me.cx_PID.Text = "Random PID"
        Me.cx_PID.UseVisualStyleBackColor = True
        '
        'lbl_Nature
        '
        Me.lbl_Nature.AutoSize = True
        Me.lbl_Nature.Location = New System.Drawing.Point(147, 129)
        Me.lbl_Nature.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Nature.Name = "lbl_Nature"
        Me.lbl_Nature.Size = New System.Drawing.Size(50, 16)
        Me.lbl_Nature.TabIndex = 31
        Me.lbl_Nature.Text = "Nature:"
        '
        'cb_Nature
        '
        Me.cb_Nature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Nature.FormattingEnabled = True
        Me.cb_Nature.Items.AddRange(New Object() {"Random", "Adamant", "Bashful", "Bold", "Brave", "Calm", "Careful", "Docile", "Gentle", "Hardy", "Hasty", "Impish", "Jolly", "Lax", "Lonely", "Mild", "Modest", "Naive", "Naughty", "Quiet", "Quirky", "Rash", "Relaxed", "Sassy", "Serious", "Timid"})
        Me.cb_Nature.Location = New System.Drawing.Point(151, 146)
        Me.cb_Nature.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_Nature.Name = "cb_Nature"
        Me.cb_Nature.Size = New System.Drawing.Size(124, 24)
        Me.cb_Nature.TabIndex = 30
        '
        'lbl_Shiny
        '
        Me.lbl_Shiny.AutoSize = True
        Me.lbl_Shiny.Location = New System.Drawing.Point(13, 129)
        Me.lbl_Shiny.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Shiny.Name = "lbl_Shiny"
        Me.lbl_Shiny.Size = New System.Drawing.Size(68, 16)
        Me.lbl_Shiny.TabIndex = 29
        Me.lbl_Shiny.Text = "Shininess:"
        '
        'cb_Shiny
        '
        Me.cb_Shiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Shiny.FormattingEnabled = True
        Me.cb_Shiny.Items.AddRange(New Object() {"Never Shiny", "Can be Shiny", "Always Shiny"})
        Me.cb_Shiny.Location = New System.Drawing.Point(17, 146)
        Me.cb_Shiny.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_Shiny.Name = "cb_Shiny"
        Me.cb_Shiny.Size = New System.Drawing.Size(124, 24)
        Me.cb_Shiny.TabIndex = 28
        '
        'lbl_Level
        '
        Me.lbl_Level.AutoSize = True
        Me.lbl_Level.Location = New System.Drawing.Point(415, 73)
        Me.lbl_Level.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Level.Name = "lbl_Level"
        Me.lbl_Level.Size = New System.Drawing.Size(43, 16)
        Me.lbl_Level.TabIndex = 23
        Me.lbl_Level.Text = "Level:"
        '
        'nud_Level
        '
        Me.nud_Level.Location = New System.Drawing.Point(419, 90)
        Me.nud_Level.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nud_Level.Name = "nud_Level"
        Me.nud_Level.Size = New System.Drawing.Size(80, 22)
        Me.nud_Level.TabIndex = 22
        '
        'lbl_OTGender
        '
        Me.lbl_OTGender.AutoSize = True
        Me.lbl_OTGender.Location = New System.Drawing.Point(148, 71)
        Me.lbl_OTGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_OTGender.Name = "lbl_OTGender"
        Me.lbl_OTGender.Size = New System.Drawing.Size(77, 16)
        Me.lbl_OTGender.TabIndex = 27
        Me.lbl_OTGender.Text = "OT Gender:"
        '
        'cb_OTGender
        '
        Me.cb_OTGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_OTGender.FormattingEnabled = True
        Me.cb_OTGender.Items.AddRange(New Object() {"Male", "Female", "Recipient"})
        Me.cb_OTGender.Location = New System.Drawing.Point(152, 89)
        Me.cb_OTGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_OTGender.Name = "cb_OTGender"
        Me.cb_OTGender.Size = New System.Drawing.Size(124, 24)
        Me.cb_OTGender.TabIndex = 26
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.Location = New System.Drawing.Point(15, 71)
        Me.lbl_Gender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(55, 16)
        Me.lbl_Gender.TabIndex = 25
        Me.lbl_Gender.Text = "Gender:"
        '
        'cb_Gender
        '
        Me.cb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Gender.FormattingEnabled = True
        Me.cb_Gender.Items.AddRange(New Object() {"Male", "Female", "Random"})
        Me.cb_Gender.Location = New System.Drawing.Point(19, 89)
        Me.cb_Gender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_Gender.Name = "cb_Gender"
        Me.cb_Gender.Size = New System.Drawing.Size(124, 24)
        Me.cb_Gender.TabIndex = 24
        '
        'lbl_AbilitySlot
        '
        Me.lbl_AbilitySlot.AutoSize = True
        Me.lbl_AbilitySlot.Location = New System.Drawing.Point(281, 71)
        Me.lbl_AbilitySlot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_AbilitySlot.Name = "lbl_AbilitySlot"
        Me.lbl_AbilitySlot.Size = New System.Drawing.Size(46, 16)
        Me.lbl_AbilitySlot.TabIndex = 23
        Me.lbl_AbilitySlot.Text = "Ability:"
        '
        'cb_AbilitySlot
        '
        Me.cb_AbilitySlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_AbilitySlot.FormattingEnabled = True
        Me.cb_AbilitySlot.Items.AddRange(New Object() {"Ability 1", "Ability 2", "Hidden Ability", "Random (w/o HA)", "Random (w/ HA)"})
        Me.cb_AbilitySlot.Location = New System.Drawing.Point(285, 89)
        Me.cb_AbilitySlot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_AbilitySlot.Name = "cb_AbilitySlot"
        Me.cb_AbilitySlot.Size = New System.Drawing.Size(124, 24)
        Me.cb_AbilitySlot.TabIndex = 22
        '
        'gb_Item
        '
        Me.gb_Item.Controls.Add(Me.lbl_Simple)
        Me.gb_Item.Controls.Add(Me.cb_Item)
        Me.gb_Item.Location = New System.Drawing.Point(587, 73)
        Me.gb_Item.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_Item.Name = "gb_Item"
        Me.gb_Item.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_Item.Size = New System.Drawing.Size(580, 529)
        Me.gb_Item.TabIndex = 15
        Me.gb_Item.TabStop = False
        Me.gb_Item.Text = "Item"
        '
        'lbl_Simple
        '
        Me.lbl_Simple.AutoSize = True
        Me.lbl_Simple.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Simple.Location = New System.Drawing.Point(215, 246)
        Me.lbl_Simple.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Simple.Name = "lbl_Simple"
        Me.lbl_Simple.Size = New System.Drawing.Size(122, 32)
        Me.lbl_Simple.TabIndex = 1
        Me.lbl_Simple.Text = "That's all" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pretty simple isn't it."
        Me.lbl_Simple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_Item
        '
        Me.cb_Item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_Item.FormattingEnabled = True
        Me.cb_Item.Location = New System.Drawing.Point(32, 22)
        Me.cb_Item.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_Item.Name = "cb_Item"
        Me.cb_Item.Size = New System.Drawing.Size(513, 24)
        Me.cb_Item.TabIndex = 0
        '
        'lbl_CardID
        '
        Me.lbl_CardID.AutoSize = True
        Me.lbl_CardID.Location = New System.Drawing.Point(473, 22)
        Me.lbl_CardID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CardID.Name = "lbl_CardID"
        Me.lbl_CardID.Size = New System.Drawing.Size(55, 16)
        Me.lbl_CardID.TabIndex = 17
        Me.lbl_CardID.Text = "Card ID:"
        '
        'nud_CardID
        '
        Me.nud_CardID.Location = New System.Drawing.Point(477, 39)
        Me.nud_CardID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nud_CardID.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nud_CardID.Name = "nud_CardID"
        Me.nud_CardID.Size = New System.Drawing.Size(80, 22)
        Me.nud_CardID.TabIndex = 16
        '
        'lbl_CardType
        '
        Me.lbl_CardType.AutoSize = True
        Me.lbl_CardType.Location = New System.Drawing.Point(17, 22)
        Me.lbl_CardType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CardType.Name = "lbl_CardType"
        Me.lbl_CardType.Size = New System.Drawing.Size(74, 16)
        Me.lbl_CardType.TabIndex = 18
        Me.lbl_CardType.Text = "Card Type:"
        '
        'btn_Done
        '
        Me.btn_Done.Location = New System.Drawing.Point(21, 622)
        Me.btn_Done.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(536, 28)
        Me.btn_Done.TabIndex = 19
        Me.btn_Done.Text = "Done"
        Me.btn_Done.UseVisualStyleBackColor = True
        '
        'lbl_CardTitle
        '
        Me.lbl_CardTitle.AutoSize = True
        Me.lbl_CardTitle.Location = New System.Drawing.Point(161, 22)
        Me.lbl_CardTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CardTitle.Name = "lbl_CardTitle"
        Me.lbl_CardTitle.Size = New System.Drawing.Size(68, 16)
        Me.lbl_CardTitle.TabIndex = 21
        Me.lbl_CardTitle.Text = "Card Title:"
        '
        'tb_CardTitle
        '
        Me.tb_CardTitle.Location = New System.Drawing.Point(163, 39)
        Me.tb_CardTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_CardTitle.MaxLength = 36
        Me.tb_CardTitle.Name = "tb_CardTitle"
        Me.tb_CardTitle.Size = New System.Drawing.Size(297, 22)
        Me.tb_CardTitle.TabIndex = 20
        '
        'gb_Power
        '
        Me.gb_Power.Controls.Add(Me.nud_Power)
        Me.gb_Power.Controls.Add(Me.lbl_Simple1)
        Me.gb_Power.Location = New System.Drawing.Point(1175, 73)
        Me.gb_Power.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_Power.Name = "gb_Power"
        Me.gb_Power.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gb_Power.Size = New System.Drawing.Size(580, 529)
        Me.gb_Power.TabIndex = 16
        Me.gb_Power.TabStop = False
        Me.gb_Power.Text = "Pass Power"
        '
        'nud_Power
        '
        Me.nud_Power.Location = New System.Drawing.Point(235, 27)
        Me.nud_Power.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nud_Power.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nud_Power.Name = "nud_Power"
        Me.nud_Power.Size = New System.Drawing.Size(80, 22)
        Me.nud_Power.TabIndex = 17
        '
        'lbl_Simple1
        '
        Me.lbl_Simple1.AutoSize = True
        Me.lbl_Simple1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Simple1.Location = New System.Drawing.Point(215, 246)
        Me.lbl_Simple1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Simple1.Name = "lbl_Simple1"
        Me.lbl_Simple1.Size = New System.Drawing.Size(122, 32)
        Me.lbl_Simple1.TabIndex = 1
        Me.lbl_Simple1.Text = "That's all" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pretty simple isn't it."
        Me.lbl_Simple1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PGFCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1771, 665)
        Me.Controls.Add(Me.gb_Power)
        Me.Controls.Add(Me.lbl_CardTitle)
        Me.Controls.Add(Me.tb_CardTitle)
        Me.Controls.Add(Me.btn_Done)
        Me.Controls.Add(Me.lbl_CardType)
        Me.Controls.Add(Me.lbl_CardID)
        Me.Controls.Add(Me.nud_CardID)
        Me.Controls.Add(Me.gb_Item)
        Me.Controls.Add(Me.gb_Pokemon)
        Me.Controls.Add(Me.cb_CardType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PGFCreator"
        Me.Text = "PGFCreator"
        Me.gb_PKDetails.ResumeLayout(False)
        Me.gb_PKDetails.PerformLayout()
        Me.gb_Pokemon.ResumeLayout(False)
        Me.gb_Pokemon.PerformLayout()
        CType(Me.nud_Level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Item.ResumeLayout(False)
        Me.gb_Item.PerformLayout()
        CType(Me.nud_CardID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Power.ResumeLayout(False)
        Me.gb_Power.PerformLayout()
        CType(Me.nud_Power, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_PK5Name As Label
    Friend WithEvents btn_OpenPKM As Button
    Friend WithEvents gb_PKDetails As GroupBox
    Friend WithEvents lbl_Species As Label
    Friend WithEvents cb_CardType As ComboBox
    Friend WithEvents lbl_Move4 As Label
    Friend WithEvents lbl_Move3 As Label
    Friend WithEvents lbl_Move2 As Label
    Friend WithEvents lbl_Move1 As Label
    Friend WithEvents lbl_IVs As Label
    Friend WithEvents lbl_Natures As Label
    Friend WithEvents lbl_Ability As Label
    Friend WithEvents HoverInfo As ToolTip
    Friend WithEvents gb_Pokemon As GroupBox
    Friend WithEvents gb_Item As GroupBox
    Friend WithEvents cb_Item As ComboBox
    Friend WithEvents lbl_CardID As Label
    Friend WithEvents nud_CardID As NumericUpDown
    Friend WithEvents lbl_CardType As Label
    Friend WithEvents btn_Done As Button
    Friend WithEvents lbl_CardTitle As Label
    Friend WithEvents tb_CardTitle As TextBox
    Friend WithEvents lbl_AbilitySlot As Label
    Friend WithEvents cb_AbilitySlot As ComboBox
    Friend WithEvents lbl_Gender As Label
    Friend WithEvents cb_Gender As ComboBox
    Friend WithEvents lbl_OTGender As Label
    Friend WithEvents cb_OTGender As ComboBox
    Friend WithEvents lbl_Level As Label
    Friend WithEvents nud_Level As NumericUpDown
    Friend WithEvents lbl_Shiny As Label
    Friend WithEvents cb_Shiny As ComboBox
    Friend WithEvents lbl_Nature As Label
    Friend WithEvents cb_Nature As ComboBox
    Friend WithEvents cx_IV As CheckBox
    Friend WithEvents cx_PID As CheckBox
    Friend WithEvents cx_Origin As CheckBox
    Friend WithEvents cx_Lang As CheckBox
    Friend WithEvents lbl_Simple As Label
    Friend WithEvents gb_Power As GroupBox
    Friend WithEvents nud_Power As NumericUpDown
    Friend WithEvents lbl_Simple1 As Label
End Class
