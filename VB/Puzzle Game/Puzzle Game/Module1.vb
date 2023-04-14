Imports System.Configuration

Module Module1
    Sub emptyspotchecker(ByRef butt1 As Button, ByRef butt2 As Button)
        If butt2.Text = "" Then
            butt2.Text = butt1.Text
            butt1.Text = ""
        End If
    End Sub
    Sub solutionchecker()
        If Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And Form1.Button3.Text = "3" And Form1.Button4.Text = "4" And
            Form1.Button5.Text = "5" And Form1.Button6.Text = "6" And Form1.Button7.Text = "7" And Form1.Button8.Text = "8" And
            Form1.Button9.Text = "9" And Form1.Button10.Text = "10" And Form1.Button11.Text = "11" And Form1.Button12.Text = "12" And
            Form1.Button13.Text = "13" And Form1.Button14.Text = "14" And Form1.Button15.Text = "15" Then
            MessageBox.Show("Well done you are a winner", "Shuffle game", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Form1.counter = Form1.counter + 1
        Form1.TextBox1.Text = "Number of      clicks      " & Form1.counter
    End Sub
    Sub shuffle()
        Dim a(15), i, j, Rn As Integer
        Dim flag As Boolean
        flag = False

        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            Rn = CInt(Int((15 * Rnd()) + 1))
            For j = 1 To i
                If (a(j) = Rn) Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                flag = False
            Else
                a(i) = Rn
                i = i + 1
            End If
        Loop
        Form1.Button1.Text = a(1)
        Form1.Button2.Text = a(2)
        Form1.Button3.Text = a(3)
        Form1.Button4.Text = a(4)
        Form1.Button5.Text = a(5)
        Form1.Button6.Text = a(6)
        Form1.Button7.Text = a(7)
        Form1.Button8.Text = a(8)
        Form1.Button9.Text = a(9)
        Form1.Button10.Text = a(10)
        Form1.Button11.Text = a(11)
        Form1.Button12.Text = a(12)
        Form1.Button13.Text = a(13)
        Form1.Button14.Text = a(14)
        Form1.Button15.Text = a(15)
        Form1.Button16.Text = ""

    End Sub
End Module
