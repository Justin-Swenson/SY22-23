Class MainWindow
    Dim length As Decimal
    Dim width As Decimal
    Dim cost As Decimal
    Dim fcost As Decimal


    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        If Carpetcombo.Text = "Trendy Threat II" Then cost = 4
        If Carpetcombo.Text = "Soft Breath II" Then cost = 3.7
        If Carpetcombo.Text = "Westchester III" Then cost = 3.5
        If Carpetcombo.Text = "Trendy Threads I" Then cost = 2.8
        If Carpetcombo.Text = "" Then cost = 1
        fcost = calculate(length, width, cost)
        Costlabel.Content = fcost.ToString("C2")
    End Sub
    Function calculate(l As Decimal, w As Decimal, c As Decimal) As Decimal
        Return l * w * c
    End Function

    Private Sub Lengthslider_ValueChanged(sender As Object, e As EventArgs)
        Decimal.TryParse(Lengthslider.Value, length)
        Lengthlabel.Content = length
    End Sub

    Private Sub Widthslider_ValueChanged(sender As Object, e As EventArgs)
        Decimal.TryParse(Widthslider.Value, width)
        widthlabel.Content = width
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Lengthlabel.Content = ""
        widthlabel.Content = ""
        Carpetcombo.Text = ""
        Lengthslider.Value = 0
        Widthslider.Value = 0
        Costlabel.Content = "$0"
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
