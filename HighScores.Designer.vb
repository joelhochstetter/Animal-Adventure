<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHighScores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listMMHighScores = New System.Windows.Forms.ListBox()
        Me.listSSHighScores = New System.Windows.Forms.ListBox()
        Me.listNNHighScores = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Candara", 70.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(760, 114)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "High Scores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listMMHighScores
        '
        Me.listMMHighScores.BackColor = System.Drawing.Color.Green
        Me.listMMHighScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMMHighScores.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listMMHighScores.ForeColor = System.Drawing.Color.White
        Me.listMMHighScores.FormattingEnabled = True
        Me.listMMHighScores.ItemHeight = 26
        Me.listMMHighScores.Items.AddRange(New Object() {"Monkey Maths"})
        Me.listMMHighScores.Location = New System.Drawing.Point(12, 150)
        Me.listMMHighScores.Name = "listMMHighScores"
        Me.listMMHighScores.Size = New System.Drawing.Size(245, 234)
        Me.listMMHighScores.TabIndex = 2
        '
        'listSSHighScores
        '
        Me.listSSHighScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.listSSHighScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listSSHighScores.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSSHighScores.ForeColor = System.Drawing.Color.White
        Me.listSSHighScores.FormattingEnabled = True
        Me.listSSHighScores.ItemHeight = 26
        Me.listSSHighScores.Items.AddRange(New Object() {"Spider Spelling"})
        Me.listSSHighScores.Location = New System.Drawing.Point(269, 150)
        Me.listSSHighScores.Name = "listSSHighScores"
        Me.listSSHighScores.Size = New System.Drawing.Size(245, 234)
        Me.listSSHighScores.TabIndex = 3
        '
        'listNNHighScores
        '
        Me.listNNHighScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.listNNHighScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listNNHighScores.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listNNHighScores.ForeColor = System.Drawing.Color.White
        Me.listNNHighScores.FormattingEnabled = True
        Me.listNNHighScores.ItemHeight = 26
        Me.listNNHighScores.Items.AddRange(New Object() {"Numbat Naming"})
        Me.listNNHighScores.Location = New System.Drawing.Point(527, 150)
        Me.listNNHighScores.Name = "listNNHighScores"
        Me.listNNHighScores.Size = New System.Drawing.Size(245, 234)
        Me.listNNHighScores.TabIndex = 4
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
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmHighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.listNNHighScores)
        Me.Controls.Add(Me.listSSHighScores)
        Me.Controls.Add(Me.listMMHighScores)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmHighScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "High Scores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listMMHighScores As System.Windows.Forms.ListBox
    Friend WithEvents listSSHighScores As System.Windows.Forms.ListBox
    Friend WithEvents listNNHighScores As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
