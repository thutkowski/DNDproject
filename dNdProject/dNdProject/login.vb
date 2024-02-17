Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class login

    Public Function loginActionFunction(ByVal username As String) As Boolean
        openDB()

        'Queries character list 
        command.CommandText = "SELECT characterID FROM characters WHERE characterName = @Username"
        command.Parameters.AddWithValue("@Username", username)
        characterID = command.ExecuteScalar()

        'Checks if the query returned any rows
        If characterID Then
            rdr.Close()
            connection.Close()
            Return True
        Else
            MessageBox.Show("That character does not exist")
            rdr.Close()
            connection.Close()
            Return False
        End If
    End Function

    Public Sub loginActionButton_Click(sender As Object, e As EventArgs) Handles loginActionButton.Click
        characterUser = characterTextBox.Text

        If loginActionFunction(characterUser) = True Then
            characterSheet.Show()
            Me.Close()
        Else
            MessageBox.Show("Character not found!")
        End If
    End Sub


    Private Sub createUserButton_Click(sender As Object, e As EventArgs) Handles createUserButton.Click
        characterCreation.Show()
        Me.Close()
    End Sub

    Private Sub login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Not checkTableCharactersExist() Then
            characterTextBox.ReadOnly = True
        Else
            loginActionButton.Enabled = True
        End If
        checkTableCharacterStatsExist()
        checkTableCharacterSkillsExist()
        checkTableCharacterInfoExist()
    End Sub
End Class