Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box1 As New box
        Integer.TryParse(LengthTextBox.Text, box1.Length)
        Integer.TryParse(WidthTextBox.Text, box1.Width)
        Integer.TryParse(HeightTextBox.Text, box1.Height)
        volumelabel.Text = box1.volume
    End Sub


End Class
