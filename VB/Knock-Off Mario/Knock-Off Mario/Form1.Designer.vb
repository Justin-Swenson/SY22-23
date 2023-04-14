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
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        Me.Picair = New System.Windows.Forms.PictureBox()
        Me.picground = New System.Windows.Forms.PictureBox()
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Scorelabel = New System.Windows.Forms.Label()
        Me.coinpicturebox = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.EnemyPictureBox = New System.Windows.Forms.PictureBox()
        Me.tmrdead = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrdeathanimation = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrmove = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Tmrfalling = New System.Windows.Forms.Timer(Me.components)
        Me.tmrstartfalling = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coinpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picplayer
        '
        Me.Picplayer.BackColor = System.Drawing.Color.Transparent
        Me.Picplayer.Image = CType(resources.GetObject("Picplayer.Image"), System.Drawing.Image)
        Me.Picplayer.Location = New System.Drawing.Point(12, 326)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(64, 62)
        Me.Picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picplayer.TabIndex = 0
        Me.Picplayer.TabStop = False
        '
        'Picair
        '
        Me.Picair.Location = New System.Drawing.Point(0, 0)
        Me.Picair.Name = "Picair"
        Me.Picair.Size = New System.Drawing.Size(800, 338)
        Me.Picair.TabIndex = 1
        Me.Picair.TabStop = False
        '
        'picground
        '
        Me.picground.BackColor = System.Drawing.Color.Lime
        Me.picground.Location = New System.Drawing.Point(-1, 382)
        Me.picground.Name = "picground"
        Me.picground.Size = New System.Drawing.Size(801, 71)
        Me.picground.TabIndex = 2
        Me.picground.TabStop = False
        '
        'tmrright
        '
        Me.tmrright.Interval = 25
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 25
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 25
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 25
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(420, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 23)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox2.Location = New System.Drawing.Point(54, 127)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 23)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox3.Location = New System.Drawing.Point(626, 241)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(126, 23)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox4.Location = New System.Drawing.Point(329, 68)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(126, 23)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "Bound"
        '
        'Scorelabel
        '
        Me.Scorelabel.AutoSize = True
        Me.Scorelabel.Location = New System.Drawing.Point(49, 26)
        Me.Scorelabel.Name = "Scorelabel"
        Me.Scorelabel.Size = New System.Drawing.Size(51, 20)
        Me.Scorelabel.TabIndex = 7
        Me.Scorelabel.Text = "Points:"
        '
        'coinpicturebox
        '
        Me.coinpicturebox.BackColor = System.Drawing.Color.Transparent
        Me.coinpicturebox.Image = CType(resources.GetObject("coinpicturebox.Image"), System.Drawing.Image)
        Me.coinpicturebox.Location = New System.Drawing.Point(293, 241)
        Me.coinpicturebox.Name = "coinpicturebox"
        Me.coinpicturebox.Size = New System.Drawing.Size(63, 55)
        Me.coinpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coinpicturebox.TabIndex = 8
        Me.coinpicturebox.TabStop = False
        Me.coinpicturebox.Tag = "Coin"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(362, 241)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(63, 55)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "Coin"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(431, 241)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(63, 55)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "Coin"
        '
        'EnemyPictureBox
        '
        Me.EnemyPictureBox.Image = CType(resources.GetObject("EnemyPictureBox.Image"), System.Drawing.Image)
        Me.EnemyPictureBox.Location = New System.Drawing.Point(54, 56)
        Me.EnemyPictureBox.Name = "EnemyPictureBox"
        Me.EnemyPictureBox.Size = New System.Drawing.Size(75, 65)
        Me.EnemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPictureBox.TabIndex = 11
        Me.EnemyPictureBox.TabStop = False
        Me.EnemyPictureBox.Tag = "Enemy"
        '
        'tmrdead
        '
        Me.tmrdead.Interval = 25
        '
        'Tmrdeathanimation
        '
        Me.Tmrdeathanimation.Interval = 1000
        '
        'Tmrmove
        '
        Me.Tmrmove.Enabled = True
        Me.Tmrmove.Interval = 25
        '
        'Enemy2
        '
        Me.Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), System.Drawing.Image)
        Me.Enemy2.Location = New System.Drawing.Point(626, 163)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(75, 65)
        Me.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy2.TabIndex = 12
        Me.Enemy2.TabStop = False
        Me.Enemy2.Tag = "Enemy"
        '
        'Tmrfalling
        '
        '
        'tmrstartfalling
        '
        Me.tmrstartfalling.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.Picplayer)
        Me.Controls.Add(Me.EnemyPictureBox)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.coinpicturebox)
        Me.Controls.Add(Me.Scorelabel)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Picair)
        Me.Name = "Form1"
        Me.Text = "bad mario"
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coinpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picplayer As PictureBox
    Friend WithEvents Picair As PictureBox
    Friend WithEvents picground As PictureBox
    Friend WithEvents tmrright As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Scorelabel As Label
    Friend WithEvents coinpicturebox As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents EnemyPictureBox As PictureBox
    Friend WithEvents tmrdead As Timer
    Friend WithEvents Tmrdeathanimation As Timer
    Friend WithEvents Tmrmove As Timer
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Tmrfalling As Timer
    Friend WithEvents tmrstartfalling As Timer
End Class
