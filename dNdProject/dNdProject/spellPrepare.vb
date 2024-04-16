Imports System.Data.SQLite
Imports System.Text.RegularExpressions

Public Class spellPrepare
    Private result As New List(Of KeyValuePair(Of String, Object))()
    Private columnNames As New List(Of String)()
    Private spellSlots As New List(Of KeyValuePair(Of Integer, Integer))()
    Private numKnownSpellsMax As Integer

    Private Sub getColumns()
        'SHOULD THIS BE GLOBAL
        openDB()
        Dim command As New SQLiteCommand(connection)
        command.CommandText = $"PRAGMA table_info(spellSlots)"

        rdr = command.ExecuteReader()

        While rdr.Read()
            columnNames.Add(rdr.GetValue(1).ToString())
        End While
        rdr.Close()

        Dim columnString As String = ""
        For Each col As String In columnNames
            columnString += col + " "
        Next
    End Sub

    Private Sub getNumSpells()
        openDB()
        Dim command As New SQLiteCommand(connection)

        Select Case characterClass
            Case "bard", "ranger", "sorcerer", "warlock"
                command.CommandText = "SELECT spellsKnown from spellSlots WHERE class=@class AND level=@level"
                command.Parameters.AddWithValue("@class", characterClass)
                command.Parameters.AddWithValue("@level", level)
                numKnownSpellsMax = (command.ExecuteScalar())
            Case "cleric", "druid"
                numKnownSpellsMax = (wisdomStat - 10) \ 2 + level
                If numKnownSpellsMax < 1 Then
                    numKnownSpellsMax = 1
                End If
            Case "paladain"
                numKnownSpellsMax = (charismaStat - 10) \ 2 + level / 2
                If numKnownSpellsMax < 1 Then
                    numKnownSpellsMax = 1
                End If
            Case "artificer"
                numKnownSpellsMax = (intelligenceStat - 10) \ 2 + level / 2
                If numKnownSpellsMax < 1 Then
                    numKnownSpellsMax = 1
                End If
            Case "wizard"
                numKnownSpellsMax = 0
        End Select
        Label1.Text = "You have " & numKnownSpellsMax & "spells to be known"

    End Sub

    Private Sub getSpellSlots()
        openDB()
        Dim command As New SQLiteCommand(connection)

        command.CommandText = "SELECT * from spellSlots WHERE class=@class AND level=@level"
        command.Parameters.AddWithValue("@class", characterClass)
        command.Parameters.AddWithValue("@level", level)
        rdr = command.ExecuteReader()
        If rdr.HasRows() Then
            rdr.Read()
            For i As Integer = 0 To rdr.FieldCount - 1
                Dim value As Object = rdr.GetValue(i)
                If value IsNot DBNull.Value Then
                    If TypeOf value Is Long Then
                        If Convert.ToInt32(value) <> 0 Then
                            result.Add(New KeyValuePair(Of String, Object)(columnNames(i), Convert.ToInt32(value)))
                        End If
                    ElseIf TypeOf value Is String Then
                        result.Add(New KeyValuePair(Of String, Object)(columnNames(i), value))
                    End If
                End If
            Next
        End If
        rdr.Close()

        For Each kvp As KeyValuePair(Of String, Object) In result
            Dim colName As String = kvp.Key
            Dim colValue As Object = kvp.Value
            If numericRegex(colName) Then
                Dim spellSlot As String = kvp.Key(1)
                spellSlots.Add(New KeyValuePair(Of Integer, Integer)(Convert.ToInt32(spellSlot), Convert.ToInt32(colValue)))
            End If
        Next
    End Sub

    Private Function numericRegex(input As String) As Boolean
        Dim regex = New Regex("_", RegexOptions.IgnoreCase)
        Return regex.IsMatch(input)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getColumns()
        getNumSpells()
        getSpellSlots()
        loadPossibleSpells()
    End Sub

    Private Sub loadPossibleSpells()
        openDB()
        Dim command As New SQLiteCommand(connection)
        Dim maxLevel As Integer = 0

        For Each slot As KeyValuePair(Of Integer, Integer) In spellSlots
            If slot.Key > maxLevel Then
                maxLevel = slot.Key
            End If
        Next

        command.CommandText = "SELECT s.spellName FROM spells as s INNER JOIN
            spellAssociation AS a ON s.spellID=a.SpellID WHERE s.spellID 
            NOT IN (SELECT spellID FROM users WHERE characterID=@characterID) 
            AND a.spellClass=@class AND s.spellLevel=@spellLevel"
        command.Parameters.AddWithValue("@characterID", characterID)
        command.Parameters.AddWithValue("@class", characterClass)
        command.Parameters.AddWithValue("@spellLevel", maxLevel)
        Dim spellName As New DataSet()

        Using da As New SQLiteDataAdapter()
            da.SelectCommand = command
            da.SelectCommand.Connection = connection
            da.Fill(spellName)
        End Using

        availableDGV.DataSource = spellName.Tables(0)
        availableDGV.Columns(0).HeaderText = "Spell Name"
        availableDGV.RowHeadersVisible = False
        availableDGV.ReadOnly = True
        availableDGV.AllowUserToAddRows = False
        availableDGV.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells)
    End Sub

    Private Sub availableDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles availableDGV.CellContentClick
        openDB()
        Dim command As New SQLiteCommand(connection)
        Dim cellValue As Object = availableDGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        'Get the spellID of the clicked on spell
        command.CommandText = "SELECT spellID FROM spells WHERE spellName=@cellValue"
        command.Parameters.AddWithValue("@cellValue", cellValue)
        Dim result As Object = command.ExecuteScalar()
        spellIDQuery = Convert.ToInt32(result)


        'Get number of existing known spells
        command.CommandText = "SELECT * FROM users WHERE characterID=@characterID"
        command.Parameters.AddWithValue("@characterID", characterID)
        rdr = command.ExecuteReader()
        Dim rowCounter As Integer = 0
        While rdr.Read()
            rowCounter += 1
        End While

        'Check if max number of prepared/known spells has been hit
        If rowCounter >= numKnownSpellsMax Then
            MessageBox.Show("You have hit your cap")
            Exit Sub
        End If
        rdr.Close()

        command.CommandText = "INSERT INTO users (characterID,spellID) VALUES (@characterID,@spellID)"
        command.Parameters.AddWithValue("@spellID", spellIDQuery)
        command.Parameters.AddWithValue("@characterID", characterID)

        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
        connection.Close()
        loadPossibleSpells()
        loadPreparedSpells()
    End Sub

    Private Sub loadPreparedSpells()
        openDB()
        Dim command As New SQLiteCommand(connection)

        command.CommandText = "SELECT s.spellName FROM spells AS s 
            INNER JOIN users AS u ON u.spellID = s.spellID WHERE u.characterID = @characterID"
        command.Parameters.AddWithValue("@characterID", characterID)

        Dim spellName As New DataSet()
        Using da As New SQLiteDataAdapter()
            da.SelectCommand = command
            da.SelectCommand.Connection = connection
            da.Fill(spellName)
        End Using

        preparedDGV.DataSource = spellName.Tables(0)
        preparedDGV.Columns(0).HeaderText = "Spell Name"
        preparedDGV.RowHeadersVisible = False
        preparedDGV.ReadOnly = True
        preparedDGV.AllowUserToAddRows = False
        preparedDGV.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells)
    End Sub

    Private Sub prepareSpells_Load(sender As Object, e As EventArgs) Handles Me.Load
        getColumns()
        getNumSpells()
        getSpellSlots()
        loadPreparedSpells()
        loadPossibleSpells()
    End Sub
End Class