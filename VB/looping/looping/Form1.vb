Imports System.Runtime.CompilerServices

Public Class Form1
    Const Speed As Integer = 10
    Dim direction As Point

    'This is where you can handle any collisions in the game
    '
    '  p1 has collided with p2
    '  you can return true to let it go through it
    '  or 
    '  you can return false to not let it go through
    '
    '  you could also do other actions like change directions or add points etc.
    Public Function Collision(p1 As PictureBox, p2 As PictureBox) As Boolean
        Debug.Print(p1.Name + " ran into " + p2.Name)

        'Any pictureboxes whose name start with TARGET that get run into will be removed
        If p2.Name.ToUpper.StartsWith("TARGET") Then 'remove targets when they are hit
            Remove(p2)
        End If

        'Any BULLET pictures will be removed when they collide
        If p1.Name.ToUpper.StartsWith("BULLET") Then
            '(don't remove them if they collide with the player - like when they start out
            If Not p2.Name.ToUpper.StartsWith("PLAYER") Then 'remove bullets when they collide with others
                Remove(p1)
            End If
        End If

        'Anything that runs into a wall will stop
        If p2.Name.ToUpper.StartsWith("WALL") Then
            Return False 'don't let anything through walls
        End If

        'if none of the above happened, let the object move
        Return True ' let it move
    End Function

    'Handle the keyboard - you could add your own keys if you wanted
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Up
                direction = New Point(0, -Speed)
                moveto(player, 0, -Speed)
            Case Keys.Down
                direction = New Point(0, Speed)
                moveto(player, 0, Speed)
            Case Keys.Left
                direction = New Point(-Speed, 0)
                moveto(player, -Speed, 0)
            Case Keys.Right
                direction = New Point(Speed, 0)
                moveto(player, Speed, 0)
            Case Keys.Space
                'Add a ball in the direction the player is facing
                'AddAt(BulletPictureBox2, New Point(60, 60), New Point(5, 5), "BALL")
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        For index = 1 To 100 Step 10
            For index2 = 1 To 100 Step 10
                AddAt(Badguy1, New Point(index2 * 10, index * 10), New Point(0, 10))
            Next

            AddAt(Badguy1, New Point(index * 10, 0), "CHASE")
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateGame()
    End Sub
End Class