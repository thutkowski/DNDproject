Imports System.Data.SQLite

Module codeModule
    Public dbCommand As String = ""
    Public bindingSrc As BindingSource
    Public dbName As String = "DND.db"
    Public dbPath As String = Application.StartupPath & "\" & dbName
    Public consString As String = "Data Source=" & dbPath & ";Version=3"
    Public connection As New SQLiteConnection(consString)

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
    Public profBonus As Integer
    Public background As String
    Public alignment As String
    Public initiative As Int32
    Public armorClass As Int32
    Public currentHp As Int32
    Public hpMax As Int32
    Public level As Int32
    Public speed As Int32
    Public spellIDQuery As Integer

    Public Function checkTableCharactersExist() As Boolean
        openDB()
        Dim command As New SQLiteCommand(connection)
        command.CommandText = "SELECT * FROM characters"

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
        If rdr.HasRows Then
            rdr.Close()
            connection.Close()
            Return True
        End If
        rdr.Close()
        connection.Close()
        Return False
    End Function
    Public Sub createUsersTable()
        openDB()
        Dim command As New SQLiteCommand(connection)

        command.CommandText = "SELECT * From users"
        Try
            rdr = command.ExecuteReader()
            rdr.Close()
        Catch ex As Exception
            command.CommandText = "CREATE TABLE users (characterID INTEGER ,
        spellID INTEGER,PRIMARY KEY (characterID,spellID))"
            command.ExecuteNonQuery()
            connection.Close()
        End Try
        connection.Close()

    End Sub
    Public Function checkTableCharacterInfoExist() As Boolean
        openDB()
        Dim command As New SQLiteCommand(connection)

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
        End Try
        If rdr.HasRows Then
            rdr.Close()
            connection.Close()
            Return True
        End If
        rdr.Close()
        connection.Close()
        Return False
    End Function

    Public Function checkTableCharacterSkillsExist() As Boolean
        openDB()
        Dim command As New SQLiteCommand(connection)

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
            );"

            command.ExecuteNonQuery()
            connection.Close()
            Return False
        End Try

        rdr.Close()
        connection.Close()
        Return True
    End Function

    Public Function checkTableCharacterStatsExist() As Boolean
        openDB()
        Dim command As New SQLiteCommand(connection)

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
        End Try
        If rdr.HasRows Then
            rdr.Close()
            connection.Close()
            Return True
        End If
        rdr.Close()
        connection.Close()
        Return False
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
