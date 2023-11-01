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
        Dim selection As String
        selection = ComboBox1.SelectedText
        connection.Open()
        command.CommandText = "SELECT @attackModifer from characters WHERE characterName = @characterUser"
        command.Parameters.AddWithValue("@attackModifer", selection)
        command.Parameters.AddWithValue("@characterUser", characterUser)
        rdr = command.ExecuteReader
        MessageBox.Show(rdr.FieldCount, rdr.HasRows)
        rdr.Read()
        MessageBox.Show(rdr.FieldCount, rdr.HasRows)
        spellAttackBonusTextBox.Text = rdr.GetInt32(0).ToString

    End Sub
End Class