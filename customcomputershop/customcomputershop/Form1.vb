Public Class Form1
    Dim casecost As Decimal
    Dim pcost As Decimal
    Dim c1 As Boolean = False
    Dim c2 As Boolean = False
    Dim c3 As Boolean = False
    Dim MB1 As Boolean = False
    Dim MB2 As Boolean = False
    Dim MB3 As Boolean = False
    Dim GC1 As Boolean = False
    Dim GC2 As Boolean = False
    Dim GC3 As Boolean = False
    Dim c4 As Boolean = False
    Dim p1 As Boolean = False
    Dim p2 As Boolean = False
    Dim p3 As Boolean = False
    Dim R1 As Boolean = False
    Dim R2 As Boolean = False
    Dim R3 As Boolean = False

    Dim totalcost As Decimal

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If c1 = False Then
            totalcost = totalcost + 124.99
            Label2.Text = totalcost.ToString("c2")
            c1 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 124.99
            End If
            Label2.Text = totalcost.ToString("c2")
            c1 = False

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If c2 = False Then
            totalcost = totalcost + 89.08
            Label2.Text = totalcost.ToString("c2")
            c2 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 89.08
            End If
            Label2.Text = totalcost.ToString("c2")
            c2 = False

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If c3 = False Then
            totalcost = totalcost + 99.99
            Label2.Text = totalcost.ToString("c2")
            c3 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 99.99
            End If
            Label2.Text = totalcost.ToString("c2")
            c3 = False

        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If p1 = False Then
            totalcost = totalcost + 695.04
            Label2.Text = totalcost.ToString("c2")
            p1 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 695.04
            End If
            Label2.Text = totalcost.ToString("c2")
            p1 = False

        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If p2 = False Then
            totalcost = totalcost + 574
            Label2.Text = totalcost.ToString("c2")
            p2 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 574
            End If
            Label2.Text = totalcost.ToString("c2")
            p2 = False

        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If p3 = False Then
            totalcost = totalcost + 599
            Label2.Text = totalcost.ToString("c2")
            p3 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 599
            End If
            Label2.Text = totalcost.ToString("c2")
            p3 = False

        End If
    End Sub



    Private Sub CLEARButton_Click(sender As Object, e As EventArgs) Handles CLEARButton.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If MB1 = False Then
            totalcost = totalcost + 962.99
            Label2.Text = totalcost.ToString("c2")
            MB1 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 962.99
            End If
            Label2.Text = totalcost.ToString("c2")
            MB1 = False

        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If MB2 = False Then
            totalcost = totalcost + 279.99
            Label2.Text = totalcost.ToString("c2")
            MB2 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 279.99
            End If
            Label2.Text = totalcost.ToString("c2")
            MB2 = False

        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If MB3 = False Then
            totalcost = totalcost + 199.99
            Label2.Text = totalcost.ToString("c2")
            MB3 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 199.99
            End If
            Label2.Text = totalcost.ToString("c2")
            MB3 = False

        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If GC1 = False Then
            totalcost = totalcost + 1649.99
            Label2.Text = totalcost.ToString("c2")
            GC1 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 1649.99
            End If
            Label2.Text = totalcost.ToString("c2")
            GC1 = False

        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If GC2 = False Then
            totalcost = totalcost + 839.99
            Label2.Text = totalcost.ToString("c2")
            GC2 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 839.99
            End If
            Label2.Text = totalcost.ToString("c2")
            GC2 = False

        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If GC3 = False Then
            totalcost = totalcost + 549.99
            Label2.Text = totalcost.ToString("c2")
            GC3 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 549.99
            End If
            Label2.Text = totalcost.ToString("c2")
            GC3 = False

        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If R1 = False Then
            totalcost = totalcost + 360
            Label2.Text = totalcost.ToString("c2")
            R1 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 360
            End If
            Label2.Text = totalcost.ToString("c2")
            R1 = False

        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If R2 = False Then
            totalcost = totalcost + 270
            Label2.Text = totalcost.ToString("c2")
            R2 = True

        Else
            If totalcost > 0 Then
                totalcost = totalcost - 270
            End If
            Label2.Text = totalcost.ToString("c2")
            R2 = False

        End If
    End Sub
End Class
