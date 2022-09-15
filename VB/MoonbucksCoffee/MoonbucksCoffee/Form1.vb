Public Class Form1
    Dim rpounds As Decimal
    Dim dpounds As Decimal
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Decimal.TryParse(RegularTextBox.Text, rpounds)
        Decimal.TryParse(DecafTextBox.Text, dpounds)
        PoundsTextBox.Text = (rpounds + dpounds)
        TotalTextBox.Text = ((rpounds + dpounds) * 4.99).ToString("C2")

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TotalTextBox.Clear()
        PoundsTextBox.Clear()
        NameTextBox.Clear()
        addressTextBox.Clear()
        CityTextBox.Clear()
        StateTextBox.Clear()
        ZipTextBox.Clear()
        RegularTextBox.Clear()
        DecafTextBox.Clear()

    End Sub


End Class
