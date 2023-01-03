Public Class Form1
    Dim length As Integer
    Dim width As Integer
    Dim area As Integer
    Private Sub CButton_Click(sender As Object, e As EventArgs) Handles CButton.Click
        rectanglearea()
    End Sub
    Function rectanglearea()
        Integer.TryParse(LTextBox.Text, length)
        Integer.TryParse(WTextBox.Text, width)
        ATextBox.Text = width * length
    End Function
End Class
