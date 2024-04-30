Class MainWindow
    Private Sub drawingcanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingcanvas.MouseMove
        Dim el As New Ellipse
        el.Width = widthslider.Value
        el.Height = heightslider.Value
        el.Fill = colorrectangle1.Fill
        Dim p As Point = Mouse.GetPosition(drawingcanvas)
        Canvas.SetLeft(el, p.X)
        Canvas.SetTop(el, p.Y)
        If e.LeftButton = MouseButtonState.Pressed Then
            drawingcanvas.Children.Add(el)
        End If
    End Sub

    Private Sub colorectangle2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles colorrectangle2.MouseDown, colorrectangle3.MouseDown, colorrectangle4.MouseDown, colorrectangle5.MouseDown
        colorrectangle1.Fill = sender.fill

    End Sub
End Class
