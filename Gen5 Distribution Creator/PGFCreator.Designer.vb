<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PK5Name = New System.Windows.Forms.Label()
        Me.OpenPK5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_Move4 = New System.Windows.Forms.Label()
        Me.lbl_Move3 = New System.Windows.Forms.Label()
        Me.lbl_Move2 = New System.Windows.Forms.Label()
        Me.lbl_Move1 = New System.Windows.Forms.Label()
        Me.lbl_IVs = New System.Windows.Forms.Label()
        Me.lbl_Nature = New System.Windows.Forms.Label()
        Me.lbl_Ability = New System.Windows.Forms.Label()
        Me.lbl_Species = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nud_CardID = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nud_CardID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PK5Name
        '
        Me.PK5Name.AutoEllipsis = True
        Me.PK5Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PK5Name.Location = New System.Drawing.Point(6, 28)
        Me.PK5Name.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.PK5Name.Name = "PK5Name"
        Me.PK5Name.Size = New System.Drawing.Size(330, 17)
        Me.PK5Name.TabIndex = 10
        Me.PK5Name.Text = "Open .pk5 ------->"
        Me.PK5Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenPK5
        '
        Me.OpenPK5.Location = New System.Drawing.Point(338, 24)
        Me.OpenPK5.Name = "OpenPK5"
        Me.OpenPK5.Size = New System.Drawing.Size(75, 23)
        Me.OpenPK5.TabIndex = 9
        Me.OpenPK5.Text = "Open .pk5"
        Me.OpenPK5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Move4)
        Me.GroupBox1.Controls.Add(Me.lbl_Move3)
        Me.GroupBox1.Controls.Add(Me.lbl_Move2)
        Me.GroupBox1.Controls.Add(Me.lbl_Move1)
        Me.GroupBox1.Controls.Add(Me.lbl_IVs)
        Me.GroupBox1.Controls.Add(Me.lbl_Nature)
        Me.GroupBox1.Controls.Add(Me.lbl_Ability)
        Me.GroupBox1.Controls.Add(Me.lbl_Species)
        Me.GroupBox1.Location = New System.Drawing.Point(515, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 287)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pokémon Info"
        '
        'lbl_Move4
        '
        Me.lbl_Move4.AutoSize = True
        Me.lbl_Move4.Location = New System.Drawing.Point(13, 205)
        Me.lbl_Move4.Name = "lbl_Move4"
        Me.lbl_Move4.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Move4.TabIndex = 7
        Me.lbl_Move4.Text = "- "
        '
        'lbl_Move3
        '
        Me.lbl_Move3.AutoSize = True
        Me.lbl_Move3.Location = New System.Drawing.Point(13, 181)
        Me.lbl_Move3.Name = "lbl_Move3"
        Me.lbl_Move3.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Move3.TabIndex = 6
        Me.lbl_Move3.Text = "- "
        '
        'lbl_Move2
        '
        Me.lbl_Move2.AutoSize = True
        Me.lbl_Move2.Location = New System.Drawing.Point(13, 152)
        Me.lbl_Move2.Name = "lbl_Move2"
        Me.lbl_Move2.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Move2.TabIndex = 5
        Me.lbl_Move2.Text = "- "
        '
        'lbl_Move1
        '
        Me.lbl_Move1.AutoSize = True
        Me.lbl_Move1.Location = New System.Drawing.Point(13, 122)
        Me.lbl_Move1.Name = "lbl_Move1"
        Me.lbl_Move1.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Move1.TabIndex = 4
        Me.lbl_Move1.Text = "- "
        '
        'lbl_IVs
        '
        Me.lbl_IVs.AutoSize = True
        Me.lbl_IVs.Location = New System.Drawing.Point(13, 94)
        Me.lbl_IVs.Name = "lbl_IVs"
        Me.lbl_IVs.Size = New System.Drawing.Size(28, 13)
        Me.lbl_IVs.TabIndex = 3
        Me.lbl_IVs.Text = "IVs: "
        Me.ToolTip1.SetToolTip(Me.lbl_IVs, "HP/Atk/Def/SpA/SpD/Spe")
        '
        'lbl_Nature
        '
        Me.lbl_Nature.AutoSize = True
        Me.lbl_Nature.Location = New System.Drawing.Point(13, 67)
        Me.lbl_Nature.Name = "lbl_Nature"
        Me.lbl_Nature.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Nature.TabIndex = 2
        Me.lbl_Nature.Text = "Nature: "
        '
        'lbl_Ability
        '
        Me.lbl_Ability.AutoSize = True
        Me.lbl_Ability.Location = New System.Drawing.Point(13, 42)
        Me.lbl_Ability.Name = "lbl_Ability"
        Me.lbl_Ability.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Ability.TabIndex = 1
        Me.lbl_Ability.Text = "Ability: "
        '
        'lbl_Species
        '
        Me.lbl_Species.AutoSize = True
        Me.lbl_Species.Location = New System.Drawing.Point(13, 20)
        Me.lbl_Species.Name = "lbl_Species"
        Me.lbl_Species.Size = New System.Drawing.Size(72, 13)
        Me.lbl_Species.TabIndex = 0
        Me.lbl_Species.Text = "Name @ Item"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Pokémon", "Item"})
        Me.ComboBox2.Location = New System.Drawing.Point(28, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PK5Name)
        Me.GroupBox2.Controls.Add(Me.OpenPK5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 71)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pokemon"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 174)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(417, 78)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(25, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Card ID:"
        '
        'nud_CardID
        '
        Me.nud_CardID.Location = New System.Drawing.Point(128, 46)
        Me.nud_CardID.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nud_CardID.Name = "nud_CardID"
        Me.nud_CardID.Size = New System.Drawing.Size(60, 20)
        Me.nud_CardID.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Card Type:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PGFCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nud_CardID)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PGFCreator"
        Me.Text = "PGFCreator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.nud_CardID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PK5Name As Label
    Friend WithEvents OpenPK5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_Species As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lbl_Move4 As Label
    Friend WithEvents lbl_Move3 As Label
    Friend WithEvents lbl_Move2 As Label
    Friend WithEvents lbl_Move1 As Label
    Friend WithEvents lbl_IVs As Label
    Friend WithEvents lbl_Nature As Label
    Friend WithEvents lbl_Ability As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nud_CardID As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
