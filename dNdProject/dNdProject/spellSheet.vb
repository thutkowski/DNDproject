Option Explicit On
Option Strict On

Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Windows.Input

Public Class spellSheet


    Private Sub addSpellButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub spellSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT s.spellName FROM spells AS s INNER JOIN 
        spellAssociation ON s.spellName=spellAssociation.spellName 
        WHERE class = @class"

        command.Parameters.AddWithValue("@class", characterClass)
        Dim classSpells As New DataSet()
        Dim da As New SQLiteDataAdapter

        ' Populate the DataSet with the data from the SQLite database
        da.SelectCommand = command
        da.Fill(classSpells)


        spellDataGridView.DataSource = classSpells.Tables(0)
        spellDataGridView.Columns(0).HeaderText = "Spell Name"
        spellDataGridView.RowHeadersVisible = False
        spellDataGridView.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedSpell As String
        selectedSpell = selectedSpellTextBox.Text

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "UPDATE spells SET known = 1 
        WHERE spellName = @spellName"
        command.Parameters.AddWithValue("@spellName", selectedSpell)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
End Class