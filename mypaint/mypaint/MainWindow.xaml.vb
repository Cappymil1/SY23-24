Class MainWindow
    Private Sub drawingcanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingcanvas.MouseMove
        If shapelabel.Content = "ellipse" Then
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
        End If
        If shapelabel.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = widthslider.Value
            el.Height = heightslider.Value
            el.Fill = colorrectangle1.Fill
            Dim p As Point = Mouse.GetPosition(drawingcanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                drawingcanvas.Children.Add(el)
            End If
        End If

    End Sub

    Private Sub colorectangle2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles colorrectangle2.MouseDown, colorrectangle3.MouseDown, colorrectangle4.MouseDown, colorrectangle5.MouseDown
        colorrectangle1.Fill = sender.fill

    End Sub

    Private Sub clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles clearbutton.Click
        drawingcanvas.Children.RemoveRange(1, drawingcanvas.Children.Count)
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        drawingcanvas.Children.RemoveAt(drawingcanvas.Children.Count - 1)

    End Sub

    Private Sub rectbutton_Click(sender As Object, e As RoutedEventArgs) Handles rectbutton.Click, elipsebutton.Click
        shapelabel.Content = sender.content

    End Sub
End Class
