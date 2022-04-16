Imports MySql.Data.MySqlClient
Public Class studentArchive
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")

    Private Sub studentArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvStudentArchived.Rows.Clear()
            conn.Open()
            Dim cm As New MySqlCommand("SELECT * FROM tblarchivedstud", conn)
            dr = cm.ExecuteReader
            While dr.Read

                dgvStudentArchived.Rows.Add(dr.Item("id").ToString, dr.Item("fullname").ToString, dr.Item("studentno").ToString, dr.Item("email").ToString, dr.Item("course").ToString, dr.Item("year").ToString, dr.Item("section").ToString, dr.Item("contact").ToString)
            End While
            dr.close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStudentArchivedClose_Click(sender As Object, e As EventArgs) Handles btnStudentArchivedClose.Click
        Me.Close()
    End Sub
End Class