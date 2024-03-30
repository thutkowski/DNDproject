Imports System.Data.SQLite

Public Class spellQueryForm
    Private Sub spellQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

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

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "UPDATE spells SET known = 1 
        WHERE spellID = @spellID"
        command.Parameters.AddWithValue("@spellID", spellIDQuery)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
End Class