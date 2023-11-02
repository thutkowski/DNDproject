Imports System.Data.SQLite

Public Class spellSheet
    Private Sub spellSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connection.Open()

        'command.CommandText = "CREATE TABLE IF NOT EXISTS spells(spellID   INTEGER PRIMARY KEY AUTOINCREMENT,
        '    spellName TEXT,
        '    spellAttackType TEXT
        '    );"

        'command.ExecuteNonQuery()
        'command.CommandText = "SELECT spellName as Spell, spellAttackType as 'Attack Type' FROM spells"
        'Dim da As New SQLiteDataAdapter()

        'da.SelectCommand = command
        'Dim dt As New DataTable

        'da.Fill(dt)
        'spellDataGridView.DataSource = dt
        'spellDataGridView.AutoGenerateColumns = True
        'connection.Close()
    End Sub

    Private Sub spellAbilityComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles spellAbilityComboBox.SelectedIndexChanged
        Dim spellAbility As String
        Dim spellAttackModifer As Integer
        spellAbility = spellAbilityComboBox.SelectedText

        Select Case spellAbility
            Case "Strength"
                spellAttackModifer = Convert.ToInt32(strengthStat)
            Case "Dexterity"
                spellAttackModifer = Convert.ToInt32(dexterityStat)
            Case "Constitution"
                spellAttackModifer = Convert.ToInt32(constitutionStat)
            Case "Intelligence"
                spellAttackModifer = Convert.ToInt32(intelligenceStat)
            Case "Wisdom"
                spellAttackModifer = Convert.ToInt32(wisdomStat)
            Case "Charisma"
                spellAttackModifer = Convert.ToInt32(charismaStat)
        End Select


    End Sub
End Class