Imports System.Net.Security

Public Class Form1
    Dim turn As Integer

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If B1.Text = " " Then B1.Text = "X"
    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If B2.Text = " " Then B2.Text = "X"
    End Sub
    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If B3.Text = " " Then B3.Text = "X"
    End Sub
    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If B4.Text = " " Then B4.Text = "X"
    End Sub
    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If B5.Text = " " Then B5.Text = "X"
    End Sub
    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        If B6.Text = " " Then B6.Text = "X"
    End Sub
    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        If B7.Text = " " Then B7.Text = "X"
    End Sub
    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        If B8.Text = " " Then B8.Text = "X"
    End Sub
    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        If B9.Text = " " Then B9.Text = "X"
    End Sub
    Private Sub player2A()

        If B9.Text = "X" And B5.Text = " " Or B7.Text = "X" And B5.Text = " " Or B3.Text = "X" And B5.Text = " " Or B1.Text = "X" And B5.Text = " " Then B5.Text = "O"
        If B1.Text = "X" And B4.Text = "X" And B8.Text = " " And B9.Text = " " Or B1.Text = "X" And B4.Text = " " And B8.Text = "X" And B9.Text = " " Then
            corners()
        End If
        If B8.Text = " " Then
            If B9.Text = "X" And B7.Text = "X" And B5.Text = "O" Then
                B8.Text = "O"
            End If
        End If
        If B6.Text = " " Then
            If B9.Text = "X" And B3.Text = "X" And B5.Text = "O" Then
                B6.Text = "O"
            End If
        End If
        If B4.Text = " " Then
            If B7.Text = "X" And B1.Text = "X" And B5.Text = "O" Then
                B4.Text = "O"
            End If
        End If

        If B2.Text = " " Then
            If B9.Text = "X" And B1.Text = "X" And B5.Text = "O" Then
                B2.Text = "O"
            End If
        End If
        If B7.Text = " " And B8.Text = "X" And B9.Text = "X" Then
            B7.Text = "O"
        End If
        If B9.Text = "X" And B6.Text = "X" And B3.Text = " " Then
            B3.Text = "O"
        End If
        If B9.Text = " " And B6.Text = "X" And B3.Text = "X" Then
            B9.Text = "O"
        End If
        If B1.Text = " " And B2.Text = "X" And B3.Text = "X" Then
            B1.Text = "O"
        End If
        If B1.Text = "X" And B2.Text = "X" And B3.Text = " " Then
            B3.Text = "O"
        End If
        If B4.Text = "X" And B2.Text = "X" And B3.Text = "X" And B9.Text = "X" And B7.Text = " " Then
            B7.Text = "O"
        End If
        If B7.Text = "X" And B8.Text = "X" And B9.Text = " " Then
            B9.Text = "O"
        End If
        If B4.Text = "X" And B7.Text = "X" And B1.Text = " " Then
            B1.Text = "O"
        End If
        If B1.Text = "X" And B6.Text = "X" And B7.Text = "X" And B8.Text = "X" And B3.Text = " " Then
            B3.Text = "O"
        End If
        If B2.Text = "X" And B5.Text = "X" And B7.Text = "X" And B9.Text = "X" And B4.Text = " " Then
            B4.Text = "O"
        End If
        If B3.Text = "X" And B4.Text = "X" And B8.Text = "X" And B9.Text = "X" And B1.Text = " " Then
            B1.Text = "O"
        End If
        If B2.Text = "X" And B6.Text = "X" And B3.Text = " " Then
            B3.Text = "O"
        End If
        If B2.Text = "X" And B4.Text = "X" And B1.Text = " " Then
            B1.Text = "O"
        End If
        If B4.Text = "X" And B8.Text = "X" And B7.Text = " " Then
            B7.Text = "O"
        End If
        If B1.Text = "X" And B4.Text = "X" And B7.Text = " " Then
            B7.Text = "O"
        End If
        If B6.Text = "X" And B8.Text = "X" And B9.Text = " " Then
            B9.Text = "O"
        End If
        If B1.Text = "X" And B2.Text = "X" And B6.Text = "X" And B7.Text = " " Then
            B7.Text = "O"
        End If
        If B7.Text = "X" And B2.Text = "X" And B6.Text = "X" And B8.Text = " " Then
            B8.Text = "O"
        End If
        If B3.Text = "X" And B9.Text = "X" And B4.Text = "X" And B8.Text = " " Then
            B8.Text = "O"
        End If
        If B5.Text = "X" And B8.Text = " " Then
            B8.Text = "O"
        End If
        If B5.Text = "X" And B7.Text = "X" And B3.Text = " " Then
            B3.Text = "O"
        End If
        If B5.Text = "X" And B1.Text = "X" And B9.Text = " " Then
            B9.Text = "O"
        End If
        If B5.Text = "X" And B9.Text = "X" And B1.Text = " " Then
            B1.Text = "O"
        End If
        If B5.Text = "X" And B3.Text = "X" And B7.Text = " " Then
            B7.Text = "O"
        End If
        If B5.Text = "X" And B2.Text = "X" And B1.Text = " " Then
            B1.Text = "O"
        End If
        If B5.Text = "X" And B4.Text = "X" And B6.Text = " " Then
            B6.Text = "O"
        End If
        If B5.Text = "X" And B6.Text = "X" And B4.Text = " " Then
            B4.Text = "O"
        End If
        If B1.Text = "X" And B3.Text = "X" And B2.Text = " " Then
            B2.Text = "O"
        End If

    End Sub
    Private Sub corners()
        If B2.Text = "X" And B5.Text = " " Or B4.Text = "X" And B5.Text = " " Or B9.Text = "X" And B5.Text = " " Or B8.Text = "X" And B5.Text = " " Then B5.Text = "O"

    End Sub
    Private Sub player2B()

    End Sub
    Function iswinner() As Boolean
        If B1.Text = B2.Text And B2.Text = B3.Text And B1.Text <> " " And B1.Text = "X" Then Return True
        If B4.Text = B5.Text And B5.Text = B6.Text And B4.Text <> " " And B4.Text = "X" Then Return True
        If B7.Text = B8.Text And B8.Text = B9.Text And B7.Text <> " " And B7.Text = "X" Then Return True
        If B1.Text = B4.Text And B4.Text = B7.Text And B1.Text <> " " And B1.Text = "X" Then Return True
        If B2.Text = B5.Text And B5.Text = B8.Text And B2.Text <> " " And B2.Text = "X" Then Return True
        If B3.Text = B6.Text And B6.Text = B9.Text And B3.Text <> " " And B3.Text = "X" Then Return True
        If B1.Text = B5.Text And B5.Text = B9.Text And B1.Text <> " " And B1.Text = "X" Then Return True
        If B3.Text = B5.Text And B5.Text = B7.Text And B3.Text <> " " And B3.Text = "X" Then Return True

        Return False
    End Function
    Function isloser() As Boolean
        If B1.Text = B2.Text And B2.Text = B3.Text And B1.Text <> " " And B1.Text = "O" Then Return True
        If B4.Text = B5.Text And B5.Text = B6.Text And B4.Text <> " " And B4.Text = "O" Then Return True
        If B7.Text = B8.Text And B8.Text = B9.Text And B7.Text <> " " And B7.Text = "O" Then Return True
        If B1.Text = B4.Text And B4.Text = B7.Text And B1.Text <> " " And B1.Text = "O" Then Return True
        If B2.Text = B5.Text And B5.Text = B8.Text And B2.Text <> " " And B2.Text = "O" Then Return True
        If B3.Text = B6.Text And B6.Text = B9.Text And B3.Text <> " " And B3.Text = "O" Then Return True
        If B1.Text = B5.Text And B5.Text = B9.Text And B1.Text <> " " And B1.Text = "O" Then Return True
        If B3.Text = B5.Text And B5.Text = B7.Text And B3.Text <> " " And B3.Text = "O" Then Return True

        Return False
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If turn = 0 Then player2A() Else player2B()
        Label1.Text = turn
        If isloser() And turn = 0 Then
            WinLabel.Text = "You lose!"
        End If
        If iswinner() And turn = 0 Then
            WinLabel.Text = "You Win!"
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        B1.Text = " "
        B2.Text = " "
        B3.Text = " "
        B4.Text = " "
        B5.Text = " "
        B6.Text = " "
        B7.Text = " "
        B8.Text = " "
        B9.Text = " "
        WinLabel.Text = " "
    End Sub

    Private Sub P1_Click(sender As Object, e As EventArgs) Handles P1.Click
        turn = 0
    End Sub

    Private Sub P2_Click(sender As Object, e As EventArgs) Handles P2.Click
        turn = 1
    End Sub
End Class
