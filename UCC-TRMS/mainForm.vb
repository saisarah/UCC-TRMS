Public Class mainForm

    Private currentChildForm As Form
    Private btnDashboardWasClicked As Boolean = False
    Private btnThesisWasClicked As Boolean = False
    Private btnBorrowersWasClicked As Boolean = False
    Private btnIssuingWasClicked As Boolean = False
    Private btnReportsWasClicked As Boolean = False
    Private btnUsersWasClicked As Boolean = False





    Public Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlBody.Controls.Add(childForm)
        pnlBody.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        btnDashboardWasClicked = True
        OpenChildForm(New dashboard)
        If btnDashboardWasClicked = True Then
            btnThesisWasClicked = False
            btnBorrowersWasClicked = False
            btnIssuingWasClicked = False
            btnReportsWasClicked = False
            btnUsersWasClicked = False
            btnDashboard.FillColor = Color.FromArgb(204, 96, 63)
            btnDashboard.FillColor2 = Color.FromArgb(204, 96, 63)
            btnDashboard.HoverState.FillColor = Color.FromArgb(204, 96, 63)
            btnDashboard.HoverState.FillColor2 = Color.FromArgb(204, 96, 63)
            btnDashboard.PressedColor = Color.FromArgb(204, 96, 63)
            btnDashboard.Cursor = DefaultCursor

            If btnBorrowersWasClicked = False And btnThesisWasClicked = False And btnIssuingWasClicked = False And btnReportsWasClicked = False And btnUsersWasClicked = False Then
                btnBorrowers.FillColor = Color.Transparent
                btnBorrowers.FillColor2 = Color.Transparent
                btnThesis.FillColor = Color.Transparent
                btnThesis.FillColor2 = Color.Transparent
                btnIssuing.FillColor = Color.Transparent
                btnIssuing.FillColor2 = Color.Transparent
                btnReports.FillColor = Color.Transparent
                btnReports.FillColor2 = Color.Transparent
                btnUsers.FillColor = Color.Transparent
                btnUsers.FillColor2 = Color.Transparent
                btnThesis.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
            End If
        End If
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.DesktopBounds).WorkingArea.Size
        Me.WindowState = FormWindowState.Maximized
        OpenChildForm(New dashboard)
        btnDashboardWasClicked = True
        If btnDashboardWasClicked = True Then
            btnThesisWasClicked = False
            btnBorrowersWasClicked = False
            btnIssuingWasClicked = False
            btnReportsWasClicked = False
            btnUsersWasClicked = False
            btnDashboard.FillColor = Color.FromArgb(204, 96, 63)
            btnDashboard.FillColor2 = Color.FromArgb(204, 96, 63)
            btnDashboard.HoverState.FillColor = Color.FromArgb(204, 96, 63)
            btnDashboard.HoverState.FillColor2 = Color.FromArgb(204, 96, 63)
            btnDashboard.PressedColor = Color.FromArgb(204, 96, 63)
            btnDashboard.Cursor = DefaultCursor

            If btnBorrowersWasClicked = False And btnThesisWasClicked = False And btnIssuingWasClicked = False And btnReportsWasClicked = False And btnUsersWasClicked = False Then
                btnBorrowers.FillColor = Color.Transparent
                btnBorrowers.FillColor2 = Color.Transparent
                btnThesis.FillColor = Color.Transparent
                btnThesis.FillColor2 = Color.Transparent
                btnIssuing.FillColor = Color.Transparent
                btnIssuing.FillColor2 = Color.Transparent
                btnReports.FillColor = Color.Transparent
                btnReports.FillColor2 = Color.Transparent
                btnUsers.FillColor = Color.Transparent
                btnUsers.FillColor2 = Color.Transparent
                btnThesis.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
            End If
        End If
    End Sub

    Private Sub btnThesis_Click(sender As Object, e As EventArgs) Handles btnThesis.Click
        OpenChildForm(New thesis)
        btnThesisWasClicked = True

        If btnThesisWasClicked = True Then
            btnDashboardWasClicked = False
            btnBorrowersWasClicked = False
            btnIssuingWasClicked = False
            btnReportsWasClicked = False
            btnUsersWasClicked = False
            btnThesis.FillColor = Color.FromArgb(204, 96, 63)
            btnThesis.FillColor2 = Color.FromArgb(204, 96, 63)
            btnThesis.HoverState.FillColor = Color.FromArgb(204, 96, 63)
            btnThesis.HoverState.FillColor2 = Color.FromArgb(204, 96, 63)
            btnThesis.PressedColor = Color.FromArgb(204, 96, 63)
            btnThesis.Cursor = DefaultCursor

            If btnBorrowersWasClicked = False And btnDashboardWasClicked = False And btnIssuingWasClicked = False And btnReportsWasClicked = False And btnUsersWasClicked = False Then
                btnBorrowers.FillColor = Color.Transparent
                btnBorrowers.FillColor2 = Color.Transparent
                btnDashboard.FillColor = Color.Transparent
                btnDashboard.FillColor2 = Color.Transparent
                btnIssuing.FillColor = Color.Transparent
                btnIssuing.FillColor2 = Color.Transparent
                btnReports.FillColor = Color.Transparent
                btnReports.FillColor2 = Color.Transparent
                btnUsers.FillColor = Color.Transparent
                btnUsers.FillColor2 = Color.Transparent
                btnDashboard.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnDashboard.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)


            End If
        End If
    End Sub

    Private Sub btnBorrowers_Click(sender As Object, e As EventArgs) Handles btnBorrowers.Click
        OpenChildForm(New borrowers)
        btnBorrowersWasClicked = True

        If btnBorrowersWasClicked = True Then
            btnDashboardWasClicked = False
            btnIssuingWasClicked = False
            btnThesisWasClicked = False
            btnReportsWasClicked = False
            btnUsersWasClicked = False
            btnBorrowers.FillColor = Color.FromArgb(204, 96, 63)
            btnBorrowers.FillColor2 = Color.FromArgb(204, 96, 63)
            btnBorrowers.HoverState.FillColor = Color.FromArgb(204, 96, 63)
            btnBorrowers.HoverState.FillColor2 = Color.FromArgb(204, 96, 63)
            btnBorrowers.PressedColor = Color.FromArgb(204, 96, 63)
            btnBorrowers.Cursor = DefaultCursor

            If btnIssuingWasClicked = False And btnDashboardWasClicked = False And btnThesisWasClicked = False And btnReportsWasClicked = False And btnUsersWasClicked = False Then
                btnIssuing.FillColor = Color.Transparent
                btnIssuing.FillColor2 = Color.Transparent
                btnDashboard.FillColor = Color.Transparent
                btnDashboard.FillColor2 = Color.Transparent
                btnThesis.FillColor = Color.Transparent
                btnThesis.FillColor2 = Color.Transparent
                btnReports.FillColor = Color.Transparent
                btnReports.FillColor2 = Color.Transparent
                btnUsers.FillColor = Color.Transparent
                btnUsers.FillColor2 = Color.Transparent
                btnDashboard.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnDashboard.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
            End If
        End If
    End Sub

    Private Sub btnIssuing_Click(sender As Object, e As EventArgs) Handles btnIssuing.Click
        OpenChildForm(New issuing)
        btnIssuingWasClicked = True

        If btnIssuingWasClicked = True Then
            btnDashboardWasClicked = False
            btnBorrowersWasClicked = False
            btnThesisWasClicked = False
            btnReportsWasClicked = False
            btnUsersWasClicked = False
            btnIssuing.FillColor = Color.FromArgb(204, 96, 63)
            btnIssuing.FillColor2 = Color.FromArgb(204, 96, 63)
            btnIssuing.HoverState.FillColor = Color.FromArgb(204, 96, 63)
            btnIssuing.HoverState.FillColor2 = Color.FromArgb(204, 96, 63)
            btnIssuing.PressedColor = Color.FromArgb(204, 96, 63)
            btnIssuing.Cursor = DefaultCursor

            If btnBorrowersWasClicked = False And btnDashboardWasClicked = False And btnThesisWasClicked = False And btnReportsWasClicked = False And btnUsersWasClicked = False Then
                btnBorrowers.FillColor = Color.Transparent
                btnBorrowers.FillColor2 = Color.Transparent
                btnDashboard.FillColor = Color.Transparent
                btnDashboard.FillColor2 = Color.Transparent
                btnThesis.FillColor = Color.Transparent
                btnThesis.FillColor2 = Color.Transparent
                btnReports.FillColor = Color.Transparent
                btnReports.FillColor2 = Color.Transparent
                btnUsers.FillColor = Color.Transparent
                btnUsers.FillColor2 = Color.Transparent
                btnDashboard.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnDashboard.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
            End If
        End If
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        OpenChildForm(New reports)
        btnReportsWasClicked = True

        If btnReportsWasClicked = True Then
            btnDashboardWasClicked = False
            btnBorrowersWasClicked = False
            btnThesisWasClicked = False
            btnIssuingWasClicked = False
            btnUsersWasClicked = False
            btnReports.FillColor = Color.FromArgb(204, 96, 63)
            btnReports.FillColor2 = Color.FromArgb(204, 96, 63)
            btnReports.HoverState.FillColor = Color.FromArgb(204, 96, 63)
            btnReports.HoverState.FillColor2 = Color.FromArgb(204, 96, 63)
            btnReports.PressedColor = Color.FromArgb(204, 96, 63)
            btnReports.Cursor = DefaultCursor

            If btnBorrowersWasClicked = False And btnDashboardWasClicked = False And btnThesisWasClicked = False And btnIssuingWasClicked = False And btnUsersWasClicked = False Then
                btnBorrowers.FillColor = Color.Transparent
                btnBorrowers.FillColor2 = Color.Transparent
                btnDashboard.FillColor = Color.Transparent
                btnDashboard.FillColor2 = Color.Transparent
                btnThesis.FillColor = Color.Transparent
                btnThesis.FillColor2 = Color.Transparent
                btnIssuing.FillColor = Color.Transparent
                btnIssuing.FillColor2 = Color.Transparent
                btnUsers.FillColor = Color.Transparent
                btnUsers.FillColor2 = Color.Transparent
                btnDashboard.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnDashboard.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnUsers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
            End If
        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        OpenChildForm(New users)
        btnUsersWasClicked = True

        If btnUsersWasClicked = True Then
            btnDashboardWasClicked = False
            btnBorrowersWasClicked = False
            btnThesisWasClicked = False
            btnIssuingWasClicked = False
            btnReportsWasClicked = False
            btnUsers.FillColor = Color.FromArgb(204, 96, 63)
            btnUsers.FillColor2 = Color.FromArgb(204, 96, 63)
            btnUsers.HoverState.FillColor = Color.FromArgb(204, 96, 63)
            btnUsers.HoverState.FillColor2 = Color.FromArgb(204, 96, 63)
            btnUsers.PressedColor = Color.FromArgb(204, 96, 63)
            btnUsers.Cursor = DefaultCursor

            If btnBorrowersWasClicked = False And btnDashboardWasClicked = False And btnThesisWasClicked = False And btnIssuingWasClicked = False And btnReportsWasClicked = False Then
                btnBorrowers.FillColor = Color.Transparent
                btnBorrowers.FillColor2 = Color.Transparent
                btnDashboard.FillColor = Color.Transparent
                btnDashboard.FillColor2 = Color.Transparent
                btnThesis.FillColor = Color.Transparent
                btnThesis.FillColor2 = Color.Transparent
                btnIssuing.FillColor = Color.Transparent
                btnIssuing.FillColor2 = Color.Transparent
                btnReports.FillColor = Color.Transparent
                btnReports.FillColor2 = Color.Transparent
                btnDashboard.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnDashboard.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnThesis.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnIssuing.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnBorrowers.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor = Color.FromArgb(64, 64, 64)
                btnReports.HoverState.FillColor2 = Color.FromArgb(64, 64, 64)
            End If
        End If
    End Sub
End Class
