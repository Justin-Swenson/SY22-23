Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim amt As Decimal
        Dim frate As Decimal
        Dim trate As Decimal
        Decimal.TryParse(Fromtextbox.Text, amt)
        If Fromcombobox.Text = "Pesos" Then
            frate = 0.0528
        End If
        If Fromcombobox.Text = "Dollars" Then
            frate = 1
        End If
        If Fromcombobox.Text = "Euros" Then
            frate = 1.09
        End If
        If tocombobox.Text = "Pesos" Then
            trate = 0.0528
        End If
        If tocombobox.Text = "Dollars" Then
            trate = 1
        End If
        If tocombobox.Text = "Euros" Then
            trate = 1.09
        End If
        totextbox.Text = convert(amt, frate, trate).ToString("C2")
    End Sub
    Function convert(amount As Decimal, fromrate As Decimal, torate As Decimal) As Decimal
        Return amount / (fromrate * torate)
    End Function
End Class
