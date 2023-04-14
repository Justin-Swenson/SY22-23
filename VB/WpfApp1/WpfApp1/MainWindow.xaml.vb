Imports System.IO
Imports Microsoft.Win32

Class MainWindow
    Private Sub Bold_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textbox1.FontWeight = FontWeights.Bold
    End Sub

    Private Sub Bold_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textbox1.FontWeight = FontWeights.Normal
    End Sub

    Private Sub Italic_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textbox1.FontStyle = FontStyles.Italic
    End Sub

    Private Sub Italic_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textbox1.FontStyle = FontStyles.Normal
    End Sub
    Dim fontthing As Decimal = 10
    Private Sub IncreaseFont_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If textbox1.FontSize < 1000 Then
            textbox1.FontSize += fontthing
            fontthing += 10
        End If
    End Sub

    Private Sub DecreaseFont_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If textbox1.FontSize > 10 Then
            textbox1.FontSize -= 2
        End If
    End Sub

    Private Sub exit_click()
        Me.Close()
    End Sub
    Private Sub Open_click()
        ' Create OpenFileDialog
        Dim dlg As New Microsoft.Win32.OpenFileDialog()

        ' Set filter for file extension and default file extension
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox
        If result = True Then
            ' Open document
            Dim filename As String = dlg.FileName
            show_file(filename)
        End If
    End Sub
    Sub show_file(fname As String)
        Dim filereader As System.IO.StreamReader
        filereader = New StreamReader(fname)

        Dim stringreader As String
        stringreader = filereader.ReadToEnd
        textbox1.Text = stringreader
        filereader.Close()
    End Sub
    Sub savefile(Fname As String)
        Dim filewriter As StreamWriter
        filewriter = New StreamWriter(Fname)
        filewriter.Write(textbox1.Text)
        filewriter.Close()
    End Sub
    Private Sub New_click()
        textbox1.Text = ""
    End Sub
    Private Sub Save_click()
        ' Create OpenFileDialog
        Dim dlg As New Microsoft.Win32.SaveFileDialog()

        ' Set filter for file extension and default file extension
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox
        If result = True Then
            ' Open document
            Dim filename As String = dlg.FileName
            savefile(filename)
        End If
    End Sub
End Class
