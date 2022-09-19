Public Class Form1
    Dim numvalue As Decimal
    Dim oper As String
    Private Sub leftbutton_Click(sender As Object, e As EventArgs) Handles leftbutton.Click
        Decimal.TryParse(Label.Text, numvalue)
        oper = "-"
        If oper = "-" Then Label.Text = numvalue - 1
        If Label.Text < 1 Then Label.Text = 3
        If numvalue = 1 Then PictureBox1.Image = Image.FromFile("C:\2.jpg")
        If numvalue = 2 Then PictureBox1.Image = Image.FromFile("C:\2.jpg")
        If numvalue = 3 Then PictureBox1.Image = Image.FromFile("C:\2.jpg")
    End Sub

    Private Sub rightButton_Click(sender As Object, e As EventArgs) Handles rightButton.Click
        Decimal.TryParse(Label.Text, numvalue)
        oper = "+"
        If oper = "+" Then Label.Text = numvalue + 1
        If Label.Text > 3 Then Label.Text = 1
        If numvalue = 1 Then PictureBox1.Image = Image.FromFile("C:\2.jpg")
        If numvalue = 2 Then PictureBox1.Image = Image.FromFile("C:\2.jpg")
        If numvalue = 3 Then PictureBox1.Image = Image.FromFile("C:\2.jpg")
    End Sub
End Class
