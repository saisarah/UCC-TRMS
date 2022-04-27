Imports MySql.Data.MySqlClient
Public Class issuing
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")

    Private Sub issuing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub
    Sub LoadRecords()
        Try
            dgvThesis.Rows.Clear()
            conn.Open()
            Dim y As New MySqlCommand("SELECT `title`, `objectives`, `scope`, `limitations`, `teamname`, `members`, `panels`, `category` FROM tblthesis", conn)
            y.ExecuteNonQuery()
            Dim da1 As New MySqlDataAdapter(y)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            dgvThesis.DataSource = dt1
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub tbSearchThesis_TextChanged(sender As Object, e As EventArgs) Handles tbSearchThesis.TextChanged
        Try
            Dim x As String
            x = tbSearchThesis.Text
            Dim y As New MySqlCommand("SELECT `title`, `objectives`, `scope`, `limitations`, `teamname`, `members`, `panels`, `category` FROM tblthesis WHERE id LIKE '%" & x & "%' OR title LIKE '%" & x & "%' OR objectives LIKE '%" & x & "%' OR scope LIKE '%" & x & "%' OR limitations LIKE '%" & x & "%' OR teamname LIKE '%" & x & "%' OR members LIKE '%" & x & "%' OR panels LIKE '%" & x & "%' OR category LIKE '%" & x & "%'", conn)
            y.ExecuteNonQuery()
            Dim da1 As New MySqlDataAdapter(y)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            dgvThesis.DataSource = dt1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        Try
            conn.Open()
            Dim x As String
            x = cbCategory.Text
            Dim y As New MySqlCommand("SELECT `title`, `objectives`, `scope`, `limitations`, `teamname`, `members`, `panels`, `category` FROM tblthesis WHERE category ='" & x & "'", conn)
            y.ExecuteNonQuery()
            Dim da1 As New MySqlDataAdapter(y)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            dgvThesis.DataSource = dt1
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub
    Sub clear()
        lblSN.Text = ""
        lblFN.Text = ""
        lblCYS.Text = ""
        lblEm.Text = ""
        lblCN.Text = ""

    End Sub
    Private Sub btnSearchStud_Click(sender As Object, e As EventArgs) Handles btnSearchStud.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT fullname, studentno, course, year, section, contact, email FROM tblstudents WHERE studentno = '" & tbSearchStudNo.Text & "'", conn)

            Dim da As New MySqlDataAdapter
            Dim dt As New DataTable()
            Dim crs, yr As String
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 And cmd.ExecuteNonQuery Then

                crs = dt.Rows(0).Item(3)
                yr = dt.Rows(0).Item(4)

                lblSN.Text = dt.Rows(0).Item(1)
                lblFN.Text = dt.Rows(0).Item(0)
                lblCYS.Text = dt.Rows(0).Item(2) + " " + crs + yr
                lblEm.Text = dt.Rows(0).Item(6)
                lblCN.Text = dt.Rows(0).Item(5)
            Else
                clear()
                MessageBox.Show("STUDENT NUMBER NOT FOUND", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            conn.close()
        Catch ex As Exception

        End Try



    End Sub
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Me.Alert("Sample Notification", notification.enmType.Success)
    End Sub
End Class