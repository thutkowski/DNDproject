Option Explicit On
Option Strict On

Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Windows.Input

Public Class spellSheet
    Private Sub spellSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT * FROM allSpells WHERE known=1"
        Dim da As New SQLiteDataAdapter()

        da.SelectCommand = command
        Dim dt As New DataTable
        da.Fill(dt)
        spellDataGridView.DataSource = dt
        spellDataGridView.AutoGenerateColumns = True
        connection.Close()
    End Sub

    Private Sub spellAbilityComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles spellAbilityComboBox.SelectedIndexChanged
        Dim spellAbility As String
        Dim spellAttackModifer As Integer
        spellAbility = spellAbilityComboBox.SelectedText

        Select Case spellAbility
            Case "Strength"
                spellAttackModifer = Convert.ToInt32(strengthStat)
            Case "Dexterity"
                spellAttackModifer = Convert.ToInt32(dexterityStat)
            Case "Constitution"
                spellAttackModifer = Convert.ToInt32(constitutionStat)
            Case "Intelligence"
                spellAttackModifer = Convert.ToInt32(intelligenceStat)
            Case "Wisdom"
                spellAttackModifer = Convert.ToInt32(wisdomStat)
            Case "Charisma"
                spellAttackModifer = Convert.ToInt32(charismaStat)
        End Select


    End Sub


    Private Sub addSpellButton_Click(sender As Object, e As EventArgs) Handles addSpellButton.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim spellName As String
        Dim results As String

        spellName = spellNameTextBox.Text
        command.CommandText = "SELECT spellID FROM allSpells WHERE spellName=@spellName"
        command.Parameters.AddWithValue("@spellName", spellName)
        If command.ExecuteScalar() Is Nothing Then
            MessageBox.Show("Spell name not found in list from 5e", "Spell not found")
        End If
        results = Convert.ToString(command.ExecuteScalar())
        MessageBox.Show(results)
        command.CommandText = "UPDATE allSpells SET known =1 
        WHERE spellID=@spellID"
        command.Parameters.AddWithValue("@spellID", results)
        command.ExecuteNonQuery()
    End Sub

End Class