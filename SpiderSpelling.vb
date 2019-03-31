Public Class frmSpiderSpelling

    Public score As Integer
    Dim time As Integer
    Dim nextquestion As Boolean
    Dim options(3) As String
    Dim numbers(3) As Integer
    Dim question As Integer
    Dim images(49) As Image
    Dim animals(49) As String
    Dim incorrect1(49) As String
    Dim incorrect2(49) As String
    Dim incorrect3(49) As String
    Dim answer As String
    Dim random As Integer
    Dim positivefeedback(4) As String
    Dim negativefeedback(2) As String
    Dim playing As Boolean

    Private Sub frmSpiderSpelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'each animal has a corresponding image + 3 incorrect answers
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

        incorrect1(0) = "Annt"
        incorrect1(1) = "Antlope"
        incorrect1(2) = "Bet"
        incorrect1(3) = "Bare"
        incorrect1(4) = "Berd"
        incorrect1(5) = "Bufalo"
        incorrect1(6) = "Buterfly"
        incorrect1(7) = "Kamel"
        incorrect1(8) = "Kat"
        incorrect1(9) = "Caterpiller"
        incorrect1(10) = "Chooken"
        incorrect1(11) = "Crabe"
        incorrect1(12) = "Crocodisle"
        incorrect1(13) = "Doge"
        incorrect1(14) = "Duk"
        incorrect1(15) = "Ealge"
        incorrect1(16) = "Elefant"
        incorrect1(17) = "Eemu"
        incorrect1(18) = "Fesh"
        incorrect1(19) = "Flie"
        incorrect1(20) = "Focs"
        incorrect1(21) = "Frogg"
        incorrect1(22) = "Goos"
        incorrect1(23) = "Gorila"
        incorrect1(24) = "Hors"
        incorrect1(25) = "Kangeroo"
        incorrect1(26) = "Kwala"
        incorrect1(27) = "Lepard"
        incorrect1(28) = "Lyon"
        incorrect1(29) = "Lizerd"
        incorrect1(30) = "Lama"
        incorrect1(31) = "Maggpie"
        incorrect1(32) = "Mouse"
        incorrect1(33) = "Moose"
        incorrect1(34) = "Nubmat"
        incorrect1(35) = "Octopuss"
        incorrect1(36) = "Pannther"
        incorrect1(37) = "Pengwin"
        incorrect1(38) = "Platipus"
        incorrect1(39) = "Pawn"
        incorrect1(40) = "Rabit"
        incorrect1(41) = "Rinocerous"
        incorrect1(42) = "Seahors"
        incorrect1(43) = "Slothe"
        incorrect1(44) = "Tasmanian Devle"
        incorrect1(45) = "Tyger"
        incorrect1(46) = "Turkee"
        incorrect1(47) = "Wabbaly"
        incorrect1(48) = "Woolf"
        incorrect1(49) = "Zeebra"

        incorrect2(0) = "Ent"
        incorrect2(1) = "Entelope"
        incorrect2(2) = "Batt"
        incorrect2(3) = "Ber"
        incorrect2(4) = "Burd"
        incorrect2(5) = "Buffallo"
        incorrect2(6) = "Buttifly"
        incorrect2(7) = "Camle"
        incorrect2(8) = "Catt"
        incorrect2(9) = "Catterpillar"
        incorrect2(10) = "Chiken"
        incorrect2(11) = "Crabb"
        incorrect2(12) = "Crocedile"
        incorrect2(13) = "Dogg"
        incorrect2(14) = "Duc"
        incorrect2(15) = "Eagel"
        incorrect2(16) = "Eliphant"
        incorrect2(17) = "Emyou"
        incorrect2(18) = "Fissh"
        incorrect2(19) = "Flly"
        incorrect2(20) = "Focks"
        incorrect2(21) = "Freg"
        incorrect2(22) = "Gouse"
        incorrect2(23) = "Gorrilla"
        incorrect2(24) = "Hoarse"
        incorrect2(25) = "Kangaro"
        incorrect2(26) = "Kooala"
        incorrect2(27) = "Leperd"
        incorrect2(28) = "Lieon"
        incorrect2(29) = "Lizzard"
        incorrect2(30) = "Lahma"
        incorrect2(31) = "Magpy"
        incorrect2(32) = "Moos"
        incorrect2(33) = "Mous"
        incorrect2(34) = "Nummbat"
        incorrect2(35) = "Octipus"
        incorrect2(36) = "Penther"
        incorrect2(37) = "Pengwen"
        incorrect2(38) = "Plattypus"
        incorrect2(39) = "Prorn"
        incorrect2(40) = "Rabbet"
        incorrect2(41) = "Rhinocoros"
        incorrect2(42) = "Seaorse"
        incorrect2(43) = "Slooth"
        incorrect2(44) = "Tamsanian Devil"
        incorrect2(45) = "Tigger"
        incorrect2(46) = "Terrkey"
        incorrect2(47) = "Walaby"
        incorrect2(48) = "Wollf"
        incorrect2(49) = "Zebrer"

        incorrect3(0) = "Antt"
        incorrect3(1) = "Enterlope"
        incorrect3(2) = "Bta"
        incorrect3(3) = "Beir"
        incorrect3(4) = "Birrd"
        incorrect3(5) = "Bufallo"
        incorrect3(6) = "Butifly"
        incorrect3(7) = "Cammel"
        incorrect3(8) = "Katt"
        incorrect3(9) = "Caterpilar"
        incorrect3(10) = "Chickin"
        incorrect3(11) = "Carb"
        incorrect3(12) = "Crocodil"
        incorrect3(13) = "Dug"
        incorrect3(14) = "Duq"
        incorrect3(15) = "Eagerl"
        incorrect3(16) = "Elerfant"
        incorrect3(17) = "Eamue"
        incorrect3(18) = "Fis"
        incorrect3(19) = "Fli"
        incorrect3(20) = "Foqs"
        incorrect3(21) = "Frerg"
        incorrect3(22) = "Gose"
        incorrect3(23) = "Gorrila"
        incorrect3(24) = "Hoors"
        incorrect3(25) = "Kangero"
        incorrect3(26) = "Koerla"
        incorrect3(27) = "Lepard"
        incorrect3(28) = "Lien"
        incorrect3(29) = "Lizzarrd"
        incorrect3(30) = "Lahmer"
        incorrect3(31) = "Maggpy"
        incorrect3(32) = "Mose"
        incorrect3(33) = "Mose"
        incorrect3(34) = "Numbet"
        incorrect3(35) = "Octerpus"
        incorrect3(36) = "Panthar"
        incorrect3(37) = "Pengwyn"
        incorrect3(38) = "Platypuss"
        incorrect3(39) = "Prorm"
        incorrect3(40) = "Rabitt"
        incorrect3(41) = "Rhinocores"
        incorrect3(42) = "Seaherse"
        incorrect3(43) = "Sloht"
        incorrect3(44) = "Tasmanean Devil"
        incorrect3(45) = "Tieger"
        incorrect3(46) = "Turrkey"
        incorrect3(47) = "Wabaly"
        incorrect3(48) = "Wofl"
        incorrect3(49) = "Zerbrer"

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
            options(1) = incorrect1(question)
            options(2) = incorrect2(question)
            options(3) = incorrect3(question)

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
        If btnOption1.Text = animals(question) Then
            score += 10 'increases score by 10 if correct
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
            lblHeader.Text = "Spider Spelling"
            lblFinalScore.Text = "Your final score is " & score
            lblFinalScore.Visible = True
            btnGoToHighScores.Visible = True 'allows you to access highscores
            btnRestart.Visible = True
            Call SpiderSpellingHighScores() 'checks if it is a highscore by accessing module
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
            btnPause.BackColor = Color.Teal
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
        frmHelp.lblHelp.Text = "Spider Spelling tests you on how to spell different animals." & vbNewLine & "To play click on the word that you think is the correct spelling of the animal in the picture." & vbNewLine & "You get 10 points for each correct answer but lose 2 for each incorrect" & vbNewLine & "The remaining time and score is displayed at the bottom of the screen." & vbNewLine & "Exit returns to the main menu." & vbNewLine & "You have " & time & " seconds left to get as many points as possible. Press play to continue." & vbNewLine & "Good luck!"
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
        'this displayes feedback for 0.5 seconds
    End Sub

    Public Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'this updates highscore name using variable from highscore process module if you get a highscore
        If HighScoreRank = 0 Then
            SShighscorename(4) = SShighscorename(3)
            SShighscorename(3) = SShighscorename(2)
            SShighscorename(2) = SShighscorename(1)
            SShighscorename(1) = SShighscorename(0)
        End If
        If HighScoreRank = 1 Then
            SShighscorename(4) = SShighscorename(3)
            SShighscorename(3) = SShighscorename(2)
            SShighscorename(2) = SShighscorename(1)
        End If
        If HighScoreRank = 2 Then
            SShighscorename(4) = SShighscorename(3)
            SShighscorename(3) = SShighscorename(2)
        End If
        If HighScoreRank = 3 Then
            SShighscorename(4) = SShighscorename(3)
        End If

        SShighscorename(HighScoreRank) = " " + txtEnterName.Text
        lblEnterName.Visible = False
        txtEnterName.Visible = False
        btnEnter.Visible = False
        Dim FileSSnames As Integer 'this saves the name of the user who gets the highscore to a file
        FileSSnames = FreeFile()
        Debug.Print(FileSSnames)
        FileOpen(FileSSnames, "SSHighscorenames.text", OpenMode.Output)
        PrintLine(FileSSnames, SShighscorename(0))
        PrintLine(FileSSnames, SShighscorename(1))
        PrintLine(FileSSnames, SShighscorename(2))
        PrintLine(FileSSnames, SShighscorename(3))
        PrintLine(FileSSnames, SShighscorename(4))
        FileClose(FileSSnames)

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
        lblHeader.Text = "Which is the correct spelling?"
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