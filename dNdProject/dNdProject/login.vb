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
        connection.Open()
        command.CommandText = "CREATE TABLE IF NOT EXISTS characters(characterID   INTEGER PRIMARY KEY AUTOINCREMENT,
            characterName TEXT,
            stren         INTEGER,
            dex           INTEGER,
            con           INTEGER,
            intel         INTEGER,
            wisdom        INTEGER,
            charisma      INTEGER
            );"
        'command.CommandText = " CREATE TABLE IF NOT EXISTS characters(ID INTEGER PRIMARY KEY AUTOINCREMENT,name TEXT)"
        command.ExecuteNonQuery()
        command.CommandText = "SELECT * FROM characters"

        rdr = command.ExecuteReader()

        If rdr.Read() Then
            loginActionButton.Enabled = True
        End If
        rdr.Close()
        connection.Close()
    End Sub
End Class