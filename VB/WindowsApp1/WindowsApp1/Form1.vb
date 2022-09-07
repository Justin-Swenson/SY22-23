Public Class Form1
    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Dim Amount As Decimal
        Decimal.TryParse(amtextBox.Text, Amount)
        nameTextBox.Clear()
        CCtextbox.Clear()
        ExpTextBox.Clear()
        ZipTextBox.Clear()
        amtextBox.Clear()
        Label10.Text = "Download Malware Complete"
        Label12.Text = "reported your IP address to the FBI for terrorism"
        Dim fee As Decimal
        Dim v As Double = Amount * 0.03
        fee = v
        FeeTextBox.Text = fee
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

End Class
