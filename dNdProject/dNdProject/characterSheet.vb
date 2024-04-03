Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Data.Entity.Core
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Security.Cryptography


Public Class characterSheet
    'Skill Scores to update modifer scores
    Private Sub strenTextBox_TextChanged(sender As Object, e As EventArgs) Handles strenTextBox.TextChanged
        Dim modifer As Integer

        If strenTextBox.Text = "" Then
            Exit Sub
        End If

        Try
            modifer = Convert.ToInt32(strenTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Invalid format enter only integers")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try

        modifer = (modifer - 10) \ 2
        strenModiferLabel.Text = Convert.ToString(modifer)
    End Sub
    Private Sub dexTextBox_TextChanged(sender As Object, e As EventArgs) Handles dexTextBox.TextChanged
        Dim modifer As Integer

        If dexTextBox.Text = "" Then
            Exit Sub
        End If

        Try
            modifer = Convert.ToInt32(dexTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Invalid format enter only integers")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try

        modifer = (modifer - 10) \ 2
        dexModiferLabel.Text = Convert.ToString(modifer)
    End Sub
    Private Sub conTextBox_TextChanged(sender As Object, e As EventArgs) Handles conTextBox.TextChanged
        Dim modifer As Integer

        If conTextBox.Text = "" Then
            Exit Sub
        End If

        Try
            modifer = Convert.ToInt32(conTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Invalid format enter only integers")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try

        modifer = (modifer - 10) \ 2
        conModiferLabel.Text = Convert.ToString(modifer)
    End Sub
    Private Sub intelTextBox_TextChanged(sender As Object, e As EventArgs) Handles intelTextBox.TextChanged
        Dim modifer As Integer

        If intelTextBox.Text = "" Then
            Exit Sub
        End If

        Try
            modifer = Convert.ToInt32(intelTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Invalid format enter only integers")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try

        modifer = (modifer - 10) \ 2
        intelModiferLabel.Text = Convert.ToString(modifer)
    End Sub
    Private Sub wisdomTextBox_TextChanged(sender As Object, e As EventArgs) Handles wisdomTextBox.TextChanged
        Dim modifer As Integer

        If wisdomTextBox.Text = "" Then
            Exit Sub
        End If

        Try
            modifer = Convert.ToInt32(wisdomTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Invalid format enter only integers")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try

        modifer = (modifer - 10) \ 2
        wisdomModiferLabel.Text = Convert.ToString(modifer)
    End Sub
    Private Sub charismaTextBox_TextChanged(sender As Object, e As EventArgs) Handles charismaTextBox.TextChanged
        Dim modifer As Integer

        If charismaTextBox.Text = "" Then
            Exit Sub
        End If

        Try
            modifer = Convert.ToInt32(charismaTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Invalid format enter only integers")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try

        modifer = (modifer - 10) \ 2
        charModiferLabel.Text = Convert.ToString(modifer)
    End Sub
    'Dice Roll w/Modifer
    Public Function strenD20roll() As Integer

        Dim roll As Integer
        Dim rnd As New Random
        roll = rnd.Next(0, 21)
        roll = Convert.ToInt32(strenModiferLabel.Text) + roll
        Return roll

    End Function
    Public Function dexD20roll() As Integer

        Dim roll As Integer
        Dim rnd As New Random
        roll = rnd.Next(1, 21)
        roll = Convert.ToInt32(dexModiferLabel.Text) + roll
        Return roll

    End Function
    Public Function wisomD20roll() As Integer

        Dim roll As Integer
        Dim rnd As New Random
        roll = rnd.Next(0, 21)
        roll = Convert.ToInt32(wisdomModiferLabel.Text) + roll
        Return roll

    End Function
    Public Function intelD20roll() As Integer

        Dim roll As Integer
        Dim rnd As New Random
        roll = rnd.Next(0, 21)
        roll = Convert.ToInt32(intelModiferLabel.Text) + roll
        Return roll

    End Function
    Public Function charD20roll() As Integer

        Dim roll As Integer
        Dim rnd As New Random
        roll = rnd.Next(0, 21)
        roll = Convert.ToInt32(charModiferLabel.Text) + roll
        Return roll

    End Function
    'Profiency Bonus
    Private Sub profTextBox_TextChanged(sender As Object, e As EventArgs) Handles profTextBox.TextChanged
        If profTextBox.Text = "" Then
            Exit Sub
        End If

        Try
            profBonus = Convert.ToInt32(profTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Invalid format enter only integers")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try
    End Sub
    'Skill Checks
    Private Sub acrobacticsButton_Click(sender As Object, e As EventArgs) Handles acrobacticsButton.Click
        Dim roll As Integer = dexD20roll()

        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub animalButton_Click(sender As Object, e As EventArgs) Handles animalButton.Click
        Dim roll As Integer = wisomD20roll()

        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub arcanaButton_Click(sender As Object, e As EventArgs) Handles arcanaButton.Click
        Dim roll As Integer = intelD20roll()

        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub athleticsButton_Click(sender As Object, e As EventArgs) Handles athleticsButton.Click
        Dim roll As Integer = strenD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub deceptionButton_Click(sender As Object, e As EventArgs) Handles deceptionButton.Click
        Dim roll As Integer = charD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub historyButton_Click(sender As Object, e As EventArgs) Handles historyButton.Click
        Dim roll As Integer = intelD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub intimidationButton_Click(sender As Object, e As EventArgs) Handles intimidationButton.Click
        Dim roll As Integer = charD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub investigationButton_Click(sender As Object, e As EventArgs) Handles investigationButton.Click
        Dim roll As Integer = intelD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub medicineButton_Click(sender As Object, e As EventArgs) Handles medicineButton.Click
        Dim roll As Integer = wisomD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub natureButton_Click(sender As Object, e As EventArgs) Handles natureButton.Click
        Dim roll As Integer = intelD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub perceptionButton_Click(sender As Object, e As EventArgs) Handles perceptionButton.Click
        Dim roll As Integer = wisomD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub performanceButton_Click(sender As Object, e As EventArgs) Handles performanceButton.Click
        Dim roll As Integer = charD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub persuasionButton_Click(sender As Object, e As EventArgs) Handles persuasionButton.Click
        Dim roll As Integer = charD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub religiomButton_Click(sender As Object, e As EventArgs) Handles religiomButton.Click
        Dim roll As Integer = intelD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub

    Private Sub sleightButton_Click(sender As Object, e As EventArgs) Handles sleightButton.Click
        Dim roll As Integer = dexD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub Buttonstealth_Click(sender As Object, e As EventArgs) Handles Buttonstealth.Click
        Dim roll As Integer = dexD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub
    Private Sub survivalButton_Click(sender As Object, e As EventArgs) Handles survivalButton.Click
        Dim roll As Integer = wisomD20roll()
        If acrobacticsCheckBox.Checked = True Then
            rollTextBox.Text = Convert.ToString(roll + profBonus)
        Else
            rollTextBox.Text = Convert.ToString(roll)
        End If
    End Sub

    Private Sub getCharacterStats()
        openDB()
        Dim command As New SQLiteCommand(connection)
        'Query character list with character name
        command.CommandText = "SELECT * FROM characterStats WHERE characterID = @characterID"
        command.Parameters.AddWithValue("@characterID", characterID)
        rdr = command.ExecuteReader()
        If rdr.HasRows Then
            rdr.Read()
            strenTextBox.Text = rdr.GetInt32(1).ToString
            dexTextBox.Text = rdr.GetInt32(2).ToString
            conTextBox.Text = rdr.GetInt32(3).ToString
            wisdomTextBox.Text = rdr.GetInt32(5).ToString
            intelTextBox.Text = rdr.GetInt32(4).ToString
            charismaTextBox.Text = rdr.GetInt32(6).ToString
        End If
        rdr.Close()

    End Sub

    Private Sub getCharacterInfo()
        openDB()
        Dim command As New SQLiteCommand(connection)
        'Query character list with character name
        command.CommandText = "SELECT * FROM characterInfo WHERE characterID = @characterID"
        command.Parameters.AddWithValue("@characterID", characterID)
        rdr = command.ExecuteReader()
        If rdr.HasRows Then
            rdr.Read()
            characterNameTextBox.Text = rdr.GetString(1)
            profTextBox.Text = rdr.GetInt32(2).ToString
            classTextBox.Text = rdr.GetString(3)
            backgroundTextBox.Text = rdr.GetString(4)
            alignmentTextBox.Text = rdr.GetString(5)
            iniativeTextBox.Text = rdr.GetInt32(6).ToString
            armorClassTextBox.Text = rdr.GetInt32(7).ToString
            currentHpTextBox.Text = rdr.GetInt32(8).ToString
            hpMaxTextBox.Text = rdr.GetInt32(9).ToString
            levelTextBox.Text = rdr.GetInt32(10).ToString
            speedTextBox.Text = rdr.GetInt32(11).ToString
        End If
        rdr.Close()
    End Sub

    Private Sub getCharacterSkills()
        openDB()
        Dim command As New SQLiteCommand(connection)

        'Query character list with character name
        command.CommandText = "SELECT * FROM characterSkills WHERE characterID = @characterID"
        command.Parameters.AddWithValue("@characterID", characterID)
        rdr = command.ExecuteReader()
        If rdr.HasRows Then
            rdr.Read()
            survivalCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(1))
            stealthCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(2))
            sleightCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(3))
            religionCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(4))
            persuasionCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(5))
            performanceCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(6))
            perceptionCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(7))
            natureCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(8))
            medicineCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(9))
            investigationCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(10))
            intimidationCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(11))
            historyCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(12))
            deceptionCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(13))
            athleticsCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(14))
            arcanaCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(15))
            animalCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(16))
            acrobacticsCheckBox.Checked = Convert.ToBoolean(rdr.GetInt32(16))
        End If
        rdr.Close()
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
            ' Populate the DataSet with the data from the SQLite database
            da.Fill(spellName)
        End Using

        spellDataGridView.DataSource = spellName.Tables(0)
        spellDataGridView.Columns(0).HeaderText = "Spell Name"
        spellDataGridView.RowHeadersVisible = False
        spellDataGridView.ReadOnly = True
        spellDataGridView.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells)
    End Sub



    Public Function AreAnyTextBoxesEmpty() As Boolean
        ' Loop through all of the text boxes and check if any of them are empty.
        For Each Panel As Panel In Me.Controls.OfType(Of Panel)
            For Each textBox As Control In Panel.Controls.OfType(Of TextBox)
                If textBox.Text = "" Then
                    Return True
                End If
            Next
        Next

        ' If none of the text boxes are empty, return False.
        Return False
    End Function

    Private Sub characterSheet_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If AreAnyTextBoxesEmpty() = True Then
            MessageBox.Show("One or more text boxes are empty. Cannot save character unless all are filled.")
            e.Cancel = True
        End If
    End Sub

    Private Sub spellSheetButton_Click(sender As Object, e As EventArgs) Handles spellSheetButton.Click
        characterClass = classTextBox.Text
        level = Convert.ToInt32(levelTextBox.Text)
        spellMenu.Show()
    End Sub

    Private Sub spellDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles spellDataGridView.CellContentClick
        spellIDQuery = e.RowIndex
        spellQueryForm.ShowDialog()
    End Sub

    Private Function checkCharacterStatsExists(ByVal charName As String) As Boolean
        openDB()
        Dim command As New SQLiteCommand(connection)

        command.CommandText = "SELECT * FROM characterStats WHERE characterID = @characterID"
        command.Parameters.AddWithValue("@characterID", characterID)

        If command.ExecuteScalar Is Nothing Then
            connection.Close()
            Return False
        Else
            connection.Close()
            Return True
        End If
    End Function

    Private Function checkCharacterSkillsExists(ByVal charName As String) As Boolean
        openDB()
        Dim command As New SQLiteCommand(connection)

        command.CommandText = "SELECT * FROM CharacterSkills WHERE characterID = @characterID"
        command.Parameters.AddWithValue("@characterID", characterID)

        If command.ExecuteScalar Is Nothing Then
            connection.Close()
            Return False
        Else
            connection.Close()
            Return True
        End If
    End Function

    Private Function checkCharacterInfoExists(ByVal charName As String) As Boolean
        openDB()
        Dim command As New SQLiteCommand(connection)

        command.CommandText = "SELECT * FROM characterInfo WHERE characterID = @characterID"
        command.Parameters.AddWithValue("@characterID", characterID)

        If command.ExecuteScalar Is Nothing Then
            connection.Close()
            Return False
        Else
            connection.Close()
            Return True
        End If
    End Function

    Private Sub saveSkills()
        openDB()
        Dim command As New SQLiteCommand(connection)

        If checkCharacterSkillsExists(characterName) Then
            command.CommandText = "UPDATE characterSkills SET Survival = @Survival,Stealth = @Stealth,
            Sleight = @Sleight,Religion = @Religion,Persuasion = @Persuasion,Performance = @Performance,
            Perception = @Perception,Nature = @Nature,Medicine = @Medicine,Investigation = @Investigation,
            Intimidation = @Intimidation,Deception = @Deception,History = @History,Arcana = @Arcana,Animal = @Animal,
            Acrobatics = @Acrobatics WHERE characterID = @characterID;"
        Else
            openDB()
            command.CommandText = "INSERT INTO characterSkills (characterID,Survival,Stealth,Sleight,Religion,
            Persuasion,Performance,Perception,Nature,Medicine,Investigation,Intimidation,History,Deception,Athletics,
            Arcana,Animal,Acrobatics) VALUES (@characterID,@Survival,@Stealth,@Sleight,@Religion,@Persuasion,
            @Performance,@Perception,@Nature,@Medicine,@Investigation,@Intimidation,@History,@Deception,@Athletics,
            @Arcana,@Animal,@Acrobatics);"
        End If
        openDB()
        command.Parameters.AddWithValue("@Survival", survivalCheckBox.Checked)
        command.Parameters.AddWithValue("@Stealth", stealthCheckBox.Checked)
        command.Parameters.AddWithValue("@Sleight", sleightCheckBox.Checked)
        command.Parameters.AddWithValue("@Religion", religionCheckBox.Checked)
        command.Parameters.AddWithValue("@Persuasion", persuasionCheckBox.Checked)
        command.Parameters.AddWithValue("@Performance", performanceCheckBox.Checked)
        command.Parameters.AddWithValue("@Perception", perceptionCheckBox.Checked)
        command.Parameters.AddWithValue("@Nature", natureCheckBox.Checked)
        command.Parameters.AddWithValue("@Medicine", medicineCheckBox.Checked)
        command.Parameters.AddWithValue("@Investigation", investigationCheckBox.Checked)
        command.Parameters.AddWithValue("@Intimidation", intimidationCheckBox.Checked)
        command.Parameters.AddWithValue("@History", historyCheckBox.Checked)
        command.Parameters.AddWithValue("@Deception", deceptionCheckBox.Checked)
        command.Parameters.AddWithValue("@Athletics", athleticsCheckBox.Checked)
        command.Parameters.AddWithValue("@Arcana", arcanaCheckBox.Checked)
        command.Parameters.AddWithValue("@Animal", animalCheckBox.Checked)
        command.Parameters.AddWithValue("@Acrobatics", acrobacticsCheckBox.Checked)
        command.Parameters.AddWithValue("@characterID", characterID)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub saveCharacterStats()
        openDB()
        Dim command As New SQLiteCommand(connection)

        If checkCharacterStatsExists(characterName) Then
            command.CommandText = "UPDATE characterStats SET stren=@stren,dex=@dex,con=@con,intel=@intel,
            wisdom=@wisdom,charisma=@charisma WHERE characterID=@characterID"
        Else
            command.CommandText = "INSERT INTO characterStats (characterID,stren,dex,con,intel,wisdom,charisma) 
            VALUES (@characterID,@stren,@dex,@con,@intel,@wisdom,@charisma)"
        End If
        command.Parameters.AddWithValue("@stren", Convert.ToInt16(strenTextBox.Text))
        command.Parameters.AddWithValue("@dex", Convert.ToInt16(dexTextBox.Text))
        command.Parameters.AddWithValue("@con", Convert.ToInt16(conTextBox.Text))
        command.Parameters.AddWithValue("@intel", Convert.ToInt16(intelTextBox.Text))
        command.Parameters.AddWithValue("@wisdom", Convert.ToInt16(wisdomTextBox.Text))
        command.Parameters.AddWithValue("@charisma", Convert.ToInt16(charismaTextBox.Text))
        command.Parameters.AddWithValue("@characterID", characterID)
        openDB()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub saveCharacterInfo()
        openDB()
        Dim command As New SQLiteCommand(connection)

        If checkCharacterInfoExists(characterName) Then
            command.CommandText = "UPDATE characterInfo SET proficiency = @proficiency,
            characterName = @characterName,characterClass=@characterClass,background = @background,alignment = @alignment,
            initiative = @initiative,armorClass = @armorClass,currentHp = @currentHp,
            hpMax = @hpMax,level = @level,speed = @speed WHERE characterID = @characterID;"
        Else
            command.CommandText = "INSERT INTO characterInfo (characterID,proficiency, 
            characterName,characterClass,background, alignment, initiative, armorClass, 
            currentHp, hpMax, level,speed)   VALUES (@characterID,@proficiency,@characterName,
            @characterClass, @background, @alignment,@initiative,@armorClass, @currentHp, 
            @hpMax, @level,@speed);"
        End If
        openDB()
        command.Parameters.AddWithValue("@proficiency", Convert.ToInt32(profTextBox.Text))
        command.Parameters.AddWithValue("@characterName", characterNameTextBox.Text)
        command.Parameters.AddWithValue("@characterClass", classTextBox.Text)
        command.Parameters.AddWithValue("@background", backgroundTextBox.Text)
        command.Parameters.AddWithValue("@alignment", alignmentTextBox.Text)
        command.Parameters.AddWithValue("@initiative", Convert.ToInt32(iniativeTextBox.Text))
        command.Parameters.AddWithValue("@armorClass", Convert.ToInt32(armorClassTextBox.Text))
        command.Parameters.AddWithValue("@currentHp", Convert.ToInt32(currentHpTextBox.Text))
        command.Parameters.AddWithValue("@hpMax", Convert.ToInt32(hpMaxTextBox.Text))
        command.Parameters.AddWithValue("@level", Convert.ToInt32(levelTextBox.Text))
        command.Parameters.AddWithValue("@speed", Convert.ToInt32(speedTextBox.Text))
        command.Parameters.AddWithValue("@characterID", characterID)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub classTextBox_TextChanged(sender As Object, e As EventArgs) Handles classTextBox.TextChanged
        If classTextBox.Text = "" Then
            Exit Sub
        End If

        validateOnlyCharacters(classTextBox)

    End Sub

    Private Sub validateOnlyCharacters(ByVal textbox As TextBox)
        Dim input As String = textbox.Text
        If Not input.All(Function(c) Char.IsLetter(c)) Then
            MessageBox.Show("Please enter only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textbox.Focus()
            textbox.SelectAll()
        End If
    End Sub

    Private Sub castSpellButton_Click(sender As Object, e As EventArgs) Handles castSpellButton.Click
        level = Convert.ToInt32(levelTextBox.Text)
        characterClass = classTextBox.Text

        spellCast.Show()
    End Sub

    Private Sub characterSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        characterNameTextBox.Text = characterName
        getCharacterStats()
        getCharacterInfo()
        getCharacterSkills()
        loadPreparedSpells()
    End Sub

    Private Sub characterSheet_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        loadPreparedSpells()
    End Sub

    Private Sub characterSheet_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        saveCharacterStats()
        saveSkills()
        saveCharacterInfo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        level = Convert.ToInt32(levelTextBox.Text)
        characterClass = classTextBox.Text
        prepareSpells.Show()
    End Sub
End Class
