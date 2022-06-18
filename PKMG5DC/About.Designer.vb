<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lb_Description = New System.Windows.Forms.Label()
        Me.lb_Includes = New System.Windows.Forms.Label()
        Me.lklb_Ndstool = New System.Windows.Forms.LinkLabel()
        Me.lklb_armips = New System.Windows.Forms.LinkLabel()
        Me.lklb_12distro = New System.Windows.Forms.LinkLabel()
        Me.lb_Source = New System.Windows.Forms.Label()
        Me.lklb_Source = New System.Windows.Forms.LinkLabel()
        Me.lb_SourceCHS = New System.Windows.Forms.Label()
        Me.lklb_SourceCHS = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'lb_Description
        '
        Me.lb_Description.AutoSize = True
        Me.lb_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Description.Location = New System.Drawing.Point(-1, 12)
        Me.lb_Description.Name = "lb_Description"
        Me.lb_Description.Size = New System.Drawing.Size(276, 60)
        Me.lb_Description.TabIndex = 0
        Me.lb_Description.Text = "本程序用于构建GEN5游戏的配信ROM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "通过一个原始的自由船票配信ROM" &
    "和.pgf配信文件，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "你可以自制一份对应事件的配信ROM。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ""
        '
        'lb_Includes
        '
        Me.lb_Includes.AutoSize = True
        Me.lb_Includes.Location = New System.Drawing.Point(13, 106)
        Me.lb_Includes.Name = "lb_Includes"
        Me.lb_Includes.Size = New System.Drawing.Size(160, 13)
        Me.lb_Includes.TabIndex = 1
        Me.lb_Includes.Text = "本程序包含以下程序的相关内容："
        '
        'lklb_Ndstool
        '
        Me.lklb_Ndstool.AutoSize = True
        Me.lklb_Ndstool.Location = New System.Drawing.Point(105, 138)
        Me.lklb_Ndstool.Name = "lklb_Ndstool"
        Me.lklb_Ndstool.Size = New System.Drawing.Size(41, 13)
        Me.lklb_Ndstool.TabIndex = 2
        Me.lklb_Ndstool.TabStop = True
        Me.lklb_Ndstool.Text = "ndstool"
        '
        'lklb_armips
        '
        Me.lklb_armips.AutoSize = True
        Me.lklb_armips.Location = New System.Drawing.Point(107, 166)
        Me.lklb_armips.Name = "lklb_armips"
        Me.lklb_armips.Size = New System.Drawing.Size(37, 13)
        Me.lklb_armips.TabIndex = 3
        Me.lklb_armips.TabStop = True
        Me.lklb_armips.Text = "armips"
        '
        'lklb_12distro
        '
        Me.lklb_12distro.AutoSize = True
        Me.lklb_12distro.Location = New System.Drawing.Point(42, 197)
        Me.lklb_12distro.Name = "lklb_12distro"
        Me.lklb_12distro.Size = New System.Drawing.Size(195, 13)
        Me.lklb_12distro.TabIndex = 4
        Me.lklb_12distro.TabStop = True
        Me.lklb_12distro.Text = "Pokémon Duodecuple Distribution hack"
        '
        'lb_Source
        '
        Me.lb_Source.AutoSize = True
        Me.lb_Source.Location = New System.Drawing.Point(13, 290)
        Me.lb_Source.Name = "lb_Source"
        Me.lb_Source.Size = New System.Drawing.Size(72, 13)
        Me.lb_Source.TabIndex = 5
        Me.lb_Source.Text = "源代码:"
        '
        'lklb_Source
        '
        Me.lklb_Source.AutoSize = True
        Me.lklb_Source.Location = New System.Drawing.Point(92, 289)
        Me.lklb_Source.Name = "lklb_Source"
        Me.lklb_Source.Size = New System.Drawing.Size(40, 13)
        Me.lklb_Source.TabIndex = 6
        Me.lklb_Source.TabStop = True
        Me.lklb_Source.Text = "GitHub"
        '
        'lb_SourceCHS
        '
        Me.lb_SourceCHS.AutoSize = True
        Me.lb_SourceCHS.Location = New System.Drawing.Point(13, 310)
        Me.lb_SourceCHS.Name = "lb_SourceCHS"
        Me.lb_SourceCHS.Size = New System.Drawing.Size(72, 13)
        Me.lb_SourceCHS.TabIndex = 7
        Me.lb_SourceCHS.Text = "汉化版源代码:"
        '
        'lklb_SourceCHS
        '
        Me.lklb_SourceCHS.AutoSize = True
        Me.lklb_SourceCHS.Location = New System.Drawing.Point(92, 310)
        Me.lklb_SourceCHS.Name = "lklb_SourceCHS"
        Me.lklb_SourceCHS.Size = New System.Drawing.Size(40, 13)
        Me.lklb_SourceCHS.TabIndex = 8
        Me.lklb_SourceCHS.TabStop = True
        Me.lklb_SourceCHS.Text = "GitHub-汉化"
        '       
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 365)
        Me.Controls.Add(Me.lklb_SourceCHS)
        Me.Controls.Add(Me.lb_SourceCHS)
        Me.Controls.Add(Me.lklb_Source)
        Me.Controls.Add(Me.lb_Source)
        Me.Controls.Add(Me.lklb_12distro)
        Me.Controls.Add(Me.lklb_armips)
        Me.Controls.Add(Me.lklb_Ndstool)
        Me.Controls.Add(Me.lb_Includes)
        Me.Controls.Add(Me.lb_Description)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "关于"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lb_Description As Label
    Friend WithEvents lb_Includes As Label
    Friend WithEvents lklb_Ndstool As LinkLabel
    Friend WithEvents lklb_armips As LinkLabel
    Friend WithEvents lklb_12distro As LinkLabel
    Friend WithEvents lb_Source As Label
    Friend WithEvents lklb_Source As LinkLabel
    Friend WithEvents lb_SourceCHS As Label
    Friend WithEvents lklb_SourceCHS As LinkLabel
End Class
