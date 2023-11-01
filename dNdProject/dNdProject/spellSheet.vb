Imports System.Data.SQLite

Public Class spellSheet
    Private Sub spellSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()

        command.CommandText = "CREATE TABLE IF NOT EXISTS spells(spellID   INTEGER PRIMARY KEY AUTOINCREMENT,
            spellName TEXT,
            spellAttackType TEXT
            );"

        command.ExecuteNonQuery()
        command.CommandText = "SELECT spellName as Spell, spellAttackType as 'Attack Type' FROM spells"
        Dim da As New SQLiteDataAdapter()

        da.SelectCommand = command
        Dim dt As New DataTable

        da.Fill(dt)
        spellDataGridView.DataSource = dt
        spellDataGridView.AutoGenerateColumns = True
        connection.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        spellAttackBonusTextBox.Text = ComboBox1.SelectedItem

    End Sub
End Class