Imports MySql.Data.MySqlClient
Public Class dashboard
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            Dim comm As New MySqlCommand("SELECT COUNT(*) FROM tblstudents", conn)
            Dim comm2 As New MySqlCommand("SELECT COUNT(*) FROM tblthesis", conn)

            Dim i As Integer = comm.ExecuteScalar()
            Dim k As Integer = comm2.ExecuteScalar()

            conn.Close()
            lblBorrowers.Text = i
            lblThesisToday.Text = k

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class