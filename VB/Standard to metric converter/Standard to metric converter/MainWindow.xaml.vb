Class MainWindow
    Dim fromAmt As Decimal, toAmt As Decimal, fromRate As Decimal, toRate As Decimal
    Private Sub Volumeconvertbutton_Click(sender As Object, e As RoutedEventArgs) Handles Volumeconvertbutton.Click
        If StandardvolumeCombobox.Text = "tablespoon" Then fromRate = 14.7868
        If StandardvolumeCombobox.Text = "fluid ounce" Then fromRate = 29.5735
        If StandardvolumeCombobox.Text = "gill" Then fromRate = 118.3
        If StandardvolumeCombobox.Text = "cup" Then fromRate = 240.00057168
        If StandardvolumeCombobox.Text = "pint" Then fromRate = 473.2
        If StandardvolumeCombobox.Text = "quart" Then fromRate = 946.4
        If StandardvolumeCombobox.Text = "gallon" Then fromRate = 3785
        If StandardvolumeCombobox.Text = "" Then fromRate = 1

        If Metricvolumecombobox.Text = "milliliter" Then toRate = 1
        If Metricvolumecombobox.Text = "liter" Then toRate = 1000
        If Metricvolumecombobox.Text = "kiloliter" Then toRate = 1000000
        If Metricvolumecombobox.Text = "" Then toRate = 1



        Decimal.TryParse(Fromtextbox.Text, fromAmt)
        Totextbox.Text = Convert(fromAmt, fromRate, toRate)
    End Sub
    Function Convert(amt As Decimal, fRate As Decimal, tRate As Decimal)

        Return amt * (fRate / tRate)

    End Function

    Private Sub Lengthconvertbuttton_Click(sender As Object, e As RoutedEventArgs) Handles Lengthconvertbuttton.Click
        If Standardlengthcombobox.Text = "inch" Then fromRate = 14.7868
        If Standardlengthcombobox.Text = "foot" Then fromRate = 29.5735
        If Standardlengthcombobox.Text = "yard" Then fromRate = 118.3
        If Standardlengthcombobox.Text = "mile" Then fromRate = 160900
        If Standardlengthcombobox.Text = "" Then fromRate = 1


        If Metriclengthcombobox.Text = "millimeter" Then toRate = 0.1
        If Metriclengthcombobox.Text = "centimeter" Then toRate = 1
        If Metriclengthcombobox.Text = "meter" Then toRate = 100
        If Metriclengthcombobox.Text = "kilometer" Then toRate = 100000
        If Metriclengthcombobox.Text = " " Then toRate = 1

        Decimal.TryParse(Fromtextbox.Text, fromAmt)
        Totextbox.Text = Convert(fromAmt, fromRate, toRate)
    End Sub

    Private Sub Clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles Clearbutton.Click
        Fromtextbox.Text = ""
    End Sub
End Class
