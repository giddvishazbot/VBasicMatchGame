Imports System.IO

Public Class frmWin
    Private Sub frmWin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Closes the intro form
        frmIntro.Close()
    End Sub


    Private Sub mnuScore_Click(sender As Object, e As EventArgs) Handles mnuScore.Click
        'handles output for the score, max of ten scores, and shows it in the message box
        If (File.Exists(frmIntro.strScoresFile)) Then
            Dim strScore() As String = File.ReadAllLines(frmIntro.strScoresFile)
            Dim scores = strScore.Select(Function(score) New With {Key .Name = score.Split(",")(0), Key .Score = score.Split(",")(1)}).OrderBy(Function(entry) Convert.ToDecimal(entry.Score)).Take(10)
            MessageBox.Show(scores.Aggregate(String.Format("{1}{0}{2}{3}", vbTab, "Name".PadRight(100), "Score", Environment.NewLine),
                                             Function(current, entry) current + String.Format("{1}{0}{2}{3}", vbTab, entry.Name.PadRight(100), entry.Score, Environment.NewLine)))
        Else
            'handles exceptions 
            MessageBox.Show("No scores to display")
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'Closes every form
        Me.Close()
        frmIntro.Close()
        frmMatchingGameMedium.Close()
    End Sub

    Private Sub mnuRestart_Click(sender As Object, e As EventArgs) Handles mnuRestart.Click
        'Opens the difficulty select form but hides the current
        Dim frmSelectDifficulty As frmSelectDifficulty
        frmSelectDifficulty = New frmSelectDifficulty
        frmSelectDifficulty.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'stores the score and name of the player for later retrieval 
        If (String.IsNullOrWhiteSpace(txtNameInput.Text) Or String.IsNullOrWhiteSpace(txtScore.Text)) Then
            MessageBox.Show("Name or score is blank.  Please correct.")
        Else
            Dim ScoreFile As StreamWriter
            If (File.Exists(frmIntro.strScoresFile)) Then
                ScoreFile = File.AppendText(frmIntro.strScoresFile)
            Else
                ScoreFile = File.CreateText(frmIntro.strScoresFile)
            End If
            ScoreFile.WriteLine(String.Format("{0},{1}", txtNameInput.Text.Trim(), txtScore.Text))
            ScoreFile.Close()
            ClearForm()
        End If
    End Sub

    Private Sub frmWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gets the players score
        txtScore.Text = frmSelectDifficulty.GetScore()
    End Sub

    Private Sub ClearForm()
        'clears score and name after input
        txtNameInput.Text = ""
        txtScore.Text = ""
    End Sub
End Class