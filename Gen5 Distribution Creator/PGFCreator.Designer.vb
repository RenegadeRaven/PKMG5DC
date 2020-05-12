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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New PKMG5DC.DatabaseDataSet()
        Me.ItemsTableAdapter = New PKMG5DC.DatabaseDataSetTableAdapters.ItemsTableAdapter()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PK5Name
        '
        Me.PK5Name.AutoEllipsis = True
        Me.PK5Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PK5Name.Location = New System.Drawing.Point(35, 55)
        Me.PK5Name.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.PK5Name.Name = "PK5Name"
        Me.PK5Name.Size = New System.Drawing.Size(330, 17)
        Me.PK5Name.TabIndex = 10
        Me.PK5Name.Text = "Open .pk5 ------->"
        Me.PK5Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenPK5
        '
        Me.OpenPK5.Location = New System.Drawing.Point(367, 51)
        Me.OpenPK5.Name = "OpenPK5"
        Me.OpenPK5.Size = New System.Drawing.Size(75, 23)
        Me.OpenPK5.TabIndex = 9
        Me.OpenPK5.Text = "Open .pk5"
        Me.OpenPK5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ItemsBindingSource
        Me.ComboBox1.DisplayMember = "Items"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'PGFCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PK5Name)
        Me.Controls.Add(Me.OpenPK5)
        Me.Name = "PGFCreator"
        Me.Text = "PGFCreator"
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PK5Name As Label
    Friend WithEvents OpenPK5 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As DatabaseDataSetTableAdapters.ItemsTableAdapter
End Class
