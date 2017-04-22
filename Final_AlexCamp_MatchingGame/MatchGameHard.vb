Imports System.IO

Public Class frmMatchingGameHard
    Private decClickValue As Decimal = 0.5

    ' This method will allow the computer to recognize which label is selected first
    ' and which label is selected second, so that the program can compare the two
    ' because only two labels need to be held at a time, there are only two methods for two labels

    Private firstClicked As Label = Nothing
    Private secondClicked As Label = Nothing
    Private blnIsWinner As Boolean = False
    Private blnIsRestart As Boolean = False

    'This will allow the images to be random each game
    Private random As New Random

    'The following list of strings appear as typical characters but using a interesting
    'font they appear as unique images, very useful for this matching game without getting
    'images from another source
    Private icons =
        New List(Of String) From {"b", "b", "k", "k", "N", "N", "u", "u", "J", "J",
                                "j", "j", "w", "w", "F", "F", "D", "D", "d", "d"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AssignIconsToSquares()

    End Sub

    'This method takes icons from the list and randomly assigns them to the labels Set 
    ' on the design form
    Private Sub AssignIconsToSquares()


        For Each Control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(Control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.Count)
                iconLabel.Text = icons(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If
        Next

    End Sub

    'This event handler determines if a label is clicked, 
    'and contains all labels ability to do so


    Private Sub lbl_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click,
        Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label16.Click,
        Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click,
        Label10.Click, Label1.Click, Label17.Click, Label18.Click, Label19.Click, Label20.Click

        'Handles the score, each click is valued at decClickValue  
        frmSelectDifficulty.AddToScore(decClickValue)

        'This will cause the timer to not recognize a third label after the first two have been selected
        If Timer1.Enabled Then Exit Sub


        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then

            'The following code makes it so that if a label that has been selected already is clicked
            'then the click will be ignored 
            'otherwise the game will mistake every click as accurate input
            If clickedLabel.ForeColor = Color.Black Then Exit Sub

            If firstClicked Is Nothing Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                clickedLabel.ForeColor = Color.Black
                Exit Sub
            End If

            'This will check if the timer is running, and if first click is currently not null
            ' if the timer isn't running and first click isn't null, then this will recognize that this must be the second icon
            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black

            'Will check if the player has won
            WinOrLoss()

            'this will recognize if two matching icons have been selected,
            ' and if so, will keep them visible so you know you suceeded and the game plays properly
            If firstClicked.Text = secondClicked.Text Then
                'Clears out the variables so that they can be used further to compare
                firstClicked = Nothing
                secondClicked = Nothing
                Exit Sub
            End If

            'At this point if two icons have been selected that will be recognized, and the timer will properly start
            'there will be a slight delay of about a second before the timer starts as i felt that was fair
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'I don't want the timer to start upon starting the form, as it would be unfair
        Timer1.Stop()

        'Hides the icons after selection
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        'Resets the first two clicked items, so that the program knows that when a new icon is selected, this is the new first click
        ' and the new second click
        firstClicked = Nothing
        secondClicked = Nothing

        'The timer will serve multiple functions as shown, stops at the start, selects the selected icons and makes them invisible again 
        ' and resets the variables for clicking back to nothing
        ' so that variable has space now to fill in with new icons, continuing the game properly.
    End Sub

    Private Sub WinOrLoss()

        'Determines if the labels have each been matched, and if so names the player a winner.
        For Each Control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(Control, Label)
            If iconLabel IsNot Nothing AndAlso
                iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
        Next

        'If the loop does not return, that means all icons were matched
        'thus the user won.
        Dim frmWin As frmWin
        frmWin = New frmWin
        frmWin.Show()
        frmWin = Nothing
        blnIsWinner = True
        Me.Close()
    End Sub

    Private Sub mnuRestart_Click(sender As Object, e As EventArgs) Handles mnuRestart.Click
        'back to difficulty form
        blnIsRestart = True
        Me.Close()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'exits and back to intro form,
        Me.Close()
    End Sub

    Private Sub mnuInfo_Click(sender As Object, e As EventArgs) Handles mnuInfo.Click
        'info on how to play
        MessageBox.Show("Click a box to reveal its picture and match it with the identical image, the less clicks you do it in, the better your score!")
    End Sub

    Private Sub mnuScore_Click(sender As Object, e As EventArgs) Handles mnuScore.Click
        'handles output for the score, max of ten scores, and shows it in the message box
        If (File.Exists(frmIntro.strScoresFile)) Then
            Dim strScore() As String = File.ReadAllLines(frmIntro.strScoresFile)
            Dim scores = strScore.Select(Function(score) New With {Key .Name = score.Split(",")(0), Key .Score = score.Split(",")(1)}).OrderBy(Function(entry) Convert.ToDecimal(entry.Score)).Take(10)
            MessageBox.Show(scores.Aggregate(String.Format("{1}{0}{2}{3}", vbTab, "Name".PadRight(100), "Score", Environment.NewLine),
                                             Function(current, entry) current + String.Format("{1}{0}{2}{3}", vbTab, entry.Name.PadRight(100), entry.Score, Environment.NewLine)))
        Else
            MessageBox.Show("No scores to display")
        End If
    End Sub
    Private Sub frmMatchingGameHard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'stops the program from running when game is closed during playing through the exit button built into forms
        If (blnIsRestart) Then
            frmSelectDifficulty.Show()
        ElseIf (Not blnIsWinner) Then
            frmIntro.Show()
        End If
    End Sub

    Private Sub frmMatchingGameHard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSelectDifficulty.ResetScore()
    End Sub
End Class




