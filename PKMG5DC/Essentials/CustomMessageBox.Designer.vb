<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomMessageBox))
        Me.bt_First = New System.Windows.Forms.Button()
        Me.bt_Second = New System.Windows.Forms.Button()
        Me.lb_Message = New System.Windows.Forms.Label()
        Me.pb_ButtonArea = New System.Windows.Forms.PictureBox()
        Me.bt_Third = New System.Windows.Forms.Button()
        CType(Me.pb_ButtonArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_First
        '
        Me.bt_First.AutoSize = True
        Me.bt_First.Location = New System.Drawing.Point(10, 80)
        Me.bt_First.Name = "bt_First"
        Me.bt_First.Size = New System.Drawing.Size(75, 23)
        Me.bt_First.TabIndex = 0
        Me.bt_First.Text = "Button1"
        Me.bt_First.UseVisualStyleBackColor = True
        '
        'bt_Second
        '
        Me.bt_Second.AutoSize = True
        Me.bt_Second.Location = New System.Drawing.Point(104, 80)
        Me.bt_Second.Name = "bt_Second"
        Me.bt_Second.Size = New System.Drawing.Size(75, 23)
        Me.bt_Second.TabIndex = 1
        Me.bt_Second.Text = "Button2"
        Me.bt_Second.UseVisualStyleBackColor = True
        '
        'lb_Message
        '
        Me.lb_Message.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lb_Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Message.Location = New System.Drawing.Point(7, 6)
        Me.lb_Message.Name = "lb_Message"
        Me.lb_Message.Size = New System.Drawing.Size(270, 57)
        Me.lb_Message.TabIndex = 2
        Me.lb_Message.Text = "Label1"
        Me.lb_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_ButtonArea
        '
        Me.pb_ButtonArea.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pb_ButtonArea.Location = New System.Drawing.Point(-4, 69)
        Me.pb_ButtonArea.Name = "pb_ButtonArea"
        Me.pb_ButtonArea.Size = New System.Drawing.Size(294, 70)
        Me.pb_ButtonArea.TabIndex = 3
        Me.pb_ButtonArea.TabStop = False
        '
        'bt_Third
        '
        Me.bt_Third.AutoSize = True
        Me.bt_Third.Location = New System.Drawing.Point(197, 80)
        Me.bt_Third.Name = "bt_Third"
        Me.bt_Third.Size = New System.Drawing.Size(75, 23)
        Me.bt_Third.TabIndex = 4
        Me.bt_Third.Text = "Button3"
        Me.bt_Third.UseVisualStyleBackColor = True
        '
        'CustomMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.bt_Third)
        Me.Controls.Add(Me.lb_Message)
        Me.Controls.Add(Me.bt_Second)
        Me.Controls.Add(Me.bt_First)
        Me.Controls.Add(Me.pb_ButtonArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CustomMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.pb_ButtonArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_First As Button
    Friend WithEvents bt_Second As Button
    Friend WithEvents lb_Message As Label
    Friend WithEvents pb_ButtonArea As PictureBox
    Friend WithEvents bt_Third As Button
End Class
