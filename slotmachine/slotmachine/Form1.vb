Public Class Form1
    Dim moneyamount As Decimal
    Dim cs As New coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = True

        If moneyamount >= 5 Then
            moneyamount = moneyamount - 5
            Reelcontrol1.spin()
            Reelcontrol2.spin()
            Reelcontrol3.spin()
            Label1.Text = Nothing
            Label2.Text = Nothing
            Label3.Text = Nothing
        End If
        Button2.Visible = False
        MoneyamountLabel.Text = moneyamount.ToString("c2")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MoneyamountLabel.Text = moneyamount.ToString("c2")
        Button2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.Text And Label2.Text = 0 And Label2.Text And Label3.Text = 0 Then
            moneyamount = moneyamount + 10

        End If
        If Label1.Text And Label2.Text = 1 And Label2.Text And Label3.Text = 1 Then
            moneyamount = moneyamount + 20
        End If
        If Label1.Text And Label2.Text = 2 And Label2.Text And Label3.Text = 2 Then
            moneyamount = moneyamount + 50
        End If
        If Label1.Text And Label2.Text = 3 And Label2.Text And Label3.Text = 3 Then
            moneyamount = moneyamount + 140

        End If
        If Label1.Text And Label2.Text = 4 And Label2.Text And Label3.Text = 4 Then
            moneyamount = moneyamount + 260
        End If
        If Label1.Text And Label2.Text = 5 And Label2.Text And Label3.Text = 5 Then
            moneyamount = moneyamount + 400
        End If


        MoneyamountLabel.Text = cs.total.ToString("c2")
        Button2.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = Reelcontrol1.itemvalue
        Label2.Text = Reelcontrol2.itemvalue
        Label3.Text = Reelcontrol3.itemvalue
        Button2.Visible = True
    End Sub





    Private Sub dollarPictureBoxbutton_Click_1(sender As Object, e As EventArgs) Handles dollarPictureBoxbutton.Click
        cs.insertdollar()
        moneyamount = moneyamount + 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertquarter()
        moneyamount = moneyamount + 0.25
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoneyamountLabel.Text = moneyamount.ToString("c2")
    End Sub


End Class
