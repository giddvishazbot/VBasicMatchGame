<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblIntroImage1 = New System.Windows.Forms.Label()
        Me.lblIntroImage2 = New System.Windows.Forms.Label()
        Me.lblIntroImage3 = New System.Windows.Forms.Label()
        Me.mnuIntro = New System.Windows.Forms.MenuStrip()
        Me.mnuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIntro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWelcome.Font = New System.Drawing.Font("Wide Latin", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(0, 24)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(284, 98)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Welcome to my Matching Game"
        '
        'lblIntroImage1
        '
        Me.lblIntroImage1.AutoSize = True
        Me.lblIntroImage1.Font = New System.Drawing.Font("Webdings", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblIntroImage1.Location = New System.Drawing.Point(28, 134)
        Me.lblIntroImage1.Name = "lblIntroImage1"
        Me.lblIntroImage1.Size = New System.Drawing.Size(50, 36)
        Me.lblIntroImage1.TabIndex = 3
        Me.lblIntroImage1.Text = "C"
        '
        'lblIntroImage2
        '
        Me.lblIntroImage2.AutoSize = True
        Me.lblIntroImage2.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblIntroImage2.Location = New System.Drawing.Point(126, 141)
        Me.lblIntroImage2.Name = "lblIntroImage2"
        Me.lblIntroImage2.Size = New System.Drawing.Size(40, 30)
        Me.lblIntroImage2.TabIndex = 4
        Me.lblIntroImage2.Text = "E"
        '
        'lblIntroImage3
        '
        Me.lblIntroImage3.AutoSize = True
        Me.lblIntroImage3.Font = New System.Drawing.Font("Webdings", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblIntroImage3.Location = New System.Drawing.Point(202, 130)
        Me.lblIntroImage3.Name = "lblIntroImage3"
        Me.lblIntroImage3.Size = New System.Drawing.Size(70, 49)
        Me.lblIntroImage3.TabIndex = 5
        Me.lblIntroImage3.Text = "b"
        '
        'mnuIntro
        '
        Me.mnuIntro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlay, Me.mnuInfo, Me.mnuScore, Me.mnuExit})
        Me.mnuIntro.Location = New System.Drawing.Point(0, 0)
        Me.mnuIntro.Name = "mnuIntro"
        Me.mnuIntro.Size = New System.Drawing.Size(284, 24)
        Me.mnuIntro.TabIndex = 6
        Me.mnuIntro.Text = "MenuStrip1"
        '
        'mnuPlay
        '
        Me.mnuPlay.Name = "mnuPlay"
        Me.mnuPlay.Size = New System.Drawing.Size(41, 20)
        Me.mnuPlay.Text = "Play"
        '
        'mnuInfo
        '
        Me.mnuInfo.Name = "mnuInfo"
        Me.mnuInfo.Size = New System.Drawing.Size(40, 20)
        Me.mnuInfo.Text = "Info"
        '
        'mnuScore
        '
        Me.mnuScore.Name = "mnuScore"
        Me.mnuScore.Size = New System.Drawing.Size(48, 20)
        Me.mnuScore.Text = "Score"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "Exit"
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblIntroImage3)
        Me.Controls.Add(Me.lblIntroImage2)
        Me.Controls.Add(Me.lblIntroImage1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.mnuIntro)
        Me.MainMenuStrip = Me.mnuIntro
        Me.Name = "frmIntro"
        Me.Text = "Welcome"
        Me.mnuIntro.ResumeLayout(False)
        Me.mnuIntro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblIntroImage1 As System.Windows.Forms.Label
    Friend WithEvents lblIntroImage2 As System.Windows.Forms.Label
    Friend WithEvents lblIntroImage3 As System.Windows.Forms.Label
    Friend WithEvents mnuIntro As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
End Class
