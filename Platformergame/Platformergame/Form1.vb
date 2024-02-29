Public Class Form2dplatformer

    Dim movespeed As Integer = 15
    Dim isjumping As Boolean
    Private Sub Form2dplatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TMRright.Start()
            Case Keys.Left
                TMRleft.Start()
            Case Keys.Up
                TMRUp.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub TMRright_Tick(sender As Object, e As EventArgs) Handles TMRright.Tick
        Picplayer.Left += movespeed
    End Sub

    Private Sub Form2dplatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TMRright.Stop()
            Case Keys.Left
                TMRleft.Stop()
            Case Keys.Up
                TMRUp.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub TMRleft_Tick(sender As Object, e As EventArgs) Handles TMRleft.Tick
        Picplayer.Left -= movespeed
    End Sub

    Private Sub TMRUp_Tick(sender As Object, e As EventArgs) Handles TMRUp.Tick
        Picplayer.Top -= movespeed
    End Sub

    Private Sub Form2dplatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timergamelogic.Start()

    End Sub

    Private Sub Timergamelogic_Tick(sender As Object, e As EventArgs) Handles Timergamelogic.Tick
        If Picplayer.Bounds.IntersectsWith(Picair.Bounds) Then
            If isjumping = False Then
                Timergravity.Start()
            End If
        ElseIf Picplayer.Bounds.IntersectsWith(Picground.Bounds) Then
            Timergravity.Stop()
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        Timergravity.Stop()
                    End If
                End If
            End If
        Next


    End Sub

    Private Sub Timergravity_Tick(sender As Object, e As EventArgs) Handles Timergravity.Tick
        Picplayer.Top += movespeed
    End Sub
End Class
