<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Picturecharacter = New System.Windows.Forms.PictureBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.BulletPicture = New System.Windows.Forms.PictureBox()
        Me.WallPicture = New System.Windows.Forms.PictureBox()
        Me.Zombie1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Zombie2 = New System.Windows.Forms.PictureBox()
        CType(Me.Picturecharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulletPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zombie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zombie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picturecharacter
        '
        Me.Picturecharacter.Image = CType(resources.GetObject("Picturecharacter.Image"), System.Drawing.Image)
        Me.Picturecharacter.Location = New System.Drawing.Point(256, -1)
        Me.Picturecharacter.Margin = New System.Windows.Forms.Padding(2)
        Me.Picturecharacter.Name = "Picturecharacter"
        Me.Picturecharacter.Size = New System.Drawing.Size(130, 80)
        Me.Picturecharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picturecharacter.TabIndex = 0
        Me.Picturecharacter.TabStop = False
        '
        'BulletPicture
        '
        Me.BulletPicture.Image = CType(resources.GetObject("BulletPicture.Image"), System.Drawing.Image)
        Me.BulletPicture.Location = New System.Drawing.Point(518, 199)
        Me.BulletPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.BulletPicture.Name = "BulletPicture"
        Me.BulletPicture.Size = New System.Drawing.Size(17, 12)
        Me.BulletPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPicture.TabIndex = 1
        Me.BulletPicture.TabStop = False
        '
        'WallPicture
        '
        Me.WallPicture.Image = CType(resources.GetObject("WallPicture.Image"), System.Drawing.Image)
        Me.WallPicture.Location = New System.Drawing.Point(220, 41)
        Me.WallPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.WallPicture.Name = "WallPicture"
        Me.WallPicture.Size = New System.Drawing.Size(184, 80)
        Me.WallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPicture.TabIndex = 2
        Me.WallPicture.TabStop = False
        '
        'Zombie1
        '
        Me.Zombie1.Image = CType(resources.GetObject("Zombie1.Image"), System.Drawing.Image)
        Me.Zombie1.Location = New System.Drawing.Point(626, 280)
        Me.Zombie1.Margin = New System.Windows.Forms.Padding(2)
        Me.Zombie1.Name = "Zombie1"
        Me.Zombie1.Size = New System.Drawing.Size(76, 80)
        Me.Zombie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Zombie1.TabIndex = 3
        Me.Zombie1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Mongolian Baiti", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(220, 161)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(167, 50)
        Me.StartButton.TabIndex = 4
        Me.StartButton.Text = "START!"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Score:"
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 1
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(13, 43)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(58, 23)
        Me.ScoreLabel.TabIndex = 6
        Me.ScoreLabel.Text = "Score"
        '
        'Zombie2
        '
        Me.Zombie2.Image = CType(resources.GetObject("Zombie2.Image"), System.Drawing.Image)
        Me.Zombie2.Location = New System.Drawing.Point(459, 292)
        Me.Zombie2.Margin = New System.Windows.Forms.Padding(2)
        Me.Zombie2.Name = "Zombie2"
        Me.Zombie2.Size = New System.Drawing.Size(76, 80)
        Me.Zombie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Zombie2.TabIndex = 7
        Me.Zombie2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(766, 421)
        Me.Controls.Add(Me.Zombie2)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Zombie1)
        Me.Controls.Add(Me.BulletPicture)
        Me.Controls.Add(Me.WallPicture)
        Me.Controls.Add(Me.Picturecharacter)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Survive"
        CType(Me.Picturecharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulletPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zombie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zombie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picturecharacter As PictureBox
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents BulletPicture As PictureBox
    Friend WithEvents WallPicture As PictureBox
    Friend WithEvents Zombie1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents StartButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Zombie2 As PictureBox
End Class
