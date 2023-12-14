<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spellSheet
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
        Me.spellDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.selectedSpellTextBox = New System.Windows.Forms.TextBox()
        CType(Me.spellDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spellDataGridView
        '
        Me.spellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.spellDataGridView.Location = New System.Drawing.Point(12, 114)
        Me.spellDataGridView.Name = "spellDataGridView"
        Me.spellDataGridView.RowHeadersWidth = 62
        Me.spellDataGridView.Size = New System.Drawing.Size(579, 152)
        Me.spellDataGridView.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Available Spells:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(333, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 62)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Prepare Spell"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'selectedSpellTextBox
        '
        Me.selectedSpellTextBox.Location = New System.Drawing.Point(113, 37)
        Me.selectedSpellTextBox.Name = "selectedSpellTextBox"
        Me.selectedSpellTextBox.Size = New System.Drawing.Size(78, 20)
        Me.selectedSpellTextBox.TabIndex = 11
        '
        'spellSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 281)
        Me.Controls.Add(Me.selectedSpellTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.spellDataGridView)
        Me.Name = "spellSheet"
        Me.Text = "Spell Sheet"
        CType(Me.spellDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spellDataGridView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents selectedSpellTextBox As TextBox
End Class
