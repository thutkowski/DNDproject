﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.displayTextBox.Location = New System.Drawing.Point(77, 91)
        Me.displayTextBox.Multiline = True
        Me.displayTextBox.Name = "displayTextBox"
        Me.displayTextBox.Size = New System.Drawing.Size(373, 183)
        Me.displayTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(554, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'spellSlotPanel
        '
        Me.spellSlotPanel.AutoScroll = True
        Me.spellSlotPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.spellSlotPanel.Location = New System.Drawing.Point(0, 303)
        Me.spellSlotPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.spellSlotPanel.Name = "spellSlotPanel"
        Me.spellSlotPanel.Size = New System.Drawing.Size(703, 118)
        Me.spellSlotPanel.TabIndex = 2
        '
        'spellCast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.spellSlotPanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.displayTextBox)
        Me.Name = "spellCast"
        Me.Text = "spellCast"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents displayTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents spellSlotPanel As Panel
End Class
