Public Class Form1
    Private Sub zombie()
        If Zombie1.Bounds.IntersectsWith(WallPicture.Bounds) Then
            Zombie1.Location = zombiestart2
        End If
        If Zombie2.Bounds.IntersectsWith(WallPicture.Bounds) Then
            Zombie2.Location = zombiestart
        End If

        FSLabel.Text = health
    End Sub
    Private Sub healths()
        If Zombie1.Bounds.IntersectsWith(WallPicture.Bounds) Then health = health - 1
        If Zombie2.Bounds.IntersectsWith(WallPicture.Bounds) Then health = health - 1
        If health = 1 Or health < 1 Then Heart3.Hide() Else Show()
        If health = 0 Or health < 0 Then Heart2.Hide() Else Show()
        If health = -1 Or health < -1 Then Heart1.Hide() Else Show()
        If health = 2 Then Heart3.Show()
        If health = 1 Then Heart2.Show()
        If health = 0 Then Heart1.Show()
        If health = -1 Then death()

    End Sub
    Private Sub death()
        If health = -1 Then WallPicture.Hide()
        If health = -1 Then BulletPicture.Hide()
        If health = -1 Then Zombie2.Location = New Point(Zombie2.Location.X = -9999, Zombie2.Location.Y = -9999)
        If health = -1 Then Zombie1.Hide()
        If health = -1 Then Zombie2.Hide()
        If health = -1 Then Zombie1.Location = New Point(Zombie1.Location.X = -9999, Zombie1.Location.Y = -9999)
        If health = -1 Then Picturecharacter.Hide()
        If health = -1 Then UButton.Hide()
        If health = -1 Then ScoreLabel.Hide()
        If health = -1 Then Label1.Hide()
        If health = -1 Then FSLabel.Text = points
        If health = -1 Then FSLabel.Show()
        If health = -1 Then FLabel.Show()
        If health = -1 Then Lostlable.Show()
    End Sub
    Private Sub shot()

        If BulletPicture.Location.X < Zombie1.Location.X + 102 And BulletPicture.Location.Y < Zombie1.Location.Y - 99 Then
            Zombie1.Location = zombiestart2
        End If
        If BulletPicture.Location.X < Zombie1.Location.X + 102 And BulletPicture.Location.Y < Zombie1.Location.Y - 99 Then
            points = points + 50 And Zombie1.Location = zombiestart2
        End If
        If BulletPicture.Location.X < Zombie2.Location.X + 102 And BulletPicture.Location.Y < Zombie2.Location.Y - 99 Then
            Zombie2.Location = zombiestart
        End If
        If BulletPicture.Location.X < Zombie2.Location.X + 102 And BulletPicture.Location.Y < Zombie2.Location.Y - 99 Then
            points = points + 50 And Zombie2.Location = zombiestart
        End If

    End Sub
    Private Sub shoot()
        aim = mouseposition2
        mouseposition2 = New Point(MousePosition.X, MousePosition.Y)
        If BulletPicture.Location = New Point(BulletPicture.Location.X = 525) Or BulletPicture.Location = New Point(BulletPicture.Location.Y = 200) Then
            BulletPicture.Location = gun
        End If
        If BulletPicture.Location = gun Then BulletPicture.Location = aim

        ScoreLabel.Text = points
        If BulletPicture.Bounds.IntersectsWith(Zombie1.Bounds) Or BulletPicture.Bounds.IntersectsWith(Zombie2.Bounds) Then
            BulletPicture.Location = gun
        End If
    End Sub
    Private Sub hit()
        health = 9999
        FLabel.Hide()
        Lostlable.Hide()
        FSLabel.Hide()
    End Sub

    Private Sub walk()
        path(1) = New Point(x:=293, y:=51)
        If playing = 0 Then Zombie1.Show()
        Zombie2.Show()
        Zombie1.Location = New Point(Zombie1.Location.X - 1, Zombie1.Location.Y - 1)
        Do While Zombie1.Location = New Point(x:=626, Zombie1.Location.Y)
            Zombie1.Location = New Point(Zombie1.Location.X - 1, Zombie1.Location.Y)
        Loop

        Do While Zombie1.Location = New Point(Zombie1.Location.X, Zombie1.Location.Y < 41)
            Zombie1.Location = New Point(Zombie1.Location.X, Zombie1.Location.Y - 1)
        Loop
        If zspeed = 1 Then
            Zombie1.Location = New Point(Zombie1.Location.X - 2, Zombie1.Location.Y - 2)
        End If
        Zombie2.Location = New Point(Zombie2.Location.X - 0, Zombie2.Location.Y - 0)
        Do While Zombie2.Location = New Point(x:=626, Zombie2.Location.Y)
            Zombie2.Location = New Point(Zombie2.Location.X - 2, Zombie2.Location.Y)
        Loop

        Do While Zombie2.Location = New Point(Zombie2.Location.X, Zombie2.Location.Y < 41)
            Zombie2.Location = New Point(Zombie2.Location.X, Zombie2.Location.Y - 2)
        Loop
        If zhide = 1 Then
            Zombie2.Location = New Point(Zombie2.Location.X - 3, Zombie2.Location.Y - 3)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        zombie()
        walk()
        healths()
        shot()

    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartButton.Hide()
        Ibutton.Hide()
        health = 2
        Heart3.Show()
        Zombie1.Location = zombiestart2
        Zombie2.Location = zombiestart
        Timer6.Enabled = False
        Heart2.Show()
        Timer1.Enabled = True
        Timer2.Enabled = True
        Me.Text = "Survive"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        shoot()

    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        BulletPicture.Location = gun
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UButton.Click
        If points = 1500 Or points > 1500 Then upgrade = upgrade + 1
        If upgrade = 1 Then points = points - 1500
        If upgrade = 2 Then points = points - 1500
        If upgrade = 1 Then Timer3.Interval = 1000
        If upgrade = 2 Then Timer3.Interval = 500
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        zspeed = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer9.Enabled = True
    End Sub
    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        hit()
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        death()
    End Sub
    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        zhide = 1

    End Sub

    Private Sub Ibutton_Click(sender As Object, e As EventArgs) Handles Ibutton.Click
        Form2.ShowDialog()
    End Sub
End Class

