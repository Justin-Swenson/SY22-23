<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.Ibutton = New System.Windows.Forms.Button()
        Me.UButton = New System.Windows.Forms.Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Heart1 = New System.Windows.Forms.PictureBox()
        Me.Heart2 = New System.Windows.Forms.PictureBox()
        Me.Heart3 = New System.Windows.Forms.PictureBox()
        Me.FSLabel = New System.Windows.Forms.Label()
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.FLabel = New System.Windows.Forms.Label()
        Me.Lostlable = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Picturecharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulletPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zombie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zombie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picturecharacter
        '
        Me.Picturecharacter.Image = CType(resources.GetObject("Picturecharacter.Image"), System.Drawing.Image)
        Me.Picturecharacter.Location = New System.Drawing.Point(341, -1)
        Me.Picturecharacter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Picturecharacter.Name = "Picturecharacter"
        Me.Picturecharacter.Size = New System.Drawing.Size(173, 98)
        Me.Picturecharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picturecharacter.TabIndex = 0
        Me.Picturecharacter.TabStop = False
        '
        'BulletPicture
        '
        Me.BulletPicture.Image = CType(resources.GetObject("BulletPicture.Image"), System.Drawing.Image)
        Me.BulletPicture.Location = New System.Drawing.Point(496, 7)
        Me.BulletPicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BulletPicture.Name = "BulletPicture"
        Me.BulletPicture.Size = New System.Drawing.Size(23, 15)
        Me.BulletPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPicture.TabIndex = 1
        Me.BulletPicture.TabStop = False
        '
        'WallPicture
        '
        Me.WallPicture.Image = CType(resources.GetObject("WallPicture.Image"), System.Drawing.Image)
        Me.WallPicture.Location = New System.Drawing.Point(293, 50)
        Me.WallPicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WallPicture.Name = "WallPicture"
        Me.WallPicture.Size = New System.Drawing.Size(245, 98)
        Me.WallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPicture.TabIndex = 2
        Me.WallPicture.TabStop = False
        '
        'Zombie1
        '
        Me.Zombie1.Image = CType(resources.GetObject("Zombie1.Image"), System.Drawing.Image)
        Me.Zombie1.Location = New System.Drawing.Point(829, 334)
        Me.Zombie1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Zombie1.Name = "Zombie1"
        Me.Zombie1.Size = New System.Drawing.Size(101, 98)
        Me.Zombie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Zombie1.TabIndex = 3
        Me.Zombie1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 15000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1500
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Mongolian Baiti", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(281, 177)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(274, 62)
        Me.StartButton.TabIndex = 4
        Me.StartButton.Text = "START!"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Score:"
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(17, 53)
        Me.ScoreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(20, 29)
        Me.ScoreLabel.TabIndex = 6
        Me.ScoreLabel.Text = " "
        '
        'Zombie2
        '
        Me.Zombie2.Image = CType(resources.GetObject("Zombie2.Image"), System.Drawing.Image)
        Me.Zombie2.Location = New System.Drawing.Point(612, 359)
        Me.Zombie2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Zombie2.Name = "Zombie2"
        Me.Zombie2.Size = New System.Drawing.Size(101, 98)
        Me.Zombie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Zombie2.TabIndex = 7
        Me.Zombie2.TabStop = False
        '
        'Ibutton
        '
        Me.Ibutton.Font = New System.Drawing.Font("Mongolian Baiti", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibutton.Location = New System.Drawing.Point(281, 247)
        Me.Ibutton.Margin = New System.Windows.Forms.Padding(4)
        Me.Ibutton.Name = "Ibutton"
        Me.Ibutton.Size = New System.Drawing.Size(274, 62)
        Me.Ibutton.TabIndex = 8
        Me.Ibutton.Text = "Instructions"
        Me.Ibutton.UseVisualStyleBackColor = True
        '
        'UButton
        '
        Me.UButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.UButton.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UButton.Location = New System.Drawing.Point(555, 11)
        Me.UButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UButton.Name = "UButton"
        Me.UButton.Size = New System.Drawing.Size(98, 71)
        Me.UButton.TabIndex = 9
        Me.UButton.Text = "upgrade fire rate"
        Me.UButton.UseVisualStyleBackColor = False
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 20000
        '
        'Heart1
        '
        Me.Heart1.Image = CType(resources.GetObject("Heart1.Image"), System.Drawing.Image)
        Me.Heart1.Location = New System.Drawing.Point(675, 11)
        Me.Heart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Heart1.Name = "Heart1"
        Me.Heart1.Size = New System.Drawing.Size(54, 61)
        Me.Heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Heart1.TabIndex = 10
        Me.Heart1.TabStop = False
        '
        'Heart2
        '
        Me.Heart2.Image = CType(resources.GetObject("Heart2.Image"), System.Drawing.Image)
        Me.Heart2.Location = New System.Drawing.Point(763, 11)
        Me.Heart2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Heart2.Name = "Heart2"
        Me.Heart2.Size = New System.Drawing.Size(54, 61)
        Me.Heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Heart2.TabIndex = 11
        Me.Heart2.TabStop = False
        '
        'Heart3
        '
        Me.Heart3.Image = CType(resources.GetObject("Heart3.Image"), System.Drawing.Image)
        Me.Heart3.Location = New System.Drawing.Point(851, 11)
        Me.Heart3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Heart3.Name = "Heart3"
        Me.Heart3.Size = New System.Drawing.Size(54, 61)
        Me.Heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Heart3.TabIndex = 12
        Me.Heart3.TabStop = False
        '
        'FSLabel
        '
        Me.FSLabel.AutoSize = True
        Me.FSLabel.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSLabel.Location = New System.Drawing.Point(401, 95)
        Me.FSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FSLabel.Name = "FSLabel"
        Me.FSLabel.Size = New System.Drawing.Size(118, 29)
        Me.FSLabel.TabIndex = 13
        Me.FSLabel.Text = " 9999999"
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        Me.Timer6.Interval = 1
        '
        'Timer7
        '
        Me.Timer7.Enabled = True
        Me.Timer7.Interval = 1000
        '
        'Timer8
        '
        Me.Timer8.Enabled = True
        '
        'Timer9
        '
        Me.Timer9.Interval = 1
        '
        'FLabel
        '
        Me.FLabel.AutoSize = True
        Me.FLabel.Font = New System.Drawing.Font("Mongolian Baiti", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FLabel.Location = New System.Drawing.Point(334, 53)
        Me.FLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FLabel.Name = "FLabel"
        Me.FLabel.Size = New System.Drawing.Size(196, 40)
        Me.FLabel.TabIndex = 14
        Me.FLabel.Text = "&Final Score:"
        '
        'Lostlable
        '
        Me.Lostlable.AutoSize = True
        Me.Lostlable.Font = New System.Drawing.Font("Mongolian Baiti", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lostlable.Location = New System.Drawing.Point(356, 7)
        Me.Lostlable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lostlable.Name = "Lostlable"
        Me.Lostlable.Size = New System.Drawing.Size(157, 40)
        Me.Lostlable.TabIndex = 16
        Me.Lostlable.Text = "You Lost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(556, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 22)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Cost: 1500"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1518, 925)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BulletPicture)
        Me.Controls.Add(Me.WallPicture)
        Me.Controls.Add(Me.Heart3)
        Me.Controls.Add(Me.Heart2)
        Me.Controls.Add(Me.Heart1)
        Me.Controls.Add(Me.Ibutton)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.FLabel)
        Me.Controls.Add(Me.FSLabel)
        Me.Controls.Add(Me.Picturecharacter)
        Me.Controls.Add(Me.Lostlable)
        Me.Controls.Add(Me.Zombie2)
        Me.Controls.Add(Me.Zombie1)
        Me.Controls.Add(Me.UButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Start"
        CType(Me.Picturecharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulletPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zombie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zombie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Ibutton As Button
    Friend WithEvents UButton As Button
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Heart1 As PictureBox
    Friend WithEvents Heart2 As PictureBox
    Friend WithEvents Heart3 As PictureBox
    Friend WithEvents FSLabel As Label
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents FLabel As Label
    Friend WithEvents Lostlable As Label
    Friend WithEvents Label5 As Label
End Class
