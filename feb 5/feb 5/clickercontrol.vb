﻿Public Class clickercontrol
    Dim c As New clickervb
    Public Property increment As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.increment = increment
        c.click()
        TextBox2.Text = c.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.reset()
        TextBox2.Text = c.count
    End Sub

End Class
