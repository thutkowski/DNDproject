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
End Module
