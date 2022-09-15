Public Class Form6
    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        Dim B As Decimal
        Decimal.TryParse(bookTextBox.Text, b)
        Book = b * 1200
    End Sub

    Private Sub ChromeButton_Click(sender As Object, e As EventArgs) Handles ChromeButton.Click
        Dim C As Decimal
        Decimal.TryParse(ChromeTextBox.Text, C)
        Chrome = C * 481
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class