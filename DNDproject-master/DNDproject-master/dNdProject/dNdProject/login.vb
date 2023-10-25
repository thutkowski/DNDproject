Option Explicit On
Option Strict On
Imports System.Data.SqlClient

Public Class login


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=tim;" &
        "server=DESKTOP-QBAILSD\SQLEXPRESS;Integrated Security=SSPI;")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM characters WHERE characterName=" & characterUser

        'Open the connection.
        myConn.Open()
    End Sub

    Private Sub loginActionButton_Click(sender As Object, e As EventArgs) Handles loginActionButton.Click
        characterUser = characterTextBox.Text
    End Sub
End Class