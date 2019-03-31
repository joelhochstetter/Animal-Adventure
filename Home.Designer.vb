<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.lblAnimalAdventure = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnHighscores = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMonkeyMaths = New System.Windows.Forms.Button()
        Me.btnSpiderSpelling = New System.Windows.Forms.Button()
        Me.btnNumbatNaming = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAnimalAdventure
        '
        Me.lblAnimalAdventure.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAnimalAdventure.Font = New System.Drawing.Font("Candara", 70.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimalAdventure.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAnimalAdventure.Location = New System.Drawing.Point(12, 9)
        Me.lblAnimalAdventure.Name = "lblAnimalAdventure"
        Me.lblAnimalAdventure.Size = New System.Drawing.Size(760, 100)
        Me.lblAnimalAdventure.TabIndex = 0
        Me.lblAnimalAdventure.Text = "Animal Adventure"
        Me.lblAnimalAdventure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(697, 514)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(616, 514)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 36)
        Me.btnHelp.TabIndex = 11
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnHighscores
        '
        Me.btnHighscores.BackColor = System.Drawing.Color.Green
        Me.btnHighscores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHighscores.FlatAppearance.BorderSize = 5
        Me.btnHighscores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHighscores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighscores.Font = New System.Drawing.Font("Candara", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighscores.ForeColor = System.Drawing.Color.White
        Me.btnHighscores.Location = New System.Drawing.Point(227, 400)
        Me.btnHighscores.Name = "btnHighscores"
        Me.btnHighscores.Size = New System.Drawing.Size(330, 100)
        Me.btnHighscores.TabIndex = 17
        Me.btnHighscores.Text = "High scores"
        Me.btnHighscores.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 537)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "© 2014 Chris Johnston and Joel Hochstetter"
        '
        'btnMonkeyMaths
        '
        Me.btnMonkeyMaths.BackColor = System.Drawing.Color.Green
        Me.btnMonkeyMaths.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMonkeyMaths.FlatAppearance.BorderSize = 5
        Me.btnMonkeyMaths.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMonkeyMaths.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnMonkeyMaths.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonkeyMaths.Font = New System.Drawing.Font("Candara", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonkeyMaths.ForeColor = System.Drawing.Color.White
        Me.btnMonkeyMaths.Location = New System.Drawing.Point(12, 162)
        Me.btnMonkeyMaths.Name = "btnMonkeyMaths"
        Me.btnMonkeyMaths.Size = New System.Drawing.Size(250, 220)
        Me.btnMonkeyMaths.TabIndex = 19
        Me.btnMonkeyMaths.Text = "Monkey Maths"
        Me.btnMonkeyMaths.UseVisualStyleBackColor = False
        '
        'btnSpiderSpelling
        '
        Me.btnSpiderSpelling.BackColor = System.Drawing.Color.Green
        Me.btnSpiderSpelling.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSpiderSpelling.FlatAppearance.BorderSize = 5
        Me.btnSpiderSpelling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSpiderSpelling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnSpiderSpelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpiderSpelling.Font = New System.Drawing.Font("Candara", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpiderSpelling.ForeColor = System.Drawing.Color.White
        Me.btnSpiderSpelling.Location = New System.Drawing.Point(267, 162)
        Me.btnSpiderSpelling.Name = "btnSpiderSpelling"
        Me.btnSpiderSpelling.Size = New System.Drawing.Size(250, 220)
        Me.btnSpiderSpelling.TabIndex = 20
        Me.btnSpiderSpelling.Text = "Spider Spelling"
        Me.btnSpiderSpelling.UseVisualStyleBackColor = False
        '
        'btnNumbatNaming
        '
        Me.btnNumbatNaming.BackColor = System.Drawing.Color.Green
        Me.btnNumbatNaming.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNumbatNaming.FlatAppearance.BorderSize = 5
        Me.btnNumbatNaming.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNumbatNaming.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnNumbatNaming.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNumbatNaming.Font = New System.Drawing.Font("Candara", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumbatNaming.ForeColor = System.Drawing.Color.White
        Me.btnNumbatNaming.Location = New System.Drawing.Point(523, 162)
        Me.btnNumbatNaming.Name = "btnNumbatNaming"
        Me.btnNumbatNaming.Size = New System.Drawing.Size(250, 220)
        Me.btnNumbatNaming.TabIndex = 21
        Me.btnNumbatNaming.Text = "Numbat Naming"
        Me.btnNumbatNaming.UseVisualStyleBackColor = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnNumbatNaming)
        Me.Controls.Add(Me.btnSpiderSpelling)
        Me.Controls.Add(Me.btnMonkeyMaths)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHighscores)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblAnimalAdventure)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnimalAdventure As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnHighscores As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMonkeyMaths As System.Windows.Forms.Button
    Friend WithEvents btnSpiderSpelling As System.Windows.Forms.Button
    Friend WithEvents btnNumbatNaming As System.Windows.Forms.Button

End Class
