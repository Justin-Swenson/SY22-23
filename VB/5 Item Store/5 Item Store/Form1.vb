﻿Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form6.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StorageButton.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles GPUButton.Click
        Form3.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles LaptopsButton.Click
        Form6.ShowDialog()
    End Sub

    Private Sub CheckoutButton_Click(sender As Object, e As EventArgs) Handles CheckoutButton.Click
        Form4.ShowDialog()

    End Sub
End Class
