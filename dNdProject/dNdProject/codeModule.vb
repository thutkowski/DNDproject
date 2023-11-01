Imports System.Data.SQLite

Module codeModule
    Public dbCommand As String = ""
    Public bindingSrc As BindingSource
    Public dbName As String = "DND.db"
    Public dbPath As String = Application.StartupPath & "\" & dbName
    Public consString As String = "Data Source=" & dbPath & ";Version=3"
    Public connection As New SQLiteConnection(consString)
    Public command As New SQLiteCommand("", connection)
    Public rdr As SQLiteDataReader

    Public characterUser As String
    Public characterID As Int32
    Public characterName As String
    Public strengthStat As Int32
    Public dexerityStat As Int32
    Public constitutionStat As Int32
    Public intelligenceStat As Int32
    Public wisdomStat As Int32
    Public charismaStat As Int32

    Public Function characterStatsFunction(characterUser As String) As Boolean
        connection.Open()

        command.CommandText = "SELECT * FROM characters WHERE characterName = @Username"

        command.Parameters.AddWithValue("@Username", characterUser)

        rdr = command.ExecuteReader()

        rdr.Read()
        characterID = rdr.GetInt32(0)
        characterName = rdr.GetString(1)
        strengthStat = rdr.GetInt32(2).ToString
        dexerityStat = rdr.GetInt32(3).ToString
        constitutionStat = rdr.GetInt32(4).ToString
        intelligenceStat = rdr.GetInt32(5).ToString
        wisdomStat = rdr.GetInt32(6).ToString
        charismaStat = rdr.GetInt32(7).ToString
        Return True
    End Function

    Public Function checkTableCharactersExistFunction()
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT * FROM characters"

        Try
            rdr = command.ExecuteReader()
        Catch ex As Exception
            command.CommandText = "CREATE TABLE characters(characterID   INTEGER PRIMARY KEY AUTOINCREMENT,
            characterName TEXT,
            stren         INTEGER,
            dex           INTEGER,
            con           INTEGER,
            intel         INTEGER,
            wisdom        INTEGER,
            charisma      INTEGER
            );"

            command.ExecuteNonQuery()
            connection.Close()
            Return False
            Exit Function
        End Try

        If rdr.Read() Then
            rdr.Close()
            connection.Close()
            Return True
        End If
    End Function

    Public Function loginActionFunction(username)
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT * FROM characters WHERE characterName = @Username"
        command.Parameters.AddWithValue("@Username", username)
        rdr = command.ExecuteReader()

        If rdr.Read() Then
            rdr.Close()
            connection.Close()
            characterSheet.Show()
        Else
            MessageBox.Show("That character does not exist")
            rdr.Close()
            connection.Close()
        End If
    End Function

    Public Function saveFunction()

    End Function
End Module
