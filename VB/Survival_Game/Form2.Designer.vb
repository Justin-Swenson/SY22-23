﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Picturecharacter = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Zombie1 = New System.Windows.Forms.PictureBox()
        Me.Heart1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BulletPicture = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        CType(Me.Picturecharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zombie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulletPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This is you dont let the zombie get near you"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 2
        '
        'Picturecharacter
        '
        Me.Picturecharacter.Image = CType(resources.GetObject("Picturecharacter.Image"), System.Drawing.Image)
        Me.Picturecharacter.Location = New System.Drawing.Point(12, 11)
        Me.Picturecharacter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Picturecharacter.Name = "Picturecharacter"
        Me.Picturecharacter.Size = New System.Drawing.Size(173, 98)
        Me.Picturecharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picturecharacter.TabIndex = 3
        Me.Picturecharacter.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(504, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "This is a zombie shoot them before you get bit"
        '
        'Zombie1
        '
        Me.Zombie1.Image = CType(resources.GetObject("Zombie1.Image"), System.Drawing.Image)
        Me.Zombie1.Location = New System.Drawing.Point(12, 113)
        Me.Zombie1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Zombie1.Name = "Zombie1"
        Me.Zombie1.Size = New System.Drawing.Size(101, 98)
        Me.Zombie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Zombie1.TabIndex = 5
        Me.Zombie1.TabStop = False
        '
        'Heart1
        '
        Me.Heart1.Image = CType(resources.GetObject("Heart1.Image"), System.Drawing.Image)
        Me.Heart1.Location = New System.Drawing.Point(12, 215)
        Me.Heart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Heart1.Name = "Heart1"
        Me.Heart1.Size = New System.Drawing.Size(54, 61)
        Me.Heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Heart1.TabIndex = 11
        Me.Heart1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(519, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "These are your lives dont let them all disappear"
        '
        'BulletPicture
        '
        Me.BulletPicture.Image = CType(resources.GetObject("BulletPicture.Image"), System.Drawing.Image)
        Me.BulletPicture.Location = New System.Drawing.Point(12, 280)
        Me.BulletPicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BulletPicture.Name = "BulletPicture"
        Me.BulletPicture.Size = New System.Drawing.Size(41, 37)
        Me.BulletPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPicture.TabIndex = 13
        Me.BulletPicture.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(726, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "These are your bullets hover over where you want to shoot to shoot"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(491, 32)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Go into full screen for best experience"
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(601, 360)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(200, 88)
        Me.StartButton.TabIndex = 16
        Me.StartButton.Text = "Back to main game"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BulletPicture)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Heart1)
        Me.Controls.Add(Me.Zombie1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Picturecharacter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Instructions"
        CType(Me.Picturecharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zombie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulletPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Picturecharacter As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Zombie1 As PictureBox
    Friend WithEvents Heart1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BulletPicture As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StartButton As Button
End Class
