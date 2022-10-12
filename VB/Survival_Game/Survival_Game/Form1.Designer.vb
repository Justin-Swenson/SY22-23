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
        CType(Me.Picturecharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulletPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zombie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picturecharacter
        '
        Me.Picturecharacter.Image = CType(resources.GetObject("Picturecharacter.Image"), System.Drawing.Image)
        Me.Picturecharacter.Location = New System.Drawing.Point(342, -1)
        Me.Picturecharacter.Name = "Picturecharacter"
        Me.Picturecharacter.Size = New System.Drawing.Size(174, 98)
        Me.Picturecharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picturecharacter.TabIndex = 0
        Me.Picturecharacter.TabStop = False
        '
        'BulletPicture
        '
        Me.BulletPicture.Image = CType(resources.GetObject("BulletPicture.Image"), System.Drawing.Image)
        Me.BulletPicture.Location = New System.Drawing.Point(388, 156)
        Me.BulletPicture.Name = "BulletPicture"
        Me.BulletPicture.Size = New System.Drawing.Size(23, 15)
        Me.BulletPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPicture.TabIndex = 1
        Me.BulletPicture.TabStop = False
        '
        'WallPicture
        '
        Me.WallPicture.Image = CType(resources.GetObject("WallPicture.Image"), System.Drawing.Image)
        Me.WallPicture.Location = New System.Drawing.Point(293, 51)
        Me.WallPicture.Name = "WallPicture"
        Me.WallPicture.Size = New System.Drawing.Size(245, 99)
        Me.WallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPicture.TabIndex = 2
        Me.WallPicture.TabStop = False
        '
        'Zombie1
        '
        Me.Zombie1.Image = CType(resources.GetObject("Zombie1.Image"), System.Drawing.Image)
        Me.Zombie1.Location = New System.Drawing.Point(626, 316)
        Me.Zombie1.Name = "Zombie1"
        Me.Zombie1.Size = New System.Drawing.Size(101, 98)
        Me.Zombie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Zombie1.TabIndex = 3
        Me.Zombie1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Zombie1)
        Me.Controls.Add(Me.WallPicture)
        Me.Controls.Add(Me.BulletPicture)
        Me.Controls.Add(Me.Picturecharacter)
        Me.Name = "Form1"
        Me.Text = "Survive"
        CType(Me.Picturecharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulletPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zombie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Picturecharacter As PictureBox
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents BulletPicture As PictureBox
    Friend WithEvents WallPicture As PictureBox
    Friend WithEvents Zombie1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
