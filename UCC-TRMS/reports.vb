Imports MySql.Data.MySqlClient
Public Class reports
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        EasyHTMLReports1.AddControl(Panel2)
        EasyHTMLReports1.ShowPrintPreviewDialog()

    End Sub

    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prntDate.Text = Date.Now.ToString("dd/MM/yyyy")
        dtpFrom.Value = Date.Today.AddDays(-3)
        dtpTo.Value = Date.Today
        lblFrom.Text = dtpFrom.Value.ToString("dd/MM/yyyy")
        lblTo.Text = dtpTo.Value.ToString("dd/MM/yyyy")


        Try
            conn.Open()

            Dim comm As New MySqlCommand("SELECT COUNT(*) FROM tblstudents", conn)
            Dim comm2 As New MySqlCommand("SELECT COUNT(*) FROM tblthesis", conn)

            Dim i As Integer = comm.ExecuteScalar()
            Dim k As Integer = comm2.ExecuteScalar()

            conn.Close()
            lblNoStudent.Text = i
            lblNoThesis.Text = k

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearchDate_Click(sender As Object, e As EventArgs) Handles btnSearchDate.Click
        lblFrom.Text = dtpFrom.Value.ToString("dd/MM/yyyy")
        lblTo.Text = dtpTo.Value.ToString("dd/MM/yyyy")

    End Sub
End Class