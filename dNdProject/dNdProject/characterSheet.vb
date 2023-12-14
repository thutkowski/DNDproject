Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Data.Entity.Core
Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class characterSheet
    Private profBonus As Integer



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
            rdr.Close()
        End If
        rdr.Close()

    End Sub

    Private Sub getCharacterInfo()
        openDB()

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
            rdr.Close()
        End If
        rdr.Close()
    End Sub

    Private Sub getCharacterSkills()
        openDB()

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

    Private Sub characterSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        characterNameTextBox.Text = characterName
        getCharacterStats()
        getCharacterInfo()
        getCharacterSkills()
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT spellName FROM spells WHERE known = 1 "
        Dim spellName As New DataSet()

        Using da As New SQLiteDataAdapter(command.CommandText, connection)
            ' Populate the DataSet with the data from the SQLite database
            da.Fill(spellName)
        End Using

        spellDataGridView.DataSource = spellName.Tables(0)
        spellDataGridView.Columns(0).HeaderText = "Spell Name"
        spellDataGridView.RowHeadersVisible = False
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
    Private Sub characterSheet_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        saveCharacterStats()
        saveSkills()
        saveCharacterInfo()
    End Sub

    Private Sub saveCharacterStats()
        Dim stren, dex, con, intel, wisdom, charisma As Integer
        openDB()

        stren = Convert.ToInt16(strenTextBox.Text)
        wisdom = Convert.ToInt16(wisdomTextBox.Text)
        dex = Convert.ToInt16(dexTextBox.Text)
        con = Convert.ToInt16(conTextBox.Text)
        intel = Convert.ToInt16(intelTextBox.Text)
        charisma = Convert.ToInt16(charismaTextBox.Text)

        If Not checkCharacterStatsExists(characterName) Then
            openDB()
            command.CommandText = "INSERT INTO characterStats (characterID,stren,dex,con,intel,wisdom,charisma) VALUES (@ID,@stren,@dex,@con,@intel,@wisdom,@charisma)"
            command.Parameters.AddWithValue("@stren", stren)
            command.Parameters.AddWithValue("@dex", dex)
            command.Parameters.AddWithValue("@con", con)
            command.Parameters.AddWithValue("@intel", intel)
            command.Parameters.AddWithValue("@wisdom", wisdom)
            command.Parameters.AddWithValue("@charisma", charisma)
            command.Parameters.AddWithValue("@ID", characterID)
            command.ExecuteNonQuery()
        Else
            openDB()
            command.CommandText = "UPDATE characterStats SET stren=@stren,dex=@dex,con=@con,intel=@intel,wisdom=@wisdom,charisma=@charisma WHERE characterID=@characterID"
            command.Parameters.AddWithValue("@stren", stren)
            command.Parameters.AddWithValue("@dex", dex)
            command.Parameters.AddWithValue("@con", con)
            command.Parameters.AddWithValue("@intel", intel)
            command.Parameters.AddWithValue("@wisdom", wisdom)
            command.Parameters.AddWithValue("@charisma", charisma)
            command.Parameters.AddWithValue("@characterID", characterID)
            command.ExecuteNonQuery()
        End If
        connection.Close()
    End Sub

    Private Sub characterSheet_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If AreAnyTextBoxesEmpty() = True Then
            MessageBox.Show("One or more text boxes are empty. Cannot save character unless all are filled.")
            e.Cancel = True
        End If
    End Sub

    Private Sub spellSheetButton_Click(sender As Object, e As EventArgs) Handles spellSheetButton.Click
        spellSheet.Show()
    End Sub

    Private Sub spellDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles spellDataGridView.CellContentClick
        spellIDQuery = e.RowIndex
        spellQueryForm.ShowDialog()
    End Sub

    Private Function checkCharacterStatsExists(ByVal charName As String) As Boolean
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

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
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

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
    Private Sub saveSkills()
        Dim survival As Boolean = survivalCheckBox.Checked
        Dim stealth As Boolean = stealthCheckBox.Checked
        Dim sleight As Boolean = sleightCheckBox.Checked
        Dim religion As Boolean = religionCheckBox.Checked
        Dim persuasion As Boolean = performanceCheckBox.Checked
        Dim performance As Boolean = performanceCheckBox.Checked
        Dim perception As Boolean = perceptionCheckBox.Checked
        Dim nature As Boolean = natureCheckBox.Checked
        Dim medicine As Boolean = medicineCheckBox.Checked
        Dim investigation As Boolean = investigationCheckBox.Checked
        Dim intimidation As Boolean = intimidationCheckBox.Checked
        Dim history As Boolean = historyCheckBox.Checked
        Dim deception As Boolean = deceptionCheckBox.Checked
        Dim athletics As Boolean = athleticsCheckBox.Checked
        Dim arcana As Boolean = arcanaCheckBox.Checked
        Dim animal As Boolean = animalCheckBox.Checked
        Dim acrobatics As Boolean = acrobacticsCheckBox.Checked


        If checkCharacterSkillsExists(characterName) Then
            openDB()
            command.CommandText = "UPDATE characterSkills SET Survival = @Survival,Stealth = @Stealth, Sleight = @Sleight,Religion = @Religion,Persuasion = @Persuasion,Performance = @Performance,Perception = @Perception,Nature = @Nature,Medicine = @Medicine,Investigation = @Investigation,Intimidation = @Intimidation,Deception = @Deception,History = @History,Arcana = @Arcana,Animal = @Animal,Acrobatics = @Acrobatics WHERE characterID = @ID;"
            command.Parameters.AddWithValue("@Survival", Convert.ToInt16(survival))
            command.Parameters.AddWithValue("@Stealth", Convert.ToInt16(stealth))
            command.Parameters.AddWithValue("@Sleight", Convert.ToInt16(stealth))
            command.Parameters.AddWithValue("@Religion", Convert.ToInt16(religion))
            command.Parameters.AddWithValue("@Persuasion", Convert.ToInt16(persuasion))
            command.Parameters.AddWithValue("@Performance", Convert.ToInt16(performance))
            command.Parameters.AddWithValue("@Perception", Convert.ToInt16(perception))
            command.Parameters.AddWithValue("@Nature", Convert.ToInt16(nature))
            command.Parameters.AddWithValue("@Medicine", Convert.ToInt16(medicine))
            command.Parameters.AddWithValue("@Investigation", Convert.ToInt16(investigation))
            command.Parameters.AddWithValue("@Intimidation", Convert.ToInt16(intimidation))
            command.Parameters.AddWithValue("@History", Convert.ToInt16(history))
            command.Parameters.AddWithValue("@Deception", Convert.ToInt16(deception))
            command.Parameters.AddWithValue("@Athletics", Convert.ToInt16(athletics))
            command.Parameters.AddWithValue("@Arcana", Convert.ToInt16(arcana))
            command.Parameters.AddWithValue("@Animal", Convert.ToInt16(animal))
            command.Parameters.AddWithValue("@Acrobatics", Convert.ToInt16(acrobatics))
            command.Parameters.AddWithValue("@ID", characterID)
            command.ExecuteNonQuery()
        Else
            openDB()
            command.CommandText = "INSERT INTO characterSkills (characterID,Survival,Stealth,Sleight,Religion,Persuasion,Performance,Perception,Nature,Medicine,Investigation,Intimidation,History,Deception,Athletics,Arcana,Animal,Acrobatics) VALUES (@characterID,@Survival,@Stealth,@Sleight,@Religion,@Persuasion,@Performance,@Perception,@Nature,@Medicine,@Investigation,@Intimidation,@History,@Deception,@Athletics,@Arcana,@Animal,@Acrobatics);"
            command.Parameters.AddWithValue("@Survival", survival)
            command.Parameters.AddWithValue("@Stealth", stealth)
            command.Parameters.AddWithValue("@Sleight", stealth)
            command.Parameters.AddWithValue("@Religion", religion)
            command.Parameters.AddWithValue("@Persuasion", persuasion)
            command.Parameters.AddWithValue("@Performance", performance)
            command.Parameters.AddWithValue("@Perception", perception)
            command.Parameters.AddWithValue("@Nature", nature)
            command.Parameters.AddWithValue("@Medicine", medicine)
            command.Parameters.AddWithValue("@Investigation", investigation)
            command.Parameters.AddWithValue("@Intimidation", intimidation)
            command.Parameters.AddWithValue("@History", history)
            command.Parameters.AddWithValue("@Deception", deception)
            command.Parameters.AddWithValue("@Athletics", athletics)
            command.Parameters.AddWithValue("@Arcana", arcana)
            command.Parameters.AddWithValue("@Animal", animal)
            command.Parameters.AddWithValue("@Acrobatics", acrobatics)
            command.Parameters.AddWithValue("@characterID", characterID)
            command.ExecuteNonQuery()
        End If
        connection.Close()
    End Sub

    Private Function checkCharacterInfoExists(ByVal charName As String) As Boolean
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

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
    Private Sub saveCharacterInfo()

        Dim proficiency As String = profTextBox.Text
        Dim characterName As String = characterNameTextBox.Text
        Dim background As String = backgroundTextBox.Text
        Dim alignment As String = alignmentTextBox.Text
        Dim initiative As Integer = Convert.ToInt32(iniativeTextBox.Text)
        Dim armorClass As Integer = Convert.ToInt32(armorClassTextBox.Text)
        Dim currentHp As Integer = Convert.ToInt32(currentHpTextBox.Text)
        Dim hpMax As Integer = Convert.ToInt32(hpMaxTextBox.Text)
        Dim level As Integer = Convert.ToInt32(levelTextBox.Text)
        Dim characterClass As String = classTextBox.Text
        Dim speed As Integer = Convert.ToInt32(speedTextBox.Text)

        If checkCharacterInfoExists(characterName) Then
            openDB()
            command.CommandText = "UPDATE characterInfo SET proficiency = @proficiency,
            characterName = @characterName,characterClass=@characterClass,background = @background,alignment = @alignment,
            initiative = @initiative,armorClass = @armorClass,currentHp = @currentHp,
            hpMax = @hpMax,level = @level,speed = @speed WHERE characterID = @ID;"
            command.Parameters.AddWithValue("@proficiency", proficiency)
            command.Parameters.AddWithValue("@characterName", characterName)
            command.Parameters.AddWithValue("@characterClass", characterClass)
            command.Parameters.AddWithValue("@background", background)
            command.Parameters.AddWithValue("@alignment", alignment)
            command.Parameters.AddWithValue("@initiative", initiative)
            command.Parameters.AddWithValue("@armorClass", armorClass)
            command.Parameters.AddWithValue("@currentHp", currentHp)
            command.Parameters.AddWithValue("@hpMax", hpMax)
            command.Parameters.AddWithValue("@level", level)
            command.Parameters.AddWithValue("@speed", speed)
            command.Parameters.AddWithValue("@ID", characterID)
            command.ExecuteNonQuery()
        Else
            openDB()
            command.CommandText = "INSERT INTO characterInfo (characterID,proficiency, 
            characterName,characterClass,background, alignment, initiative, armorClass, 
            currentHp, hpMax, level,speed)   VALUES (@ID,@proficiency,@characterName,
            @characterClass, @Background, @Alignment,@Initiative,@ArmorClass, @CurrentHp, 
            @HpMax, @Level,@speed);"

            command.Parameters.AddWithValue("@proficiency", proficiency)
            command.Parameters.AddWithValue("@characterName", characterName)
            command.Parameters.AddWithValue("@characterClass", characterClass)
            command.Parameters.AddWithValue("@Background", background)
            command.Parameters.AddWithValue("@Alignment", alignment)
            command.Parameters.AddWithValue("@Initiative", initiative)
            command.Parameters.AddWithValue("@ArmorClass", armorClass)
            command.Parameters.AddWithValue("@CurrentHp", currentHp)
            command.Parameters.AddWithValue("@HpMax", hpMax)
            command.Parameters.AddWithValue("@Level", level)
            command.Parameters.AddWithValue("@speed", speed)
            command.Parameters.AddWithValue("@ID", characterID)
            command.ExecuteNonQuery()
        End If

    End Sub

End Class
