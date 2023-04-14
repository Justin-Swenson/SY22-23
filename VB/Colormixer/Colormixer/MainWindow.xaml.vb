Imports System.IO
Imports System.Windows.Automation
Imports System.Windows.Threading
Imports Microsoft.Win32

Class MainWindow
    Dim r As Decimal
    Dim g As Integer
    Dim b As Integer
    Dim angle As Integer
    Dim g1 As Color
    Dim g2 As Color
    Dim shape As String
    Dim edit As String

    Private Sub Redslider_ValueChanged(sender As Object, e As EventArgs)
        Dim brush = New SolidColorBrush(Color.FromRgb(r, g, b))
        r = Redslider.Value
        Redlabel.Content = r
        changecolor()

    End Sub

    Private Sub Greenslider_ValueChanged(sender As Object, e As EventArgs)
        Dim brush = New SolidColorBrush(Color.FromRgb(r, g, b))
        g = Greenslider.Value
        greenlabel.Content = Greenslider.Value
        changecolor()
        Dim width As Integer, height As Integer
        width = widthslider.Value
        height = heightslider.Value
    End Sub

    Private Sub Blueslider_ValueChanged(sender As Object, e As EventArgs)
        b = Blueslider.Value
        bluelabel.Content = Blueslider.Value
        changecolor()
    End Sub
    Sub changecolor()

        colorrectangle.Fill = New SolidColorBrush(Color.FromRgb(r, g, b))
    End Sub
    Sub changegradient()
        colorrectangle.Fill = New RadialGradientBrush(g1, g2)
    End Sub
    Private Sub button_Click(sender As Object, e As RoutedEventArgs)
        sender.background = colorrectangle.Fill
    End Sub

    Private Sub Gradient_1_Click(sender As Object, e As RoutedEventArgs) Handles gradient1.Click
        g1 = Color.FromRgb(r, g, b)
        gradient1.Background = New SolidColorBrush(g1)
    End Sub

    Private Sub Gradient_2_Click(sender As Object, e As RoutedEventArgs) Handles gradient2.Click
        g2 = Color.FromRgb(r, g, b)
        gradient2.Background = New SolidColorBrush(g2)
    End Sub
    Private Sub Radial_gradient_Click(sender As Object, e As RoutedEventArgs) Handles Radial_gradient.Click
        changegradient()
    End Sub

    Private Sub Linearbutton_Click(sender As Object, e As RoutedEventArgs) Handles Linearbutton.Click
        colorrectangle.Fill = New LinearGradientBrush(g1, g2, angle)
    End Sub

    Private Sub Angle_slider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        angle = Angle_slider.Value
        anglelabel.Content = angle
        colorrectangle.Fill = New LinearGradientBrush(g1, g2, angle)

    End Sub

    Private Sub MyParentCanvas_MouseMove(sender As Object, e As MouseEventArgs)
        Select Case shape
            Case "Rectangle"
                Dim el As New Rectangle
                el.Width = widthslider.Value
                el.Height = heightslider.Value
                el.Fill = colorrectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "Ellipse"
                Dim el As New Ellipse
                el.Width = widthslider.Value
                el.Height = heightslider.Value
                el.Fill = colorrectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "triangle"
                Dim el As New Polygon
                el.Width = widthslider.Value
                el.Height = heightslider.Value
                el.Fill = colorrectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                el.Points.Add(New Point(0, 0))
                el.Points.Add(New Point(widthslider.Value, 0))
                el.Points.Add(New Point(heightslider.Value, widthslider.Value))
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "fish"
                Dim el As New Polygon
                el.Fill = colorrectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                el.Points.Add(New Point(p.X, p.Y))
                el.Points.Add(New Point(p.X, p.Y + heightslider.Value / 2))
                el.Points.Add(New Point(p.X + (widthslider.Value / 4) * 2, p.Y + heightslider.Value / 4))
                el.Points.Add(New Point(p.X + (widthslider.Value / 4) * 5, (p.Y + heightslider.Value / 4) - (heightslider.Value / 4) + 2))
                el.Points.Add(New Point(p.X + (widthslider.Value / 4) * 8, p.Y + heightslider.Value / 4))
                el.Points.Add(New Point(p.X + (widthslider.Value / 4) * 5, (p.Y + heightslider.Value / 4) + (heightslider.Value / 4) + 2))
                el.Points.Add(New Point(p.X + widthslider.Value / 2, p.Y + heightslider.Value / 4 + 0.01))
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "polygon"
                Dim el As New Polygon
                el.Fill = colorrectangle.Fill
                Dim numpoints As Integer = Sidesslider.Value
                For index = 0 To numpoints - 1
                    Dim angle As Decimal
                    angle = (2 * Math.PI / numpoints) * index
                    el.Points.Add(New Point(Math.Cos(angle) * widthslider.Value, Math.Sin(angle) * widthslider.Value))
                Next
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)

                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "amogus"
                Dim myImageBrush As New ImageBrush(amogus.Source)
                Dim myCanvas As New Canvas
                myCanvas.Width = widthslider.Value
                myCanvas.Height = heightslider.Value
                myCanvas.Background = myImageBrush
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(myCanvas, p.X)
                Canvas.SetTop(myCanvas, p.Y)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(myCanvas)
                End If
            Case "chicken"
                Dim myImageBrush As New ImageBrush(chicken.Source)
                Dim myCanvas As New Canvas
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                myCanvas.Width = widthslider.Value
                myCanvas.Height = heightslider.Value
                myCanvas.Background = myImageBrush
                Canvas.SetLeft(myCanvas, p.X)
                Canvas.SetTop(myCanvas, p.Y)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(myCanvas)
                End If
            Case "Erase"
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Dim result As HitTestResult = VisualTreeHelper.HitTest(drawingCanvas, p)
                If e.RightButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Remove(result.VisualHit)
                End If
        End Select
        Select Case Edit
            Case "Replace"
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Dim result As HitTestResult = VisualTreeHelper.HitTest(drawingCanvas, p)
                    If e.RightButton = MouseButtonState.Pressed Then
                    'drawingCanvas.Children.Add()
                End If

                    Case Else
                End Select
                fromslider.Maximum = drawingCanvas.Children.Count - 1
        toslider.Maximum = drawingCanvas.Children.Count - 1
    End Sub

    Private Sub widthslider_ValueChanged(sender As Object, e As EventArgs)
        anglelabel_Copy.Content = widthslider.Value
        If widthslider.Value < 1 Then widthslider.Value = 1

    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        g1 = Colors.Red
        g2 = Colors.Green
        gradient1.Background = New SolidColorBrush(g1)
        gradient2.Background = New SolidColorBrush(g2)
        widthslider.Value = 1
        heightslider.Value = 1

    End Sub

    Private Sub rbutton_Click(sender As Object, e As RoutedEventArgs) Handles rbutton.Click
        shape = "Rectangle"
    End Sub

    Private Sub Ebutton_Click(sender As Object, e As RoutedEventArgs) Handles Ebutton.Click
        shape = "Ellipse"
    End Sub
    Private Sub heightslider_ValueChanged_1(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        heightlable.Content = heightslider.Value
        If heightslider.Value < 1 Then heightslider.Value = 1
    End Sub

    Private Sub tbutton_Click(sender As Object, e As RoutedEventArgs) Handles tbutton.Click
        shape = "triangle"
    End Sub

    Private Sub clear_Click(sender As Object, e As RoutedEventArgs) Handles clear.Click
        drawingCanvas.Children.Clear()
    End Sub

    Private Sub fbutton_Click(sender As Object, e As RoutedEventArgs) Handles fbutton.Click
        shape = "fish"
    End Sub

    Private Sub polygon_Click(sender As Object, e As RoutedEventArgs) Handles polygon.Click
        shape = "polygon"
    End Sub

    Private Sub sidesslider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        sideslabel.Content = sidesslider.Value
        If sidesslider.Value < 3 Then sidesslider.Value = 3

    End Sub

    Private Sub OnClick5(sender As Object, e As RoutedEventArgs)
        shape = "amogus"
    End Sub

    Private Sub chicken1_Click(sender As Object, e As RoutedEventArgs) Handles chicken1.Click
        shape = "chicken"
    End Sub

    Private Sub deletebutton_Click(sender As Object, e As RoutedEventArgs) Handles deletebutton.Click
        drawingCanvas.Children.RemoveRange(fromslider.Value, toslider.Value - fromslider.Value)
        fromslider.Maximum = drawingCanvas.Children.Count - 1
        toslider.Maximum = drawingCanvas.Children.Count - 1

    End Sub

    Private Sub savebutton_Click(sender As Object, e As RoutedEventArgs) Handles savebutton.Click
        ExporttoPng(drawingCanvas)
    End Sub
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(drawingCanvas, 200)

        Canvas.SetTop(drawingCanvas, 32)

    End Sub

    Private Sub MyParentCanvas_Loaded(sender As Object, e As RoutedEventArgs)
        Dim dt As DispatcherTimer = New DispatcherTimer()
        AddHandler dt.Tick, AddressOf dispatcherTimer_Tick

        dt.Interval = New TimeSpan(0, 0, 1)
        dt.Start()
    End Sub
    Public Sub dispatcherTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If leftrightslider.Value > 0 Then
            For Each u In drawingCanvas.Children
                Canvas.SetLeft(u, Canvas.GetLeft(u) + 10)
            Next
        End If
        If leftrightslider.Value < 0 Then
            For Each u In drawingCanvas.Children
                Canvas.SetLeft(u, Canvas.GetLeft(u) - 10)
            Next
        End If
        If updownslider.Value < 0 Then
            For Each u In drawingCanvas.Children
                Canvas.SetTop(u, Canvas.GetTop(u) + 10)
            Next
        End If
        If updownslider.Value > 0 Then
            For Each u In drawingCanvas.Children
                Canvas.SetTop(u, Canvas.GetTop(u) - 10)
            Next
        End If
    End Sub

    Private Sub leftrightslider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        leftrightlabel.Content = leftrightslider.Value
    End Sub

    Private Sub updownslider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        updownlabel.Content = updownslider.Value
    End Sub

    Private Sub Erasebuton_Click(sender As Object, e As RoutedEventArgs) Handles Erasebuton.Click
        shape = "Erase"
    End Sub

    Private Sub replacebutton_Click(sender As Object, e As RoutedEventArgs) Handles replacebutton.Click
        edit = "Replace"
    End Sub
End Class
