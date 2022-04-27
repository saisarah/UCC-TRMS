Public Class notification
    Private Sub notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private x, y As Integer

    Public Sub showAlert(ByVal msg As String, ByVal type As enmType)
        Me.Opacity = 0.0
        Me.StartPosition = FormStartPosition.Manual
        Dim fname As String

        For i As Integer = 1 To 10 - 1
            fname = "alert" & i.ToString()
            Dim frm As notification = CType(Application.OpenForms(fname), notification)

            If frm Is Nothing Then
                Me.Name = fname
                Me.x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                Me.y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(Me.x, Me.y)
                Exit For
            End If
        Next

        Me.x = Screen.PrimaryScreen.WorkingArea.Width - MyBase.Width - 5

        Select Case type
            Case enmType.Success
                Me.BackColor = Color.SeaGreen
            Case enmType.[Error]
                Me.BackColor = Color.DarkRed
            Case enmType.Info
                Me.BackColor = Color.RoyalBlue
            Case enmType.Warning
                Me.BackColor = Color.DarkOrange
        End Select

        Me.lblMsg.Text = msg
        Me.Show()
        Me.action = enmAction.start
        Me.timer1.Interval = 1
        Me.timer1.Start()
    End Sub
    Public Enum enmAction
        wait
        start
        close
    End Enum
    Public Enum enmType
        Success
        Warning
        [Error]
        Info
    End Enum

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case enmAction.wait
                Timer1.Interval = 3000
                action = enmAction.close
            Case enmAction.start
                Timer1.Interval = 1
                Opacity += 0.1
                If x < Me.Location.X Then
                    Left -= 1
                Else
                    If (Opacity = 1.0) Then
                        action = notification.enmAction.wait
                    End If
                End If
            Case enmAction.close
                Timer1.Interval = 10
                Me.Opacity -= 0.1
                Me.Left -= 3
                If MyBase.Opacity = 0.0 Then
                    Dispose()
                End If
        End Select
    End Sub

    Private action As notification.enmAction

End Class