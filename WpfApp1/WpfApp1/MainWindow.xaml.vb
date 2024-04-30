Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        label1.Content = "hello world"
    End Sub

    Private Sub ccnum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles ccnum.TextChanged
        If Not paybutton Is Nothing Then
            If ccnum.Text Like "################" Then

                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub cvvnum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles cvvnum.TextChanged
        If Not paybutton Is Nothing Then
            If cvvnum.Text Like "####" Then

                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub cardholdername_TextChanged(sender As Object, e As TextChangedEventArgs) Handles cardholdername.TextChanged
        If Not paybutton Is Nothing Then
            If cardholdername.Text Like "*" Then

                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub emailtext_TextChanged(sender As Object, e As TextChangedEventArgs) Handles emailtext.TextChanged
        If Not paybutton Is Nothing Then
            If emailtext.Text Like "*@*.*" Then

                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub expdate_TextChanged(sender As Object, e As TextChangedEventArgs) Handles expdate.TextChanged
        If Not paybutton Is Nothing Then
            If expdate.Text Like "##/##" Then

                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub phonenum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles phonenum.TextChanged
        If Not paybutton Is Nothing Then
            If phonenum.Text Like "###-###-####" Then

                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        phonenum.Text = Nothing
        expdate.Text = Nothing
        emailtext.Text = Nothing
        cardholdername.Text = Nothing
        ccnum.Text = Nothing
        cvvnum.Text = Nothing
    End Sub
End Class
