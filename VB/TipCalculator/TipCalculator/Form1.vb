Public Class Form1
    Private Sub enterbutton_Click(sender As Object, e As EventArgs) Handles enterbutton.Click
        Dim price As Decimal
        Decimal.TryParse(PriceTextBox.Text, price)
        Dim tip As Decimal
        Decimal.TryParse(TipTextBox.Text, tip)
        Dim tipamount As Decimal
        tipamount = (tip * 0.01)
        Dim tiptotal As Decimal
        tiptotal = tipamount * price

        Dim tax As Decimal
        tax = price * 0.056
        taxTextBox.Text = tax.ToString("c2")
        Dim grandtotal As Decimal
        Dim subtotal As Decimal
        subtotal = price + tiptotal
        Subtextbox.text = subtotal
        grandtotal = price + tiptotal + tax
        GrandtotalTextBox.Text = grandtotal.ToString("c2")
        If tipamount < 0.05 Then GrandtotalTextBox.Clear()
        If tipamount < 0.05 Then tipLabel.Text = "tip must be above 5%"
        If tipamount < 0.05 Then taxTextBox.Clear()
        If tipamount < 0.05 Then TipTextBox.Clear()
        If tipamount > 0.049 Then tipLabel.Text = " "



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TipTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipTextBox.TextChanged

    End Sub
End Class
