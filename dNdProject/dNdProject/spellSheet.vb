Imports System.Data.SQLite

Public Class spellSheet
    Private Sub spellSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()

        command.CommandText = "CREATE TABLE IF NOT EXISTS spells(spellID   INTEGER PRIMARY KEY AUTOINCREMENT,
            spellName TEXT,
            spellAttackType TEXT
            );"

        command.ExecuteNonQuery()
        command.CommandText = "SELECT * FROM spells"
        Dim da As New SQLiteDataAdapter()

        da.SelectCommand = command
        Dim dt As New DataTable

        da.Fill(dt)
        spellDataGridView.DataSource = dt
        spellDataGridView.AutoGenerateColumns = True
        connection.Close()
    End Sub
End Class