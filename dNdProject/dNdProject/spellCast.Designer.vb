<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spellCast
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
        Me.displayTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.spellSlotPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'displayTextBox
        '
        Me.displayTextBox.Location = New System.Drawing.Point(116, 140)
        Me.displayTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.displayTextBox.Multiline = True
        Me.displayTextBox.Name = "displayTextBox"
        Me.displayTextBox.Size = New System.Drawing.Size(558, 279)
        Me.displayTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(831, 242)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'spellSlotPanel
        '
        Me.spellSlotPanel.AutoScroll = True
        Me.spellSlotPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.spellSlotPanel.Location = New System.Drawing.Point(235, 466)
        Me.spellSlotPanel.Name = "spellSlotPanel"
        Me.spellSlotPanel.Size = New System.Drawing.Size(644, 181)
        Me.spellSlotPanel.TabIndex = 2
        '
        'spellCast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.spellSlotPanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.displayTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "spellCast"
        Me.Text = "spellCast"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents displayTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents spellSlotPanel As Panel
End Class
