Public Class Frm2dplatformer
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean

    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Tmrright.Start()
            Case Keys.Left
                Tmrleft.Start()
            Case Keys.Up
                Tmrup.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As System.Object, e As System.EventArgs) Handles Tmrright.Tick
        Picplayer.Left += moveSpeed
    End Sub

    Private Sub frm2DPlatformer_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                Tmrright.Stop()
            Case Keys.Left
                Tmrleft.Stop()
            Case Keys.Up
                Tmrup.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As System.Object, e As System.EventArgs) Handles Tmrleft.Tick
        Picplayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As System.Object, e As System.EventArgs) Handles Tmrup.Tick
        Picplayer.Top -= moveSpeed
    End Sub

    Private Sub frm2DPlatformer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGameLogic.Tick
        If Picplayer.Bounds.IntersectsWith(Picground.Bounds) Then
            Tmrgravity.Stop()
        Else
            If isJumping = False Then
                Tmrgravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        Tmrgravity.Stop()
                    End If
                End If
                If b.Tag = "restart" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        Picplayer.Location = New Point(12, 288)
                        Tmrgravity.Stop()
                    End If
                End If
                If b.Tag = "collectable" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False

                    End If
                End If
            End If
        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As System.Object, e As System.EventArgs) Handles Tmrgravity.Tick
        Picplayer.Top += moveSpeed
    End Sub
End Class


