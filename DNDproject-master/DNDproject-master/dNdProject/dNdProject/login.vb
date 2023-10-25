Option Explicit On
Option Strict On


Public Class login
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles MyBaseButton.Click
        characterUser = characterTextBox.Text
    End Sub

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
End Class