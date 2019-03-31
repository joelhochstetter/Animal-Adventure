Module HighScoreProcess
    Public MMhighscore(4) As Integer
    Public SShighscore(4) As Integer
    Public NNhighscore(4) As Integer
    Public MMhighscorename(4) As String
    Public SShighscorename(4) As String
    Public NNhighscorename(4) As String
    Public HighScoreRank As Integer
    Dim finalscore As Integer 'this gives a local variable for score that can be used in all modules
    Public Sub MonkeyMathsHighScores()
        HighScoreRank = 5
        finalscore = frmMonkeyMaths.score
        For i = 0 To 4
            If finalscore > MMhighscore(i) Then 'this determines what the rank of the highscore is
                If i < HighScoreRank Then
                    HighScoreRank = i
                End If
            End If
        Next
        If HighScoreRank < 5 Then 'if it is a highscore it tells you and gives on screen prompts to enter name
            frmMonkeyMaths.lblNewHighScore.Visible = True
            frmMonkeyMaths.lblEnterName.Visible = True
            frmMonkeyMaths.txtEnterName.Visible = True
            frmMonkeyMaths.btnEnter.Visible = True
        End If
        'the following structures move previous highscores down depending on what rank the new highscore is. 
        If HighScoreRank = 0 Then
            MMhighscore(4) = MMhighscore(3)
            MMhighscore(3) = MMhighscore(2)
            MMhighscore(2) = MMhighscore(1)
            MMhighscore(1) = MMhighscore(0)
            MMhighscore(0) = finalscore
        End If
        If HighScoreRank = 1 Then
            MMhighscore(4) = MMhighscore(3)
            MMhighscore(3) = MMhighscore(2)
            MMhighscore(2) = MMhighscore(1)
            MMhighscore(1) = finalscore
        End If
        If HighScoreRank = 2 Then
            MMhighscore(4) = MMhighscore(3)
            MMhighscore(3) = MMhighscore(2)
            MMhighscore(2) = finalscore
        End If
        If HighScoreRank = 3 Then
            MMhighscore(4) = MMhighscore(3)
            MMhighscore(3) = finalscore
        End If

        'name is assigned from enter button on the form
        'this updates the file storing highscores for Monkey maths
        Dim FileMM As Integer
        FileMM = FreeFile()
        Debug.Print(FileMM)
        FileOpen(FileMM, "MMHighscore.text", OpenMode.Output)
        PrintLine(FileMM, MMhighscore(0))
        PrintLine(FileMM, MMhighscore(1))
        PrintLine(FileMM, MMhighscore(2))
        PrintLine(FileMM, MMhighscore(3))
        PrintLine(FileMM, MMhighscore(4))
        FileClose(FileMM)

    End Sub
    Public Sub SpiderSpellingHighScores()
        HighScoreRank = 5
        finalscore = frmSpiderSpelling.score
        For i = 0 To 4
            If finalscore > SShighscore(i) Then 'this determines what the rank of the highscore is
                If i < HighScoreRank Then
                    HighScoreRank = i
                End If
            End If
        Next
        If HighScoreRank < 5 Then 'if it is a highscore it tells you and gives on screen prompts to enter name
            frmSpiderSpelling.lblNewHighScore.Visible = True
            frmSpiderSpelling.lblEnterName.Visible = True
            frmSpiderSpelling.txtEnterName.Visible = True
            frmSpiderSpelling.btnEnter.Visible = True
        End If
        'the following structures move previous highscores down depending on what rank the new highscore is. 
        If HighScoreRank = 0 Then
            SShighscore(4) = SShighscore(3)
            SShighscore(3) = SShighscore(2)
            SShighscore(2) = SShighscore(1)
            SShighscore(1) = SShighscore(0)
            SShighscore(0) = finalscore
        End If
        If HighScoreRank = 1 Then
            SShighscore(4) = SShighscore(3)
            SShighscore(3) = SShighscore(2)
            SShighscore(2) = SShighscore(1)
            SShighscore(1) = finalscore
        End If
        If HighScoreRank = 2 Then
            SShighscore(4) = SShighscore(3)
            SShighscore(3) = SShighscore(2)
            SShighscore(2) = finalscore
        End If
        If HighScoreRank = 3 Then
            SShighscore(4) = SShighscore(3)
            SShighscore(3) = finalscore
        End If
        'name is assigned from enter button on the form
        'this updates the file storing highscores for Spider Spelling
        Dim FileSS As Integer
        FileSS = FreeFile()
        Debug.Print(FileSS)
        FileOpen(FileSS, "SSHighscore.text", OpenMode.Output)
        PrintLine(FileSS, SShighscore(0))
        PrintLine(FileSS, SShighscore(1))
        PrintLine(FileSS, SShighscore(2))
        PrintLine(FileSS, SShighscore(3))
        PrintLine(FileSS, SShighscore(4))
        FileClose(FileSS)

    End Sub
    Public Sub NumbatNamingHighScores()
        HighScoreRank = 5
        finalscore = frmNumbatNaming.score
        For i = 0 To 4
            If finalscore > NNhighscore(i) Then 'this determines what the rank of the highscore is
                If i < HighScoreRank Then
                    HighScoreRank = i
                End If
            End If
        Next
        If HighScoreRank < 5 Then 'if it is a highscore it tells you and gives on screen prompts to enter name
            frmNumbatNaming.lblNewHighScore.Visible = True
            frmNumbatNaming.lblEnterName.Visible = True
            frmNumbatNaming.txtEnterName.Visible = True
            frmNumbatNaming.btnEnter.Visible = True
        End If
        'the following structures move previous highscores down depending on what rank the new highscore is. 
        If HighScoreRank = 0 Then
            NNhighscore(4) = NNhighscore(3)
            NNhighscore(3) = NNhighscore(2)
            NNhighscore(2) = NNhighscore(1)
            NNhighscore(1) = NNhighscore(0)
            NNhighscore(0) = finalscore
        End If
        If HighScoreRank = 1 Then
            NNhighscore(4) = NNhighscore(3)
            NNhighscore(3) = NNhighscore(2)
            NNhighscore(2) = NNhighscore(1)
            NNhighscore(1) = finalscore
        End If
        If HighScoreRank = 2 Then
            NNhighscore(4) = NNhighscore(3)
            NNhighscore(3) = NNhighscore(2)
            NNhighscore(2) = finalscore
        End If
        If HighScoreRank = 3 Then
            NNhighscore(4) = NNhighscore(3)
            NNhighscore(3) = finalscore
        End If
        'name is assigned from enter button on the form
        'this updates the file storing highscores for numbat naming
        Dim FileNN As Integer
        FileNN = FreeFile()
        Debug.Print(FileNN)
        FileOpen(FileNN, "NNHighscore.txt", OpenMode.Output)
        PrintLine(FileNN, NNhighscore(0))
        PrintLine(FileNN, NNhighscore(1))
        PrintLine(FileNN, NNhighscore(2))
        PrintLine(FileNN, NNhighscore(3))
        PrintLine(FileNN, NNhighscore(4))
        FileClose(FileNN)

    End Sub

End Module
