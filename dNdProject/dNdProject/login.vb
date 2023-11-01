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
            rdr.Close()
            connection.Close()
            characterSheet.Show()
        Else
            MessageBox.Show("That character does not exist")
            rdr.Close()
            connection.Close()
            Exit Sub
        End If
    End Sub

    Private Sub createUserButton_Click(sender As Object, e As EventArgs) Handles createUserButton.Click
        characterSheetNew.Show()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check if the table exists and enables the login button if so
        Dim characterTableExists As Boolean
        characterTableExists = Convert.ToBoolean(checkTableCharactersExistFunction())

        If characterTableExists = True Then
            loginActionButton.Enabled = True
        End If

    End Sub
End Class