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
        Me.tscb_Region = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmi_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoverInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.pb_Donate = New System.Windows.Forms.PictureBox()
        Me.gb_GameComp = New System.Windows.Forms.GroupBox()
        Me.cb_White2 = New System.Windows.Forms.CheckBox()
        Me.cb_Black2 = New System.Windows.Forms.CheckBox()
        Me.cb_White = New System.Windows.Forms.CheckBox()
        Me.cb_Black = New System.Windows.Forms.CheckBox()
        Me.gb_Region = New System.Windows.Forms.GroupBox()
        Me.cb_Region = New System.Windows.Forms.ComboBox()
        Me.gb_DateLimit = New System.Windows.Forms.GroupBox()
        Me.cb_MaxLimit = New System.Windows.Forms.CheckBox()
        Me.lb_End = New System.Windows.Forms.Label()
        Me.lb_Start = New System.Windows.Forms.Label()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.lb_EventMsg = New System.Windows.Forms.Label()
        Me.rtb_EventMsg = New System.Windows.Forms.RichTextBox()
        Me.lklb_Author = New System.Windows.Forms.LinkLabel()
        Me.lb_By = New System.Windows.Forms.Label()
        Me.bt_Custom = New System.Windows.Forms.Button()
        Me.lb_PGF = New System.Windows.Forms.Label()
        Me.bt_PGF = New System.Windows.Forms.Button()
        Me.tc_Cards = New System.Windows.Forms.TabControl()
        Me.tp_Add = New System.Windows.Forms.TabPage()
        Me.pnl_EditCard = New System.Windows.Forms.Panel()
        Me.bt_Build = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pb_Donate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_GameComp.SuspendLayout()
        Me.gb_Region.SuspendLayout()
        Me.gb_DateLimit.SuspendLayout()
        Me.tc_Cards.SuspendLayout()
        Me.tp_Add.SuspendLayout()
        Me.pnl_EditCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lklb_Update
        '
        Me.lklb_Update.AutoSize = True
        Me.lklb_Update.Location = New System.Drawing.Point(2, 6)
        Me.lklb_Update.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lklb_Update.Name = "lklb_Update"
        Me.lklb_Update.Size = New System.Drawing.Size(168, 20)
        Me.lklb_Update.TabIndex = 6
        Me.lklb_Update.TabStop = True
        Me.lklb_Update.Text = "New Update Available!"
        Me.HoverInfo.SetToolTip(Me.lklb_Update, "New Features! Download the new version")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Options})
        Me.MenuStrip1.Location = New System.Drawing.Point(170, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(103, 35)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmi_Options
        '
        Me.tsmi_Options.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscb_Region, Me.ToolStripSeparator1, Me.tsmi_About, Me.ToolStripMenuItem2})
        Me.tsmi_Options.Name = "tsmi_Options"
        Me.tsmi_Options.Size = New System.Drawing.Size(92, 29)
        Me.tsmi_Options.Text = "Options"
        '
        'tscb_Region
        '
        Me.tscb_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscb_Region.DropDownWidth = 170
        Me.tscb_Region.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tscb_Region.Items.AddRange(New Object() {"English (US/UK/AU)", "Français (France/Québec)", "Italiano (Italy)", "Deutsch (Germany)", "Español (Spain/Latin Americas)", "日本語 (Japan)", "한국어 (South Korea)"})
        Me.tscb_Region.Name = "tscb_Region"
        Me.tscb_Region.Size = New System.Drawing.Size(130, 33)
        Me.tscb_Region.ToolTipText = "Default Region"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(259, 6)
        '
        'tsmi_About
        '
        Me.tsmi_About.Name = "tsmi_About"
        Me.tsmi_About.Size = New System.Drawing.Size(262, 34)
        Me.tsmi_About.Text = "About"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackgroundImage = Global.PKMG5DC.My.Resources.Resources.ppdb
        Me.ToolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(262, 34)
        Me.ToolStripMenuItem2.Text = "                  Donate"
        Me.ToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pb_Donate
        '
        Me.pb_Donate.BackColor = System.Drawing.SystemColors.Control
        Me.pb_Donate.BackgroundImage = CType(resources.GetObject("pb_Donate.BackgroundImage"), System.Drawing.Image)
        Me.pb_Donate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Donate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_Donate.Location = New System.Drawing.Point(327, 5)
        Me.pb_Donate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pb_Donate.Name = "pb_Donate"
        Me.pb_Donate.Size = New System.Drawing.Size(120, 34)
        Me.pb_Donate.TabIndex = 32
        Me.pb_Donate.TabStop = False
        '
        'gb_GameComp
        '
        Me.gb_GameComp.Controls.Add(Me.cb_White2)
        Me.gb_GameComp.Controls.Add(Me.cb_Black2)
        Me.gb_GameComp.Controls.Add(Me.cb_White)
        Me.gb_GameComp.Controls.Add(Me.cb_Black)
        Me.gb_GameComp.Location = New System.Drawing.Point(9, 103)
        Me.gb_GameComp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_GameComp.Name = "gb_GameComp"
        Me.gb_GameComp.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_GameComp.Size = New System.Drawing.Size(213, 102)
        Me.gb_GameComp.TabIndex = 33
        Me.gb_GameComp.TabStop = False
        Me.gb_GameComp.Text = "Game Compatibility"
        '
        'cb_White2
        '
        Me.cb_White2.AutoSize = True
        Me.cb_White2.Location = New System.Drawing.Point(110, 63)
        Me.cb_White2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_White2.Name = "cb_White2"
        Me.cb_White2.Size = New System.Drawing.Size(89, 24)
        Me.cb_White2.TabIndex = 3
        Me.cb_White2.Text = "White 2"
        Me.cb_White2.UseVisualStyleBackColor = True
        '
        'cb_Black2
        '
        Me.cb_Black2.AutoSize = True
        Me.cb_Black2.Location = New System.Drawing.Point(18, 63)
        Me.cb_Black2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_Black2.Name = "cb_Black2"
        Me.cb_Black2.Size = New System.Drawing.Size(87, 24)
        Me.cb_Black2.TabIndex = 2
        Me.cb_Black2.Text = "Black 2"
        Me.cb_Black2.UseVisualStyleBackColor = True
        '
        'cb_White
        '
        Me.cb_White.AutoSize = True
        Me.cb_White.Location = New System.Drawing.Point(110, 28)
        Me.cb_White.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_White.Name = "cb_White"
        Me.cb_White.Size = New System.Drawing.Size(76, 24)
        Me.cb_White.TabIndex = 1
        Me.cb_White.Text = "White"
        Me.cb_White.UseVisualStyleBackColor = True
        '
        'cb_Black
        '
        Me.cb_Black.AutoSize = True
        Me.cb_Black.Location = New System.Drawing.Point(18, 28)
        Me.cb_Black.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_Black.Name = "cb_Black"
        Me.cb_Black.Size = New System.Drawing.Size(74, 24)
        Me.cb_Black.TabIndex = 0
        Me.cb_Black.Text = "Black"
        Me.cb_Black.UseVisualStyleBackColor = True
        '
        'gb_Region
        '
        Me.gb_Region.Controls.Add(Me.cb_Region)
        Me.gb_Region.Location = New System.Drawing.Point(9, 214)
        Me.gb_Region.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_Region.Name = "gb_Region"
        Me.gb_Region.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_Region.Size = New System.Drawing.Size(213, 63)
        Me.gb_Region.TabIndex = 34
        Me.gb_Region.TabStop = False
        Me.gb_Region.Text = "Region"
        '
        'cb_Region
        '
        Me.cb_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Region.FormattingEnabled = True
        Me.cb_Region.Items.AddRange(New Object() {"English (US/UK/AU)", "Français (France/Québec)", "Italiano (Italy)", "Deutsch (Germany)", "Español (Spain/Latin Americas)", "日本語 (Japan)", "한국어 (South Korea)"})
        Me.cb_Region.Location = New System.Drawing.Point(9, 22)
        Me.cb_Region.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_Region.Name = "cb_Region"
        Me.cb_Region.Size = New System.Drawing.Size(193, 28)
        Me.cb_Region.TabIndex = 35
        '
        'gb_DateLimit
        '
        Me.gb_DateLimit.Controls.Add(Me.cb_MaxLimit)
        Me.gb_DateLimit.Controls.Add(Me.lb_End)
        Me.gb_DateLimit.Controls.Add(Me.lb_Start)
        Me.gb_DateLimit.Controls.Add(Me.EndDatePicker)
        Me.gb_DateLimit.Controls.Add(Me.StartDatePicker)
        Me.gb_DateLimit.Location = New System.Drawing.Point(232, 103)
        Me.gb_DateLimit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_DateLimit.Name = "gb_DateLimit"
        Me.gb_DateLimit.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_DateLimit.Size = New System.Drawing.Size(176, 174)
        Me.gb_DateLimit.TabIndex = 35
        Me.gb_DateLimit.TabStop = False
        Me.gb_DateLimit.Text = "Date Limit"
        '
        'cb_MaxLimit
        '
        Me.cb_MaxLimit.AutoSize = True
        Me.cb_MaxLimit.Location = New System.Drawing.Point(18, 137)
        Me.cb_MaxLimit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_MaxLimit.Name = "cb_MaxLimit"
        Me.cb_MaxLimit.Size = New System.Drawing.Size(139, 24)
        Me.cb_MaxLimit.TabIndex = 4
        Me.cb_MaxLimit.Text = "Auto Max Limit"
        Me.cb_MaxLimit.UseVisualStyleBackColor = True
        '
        'lb_End
        '
        Me.lb_End.AutoSize = True
        Me.lb_End.Location = New System.Drawing.Point(12, 78)
        Me.lb_End.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_End.Name = "lb_End"
        Me.lb_End.Size = New System.Drawing.Size(42, 20)
        Me.lb_End.TabIndex = 3
        Me.lb_End.Text = "End:"
        '
        'lb_Start
        '
        Me.lb_Start.AutoSize = True
        Me.lb_Start.Location = New System.Drawing.Point(12, 25)
        Me.lb_Start.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_Start.Name = "lb_Start"
        Me.lb_Start.Size = New System.Drawing.Size(48, 20)
        Me.lb_Start.TabIndex = 2
        Me.lb_Start.Text = "Start:"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(12, 98)
        Me.EndDatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(151, 26)
        Me.EndDatePicker.TabIndex = 1
        Me.EndDatePicker.Value = New Date(2018, 10, 5, 0, 0, 0, 0)
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(12, 45)
        Me.StartDatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(151, 26)
        Me.StartDatePicker.TabIndex = 0
        Me.StartDatePicker.Value = New Date(2018, 10, 5, 0, 0, 0, 0)
        '
        'lb_EventMsg
        '
        Me.lb_EventMsg.AutoSize = True
        Me.lb_EventMsg.Location = New System.Drawing.Point(45, 282)
        Me.lb_EventMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_EventMsg.Name = "lb_EventMsg"
        Me.lb_EventMsg.Size = New System.Drawing.Size(123, 20)
        Me.lb_EventMsg.TabIndex = 37
        Me.lb_EventMsg.Text = "Event Message:"
        '
        'rtb_EventMsg
        '
        Me.rtb_EventMsg.Location = New System.Drawing.Point(45, 302)
        Me.rtb_EventMsg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rtb_EventMsg.MaxLength = 252
        Me.rtb_EventMsg.Name = "rtb_EventMsg"
        Me.rtb_EventMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb_EventMsg.Size = New System.Drawing.Size(332, 147)
        Me.rtb_EventMsg.TabIndex = 36
        Me.rtb_EventMsg.Text = ""
        Me.rtb_EventMsg.WordWrap = False
        '
        'lklb_Author
        '
        Me.lklb_Author.AutoSize = True
        Me.lklb_Author.Location = New System.Drawing.Point(22, 668)
        Me.lklb_Author.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lklb_Author.Name = "lklb_Author"
        Me.lklb_Author.Size = New System.Drawing.Size(130, 20)
        Me.lklb_Author.TabIndex = 40
        Me.lklb_Author.TabStop = True
        Me.lklb_Author.Text = "RenegadeRaven"
        '
        'lb_By
        '
        Me.lb_By.AutoSize = True
        Me.lb_By.Location = New System.Drawing.Point(2, 668)
        Me.lb_By.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_By.Name = "lb_By"
        Me.lb_By.Size = New System.Drawing.Size(25, 20)
        Me.lb_By.TabIndex = 41
        Me.lb_By.Text = "by"
        '
        'bt_Custom
        '
        Me.bt_Custom.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, CType(0, Byte))
        Me.bt_Custom.Location = New System.Drawing.Point(9, 9)
        Me.bt_Custom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_Custom.Name = "bt_Custom"
        Me.bt_Custom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_Custom.Size = New System.Drawing.Size(195, 35)
        Me.bt_Custom.TabIndex = 44
        Me.bt_Custom.Text = "Custom"
        Me.bt_Custom.UseVisualStyleBackColor = True
        '
        'lb_PGF
        '
        Me.lb_PGF.AutoEllipsis = True
        Me.lb_PGF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_PGF.Location = New System.Drawing.Point(9, 58)
        Me.lb_PGF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 0)
        Me.lb_PGF.Name = "lb_PGF"
        Me.lb_PGF.Size = New System.Drawing.Size(399, 26)
        Me.lb_PGF.TabIndex = 43
        Me.lb_PGF.Text = "▲▲▲ Open .pgf"
        Me.lb_PGF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bt_PGF
        '
        Me.bt_PGF.Location = New System.Drawing.Point(213, 9)
        Me.bt_PGF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_PGF.Name = "bt_PGF"
        Me.bt_PGF.Size = New System.Drawing.Size(195, 35)
        Me.bt_PGF.TabIndex = 42
        Me.bt_PGF.Text = "Open .pgf"
        Me.bt_PGF.UseVisualStyleBackColor = True
        '
        'tc_Cards
        '
        Me.tc_Cards.Controls.Add(Me.tp_Add)
        Me.tc_Cards.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tc_Cards.ItemSize = New System.Drawing.Size(21, 18)
        Me.tc_Cards.Location = New System.Drawing.Point(12, 42)
        Me.tc_Cards.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tc_Cards.Name = "tc_Cards"
        Me.tc_Cards.Padding = New System.Drawing.Point(2, 3)
        Me.tc_Cards.SelectedIndex = 0
        Me.tc_Cards.Size = New System.Drawing.Size(429, 525)
        Me.tc_Cards.TabIndex = 45
        '
        'tp_Add
        '
        Me.tp_Add.Controls.Add(Me.pnl_EditCard)
        Me.tp_Add.Location = New System.Drawing.Point(4, 22)
        Me.tp_Add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tp_Add.Name = "tp_Add"
        Me.tp_Add.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tp_Add.Size = New System.Drawing.Size(421, 499)
        Me.tp_Add.TabIndex = 1
        Me.tp_Add.Text = "    +"
        Me.tp_Add.UseVisualStyleBackColor = True
        '
        'pnl_EditCard
        '
        Me.pnl_EditCard.Controls.Add(Me.lb_EventMsg)
        Me.pnl_EditCard.Controls.Add(Me.gb_GameComp)
        Me.pnl_EditCard.Controls.Add(Me.bt_Custom)
        Me.pnl_EditCard.Controls.Add(Me.gb_Region)
        Me.pnl_EditCard.Controls.Add(Me.rtb_EventMsg)
        Me.pnl_EditCard.Controls.Add(Me.lb_PGF)
        Me.pnl_EditCard.Controls.Add(Me.gb_DateLimit)
        Me.pnl_EditCard.Controls.Add(Me.bt_PGF)
        Me.pnl_EditCard.Location = New System.Drawing.Point(0, 0)
        Me.pnl_EditCard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnl_EditCard.Name = "pnl_EditCard"
        Me.pnl_EditCard.Size = New System.Drawing.Size(417, 485)
        Me.pnl_EditCard.TabIndex = 45
        '
        'bt_Build
        '
        Me.bt_Build.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Build.Location = New System.Drawing.Point(142, 585)
        Me.bt_Build.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_Build.Name = "bt_Build"
        Me.bt_Build.Size = New System.Drawing.Size(192, 71)
        Me.bt_Build.TabIndex = 46
        Me.bt_Build.Text = "Build Event ROM"
        Me.bt_Build.UseVisualStyleBackColor = True
        '
        'Main5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 692)
        Me.Controls.Add(Me.bt_Build)
        Me.Controls.Add(Me.tc_Cards)
        Me.Controls.Add(Me.lklb_Author)
        Me.Controls.Add(Me.lb_By)
        Me.Controls.Add(Me.pb_Donate)
        Me.Controls.Add(Me.lklb_Update)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PKMG5DC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pb_Donate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_GameComp.ResumeLayout(False)
        Me.gb_GameComp.PerformLayout()
        Me.gb_Region.ResumeLayout(False)
        Me.gb_DateLimit.ResumeLayout(False)
        Me.gb_DateLimit.PerformLayout()
        Me.tc_Cards.ResumeLayout(False)
        Me.tp_Add.ResumeLayout(False)
        Me.pnl_EditCard.ResumeLayout(False)
        Me.pnl_EditCard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lklb_Update As LinkLabel
    Friend WithEvents HoverInfo As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmi_Options As ToolStripMenuItem
    Friend WithEvents pb_Donate As PictureBox
    Friend WithEvents gb_GameComp As GroupBox
    Friend WithEvents cb_White2 As CheckBox
    Friend WithEvents cb_Black2 As CheckBox
    Friend WithEvents cb_White As CheckBox
    Friend WithEvents cb_Black As CheckBox
    Friend WithEvents gb_Region As GroupBox
    Friend WithEvents cb_Region As ComboBox
    Friend WithEvents gb_DateLimit As GroupBox
    Friend WithEvents cb_MaxLimit As CheckBox
    Friend WithEvents lb_End As Label
    Friend WithEvents lb_Start As Label
    Friend WithEvents EndDatePicker As DateTimePicker
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents lb_EventMsg As Label
    Friend WithEvents rtb_EventMsg As RichTextBox
    Friend WithEvents lklb_Author As LinkLabel
    Friend WithEvents lb_By As Label
    Friend WithEvents bt_Custom As Button
    Friend WithEvents lb_PGF As Label
    Friend WithEvents bt_PGF As Button
    Friend WithEvents tc_Cards As TabControl
    Friend WithEvents tp_Add As TabPage
    Friend WithEvents pnl_EditCard As Panel
    Friend WithEvents bt_Build As Button
    Friend WithEvents tsmi_About As ToolStripMenuItem
    Friend WithEvents tscb_Region As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
