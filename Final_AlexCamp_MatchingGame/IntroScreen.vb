Imports System.IO

Public Class frmIntro
    Public ReadOnly strScoresFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MatchingGameScores.txt")

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'Closes the form
        Me.Close()
    End Sub

    Private Sub mnuScore_Click(sender As Object, e As EventArgs) Handles mnuScore.Click
        'handles output for the score, max of ten scores, and shows it in the message box
        If (File.Exists(strScoresFile)) Then
            Dim strScore() As String = File.ReadAllLines(strScoresFile)
            Dim scores = strScore.Select(Function(score) New With {Key .Name = score.Split(",")(0), Key .Score = score.Split(",")(1)}).OrderBy(Function(entry) Convert.ToDecimal(entry.Score)).Take(10)
            MessageBox.Show(scores.Aggregate(String.Format("{1}{0}{2}{3}", vbTab, "Name".PadRight(100), "Score", Environment.NewLine),
                                             Function(current, entry) current + String.Format("{1}{0}{2}{3}", vbTab, entry.Name.PadRight(100), entry.Score, Environment.NewLine)))
        Else
            MessageBox.Show("No scores to display")
        End If
    End Sub

    Private Sub mnuInfo_Click(sender As Object, e As EventArgs) Handles mnuInfo.Click
        'info on how to play
        MessageBox.Show("Click a box to reveal its picture and match it with the identical image, the less clicks you do it in, the better your score!")
    End Sub

    Private Sub mnuPlay_Click(sender As Object, e As EventArgs) Handles mnuPlay.Click
        'This menu option will hide the current form and open a new one for difficulty selection
        Dim frmSelectDifficulty As frmSelectDifficulty
        frmSelectDifficulty = New frmSelectDifficulty
        frmSelectDifficulty.Show()
        Me.Hide()
    End Sub

End Class