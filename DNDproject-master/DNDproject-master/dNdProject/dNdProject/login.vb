Option Explicit On
Option Strict On
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class login

    Private Sub loginActionButton_Click(sender As Object, e As EventArgs) Handles loginActionButton.Click
        characterUser = characterTextBox.Text
        connection.Open()

        command.Connection = connection
        command.CommandText = "SELECT * FROM characters WHERE characterName =@characterUser"
        command.Parameters.AddWithValue("@characterUser", characterTextBox.Text)



        rdr = command.ExecuteReader()
        'Using rdr
        '    While (rdr.Read())
        '        ((rdr.GetInt32(0) & rdr.GetString(1) & rdr.GetInt32(2)))
        '    End While
        'End Using
        If rdr.Read() Then
            characterSheet.Show()
        Else
            MessageBox.Show("That character does not exist")
        End If
        connection.Close()
        If connection.State = ConnectionState.Open Then
            MsgBox("The connection is: " & connection.State.ToString)
        End If
    End Sub
End Class