Imports MySql.Data.MySqlClient

Public Class login
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Dim cmdd As New MySqlCommand


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cm As New MySqlCommand("SELECT username FROM tblusers", conn)
            Dim dr As MySqlDataReader
            conn.Open()

            dr = cm.ExecuteReader
            While dr.Read
                cbCredentials.Items.Add(dr.Item("username"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

        Me.MaximumSize = Screen.FromRectangle(Me.DesktopBounds).WorkingArea.Size
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cbCredentials.Text <> "" Then
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT `username` FROM `tblusers` WHERE `username` = '" & cbCredentials.Text & "' "
            cmdd = New MySqlCommand(sql, conn)
            reader = cmdd.ExecuteReader
            mainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnCloseLogin_Click_1(sender As Object, e As EventArgs) Handles btnCloseLogin.Click
        Application.Exit()
    End Sub

    Private Sub btnMazimized_Click(sender As Object, e As EventArgs) Handles btnMazimized.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
End Class