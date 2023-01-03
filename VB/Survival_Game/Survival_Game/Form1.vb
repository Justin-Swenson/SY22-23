Public Class Form1
    Const speed As Integer = 10
    Dim health As Integer
    Dim player As New Point(293, 51)
    Dim zombiestart As New Point(359, 280)
    Dim zombiestart2 As New Point(626, 280)
    Dim zombienumber As Integer
    Dim wave As Integer
    Const a As Integer = 1
    Dim points As Integer
    Dim aim As New Point
    Dim gun As New Point(369, 11)


    Private Sub zombie()
        Timer2.Enabled = True
        If Zombie1.Bounds.IntersectsWith(WallPicture.Bounds) Then
            Zombie1.Location = zombiestart2
        End If
        If Zombie2.Bounds.IntersectsWith(WallPicture.Bounds) Then
            Zombie2.Location = zombiestart
        End If

    End Sub
    Private Sub shot()
        If Zombie1.Bounds.IntersectsWith(BulletPicture.Bounds) Then points = points + 100
        If Zombie1.Bounds.IntersectsWith(BulletPicture.Bounds) Then
            Zombie1.Location = zombiestart2
        End If
        If Zombie2.Bounds.IntersectsWith(BulletPicture.Bounds) Then points = points + 100
        If Zombie2.Bounds.IntersectsWith(BulletPicture.Bounds) Then
            Zombie2.Location = zombiestart
        End If
    End Sub
    Private Sub shoot()
        aim = MousePosition
        If BulletPicture.Location = New Point(BulletPicture.Location.X = 525) Or BulletPicture.Location = New Point(BulletPicture.Location.Y = 200) Then
            BulletPicture.Location = gun
        End If
        If BulletPicture.Location = gun Then BulletPicture.Location = aim
        shot()
        ScoreLabel.Text = points
    End Sub
    Private Sub start()
        zombie()
        shot()
        walk()
    End Sub

    Private Sub walk()
        Zombie1.Location = New Point(Zombie1.Location.X - 1, Zombie1.Location.Y - 1)
        Do While Zombie1.Location = New Point(Zombie1.Location.X = 626, Zombie1.Location.Y)
            Zombie1.Location = New Point(Zombie1.Location.X - 5, Zombie1.Location.Y)
        Loop

        Do While Zombie1.Location = New Point(Zombie1.Location.X, Zombie1.Location.Y < 41)
            Zombie1.Location = New Point(Zombie1.Location.X, Zombie1.Location.Y - 5)
        Loop
        Zombie2.Location = New Point(Zombie2.Location.X - 1, Zombie2.Location.Y - 1)
        Do While Zombie2.Location = New Point(Zombie2.Location.X = 626, Zombie2.Location.Y)
            Zombie2.Location = New Point(Zombie2.Location.X - 5, Zombie2.Location.Y)
        Loop

        Do While Zombie2.Location = New Point(Zombie2.Location.X, Zombie2.Location.Y < 41)
            Zombie2.Location = New Point(Zombie2.Location.X, Zombie2.Location.Y - 5)
        Loop
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        zombie()
        walk()
        Update()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub


    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        start()

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Zombie1.Image.Clone()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        BulletPicture.Location = gun
        shoot()
    End Sub
End Class

