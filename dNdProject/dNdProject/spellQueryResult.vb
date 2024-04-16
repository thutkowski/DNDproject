Imports System.Data.SQLite

Public Class spellQueryResult
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

End Class