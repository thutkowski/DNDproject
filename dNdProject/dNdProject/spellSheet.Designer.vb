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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.spellSaveDCTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.spellAttackBonusTextBox = New System.Windows.Forms.TextBox()
        Me.spellAbilityComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.attackSpellCheckBox = New System.Windows.Forms.CheckBox()
        Me.spellNameTextBox = New System.Windows.Forms.TextBox()
        Me.addSpellButton = New System.Windows.Forms.Button()
        CType(Me.spellDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spellDataGridView
        '
        Me.spellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.spellDataGridView.Location = New System.Drawing.Point(12, 114)
        Me.spellDataGridView.Name = "spellDataGridView"
        Me.spellDataGridView.Size = New System.Drawing.Size(579, 152)
        Me.spellDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Spellcasting Ability:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Spell Save DC:"
        '
        'spellSaveDCTextBox
        '
        Me.spellSaveDCTextBox.Location = New System.Drawing.Point(299, 10)
        Me.spellSaveDCTextBox.Name = "spellSaveDCTextBox"
        Me.spellSaveDCTextBox.Size = New System.Drawing.Size(59, 20)
        Me.spellSaveDCTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Spell Attack Bonus:"
        '
        'spellAttackBonusTextBox
        '
        Me.spellAttackBonusTextBox.Location = New System.Drawing.Point(460, 11)
        Me.spellAttackBonusTextBox.Name = "spellAttackBonusTextBox"
        Me.spellAttackBonusTextBox.Size = New System.Drawing.Size(36, 20)
        Me.spellAttackBonusTextBox.TabIndex = 7
        '
        'spellAbilityComboBox
        '
        Me.spellAbilityComboBox.FormattingEnabled = True
        Me.spellAbilityComboBox.Items.AddRange(New Object() {"stren", "Dexterity" & Global.Microsoft.VisualBasic.ChrW(9), "Constitution", "Charisma", "Wisdom", "Intelligence"})
        Me.spellAbilityComboBox.Location = New System.Drawing.Point(104, 10)
        Me.spellAbilityComboBox.Name = "spellAbilityComboBox"
        Me.spellAbilityComboBox.Size = New System.Drawing.Size(104, 21)
        Me.spellAbilityComboBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Existing Spells:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Spell Name:"
        '
        'attackSpellCheckBox
        '
        Me.attackSpellCheckBox.AutoSize = True
        Me.attackSpellCheckBox.Location = New System.Drawing.Point(502, 46)
        Me.attackSpellCheckBox.Name = "attackSpellCheckBox"
        Me.attackSpellCheckBox.Size = New System.Drawing.Size(89, 17)
        Me.attackSpellCheckBox.TabIndex = 15
        Me.attackSpellCheckBox.Text = "Attack Spell?"
        Me.attackSpellCheckBox.UseVisualStyleBackColor = True
        '
        'spellNameTextBox
        '
        Me.spellNameTextBox.Location = New System.Drawing.Point(81, 42)
        Me.spellNameTextBox.Name = "spellNameTextBox"
        Me.spellNameTextBox.Size = New System.Drawing.Size(79, 20)
        Me.spellNameTextBox.TabIndex = 17
        '
        'addSpellButton
        '
        Me.addSpellButton.Location = New System.Drawing.Point(490, 66)
        Me.addSpellButton.Name = "addSpellButton"
        Me.addSpellButton.Size = New System.Drawing.Size(101, 27)
        Me.addSpellButton.TabIndex = 24
        Me.addSpellButton.Text = "Add Spell"
        Me.addSpellButton.UseVisualStyleBackColor = True
        '
        'spellSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 281)
        Me.Controls.Add(Me.addSpellButton)
        Me.Controls.Add(Me.spellNameTextBox)
        Me.Controls.Add(Me.attackSpellCheckBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.spellAbilityComboBox)
        Me.Controls.Add(Me.spellAttackBonusTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.spellSaveDCTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.spellDataGridView)
        Me.Name = "spellSheet"
        Me.Text = "Spell Sheet"
        CType(Me.spellDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spellDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents spellSaveDCTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents spellAttackBonusTextBox As TextBox
    Friend WithEvents spellAbilityComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents attackSpellCheckBox As CheckBox
    Friend WithEvents spellNameTextBox As TextBox
    Friend WithEvents addSpellButton As Button
End Class
