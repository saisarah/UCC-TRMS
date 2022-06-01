Imports MySql.Data.MySqlClient
Public Class dashboard
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            Dim comm As New MySqlCommand("SELECT COUNT(*) FROM tblstudents", conn)
            Dim comm2 As New MySqlCommand("SELECT COUNT(*) FROM tblthesis", conn)
            Dim comm3 As New MySqlCommand("SELECT COUNT(*) FROM tblborroweddetails WHERE status ='IN POSSESION'", conn)
            Dim comm4 As New MySqlCommand("SELECT COUNT(*) FROM tblborroweddetails WHERE status ='SENT'", conn)
            Dim i As Integer = comm.ExecuteScalar()
            Dim k As Integer = comm2.ExecuteScalar()
            Dim l As Integer = comm3.ExecuteScalar()
            Dim m As Integer = comm4.ExecuteScalar()

            conn.Close()
            lblBorrowers.Text = i
            lblThesisToday.Text = k
            lblInPosses.Text = l
            lblSent.Text = m

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class