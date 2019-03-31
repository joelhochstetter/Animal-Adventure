Public Class frmHome

    Private Sub btnMonkeyMaths_Click(sender As Object, e As EventArgs) Handles btnMonkeyMaths.Click
        frmMonkeyMaths.Show()
    End Sub

    Private Sub btnSpiderSpelling_Click(sender As Object, e As EventArgs) Handles btnSpiderSpelling.Click
        frmSpiderSpelling.Show()
    End Sub

    Private Sub btnNumbatNaming_Click1(sender As Object, e As EventArgs) Handles btnNumbatNaming.Click
        frmNumbatNaming.Show()
    End Sub

    Private Sub btnHighscores_Click(sender As Object, e As EventArgs) Handles btnHighscores.Click
        frmHighScores.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'This changes the info on the help screen as it is context sensitive
        frmHelp.lblHelp.Text = "Select the game mode you want to play." + vbNewLine + "- Monkey Maths is an adding and subtracting game." + vbNewLine + "- Spider Spelling tests you on how to spell different animals." + vbNewLine + "- Numbat Naming tests how well you know what animals look like." + vbNewLine + "To play click on the answer you think is correct." + vbNewLine + "You get 10 points for each correct answer but lose 2 for each incorrect." + vbNewLine + "The remaining time and score is displayed at the bottom of the screen." + vbNewLine + "You have 2 minutes to get as many points as possible." + vbNewLine + "Good luck and have fun!"
        frmHelp.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'this closes the program
        Me.Close()
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this reads the files containing highscore and adds them on startup so you can keep old highscores
        Dim FileMM As Integer
        FileMM = FreeFile()
        FileOpen(FileMM, "MMhighscore.text", OpenMode.Input)
        MMhighscore(0) = LineInput(FileMM)
        MMhighscore(1) = LineInput(FileMM)
        MMhighscore(2) = LineInput(FileMM)
        MMhighscore(3) = LineInput(FileMM)
        MMhighscore(4) = LineInput(FileMM)
        FileClose(FileMM)
        FileMM = FreeFile()
        FileOpen(FileMM, "MMhighscorenames.text", OpenMode.Input)
        MMhighscorename(0) = LineInput(FileMM)
        MMhighscorename(1) = LineInput(FileMM)
        MMhighscorename(2) = LineInput(FileMM)
        MMhighscorename(3) = LineInput(FileMM)
        MMhighscorename(4) = LineInput(FileMM)
        FileClose(FileMM)
        Dim FileSS As Integer
        FileSS = FreeFile()
        FileOpen(FileSS, "SShighscore.text", OpenMode.Input)
        SShighscore(0) = LineInput(FileSS)
        SShighscore(1) = LineInput(FileSS)
        SShighscore(2) = LineInput(FileSS)
        SShighscore(3) = LineInput(FileSS)
        SShighscore(4) = LineInput(FileSS)
        FileClose(FileSS)
        Dim FileSSName As Integer
        FileSSName = FreeFile()
        FileOpen(FileSS, "SShighscorenames.text", OpenMode.Input)
        SShighscorename(0) = LineInput(FileSSName)
        SShighscorename(1) = LineInput(FileSSName)
        SShighscorename(2) = LineInput(FileSSName)
        SShighscorename(3) = LineInput(FileSSName)
        SShighscorename(4) = LineInput(FileSSName)
        FileClose(FileSSName)
        Dim FileNN As Integer
        FileNN = FreeFile()
        FileOpen(FileNN, "NNhighscore.txt", OpenMode.Input)
        NNhighscore(0) = LineInput(FileNN)
        NNhighscore(1) = LineInput(FileNN)
        NNhighscore(2) = LineInput(FileNN)
        NNhighscore(3) = LineInput(FileNN)
        NNhighscore(4) = LineInput(FileNN)
        FileClose(FileNN)
        FileNN = FreeFile()
        FileOpen(FileNN, "NNhighscorenames.txt", OpenMode.Input)
        NNhighscorename(0) = LineInput(FileNN)
        NNhighscorename(1) = LineInput(FileNN)
        NNhighscorename(2) = LineInput(FileNN)
        NNhighscorename(3) = LineInput(FileNN)
        NNhighscorename(4) = LineInput(FileNN)
        FileClose(FileNN)


    End Sub


End Class