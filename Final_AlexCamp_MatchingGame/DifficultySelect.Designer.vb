<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectDifficulty
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
        Me.lstDifficultyLevels = New System.Windows.Forms.ListBox()
        Me.lblDifficultyLevels = New System.Windows.Forms.Label()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDifficultyLevels
        '
        Me.lstDifficultyLevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDifficultyLevels.FormattingEnabled = True
        Me.lstDifficultyLevels.ItemHeight = 29
        Me.lstDifficultyLevels.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.lstDifficultyLevels.Location = New System.Drawing.Point(50, 65)
        Me.lstDifficultyLevels.Name = "lstDifficultyLevels"
        Me.lstDifficultyLevels.Size = New System.Drawing.Size(173, 120)
        Me.lstDifficultyLevels.TabIndex = 0
        '
        'lblDifficultyLevels
        '
        Me.lblDifficultyLevels.AutoSize = True
        Me.lblDifficultyLevels.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyLevels.Location = New System.Drawing.Point(27, 24)
        Me.lblDifficultyLevels.Name = "lblDifficultyLevels"
        Me.lblDifficultyLevels.Size = New System.Drawing.Size(236, 29)
        Me.lblDifficultyLevels.TabIndex = 1
        Me.lblDifficultyLevels.Text = "Select difficulty level:"
        '
        'btnStartGame
        '
        Me.btnStartGame.Location = New System.Drawing.Point(69, 203)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(123, 39)
        Me.btnStartGame.TabIndex = 2
        Me.btnStartGame.Text = "Start Game!"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'frmSelectDifficulty
        '
        Me.AcceptButton = Me.btnStartGame
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.lblDifficultyLevels)
        Me.Controls.Add(Me.lstDifficultyLevels)
        Me.Name = "frmSelectDifficulty"
        Me.Text = "Select Difficulty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstDifficultyLevels As System.Windows.Forms.ListBox
    Friend WithEvents lblDifficultyLevels As System.Windows.Forms.Label
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
End Class
