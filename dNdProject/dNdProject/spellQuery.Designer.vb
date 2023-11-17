<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spellQuery
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.spellName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.school = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.castingTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spellRange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spellComponents = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spellLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.spellName, Me.school, Me.castingTime, Me.spellRange, Me.duration, Me.spellComponents, Me.spellLevel})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'spellName
        '
        Me.spellName.HeaderText = "Spell Name"
        Me.spellName.Name = "spellName"
        '
        'school
        '
        Me.school.HeaderText = "School"
        Me.school.Name = "school"
        '
        'castingTime
        '
        Me.castingTime.HeaderText = "Casting Time"
        Me.castingTime.Name = "castingTime"
        '
        'spellRange
        '
        Me.spellRange.HeaderText = "Spell Range"
        Me.spellRange.Name = "spellRange"
        '
        'duration
        '
        Me.duration.HeaderText = "Duration"
        Me.duration.Name = "duration"
        '
        'spellComponents
        '
        Me.spellComponents.HeaderText = "Components"
        Me.spellComponents.Name = "spellComponents"
        '
        'spellLevel
        '
        Me.spellLevel.HeaderText = "Level"
        Me.spellLevel.Name = "spellLevel"
        '
        'spellQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "spellQuery"
        Me.Text = "spellQuery"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents spellName As DataGridViewTextBoxColumn
    Friend WithEvents school As DataGridViewTextBoxColumn
    Friend WithEvents castingTime As DataGridViewTextBoxColumn
    Friend WithEvents spellRange As DataGridViewTextBoxColumn
    Friend WithEvents duration As DataGridViewTextBoxColumn
    Friend WithEvents spellComponents As DataGridViewTextBoxColumn
    Friend WithEvents spellLevel As DataGridViewTextBoxColumn
End Class
