Imports System.Data.SQLite
Public Class Form1
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "DND.db"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private consString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(consString)
    Private command As New SQLiteCommand("", connection)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()

        command.Connection = connection
        command.CommandText = "Select * from tbl1"

        Dim rdr As SQLiteDataReader = command.ExecuteReader
        Using rdr
            While (rdr.Read())
                MsgBox((rdr.GetInt32(0) & rdr.GetString(1) & rdr.GetInt32(2)))
            End While

        End Using

        connection.Close()
        'If connection.State = ConnectionState.Open Then
        '    MsgBox("The connection is: " & connection.State.ToString)
        'End If
    End Sub




End Class
