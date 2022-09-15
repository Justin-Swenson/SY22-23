Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        itemsTextBox.Hide()
        subTextBox.Hide()
        GrandTextBox.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles itemsTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Decimal.TryParse(s + h + G + GT + B + c, items)
        itemsTextBox.Text = items
        Decimal.TryParse(SSD + HDD + GDD + GTX + Book + Chrome, Subs)
        subTextBox.Text = Subs.ToString("C2")
        Decimal.TryParse(Subs * 1.056, grand)
        GrandTextBox.Text = grand.ToString("C2")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        itemsTextBox.Show()
        subTextBox.Show()
        GrandTextBox.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Decimal.TryParse(SSD + HDD + GDD + GTX + Book + Chrome, Subs)
        subTextBox.Text = Subs.ToString("C2")
        Decimal.TryParse(Subs * 1.056, grand)
        GrandTextBox.Text = grand.ToString("C2")
        Decimal.TryParse(Form2.SSDTextBox.Text, S)
        Decimal.TryParse(Form2.HDDTextBox.Text, H)
        Decimal.TryParse(Form3.GDDTextBox.Text, G)
        Decimal.TryParse(Form3.GeforceTextBox.Text, GT)
        Decimal.TryParse(Form6.bookTextBox.Text, Book)
        Decimal.TryParse(Form6.ChromeTextBox.Text, Chrome)
        itemsTextBox.Text = S + H + G + GT + Book + Chrome
    End Sub
End Class