Class MainWindow
    Private Sub FromMenu(sender As Object, e As RoutedEventArgs)
        FromtextBox.Text = sender.header
    End Sub
    Private Sub ToMenu(sender As Object, e As RoutedEventArgs)
        TotextBox.Text = sender.header
    End Sub
    Function DollarstoPesos(dollars As Decimal) As Decimal
        Return 18.5 * dollars
    End Function
    Function PesostoDollars(pesos As Decimal) As Decimal
        Return pesos / 18.5
    End Function
    Function DollarstoPound(dollars As Decimal) As Decimal
        Return dollars / 1.22
    End Function
    Function DollarstoEuros(dollars As Decimal) As Decimal
        Return dollars / 1.08
    End Function
    Function DollarstoYen(Dollars As Decimal) As Decimal
        Return Dollars * 128.43
    End Function
    Function DollarstoRuble(Dollars As Decimal) As Decimal
        Return Dollars * 69.2
    End Function
    Function PesostoPound(pesos As Decimal) As Decimal
        Return pesos * 0.043
    End Function
    Function PesostoEuros(pesos As Decimal) As Decimal
        Return pesos * 0.049
    End Function
    Function PesostoYen(pesos As Decimal) As Decimal
        Return pesos * 6.83
    End Function
    Function PesostoRuble(pesos As Decimal) As Decimal
        Return pesos * 3.67
    End Function
    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim fromAmt As Decimal
        Dim toAmt As Decimal
        Decimal.TryParse(FromtextAmount.Text, fromAmt)
        If FromtextBox.Text = "Dollars" And TotextBox.Text = "Pesos" Then
            toAmt = DollarstoPesos(fromAmt)
        End If
        If FromtextBox.Text = "Dollars" And TotextBox.Text = "Pound" Then
            toAmt = DollarstoPound(fromAmt)
        End If
        If FromtextBox.Text = "Dollars" And TotextBox.Text = "Euros" Then
            toAmt = DollarstoEuros(fromAmt)
        End If
        If FromtextBox.Text = "Dollars" And TotextBox.Text = "Yen" Then
            toAmt = DollarstoYen(fromAmt)
        End If
        If FromtextBox.Text = "Dollars" And TotextBox.Text = "Ruble" Then
            toAmt = DollarstoRuble(fromAmt)
        End If
        If FromtextBox.Text = "Pesos" And TotextBox.Text = "Dollars" Then
            toAmt = PesostoDollars(fromAmt)
        End If
        If FromtextBox.Text = "Pesos" And TotextBox.Text = "Pound" Then
            toAmt = PesostoPound(fromAmt)
        End If
        If FromtextBox.Text = "Pesos" And TotextBox.Text = "Euros" Then
            toAmt = PesostoEuros(fromAmt)
        End If
        If FromtextBox.Text = "Pesos" And TotextBox.Text = "Yen" Then
            toAmt = PesostoYen(fromAmt)
        End If
        If FromtextBox.Text = "Pesos" And TotextBox.Text = "Ruble" Then
            toAmt = PesostoRuble(fromAmt)
        End If
        TotextAmount.Text = toAmt.ToString("C2")
    End Sub
End Class

