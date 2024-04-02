Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        costlabel.Text = Module1.totalcost
        totalaftertax.Text = Module1.totalcost * 1.133 / 100.ToString("c2")
    End Sub

End Class