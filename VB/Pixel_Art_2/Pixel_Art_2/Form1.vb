
Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim drawcolor As Color
    Dim draw As Integer
    Dim p As PictureBox
    Private Sub PictureBox321_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox2.Click, PictureBox10.Click, PictureBox1.Click
        sender.backcolor = drawcolor
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        drawcolor = sender.backcolor
    End Sub

    Private Sub drawing(sender As Object, e As MouseEventArgs) Handles PictureBox99.MouseMove, PictureBox98.MouseMove, PictureBox97.MouseMove, PictureBox96.MouseMove, PictureBox95.MouseMove, PictureBox94.MouseMove, PictureBox93.MouseMove, PictureBox92.MouseMove, PictureBox91.MouseMove, PictureBox90.MouseMove, PictureBox9.MouseMove, PictureBox89.MouseMove, PictureBox88.MouseMove, PictureBox87.MouseMove, PictureBox86.MouseMove, PictureBox85.MouseMove, PictureBox84.MouseMove, PictureBox83.MouseMove, PictureBox82.MouseMove, PictureBox81.MouseMove, PictureBox80.MouseMove, PictureBox8.MouseMove, PictureBox79.MouseMove, PictureBox78.MouseMove, PictureBox77.MouseMove, PictureBox76.MouseMove, PictureBox75.MouseMove, PictureBox74.MouseMove, PictureBox73.MouseMove, PictureBox72.MouseMove, PictureBox71.MouseMove, PictureBox70.MouseMove, PictureBox7.MouseMove, PictureBox69.MouseMove, PictureBox68.MouseMove, PictureBox67.MouseMove, PictureBox66.MouseMove, PictureBox65.MouseMove, PictureBox64.MouseMove, PictureBox63.MouseMove, PictureBox62.MouseMove, PictureBox61.MouseMove, PictureBox60.MouseMove, PictureBox6.MouseMove, PictureBox59.MouseMove, PictureBox58.MouseMove, PictureBox57.MouseMove, PictureBox56.MouseMove, PictureBox55.MouseMove, PictureBox54.MouseMove, PictureBox53.MouseMove, PictureBox52.MouseMove, PictureBox51.MouseMove, PictureBox50.MouseMove, PictureBox5.MouseMove, PictureBox49.MouseMove, PictureBox48.MouseMove, PictureBox47.MouseMove, PictureBox46.MouseMove, PictureBox45.MouseMove, PictureBox44.MouseMove, PictureBox43.MouseMove, PictureBox42.MouseMove, PictureBox41.MouseMove, PictureBox400.MouseMove, PictureBox40.MouseMove, PictureBox4.MouseMove, PictureBox399.MouseMove, PictureBox398.MouseMove, PictureBox397.MouseMove, PictureBox396.MouseMove, PictureBox395.MouseMove, PictureBox394.MouseMove, PictureBox393.MouseMove, PictureBox392.MouseMove, PictureBox391.MouseMove, PictureBox390.MouseMove, PictureBox39.MouseMove, PictureBox389.MouseMove, PictureBox388.MouseMove, PictureBox387.MouseMove, PictureBox386.MouseMove, PictureBox385.MouseMove, PictureBox384.MouseMove, PictureBox383.MouseMove, PictureBox382.MouseMove, PictureBox381.MouseMove, PictureBox380.MouseMove, PictureBox38.MouseMove, PictureBox379.MouseMove, PictureBox378.MouseMove, PictureBox377.MouseMove, PictureBox376.MouseMove, PictureBox375.MouseMove, PictureBox374.MouseMove, PictureBox373.MouseMove, PictureBox372.MouseMove, PictureBox371.MouseMove, PictureBox370.MouseMove, PictureBox37.MouseMove, PictureBox369.MouseMove, PictureBox368.MouseMove, PictureBox367.MouseMove, PictureBox366.MouseMove, PictureBox365.MouseMove, PictureBox364.MouseMove, PictureBox363.MouseMove, PictureBox362.MouseMove, PictureBox361.MouseMove, PictureBox360.MouseMove, PictureBox36.MouseMove, PictureBox359.MouseMove, PictureBox358.MouseMove, PictureBox357.MouseMove, PictureBox356.MouseMove, PictureBox355.MouseMove, PictureBox354.MouseMove, PictureBox353.MouseMove, PictureBox352.MouseMove, PictureBox351.MouseMove, PictureBox350.MouseMove, PictureBox35.MouseMove, PictureBox349.MouseMove, PictureBox348.MouseMove, PictureBox347.MouseMove, PictureBox346.MouseMove, PictureBox345.MouseMove, PictureBox344.MouseMove, PictureBox343.MouseMove, PictureBox342.MouseMove, PictureBox341.MouseMove, PictureBox340.MouseMove, PictureBox34.MouseMove, PictureBox339.MouseMove, PictureBox338.MouseMove, PictureBox337.MouseMove, PictureBox336.MouseMove, PictureBox335.MouseMove, PictureBox334.MouseMove, PictureBox333.MouseMove, PictureBox332.MouseMove, PictureBox331.MouseMove, PictureBox330.MouseMove, PictureBox33.MouseMove, PictureBox329.MouseMove, PictureBox328.MouseMove, PictureBox327.MouseMove, PictureBox326.MouseMove, PictureBox325.MouseMove, PictureBox324.MouseMove, PictureBox323.MouseMove, PictureBox322.MouseMove, PictureBox321.MouseMove, PictureBox320.MouseMove, PictureBox32.MouseMove, PictureBox319.MouseMove, PictureBox318.MouseMove, PictureBox317.MouseMove, PictureBox316.MouseMove, PictureBox315.MouseMove, PictureBox314.MouseMove, PictureBox313.MouseMove, PictureBox312.MouseMove, PictureBox311.MouseMove, PictureBox310.MouseMove, PictureBox31.MouseMove, PictureBox309.MouseMove, PictureBox308.MouseMove, PictureBox307.MouseMove, PictureBox306.MouseMove, PictureBox305.MouseMove, PictureBox304.MouseMove, PictureBox303.MouseMove, PictureBox302.MouseMove, PictureBox301.MouseMove, PictureBox300.MouseMove, PictureBox30.MouseMove, PictureBox3.MouseMove, PictureBox299.MouseMove, PictureBox298.MouseMove, PictureBox297.MouseMove, PictureBox296.MouseMove, PictureBox295.MouseMove, PictureBox294.MouseMove, PictureBox293.MouseMove, PictureBox292.MouseMove, PictureBox291.MouseMove, PictureBox290.MouseMove, PictureBox29.MouseMove, PictureBox289.MouseMove, PictureBox288.MouseMove, PictureBox287.MouseMove, PictureBox286.MouseMove, PictureBox285.MouseMove, PictureBox284.MouseMove, PictureBox283.MouseMove, PictureBox282.MouseMove, PictureBox281.MouseMove, PictureBox280.MouseMove, PictureBox28.MouseMove, PictureBox279.MouseMove, PictureBox278.MouseMove, PictureBox277.MouseMove, PictureBox276.MouseMove, PictureBox275.MouseMove, PictureBox274.MouseMove, PictureBox273.MouseMove, PictureBox272.MouseMove, PictureBox271.MouseMove, PictureBox270.MouseMove, PictureBox27.MouseMove, PictureBox269.MouseMove, PictureBox268.MouseMove, PictureBox267.MouseMove, PictureBox266.MouseMove, PictureBox265.MouseMove, PictureBox264.MouseMove, PictureBox263.MouseMove, PictureBox262.MouseMove, PictureBox261.MouseMove, PictureBox260.MouseMove, PictureBox26.MouseMove, PictureBox259.MouseMove, PictureBox258.MouseMove, PictureBox257.MouseMove, PictureBox256.MouseMove, PictureBox255.MouseMove, PictureBox254.MouseMove, PictureBox253.MouseMove, PictureBox252.MouseMove, PictureBox251.MouseMove, PictureBox250.MouseMove, PictureBox25.MouseMove, PictureBox249.MouseMove, PictureBox248.MouseMove, PictureBox247.MouseMove, PictureBox246.MouseMove, PictureBox245.MouseMove, PictureBox244.MouseMove, PictureBox243.MouseMove, PictureBox242.MouseMove, PictureBox241.MouseMove, PictureBox240.MouseMove, PictureBox24.MouseMove, PictureBox239.MouseMove, PictureBox238.MouseMove, PictureBox237.MouseMove, PictureBox236.MouseMove, PictureBox235.MouseMove, PictureBox234.MouseMove, PictureBox233.MouseMove, PictureBox232.MouseMove, PictureBox231.MouseMove, PictureBox230.MouseMove, PictureBox23.MouseMove, PictureBox229.MouseMove, PictureBox228.MouseMove, PictureBox227.MouseMove, PictureBox226.MouseMove, PictureBox225.MouseMove, PictureBox224.MouseMove, PictureBox223.MouseMove, PictureBox222.MouseMove, PictureBox221.MouseMove, PictureBox220.MouseMove, PictureBox22.MouseMove, PictureBox219.MouseMove, PictureBox218.MouseMove, PictureBox217.MouseMove, PictureBox216.MouseMove, PictureBox215.MouseMove, PictureBox214.MouseMove, PictureBox213.MouseMove, PictureBox212.MouseMove, PictureBox211.MouseMove, PictureBox210.MouseMove, PictureBox21.MouseMove, PictureBox209.MouseMove, PictureBox208.MouseMove, PictureBox207.MouseMove, PictureBox206.MouseMove, PictureBox205.MouseMove, PictureBox204.MouseMove, PictureBox203.MouseMove, PictureBox202.MouseMove, PictureBox201.MouseMove, PictureBox200.MouseMove, PictureBox20.MouseMove, PictureBox2.MouseMove, PictureBox199.MouseMove, PictureBox198.MouseMove, PictureBox197.MouseMove, PictureBox196.MouseMove, PictureBox195.MouseMove, PictureBox194.MouseMove, PictureBox193.MouseMove, PictureBox192.MouseMove, PictureBox191.MouseMove, PictureBox190.MouseMove, PictureBox19.MouseMove, PictureBox189.MouseMove, PictureBox188.MouseMove, PictureBox187.MouseMove, PictureBox186.MouseMove, PictureBox185.MouseMove, PictureBox184.MouseMove, PictureBox183.MouseMove, PictureBox182.MouseMove, PictureBox181.MouseMove, PictureBox180.MouseMove, PictureBox18.MouseMove, PictureBox179.MouseMove, PictureBox178.MouseMove, PictureBox177.MouseMove, PictureBox176.MouseMove, PictureBox175.MouseMove, PictureBox174.MouseMove, PictureBox173.MouseMove, PictureBox172.MouseMove, PictureBox171.MouseMove, PictureBox170.MouseMove, PictureBox17.MouseMove, PictureBox169.MouseMove, PictureBox168.MouseMove, PictureBox167.MouseMove, PictureBox166.MouseMove, PictureBox165.MouseMove, PictureBox164.MouseMove, PictureBox163.MouseMove, PictureBox162.MouseMove, PictureBox161.MouseMove, PictureBox160.MouseMove, PictureBox16.MouseMove, PictureBox159.MouseMove, PictureBox158.MouseMove, PictureBox157.MouseMove, PictureBox156.MouseMove, PictureBox155.MouseMove, PictureBox154.MouseMove, PictureBox153.MouseMove, PictureBox152.MouseMove, PictureBox151.MouseMove, PictureBox150.MouseMove, PictureBox15.MouseMove, PictureBox149.MouseMove, PictureBox148.MouseMove, PictureBox147.MouseMove, PictureBox146.MouseMove, PictureBox145.MouseMove, PictureBox144.MouseMove, PictureBox143.MouseMove, PictureBox142.MouseMove, PictureBox141.MouseMove, PictureBox140.MouseMove, PictureBox14.MouseMove, PictureBox139.MouseMove, PictureBox138.MouseMove, PictureBox137.MouseMove, PictureBox136.MouseMove, PictureBox135.MouseMove, PictureBox134.MouseMove, PictureBox133.MouseMove, PictureBox132.MouseMove, PictureBox131.MouseMove, PictureBox130.MouseMove, PictureBox13.MouseMove, PictureBox129.MouseMove, PictureBox128.MouseMove, PictureBox127.MouseMove, PictureBox126.MouseMove, PictureBox125.MouseMove, PictureBox124.MouseMove, PictureBox123.MouseMove, PictureBox122.MouseMove, PictureBox121.MouseMove, PictureBox120.MouseMove, PictureBox12.MouseMove, PictureBox119.MouseMove, PictureBox118.MouseMove, PictureBox117.MouseMove, PictureBox116.MouseMove, PictureBox115.MouseMove, PictureBox114.MouseMove, PictureBox113.MouseMove, PictureBox112.MouseMove, PictureBox111.MouseMove, PictureBox110.MouseMove, PictureBox11.MouseMove, PictureBox109.MouseMove, PictureBox108.MouseMove, PictureBox107.MouseMove, PictureBox106.MouseMove, PictureBox105.MouseMove, PictureBox104.MouseMove, PictureBox103.MouseMove, PictureBox102.MouseMove, PictureBox101.MouseMove, PictureBox100.MouseMove, PictureBox10.MouseMove, PictureBox1.MouseMove
        If draw = 1 Then
            sender.BackColor = drawcolor
            For index = 1 To 400
                Dim p As PictureBox
                p = Controls("picturebox" & index)
                p.BorderStyle = BorderStyle.Fixed3D
            Next
        End If
        If draw = 0 Then
            For index = 1 To 400
                Dim p As PictureBox
                p = Controls("picturebox" & index)
                p.BorderStyle = BorderStyle.None
            Next
        End If
    End Sub

    Private Sub DrawRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DrawRadioButton.CheckedChanged
        If DrawRadioButton.Checked Then
            draw = 1
        End If

    End Sub

    Private Sub StopRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles StopRadioButton.CheckedChanged
        If StopRadioButton.Checked Then
            draw = 0
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ColorDialog1.ShowDialog()
        Button13.BackColor = ColorDialog1.Color
        drawcolor = ColorDialog1.Color
    End Sub
    Private Sub Resetbutton_Click(sender As Object, e As EventArgs) Handles Resetbutton.Click
        For index = 1 To 400
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BackColor = Color.Gray
        Next
    End Sub
    Private Sub designs()
        For index = 1 To 400
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BackColor = Color.Black
        Next
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles VmiddleButton.Click
        For col = 1 To 400
            If col Mod 2 = 1 Then
                Dim p As PictureBox
                p = Controls("picturebox" & col)
                p.BackColor = Color.Black
            End If
        Next
        For col = 1 To 400
            If col Mod 2 = 0 Then
                Dim p As PictureBox
                p = Controls("picturebox" & col)
                p.BackColor = Color.Red
            End If
        Next




    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles halfButton.Click
        For row = 1 To 200
            p = Controls("picturebox" & row)
            p.BackColor = Color.DarkBlue
        Next
        For row = 201 To 400
            p = Controls("picturebox" & row)
            p.BackColor = Color.Violet
        Next
    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles RandomButton.Click
        For index = 1 To 400
            Dim random = Int((2 * Rnd()) + 1)
            If random = 1 Then
                Controls("picturebox" & index).BackColor = Color.FromArgb(0, 0, 255)

            Else
                Controls("picturebox" & index).BackColor = Color.FromArgb(0, 255, 255)
            End If
        Next
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        For col = 1 To 400
            If col Mod 3 = 1 Then
                Dim p As PictureBox
                p = Controls("picturebox" & col)
                p.BackColor = drawcolor
            End If
        Next
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        For col = 1 To 400
            Dim p As PictureBox
            p = Controls("picturebox" & col)
            p.BackColor = drawcolor
        Next
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        For col = 68 To 73
            Dim p As PictureBox
            p = Controls("picturebox" & col)
            p.BackColor = drawcolor
        Next
        For col = 228 To 233
            Dim p As PictureBox
            p = Controls("picturebox" & col)
            p.BackColor = drawcolor
        Next
        PictureBox87.BackColor = drawcolor
        PictureBox94.BackColor = drawcolor
        PictureBox115.BackColor = drawcolor
        PictureBox135.BackColor = drawcolor
        PictureBox155.BackColor = drawcolor
        PictureBox175.BackColor = drawcolor
        PictureBox195.BackColor = drawcolor
        PictureBox214.BackColor = drawcolor
        PictureBox106.BackColor = drawcolor
        PictureBox126.BackColor = drawcolor
        PictureBox146.BackColor = drawcolor
        PictureBox166.BackColor = drawcolor
        PictureBox186.BackColor = drawcolor
        PictureBox207.BackColor = drawcolor


    End Sub
End Class
