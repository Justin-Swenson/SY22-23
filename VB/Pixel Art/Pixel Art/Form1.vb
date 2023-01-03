Public Class Form1
    Dim drawcolor As Color
    Sub clear()
        For index = 1 To 100
            Controls("button" & index).BackColor = Color.White
        Next
    End Sub
    Sub fill(c As Color)
        For index = 1 To 100
            Controls("button" & index).BackColor = c
        Next
    End Sub

    Private Sub Clearbutton_Click(sender As Object, e As EventArgs) Handles Clearbutton.Click
        clear()
    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs)
        fill(sender.backcolor)
    End Sub

    Private Sub Button51_MouseMove(sender As Object, e As MouseEventArgs) Handles Button99.MouseMove, Button98.MouseMove, Button97.MouseMove, Button96.MouseMove, Button95.MouseMove, Button94.MouseMove, Button93.MouseMove, Button92.MouseMove, Button91.MouseMove, Button90.MouseMove, Button9.MouseMove, Button89.MouseMove, Button88.MouseMove, Button87.MouseMove, Button86.MouseMove, Button85.MouseMove, Button84.MouseMove, Button83.MouseMove, Button82.MouseMove, Button81.MouseMove, Button80.MouseMove, Button8.MouseMove, Button79.MouseMove, Button78.MouseMove, Button77.MouseMove, Button76.MouseMove, Button75.MouseMove, Button74.MouseMove, Button73.MouseMove, Button72.MouseMove, Button71.MouseMove, Button70.MouseMove, Button7.MouseMove, Button69.MouseMove, Button68.MouseMove, Button67.MouseMove, Button66.MouseMove, Button65.MouseMove, Button64.MouseMove, Button63.MouseMove, Button62.MouseMove, Button61.MouseMove, Button60.MouseMove, Button6.MouseMove, Button59.MouseMove, Button58.MouseMove, Button57.MouseMove, Button56.MouseMove, Button55.MouseMove, Button54.MouseMove, Button53.MouseMove, Button52.MouseMove, Button51.MouseMove, Button50.MouseMove, Button5.MouseMove, Button49.MouseMove, Button48.MouseMove, Button47.MouseMove, Button46.MouseMove, Button45.MouseMove, Button44.MouseMove, Button43.MouseMove, Button42.MouseMove, Button41.MouseMove, Button40.MouseMove, Button4.MouseMove, Button39.MouseMove, Button38.MouseMove, Button37.MouseMove, Button36.MouseMove, Button35.MouseMove, Button34.MouseMove, Button33.MouseMove, Button32.MouseMove, Button31.MouseMove, Button30.MouseMove, Button3.MouseMove, Button29.MouseMove, Button28.MouseMove, Button27.MouseMove, Button26.MouseMove, Button25.MouseMove, Button24.MouseMove, Button23.MouseMove, Button22.MouseMove, Button21.MouseMove, Button20.MouseMove, Button2.MouseMove, Button19.MouseMove, Button18.MouseMove, Button17.MouseMove, Button16.MouseMove, Button15.MouseMove, Button14.MouseMove, Button13.MouseMove, Button12.MouseMove, Button11.MouseMove, Button100.MouseMove, Button10.MouseMove, Button1.MouseMove
        sender.backcolor = drawcolor
    End Sub
    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Button105.Click, Button104.Click, Button103.Click, Button102.Click, Button101.Click
        drawcolor = sender.backcolor

    End Sub

    Private Sub Button105_MouseDown(sender As Object, e As MouseEventArgs) Handles Button105.MouseDown, Button104.MouseDown, Button103.MouseDown, Button102.MouseDown, Button101.MouseDown
        If e.Button = MouseButtons.Right Then
            ColorDialog1.ShowDialog()
            sender.backcolor = ColorDialog1.Color
            drawcolor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button99.Click, Button98.Click, Button97.Click, Button96.Click, Button95.Click, Button94.Click, Button93.Click, Button92.Click, Button91.Click, Button90.Click, Button9.Click, Button89.Click, Button88.Click, Button87.Click, Button86.Click, Button85.Click, Button84.Click, Button83.Click, Button82.Click, Button81.Click, Button80.Click, Button8.Click, Button79.Click, Button78.Click, Button77.Click, Button76.Click, Button75.Click, Button74.Click, Button73.Click, Button72.Click, Button71.Click, Button70.Click, Button7.Click, Button69.Click, Button68.Click, Button67.Click, Button66.Click, Button65.Click, Button64.Click, Button63.Click, Button62.Click, Button61.Click, Button60.Click, Button6.Click, Button59.Click, Button58.Click, Button57.Click, Button56.Click, Button55.Click, Button54.Click, Button53.Click, Button52.Click, Button51.Click, Button50.Click, Button5.Click, Button49.Click, Button48.Click, Button47.Click, Button46.Click, Button45.Click, Button44.Click, Button43.Click, Button42.Click, Button41.Click, Button40.Click, Button4.Click, Button39.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button30.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button100.Click, Button10.Click, Button1.Click
        sender.backcolor = drawcolor
    End Sub

    Private Sub Button106_Click(sender As Object, e As EventArgs) Handles Button106.Click
        PictureBox1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Button107_Click(sender As Object, e As EventArgs) Handles Button107.Click
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub GridButton_Click(sender As Object, e As EventArgs) Handles GridButton.Click

        For index = 1 To 2
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BorderStyle = BorderStyle.None
        Next

    End Sub
End Class
