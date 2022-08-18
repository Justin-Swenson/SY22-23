Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        displayPictureBox1.Image = BplanePictureBox.Image
        nameLabel6.Text = "Biplane"
        firstusedLabel6.Text = "1903-1909"
        retiredLabel6.Text = "1930s"
        lengthLabel6.Text = "40'"
        longestflightLabel6.Text = "8 hours"
        Length.Text = "24'"
        speedlabel.Text = "75 Mph."

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles NameLabel4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles nameLabel6.Click

    End Sub

    Private Sub PlanePictureBox1_Click(sender As Object, e As EventArgs) Handles BiplanePictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        displayPictureBox1.Image = b17PictureBox.Image
        nameLabel6.Text = "B-17 Flying Fortress"
        firstusedLabel6.Text = "1935"
        retiredLabel6.Text = "1968"
        lengthLabel6.Text = "103'"
        longestflightLabel6.Text = "19 hours"
        Length.Text = "75'"
        speedlabel.Text = "287 Mph."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        displayPictureBox1.Image = f117PictureBox.Image
        nameLabel6.Text = "Lockheed F-117 Nighthawk"
        firstusedLabel6.Text = "1981"
        retiredLabel6.Text = "2008"
        lengthLabel6.Text = "43'"
        longestflightLabel6.Text = "11 hours"
        Length.Text = "66'"
        speedlabel.Text = "684 Mph."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        displayPictureBox1.Image = f35PictureBox.Image
        nameLabel6.Text = "Lockheed Martin F-35 Lightning II"
        firstusedLabel6.Text = "2015"
        retiredLabel6.Text = "Still in use"
        lengthLabel6.Text = "35'"
        longestflightLabel6.Text = "10 hours"
        Length.Text = "51'"
        speedlabel.Text = "1200 Mph."
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        displayPictureBox1.Image = boeingPictureBox.Image
        nameLabel6.Text = "Boeing 747-400"
        firstusedLabel6.Text = "1989"
        retiredLabel6.Text = "Still in use"
        lengthLabel6.Text = "211'"
        longestflightLabel6.Text = "20 hours"
        Length.Text = "232'"
        speedlabel.Text = "614 Mph."
    End Sub

    Private Sub b17PictureBox1_Click(sender As Object, e As EventArgs) Handles b17PictureBox1.Click

    End Sub

    Private Sub displayPictureBox1_Click(sender As Object, e As EventArgs) Handles displayPictureBox1.Click

    End Sub

    Private Sub b17PictureBox_Click(sender As Object, e As EventArgs) Handles b17PictureBox.Click

    End Sub

    Private Sub f117PictureBox_Click(sender As Object, e As EventArgs) Handles f117PictureBox.Click

    End Sub

    Private Sub boeingPictureBox_Click(sender As Object, e As EventArgs) Handles boeingPictureBox.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles mig25button.Click
        displayPictureBox1.Image = migPictureBox1.Image
        nameLabel6.Text = "Mikoyan Gurevich Mig-25"
        firstusedLabel6.Text = "1970"
        retiredLabel6.Text = "1984"
        lengthLabel6.Text = "46'"
        longestflightLabel6.Text = "10 hours"
        Length.Text = "78'"
        speedlabel.Text = "2171 Mph."
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub srButton_Click(sender As Object, e As EventArgs) Handles srButton.Click
        displayPictureBox1.Image = SRPictureBox.Image
        nameLabel6.Text = "Lockheed SR-71 Blackbird"
        firstusedLabel6.Text = "1966"
        retiredLabel6.Text = "1999"
        lengthLabel6.Text = "56'"
        longestflightLabel6.Text = "2 hours"
        Length.Text = "107'"
        speedlabel.Text = "2200 Mph."
    End Sub
End Class
