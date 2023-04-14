Public Class Enemy
    Public Property picture As PictureBox
    Public Property speed As Integer
    Public Property moveright As Boolean
    Public Property boundaryplatfrom As PictureBox

    Public Sub move()
        If picture.Left > boundaryplatfrom.Left + boundaryplatfrom.Width Then
            moveright = False
        End If
        If picture.Left < boundaryplatfrom.Left - 54 Then
            moveright = True
        End If
        If moveright = True Then
            picture.Left += speed
        Else
            picture.Left -= speed
        End If
    End Sub
End Class
