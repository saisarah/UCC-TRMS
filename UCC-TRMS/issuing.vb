Imports MySql.Data.MySqlClient
Public Class issuing
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")

    Private Sub issuing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvThesis.Rows.Clear()
            conn.Open()
            Dim cm As New MySqlCommand("SELECT * FROM tblthesis", conn)
            dr = cm.ExecuteReader
            While dr.Read

                dgvThesis.Rows.Add(dr.Item("id").ToString, dr.Item("title").ToString, dr.Item("objectives").ToString, dr.Item("scope").ToString, dr.Item("limitations").ToString, dr.Item("teamname").ToString, dr.Item("members").ToString, dr.Item("panels").ToString, dr.Item("category").ToString)
            End While
            dr.close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbSearchThesis_TextChanged(sender As Object, e As EventArgs) Handles tbSearchThesis.TextChanged
        Try
            conn.Open()
            Dim x As String
            x = tbSearchThesis.Text
            Dim y As New MySqlCommand("SELECT * FROM tblthesis WHERE id LIKE '%" & x & "%' OR title LIKE '%" & x & "%' OR objectives LIKE '%" & x & "%' OR scope LIKE '%" & x & "%' OR limitations LIKE '%" & x & "%' OR teamname LIKE '%" & x & "%' OR members LIKE '%" & x & "%' OR panels LIKE '%" & x & "%' OR category LIKE '%" & x & "%'", conn)
            y.ExecuteNonQuery()
            Dim da1 As New MySqlDataAdapter(y)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            dgvThesis.DataSource = dt1
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        Try
            conn.Open()
            Dim x As String
            x = cbCategory.Text
            Dim y As New MySqlCommand("SELECT * FROM tblthesis WHERE category ='" & x & "'", conn)
            y.ExecuteNonQuery()
            Dim da1 As New MySqlDataAdapter(y)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            dgvThesis.DataSource = dt1
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class