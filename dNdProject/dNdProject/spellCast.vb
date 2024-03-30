﻿Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Text.RegularExpressions

Public Class spellCast
    Private result As New List(Of KeyValuePair(Of String, Object))()
    Private spellSlots As New List(Of KeyValuePair(Of String, Integer))()

    Private columnNames As New List(Of String)()

    Private Sub getColumns()
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
        Dim resultString As String = ""
        openDB()

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
            resultString += colName & ": " & colValue & " "
        Next
        displayTextBox.Text = resultString
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

        Dim sqlQuery As String = "SELECT s.spellName FROM spells AS s INNER JOIN 
        spellAssociation as a ON s.spellName=a.spellName"
        conditions.Add($"a.class =" & charClass)
        conditions.Add($"a.level =" & level.ToString())
        sqlQuery = "SELECT s.spellName FROM spells AS s INNER JOIN 
        spellAssociation as a ON s.spellName=a.spellName"

        If conditions.Count > 0 Then
            Dim whereQuery As String = String.Join(" AND ", conditions)
            sqlQuery = $"{sqlQuery} WHERE {whereQuery}"
        Else
            sqlQuery = "select spellName from spells"
        End If
        command.CommandText = sqlQuery
    End Sub
    Private Sub createSpellSlot()
        Dim yPosition As Integer = 10
        MessageBox.Show(command.CommandText)
        For Each kvp As KeyValuePair(Of String, Integer) In spellSlots
            If rdr IsNot Nothing AndAlso Not rdr.IsClosed Then
                rdr.Close()
            End If
            spellQuery(kvp.Key, characterClass)
            command.CommandText = "SELECT spellName from spells where spellLevel = @spellLevel AND  known ='1'"
            command.Parameters.Clear() ' Clear any previous parameters
            command.Parameters.AddWithValue("@spellLevel", kvp.Key)
            MessageBox.Show(command.CommandText)
            rdr = command.ExecuteReader()
            Dim label As New Label()
            label.Text = kvp.Key
            label.AutoSize = True
            label.Location = New Point(10, yPosition)
            spellSlotPanel.Controls.Add(label)

            Dim comboBox As New ComboBox()
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList
            comboBox.Location = New Point(40, yPosition)
            spellSlotPanel.Controls.Add(comboBox)

            Dim castButton As New Button()
            castButton.Text = "Cast spell"
            While rdr.Read()
                comboBox.Items.Add(rdr.GetValue(0).ToString())
            End While
            yPosition += 30
        Next
        rdr.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getColumns()
        getKvp()
        buildMessage()
        createSpellSlot()
    End Sub
End Class