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
        CType(Me.spellDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spellDataGridView
        '
        Me.spellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.spellDataGridView.Location = New System.Drawing.Point(53, 99)
        Me.spellDataGridView.Name = "spellDataGridView"
        Me.spellDataGridView.Size = New System.Drawing.Size(300, 152)
        Me.spellDataGridView.TabIndex = 1
        '
        'spellSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 450)
        Me.Controls.Add(Me.spellDataGridView)
        Me.Name = "spellSheet"
        Me.Text = "Spell Sheet"
        CType(Me.spellDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents spellDataGridView As DataGridView
End Class
