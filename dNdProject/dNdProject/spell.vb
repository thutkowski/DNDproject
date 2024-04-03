Imports System.Data.SQLite

Module spell

    'maybe logic not needed if we know they are preparing spells
    Private Function checkFirstSpell() As Boolean
        openDB()
        Dim command As New SQLiteCommand(connection)

        command.CommandText = "SELECT spellName from spells WHERE known='1' OR prepared='1'"
        If command.ExecuteScalar() IsNot Nothing AndAlso command.ExecuteScalar IsNot DBNull.Value Then
            Return False
        End If
        Return True
        connection.Close()
    End Function


    'prepare spell can be changed for known but think want to redesign
    'Private Sub prepareButton_Click(sender As Object, e As EventArgs) Handles prepareButton.Click
    '    openDB()
    '    If checkFirstSpell() Then
    '        prepareSpells.Show()
    '    End If

    '    'command.CommandText = "UPDATE spells SET known = 1 
    '    'WHERE spellID = @spellID"
    '    'command.Parameters.AddWithValue("@spellID", spellIDQuery)
    '    'command.ExecuteNonQuery()
    '    'connection.Close()
    'End Sub
End Module
