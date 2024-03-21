Public Class Form1
    Dim casecost As Decimal

    Private Sub caseoption1_Click(sender As Object, e As EventArgs) Handles caseoption1.Click
        Dim c1 As Integer

        case1labelamount.Text = c1 + 1


        casecost = casecost + 350
        Label2.Text = casecost.ToString("c2")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        casecost = casecost + 350
        Label2.Text = casecost.ToString("c2")
    End Sub
End Class
