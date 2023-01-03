Public Class Form1
    Dim length As Integer
    Dim width As Integer
    Dim radius As Integer
    Dim Cradius As Integer
    Dim height As Integer
    Dim Plength As Integer
    Dim pWidth As Integer
    Dim pheight As Integer
    Private Sub Calculate()
        Integer.TryParse(LengthTextBox.Text, length)
        Integer.TryParse(WidthTextBox.Text, width)
        AreaTextBox.Text = rectanglearea(length, width)
        PerimeterTextBox.Text = rectangleperimeter(length, width)
    End Sub
    Function rectanglearea(l As Integer, w As Integer) As Integer
        Return l * w
    End Function
    Function rectangleperimeter(l As Integer, w As Integer) As Integer
        Return 2 * l + 2 * w
    End Function

    Private Sub LengthTrackBar_Scroll(sender As Object, e As EventArgs) Handles LengthTrackBar.Scroll
        LengthTextBox.Text = LengthTrackBar.Value
    End Sub

    Private Sub WidthTrackBar_Scroll(sender As Object, e As EventArgs) Handles WidthTrackBar.Scroll
        WidthTextBox.Text = WidthTrackBar.Value
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles WidthTextBox.TextChanged, LengthTextBox.TextChanged
        Calculate()
    End Sub

    Private Sub RadiusTrackBar_Scroll(sender As Object, e As EventArgs) Handles RadiusTrackBar.Scroll
        RadiusTextBox.Text = RadiusTrackBar.Value
    End Sub
    Sub cirlcecalculate()
        circleareatextbox.Text = circleareacalculate(radius).ToString("N2")
        CircumferenceTextBox.Text = circlecircumference(radius).ToString("N2")
        VolumeTextBox.Text = spherevolume(radius).ToString("N2")
        SurfaceareaTextBox.Text = spheresurfacearea(radius).ToString("N2")
    End Sub
    Function circleareacalculate(r As Integer) As Decimal
        Return r ^ 2 * Math.PI
    End Function
    Function circlecircumference(r As Integer) As Decimal
        Return 2 * r * Math.PI
    End Function
    Private Sub RadiusTextBox_TextChanged(sender As Object, e As EventArgs) Handles RadiusTextBox.TextChanged
        Integer.TryParse(RadiusTextBox.Text, radius)
        cirlcecalculate()
    End Sub
    Function spherevolume(r As Integer) As Decimal
        Return 4 / 3 * Math.PI * r ^ 3
    End Function
    Function spheresurfacearea(r As Integer) As Decimal
        Return 4 * Math.PI * r ^ 2
    End Function
    Sub cylindercalculate()
        Integer.TryParse(HeightTextBox.Text, height)
        Integer.TryParse(CRadiusTextBox.Text, Cradius)
        CvolumeTextBox.Text = cylindervolume(Cradius, height).ToString("N2")
        CsurfaceareaTextBox.Text = cylindersurfacearea(Cradius, height).ToString("N2")
    End Sub
    Function cylindervolume(r As Integer, h As Integer) As Decimal
        Return Math.PI * r ^ 2 * h
    End Function
    Function cylindersurfacearea(r As Integer, h As Integer) As Decimal
        Return 2 * Math.PI * r * h + 2 * Math.PI * r ^ 2
    End Function
    Private Sub CHeightTrackBar_Scroll(sender As Object, e As EventArgs) Handles HeightTrackBar.Scroll
        HeightTextBox.Text = HeightTrackBar.Value
    End Sub

    Private Sub CRadiusTrackBar_Scroll(sender As Object, e As EventArgs) Handles CRadiusTrackBar.Scroll
        CRadiusTextBox.Text = CRadiusTrackBar.Value
    End Sub

    Private Sub CRadiusTextBox_TextChanged(sender As Object, e As EventArgs) Handles CRadiusTextBox.TextChanged
        cylindercalculate()
    End Sub

    Private Sub HeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles HeightTextBox.TextChanged
        cylindercalculate()
    End Sub
    Sub pyramidcalculate()
        Integer.TryParse(PlengthTextBox.Text, Plength)
        Integer.TryParse(PwidthTextBox.Text, Pwidth)
        Integer.TryParse(PheightTextBox.Text, pheight)
        PvolumeTextBox.Text = pyramidvolume(Plength, pWidth, pheight).ToString("N2")
        PSurfaceareaTextBox.Text = pyramidsurfacearea(Plength, pWidth, pheight).ToString("N2")
    End Sub
    Function pyramidvolume(l As Integer, w As Integer, h As Integer) As Decimal
        Return (l * w * h) / 3
    End Function
    Function pyramidsurfacearea(l As Integer, w As Integer, h As Integer) As Decimal
        Return l * w + l * Math.Sqrt((w / 2) ^ 2 + h ^ 2) + w * Math.Sqrt((l / 2) ^ 2 + h ^ 2)
    End Function
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles PheightTrackBar.Scroll, PwidthTrackBar.Scroll, PlengthTrackBar.Scroll
        PlengthTextBox.Text = PlengthTrackBar.Value
        PwidthTextBox.Text = PwidthTrackBar.Value
        PheightTextBox.Text = PheightTrackBar.Value
    End Sub

    Private Sub PheightTextBox_TextChanged(sender As Object, e As EventArgs) Handles PwidthTextBox.TextChanged, PlengthTextBox.TextChanged, PheightTextBox.TextChanged
        pyramidcalculate()
    End Sub
End Class
