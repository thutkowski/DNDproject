Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Text.RegularExpressions

Public Class spellCast
    Private result As New List(Of KeyValuePair(Of String, Object))()
    Private spellSlots As New List(Of KeyValuePair(Of String, Integer))()
    Private columnNames As New List(Of String)()

    Private Sub getColumns()
        openDB()
        'MAKE GLOBAL
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

    Private Sub getKvp()
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
                spellSlots.Add(New KeyValuePair(Of String, Integer)(spellSlot, Convert.ToInt32(colValue)))
            End If
        Next
    End Sub

    Private Function numericRegex(input As String) As Boolean
        Dim regex = New Regex("_", RegexOptions.IgnoreCase)
        Return regex.IsMatch(input)
    End Function

    Private Sub buildMessage()
        Dim spellSlotMessage As String = ""
        Dim warlockSlots As String = ""
        Dim warlockLevel As String = ""
        Dim slotS As String = "s"
        Dim ordinal As String = ""
        Dim numCantrips As Integer = 0
        For Each kvp As KeyValuePair(Of String, Object) In result

            Dim colName As String = kvp.Key
            Dim colValue As Object = kvp.Value
            If colName = "cantrips" Then
                numCantrips = Convert.ToInt32(colValue)
            End If
            If Convert.ToInt32(numCantrips) = 1 Then
                slotS = ""
            End If

            If colName = "spellSlots" Then
                warlockSlots = colValue
                If colValue = 1 Then
                    slotS = ""
                End If
            End If
            If colName = "slotLevel" Then
                warlockLevel = colValue
                If Convert.ToInt32(warlockLevel) = 1 Then
                    ordinal = "1st"
                ElseIf Convert.ToInt32(warlockLevel) = 2 Then
                    ordinal = "2nd"
                ElseIf Convert.ToInt32(warlockLevel) = 3 Then
                    ordinal = "3rd"
                Else
                    ordinal = warlockLevel & "th"
                End If
            End If
            If numericRegex(colName) Then
                Dim slotLevel As String = colName(1)
                If colValue = 1 Then
                    slotS = ""
                End If
                If Convert.ToInt32(slotLevel) = 1 Then
                    ordinal = "1st"
                ElseIf Convert.ToInt32(slotLevel) = 2 Then
                    ordinal = "2nd"
                ElseIf Convert.ToInt32(slotLevel) = 3 Then
                    ordinal = "3rd"
                Else
                    ordinal = slotLevel & "th"
                End If

                spellSlotMessage += "You have " & colValue & " " & ordinal & " level spell slot" & slotS & "."
            End If
        Next
        If warlockLevel <> "" Then
            spellSlotMessage += "You have " & warlockSlots & " " & ordinal & " level spell slot" & slotS & "."
        End If
        spellSlotMessage += "You have " & numCantrips & " cantrip" & slotS & " available."
        displayTextBox.Text += spellSlotMessage
    End Sub

    Private Sub spellQuery(level As Integer, charClass As String)
        Dim conditions As New List(Of String)
        Dim command As New SQLiteCommand(connection)

        Dim sqlQuery As String = "SELECT s.spellName FROM spells AS s INNER JOIN 
        spellAssociation as a ON s.spellID=a.spellID"
        conditions.Add($"a.spellClass =" & charClass)
        conditions.Add($"a.level =" & level.ToString())
        sqlQuery = "SELECT s.spellName FROM spells AS s INNER JOIN 
        spellAssociation as a ON s.spellID=a.spellID"

        If conditions.Count > 0 Then
            Dim whereQuery As String = String.Join(" AND ", conditions)
            sqlQuery = $"{sqlQuery} WHERE {whereQuery}"
        Else
            sqlQuery = "select spellName from spells"
        End If
        command.CommandText = sqlQuery
    End Sub

    Private Sub createSpellSlot()
        Dim command As New SQLiteCommand(connection)
        Dim yPosition As Integer = 0
        Dim panelYposition As Integer = 10

        For Each kvp As KeyValuePair(Of String, Integer) In spellSlots
            Dim slotX As Integer = 160
            Dim slotPanel As New Panel
            slotPanel.Location = New Point(0, panelYposition)
            slotPanel.Size = New Size(500, 30)
            If rdr IsNot Nothing AndAlso Not rdr.IsClosed Then
                rdr.Close()
            End If
            spellQuery(kvp.Key, characterClass)
            command.CommandText = "SELECT s.spellNAme FROM spells AS s 
                     INNER JOIN users AS u ON s.spellID=u.spellID WHERE s.spellLevel = @spellLevel"
            command.Parameters.Clear() ' Clear any previous parameters
            command.Parameters.AddWithValue("@spellLevel", kvp.Key)
            rdr = command.ExecuteReader()
            Dim label As New Label()
            label.Text = kvp.Key
            label.AutoSize = True
            label.Location = New Point(10, yPosition)
            slotPanel.Controls.Add(label)

            Dim comboBox As New ComboBox()
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList
            comboBox.Location = New Point(30, yPosition)
            slotPanel.Controls.Add(comboBox)

            For i As Integer = 1 To kvp.Value
                Dim checkBox As New CheckBox()
                checkBox.Size = New Size(20, 20)
                checkBox.Location = New Point(slotX, yPosition)
                slotX += 20
                slotPanel.Controls.Add(checkBox)
            Next

            Dim castButton As New Button()
            castButton.Text = "Cast spell"
            castButton.Location = New Point(slotX, yPosition)
            AddHandler castButton.Click, AddressOf CastButtonClick
            slotPanel.Controls.Add(castButton)
            While rdr.Read()
                comboBox.Items.Add(rdr.GetValue(0).ToString())
            End While
            panelYposition += 30
            spellSlotPanel.Controls.Add(slotPanel)
        Next
        rdr.Close()
    End Sub

    Private Sub displaySpellInfo(spellName)
        openDB()
        Dim command As New SQLiteCommand(connection)
        Dim cellValue As String = spellName
        Dim resultString As String = ""
        command.CommandText = "Select spellID from spells WHERE spellName=@spellName"
        command.Parameters.AddWithValue("@spellName", spellName)
        Dim result As Object = command.ExecuteScalar()

        spellIDQuery = Convert.ToInt32(result)
        command.CommandText = "SELECT spellName,source, spellLevel,castingTime ,
        components,spellRange,school ,duration,description,higherLevel 
        FROM spells WHERE spellID = @spellID"
        command.Parameters.AddWithValue("@spellID", spellIDQuery)

        rdr = command.ExecuteReader

        While rdr.Read()
            resultString &= "Spell Name: " & rdr.GetString(0) & "         "
            resultString &= "Source: " & rdr.GetString(1) & vbCrLf
            resultString &= "Spell Level: " & rdr.GetString(2) & vbCrLf
            resultString &= "Casting Time: " & rdr.GetString(3) & vbCrLf
            resultString &= "Components: " & rdr.GetString(4) & vbCrLf
            resultString &= "Range: " & rdr.GetString(5) & vbCrLf
            resultString &= "School: " & rdr.GetString(6) & vbCrLf
            resultString &= "Duration: " & rdr.GetString(7) & vbCrLf
            resultString &= "Description: " & rdr.GetString(8) & vbCrLf
            resultString &= "At Higher Level: " & rdr.GetString(9) & vbCrLf
        End While

        rdr.Close()
        connection.Close()

        displayTextBox.Text = resultString
    End Sub

    Private Sub CastButtonClick(sender As Object, e As EventArgs)
        Dim clickedButton As Button = DirectCast(sender, Button)
        Dim slotPanel As Panel = DirectCast(clickedButton.Parent, Panel)
        Dim comboBox As ComboBox = slotPanel.Controls.OfType(Of ComboBox)().FirstOrDefault()

        If comboBox.SelectedIndex <> -1 Then
            Dim selectedSpell As String = comboBox.SelectedItem.ToString()
            Dim numCheckBoxes As Integer = 0
            Dim numChecked As Integer = 0
            For Each control As Control In slotPanel.Controls
                If TypeOf control Is CheckBox Then
                    numCheckBoxes += 1
                    Dim checkbox As CheckBox = DirectCast(control, CheckBox)
                    If Not checkbox.Checked Then
                        displaySpellInfo(selectedSpell)
                        checkbox.Checked = True

                        Exit Sub
                    Else
                        numChecked += 1
                    End If

                End If
            Next
            If numChecked = numChecked Then
                MessageBox.Show("All spell slots used")
            End If
        End If

    End Sub


    Private Sub spellCast_Load(sender As Object, e As EventArgs) Handles Me.Load
        getColumns()
        getKvp()
        createSpellSlot()
    End Sub
End Class