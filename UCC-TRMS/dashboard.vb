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
            conn.Open()

            Dim comm5 As New MySqlCommand("SELECT * FROM tblborroweddetails ORDER BY thesis_id DESC LIMIT 10", conn)
            dr = comm5.ExecuteReader
            While dr.Read
                Dim c As recentBorrowed = New recentBorrowed
                Dim a As Integer = 1
                c.Dock = DockStyle.Top
                For f As Integer = 0 To 1000
                    c.lblCode.Text = dr(0)
                    c.lblTitle.Text = dr(1)
                    c.lblDate.Text = dr(2)
                    c.lblBorrower.Text = dr(4)
                    Panel5.Controls.Add(c)


                Next

            End While
            lblBorrowers.Text = i
            lblThesisToday.Text = k
            lblInPosses.Text = l
            lblSent.Text = m
            dr.Close()

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class