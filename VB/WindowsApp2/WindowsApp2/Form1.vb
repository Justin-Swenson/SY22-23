Public Class Form1


    Private Sub USbutton_Click(sender As Object, e As EventArgs) Handles USbutton.Click
        Dim Amount As Decimal
        Decimal.TryParse(USTextBox.Text, Amount)
        Dim euro As Decimal
        Dim v As Double = Amount * 1
        euro = v
        VCTextBox.Text = euro.ToString("C2")
        Dim Pesos As Decimal
        Dim w As Double = Amount * 19.92
        Pesos = w
        MexicoTextBox.Text = Pesos.ToString("C2")
        Dim Cyuan As Decimal
        Dim y As Double = Amount * 6.85
        Cyuan = y
        ChinaTextBox.Text = Cyuan.ToString("C2")
        Dim ruble As Decimal
        Dim x As Double = Amount * 60.5
        ruble = x
        RussiaTextBox.Text = ruble.ToString("C2")
        Dim pound As Decimal
        Dim z As Double = Amount * 0.85
        pound = z
        UKTextBox.Text = pound.ToString("C2")
        Dim won As Decimal
        Dim a As Double = Amount * 1335.06
        won = a
        SouthKoreaTextBox.Text = won.ToString("C2")
    End Sub

    Private Sub MexicoButton_Click(sender As Object, e As EventArgs) Handles MexicoButton.Click
        Dim Mamount As Decimal
        Decimal.TryParse(MexicoTextBox.Text, Mamount)
        USTextBox.Text = (Mamount * 0.05.ToString("C2"))
    End Sub

    Private Sub ChinaButton_Click(sender As Object, e As EventArgs) Handles ChinaButton.Click
        Dim Camount As Decimal
        Decimal.TryParse(ChinaTextBox.Text, Camount)
        USTextBox.Text = (Camount * 0.14.ToString("C2"))
    End Sub

    Private Sub SouthKoreaButton_Click(sender As Object, e As EventArgs) Handles SouthKoreaButton.Click
        Dim Kamount As Decimal
        Decimal.TryParse(SouthKoreaTextBox.Text, Kamount)
        USTextBox.Text = (Kamount * 0.00075).ToString("C2")
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        USTextBox.Clear()
        MexicoTextBox.Clear()
        ChinaTextBox.Clear()
        UKTextBox.Clear()
        VCTextBox.Clear()
        RussiaTextBox.Clear()
        SouthKoreaTextBox.Clear()
    End Sub

    Private Sub VCTextBox_TextChanged(sender As Object, e As EventArgs) Handles VCTextBox.TextChanged
        Dim VCamount As Decimal
        Decimal.TryParse(VCTextBox.Text, VCamount)
        USTextBox.Text = (VCamount * 1).ToString("C2")
    End Sub

    Private Sub VCButton_Click(sender As Object, e As EventArgs) Handles VCButton.Click

    End Sub

    Private Sub UKButton_Click(sender As Object, e As EventArgs) Handles UKButton.Click
        Dim UKamount As Decimal
        Decimal.TryParse(UKTextBox.Text, UKamount)
        USTextBox.Text = (UKamount * 1.17).ToString("C2")
    End Sub

    Private Sub RussiaButton_Click(sender As Object, e As EventArgs) Handles RussiaButton.Click
        Dim Ramount As Decimal
        Decimal.TryParse(RussiaTextBox.Text, Ramount)
        USTextBox.Text = (Ramount * 0.016).ToString("C2")
    End Sub

    Private Sub USTextBox_TextChanged(sender As Object, e As EventArgs) Handles USTextBox.TextChanged

    End Sub
End Class

