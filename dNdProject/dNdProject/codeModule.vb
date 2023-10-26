Imports System.Data.SQLite

Module codeModule
    Public characterUser As String

    Public dbCommand As String = ""
    Public bindingSrc As BindingSource

    Public dbName As String = "DND.db"
    Public dbPath As String = Application.StartupPath & "\" & dbName
    Public consString As String = "Data Source=" & dbPath & ";Version=3"

    Public connection As New SQLiteConnection(consString)
    Public command As New SQLiteCommand("", connection)
    Public rdr As SQLiteDataReader

    Public Function loginFunction(username As String) As Boolean
        connection.Open()

        command.CommandText = "SELECT * FROM characters WHERE characterName = @Username"

        command.Parameters.AddWithValue("@Username", username)

        rdr = command.ExecuteReader()

        If rdr.Read() Then
            Return True
        Else
            Return False
        End If
    End Function


End Module
