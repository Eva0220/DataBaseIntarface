Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub button3_click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub

    Private Sub button4_click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show()
    End Sub

End Class
