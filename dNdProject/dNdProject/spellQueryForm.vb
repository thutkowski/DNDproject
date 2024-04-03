Imports System.Data.SQLite

Public Class spellQueryForm
    Private Sub spellQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openDB()
        Dim command As New SQLiteCommand(connection)

        command.CommandText = "SELECT spellName,source, spellLevel,castingTime ,
        components,spellRange,school ,duration,description,higherLevel 
        FROM spells WHERE spellID = @spellID"
        command.Parameters.AddWithValue("@spellID", spellIDQuery)

        rdr = command.ExecuteReader

        rdr.Read()
        spellNameLabel.Text = rdr.GetString(0)
        sourceTextBox.Text = rdr.GetString(1)
        spellLevelTextBox.Text = rdr.GetString(2)
        castingTimeTextBox.Text = rdr.GetString(3)
        componentsTextBox.Text = rdr.GetString(4)
        rangeTextBox.Text = rdr.GetString(5)
        schoolTextBox.Text = rdr.GetString(6)
        durationTextBox.Text = rdr.GetString(7)
        descTextBox.Text = rdr.GetString(8)
        atHigherLevelTextBox.Text = rdr.GetString(9)

        rdr.Close()

    End Sub

    Private Sub prepareButton_Click(sender As Object, e As EventArgs) Handles prepareButton.Click
        openDB()
        Dim command As New SQLiteCommand(connection)

        If checkFirstSpell() Then
            prepareSpells.show()
        End If

        command.CommandText = "INSERT INTO users (characterID,spellID) VALUES (@characterID,@spellID)"
        command.Parameters.AddWithValue("@spellID", spellIDQuery)
        command.Parameters.AddWithValue("@characterID", characterID)

        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
        connection.Close()
    End Sub

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
End Class