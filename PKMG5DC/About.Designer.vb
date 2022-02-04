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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.lb_Description = New System.Windows.Forms.Label()
        Me.lb_Includes = New System.Windows.Forms.Label()
        Me.lklb_Ndstool = New System.Windows.Forms.LinkLabel()
        Me.lklb_armips = New System.Windows.Forms.LinkLabel()
        Me.lklb_12distro = New System.Windows.Forms.LinkLabel()
        Me.lb_Source = New System.Windows.Forms.Label()
        Me.lklb_Source = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_AppVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb_Description
        '
        Me.lb_Description.AutoSize = True
        Me.lb_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lb_Description.Location = New System.Drawing.Point(13, 32)
        Me.lb_Description.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_Description.Name = "lb_Description"
        Me.lb_Description.Size = New System.Drawing.Size(340, 72)
        Me.lb_Description.TabIndex = 0
        Me.lb_Description.Text = "This program builds Distribution ROMs for Gen 5 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pokémon games. With a copy of t" &
    "he Liberty Ticket" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Distribution ROM and a .pgf event file, you can " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "make a Dist" &
    "ribution ROM."
        '
        'lb_Includes
        '
        Me.lb_Includes.AutoSize = True
        Me.lb_Includes.Location = New System.Drawing.Point(13, 141)
        Me.lb_Includes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_Includes.Name = "lb_Includes"
        Me.lb_Includes.Size = New System.Drawing.Size(201, 16)
        Me.lb_Includes.TabIndex = 1
        Me.lb_Includes.Text = "This program contains copies of:"
        '
        'lklb_Ndstool
        '
        Me.lklb_Ndstool.AutoSize = True
        Me.lklb_Ndstool.Location = New System.Drawing.Point(13, 170)
        Me.lklb_Ndstool.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lklb_Ndstool.Name = "lklb_Ndstool"
        Me.lklb_Ndstool.Size = New System.Drawing.Size(51, 16)
        Me.lklb_Ndstool.TabIndex = 2
        Me.lklb_Ndstool.TabStop = True
        Me.lklb_Ndstool.Text = "ndstool"
        '
        'lklb_armips
        '
        Me.lklb_armips.AutoSize = True
        Me.lklb_armips.Location = New System.Drawing.Point(13, 202)
        Me.lklb_armips.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lklb_armips.Name = "lklb_armips"
        Me.lklb_armips.Size = New System.Drawing.Size(48, 16)
        Me.lklb_armips.TabIndex = 3
        Me.lklb_armips.TabStop = True
        Me.lklb_armips.Text = "armips"
        '
        'lklb_12distro
        '
        Me.lklb_12distro.AutoSize = True
        Me.lklb_12distro.Location = New System.Drawing.Point(13, 235)
        Me.lklb_12distro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lklb_12distro.Name = "lklb_12distro"
        Me.lklb_12distro.Size = New System.Drawing.Size(243, 16)
        Me.lklb_12distro.TabIndex = 4
        Me.lklb_12distro.TabStop = True
        Me.lklb_12distro.Text = "Pokémon Duodecuple Distribution hack"
        '
        'lb_Source
        '
        Me.lb_Source.AutoSize = True
        Me.lb_Source.Location = New System.Drawing.Point(13, 357)
        Me.lb_Source.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_Source.Name = "lb_Source"
        Me.lb_Source.Size = New System.Drawing.Size(89, 16)
        Me.lb_Source.TabIndex = 5
        Me.lb_Source.Text = "Source Code:"
        '
        'lklb_Source
        '
        Me.lklb_Source.AutoSize = True
        Me.lklb_Source.Location = New System.Drawing.Point(110, 357)
        Me.lklb_Source.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lklb_Source.Name = "lklb_Source"
        Me.lklb_Source.Size = New System.Drawing.Size(48, 16)
        Me.lklb_Source.TabIndex = 6
        Me.lklb_Source.TabStop = True
        Me.lklb_Source.Text = "GitHub"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 357)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "App Version:"
        '
        'lb_AppVersion
        '
        Me.lb_AppVersion.AutoSize = True
        Me.lb_AppVersion.Location = New System.Drawing.Point(301, 357)
        Me.lb_AppVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_AppVersion.Name = "lb_AppVersion"
        Me.lb_AppVersion.Size = New System.Drawing.Size(0, 16)
        Me.lb_AppVersion.TabIndex = 7
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 382)
        Me.Controls.Add(Me.lb_AppVersion)
        Me.Controls.Add(Me.lklb_Source)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_Source)
        Me.Controls.Add(Me.lklb_12distro)
        Me.Controls.Add(Me.lklb_armips)
        Me.Controls.Add(Me.lklb_Ndstool)
        Me.Controls.Add(Me.lb_Includes)
        Me.Controls.Add(Me.lb_Description)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_Description As Label
    Friend WithEvents lb_Includes As Label
    Friend WithEvents lklb_Ndstool As LinkLabel
    Friend WithEvents lklb_armips As LinkLabel
    Friend WithEvents lklb_12distro As LinkLabel
    Friend WithEvents lb_Source As Label
    Friend WithEvents lklb_Source As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_AppVersion As Label
End Class
