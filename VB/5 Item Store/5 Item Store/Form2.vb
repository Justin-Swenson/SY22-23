Public Class Form2
    Private Sub SSDButton_Click(sender As Object, e As EventArgs) Handles SSDButton.Click
        Dim S As Decimal
        Decimal.TryParse(SSDTextBox.Text, S)
        SSD = S * 109.99
    End Sub

    Private Sub HDDButton_Click(sender As Object, e As EventArgs) Handles HDDButton.Click
        Dim H As Decimal
        Decimal.TryParse(HDDTextBox.Text, H)
        HDD = H * 120
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class