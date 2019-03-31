Public Class frmMonkeyMaths

    Public score As Integer
    Dim time As Integer
    Dim nextquestion As Boolean
    Dim options(3) As Integer
    Dim numbers(3) As Integer
    Dim sign As String
    Dim number1 As Integer
    Dim number2 As Integer
    Dim answer As Integer
    Dim random As Integer
    Dim positivefeedback(4) As String
    Dim negativefeedback(2) As String
    Dim playing As Boolean

   

    Private Sub frmMonkeyMaths_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        frmHome.Hide()
        score = 0
        time = 120
        tmrCountdown.Enabled = True
        playing = True

        'this defines feedback to be used depending on correctness of answers
        positivefeedback(0) = "Well done!"
        positivefeedback(1) = "Good job!"
        positivefeedback(2) = "That's right!"
        positivefeedback(3) = "Nice work!"
        positivefeedback(4) = "Great!"
        negativefeedback(0) = "Incorrect"
        negativefeedback(1) = "Wrong"
        negativefeedback(2) = "Bad luck"

        Do
            nextquestion = False 'prevents application from progressing to next question
            For i = 0 To 3
                options(i) = -1
                numbers(i) = -1 'sets numbers to -1  so that a structure later on works
            Next

            Randomize()

            If Int(2 * Rnd()) = 0 Then 'randomises a binary integer to determine whether adding or subtracting. 
                sign = "+"
                number1 = Int((14 * Rnd()) + 1) 'randomise number between 0 and 15 adds 1
                number2 = Int((14 * Rnd()) + 1) 'randomise another number between 0 and 15 adds 1
                answer = number1 + number2
                options(3) = Math.Abs(number1 - number2) 'always the opposite as an option to make them check
            Else
                sign = "-"
                number1 = Int((7 * Rnd()) + 9) 'randomises a number between 0 and 7 + 8
                number2 = Int(((number1 - 1) * Rnd()) + 1) 'randomises a smaller number to subract
                answer = number1 - number2
                options(3) = number1 + number2 'always the opposite as an option to make them check
            End If
            lblQuestion.Text = number1 & " " & sign & " " & number2 & " =" 'displays question

            options(0) = answer
            options(1) = answer + 1
            options(2) = answer - 1

            For i = 0 To 3 'this structure randomises the order
                Do
                    random = Int(4 * Rnd()) 'random number between 0 and 3
                Loop Until random <> numbers(0) And random <> numbers(1) And random <> numbers(2) And random <> numbers(3)
                numbers(i) = random
            Next

            btnOption1.Text = options(numbers(0)) 'using random order it applies options to buttons
            btnOption2.Text = options(numbers(1))
            btnOption3.Text = options(numbers(2))
            btnOption4.Text = options(numbers(3))

            Do Until nextquestion
                Application.DoEvents() 'this waits until next question is true to loop
            Loop
        Loop Until time = 0 'once time is 0 there are no more questions
    End Sub

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        If btnOption1.Text = answer Then
            score += 10 'increases score by 10 if correct
            lblQuestion.Text = positivefeedback(Int(5 * Rnd())) 'it randomises a positive feedback option choosing one from a possible 5
        Else
            score -= 2 'decreases score by two if incorrect
            lblQuestion.Text = negativefeedback(Int(3 * Rnd())) 'it randomises negative feedback choosing one from a possible three
        End If
        tmrFeedback.Enabled = True 'this updates the score
        lblScore.Text = "Score: " & score 'this displays the feedback label
    End Sub

    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        If btnOption2.Text = answer Then
            score += 10
            lblQuestion.Text = positivefeedback(Int(5 * Rnd()))
        Else
            score -= 2
            lblQuestion.Text = negativefeedback(Int(3 * Rnd()))
        End If
        tmrFeedback.Enabled = True
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        If btnOption3.Text = answer Then
            score += 10
            lblQuestion.Text = positivefeedback(Int(5 * Rnd()))
        Else
            score -= 2
            lblQuestion.Text = negativefeedback(Int(3 * Rnd()))
        End If
        tmrFeedback.Enabled = True
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub btnOption4_Click(sender As Object, e As EventArgs) Handles btnOption4.Click
        If btnOption4.Text = answer Then
            score += 10
            lblQuestion.Text = positivefeedback(Int(5 * Rnd()))
        Else
            score -= 2
            lblQuestion.Text = negativefeedback(Int(3 * Rnd()))
        End If
        tmrFeedback.Enabled = True
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
        time = time - 1 'decreases time. in properties interval is 1000 so is each second
        lblTime.Text = "Time: " & time 'updates time label
        If time = 0 Then  'when time is zero it hides all buttons and labels from playing and displays restart button, gives final score
            tmrCountdown.Enabled = False
            btnOption1.Visible = False
            btnOption2.Visible = False
            btnOption3.Visible = False
            btnOption4.Visible = False
            lblQuestion.Visible = False
            lblScore.Visible = False
            lblTime.Visible = False
            btnPause.Visible = False
            btnHelp.Visible = False
            lblHeader.Text = "Monkey Maths"
            lblFinalScore.Text = "Your Final Score is " & score
            lblFinalScore.Visible = True
            btnGoToHighScores.Visible = True 'allows you to access highscores
            btnRestart.Visible = True
            Call MonkeyMathsHighScores() 'checks if it is a highscore by accessing module
        End If
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If playing = True Then 'disables buttons and time when you press pause
            btnOption1.Enabled = False
            btnOption2.Enabled = False
            btnOption3.Enabled = False
            btnOption4.Enabled = False
            tmrCountdown.Enabled = False
            btnPause.Text = "Play"
            playing = False
            btnPause.BackColor = Color.Maroon 'this makes it easily identifiable to play again
        Else 'once paused this plays the game again
            btnOption1.Enabled = True
            btnOption2.Enabled = True
            btnOption3.Enabled = True
            btnOption4.Enabled = True
            nextquestion = True
            tmrCountdown.Enabled = True
            playing = True
            btnPause.Text = "Pause"
            btnPause.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        If playing = True Then 'this displays help and pauses game
            btnOption1.Enabled = False
            btnOption2.Enabled = False
            btnOption3.Enabled = False
            btnOption4.Enabled = False
            tmrCountdown.Enabled = False
            btnPause.Text = "Play"
            playing = False
            btnPause.BackColor = Color.Maroon
        End If
        frmHelp.lblHelp.Text = "Monkey Maths is an adding and subtracting game." & vbNewLine & "To play click on the number that correctly answers the question." & vbNewLine & "You get 10 points for each correct answer but lose 2 for each incorrect." & vbNewLine & "The remaining time and score is displayed at the bottom of the screen." & vbNewLine & "Exit returns to the main menu." & vbNewLine & "You have " & time & " seconds left to get as many points as possible. Press play to continue." & vbNewLine & "Good luck!"
        'the above makes help context sensitive
        frmHelp.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub tmrFeedback_Tick(sender As Object, e As EventArgs) Handles tmrFeedback.Tick
        nextquestion = True
        tmrFeedback.Enabled = False
        'this displayes feedback for 0.5 seconds
    End Sub

    Private Sub btnGoToHighScores_Click(sender As Object, e As EventArgs) Handles btnGoToHighScores.Click
        Me.Close()
        frmHighScores.Show()
    End Sub


    Public Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'this updates highscore name using variable from highscore process module if you get a highscore
        If HighScoreRank = 0 Then
            MMhighscorename(4) = MMhighscorename(3)
            MMhighscorename(3) = MMhighscorename(2)
            MMhighscorename(2) = MMhighscorename(1)
            MMhighscorename(1) = MMhighscorename(0)
        End If
        If HighScoreRank = 1 Then
            MMhighscorename(4) = MMhighscorename(3)
            MMhighscorename(3) = MMhighscorename(2)
            MMhighscorename(2) = MMhighscorename(1)
        End If
        If HighScoreRank = 2 Then
            MMhighscorename(4) = MMhighscorename(3)
            MMhighscorename(3) = MMhighscorename(2)
        End If
        If HighScoreRank = 3 Then
            MMhighscorename(4) = MMhighscorename(3)
        End If

        MMhighscorename(HighScoreRank) = " " + txtEnterName.Text
        lblEnterName.Visible = False
        txtEnterName.Visible = False
        btnEnter.Visible = False
        Dim FileMM As Integer 'this saves the name of the user who gets the highscore to a file
        FileMM = FreeFile()
        Debug.Print(FileMM)
        FileOpen(FileMM, "MMHighscorenames.text", OpenMode.Output)
        PrintLine(FileMM, MMhighscorename(0))
        PrintLine(FileMM, MMhighscorename(1))
        PrintLine(FileMM, MMhighscorename(2))
        PrintLine(FileMM, MMhighscorename(3))
        PrintLine(FileMM, MMhighscorename(4))
        FileClose(FileMM)
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'it displays all buttons again and hides all end game buttons, resetting time and score when you click restart button
        btnOption1.Visible = True
        btnOption2.Visible = True
        btnOption3.Visible = True
        btnOption4.Visible = True
        lblQuestion.Visible = True
        lblScore.Visible = True
        lblTime.Visible = True
        btnPause.Visible = True
        btnHelp.Visible = True
        lblHeader.Text = "What is the answer?"
        lblFinalScore.Visible = False
        btnGoToHighScores.Visible = False
        tmrCountdown.Enabled = False
        btnRestart.Visible = False
        txtEnterName.Visible = False
        btnEnter.Visible = False
        lblEnterName.Visible = False
        lblNewHighScore.Visible = False
        time = 120
        score = 0
        lblScore.Text = "Score: " & score
        tmrCountdown.Enabled = True
    End Sub
End Class