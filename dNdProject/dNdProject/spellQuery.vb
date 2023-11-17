Public Class spellQuery

    Private Sub spellQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if the connection is open and if not open it
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        command.CommandText = "SELECT * from allSpells"
    End Sub
End Class