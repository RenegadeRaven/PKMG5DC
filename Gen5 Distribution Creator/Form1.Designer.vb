<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rtb_Editor = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_PGF = New System.Windows.Forms.Button()
        Me.lb_PGF = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gb_GameComp = New System.Windows.Forms.GroupBox()
        Me.cb_White2 = New System.Windows.Forms.CheckBox()
        Me.cb_Black2 = New System.Windows.Forms.CheckBox()
        Me.cb_White = New System.Windows.Forms.CheckBox()
        Me.cb_Black = New System.Windows.Forms.CheckBox()
        Me.rtb_EventMsg = New System.Windows.Forms.RichTextBox()
        Me.gb_DateLimit = New System.Windows.Forms.GroupBox()
        Me.cb_MaxLimit = New System.Windows.Forms.CheckBox()
        Me.lb_End = New System.Windows.Forms.Label()
        Me.lb_Start = New System.Windows.Forms.Label()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.gb_Region = New System.Windows.Forms.GroupBox()
        Me.rb_Kor = New System.Windows.Forms.RadioButton()
        Me.rb_Jap = New System.Windows.Forms.RadioButton()
        Me.rb_Spa = New System.Windows.Forms.RadioButton()
        Me.rb_Ger = New System.Windows.Forms.RadioButton()
        Me.rb_Ita = New System.Windows.Forms.RadioButton()
        Me.rb_Fr = New System.Windows.Forms.RadioButton()
        Me.rb_Eng = New System.Windows.Forms.RadioButton()
        Me.bt_Build = New System.Windows.Forms.Button()
        Me.lb_EventMsg = New System.Windows.Forms.Label()
        Me.bt_ClearEM = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.bt_Custom = New System.Windows.Forms.Button()
        Me.lklb_Update = New System.Windows.Forms.LinkLabel()
        Me.gb_ROM = New System.Windows.Forms.GroupBox()
        Me.bt_DefaultDes = New System.Windows.Forms.Button()
        Me.bt_ClearDes = New System.Windows.Forms.Button()
        Me.lb_Descript = New System.Windows.Forms.Label()
        Me.rtb_ROMDes = New System.Windows.Forms.RichTextBox()
        Me.lb_Code = New System.Windows.Forms.Label()
        Me.tb_Code = New System.Windows.Forms.TextBox()
        Me.lb_Header = New System.Windows.Forms.Label()
        Me.tb_Header = New System.Windows.Forms.TextBox()
        Me.lb_FileName = New System.Windows.Forms.Label()
        Me.tb_FileName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lklb_Author = New System.Windows.Forms.LinkLabel()
        Me.lb_By = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gb_GameComp.SuspendLayout()
        Me.gb_DateLimit.SuspendLayout()
        Me.gb_Region.SuspendLayout()
        Me.gb_ROM.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtb_Editor
        '
        Me.rtb_Editor.Location = New System.Drawing.Point(455, 26)
        Me.rtb_Editor.Name = "rtb_Editor"
        Me.rtb_Editor.ReadOnly = True
        Me.rtb_Editor.Size = New System.Drawing.Size(357, 412)
        Me.rtb_Editor.TabIndex = 0
        Me.rtb_Editor.Text = ""
        Me.ToolTip1.SetToolTip(Me.rtb_Editor, "The output. See your changes here.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'bt_PGF
        '
        Me.bt_PGF.Location = New System.Drawing.Point(283, 50)
        Me.bt_PGF.Name = "bt_PGF"
        Me.bt_PGF.Size = New System.Drawing.Size(68, 23)
        Me.bt_PGF.TabIndex = 2
        Me.bt_PGF.Text = "Open .pgf"
        Me.bt_PGF.UseVisualStyleBackColor = True
        '
        'lb_PGF
        '
        Me.lb_PGF.AutoEllipsis = True
        Me.lb_PGF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_PGF.Location = New System.Drawing.Point(13, 54)
        Me.lb_PGF.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lb_PGF.Name = "lb_PGF"
        Me.lb_PGF.Size = New System.Drawing.Size(268, 17)
        Me.lb_PGF.TabIndex = 3
        Me.lb_PGF.Text = "Open .pgf ------->"
        Me.lb_PGF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'gb_GameComp
        '
        Me.gb_GameComp.Controls.Add(Me.cb_White2)
        Me.gb_GameComp.Controls.Add(Me.cb_Black2)
        Me.gb_GameComp.Controls.Add(Me.cb_White)
        Me.gb_GameComp.Controls.Add(Me.cb_Black)
        Me.gb_GameComp.Location = New System.Drawing.Point(13, 81)
        Me.gb_GameComp.Name = "gb_GameComp"
        Me.gb_GameComp.Size = New System.Drawing.Size(175, 97)
        Me.gb_GameComp.TabIndex = 4
        Me.gb_GameComp.TabStop = False
        Me.gb_GameComp.Text = "Game Compatibility"
        '
        'cb_White2
        '
        Me.cb_White2.AutoSize = True
        Me.cb_White2.Location = New System.Drawing.Point(98, 59)
        Me.cb_White2.Name = "cb_White2"
        Me.cb_White2.Size = New System.Drawing.Size(63, 17)
        Me.cb_White2.TabIndex = 3
        Me.cb_White2.Text = "White 2"
        Me.cb_White2.UseVisualStyleBackColor = True
        '
        'cb_Black2
        '
        Me.cb_Black2.AutoSize = True
        Me.cb_Black2.Location = New System.Drawing.Point(21, 59)
        Me.cb_Black2.Name = "cb_Black2"
        Me.cb_Black2.Size = New System.Drawing.Size(62, 17)
        Me.cb_Black2.TabIndex = 2
        Me.cb_Black2.Text = "Black 2"
        Me.cb_Black2.UseVisualStyleBackColor = True
        '
        'cb_White
        '
        Me.cb_White.AutoSize = True
        Me.cb_White.Location = New System.Drawing.Point(98, 28)
        Me.cb_White.Name = "cb_White"
        Me.cb_White.Size = New System.Drawing.Size(54, 17)
        Me.cb_White.TabIndex = 1
        Me.cb_White.Text = "White"
        Me.cb_White.UseVisualStyleBackColor = True
        '
        'cb_Black
        '
        Me.cb_Black.AutoSize = True
        Me.cb_Black.Location = New System.Drawing.Point(21, 28)
        Me.cb_Black.Name = "cb_Black"
        Me.cb_Black.Size = New System.Drawing.Size(53, 17)
        Me.cb_Black.TabIndex = 0
        Me.cb_Black.Text = "Black"
        Me.cb_Black.UseVisualStyleBackColor = True
        '
        'rtb_EventMsg
        '
        Me.rtb_EventMsg.Location = New System.Drawing.Point(197, 231)
        Me.rtb_EventMsg.MaxLength = 252
        Me.rtb_EventMsg.Name = "rtb_EventMsg"
        Me.rtb_EventMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb_EventMsg.Size = New System.Drawing.Size(223, 97)
        Me.rtb_EventMsg.TabIndex = 5
        Me.rtb_EventMsg.Text = ""
        Me.rtb_EventMsg.WordWrap = False
        '
        'gb_DateLimit
        '
        Me.gb_DateLimit.Controls.Add(Me.cb_MaxLimit)
        Me.gb_DateLimit.Controls.Add(Me.lb_End)
        Me.gb_DateLimit.Controls.Add(Me.lb_Start)
        Me.gb_DateLimit.Controls.Add(Me.EndDatePicker)
        Me.gb_DateLimit.Controls.Add(Me.StartDatePicker)
        Me.gb_DateLimit.Location = New System.Drawing.Point(195, 81)
        Me.gb_DateLimit.Name = "gb_DateLimit"
        Me.gb_DateLimit.Size = New System.Drawing.Size(225, 97)
        Me.gb_DateLimit.TabIndex = 6
        Me.gb_DateLimit.TabStop = False
        Me.gb_DateLimit.Text = "Date Limit"
        '
        'cb_MaxLimit
        '
        Me.cb_MaxLimit.AutoSize = True
        Me.cb_MaxLimit.Location = New System.Drawing.Point(123, 11)
        Me.cb_MaxLimit.Name = "cb_MaxLimit"
        Me.cb_MaxLimit.Size = New System.Drawing.Size(95, 17)
        Me.cb_MaxLimit.TabIndex = 4
        Me.cb_MaxLimit.Text = "Auto Max Limit"
        Me.ToolTip1.SetToolTip(Me.cb_MaxLimit, "Sets Start to January 1st 1753" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and End to December 31st 9998")
        Me.cb_MaxLimit.UseVisualStyleBackColor = True
        '
        'lb_End
        '
        Me.lb_End.AutoSize = True
        Me.lb_End.Location = New System.Drawing.Point(7, 54)
        Me.lb_End.Name = "lb_End"
        Me.lb_End.Size = New System.Drawing.Size(29, 13)
        Me.lb_End.TabIndex = 3
        Me.lb_End.Text = "End:"
        '
        'lb_Start
        '
        Me.lb_Start.AutoSize = True
        Me.lb_Start.Location = New System.Drawing.Point(7, 19)
        Me.lb_Start.Name = "lb_Start"
        Me.lb_Start.Size = New System.Drawing.Size(32, 13)
        Me.lb_Start.TabIndex = 2
        Me.lb_Start.Text = "Start:"
        '
        'EndDatePicker
        '
        Me.EndDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDatePicker.Location = New System.Drawing.Point(6, 67)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(213, 20)
        Me.EndDatePicker.TabIndex = 1
        Me.EndDatePicker.Value = New Date(2018, 10, 5, 0, 0, 0, 0)
        '
        'StartDatePicker
        '
        Me.StartDatePicker.CustomFormat = "yyyy/MM/dd"
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDatePicker.Location = New System.Drawing.Point(6, 32)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(213, 20)
        Me.StartDatePicker.TabIndex = 0
        Me.StartDatePicker.Value = New Date(2018, 10, 5, 0, 0, 0, 0)
        '
        'gb_Region
        '
        Me.gb_Region.Controls.Add(Me.rb_Kor)
        Me.gb_Region.Controls.Add(Me.rb_Jap)
        Me.gb_Region.Controls.Add(Me.rb_Spa)
        Me.gb_Region.Controls.Add(Me.rb_Ger)
        Me.gb_Region.Controls.Add(Me.rb_Ita)
        Me.gb_Region.Controls.Add(Me.rb_Fr)
        Me.gb_Region.Controls.Add(Me.rb_Eng)
        Me.gb_Region.Location = New System.Drawing.Point(13, 177)
        Me.gb_Region.Name = "gb_Region"
        Me.gb_Region.Size = New System.Drawing.Size(407, 41)
        Me.gb_Region.TabIndex = 7
        Me.gb_Region.TabStop = False
        Me.gb_Region.Text = "Region"
        '
        'rb_Kor
        '
        Me.rb_Kor.AutoSize = True
        Me.rb_Kor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_Kor.Location = New System.Drawing.Point(352, 16)
        Me.rb_Kor.Name = "rb_Kor"
        Me.rb_Kor.Size = New System.Drawing.Size(64, 18)
        Me.rb_Kor.TabIndex = 6
        Me.rb_Kor.TabStop = True
        Me.rb_Kor.Text = "한국어"
        Me.rb_Kor.UseVisualStyleBackColor = True
        '
        'rb_Jap
        '
        Me.rb_Jap.AutoSize = True
        Me.rb_Jap.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_Jap.Location = New System.Drawing.Point(297, 16)
        Me.rb_Jap.Name = "rb_Jap"
        Me.rb_Jap.Size = New System.Drawing.Size(67, 18)
        Me.rb_Jap.TabIndex = 5
        Me.rb_Jap.TabStop = True
        Me.rb_Jap.Text = "日本語"
        Me.rb_Jap.UseVisualStyleBackColor = True
        '
        'rb_Spa
        '
        Me.rb_Spa.AutoSize = True
        Me.rb_Spa.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_Spa.Location = New System.Drawing.Point(239, 16)
        Me.rb_Spa.Name = "rb_Spa"
        Me.rb_Spa.Size = New System.Drawing.Size(69, 18)
        Me.rb_Spa.TabIndex = 4
        Me.rb_Spa.TabStop = True
        Me.rb_Spa.Text = "Español"
        Me.rb_Spa.UseVisualStyleBackColor = True
        '
        'rb_Ger
        '
        Me.rb_Ger.AutoSize = True
        Me.rb_Ger.Cursor = System.Windows.Forms.Cursors.Default
        Me.rb_Ger.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_Ger.Location = New System.Drawing.Point(173, 16)
        Me.rb_Ger.Name = "rb_Ger"
        Me.rb_Ger.Size = New System.Drawing.Size(77, 18)
        Me.rb_Ger.TabIndex = 3
        Me.rb_Ger.TabStop = True
        Me.rb_Ger.Text = "Deutsche"
        Me.rb_Ger.UseVisualStyleBackColor = True
        '
        'rb_Ita
        '
        Me.rb_Ita.AutoSize = True
        Me.rb_Ita.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_Ita.Location = New System.Drawing.Point(120, 16)
        Me.rb_Ita.Name = "rb_Ita"
        Me.rb_Ita.Size = New System.Drawing.Size(65, 18)
        Me.rb_Ita.TabIndex = 2
        Me.rb_Ita.TabStop = True
        Me.rb_Ita.Text = "Italiano"
        Me.rb_Ita.UseVisualStyleBackColor = True
        '
        'rb_Fr
        '
        Me.rb_Fr.AutoSize = True
        Me.rb_Fr.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_Fr.Location = New System.Drawing.Point(60, 16)
        Me.rb_Fr.Name = "rb_Fr"
        Me.rb_Fr.Size = New System.Drawing.Size(71, 18)
        Me.rb_Fr.TabIndex = 1
        Me.rb_Fr.TabStop = True
        Me.rb_Fr.Text = "Français"
        Me.rb_Fr.UseVisualStyleBackColor = True
        '
        'rb_Eng
        '
        Me.rb_Eng.AutoSize = True
        Me.rb_Eng.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_Eng.Location = New System.Drawing.Point(5, 16)
        Me.rb_Eng.Name = "rb_Eng"
        Me.rb_Eng.Size = New System.Drawing.Size(65, 18)
        Me.rb_Eng.TabIndex = 0
        Me.rb_Eng.TabStop = True
        Me.rb_Eng.Text = "English"
        Me.rb_Eng.UseVisualStyleBackColor = True
        '
        'bt_Build
        '
        Me.bt_Build.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Build.Location = New System.Drawing.Point(246, 374)
        Me.bt_Build.Name = "bt_Build"
        Me.bt_Build.Size = New System.Drawing.Size(128, 46)
        Me.bt_Build.TabIndex = 9
        Me.bt_Build.Text = "Build Event ROM"
        Me.bt_Build.UseVisualStyleBackColor = True
        '
        'lb_EventMsg
        '
        Me.lb_EventMsg.AutoSize = True
        Me.lb_EventMsg.Location = New System.Drawing.Point(197, 218)
        Me.lb_EventMsg.Name = "lb_EventMsg"
        Me.lb_EventMsg.Size = New System.Drawing.Size(84, 13)
        Me.lb_EventMsg.TabIndex = 10
        Me.lb_EventMsg.Text = "Event Message:"
        '
        'bt_ClearEM
        '
        Me.bt_ClearEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ClearEM.Location = New System.Drawing.Point(197, 329)
        Me.bt_ClearEM.Name = "bt_ClearEM"
        Me.bt_ClearEM.Size = New System.Drawing.Size(223, 21)
        Me.bt_ClearEM.TabIndex = 11
        Me.bt_ClearEM.Text = "Clear Text"
        Me.bt_ClearEM.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(0, 428)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Button5, "About")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'bt_Custom
        '
        Me.bt_Custom.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, CType(0, Byte))
        Me.bt_Custom.Location = New System.Drawing.Point(353, 50)
        Me.bt_Custom.Name = "bt_Custom"
        Me.bt_Custom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_Custom.Size = New System.Drawing.Size(68, 23)
        Me.bt_Custom.TabIndex = 16
        Me.bt_Custom.Text = "Custom"
        Me.ToolTip1.SetToolTip(Me.bt_Custom, "Make a custom Event pgf")
        Me.bt_Custom.UseVisualStyleBackColor = True
        '
        'lklb_Update
        '
        Me.lklb_Update.AutoSize = True
        Me.lklb_Update.Location = New System.Drawing.Point(10, 4)
        Me.lklb_Update.Name = "lklb_Update"
        Me.lklb_Update.Size = New System.Drawing.Size(48, 13)
        Me.lklb_Update.TabIndex = 17
        Me.lklb_Update.TabStop = True
        Me.lklb_Update.Text = "Update?"
        Me.ToolTip1.SetToolTip(Me.lklb_Update, "Update")
        '
        'gb_ROM
        '
        Me.gb_ROM.Controls.Add(Me.bt_DefaultDes)
        Me.gb_ROM.Controls.Add(Me.bt_ClearDes)
        Me.gb_ROM.Controls.Add(Me.lb_Descript)
        Me.gb_ROM.Controls.Add(Me.rtb_ROMDes)
        Me.gb_ROM.Controls.Add(Me.lb_Code)
        Me.gb_ROM.Controls.Add(Me.tb_Code)
        Me.gb_ROM.Controls.Add(Me.lb_Header)
        Me.gb_ROM.Controls.Add(Me.tb_Header)
        Me.gb_ROM.Controls.Add(Me.lb_FileName)
        Me.gb_ROM.Controls.Add(Me.tb_FileName)
        Me.gb_ROM.Controls.Add(Me.Label7)
        Me.gb_ROM.Location = New System.Drawing.Point(13, 221)
        Me.gb_ROM.Name = "gb_ROM"
        Me.gb_ROM.Size = New System.Drawing.Size(180, 194)
        Me.gb_ROM.TabIndex = 19
        Me.gb_ROM.TabStop = False
        Me.gb_ROM.Text = "ROM Details"
        '
        'bt_DefaultDes
        '
        Me.bt_DefaultDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_DefaultDes.Location = New System.Drawing.Point(90, 166)
        Me.bt_DefaultDes.Name = "bt_DefaultDes"
        Me.bt_DefaultDes.Size = New System.Drawing.Size(85, 21)
        Me.bt_DefaultDes.TabIndex = 23
        Me.bt_DefaultDes.Text = "Default Text"
        Me.bt_DefaultDes.UseVisualStyleBackColor = True
        '
        'bt_ClearDes
        '
        Me.bt_ClearDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_ClearDes.Location = New System.Drawing.Point(4, 166)
        Me.bt_ClearDes.Name = "bt_ClearDes"
        Me.bt_ClearDes.Size = New System.Drawing.Size(85, 21)
        Me.bt_ClearDes.TabIndex = 20
        Me.bt_ClearDes.Text = "Clear Text"
        Me.bt_ClearDes.UseVisualStyleBackColor = True
        '
        'lb_Descript
        '
        Me.lb_Descript.AutoSize = True
        Me.lb_Descript.Location = New System.Drawing.Point(4, 94)
        Me.lb_Descript.Name = "lb_Descript"
        Me.lb_Descript.Size = New System.Drawing.Size(63, 13)
        Me.lb_Descript.TabIndex = 21
        Me.lb_Descript.Text = "Description:"
        '
        'rtb_ROMDes
        '
        Me.rtb_ROMDes.Location = New System.Drawing.Point(4, 107)
        Me.rtb_ROMDes.MaxLength = 96
        Me.rtb_ROMDes.Name = "rtb_ROMDes"
        Me.rtb_ROMDes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb_ROMDes.Size = New System.Drawing.Size(172, 59)
        Me.rtb_ROMDes.TabIndex = 20
        Me.rtb_ROMDes.Text = "Pokémon" & Global.Microsoft.VisualBasic.ChrW(10) & "Generation 5" & Global.Microsoft.VisualBasic.ChrW(10) & "Custom Made Distribution" & Global.Microsoft.VisualBasic.ChrW(10) & "PKMG5DC"
        Me.rtb_ROMDes.WordWrap = False
        '
        'lb_Code
        '
        Me.lb_Code.AutoSize = True
        Me.lb_Code.Location = New System.Drawing.Point(117, 55)
        Me.lb_Code.Name = "lb_Code"
        Me.lb_Code.Size = New System.Drawing.Size(35, 13)
        Me.lb_Code.TabIndex = 18
        Me.lb_Code.Text = "Code:"
        '
        'tb_Code
        '
        Me.tb_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tb_Code.Location = New System.Drawing.Point(118, 68)
        Me.tb_Code.MaxLength = 4
        Me.tb_Code.Name = "tb_Code"
        Me.tb_Code.Size = New System.Drawing.Size(44, 20)
        Me.tb_Code.TabIndex = 17
        Me.tb_Code.Text = "G5DC"
        '
        'lb_Header
        '
        Me.lb_Header.AutoSize = True
        Me.lb_Header.Location = New System.Drawing.Point(6, 55)
        Me.lb_Header.Name = "lb_Header"
        Me.lb_Header.Size = New System.Drawing.Size(45, 13)
        Me.lb_Header.TabIndex = 16
        Me.lb_Header.Text = "Header:"
        '
        'tb_Header
        '
        Me.tb_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tb_Header.Location = New System.Drawing.Point(7, 68)
        Me.tb_Header.MaxLength = 12
        Me.tb_Header.Name = "tb_Header"
        Me.tb_Header.Size = New System.Drawing.Size(103, 20)
        Me.tb_Header.TabIndex = 15
        Me.tb_Header.Text = "PKMCUSTOMROM"
        '
        'lb_FileName
        '
        Me.lb_FileName.AutoSize = True
        Me.lb_FileName.Location = New System.Drawing.Point(6, 16)
        Me.lb_FileName.Name = "lb_FileName"
        Me.lb_FileName.Size = New System.Drawing.Size(57, 13)
        Me.lb_FileName.TabIndex = 13
        Me.lb_FileName.Text = "File Name:"
        '
        'tb_FileName
        '
        Me.tb_FileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_FileName.Location = New System.Drawing.Point(7, 29)
        Me.tb_FileName.Name = "tb_FileName"
        Me.tb_FileName.Size = New System.Drawing.Size(142, 21)
        Me.tb_FileName.TabIndex = 12
        Me.tb_FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = ".nds"
        '
        'lklb_Author
        '
        Me.lklb_Author.AutoSize = True
        Me.lklb_Author.Location = New System.Drawing.Point(392, 436)
        Me.lklb_Author.Name = "lklb_Author"
        Me.lklb_Author.Size = New System.Drawing.Size(47, 13)
        Me.lklb_Author.TabIndex = 20
        Me.lklb_Author.TabStop = True
        Me.lklb_Author.Text = "Regnum"
        '
        'lb_By
        '
        Me.lb_By.AutoSize = True
        Me.lb_By.Location = New System.Drawing.Point(378, 436)
        Me.lb_By.Name = "lb_By"
        Me.lb_By.Size = New System.Drawing.Size(18, 13)
        Me.lb_By.TabIndex = 21
        Me.lb_By.Text = "by"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(433, 4)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(9, 442)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|"
        Me.ToolTip1.SetToolTip(Me.Label13, "Divider, so I know what Release sees")
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(412, -4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(29, 24)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = ">>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(328, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 22)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(822, 451)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lklb_Author)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lb_By)
        Me.Controls.Add(Me.gb_ROM)
        Me.Controls.Add(Me.lklb_Update)
        Me.Controls.Add(Me.bt_Custom)
        Me.Controls.Add(Me.bt_ClearEM)
        Me.Controls.Add(Me.lb_EventMsg)
        Me.Controls.Add(Me.bt_Build)
        Me.Controls.Add(Me.gb_Region)
        Me.Controls.Add(Me.gb_DateLimit)
        Me.Controls.Add(Me.rtb_EventMsg)
        Me.Controls.Add(Me.gb_GameComp)
        Me.Controls.Add(Me.lb_PGF)
        Me.Controls.Add(Me.bt_PGF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtb_Editor)
        Me.Controls.Add(Me.Button7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PKMG5DC"
        Me.gb_GameComp.ResumeLayout(False)
        Me.gb_GameComp.PerformLayout()
        Me.gb_DateLimit.ResumeLayout(False)
        Me.gb_DateLimit.PerformLayout()
        Me.gb_Region.ResumeLayout(False)
        Me.gb_Region.PerformLayout()
        Me.gb_ROM.ResumeLayout(False)
        Me.gb_ROM.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtb_Editor As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_PGF As Button
    Friend WithEvents lb_PGF As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents gb_GameComp As GroupBox
    Friend WithEvents cb_White2 As CheckBox
    Friend WithEvents cb_Black2 As CheckBox
    Friend WithEvents cb_White As CheckBox
    Friend WithEvents cb_Black As CheckBox
    Friend WithEvents rtb_EventMsg As RichTextBox
    Friend WithEvents gb_DateLimit As GroupBox
    Friend WithEvents lb_End As Label
    Friend WithEvents lb_Start As Label
    Friend WithEvents EndDatePicker As DateTimePicker
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents cb_MaxLimit As CheckBox
    Friend WithEvents gb_Region As GroupBox
    Friend WithEvents rb_Kor As RadioButton
    Friend WithEvents rb_Jap As RadioButton
    Friend WithEvents rb_Spa As RadioButton
    Friend WithEvents rb_Ger As RadioButton
    Friend WithEvents rb_Ita As RadioButton
    Friend WithEvents rb_Fr As RadioButton
    Friend WithEvents rb_Eng As RadioButton
    Friend WithEvents bt_Build As Button
    Friend WithEvents lb_EventMsg As Label
    Friend WithEvents bt_ClearEM As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents bt_Custom As Button
    Friend WithEvents lklb_Update As LinkLabel
    Friend WithEvents gb_ROM As GroupBox
    Friend WithEvents lb_FileName As Label
    Friend WithEvents tb_FileName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lb_Descript As Label
    Friend WithEvents rtb_ROMDes As RichTextBox
    Friend WithEvents lb_Code As Label
    Friend WithEvents tb_Code As TextBox
    Friend WithEvents lb_Header As Label
    Friend WithEvents tb_Header As TextBox
    Friend WithEvents bt_ClearDes As Button
    Friend WithEvents lklb_Author As LinkLabel
    Friend WithEvents lb_By As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bt_DefaultDes As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
