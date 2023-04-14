Class MainWindow
    Dim acolor As Color
    Dim angle As Integer


    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Integer.TryParse(Angletextbox.Text, angle)
        If combobox.Text = "Gradient" Then
            Me.Background = New LinearGradientBrush(Colors.Red, Colors.Purple, angle)
        Else
            acolor = ColorConverter.ConvertFromString(combobox.Text)
            Me.Background = New SolidColorBrush(acolor)
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Integer.TryParse(Angletextbox.Text, angle)
        Select Case combobox.Text
            Case "Red"
                Me.Background = New SolidColorBrush(Colors.Red)
            Case "Yellow"
                Me.Background = New SolidColorBrush(Colors.Yellow)
            Case "Blue"
                Me.Background = New SolidColorBrush(Colors.Blue)
            Case "Purple"
                Me.Background = New SolidColorBrush(Colors.Purple)
            Case "Green"
                Me.Background = New SolidColorBrush(Colors.Green)
            Case "Orange"
                Me.Background = New SolidColorBrush(Colors.Orange)
            Case "Gradient"
                Me.Background = New LinearGradientBrush(Colors.Red, Colors.Purple, angleslider.value)
        End Select

    End Sub
    Dim rgb1 As Integer
    Dim rgb2 As Integer
    Dim rgb3 As Integer
    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Integer.TryParse(Redtextbox.Text, rgb1)
        Integer.TryParse(Greentextbox.Text, rgb2)
        Integer.TryParse(Bluetextbox.Text, rgb3)
        'rgb3 = Bluetextbox.Text
        Resultlabel.Content = rgb1 + rgb2 + rgb3
    End Sub

    Private Sub Redslider_ValueChanged(sender As Object, e As EventArgs)
        showcolor()
    End Sub

    Private Sub Greenslider_ValueChanged(sender As Object, e As EventArgs)
        showcolor()
    End Sub

    Private Sub Blueslider_ValueChanged(sender As Object, e As EventArgs)
        showcolor()
    End Sub
    Private Sub showcolor()
        Dim c As Color
        Dim c2 As Color
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
        r = Redslider.Value
        g = Greenslider.Value
        b = Blueslider.Value
        Redtextbox.Text = r
        Greentextbox.Text = g
        Bluetextbox.Text = b
        c = Color.FromArgb(255, r, g, b)
        c2 = Color.FromArgb(255, 255 - r, 255 - g, 255 - b)
        'Me.Background = New SolidColorBrush(c)
        Me.Background = New LinearGradientBrush(c, c2, Angleslider.Value)

    End Sub
End Class
