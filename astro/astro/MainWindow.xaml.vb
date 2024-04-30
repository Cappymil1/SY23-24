Imports System.Security.Policy

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim d As Integer
        Dim m As Integer
        m = cal1.SelectedDate.Value.Month
        d = cal1.SelectedDate.Value.Day
        If m = 3 And d > 20 Or m = 4 And d < 20 Then
            label1.Content = "Aries"
            ariespic.Visibility = Visibility.Visible
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 4 And d > 19 Or m = 5 And d < 21 Then
            label1.Content = "Taurus"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Visible
        End If
        If m = 5 And d > 20 Or m = 6 And d < 21 Then
            label1.Content = "Gemini"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Visible
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 6 And d > 20 Or m = 7 And d < 23 Then
            label1.Content = "Cancer"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Visible
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 7 And d > 22 Or m = 8 And d < 23 Then
            label1.Content = "Leo"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Visible
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 8 And d > 22 Or m = 9 And d < 23 Then
            label1.Content = "Virgo"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Visible
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 9 And d > 22 Or m = 10 And d < 23 Then
            label1.Content = "Libra"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Visible
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 10 And d > 22 Or m = 11 And d < 22 Then
            label1.Content = "Scorpio"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Visible
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 11 And d > 22 Or m = 12 And d < 20 Then
            label1.Content = "Sagittarius"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Visible
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 12 And d > 21 Or m = 1 And d < 20 Then
            label1.Content = "Capricorn"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Visible
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 1 And d > 19 Or m = 2 And d < 19 Then
            label1.Content = "Aquarius"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Visible
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Collapsed
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If
        If m = 2 And d > 18 Or m = 3 And d < 21 Then
            label1.Content = "Pisces"
            ariespic.Visibility = Visibility.Collapsed
            aquapic.Visibility = Visibility.Collapsed
            cappic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
            sagpic.Visibility = Visibility.Collapsed
            leopic.Visibility = Visibility.Collapsed
            scorpiopic.Visibility = Visibility.Collapsed
            virgopic.Visibility = Visibility.Collapsed
            gempic.Visibility = Visibility.Collapsed
            piscespic.Visibility = Visibility.Visible
            librapic.Visibility = Visibility.Collapsed
            tau_pic.Visibility = Visibility.Collapsed
        End If

    End Sub
End Class
