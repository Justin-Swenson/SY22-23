Public Class Form1
    Dim length As Decimal
    Dim width As Decimal
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = sender.text
        If sender.text = "Wool" Then
            Displaypicturebox.Image = WoolPictureBox.Image
            Pricelabel.Text = 1.5
        End If
        If sender.text = "Berber" Then
            Displaypicturebox.Image = BerberPictureBox.Image
            Pricelabel.Text = 2.5
        End If
        If sender.text = "Nylon" Then
            Displaypicturebox.Image = NylonPictureBox.Image
            Pricelabel.Text = 2
        End If
        Decimal.TryParse(LengthTextBox.Text, length)
        Decimal.TryParse(WidthTextBox.Text, width)
        CostLabel.Text = "$" & (Pricelabel.Text * length * width)
    End Sub


End Class
