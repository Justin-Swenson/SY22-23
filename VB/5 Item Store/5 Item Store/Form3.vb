Public Class Form3
    Private Sub GDDButton_Click(sender As Object, e As EventArgs) Handles GDDButton.Click
        Dim G As Decimal
        Decimal.TryParse(GDDTextBox.Text, G)
        GDD = G * 239.99
    End Sub

    Private Sub GeforceButton_Click(sender As Object, e As EventArgs) Handles GeforceButton.Click
        Dim GT As Decimal
        Decimal.TryParse(GeforceTextBox.Text, GT)
        GTX = GT * 599.99
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class