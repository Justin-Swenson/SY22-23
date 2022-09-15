Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim d As Decimal
        Dim s As Single
        Integer.TryParse(ATextBox.Text, n)
        Decimal.TryParse(BTextBox.Text, d)
        Single.TryParse(CTextBox.Text, s)
        Label1.Text = n
        Label2.Text = d
        Label3.Text = s
        If n < 0 Then Form4.ShowDialog()
        If d < 0 Then Form4.ShowDialog()
        If s < 0 Then Form4.ShowDialog()
        If n < 0 Then Label1.Text = 0
        If d < 0 Then Label2.Text = 0
        If s < 0 Then Label3.Text = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
        Label2.Text = pope
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.ShowDialog()
        Label3.Text = kingcharles
    End Sub
End Class
