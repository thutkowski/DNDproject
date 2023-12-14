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

    'What actually needs to be a global variable
    Public characterUser As String
    Public characterID As Int32
    Public characterName As String
    Public strengthStat As Int32
    Public dexterityStat As Int32
    Public constitutionStat As Int32
    Public intelligenceStat As Int32
    Public wisdomStat As Int32
    Public charismaStat As Int32
    Public characterClass As String

    Public spellIDQuery As Integer

    Public Function checkTableCharactersExist() As Boolean
        openDB()
        command.CommandText = "SELECT * FROM characterInfo"

        Try
            rdr = command.ExecuteReader()
        Catch ex As Exception
            command.CommandText = "CREATE TABLE characters (
                characterID INTEGER  PRIMARY KEY AUTOINCREMENT,
                characterName TEXT
            );"

            command.ExecuteNonQuery()
            connection.Close()

            Return False
        End Try
        rdr.Close()
        Return True
    End Function
    Public Function checkTableCharacterInfoExist() As Boolean
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT * FROM characterInfo"

        Try
            rdr = command.ExecuteReader()
        Catch ex As Exception

            command.CommandText = "CREATE TABLE characterInfo (
                characterID INTEGER,
                characterName TEXT,
                proficiency INTEGER,
                characterClass TEXT,
                background TEXT,
                alignment TEXT,
                initiative INTEGER,
                armorClass INTEGER,
                currentHp INTEGER,
                hpMax INTEGER,
                level INTEGER,
                speed INTEGER
            );
            "

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
        rdr.Close()
        connection.Close()
        Return False
    End Function

    Public Function checkTableCharacterSkillsExist() As Boolean
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT * FROM characterSkills"

        Try
            rdr = command.ExecuteReader()
        Catch ex As Exception

            command.CommandText = "CREATE TABLE characterSkills (
                characterID INTEGER ,
                Survival INTEGER,
                Stealth INTEGER,
                Sleight INTEGER,
                Religion INTEGER,
                Persuasion INTEGER,
                Performance INTEGER,
                Perception INTEGER,
                Nature INTEGER,
                Medicine INTEGER,
                Investigation INTEGER,
                Intimidation INTEGER,
                History INTEGER,
                Deception INTEGER,
                Athletics INTEGER,
                Arcana INTEGER,
                Animal INTEGER,
                Acrobatics INTEGER
            );
            "

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
        rdr.Close()
        connection.Close()
        Return False
    End Function

    Public Function checkTableCharacterStatsExist() As Boolean
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT * FROM characterStats"

        Try
            rdr = command.ExecuteReader()
        Catch ex As Exception

            command.CommandText = "CREATE TABLE characterStats(characterID  INTEGER ,
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
        rdr.Close()
        connection.Close()
        Return False
    End Function

    Public Function loginActionFunction(username) As Boolean
        openDB()

        'Queries character list 
        command.CommandText = "SELECT characterID FROM characters WHERE characterName = @Username"
        command.Parameters.AddWithValue("@Username", username)
        characterID = command.ExecuteScalar()

        'Checks if the query returned any rows
        If characterID Then
            rdr.Close()
            connection.Close()
            Return True
        Else
            MessageBox.Show("That character does not exist")
            rdr.Close()
            connection.Close()
            Return False
        End If
    End Function

    Public Function AreAnyTextBoxesEmpty(controls As Control.ControlCollection) As Boolean
        ' Loop through all of the text boxes and check if any of them are empty.

        For Each textBox As Control In controls.OfType(Of TextBox)
            If textBox.Text = "" Then
                Return True
            End If
        Next

        ' If none of the text boxes are empty, return False.
        Return False
    End Function

    Public Sub openDB()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub
End Module
