Public Class characterCreation

    Private Sub createCharacterButton_Click(sender As Object, e As EventArgs) Handles createCharacterButton.Click
        openDB()
        characterName = charNameTextBox.Text

        If checkIfNameTaken(characterName) Then
            Exit Sub
        End If

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
    Private Function checkIfNameTaken(ByVal charName As String) As Boolean
        command.CommandText = "SELECT * FROM characters WHERE characterName=@characterName"
        command.Parameters.AddWithValue("@characterName", charName)
        If Not CInt(command.ExecuteScalar) = 0 Then
            MessageBox.Show("Character name already taken. Choose a new new name or login!", "Character Name Error")
            Return True
        End If
        Return False
    End Function
End Class