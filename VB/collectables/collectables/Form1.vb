Imports System.IO

Public Class Form1
    Dim lines(100) As String
    Dim idx As Integer
    Dim count As Integer
    Dim current As Integer
    Structure country
        Dim name As String, yearcreated As String, origincountry As String, marketvalue As String, rarity As String, picture As String, picture2 As String
    End Structure

    Private Sub displayPictureBox_Click(sender As Object, e As EventArgs) Handles displayPictureBox.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub displayPictureBox2_Click(sender As Object, e As EventArgs) Handles displayPictureBox2.Click
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        displayPictureBox.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        displayPictureBox2.Load(OpenFileDialog2.FileName)
    End Sub
    Sub save()
        Dim outfile As IO.StreamWriter
        outfile = IO.File.CreateText("collectables.txt")
        For index = 0 To count - 1
            If lines(index) <> "" Then outfile.WriteLine(lines(index))
        Next
        outfile.Close()
    End Sub
    Sub load()
        Dim infile As StreamReader
        If IO.File.Exists("collectables.txt") Then
            infile = IO.File.OpenText("collectables.txt")
            While infile.Peek <> -1
                lines(idx) = infile.ReadLine
                idx = idx + 1
            End While
            count = idx
            infile.Close()
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim l As String
        l = nameTextBox.Text
        l += "|"
        l += yearcreatedTextBox.Text
        l += "|"
        l += origincountryTextBox.Text
        l += "|"
        l += marketvalueTextBox.Text
        l += "|"
        l += RarityTextBox.Text
        l += "|"
        l += displayPictureBox.ImageLocation
        l += "|"
        l += displayPictureBox2.ImageLocation
        lines(current) = l
        save()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        If current < 9 Then
            current = current + 1
        Else current = 0
        End If
        'showcountry(current)
    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        If current > 0 Then
            current = current - 1
        Else current = 9
        End If
        'showcountry(current)
    End Sub
End Class
