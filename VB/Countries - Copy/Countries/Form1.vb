Imports System.IO
Imports System.Net.Security

Public Class Form1
    Dim lines(100) As String
    Dim idx As Integer
    Dim count As Integer
    Dim current As Integer

    Structure country
        Dim name As String, capital As String, population As String, size As String, picture As String
    End Structure
    Function getcountry(Index As Integer) As country
        Dim fields() As String
        Dim c As country
        If Index < 0 Or lines(Index) = "" Then
            Return Nothing
        End If
        fields = lines(Index).Split(separator:="|")
        c.name = fields(0)
        c.capital = fields(1)
        c.population = fields(2)
        c.size = fields(3)
        If IO.File.Exists(fields(4)) Then
            c.picture = (fields(4))
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
        l = CountryTextBox.Text
        l += "|"
        l += CapitalTextBox.Text
        l += "|"
        l += populationTextBox.Text
        l += "|"
        l += sizeTextBox.Text
        l += "|"
        l += DisplayPictureBox.ImageLocation
        lines(current) = l
        save()
    End Sub
    Sub save()
        Dim outfile As IO.StreamWriter
        outfile = IO.File.CreateText("countries.txt")
        For index = 0 To count - 1
            If lines(index) <> "" Then outfile.WriteLine(lines(index))
        Next
        outfile.Close()
    End Sub
    Sub clear()
        CountryTextBox.Clear()
        CapitalTextBox.Clear()
        populationTextBox.Clear()
        sizeTextBox.Clear()
        DisplayPictureBox.Image = Nothing
    End Sub
    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click

    End Sub
    Sub load()
        Dim infile As StreamReader
        countryComboBox.Items.Clear()
        If IO.File.Exists("countries.txt") Then
            infile = IO.File.OpenText("countries.txt")
            While infile.Peek <> -1
                lines(idx) = infile.ReadLine
                countryComboBox.Items.Add(getcountry(idx).name)
                idx = idx + 1
            End While
            count = idx
            showcountry(0)
            infile.Close()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Sub showcountry(index As Integer)
        Dim fields() As String
        If index < 0 Or lines(index) = "" Then Return
        fields = lines(index).Split(separator:="|")
        CountryTextBox.Text = fields(0)
        CapitalTextBox.Text = fields(1)
        populationTextBox.Text = fields(2)
        sizeTextBox.Text = fields(3)
        If IO.File.Exists(fields(4)) Then
            DisplayPictureBox.Load(fields(4))
        End If
    End Sub
    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        current = 0
        showcountry(current)
    End Sub

    Private Sub nextbutton_Click(sender As Object, e As EventArgs) Handles nextbutton.Click
        If current < 9 Then
            current = current + 1
        Else current = 0
        End If

        showcountry(current)

    End Sub

    Private Sub Previousbutton_Click(sender As Object, e As EventArgs) Handles Previousbutton.Click
        If current > 0 Then
            current = current - 1
        Else current = 9
        End If
        showcountry(current)
    End Sub

    Private Sub Lastbutton_Click(sender As Object, e As EventArgs) Handles Lastbutton.Click
        showcountry(count - 1)
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

    Private Sub countryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles countryComboBox.SelectedIndexChanged
        showcountry(countryComboBox.SelectedIndex)
    End Sub
End Class
