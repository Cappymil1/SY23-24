Public Class productcontrol
    Public Property productID As String
    Public Property productPrice As Decimal
    Public Property productpicture As Image
    Public Property count As Integer

    Private Sub productcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLabel.Text = productID
        pricelabel.Text = productPrice.ToString("c2")
        PictureBox1.Image = productpicture
        inventorylabel.Text = count
    End Sub

    Sub buy()

        If count > 0 Then
            count = count - 1
        End If

        If count = 0 Then
            PictureBox1.Image = Nothing

        End If
        inventorylabel.Text = count
    End Sub
End Class
