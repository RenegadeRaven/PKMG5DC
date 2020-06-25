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
        Me.lb_Description.Text = "This program builds Distribution ROMs for Gen 5 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pokémon games. With a copy of t" &
    "he Liberty Ticket" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Distribution ROM and a .pgf event file, you can " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "make a Dist" &
    "ribution ROM."
        '
        'lb_Includes
        '
        Me.lb_Includes.AutoSize = True
        Me.lb_Includes.Location = New System.Drawing.Point(13, 106)
        Me.lb_Includes.Name = "lb_Includes"
        Me.lb_Includes.Size = New System.Drawing.Size(160, 13)
        Me.lb_Includes.TabIndex = 1
        Me.lb_Includes.Text = "This program contains copies of:"
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
        Me.lb_Source.Text = "Source Code:"
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
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 365)
        Me.Controls.Add(Me.lklb_Source)
        Me.Controls.Add(Me.lb_Source)
        Me.Controls.Add(Me.lklb_12distro)
        Me.Controls.Add(Me.lklb_armips)
        Me.Controls.Add(Me.lklb_Ndstool)
        Me.Controls.Add(Me.lb_Includes)
        Me.Controls.Add(Me.lb_Description)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
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
End Class
