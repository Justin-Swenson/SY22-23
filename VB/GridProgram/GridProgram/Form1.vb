Public Class Form1
    Dim random As Integer
    Dim random2 As Integer
    Dim drawcolor As Color
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For row = 0 To 40
            For col = 0 To 40
                CreatePicture(PictureBox1, row, col)
            Next
        Next
    End Sub

    Private Sub AllButton_Click(sender As Object, e As EventArgs) Handles AllButton.Click
        For row = 0 To 40
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.DarkGreen
            Next
        Next
    End Sub

    Private Sub TopButton_Click(sender As Object, e As EventArgs) Handles TopButton.Click
        For Row = 0 To 20
            For col = 0 To 40
                GetPicture(Row, col).BackColor = Color.Yellow
            Next
        Next
    End Sub

    Private Sub LeftButton_Click(sender As Object, e As EventArgs) Handles LeftButton.Click
        For row = 0 To 40
            For col = 0 To 20
                GetPicture(row, col).BackColor = Color.Goldenrod
            Next
        Next
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        For row = 0 To 40
            For col = 21 To 40
                GetPicture(row, col).BackColor = Color.BlueViolet
            Next
        Next
    End Sub

    Private Sub StripesButton_Click(sender As Object, e As EventArgs) Handles StripesButton.Click
        For row = 0 To 40 Step 2
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Ivory
            Next
        Next
    End Sub

    Private Sub CBButton_Click(sender As Object, e As EventArgs) Handles CBButton.Click
        For row = 0 To 40
            For col = 0 To 40
                If row Mod 2 = 0 Then
                    If col Mod 2 = 0 Then GetPicture(row, col).BackColor = Color.White Else GetPicture(row, col).BackColor = Color.Black
                End If
                If row Mod 2 = 1 Then
                    If col Mod 2 = 0 Then GetPicture(row, col).BackColor = Color.Black Else GetPicture(row, col).BackColor = Color.White
                End If
            Next
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        For row = 0 To 40
            For col = 0 To 40
                If col Mod 4 = 0 Then
                    GetPicture(row, col).BackColor = Color.DarkRed
                End If
                If row Mod 4 = 0 Then
                    GetPicture(row, col).BackColor = Color.DarkMagenta
                End If
            Next
        Next
    End Sub

    Private Sub DiagonalButton_Click(sender As Object, e As EventArgs) Handles DiagonalButton.Click
        For row = 0 To 40
            For col = 0 To 40
                If col < row Then
                    GetPicture(row, col).BackColor = ColorButton.BackColor
                End If
            Next
        Next
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        ColorDialog1.ShowDialog()
        ColorButton.BackColor = ColorDialog1.Color
        drawcolor = ColorDialog1.Color
    End Sub

    Private Sub Bottombutton_Click(sender As Object, e As EventArgs) Handles Bottombutton.Click
        For row = 21 To 40
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Violet
            Next
        Next
    End Sub

    Private Sub VstripesButton_Click(sender As Object, e As EventArgs) Handles VstribesButton.Click
        For row = 0 To 40
            For col = 0 To 40 Step 2
                GetPicture(row, col).BackColor = Color.BlueViolet
            Next
        Next
    End Sub

    Private Sub SmileyButton_Click(sender As Object, e As EventArgs) Handles SmileyButton.Click
        For col = 9 To 13
            For row = 15 To 19
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
        For col = 16 To 20
            For row = 15 To 19
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
        For col = 12 To 17
            For row = 24 To 24
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
        For col = 11 To 11
            For row = 23 To 23
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
        For col = 18 To 18
            For row = 23 To 23
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
        For col = 10 To 10
            For row = 22 To 22
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
        For col = 19 To 19
            For row = 22 To 22
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For row = 0 To 40
            For col = 0 To 40
                If row > 40 - col Then
                    GetPicture(row, col).BackColor = ColorButton.BackColor
                End If
            Next
        Next
    End Sub

    Private Sub VmiddleButton_Click(sender As Object, e As EventArgs) Handles VmiddleButton.Click
        For row = 0 To 40
            For col = 11 To 30
                GetPicture(row, col).BackColor = Color.Cyan
            Next
        Next
    End Sub

    Private Sub HmiddleButton_Click(sender As Object, e As EventArgs) Handles HmiddleButton.Click
        For row = 11 To 30
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Red
            Next
        Next
    End Sub

    Private Sub RandomButton_Click(sender As Object, e As EventArgs) Handles RandomButton.Click
        random = Rnd()
        If random = 0 Then randomset1()
        If random = 1 Then randomset2()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        For row = 0 To 40
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.White
            Next
        Next
    End Sub
    Sub randomset1()
        For row = 0 To 2
            For col = 20 To 35
                GetPicture(row, col).BackColor = Color.Navy
            Next
        Next
        For row = 12 To 20
            For col = 3 To 5
                GetPicture(row, col).BackColor = Color.LightGoldenrodYellow
            Next
        Next
        For row = 33 To 40
            For col = 12 To 23
                GetPicture(row, col).BackColor = Color.Cornsilk
            Next
        Next
        For row = 23 To 40
            For col = 5 To 10
                GetPicture(row, col).BackColor = Color.Indigo
            Next
        Next
        For row = 10 To 20
            For col = 20 To 35
                GetPicture(row, col).BackColor = Color.Yellow
            Next
        Next
    End Sub
    Sub randomset2()
        For row = 17 To 27
            For col = 24 To 32
                GetPicture(row, col).BackColor = Color.Navy
            Next
        Next
        For row = 15 To 35
            For col = 2 To 13
                GetPicture(row, col).BackColor = Color.Chocolate
            Next
        Next
        For row = 27 To 40
            For col = 33 To 40
                GetPicture(row, col).BackColor = Color.ForestGreen
            Next
        Next
        For row = 2 To 15
            For col = 20 To 35
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        For row = 10 To 10
            For col = 10 To 13
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
        For row = 11 To 11
            For col = 14 To 14
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
        For row = 11 To 11
            For col = 9 To 9
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
        For row = 12 To 15
            For col = 8 To 8
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
        For row = 12 To 15
            For col = 15 To 15
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
        For row = 16 To 16
            For col = 14 To 14
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
        For row = 16 To 16
            For col = 9 To 9
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
        For row = 17 To 17
            For col = 10 To 13
                GetPicture(row, col).BackColor = Color.DimGray
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For row = 20 To 40
            For col = 0 To 40
                If col > 40 - row And col < row Then
                    GetPicture(row, col).BackColor = ColorButton.BackColor
                End If
            Next
        Next
        For row = 0 To 21
            For col = 0 To 40
                If col > row And col < 40 - row Then
                    GetPicture(row, col).BackColor = ColorButton.BackColor

                End If
            Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For row = 0 To 40
            For col = 0 To 40
                If row < 40 - col And row > col Then
                    GetPicture(row, col).BackColor = ColorButton.BackColor
                End If
                If row > 40 - col And row < col Then
                    GetPicture(row, col).BackColor = ColorButton.BackColor
                End If
            Next
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Drawbutton.Click
        For row = 5 To 5
            For col = 5 To 7
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 7 To 9
            For col = 3 To 3
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 7 To 9
            For col = 9 To 9
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 11 To 11
            For col = 5 To 7
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 12 To 18
            For col = 6 To 6
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 10 To 10
            For col = 5 To 7
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
        GetPicture(6, 4).BackColor = Color.PowderBlue
        GetPicture(6, 8).BackColor = Color.PowderBlue
        GetPicture(10, 8).BackColor = Color.PowderBlue
        GetPicture(10, 4).BackColor = Color.PowderBlue
        GetPicture(9, 4).BackColor = Color.Blue
        GetPicture(9, 8).BackColor = Color.Blue
        GetPicture(7, 7).BackColor = Color.Blue
        GetPicture(7, 5).BackColor = Color.Blue
        GetPicture(13, 5).BackColor = Color.PowderBlue
        GetPicture(13, 7).BackColor = Color.PowderBlue
        GetPicture(14, 8).BackColor = Color.PowderBlue
        GetPicture(15, 9).BackColor = Color.PowderBlue
        GetPicture(16, 10).BackColor = Color.PowderBlue
        GetPicture(12, 4).BackColor = Color.PowderBlue
        GetPicture(11, 3).BackColor = Color.PowderBlue
        GetPicture(10, 2).BackColor = Color.PowderBlue
        GetPicture(9, 1).BackColor = Color.PowderBlue
        GetPicture(19, 5).BackColor = Color.PowderBlue
        GetPicture(20, 4).BackColor = Color.PowderBlue
        GetPicture(21, 3).BackColor = Color.PowderBlue
        GetPicture(22, 2).BackColor = Color.PowderBlue
        GetPicture(19, 7).BackColor = Color.PowderBlue
        GetPicture(20, 8).BackColor = Color.PowderBlue
        GetPicture(21, 9).BackColor = Color.PowderBlue
        GetPicture(22, 10).BackColor = Color.PowderBlue

        For row = 5 To 5
            For col = 25 To 27
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 7 To 9
            For col = 23 To 23
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 7 To 9
            For col = 29 To 29
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 11 To 11
            For col = 25 To 27
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 12 To 18
            For col = 26 To 26
                GetPicture(row, col).BackColor = Color.PowderBlue
            Next
        Next
        For row = 10 To 10
            For col = 25 To 27
                GetPicture(row, col).BackColor = Color.Blue
            Next
        Next
        GetPicture(6, 24).BackColor = Color.PowderBlue
        GetPicture(6, 28).BackColor = Color.PowderBlue
        GetPicture(10, 28).BackColor = Color.PowderBlue
        GetPicture(10, 24).BackColor = Color.PowderBlue
        GetPicture(9, 24).BackColor = Color.Blue
        GetPicture(9, 28).BackColor = Color.Blue
        GetPicture(7, 27).BackColor = Color.Blue
        GetPicture(7, 25).BackColor = Color.Blue
        GetPicture(13, 25).BackColor = Color.PowderBlue
        GetPicture(13, 27).BackColor = Color.PowderBlue
        GetPicture(12, 28).BackColor = Color.PowderBlue
        GetPicture(11, 29).BackColor = Color.PowderBlue
        GetPicture(10, 30).BackColor = Color.PowderBlue
        GetPicture(14, 24).BackColor = Color.PowderBlue
        GetPicture(15, 23).BackColor = Color.PowderBlue
        GetPicture(16, 22).BackColor = Color.PowderBlue
        GetPicture(19, 25).BackColor = Color.PowderBlue
        GetPicture(20, 24).BackColor = Color.PowderBlue
        GetPicture(21, 23).BackColor = Color.PowderBlue
        GetPicture(22, 22).BackColor = Color.PowderBlue
        GetPicture(19, 27).BackColor = Color.PowderBlue
        GetPicture(20, 28).BackColor = Color.PowderBlue
        GetPicture(21, 29).BackColor = Color.PowderBlue
        GetPicture(22, 30).BackColor = Color.PowderBlue
        For row = 30 To 34
            For col = 10 To 10
                GetPicture(row, col).BackColor = Color.Black
            Next
        Next
        For row = 30 To 34
            For col = 12 To 12
                GetPicture(row, col).BackColor = Color.Black
            Next
        Next
        GetPicture(30, 11).BackColor = Color.Black
        GetPicture(34, 11).BackColor = Color.Black
        For row = 30 To 33
            For col = 14 To 14
                GetPicture(row, col).BackColor = Color.Black
            Next
        Next
        For row = 29 To 29
            For col = 18 To 21
                GetPicture(row, col).BackColor = Color.Black
            Next
        Next
        For row = 30 To 32
            For col = 22 To 22
                GetPicture(row, col).BackColor = Color.Black
            Next
        Next
        For row = 34 To 34
            For col = 15 To 20
                GetPicture(row, col).BackColor = Color.Black
            Next
        Next
        GetPicture(29, 15).BackColor = Color.Black
        GetPicture(28, 16).BackColor = Color.Black
        GetPicture(27, 17).BackColor = Color.Black
        GetPicture(26, 17).BackColor = Color.Black
        GetPicture(26, 18).BackColor = Color.Black
        GetPicture(26, 19).BackColor = Color.Black
        GetPicture(27, 19).BackColor = Color.Black
        GetPicture(28, 19).BackColor = Color.Black
        GetPicture(33, 21).BackColor = Color.Black
        For row = 30 To 33
            For col = 15 To 20
                GetPicture(row, col).BackColor = Color.Yellow
            Next
        Next
        GetPicture(30, 21).BackColor = Color.Yellow
        GetPicture(31, 21).BackColor = Color.Yellow
        GetPicture(32, 21).BackColor = Color.Yellow
        GetPicture(29, 18).BackColor = Color.Yellow
        GetPicture(29, 17).BackColor = Color.Yellow
        GetPicture(29, 16).BackColor = Color.Yellow
        GetPicture(28, 17).BackColor = Color.Yellow
        GetPicture(28, 18).BackColor = Color.Yellow
        GetPicture(27, 18).BackColor = Color.Yellow
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.BackColor = drawcolor
    End Sub
End Class
