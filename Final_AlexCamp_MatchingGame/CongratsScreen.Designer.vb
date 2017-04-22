<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWin
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
        Me.mnuVictory = New System.Windows.Forms.MenuStrip()
        Me.mnuRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScore = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.mnuVictory.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuVictory
        '
        Me.mnuVictory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRestart, Me.mnuExit, Me.mnuScore})
        Me.mnuVictory.Location = New System.Drawing.Point(0, 0)
        Me.mnuVictory.Name = "mnuVictory"
        Me.mnuVictory.Size = New System.Drawing.Size(284, 24)
        Me.mnuVictory.TabIndex = 3
        Me.mnuVictory.Text = "MenuStrip1"
        '
        'mnuRestart
        '
        Me.mnuRestart.Name = "mnuRestart"
        Me.mnuRestart.Size = New System.Drawing.Size(55, 20)
        Me.mnuRestart.Text = "Restart"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "Exit"
        '
        'mnuScore
        '
        Me.mnuScore.Name = "mnuScore"
        Me.mnuScore.Size = New System.Drawing.Size(48, 20)
        Me.mnuScore.Text = "Score"
        '
        'txtNameInput
        '
        Me.txtNameInput.Location = New System.Drawing.Point(31, 133)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(100, 20)
        Me.txtNameInput.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(28, 99)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(101, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Enter Name Please:"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(164, 133)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(54, 20)
        Me.txtScore.TabIndex = 6
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(161, 99)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "Score:"
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.Location = New System.Drawing.Point(82, 37)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(117, 29)
        Me.lblWin.TabIndex = 8
        Me.lblWin.Text = "You Win!"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(100, 190)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmWin
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.mnuVictory)
        Me.MainMenuStrip = Me.mnuVictory
        Me.Name = "frmWin"
        Me.Text = "Congratulations"
        Me.mnuVictory.ResumeLayout(False)
        Me.mnuVictory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuVictory As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuRestart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNameInput As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblWin As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
