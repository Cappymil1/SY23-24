Imports Microsoft.Win32
Imports System.IO

Class MainWindow
    Dim grad1 As Color
    Dim grad2 As Color
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
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(drawingcanvas, 570)

        Canvas.SetTop(drawingcanvas, 434)

    End Sub

    Private Sub Savebutton_Click(sender As Object, e As RoutedEventArgs) Handles Savebutton.Click
        ExportToPng(drawingcanvas)
    End Sub

    Private Sub colorone_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles colorone.MouseDown
        grad1 = Color.FromRgb(R.Value, G.Value, B.Value)
        sender.fill = New SolidColorBrush(grad1)
    End Sub

    Private Sub colortwo_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles colortwo.MouseDown
        grad2 = Color.FromRgb(R.Value, G.Value, B.Value)
        sender.fill = New SolidColorBrush(grad2)
    End Sub

    Private Sub anglesilder_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleslider.ValueChanged
        colorrectangle1.Fill = New LinearGradientBrush(grad1, grad2, angleslider.Value)
    End Sub
End Class
