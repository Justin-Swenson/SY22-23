Public Class Form1
    Const speed As Integer = 10
    Dim health As Integer
    Dim player As New Point(293, 51)
    Dim zombiestart As New Point(359, 280)
    Dim zombiestart2 As New Point(63, 280)
    Dim zombiestart3 As New Point(626, 280)
    Dim zombienumber As Integer
    Dim wave As Integer
    Const a As Integer = 1



    Private Sub zombie()
        Timer2.Enabled = True
        Zombie1.Image.Clone()
        zombienumber = Int(Rnd(3))
        If Zombie1.Bounds.IntersectsWith(WallPicture.Bounds) And zombienumber = 1 Then
            Zombie1.Location = zombiestart
        End If
        If Zombie1.Bounds.IntersectsWith(WallPicture.Bounds) And zombienumber = 2 Then
            Zombie1.Location = zombiestart2
        End If
        If Zombie1.Bounds.IntersectsWith(WallPicture.Bounds) And zombienumber = 3 Then
            Zombie1.Location = zombiestart3
        End If
        If Zombie1.Location = zombiestart Then walk()
        If Zombie1.Location = zombiestart Then walk()
        If Zombie1.Location = zombiestart Then walk()


    End Sub
    Private Sub walk()
        Zombie1.Location = New Point(Zombie1.Location.X + 5, Zombie1.Location.Y + 5)
        If Zombie1.Location = New Point(Zombie1.Location.X = 293) Then
            Zombie1.Location = New Point(Zombie1.Location.X, Zombie1.Location.Y + 5)
        End If
        If Zombie1.Location = New Point(Zombie1.Location.Y = 51) Then
            Zombie1.Location = New Point(Zombie1.Location.X + 5, Zombie1.Location.Y)
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Zombie1.Image.Clone()
        zombie()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Update()
        wave = a + 1
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub


End Class

