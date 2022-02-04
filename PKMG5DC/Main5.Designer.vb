<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main5))
        Me.lklb_Update = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmi_Options = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoverInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.pb_Donate = New System.Windows.Forms.PictureBox()
        Me.lklb_Author = New System.Windows.Forms.LinkLabel()
        Me.lb_By = New System.Windows.Forms.Label()
        Me.bt_Build = New System.Windows.Forms.Button()
        Me.bt_PGF = New System.Windows.Forms.Button()
        Me.gb_DateLimit = New System.Windows.Forms.GroupBox()
        Me.bt_ResetDate = New System.Windows.Forms.Button()
        Me.cb_MaxLimit = New System.Windows.Forms.CheckBox()
        Me.bt_SetDate = New System.Windows.Forms.Button()
        Me.lb_End = New System.Windows.Forms.Label()
        Me.lb_Start = New System.Windows.Forms.Label()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.rtb_EventMsg = New System.Windows.Forms.RichTextBox()
        Me.gb_Region = New System.Windows.Forms.GroupBox()
        Me.bt_ResetRegion = New System.Windows.Forms.Button()
        Me.cb_Region = New System.Windows.Forms.ComboBox()
        Me.bt_SetRegion = New System.Windows.Forms.Button()
        Me.bt_Custom = New System.Windows.Forms.Button()
        Me.gb_GameComp = New System.Windows.Forms.GroupBox()
        Me.bt_ResetCompatibility = New System.Windows.Forms.Button()
        Me.cb_White2 = New System.Windows.Forms.CheckBox()
        Me.cb_Black2 = New System.Windows.Forms.CheckBox()
        Me.bt_SetCompatibility = New System.Windows.Forms.Button()
        Me.cb_White = New System.Windows.Forms.CheckBox()
        Me.cb_Black = New System.Windows.Forms.CheckBox()
        Me.lb_EventMsg = New System.Windows.Forms.Label()
        Me.rtb_EventTitle = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_Cards = New System.Windows.Forms.ComboBox()
        Me.gb_Main = New System.Windows.Forms.GroupBox()
        Me.gb_Text = New System.Windows.Forms.GroupBox()
        Me.lb_CharCountNumber = New System.Windows.Forms.Label()
        Me.lb_CharCount = New System.Windows.Forms.Label()
        Me.bt_ResetEventMsg = New System.Windows.Forms.Button()
        Me.bt_SetEventMsg = New System.Windows.Forms.Button()
        Me.gb_Cards = New System.Windows.Forms.GroupBox()
        Me.bt_ClearForm = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pb_Donate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_DateLimit.SuspendLayout()
        Me.gb_Region.SuspendLayout()
        Me.gb_GameComp.SuspendLayout()
        Me.gb_Main.SuspendLayout()
        Me.gb_Text.SuspendLayout()
        Me.gb_Cards.SuspendLayout()
        Me.SuspendLayout()
        '
        'lklb_Update
        '
        Me.lklb_Update.AutoSize = True
        Me.lklb_Update.Location = New System.Drawing.Point(8, 9)
        Me.lklb_Update.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lklb_Update.Name = "lklb_Update"
        Me.lklb_Update.Size = New System.Drawing.Size(145, 16)
        Me.lklb_Update.TabIndex = 6
        Me.lklb_Update.TabStop = True
        Me.lklb_Update.Text = "New Update Available!"
        Me.HoverInfo.SetToolTip(Me.lklb_Update, "New Features! Download the new version")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Options})
        Me.MenuStrip1.Location = New System.Drawing.Point(151, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(82, 28)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmi_Options
        '
        Me.tsmi_Options.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_About, Me.ToolStripMenuItem2})
        Me.tsmi_Options.Name = "tsmi_Options"
        Me.tsmi_Options.Size = New System.Drawing.Size(75, 24)
        Me.tsmi_Options.Text = "Options"
        '
        'tsmi_About
        '
        Me.tsmi_About.Name = "tsmi_About"
        Me.tsmi_About.Size = New System.Drawing.Size(224, 26)
        Me.tsmi_About.Text = "About"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackgroundImage = Global.PKMG5DC.My.Resources.Resources.ppdb
        Me.ToolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem2.Text = "                  Donate"
        Me.ToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pb_Donate
        '
        Me.pb_Donate.BackColor = System.Drawing.SystemColors.Control
        Me.pb_Donate.BackgroundImage = CType(resources.GetObject("pb_Donate.BackgroundImage"), System.Drawing.Image)
        Me.pb_Donate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Donate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_Donate.Location = New System.Drawing.Point(641, 9)
        Me.pb_Donate.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_Donate.Name = "pb_Donate"
        Me.pb_Donate.Size = New System.Drawing.Size(107, 27)
        Me.pb_Donate.TabIndex = 32
        Me.pb_Donate.TabStop = False
        '
        'lklb_Author
        '
        Me.lklb_Author.AutoSize = True
        Me.lklb_Author.Location = New System.Drawing.Point(31, 607)
        Me.lklb_Author.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lklb_Author.Name = "lklb_Author"
        Me.lklb_Author.Size = New System.Drawing.Size(58, 16)
        Me.lklb_Author.TabIndex = 40
        Me.lklb_Author.TabStop = True
        Me.lklb_Author.Text = "Regnum"
        '
        'lb_By
        '
        Me.lb_By.AutoSize = True
        Me.lb_By.Location = New System.Drawing.Point(12, 607)
        Me.lb_By.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_By.Name = "lb_By"
        Me.lb_By.Size = New System.Drawing.Size(22, 16)
        Me.lb_By.TabIndex = 41
        Me.lb_By.Text = "by"
        '
        'bt_Build
        '
        Me.bt_Build.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Build.Location = New System.Drawing.Point(204, 546)
        Me.bt_Build.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_Build.Name = "bt_Build"
        Me.bt_Build.Size = New System.Drawing.Size(171, 57)
        Me.bt_Build.TabIndex = 46
        Me.bt_Build.Text = "Build Event ROM"
        Me.bt_Build.UseVisualStyleBackColor = True
        '
        'bt_PGF
        '
        Me.bt_PGF.Location = New System.Drawing.Point(189, 33)
        Me.bt_PGF.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_PGF.Name = "bt_PGF"
        Me.bt_PGF.Size = New System.Drawing.Size(173, 28)
        Me.bt_PGF.TabIndex = 42
        Me.bt_PGF.Text = "Open .pgf"
        Me.bt_PGF.UseVisualStyleBackColor = True
        '
        'gb_DateLimit
        '
        Me.gb_DateLimit.Controls.Add(Me.bt_ResetDate)
        Me.gb_DateLimit.Controls.Add(Me.cb_MaxLimit)
        Me.gb_DateLimit.Controls.Add(Me.bt_SetDate)
        Me.gb_DateLimit.Controls.Add(Me.lb_End)
        Me.gb_DateLimit.Controls.Add(Me.lb_Start)
        Me.gb_DateLimit.Controls.Add(Me.EndDatePicker)
        Me.gb_DateLimit.Controls.Add(Me.StartDatePicker)
        Me.gb_DateLimit.Location = New System.Drawing.Point(9, 352)
        Me.gb_DateLimit.Margin = New System.Windows.Forms.Padding(4)
        Me.gb_DateLimit.Name = "gb_DateLimit"
        Me.gb_DateLimit.Padding = New System.Windows.Forms.Padding(4)
        Me.gb_DateLimit.Size = New System.Drawing.Size(355, 139)
        Me.gb_DateLimit.TabIndex = 35
        Me.gb_DateLimit.TabStop = False
        Me.gb_DateLimit.Text = "Date Limit"
        '
        'bt_ResetDate
        '
        Me.bt_ResetDate.Location = New System.Drawing.Point(181, 92)
        Me.bt_ResetDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_ResetDate.Name = "bt_ResetDate"
        Me.bt_ResetDate.Size = New System.Drawing.Size(73, 41)
        Me.bt_ResetDate.TabIndex = 49
        Me.bt_ResetDate.Text = "Reset"
        Me.bt_ResetDate.UseVisualStyleBackColor = True
        '
        'cb_MaxLimit
        '
        Me.cb_MaxLimit.AutoSize = True
        Me.cb_MaxLimit.Location = New System.Drawing.Point(127, 65)
        Me.cb_MaxLimit.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_MaxLimit.Name = "cb_MaxLimit"
        Me.cb_MaxLimit.Size = New System.Drawing.Size(114, 20)
        Me.cb_MaxLimit.TabIndex = 4
        Me.cb_MaxLimit.Text = "Auto Max Limit"
        Me.cb_MaxLimit.UseVisualStyleBackColor = True
        '
        'bt_SetDate
        '
        Me.bt_SetDate.Location = New System.Drawing.Point(100, 91)
        Me.bt_SetDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_SetDate.Name = "bt_SetDate"
        Me.bt_SetDate.Size = New System.Drawing.Size(73, 41)
        Me.bt_SetDate.TabIndex = 48
        Me.bt_SetDate.Text = "Set"
        Me.bt_SetDate.UseVisualStyleBackColor = True
        '
        'lb_End
        '
        Me.lb_End.AutoSize = True
        Me.lb_End.Location = New System.Drawing.Point(188, 18)
        Me.lb_End.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_End.Name = "lb_End"
        Me.lb_End.Size = New System.Drawing.Size(34, 16)
        Me.lb_End.TabIndex = 3
        Me.lb_End.Text = "End:"
        '
        'lb_Start
        '
        Me.lb_Start.AutoSize = True
        Me.lb_Start.Location = New System.Drawing.Point(32, 18)
        Me.lb_Start.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_Start.Name = "lb_Start"
        Me.lb_Start.Size = New System.Drawing.Size(37, 16)
        Me.lb_Start.TabIndex = 2
        Me.lb_Start.Text = "Start:"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(188, 34)
        Me.EndDatePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(135, 22)
        Me.EndDatePicker.TabIndex = 1
        Me.EndDatePicker.Value = New Date(2018, 10, 5, 0, 0, 0, 0)
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(32, 34)
        Me.StartDatePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(135, 22)
        Me.StartDatePicker.TabIndex = 0
        Me.StartDatePicker.Value = New Date(2018, 10, 5, 0, 0, 0, 0)
        '
        'rtb_EventMsg
        '
        Me.rtb_EventMsg.Location = New System.Drawing.Point(7, 95)
        Me.rtb_EventMsg.Margin = New System.Windows.Forms.Padding(4)
        Me.rtb_EventMsg.MaxLength = 252
        Me.rtb_EventMsg.Name = "rtb_EventMsg"
        Me.rtb_EventMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb_EventMsg.Size = New System.Drawing.Size(337, 122)
        Me.rtb_EventMsg.TabIndex = 36
        Me.rtb_EventMsg.Text = resources.GetString("rtb_EventMsg.Text")
        Me.rtb_EventMsg.WordWrap = False
        '
        'gb_Region
        '
        Me.gb_Region.Controls.Add(Me.bt_ResetRegion)
        Me.gb_Region.Controls.Add(Me.cb_Region)
        Me.gb_Region.Controls.Add(Me.bt_SetRegion)
        Me.gb_Region.Location = New System.Drawing.Point(8, 130)
        Me.gb_Region.Margin = New System.Windows.Forms.Padding(4)
        Me.gb_Region.Name = "gb_Region"
        Me.gb_Region.Padding = New System.Windows.Forms.Padding(4)
        Me.gb_Region.Size = New System.Drawing.Size(355, 102)
        Me.gb_Region.TabIndex = 34
        Me.gb_Region.TabStop = False
        Me.gb_Region.Text = "Region"
        '
        'bt_ResetRegion
        '
        Me.bt_ResetRegion.Location = New System.Drawing.Point(181, 49)
        Me.bt_ResetRegion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_ResetRegion.Name = "bt_ResetRegion"
        Me.bt_ResetRegion.Size = New System.Drawing.Size(73, 41)
        Me.bt_ResetRegion.TabIndex = 49
        Me.bt_ResetRegion.Text = "Reset"
        Me.bt_ResetRegion.UseVisualStyleBackColor = True
        '
        'cb_Region
        '
        Me.cb_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Region.FormattingEnabled = True
        Me.cb_Region.Items.AddRange(New Object() {"English (US/UK/AU)", "Français (France/Québec)", "Italiano (Italy)", "Deutsch (Germany)", "Español (Spain/Latin Americas)", "日本語 (Japan)", "한국어 (South Korea)"})
        Me.cb_Region.Location = New System.Drawing.Point(8, 17)
        Me.cb_Region.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_Region.Name = "cb_Region"
        Me.cb_Region.Size = New System.Drawing.Size(337, 24)
        Me.cb_Region.TabIndex = 35
        '
        'bt_SetRegion
        '
        Me.bt_SetRegion.Location = New System.Drawing.Point(100, 48)
        Me.bt_SetRegion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_SetRegion.Name = "bt_SetRegion"
        Me.bt_SetRegion.Size = New System.Drawing.Size(73, 41)
        Me.bt_SetRegion.TabIndex = 48
        Me.bt_SetRegion.Text = "Set"
        Me.bt_SetRegion.UseVisualStyleBackColor = True
        '
        'bt_Custom
        '
        Me.bt_Custom.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, CType(0, Byte))
        Me.bt_Custom.Location = New System.Drawing.Point(8, 33)
        Me.bt_Custom.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_Custom.Name = "bt_Custom"
        Me.bt_Custom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_Custom.Size = New System.Drawing.Size(173, 28)
        Me.bt_Custom.TabIndex = 44
        Me.bt_Custom.Text = "Custom"
        Me.bt_Custom.UseVisualStyleBackColor = True
        '
        'gb_GameComp
        '
        Me.gb_GameComp.Controls.Add(Me.bt_ResetCompatibility)
        Me.gb_GameComp.Controls.Add(Me.cb_White2)
        Me.gb_GameComp.Controls.Add(Me.cb_Black2)
        Me.gb_GameComp.Controls.Add(Me.bt_SetCompatibility)
        Me.gb_GameComp.Controls.Add(Me.cb_White)
        Me.gb_GameComp.Controls.Add(Me.cb_Black)
        Me.gb_GameComp.Location = New System.Drawing.Point(9, 240)
        Me.gb_GameComp.Margin = New System.Windows.Forms.Padding(4)
        Me.gb_GameComp.Name = "gb_GameComp"
        Me.gb_GameComp.Padding = New System.Windows.Forms.Padding(4)
        Me.gb_GameComp.Size = New System.Drawing.Size(355, 105)
        Me.gb_GameComp.TabIndex = 33
        Me.gb_GameComp.TabStop = False
        Me.gb_GameComp.Text = "Game Compatibility"
        '
        'bt_ResetCompatibility
        '
        Me.bt_ResetCompatibility.Location = New System.Drawing.Point(181, 50)
        Me.bt_ResetCompatibility.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_ResetCompatibility.Name = "bt_ResetCompatibility"
        Me.bt_ResetCompatibility.Size = New System.Drawing.Size(73, 41)
        Me.bt_ResetCompatibility.TabIndex = 49
        Me.bt_ResetCompatibility.Text = "Reset"
        Me.bt_ResetCompatibility.UseVisualStyleBackColor = True
        '
        'cb_White2
        '
        Me.cb_White2.AutoSize = True
        Me.cb_White2.Location = New System.Drawing.Point(249, 22)
        Me.cb_White2.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_White2.Name = "cb_White2"
        Me.cb_White2.Size = New System.Drawing.Size(73, 20)
        Me.cb_White2.TabIndex = 3
        Me.cb_White2.Text = "White 2"
        Me.cb_White2.UseVisualStyleBackColor = True
        '
        'cb_Black2
        '
        Me.cb_Black2.AutoSize = True
        Me.cb_Black2.Location = New System.Drawing.Point(168, 22)
        Me.cb_Black2.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_Black2.Name = "cb_Black2"
        Me.cb_Black2.Size = New System.Drawing.Size(73, 20)
        Me.cb_Black2.TabIndex = 2
        Me.cb_Black2.Text = "Black 2"
        Me.cb_Black2.UseVisualStyleBackColor = True
        '
        'bt_SetCompatibility
        '
        Me.bt_SetCompatibility.Location = New System.Drawing.Point(100, 49)
        Me.bt_SetCompatibility.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_SetCompatibility.Name = "bt_SetCompatibility"
        Me.bt_SetCompatibility.Size = New System.Drawing.Size(73, 41)
        Me.bt_SetCompatibility.TabIndex = 48
        Me.bt_SetCompatibility.Text = "Set"
        Me.bt_SetCompatibility.UseVisualStyleBackColor = True
        '
        'cb_White
        '
        Me.cb_White.AutoSize = True
        Me.cb_White.Location = New System.Drawing.Point(97, 22)
        Me.cb_White.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_White.Name = "cb_White"
        Me.cb_White.Size = New System.Drawing.Size(63, 20)
        Me.cb_White.TabIndex = 1
        Me.cb_White.Text = "White"
        Me.cb_White.UseVisualStyleBackColor = True
        '
        'cb_Black
        '
        Me.cb_Black.AutoSize = True
        Me.cb_Black.Location = New System.Drawing.Point(16, 22)
        Me.cb_Black.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_Black.Name = "cb_Black"
        Me.cb_Black.Size = New System.Drawing.Size(63, 20)
        Me.cb_Black.TabIndex = 0
        Me.cb_Black.Text = "Black"
        Me.cb_Black.UseVisualStyleBackColor = True
        '
        'lb_EventMsg
        '
        Me.lb_EventMsg.AutoSize = True
        Me.lb_EventMsg.Location = New System.Drawing.Point(7, 79)
        Me.lb_EventMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_EventMsg.Name = "lb_EventMsg"
        Me.lb_EventMsg.Size = New System.Drawing.Size(104, 16)
        Me.lb_EventMsg.TabIndex = 37
        Me.lb_EventMsg.Text = "Event Message:"
        '
        'rtb_EventTitle
        '
        Me.rtb_EventTitle.BackColor = System.Drawing.Color.White
        Me.rtb_EventTitle.Location = New System.Drawing.Point(7, 37)
        Me.rtb_EventTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.rtb_EventTitle.MaxLength = 24
        Me.rtb_EventTitle.Name = "rtb_EventTitle"
        Me.rtb_EventTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb_EventTitle.Size = New System.Drawing.Size(337, 34)
        Me.rtb_EventTitle.TabIndex = 45
        Me.rtb_EventTitle.Text = "Input Event Title Here."
        Me.rtb_EventTitle.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Event Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-195, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Event File Name"
        '
        'cb_Cards
        '
        Me.cb_Cards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Cards.FormattingEnabled = True
        Me.cb_Cards.Location = New System.Drawing.Point(7, 22)
        Me.cb_Cards.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_Cards.MaxDropDownItems = 6
        Me.cb_Cards.MaxLength = 12
        Me.cb_Cards.Name = "cb_Cards"
        Me.cb_Cards.Size = New System.Drawing.Size(337, 24)
        Me.cb_Cards.TabIndex = 36
        '
        'gb_Main
        '
        Me.gb_Main.Controls.Add(Me.gb_Text)
        Me.gb_Main.Controls.Add(Me.gb_Cards)
        Me.gb_Main.Controls.Add(Me.Label3)
        Me.gb_Main.Controls.Add(Me.bt_PGF)
        Me.gb_Main.Controls.Add(Me.gb_DateLimit)
        Me.gb_Main.Controls.Add(Me.gb_Region)
        Me.gb_Main.Controls.Add(Me.gb_GameComp)
        Me.gb_Main.Controls.Add(Me.bt_Custom)
        Me.gb_Main.Location = New System.Drawing.Point(11, 38)
        Me.gb_Main.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_Main.Name = "gb_Main"
        Me.gb_Main.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_Main.Size = New System.Drawing.Size(737, 502)
        Me.gb_Main.TabIndex = 47
        Me.gb_Main.TabStop = False
        Me.gb_Main.Text = "Distribution ROM"
        '
        'gb_Text
        '
        Me.gb_Text.Controls.Add(Me.lb_CharCountNumber)
        Me.gb_Text.Controls.Add(Me.lb_CharCount)
        Me.gb_Text.Controls.Add(Me.rtb_EventMsg)
        Me.gb_Text.Controls.Add(Me.lb_EventMsg)
        Me.gb_Text.Controls.Add(Me.bt_ResetEventMsg)
        Me.gb_Text.Controls.Add(Me.rtb_EventTitle)
        Me.gb_Text.Controls.Add(Me.bt_SetEventMsg)
        Me.gb_Text.Controls.Add(Me.Label1)
        Me.gb_Text.Location = New System.Drawing.Point(371, 68)
        Me.gb_Text.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_Text.Name = "gb_Text"
        Me.gb_Text.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_Text.Size = New System.Drawing.Size(355, 277)
        Me.gb_Text.TabIndex = 51
        Me.gb_Text.TabStop = False
        Me.gb_Text.Text = "Event"
        '
        'lb_CharCountNumber
        '
        Me.lb_CharCountNumber.AutoSize = True
        Me.lb_CharCountNumber.Location = New System.Drawing.Point(316, 79)
        Me.lb_CharCountNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_CharCountNumber.Name = "lb_CharCountNumber"
        Me.lb_CharCountNumber.Size = New System.Drawing.Size(14, 16)
        Me.lb_CharCountNumber.TabIndex = 51
        Me.lb_CharCountNumber.Text = "0"
        Me.lb_CharCountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_CharCount
        '
        Me.lb_CharCount.AutoSize = True
        Me.lb_CharCount.Location = New System.Drawing.Point(240, 79)
        Me.lb_CharCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_CharCount.Name = "lb_CharCount"
        Me.lb_CharCount.Size = New System.Drawing.Size(73, 16)
        Me.lb_CharCount.TabIndex = 50
        Me.lb_CharCount.Text = "Char count:"
        '
        'bt_ResetEventMsg
        '
        Me.bt_ResetEventMsg.Location = New System.Drawing.Point(176, 224)
        Me.bt_ResetEventMsg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_ResetEventMsg.Name = "bt_ResetEventMsg"
        Me.bt_ResetEventMsg.Size = New System.Drawing.Size(73, 41)
        Me.bt_ResetEventMsg.TabIndex = 49
        Me.bt_ResetEventMsg.Text = "Reset"
        Me.bt_ResetEventMsg.UseVisualStyleBackColor = True
        '
        'bt_SetEventMsg
        '
        Me.bt_SetEventMsg.Location = New System.Drawing.Point(97, 224)
        Me.bt_SetEventMsg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bt_SetEventMsg.Name = "bt_SetEventMsg"
        Me.bt_SetEventMsg.Size = New System.Drawing.Size(73, 41)
        Me.bt_SetEventMsg.TabIndex = 48
        Me.bt_SetEventMsg.Text = "Set"
        Me.bt_SetEventMsg.UseVisualStyleBackColor = True
        '
        'gb_Cards
        '
        Me.gb_Cards.Controls.Add(Me.cb_Cards)
        Me.gb_Cards.Location = New System.Drawing.Point(8, 68)
        Me.gb_Cards.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_Cards.Name = "gb_Cards"
        Me.gb_Cards.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_Cards.Size = New System.Drawing.Size(355, 55)
        Me.gb_Cards.TabIndex = 50
        Me.gb_Cards.TabStop = False
        Me.gb_Cards.Text = "Cards Selected"
        '
        'bt_ClearForm
        '
        Me.bt_ClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ClearForm.Location = New System.Drawing.Point(382, 546)
        Me.bt_ClearForm.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_ClearForm.Name = "bt_ClearForm"
        Me.bt_ClearForm.Size = New System.Drawing.Size(171, 57)
        Me.bt_ClearForm.TabIndex = 48
        Me.bt_ClearForm.Text = "Clear Form"
        Me.bt_ClearForm.UseVisualStyleBackColor = True
        '
        'Main5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 634)
        Me.Controls.Add(Me.bt_ClearForm)
        Me.Controls.Add(Me.gb_Main)
        Me.Controls.Add(Me.bt_Build)
        Me.Controls.Add(Me.lklb_Author)
        Me.Controls.Add(Me.lklb_Update)
        Me.Controls.Add(Me.lb_By)
        Me.Controls.Add(Me.pb_Donate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PKMG5DC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pb_Donate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_DateLimit.ResumeLayout(False)
        Me.gb_DateLimit.PerformLayout()
        Me.gb_Region.ResumeLayout(False)
        Me.gb_GameComp.ResumeLayout(False)
        Me.gb_GameComp.PerformLayout()
        Me.gb_Main.ResumeLayout(False)
        Me.gb_Main.PerformLayout()
        Me.gb_Text.ResumeLayout(False)
        Me.gb_Text.PerformLayout()
        Me.gb_Cards.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lklb_Update As LinkLabel
    Friend WithEvents HoverInfo As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents pb_Donate As PictureBox
    Friend WithEvents lklb_Author As LinkLabel
    Friend WithEvents lb_By As Label
    Friend WithEvents bt_Build As Button
    Friend WithEvents cb_Cards As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtb_EventTitle As RichTextBox
    Friend WithEvents lb_EventMsg As Label
    Friend WithEvents gb_GameComp As GroupBox
    Friend WithEvents cb_White2 As CheckBox
    Friend WithEvents cb_Black2 As CheckBox
    Friend WithEvents cb_White As CheckBox
    Friend WithEvents cb_Black As CheckBox
    Friend WithEvents bt_Custom As Button
    Friend WithEvents gb_Region As GroupBox
    Friend WithEvents cb_Region As ComboBox
    Friend WithEvents rtb_EventMsg As RichTextBox
    Friend WithEvents gb_DateLimit As GroupBox
    Friend WithEvents cb_MaxLimit As CheckBox
    Friend WithEvents lb_End As Label
    Friend WithEvents lb_Start As Label
    Friend WithEvents EndDatePicker As DateTimePicker
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents bt_PGF As Button
    Friend WithEvents gb_Main As GroupBox
    Friend WithEvents bt_SetEventMsg As Button
    Friend WithEvents bt_ResetEventMsg As Button
    Friend WithEvents bt_ResetDate As Button
    Friend WithEvents bt_SetDate As Button
    Friend WithEvents gb_Cards As GroupBox
    Friend WithEvents gb_Text As GroupBox
    Friend WithEvents bt_ResetCompatibility As Button
    Friend WithEvents bt_SetCompatibility As Button
    Friend WithEvents bt_ResetRegion As Button
    Friend WithEvents bt_SetRegion As Button
    Friend WithEvents lb_CharCountNumber As Label
    Friend WithEvents lb_CharCount As Label
    Friend WithEvents tsmi_Options As ToolStripMenuItem
    Friend WithEvents tsmi_About As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents bt_ClearForm As Button
End Class
