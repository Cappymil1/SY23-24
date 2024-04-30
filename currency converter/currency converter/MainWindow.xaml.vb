Class MainWindow
    Dim convertcode As Integer = 0
    Dim desiredamount As String
    Dim eurochecked As Boolean = False
    Dim pesochecked As Boolean = False
    Dim adchecked As Boolean = False
    Dim cdchecked As Boolean = False
    Dim yenchecked As Boolean = False
    Dim poundchecked As Boolean = False

    Private Sub euro_Checked(sender As Object, e As RoutedEventArgs) Handles euro.Checked
        If eurochecked = False Then
            eurochecked = True
            convertcode = 1
            europic.Visibility = Visibility.Visible
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        Else
            eurochecked = False
            convertcode = 0
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        End If
    End Sub

    Private Sub pesos_Checked(sender As Object, e As RoutedEventArgs) Handles pesos.Checked
        If pesochecked = False Then
            pesochecked = True
            convertcode = 2
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Visible
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        Else
            pesochecked = False
            convertcode = 0
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        End If
    End Sub

    Private Sub yen_Checked(sender As Object, e As RoutedEventArgs) Handles yen.Checked
        If yenchecked = False Then
            yenchecked = True
            convertcode = 3
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Visible
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        Else
            yenchecked = False
            convertcode = 0
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        End If
    End Sub

    Private Sub pound_Checked(sender As Object, e As RoutedEventArgs) Handles pound.Checked
        If poundchecked = False Then
            poundchecked = True
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Visible
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
            convertcode = 4
        Else
            poundchecked = False
            convertcode = 0
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        End If
    End Sub

    Private Sub ad_Checked(sender As Object, e As RoutedEventArgs) Handles ad.Checked
        If adchecked = False Then
            adchecked = True
            convertcode = 5
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Visible
            cdpic.Visibility = Visibility.Collapsed
        Else
            adchecked = False
            convertcode = 0
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        End If
    End Sub

    Private Sub cd_Checked(sender As Object, e As RoutedEventArgs) Handles cd.Checked
        If cdchecked = False Then
            cdchecked = True
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Visible
            convertcode = 6
        Else
            cdchecked = False
            convertcode = 0
            europic.Visibility = Visibility.Collapsed
            yenpic.Visibility = Visibility.Collapsed
            pesopic.Visibility = Visibility.Collapsed
            poundpic.Visibility = Visibility.Collapsed
            adpic.Visibility = Visibility.Collapsed
            cdpic.Visibility = Visibility.Collapsed
        End If
    End Sub

    Private Sub convertbutton_Click(sender As Object, e As RoutedEventArgs) Handles convertbutton.Click

        If convertcode = 1 Then
                convertedtextbox.Text = desiredamount * 0.93.ToString("c2")
            End If
            If convertcode = 2 Then
            convertedtextbox.Text = desiredamount * 17.07.ToString("c2")
        End If
            If convertcode = 3 Then
            convertedtextbox.Text = desiredamount * 155.36.ToString("c2")
        End If
            If convertcode = 4 Then
            convertedtextbox.Text = desiredamount * 0.8.ToString("c2")
        End If
            If convertcode = 5 Then
            convertedtextbox.Text = desiredamount * 1.54.ToString("c2")
        End If
            If convertcode = 6 Then
            convertedtextbox.Text = desiredamount * 1.37.ToString("c2")
        End If

    End Sub

    Private Sub usdollartextbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles usdollartextbox.TextChanged
        If Not convertbutton Is Nothing Then
            If usdollartextbox.Text Like "##.##" Then
                convertbutton.IsEnabled = True
                desiredamount = usdollartextbox.Text
            Else
                convertbutton.IsEnabled = False
            End If
        End If

    End Sub

    Private Sub clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles clearbutton.Click
        usdollartextbox.Text = Nothing
        convertedtextbox.Text = Nothing
    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded


    End Sub
End Class
