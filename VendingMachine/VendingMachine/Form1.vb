Public Class Form1
    Dim WithEvents cs As New coinslot

    Private Sub NickelButton_Click(sender As Object, e As EventArgs) Handles NickelButton.Click
        cs.insertnickel()
        totalLabel.Text = cs.total.ToString("c2")

    End Sub

    Private Sub DimeButton_Click(sender As Object, e As EventArgs) Handles DimeButton.Click
        cs.insertdime()
        totalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub QuarterButton_Click(sender As Object, e As EventArgs) Handles QuarterButton.Click
        cs.insertquarter()
        totalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub DollarButton_Click(sender As Object, e As EventArgs) Handles DollarButton.Click
        cs.insertdollar()
        totalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub coinreturnbutton_Click(sender As Object, e As EventArgs) Handles coinreturnbutton.Click
        cs.coinreturn()
        totalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent

        If d > 0 Then
            dollarpb.Visible = True
        Else
            dollarpb.Visible = False
        End If

        If q > 0 Then
            quarterpb.Visible = True
        Else
            quarterpb.Visible = False
        End If


        If di > 0 Then
            dimepb.Visible = True
        Else
            dimepb.Visible = False
        End If


        If n > 0 Then
            nickelpb.Visible = True
        Else
            nickelpb.Visible = False
        End If

    End Sub

    Private Sub buyButton_Click(sender As Object, e As EventArgs) Handles buyButton.Click
        Select Case idtextbox.Text
            Case Productcontrol1.productID
                cs.buy(Productcontrol1)

            Case Productcontrol2.productID
                cs.buy(Productcontrol2)

            Case Productcontrol3.productID
                cs.buy(Productcontrol3)

            Case Productcontrol4.productID
                cs.buy(Productcontrol4)

            Case Productcontrol5.productID
                cs.buy(Productcontrol5)

            Case Productcontrol6.productID
                cs.buy(Productcontrol6)

            Case Productcontrol7.productID
                cs.buy(Productcontrol7)

            Case Productcontrol8.productID
                cs.buy(Productcontrol8)

            Case Productcontrol9.productID
                cs.buy(Productcontrol9)

            Case Productcontrol10.productID
                cs.buy(Productcontrol10)

            Case Productcontrol11.productID
                cs.buy(Productcontrol11)


            Case Productcontrol12.productID
                cs.buy(Productcontrol12)

            Case Productcontrol13.productID
                cs.buy(Productcontrol13)

            Case Productcontrol14.productID
                cs.buy(Productcontrol14)

            Case Productcontrol15.productID
                cs.buy(Productcontrol15)

            Case Productcontrol16.productID
                cs.buy(Productcontrol16)





        End Select
        totalLabel.Text = cs.total.ToString("c2")



    End Sub

    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        ProductPictureBox.Image = p
    End Sub


End Class
