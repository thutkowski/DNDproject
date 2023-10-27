<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.characterTextBox = New System.Windows.Forms.TextBox()
        Me.createUserButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginActionButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Character Name:"
        '
        'characterTextBox
        '
        Me.characterTextBox.Location = New System.Drawing.Point(257, 48)
        Me.characterTextBox.Name = "characterTextBox"
        Me.characterTextBox.Size = New System.Drawing.Size(218, 23)
        Me.characterTextBox.TabIndex = 2
        '
        'createUserButton
        '
        Me.createUserButton.Location = New System.Drawing.Point(367, 84)
        Me.createUserButton.Name = "createUserButton"
        Me.createUserButton.Size = New System.Drawing.Size(108, 59)
        Me.createUserButton.TabIndex = 3
        Me.createUserButton.Text = "Create a character"
        Me.createUserButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 4
        '
        'loginActionButton
        '
        Me.loginActionButton.Enabled = False
        Me.loginActionButton.Location = New System.Drawing.Point(257, 84)
        Me.loginActionButton.Name = "loginActionButton"
        Me.loginActionButton.Size = New System.Drawing.Size(94, 59)
        Me.loginActionButton.TabIndex = 5
        Me.loginActionButton.Text = "Login"
        Me.loginActionButton.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 241)
        Me.Controls.Add(Me.loginActionButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.createUserButton)
        Me.Controls.Add(Me.characterTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "login"
        Me.Text = "DND Character Sheet Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents characterTextBox As TextBox
    Friend WithEvents createUserButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents loginActionButton As Button
End Class
