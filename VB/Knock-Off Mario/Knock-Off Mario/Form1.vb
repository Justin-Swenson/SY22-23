Imports System.Security.Cryptography.Xml

Public Class Form1
    Dim movespeed As Integer = 15
    Dim isjumping As Boolean
    Dim isjumping2 As Boolean
    Dim isdead As Boolean
    Dim coin As Integer
    Dim deathmessagebox As Boolean
    Dim e1 As New Enemy
    Dim e2 As New Enemy

    Dim res As Boolean

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Start()
            Case Keys.Left
                tmrLeft.Start()
        End Select
        If isjumping2 = True Then
            Select Case e.KeyCode
                Case Keys.Up
                    tmrUp.Start()
                    isjumping = True
            End Select
        End If

    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        Picplayer.Left += movespeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isjumping = True
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        Picplayer.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        Picplayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load() Handles Me.Load
        tmrGameLogic.Start()
        e1.picture = EnemyPictureBox
        e1.speed = 5
        e1.boundaryplatfrom = PictureBox2
        e2.picture = Enemy2
        e2.boundaryplatfrom = PictureBox3
        e2.speed = 5

    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If Picplayer.Bounds.IntersectsWith(Picair.Bounds) Then
            If isjumping = False Then
                tmrGravity.Start()
            End If
        ElseIf Picplayer.Bounds.IntersectsWith(picground.Bounds) Then
            tmrGravity.Stop()
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Bound" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
            If b.Tag = "Coin" Then
                If b.Visible And Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    coin += 1
                    Scorelabel.Text = coin
                    Scorelabel.Text = "Points: " & coin
                    If Res = True Then
                        b.Visible = True
                    End If
                    res = False
                End If
            End If '' 1AZhJB5E
            If b.Tag = "Enemy" Then
                If b.Visible And Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    coin -= 1
                    isdead = True
                    Scorelabel.Text = coin
                    Scorelabel.Text = "Points: " & coin
                End If
            End If
        Next
        If isdead = True Then
            deathanimation()
        End If
        If isdead = True Then
            deathmessagebox = True
        End If
        e1.move()
        e2.move()

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        Picplayer.Top += movespeed
    End Sub
    Private Sub deathanimation()
        Picplayer.Image = Image.FromFile("deadmario.png")
        Picplayer.Top -= 75
        Tmrdeathanimation.Start()
        tmrLeft.Stop()
        tmrright.Stop()
        tmrUp.Stop()
        tmrGameLogic.Stop()
        tmrGravity.Stop()
    End Sub

    Private Sub tmrdead_Tick(sender As Object, e As EventArgs) Handles tmrdead.Tick
        Picplayer.Top += 5
    End Sub
    Private Sub Tmrdeathanimation_Tick(sender As Object, e As EventArgs) Handles Tmrdeathanimation.Tick
        tmrdead.Start()
        If isdead = True And Picplayer.Location.Y > 380 And deathmessagebox = True Then
            deathmessagebox = False
            Dim m = MessageBox.Show("Do you want to restart", "Knock off mario", MessageBoxButtons.YesNo)

            If m = DialogResult.Yes Then
                restart()
            End If
            If m = DialogResult.No Then
                Me.Close()
            End If
        End If

    End Sub
    Private Sub restart()
        isdead = False
        Picplayer.Image = Image.FromFile("alivemario.png")
        tmrdead.Stop()
        Tmrdeathanimation.Stop()
        Form1_Load()
        Picplayer.Left = 12
        Picplayer.Top = 314
        EnemyPictureBox.Left = 54
        EnemyPictureBox.Top = 56
        EnemyPictureBox.Visible = True
        res = True
    End Sub
End Class
