<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class spellQueryForm
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
        Me.spellNameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.sourceTextBox = New System.Windows.Forms.TextBox()
        Me.spellLevelTextBox = New System.Windows.Forms.TextBox()
        Me.castingTimeTextBox = New System.Windows.Forms.TextBox()
        Me.componentsTextBox = New System.Windows.Forms.TextBox()
        Me.durationTextBox = New System.Windows.Forms.TextBox()
        Me.descTextBox = New System.Windows.Forms.TextBox()
        Me.atHigherLevelTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.schoolTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rangeTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'spellNameLabel
        '
        Me.spellNameLabel.AutoSize = True
        Me.spellNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spellNameLabel.Location = New System.Drawing.Point(22, 20)
        Me.spellNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.spellNameLabel.Name = "spellNameLabel"
        Me.spellNameLabel.Size = New System.Drawing.Size(0, 18)
        Me.spellNameLabel.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Source:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Spell Level"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 105)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Duration:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 285)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "At Higher Levels:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 129)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Components:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 102)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 15)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Casting Time:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 170)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 15)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Descripition"
        '
        'sourceTextBox
        '
        Me.sourceTextBox.Location = New System.Drawing.Point(113, 45)
        Me.sourceTextBox.Name = "sourceTextBox"
        Me.sourceTextBox.Size = New System.Drawing.Size(100, 21)
        Me.sourceTextBox.TabIndex = 19
        '
        'spellLevelTextBox
        '
        Me.spellLevelTextBox.Location = New System.Drawing.Point(113, 72)
        Me.spellLevelTextBox.Name = "spellLevelTextBox"
        Me.spellLevelTextBox.Size = New System.Drawing.Size(100, 21)
        Me.spellLevelTextBox.TabIndex = 20
        '
        'castingTimeTextBox
        '
        Me.castingTimeTextBox.Location = New System.Drawing.Point(113, 99)
        Me.castingTimeTextBox.Name = "castingTimeTextBox"
        Me.castingTimeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.castingTimeTextBox.TabIndex = 21
        '
        'componentsTextBox
        '
        Me.componentsTextBox.Location = New System.Drawing.Point(113, 126)
        Me.componentsTextBox.Name = "componentsTextBox"
        Me.componentsTextBox.Size = New System.Drawing.Size(100, 21)
        Me.componentsTextBox.TabIndex = 22
        '
        'durationTextBox
        '
        Me.durationTextBox.Location = New System.Drawing.Point(325, 105)
        Me.durationTextBox.Name = "durationTextBox"
        Me.durationTextBox.Size = New System.Drawing.Size(100, 21)
        Me.durationTextBox.TabIndex = 23
        '
        'descTextBox
        '
        Me.descTextBox.Location = New System.Drawing.Point(23, 197)
        Me.descTextBox.Multiline = True
        Me.descTextBox.Name = "descTextBox"
        Me.descTextBox.Size = New System.Drawing.Size(580, 75)
        Me.descTextBox.TabIndex = 24
        '
        'atHigherLevelTextBox
        '
        Me.atHigherLevelTextBox.Location = New System.Drawing.Point(25, 313)
        Me.atHigherLevelTextBox.Multiline = True
        Me.atHigherLevelTextBox.Name = "atHigherLevelTextBox"
        Me.atHigherLevelTextBox.Size = New System.Drawing.Size(578, 52)
        Me.atHigherLevelTextBox.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "School:"
        '
        'schoolTextBox
        '
        Me.schoolTextBox.Location = New System.Drawing.Point(325, 75)
        Me.schoolTextBox.Name = "schoolTextBox"
        Me.schoolTextBox.Size = New System.Drawing.Size(100, 21)
        Me.schoolTextBox.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Range:"
        '
        'rangeTextBox
        '
        Me.rangeTextBox.Location = New System.Drawing.Point(325, 45)
        Me.rangeTextBox.Name = "rangeTextBox"
        Me.rangeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.rangeTextBox.TabIndex = 29
        '
        'spellQueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 416)
        Me.Controls.Add(Me.rangeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.schoolTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.atHigherLevelTextBox)
        Me.Controls.Add(Me.descTextBox)
        Me.Controls.Add(Me.durationTextBox)
        Me.Controls.Add(Me.componentsTextBox)
        Me.Controls.Add(Me.castingTimeTextBox)
        Me.Controls.Add(Me.spellLevelTextBox)
        Me.Controls.Add(Me.sourceTextBox)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.spellNameLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "spellQueryForm"
        Me.Text = "spellQueryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spellNameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents sourceTextBox As TextBox
    Friend WithEvents spellLevelTextBox As TextBox
    Friend WithEvents castingTimeTextBox As TextBox
    Friend WithEvents componentsTextBox As TextBox
    Friend WithEvents durationTextBox As TextBox
    Friend WithEvents descTextBox As TextBox
    Friend WithEvents atHigherLevelTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents schoolTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rangeTextBox As TextBox
End Class
