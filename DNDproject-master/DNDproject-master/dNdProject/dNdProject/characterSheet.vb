Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.Data.SQLite
Imports System.Security.Cryptography

Public Class characterSheet
    'Private dbCommand As String = ""
    'Private bindingSrc As BindingSource

    'Private dbName As String = "DND.db"
    'Private dbPath As String = Application.StartupPath & "\" & dbName
    'Private consString As String = "Data Source=" & dbPath & ";Version=3"

    'Private connection As New SQLiteConnection(consString)
    'Private command As New SQLiteCommand("", connection)

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '   connection.Open()

    '  command.Connection = connection
    ' command.CommandText = "Select * from tbl1"

    'Dim rdr As SQLiteDataReader = command.ExecuteReader
    'Using rdr
    'While (rdr.Read())
    '           MsgBox((rdr.GetInt32(0) & rdr.GetString(1) & rdr.GetInt32(2)))
    'End While

    'End Using

    '   connection.Close()
    'If connection.State = ConnectionState.Open Then
    '    MsgBox("The connection is: " & connection.State.ToString)
    'End If
    'End Sub
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
    Private Sub charTextBox_TextChanged(sender As Object, e As EventArgs) Handles charTextBox.TextChanged
        Dim modifer As Integer

        If charTextBox.Text = "" Then
            Exit Sub
        End If

        Try
            modifer = Convert.ToInt32(charTextBox.Text)
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
    Public Function strenD20roll() As Integer

        Dim roll As Integer
        Dim rnd As New Random
        roll = rnd.Next(0, 21)
        roll = Convert.ToInt32(strenModiferLabel.Text) + roll
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
    Private Sub profTextBox_TextChanged(sender As Object, e As EventArgs)
        profBonus = Convert.ToInt32(profTextBox.Text)
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

    Private Sub characterSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database2.accdb")
        conn.Open()

        ' Create a new OleDbCommand object and set the CommandType property to Text.
        Dim cmd As New OleDbCommand("SELECT * FROM characters WHERE characterName", conn)

        ' Create a new OleDbDataReader object and execute the OleDbCommand object.
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        ' Read the data from the OleDbDataReader object.
        While reader.Read()
            ' Do something with the data.
            ' For example, you could display the data in a textbox.
            TextBox1.Text = reader("TextBoxValue").ToString()
        End While

        ' Close the OleDbDataReader object and the OleDbConnection object.
        reader.Close()
        conn.Close()
    End Sub
End Class
