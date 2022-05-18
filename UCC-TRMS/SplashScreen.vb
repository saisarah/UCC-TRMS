Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.Width += 3
        If Panel1.Width >= 800 Then
            Timer1.Stop()
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class