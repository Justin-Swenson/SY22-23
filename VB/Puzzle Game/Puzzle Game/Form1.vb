Public Class Form1
    Public counter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call shuffle()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call emptyspotchecker(Button1, Button2)
        Call emptyspotchecker(Button1, Button5)
        Call solutionchecker()
    End Sub

    Private Sub rbutton_Click(sender As Object, e As EventArgs) Handles rbutton.Click
        Call shuffle()
        counter = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call emptyspotchecker(Button2, Button1)
        Call emptyspotchecker(Button2, Button3)
        Call emptyspotchecker(Button2, Button6)
        Call solutionchecker()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call emptyspotchecker(Button3, Button2)
        Call emptyspotchecker(Button3, Button4)
        Call emptyspotchecker(Button3, Button7)
        Call solutionchecker()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call emptyspotchecker(Button4, Button3)
        Call emptyspotchecker(Button4, Button8)
        Call solutionchecker()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call emptyspotchecker(Button5, Button1)
        Call emptyspotchecker(Button5, Button6)
        Call emptyspotchecker(Button5, Button9)
        Call solutionchecker()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call emptyspotchecker(Button6, Button2)
        Call emptyspotchecker(Button6, Button5)
        Call emptyspotchecker(Button6, Button10)
        Call emptyspotchecker(Button6, Button7)
        Call solutionchecker()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call emptyspotchecker(Button7, Button6)
        Call emptyspotchecker(Button7, Button3)
        Call emptyspotchecker(Button7, Button8)
        Call emptyspotchecker(Button7, Button11)
        Call solutionchecker()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call emptyspotchecker(Button8, Button4)
        Call emptyspotchecker(Button8, Button7)
        Call emptyspotchecker(Button8, Button12)
        Call solutionchecker()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call emptyspotchecker(Button9, Button5)
        Call emptyspotchecker(Button9, Button10)
        Call emptyspotchecker(Button9, Button13)
        Call solutionchecker()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Call emptyspotchecker(Button10, Button9)
        Call emptyspotchecker(Button10, Button6)
        Call emptyspotchecker(Button10, Button14)
        Call emptyspotchecker(Button10, Button11)
        Call solutionchecker()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Call emptyspotchecker(Button11, Button10)
        Call emptyspotchecker(Button11, Button7)
        Call emptyspotchecker(Button11, Button12)
        Call emptyspotchecker(Button11, Button15)
        Call solutionchecker()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call emptyspotchecker(Button12, Button8)
        Call emptyspotchecker(Button12, Button11)
        Call emptyspotchecker(Button12, Button16)
        Call solutionchecker()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Call emptyspotchecker(Button13, Button9)
        Call emptyspotchecker(Button13, Button14)
        Call solutionchecker()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Call emptyspotchecker(Button14, Button13)
        Call emptyspotchecker(Button14, Button10)
        Call emptyspotchecker(Button14, Button15)
        Call solutionchecker()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Call emptyspotchecker(Button15, Button14)
        Call emptyspotchecker(Button15, Button11)
        Call emptyspotchecker(Button15, Button16)
        Call solutionchecker()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Call emptyspotchecker(Button16, Button12)
        Call emptyspotchecker(Button16, Button15)
        Call solutionchecker()
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Dim iexit = MessageBox.Show("Confirm if you want to exit", "Shuffle Games", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iexit = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim iexit = MessageBox.Show("Confirm if you want to exit", "Shuffle Games", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iexit = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Changecolour(sender As Object, e As EventArgs) Handles Button9.MouseEnter, Button8.MouseEnter, Button7.MouseEnter, Button6.MouseEnter, Button5.MouseEnter, Button4.MouseEnter, Button3.MouseEnter, Button2.MouseEnter, Button16.MouseEnter, Button15.MouseEnter, Button14.MouseEnter, Button13.MouseEnter, Button12.MouseEnter, Button11.MouseEnter, Button10.MouseEnter, Button1.MouseEnter
        Dim b As Button = sender
        b.BackColor = Color.Aqua
    End Sub

    Private Sub changecolourback(sender As Object, e As EventArgs) Handles Button9.MouseLeave, Button8.MouseLeave, Button7.MouseLeave, Button6.MouseLeave, Button5.MouseLeave, Button4.MouseLeave, Button3.MouseLeave, Button2.MouseLeave, Button16.MouseLeave, Button15.MouseLeave, Button14.MouseLeave, Button13.MouseLeave, Button12.MouseLeave, Button11.MouseLeave, Button10.MouseLeave, Button1.MouseLeave
        Dim b As Button = sender
        b.BackColor = Color.Teal
    End Sub
End Class
