﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonkeyMaths
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonkeyMaths))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnOption1 = New System.Windows.Forms.Button()
        Me.btnOption2 = New System.Windows.Forms.Button()
        Me.btnOption3 = New System.Windows.Forms.Button()
        Me.btnOption4 = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFeedback = New System.Windows.Forms.Timer(Me.components)
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnGoToHighScores = New System.Windows.Forms.Button()
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblNewHighScore = New System.Windows.Forms.Label()
        Me.txtEnterName = New System.Windows.Forms.TextBox()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHeader.Font = New System.Drawing.Font("Candara", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(760, 50)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "What is the answer?"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQuestion.Font = New System.Drawing.Font("Candara", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.White
        Me.lblQuestion.Location = New System.Drawing.Point(242, 235)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(300, 100)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOption1
        '
        Me.btnOption1.BackColor = System.Drawing.Color.Transparent
        Me.btnOption1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOption1.FlatAppearance.BorderSize = 5
        Me.btnOption1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOption1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption1.Font = New System.Drawing.Font("Candara", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption1.ForeColor = System.Drawing.Color.White
        Me.btnOption1.Location = New System.Drawing.Point(12, 64)
        Me.btnOption1.Name = "btnOption1"
        Me.btnOption1.Size = New System.Drawing.Size(377, 220)
        Me.btnOption1.TabIndex = 3
        Me.btnOption1.UseVisualStyleBackColor = False
        '
        'btnOption2
        '
        Me.btnOption2.BackColor = System.Drawing.Color.Transparent
        Me.btnOption2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOption2.FlatAppearance.BorderSize = 5
        Me.btnOption2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOption2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption2.Font = New System.Drawing.Font("Candara", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption2.ForeColor = System.Drawing.Color.White
        Me.btnOption2.Location = New System.Drawing.Point(395, 62)
        Me.btnOption2.Name = "btnOption2"
        Me.btnOption2.Size = New System.Drawing.Size(377, 220)
        Me.btnOption2.TabIndex = 4
        Me.btnOption2.UseVisualStyleBackColor = False
        '
        'btnOption3
        '
        Me.btnOption3.BackColor = System.Drawing.Color.Transparent
        Me.btnOption3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOption3.FlatAppearance.BorderSize = 5
        Me.btnOption3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOption3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption3.Font = New System.Drawing.Font("Candara", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption3.ForeColor = System.Drawing.Color.White
        Me.btnOption3.Location = New System.Drawing.Point(12, 288)
        Me.btnOption3.Name = "btnOption3"
        Me.btnOption3.Size = New System.Drawing.Size(377, 220)
        Me.btnOption3.TabIndex = 5
        Me.btnOption3.UseVisualStyleBackColor = False
        '
        'btnOption4
        '
        Me.btnOption4.BackColor = System.Drawing.Color.Transparent
        Me.btnOption4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOption4.FlatAppearance.BorderSize = 5
        Me.btnOption4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOption4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption4.Font = New System.Drawing.Font("Candara", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption4.ForeColor = System.Drawing.Color.White
        Me.btnOption4.Location = New System.Drawing.Point(395, 288)
        Me.btnOption4.Name = "btnOption4"
        Me.btnOption4.Size = New System.Drawing.Size(377, 220)
        Me.btnOption4.TabIndex = 6
        Me.btnOption4.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Green
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(616, 514)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 36)
        Me.btnHelp.TabIndex = 9
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Green
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(697, 514)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Green
        Me.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblScore.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(12, 511)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(100, 42)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Score: 0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Green
        Me.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTime.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(118, 511)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 42)
        Me.lblTime.TabIndex = 12
        Me.lblTime.Text = "Time: 120"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrCountdown
        '
        Me.tmrCountdown.Interval = 1000
        '
        'tmrFeedback
        '
        Me.tmrFeedback.Interval = 500
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.Green
        Me.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.ForeColor = System.Drawing.Color.White
        Me.btnPause.Location = New System.Drawing.Point(535, 514)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 36)
        Me.btnPause.TabIndex = 7
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnGoToHighScores
        '
        Me.btnGoToHighScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGoToHighScores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGoToHighScores.FlatAppearance.BorderSize = 0
        Me.btnGoToHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoToHighScores.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToHighScores.ForeColor = System.Drawing.Color.White
        Me.btnGoToHighScores.Location = New System.Drawing.Point(342, 450)
        Me.btnGoToHighScores.Name = "btnGoToHighScores"
        Me.btnGoToHighScores.Size = New System.Drawing.Size(100, 36)
        Me.btnGoToHighScores.TabIndex = 52
        Me.btnGoToHighScores.Text = "High scores"
        Me.btnGoToHighScores.UseVisualStyleBackColor = False
        Me.btnGoToHighScores.Visible = False
        '
        'lblEnterName
        '
        Me.lblEnterName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEnterName.Font = New System.Drawing.Font("Candara", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEnterName.Location = New System.Drawing.Point(189, 300)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(200, 46)
        Me.lblEnterName.TabIndex = 51
        Me.lblEnterName.Text = "Your name:"
        Me.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEnterName.Visible = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnter.FlatAppearance.BorderSize = 0
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(342, 400)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 36)
        Me.btnEnter.TabIndex = 50
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        Me.btnEnter.Visible = False
        '
        'lblNewHighScore
        '
        Me.lblNewHighScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNewHighScore.Font = New System.Drawing.Font("Candara", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewHighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNewHighScore.Location = New System.Drawing.Point(12, 250)
        Me.lblNewHighScore.Name = "lblNewHighScore"
        Me.lblNewHighScore.Size = New System.Drawing.Size(760, 50)
        Me.lblNewHighScore.TabIndex = 49
        Me.lblNewHighScore.Text = "You got a new high score!"
        Me.lblNewHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNewHighScore.Visible = False
        '
        'txtEnterName
        '
        Me.txtEnterName.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEnterName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnterName.Font = New System.Drawing.Font("Candara", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterName.ForeColor = System.Drawing.Color.White
        Me.txtEnterName.Location = New System.Drawing.Point(395, 300)
        Me.txtEnterName.Name = "txtEnterName"
        Me.txtEnterName.Size = New System.Drawing.Size(200, 46)
        Me.txtEnterName.TabIndex = 48
        Me.txtEnterName.Visible = False
        '
        'lblFinalScore
        '
        Me.lblFinalScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFinalScore.Font = New System.Drawing.Font("Candara", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFinalScore.Location = New System.Drawing.Point(12, 150)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(760, 50)
        Me.lblFinalScore.TabIndex = 47
        Me.lblFinalScore.Text = "Your final score is:"
        Me.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinalScore.Visible = False
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.Green
        Me.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRestart.FlatAppearance.BorderSize = 0
        Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestart.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.ForeColor = System.Drawing.Color.White
        Me.btnRestart.Location = New System.Drawing.Point(616, 514)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 36)
        Me.btnRestart.TabIndex = 20
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        Me.btnRestart.Visible = False
        '
        'frmMonkeyMaths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnGoToHighScores)
        Me.Controls.Add(Me.lblEnterName)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblNewHighScore)
        Me.Controls.Add(Me.txtEnterName)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnOption4)
        Me.Controls.Add(Me.btnOption3)
        Me.Controls.Add(Me.btnOption2)
        Me.Controls.Add(Me.btnOption1)
        Me.Controls.Add(Me.lblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmMonkeyMaths"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monkey Maths"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnOption1 As System.Windows.Forms.Button
    Friend WithEvents btnOption2 As System.Windows.Forms.Button
    Friend WithEvents btnOption3 As System.Windows.Forms.Button
    Friend WithEvents btnOption4 As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrCountdown As System.Windows.Forms.Timer
    Friend WithEvents tmrFeedback As System.Windows.Forms.Timer
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnGoToHighScores As System.Windows.Forms.Button
    Friend WithEvents lblEnterName As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblNewHighScore As System.Windows.Forms.Label
    Friend WithEvents txtEnterName As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalScore As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
End Class
