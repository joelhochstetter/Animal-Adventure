Public Class frmHighScores

    Public Sub frmHighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the boxes displaying highscores are list boxes and the following adds the name of the user followed by their score for highscores
        listMMHighScores.Items.Add("1. " & MMhighscorename(0) & " " & MMhighscore(0))
        listMMHighScores.Items.Add("2. " & MMhighscorename(1) & " " & MMhighscore(1))
        listMMHighScores.Items.Add("3. " & MMhighscorename(2) & " " & MMhighscore(2))
        listMMHighScores.Items.Add("4. " & MMhighscorename(3) & " " & MMhighscore(3))
        listMMHighScores.Items.Add("5. " & MMhighscorename(4) & " " & MMhighscore(4))

        listSSHighScores.Items.Add("1. " & SShighscorename(0) & " " & SShighscore(0))
        listSSHighScores.Items.Add("2. " & SShighscorename(1) & " " & SShighscore(1))
        listSSHighScores.Items.Add("3. " & SShighscorename(2) & " " & SShighscore(2))
        listSSHighScores.Items.Add("4. " & SShighscorename(3) & " " & SShighscore(3))
        listSSHighScores.Items.Add("5. " & SShighscorename(4) & " " & SShighscore(4))

        listNNHighScores.Items.Add("1. " & NNhighscorename(0) & " " & NNhighscore(0))
        listNNHighScores.Items.Add("2. " & NNhighscorename(1) & " " & NNhighscore(1))
        listNNHighScores.Items.Add("3. " & NNhighscorename(2) & " " & NNhighscore(2))
        listNNHighScores.Items.Add("4. " & NNhighscorename(3) & " " & NNhighscore(3))
        listNNHighScores.Items.Add("5. " & NNhighscorename(4) & " " & NNhighscore(4))

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmHome.Show()
    End Sub
End Class