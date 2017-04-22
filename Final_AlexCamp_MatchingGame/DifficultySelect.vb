Public Class frmSelectDifficulty

    Private boolIsGameStarted As Boolean = False
    Private decScore As Decimal = 0.0
    'following subs and functions handle score system`
    Public Sub ResetScore()
        Me.decScore = 0.0
    End Sub

    Public Sub AddToScore(decValue As Decimal)
        Me.decScore += decValue
    End Sub

    Public Function GetScore() As Decimal
        Return Me.decScore
    End Function
    'end score system
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        If lstDifficultyLevels.SelectedIndex = -1 Then
            'TODO: Show an alert indicating the game cannot be started without selecting a difficulty level
            MessageBox.Show("Please select a difficulty level.")
            'Uses a select case to determine which difficulty was selected, which determines which form is shown and spawned
        Else
            Select Case lstDifficultyLevels.SelectedItem
                Case "Easy"
                    Dim frmMatchingGame As frmMatchingGameEasy
                    frmMatchingGame = New frmMatchingGameEasy
                    frmMatchingGame.Show()
                    boolIsGameStarted = True
                    Me.Close()
                Case "Medium"
                    Dim frmMatchingGame As frmMatchingGameMedium
                    frmMatchingGame = New frmMatchingGameMedium
                    frmMatchingGame.Show()
                    boolIsGameStarted = True
                    Me.Close()
                Case "Hard"
                    Dim frmMatchingGame As frmMatchingGameHard
                    frmMatchingGame = New frmMatchingGameHard
                    frmMatchingGame.Show()
                    boolIsGameStarted = True
                    Me.Close()
            End Select
        End If
    End Sub

    Private Sub frmSelectDifficulty_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Determines if the game was selected to start, if not, then the form is closed.  
        If boolIsGameStarted = False Then
            frmIntro.Close()
        End If
    End Sub

    Private Sub frmSelectDifficulty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class