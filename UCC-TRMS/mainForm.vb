﻿Imports MySql.Data.MySqlClient

Public Class mainForm
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Public Property SelectedRows As DataGridViewSelectedRowCollection

    Private currentChildForm As Form
    Private btnDashboardWasClicked As Boolean = False
    Private btnThesisWasClicked As Boolean = False
    Private btnBorrowersWasClicked As Boolean = False
    Private btnIssuingWasClicked As Boolean = False
    Private btnReportsWasClicked As Boolean = False
    Private btnUsersWasClicked As Boolean = False
    Dim cur, cur2 As String


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
        Label1.Text = "Dashboard"
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
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim sql As String
            sql = "SELECT `username` FROM `tblusers` WHERE `Username` = '" & login.cbCredentials.Text & "' "
            cmdd = New MySqlCommand(sql, conn)
            reader = cmdd.ExecuteReader
            While reader.Read
                lblUser.Text = reader(0)
            End While
            If lblUser.Text <> "Admin" Then
                btnUsers.ForeColor = Color.FromArgb(150, 150, 150)
                btnUsers.Image = My.Resources.user__2_
                btnUsers.Enabled = False
            End If
            Me.Alert("Welcome back, " + login.cbCredentials.Text + "!", notification.enmType.welcome)
            reader.Close()
        Catch ex As Exception


        End Try


        Me.MaximumSize = Screen.FromRectangle(Me.DesktopBounds).WorkingArea.Size
        Me.WindowState = FormWindowState.Maximized
        OpenChildForm(New dashboard)
        Label1.Text = "Dashboard"

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
        thesis.cbCategories.SelectedIndex = -1
        thesis.tbSearch.Clear()

        btnThesisWasClicked = True
        Label1.Text = "Thesis"

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
        Label1.Text = "Borrowers"

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
        Label1.Text = "Issuing"

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
        Label1.Text = "Reports"

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
        OpenChildForm(New usersAcc)
        btnUsersWasClicked = True
        Label1.Text = "Users"

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim CurrentDateTime As DateTime
        CurrentDateTime = DateTime.Now
        Label3.Text = CurrentDateTime.ToString("dddd, d MMMM yyyy  |  hh:mm:ss tt")


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        login.Show()
    End Sub

End Class
