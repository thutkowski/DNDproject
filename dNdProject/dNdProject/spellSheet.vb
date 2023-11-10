Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Windows.Input

Public Class spellSheet

    Private Sub spellSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If



        command.CommandText = "SELECT * FROM spellsNonAttack"
        If rdr.IsClosed Then
            rdr.
        Else
            command.CommandText = "SELECT * FROM spellsNonAttack"
            Dim da As New SQLiteDataAdapter()

            da.SelectCommand = command
            Dim dt As New DataTable
            da.Fill(dt)
            spellDataGridView.DataSource = dt
            spellDataGridView.AutoGenerateColumns = True
            connection.Close()
            End If
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

    Public Function AreAnyTextBoxesEmpty() As Boolean
        ' Loop through all of the text boxes and check if any of them are empty.

        For Each textBox As Control In Me.Controls.OfType(Of TextBox)
            If textBox.Text = "" Then
                Return True
            End If
        Next

        ' If none of the text boxes are empty, return False.
        Return False
    End Function
    Private Sub addSpellButton_Click(sender As Object, e As EventArgs) Handles addSpellButton.Click
        If AreAnyTextBoxesEmpty() Then
            MessageBox.Show("One or more text boxes are empty. Cannot save character unless all are filled.")
        End If
        Dim spellName, spellType, spellLevel, spellAttack As String
        Dim range, duration As Integer

        spellName = spellNameTextBox.Text
        spellType = spellTypeTextBox.Text
        spellLevel = spellLevelTextBox.Text
        spellAttack = spellAttackTextBox.Text
        range = Convert.ToInt32(spellRangeTextBox.Text)
        duration = Convert.ToInt32(spellDurationTextBox.Text)

    End Sub

End Class