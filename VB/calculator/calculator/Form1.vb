Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim mem As Decimal
    Dim oper As String
    Private Sub B_Click(sender As Object, e As EventArgs) Handles B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click, B0.Click, dotButton.Click
        DisplayTextBox.Text = DisplayTextBox.Text + sender.text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub plusbutton_Click(sender As Object, e As EventArgs) Handles plusbutton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "+"
        DisplayTextBox.Clear()
    End Sub

    Private Sub equalsButton_Click(sender As Object, e As EventArgs) Handles equalsButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num2)
        If oper = "+" Then
            DisplayTextBox.Text = num1 + num2
        End If
        If oper = "-" Then
            DisplayTextBox.Text = num1 - num2
        End If
        If oper = "*" Then
            DisplayTextBox.Text = num1 * num2
        End If
        If oper = "/" Then
            DisplayTextBox.Text = num1 / num2

        End If
        oper = ""
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "-"
        DisplayTextBox.Clear()
    End Sub

    Private Sub timesButton_Click(sender As Object, e As EventArgs) Handles timesButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "*"
        DisplayTextBox.Clear()
    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "/"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sprt.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Sqrt(num1)
    End Sub

    Private Sub sinButton_Click(sender As Object, e As EventArgs) Handles sinButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Sin(num1)
    End Sub

    Private Sub cosButton_Click(sender As Object, e As EventArgs) Handles cosButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Cos(num1)
    End Sub

    Private Sub tanButton_Click(sender As Object, e As EventArgs) Handles tanButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Tan(num1)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles squareButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = (num1 ^ 2)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayTextBox.Text = Math.PI
    End Sub

    Private Sub MplusButton_Click(sender As Object, e As EventArgs) Handles MplusButton.Click
        Decimal.TryParse(DisplayTextBox.Text, mem)
    End Sub

    Private Sub MRButton_Click(sender As Object, e As EventArgs) Handles MRButton.Click
        DisplayTextBox.Text = mem
    End Sub

    Private Sub MCButton_Click(sender As Object, e As EventArgs) Handles MCButton.Click
        mem = 0
    End Sub
End Class
