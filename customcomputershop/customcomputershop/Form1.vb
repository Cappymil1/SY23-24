Public Class Form1
    Dim casecost As Decimal
    Dim c1 As Boolean = False

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If c1 = False Then
            casecost = casecost + 350
            Label2.Text = casecost.ToString("c2")
            c1 = True
            case1labelamount.Text = case1labelamount.Text + 1
        Else
            casecost = casecost - 350
            Label2.Text = casecost.ToString("c2")
            c1 = False
            case1labelamount.Text = case1labelamount.Text - 1
        End If

    End Sub
End Class
