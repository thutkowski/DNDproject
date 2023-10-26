Option Explicit On
Option Strict On
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class login

    Private Sub loginActionButton_Click(sender As Object, e As EventArgs) Handles loginActionButton.Click
        characterUser = characterTextBox.Text

        If loginFunction(characterUser) = True Then
            characterSheet.Show()
        Else
            MessageBox.Show("That character does not exist")
        End If

    End Sub

    Private Sub createUserButton_Click(sender As Object, e As EventArgs) Handles createUserButton.Click
        characterSheet.Show()
    End Sub
End Class