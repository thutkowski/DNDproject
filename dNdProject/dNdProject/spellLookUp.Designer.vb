<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class spellLookUp
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
        Me.spellDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.levelTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.classTextBox = New System.Windows.Forms.TextBox()
        CType(Me.spellDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spellDataGridView
        '
        Me.spellDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.spellDataGridView.Location = New System.Drawing.Point(12, 114)
        Me.spellDataGridView.Name = "spellDataGridView"
        Me.spellDataGridView.RowHeadersWidth = 62
        Me.spellDataGridView.Size = New System.Drawing.Size(318, 152)
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
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(197, 26)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(100, 44)
        Me.searchButton.TabIndex = 10
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'levelTextBox
        '
        Me.levelTextBox.Location = New System.Drawing.Point(65, 24)
        Me.levelTextBox.Name = "levelTextBox"
        Me.levelTextBox.Size = New System.Drawing.Size(78, 20)
        Me.levelTextBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Class"
        '
        'classTextBox
        '
        Me.classTextBox.Location = New System.Drawing.Point(65, 51)
        Me.classTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.classTextBox.Name = "classTextBox"
        Me.classTextBox.Size = New System.Drawing.Size(78, 20)
        Me.classTextBox.TabIndex = 14
        '
        'spellMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 281)
        Me.Controls.Add(Me.classTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.levelTextBox)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.spellDataGridView)
        Me.Name = "spellMenu"
        Me.Text = "Search"
        CType(Me.spellDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spellDataGridView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents levelTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents classTextBox As TextBox
End Class
