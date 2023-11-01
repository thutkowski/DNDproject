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
        command.CommandText = "SELECT @attackModifer FROM characters WHERE characterName = 'tim'"
        command.Parameters.AddWithValue("@attackModifer", selection)


        rdr = command.ExecuteReader
        rdr.Read()

        MessageBox.Show(rdr.HasRows)

        MessageBox.Show(rdr.GetInt32(0))

        'Dim stren As Int32
        'stren = rdr.GetInt32(0)
        'spellAttackBonusTextBox.Text = stren.ToString
        'rdr.Close()
        'connection.Close()
    End Sub
End Class