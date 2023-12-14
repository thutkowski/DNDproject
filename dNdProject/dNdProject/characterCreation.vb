Public Class characterCreation

    Private Sub createCharacterButton_Click(sender As Object, e As EventArgs) Handles createCharacterButton.Click
        openDB()
        characterName = charNameTextBox.Text
        command.CommandText = "INSERT INTO characters (characterName) VALUES (@characterName)"
        command.Parameters.AddWithValue("@characterName", characterName)
        command.ExecuteNonQuery()
        command.CommandText = "SELECT characterID FROM characters WHERE characterName = @characterName"
        command.Parameters.AddWithValue("@characterName", characterName)
        characterID = Convert.ToInt32(command.ExecuteScalar)
        connection.Close()
        characterSheet.Show()
        Me.Close()
    End Sub
End Class