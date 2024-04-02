Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        costlabel.Text = Module1.totalcost.ToString("c2")
        totalaftertax.Text = Module1.totalcost + Module1.totalcost * 10 / 100.ToString("c2")

    End Sub

End Class