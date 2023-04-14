Imports System.IO
Imports System.Net.Security
Public Class Form1
    Dim lines(100) As String
    Dim idx As Integer
    Dim count As Integer
    Dim current As Integer

    Structure country
        Dim name As String, Yearcreated As String, origincountry As String, marketvalue As String, rarity As String, picture1 As String, picture2 As String
    End Structure
    Function getcoin(Index As Integer) As country
        Dim fields() As String
        Dim c As country
        If Index < 0 Or lines(Index) = "" Then
            Return Nothing
        End If
        fields = lines(Index).Split(separator:="|")
        c.name = fields(0)
        c.Yearcreated = fields(1)
        c.origincountry = fields(2)
        c.marketvalue = fields(3)
        c.rarity = fields(4)
        If IO.File.Exists(fields(5)) Then
            c.picture1 = (fields(5))
        End If
        If IO.File.Exists(fields(6)) Then
            c.picture2 = (fields(6))
        End If
        Return c
    End Function
    Private Sub DisplayPictureBox_Click(sender As Object, e As EventArgs) Handles DisplayPictureBox.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        DisplayPictureBox.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim l As String
        l = NameTextBox.Text
        l += "|"
        l += YearTextBox.Text
        l += "|"
        l += OriginTextBox.Text
        l += "|"
        l += ValueTextBox.Text
        l += "|"
        l += RarityTextBox.Text
        l += "|"
        l += DisplayPictureBox.ImageLocation
        l += "|"
        l += DisplayPictureBox2.ImageLocation
        lines(current) = l
        save()
    End Sub
    Sub save()
        Dim outfile As IO.StreamWriter
        outfile = IO.File.CreateText("collectables.txt")
        For index = 0 To count - 1
            If lines(index) <> "" Then outfile.WriteLine(lines(index))
        Next
        outfile.Close()
    End Sub
    Sub clear()
        NameTextBox.Clear()
        YearTextBox.Clear()
        OriginTextBox.Clear()
        ValueTextBox.Clear()
        RarityTextBox.Clear()
        DisplayPictureBox.Image = Nothing
        DisplayPictureBox2.Image = Nothing
    End Sub
    Sub load()
        Dim infile As StreamReader
        coinsComboBox.Items.Clear()
        If IO.File.Exists("collectables.txt") Then
            infile = IO.File.OpenText("collectables.txt")
            While infile.Peek <> -1
                lines(idx) = infile.ReadLine
                coinsComboBox.Items.Add(getcoin(idx).name)
                idx = idx + 1
            End While
            count = idx
            showcoin(0)
            infile.Close()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Sub showcoin(index As Integer)
        Dim fields() As String
        If index < 0 Or lines(index) = "" Then Return
        fields = lines(index).Split(separator:="|")
        If fields.Length > 0 Then NameTextBox.Text = fields(0)
        If fields.Length > 1 Then YearTextBox.Text = fields(1)
        If fields.Length > 2 Then OriginTextBox.Text = fields(2)
        If fields.Length > 3 Then ValueTextBox.Text = fields(3)
        If fields.Length > 4 Then RarityTextBox.Text = fields(4)
        If fields.Length > 5 Then
            If IO.File.Exists(fields(5)) Then
                DisplayPictureBox.Load(fields(5))
            End If
        End If
        If fields.Length > 6 Then
            If IO.File.Exists(fields(6)) Then
                DisplayPictureBox2.Load(fields(6))
            End If
        End If
        currentLabel.Text = current + 1 & " out of " & count
    End Sub
    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        current = 0
        showcoin(current)
    End Sub

    Private Sub nextbutton_Click(sender As Object, e As EventArgs) Handles nextbutton.Click
        If current < count - 1 Then
            current = current + 1
        Else current = 0
        End If

        showcoin(current)

    End Sub

    Private Sub Previousbutton_Click(sender As Object, e As EventArgs) Handles Previousbutton.Click
        If current > 0 Then
            current = current - 1
        Else current = count - 1
        End If
        showcoin(current)
    End Sub

    Private Sub Lastbutton_Click(sender As Object, e As EventArgs) Handles Lastbutton.Click
        current = count - 1
        showcoin(current)
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        current = count
        count = count + 1
        clear()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        lines(current) = ""
        save()
        load()
    End Sub

    Private Sub countryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coinsComboBox.SelectedIndexChanged
        showcoin(coinsComboBox.SelectedIndex)
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        DisplayPictureBox2.Load(OpenFileDialog2.FileName)
    End Sub

    Private Sub DisplayPictureBox2_Click(sender As Object, e As EventArgs) Handles DisplayPictureBox2.Click
        OpenFileDialog2.ShowDialog()
    End Sub
End Class
