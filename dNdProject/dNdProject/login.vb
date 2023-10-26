Option Explicit On
Option Strict On
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class login

    Private Sub loginActionButton_Click(sender As Object, e As EventArgs) Handles loginActionButton.Click
        characterUser = characterTextBox.Text
        connection.Open()

        command.CommandText = "SELECT * FROM characters WHERE characterName = @Username"

        command.Parameters.AddWithValue("@Username", characterUser)

        rdr = command.ExecuteReader()

        If rdr.Read() Then
            characterSheet.Show()
        Else
            MessageBox.Show("That character does not exist")
        End If
        rdr.Close()
        connection.Close()
    End Sub

    Private Sub createUserButton_Click(sender As Object, e As EventArgs) Handles createUserButton.Click
        characterSheetNew.Show()
    End Sub

End Class