Option Explicit On
Option Strict On
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class login
    Public Sub loginActionButton_Click(sender As Object, e As EventArgs) Handles loginActionButton.Click
        characterUser = characterTextBox.Text

        If loginActionFunction(characterUser) = True Then
            characterSheet.Show()
        Else
            MessageBox.Show("Character not found!")
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not checkTableCharactersExist() Then
            characterTextBox.ReadOnly = True
        Else
            loginActionButton.Enabled = True
        End If
        checkTableCharacterStatsExist()
        checkTableCharacterSkillsExist()
        checkTableCharacterInfoExist()

    End Sub

    Private Sub createUserButton_Click(sender As Object, e As EventArgs) Handles createUserButton.Click
        characterCreation.Show()
        Me.Close()
    End Sub
End Class