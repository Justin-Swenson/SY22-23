Public Class Form1
    Dim redint As Decimal
    Dim greenint As Decimal
    Dim blueint As Decimal

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs)

        Dim redint As Decimal
        Dim greenint As Decimal
        Dim blueint As Decimal

        ColorButton.BackColor = Color.FromArgb(redint, greenint, blueint)
    End Sub



    Private Sub GreenTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BlueTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RedScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles RedScrollBar.Scroll
        Decimal.TryParse(RedScrollBar.Value, redint)
        ColorButton.BackColor = Color.FromArgb(redint, greenint, blueint)
    End Sub

    Private Sub GreenScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles GreenScrollBar.Scroll
        Decimal.TryParse(GreenScrollBar.Value, greenint)
        ColorButton.BackColor = Color.FromArgb(redint, greenint, blueint)
    End Sub

    Private Sub BlueScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles BlueScrollBar.Scroll
        Decimal.TryParse(BlueScrollBar.Value, blueint)
        ColorButton.BackColor = Color.FromArgb(redint, greenint, blueint)
    End Sub
End Class
