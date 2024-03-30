Option Explicit On
Option Strict On

Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Windows.Input

Public Class spellMenu
    Private Sub spellSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        openDB()

        command.CommandText = "SELECT spellID,spellName FROM spells  "

        Dim classSpells As New DataSet()
        Dim da As New SQLiteDataAdapter

        ' Populate the DataSet with the data from the SQLite database
        da.SelectCommand = command
        da.Fill(classSpells)

        classSpells.Tables(0).Columns("spellID").ColumnMapping = MappingType.Hidden
        spellDataGridView.DataSource = classSpells.Tables(0)
        spellDataGridView.Columns(0).HeaderText = "Spell Name"
        spellDataGridView.RowHeadersVisible = False
        spellDataGridView.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells)

    End Sub

    Private Sub spellDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles spellDataGridView.CellContentClick
        openDB()
        Dim cellValue As Object = spellDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        command.CommandText = "Select spellID from spells WHERE spellName=@cellValue"
        command.Parameters.AddWithValue("@cellValue", cellValue)
        Dim result As Object = command.ExecuteScalar()

        spellIDQuery = Convert.ToInt32(result)

        Dim newSpellQueryForm As New spellQueryForm() ' Assuming SpellQueryForm is the name of your form class
        newSpellQueryForm.Show()

    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        spellDataGridView.DataSource = Nothing
        openDB()

        Dim conditions As New List(Of String)

        Dim sqlQuery As String = "SELECT s.spellName FROM spells AS s INNER JOIN 
        spellAssociation as a ON s.spellName=a.spellName"

        If Not String.IsNullOrEmpty(classTextBox.Text) Then
            conditions.Add($"a.class ='{classTextBox.Text}'")
            If Not String.IsNullOrEmpty(levelTextBox.Text) Then
                conditions.Add($"s.spellLevel ='{levelTextBox.Text}'")
            End If
            sqlQuery = "SELECT s.spellName FROM spells AS s INNER JOIN 
        spellAssociation as a ON s.spellName=a.spellName"
        Else
            sqlQuery = "select spellName from spells"
            If Not String.IsNullOrEmpty(levelTextBox.Text) Then
                conditions.Add($"spellLevel ='{levelTextBox.Text}'")
            End If
        End If


        If conditions.Count > 0 Then
            Dim whereQuery As String = String.Join(" AND ", conditions)
            sqlQuery = $"{sqlQuery} WHERE {whereQuery}"
        Else
            sqlQuery = "select spellName from spells"
        End If
        MessageBox.Show(sqlQuery)
        Dim classSpells As New DataSet()
        Dim da As New SQLiteDataAdapter
        command.CommandText = sqlQuery
        ' Populate the DataSet with the data from the SQLite database
        da.SelectCommand = command
        da.Fill(classSpells)

        spellDataGridView.DataSource = classSpells.Tables(0)
        spellDataGridView.Columns(0).HeaderText = "Spell Name"
        spellDataGridView.RowHeadersVisible = False
        spellDataGridView.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim selectedSpell As String
        'selectedSpell = selectedSpellTextBox.Text

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