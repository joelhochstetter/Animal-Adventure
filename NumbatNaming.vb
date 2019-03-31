Public Class frmNumbatNaming

    Public score As Integer
    Dim time As Integer
    Dim nextquestion As Boolean
    Dim options(3) As String
    Dim numbers(3) As Integer
    Dim question As Integer
    Dim images(49) As Image
    Dim animals(49) As String
    Dim answer As String
    Dim random As Integer
    Dim positivefeedback(4) As String
    Dim negativefeedback(2) As String
    Dim playing As Boolean

    Private Sub frmNumbatNaming_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'each animal has a corresponding images
        images(0) = My.Resources.Ant
        images(1) = My.Resources.Antelope
        images(2) = My.Resources.Bat
        images(3) = My.Resources.Bear
        images(4) = My.Resources.Bird
        images(5) = My.Resources.Buffalo
        images(6) = My.Resources.Butterfly
        images(7) = My.Resources.Camel
        images(8) = My.Resources.Cat
        images(9) = My.Resources.Caterpillar
        images(10) = My.Resources.Chicken
        images(11) = My.Resources.Crab
        images(12) = My.Resources.Crocodile
        images(13) = My.Resources.Dog
        images(14) = My.Resources.Duck
        images(15) = My.Resources.Eagle
        images(16) = My.Resources.Elephant
        images(17) = My.Resources.Emu
        images(18) = My.Resources.Fish
        images(19) = My.Resources.Fly
        images(20) = My.Resources.Fox
        images(21) = My.Resources.Frog
        images(22) = My.Resources.Goose
        images(23) = My.Resources.Gorilla
        images(24) = My.Resources.Horse
        images(25) = My.Resources.Kangaroo
        images(26) = My.Resources.Koala
        images(27) = My.Resources.Leopard
        images(28) = My.Resources.Lion
        images(29) = My.Resources.Lizard
        images(30) = My.Resources.Llama
        images(31) = My.Resources.Magpie
        images(32) = My.Resources.Moose
        images(33) = My.Resources.Mouse
        images(34) = My.Resources.Numbat
        images(35) = My.Resources.Octopus
        images(36) = My.Resources.Panther
        images(37) = My.Resources.Penguin
        images(38) = My.Resources.Platypus
        images(39) = My.Resources.Prawn
        images(40) = My.Resources.Rabbit
        images(41) = My.Resources.Rhino
        images(42) = My.Resources.Seahorse
        images(43) = My.Resources.Sloth
        images(44) = My.Resources.Tasmaniandevil
        images(45) = My.Resources.Tiger
        images(46) = My.Resources.Turkey
        images(47) = My.Resources.Wallaby
        images(48) = My.Resources.Wolf
        images(49) = My.Resources.Zebra

        animals(0) = "Ant"
        animals(1) = "Antelope"
        animals(2) = "Bat"
        animals(3) = "Bear"
        animals(4) = "Bird"
        animals(5) = "Buffalo"
        animals(6) = "Butterfly"
        animals(7) = "Camel"
        animals(8) = "Cat"
        animals(9) = "Caterpillar"
        animals(10) = "Chicken"
        animals(11) = "Crab"
        animals(12) = "Crocodile"
        animals(13) = "Dog"
        animals(14) = "Duck"
        animals(15) = "Eagle"
        animals(16) = "Elephant"
        animals(17) = "Emu"
        animals(18) = "Fish"
        animals(19) = "Fly"
        animals(20) = "Fox"
        animals(21) = "Frog"
        animals(22) = "Goose"
        animals(23) = "Gorilla"
        animals(24) = "Horse"
        animals(25) = "Kangaroo"
        animals(26) = "Koala"
        animals(27) = "Leopard"
        animals(28) = "Lion"
        animals(29) = "Lizard"
        animals(30) = "Llama"
        animals(31) = "Magpie"
        animals(32) = "Moose"
        animals(33) = "Mouse"
        animals(34) = "Numbat"
        animals(35) = "Octopus"
        animals(36) = "Panther"
        animals(37) = "Penguin"
        animals(38) = "Platypus"
        animals(39) = "Prawn"
        animals(40) = "Rabbit"
        animals(41) = "Rhinoceros"
        animals(42) = "Seahorse"
        animals(43) = "Sloth"
        animals(44) = "Tasmanian Devil"
        animals(45) = "Tiger"
        animals(46) = "Turkey"
        animals(47) = "Wallaby"
        animals(48) = "Wolf"
        animals(49) = "Zebra"

        Do
            lblFeedback.Visible = False
            nextquestion = False 'prevents application from progressing to next question
            For i = 0 To 3
                numbers(i) = -1 'sets numbers to -1  so that a structure later on works
            Next


            Randomize()
            Do
                question = Int(50 * Rnd()) 'randomises number between 0 and 49
            Loop Until animals(question) <> options(0) 'means that the same question does not occur twice in a row

            pctQuestion.Image = images(question) 'changes to the image with the one corresponding with question

            options(0) = animals(question)

            For i = 1 To 3 'this structure randomises the options and makes sure that they are all different
                Do
                    random = Int(50 * Rnd()) 'random number between 0 and 49
                Loop Until animals(random) <> options(0) And animals(random) <> options(1) And animals(random) <> options(2) And animals(random) <> options(3)
                options(i) = animals(random)
            Next

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
        If btnOption1.Text = animals(question) Then 'increases score by 10 if correct
            score += 10
            lblFeedback.Text = positivefeedback(Int(5 * Rnd())) 'it randomises a positive feedback option choosing one from a possible 5
        Else
            score -= 2 'decreases score by two if incorrect
            lblFeedback.Text = negativefeedback(Int(3 * Rnd())) 'it randomises negative feedback choosing one from a possible three
        End If
        tmrFeedback.Enabled = True 'this enables the feedback timer for how long the feedback label is displayed
        lblScore.Text = "Score: " & score 'this updates the score
        lblFeedback.Visible = True 'this displays the feedback label
    End Sub

    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        If btnOption2.Text = animals(question) Then
            score += 10
            lblFeedback.Text = positivefeedback(Int(5 * Rnd()))
        Else
            score -= 2
            lblFeedback.Text = negativefeedback(Int(3 * Rnd()))
        End If
        tmrFeedback.Enabled = True
        lblScore.Text = "Score: " & score
        lblFeedback.Visible = True
    End Sub

    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        If btnOption3.Text = animals(question) Then
            score += 10
            lblFeedback.Text = positivefeedback(Int(5 * Rnd()))
        Else
            score -= 2
            lblFeedback.Text = negativefeedback(Int(3 * Rnd()))
        End If
        tmrFeedback.Enabled = True
        lblScore.Text = "Score: " & score
        lblFeedback.Visible = True
    End Sub

    Private Sub btnOption4_Click(sender As Object, e As EventArgs) Handles btnOption4.Click
        If btnOption4.Text = animals(question) Then
            score += 10
            lblFeedback.Text = positivefeedback(Int(5 * Rnd()))
        Else
            score -= 2
            lblFeedback.Text = negativefeedback(Int(3 * Rnd()))
        End If
        tmrFeedback.Enabled = True
        lblScore.Text = "Score: " & score
        lblFeedback.Visible = True
    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
        time = time - 1 'decreases time. in properties interval is 1000 so is each second
        lblTime.Text = "Time: " & time 'updates time label
        If time = 0 Then 'when time is zero it hides all buttons and labels from playing and displays restart button, gives final score
            tmrCountdown.Enabled = False
            btnOption1.Visible = False
            btnOption2.Visible = False
            btnOption3.Visible = False
            btnOption4.Visible = False
            pctQuestion.Visible = False
            lblScore.Visible = False
            lblTime.Visible = False
            btnPause.Visible = False
            btnHelp.Visible = False
            lblFeedback.Visible = False
            lblHeader.Text = "Numbat Naming"
            lblFinalScore.Text = "Your Final Score is " & score
            lblFinalScore.Visible = True
            btnGoToHighScores.Visible = True 'allows you to access highscores
            btnRestart.Visible = True
            Call NumbatNamingHighScores() 'checks if it is a highscore by accessing module
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
            btnPause.BackColor = Color.DarkOrange
        End If
    End Sub


    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        If playing = True Then
            btnOption1.Enabled = False 'this displays help and pauses game
            btnOption2.Enabled = False
            btnOption3.Enabled = False
            btnOption4.Enabled = False
            tmrCountdown.Enabled = False
            btnPause.Text = "Play"
            btnPause.BackColor = Color.Maroon
            playing = False
        End If
        frmHelp.lblHelp.Text = "Numbat Naming tests how well you know what animals look like." & vbNewLine & "To play click on the name that you think matches the picture" & vbNewLine & "You get 10 points for each correct answer but lose 2 for each incorrect" & vbNewLine & "The remaining time and score is displayed at the bottom of screen." & vbNewLine & "Exit returns to the main menu." & vbNewLine & "You have " & time & " seconds left to get as many points as possible. Press play to continue." & vbNewLine & "Good luck!"
        'the above makes help context sensitive
        frmHelp.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmHome.Show()
        Me.Close() 'by closing it resets for next time you enter it
    End Sub

    Private Sub tmrFeedback_Tick(sender As Object, e As EventArgs) Handles tmrFeedback.Tick
        nextquestion = True
        tmrFeedback.Enabled = False
    End Sub

    Public Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'this updates highscore name using variable from highscore process module if you get a highscore
        If HighScoreRank = 0 Then
            NNhighscorename(4) = NNhighscorename(3)
            NNhighscorename(3) = NNhighscorename(2)
            NNhighscorename(2) = NNhighscorename(1)
            NNhighscorename(1) = NNhighscorename(0)
        End If
        If HighScoreRank = 1 Then
            NNhighscorename(4) = NNhighscorename(3)
            NNhighscorename(3) = NNhighscorename(2)
            NNhighscorename(2) = NNhighscorename(1)
        End If
        If HighScoreRank = 2 Then
            NNhighscorename(4) = NNhighscorename(3)
            NNhighscorename(3) = NNhighscorename(2)
        End If
        If HighScoreRank = 3 Then
            NNhighscorename(4) = NNhighscorename(3)
        End If
        NNhighscorename(HighScoreRank) = " " + txtEnterName.Text
        lblEnterName.Visible = False
        txtEnterName.Visible = False
        btnEnter.Visible = False
        Dim FileNN As Integer 'this saves the name of the user who gets the highscore to a file
        FileNN = FreeFile()
        Debug.Print(FileNN)
        FileOpen(FileNN, "NNHighscorenames.txt", OpenMode.Output)
        PrintLine(FileNN, NNhighscorename(0))
        PrintLine(FileNN, NNhighscorename(1))
        PrintLine(FileNN, NNhighscorename(2))
        PrintLine(FileNN, NNhighscorename(3))
        PrintLine(FileNN, NNhighscorename(4))
        FileClose(FileNN)

    End Sub

    Private Sub btnGoToHighScores_Click(sender As Object, e As EventArgs) Handles btnGoToHighScores.Click
        Me.Close()
        frmHighScores.Show()
    End Sub

    Private Sub btnRestart_Click_1(sender As Object, e As EventArgs) Handles btnRestart.Click
        'it displays all buttons again and hides all end game buttons, resetting time and score when you click restart button
        btnOption1.Visible = True
        btnOption2.Visible = True
        btnOption3.Visible = True
        btnOption4.Visible = True
        pctQuestion.Visible = True
        lblScore.Visible = True
        lblTime.Visible = True
        btnPause.Visible = True
        btnHelp.Visible = True
        lblHeader.Text = "What animal is this?"
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