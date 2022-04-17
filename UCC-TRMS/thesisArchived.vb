Imports MySql.Data.MySqlClient

Public Class thesisArchived
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub thesisArchived_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvThesisArchived.Rows.Clear()
            conn.Open()
            Dim cm As New MySqlCommand("SELECT * FROM tblArchive", conn)
            dr = cm.ExecuteReader
            While dr.Read

                dgvThesisArchived.Rows.Add(dr.Item("id").ToString, dr.Item("title").ToString, dr.Item("objectives").ToString, dr.Item("scope").ToString, dr.Item("limitations").ToString, dr.Item("teamname").ToString, dr.Item("members").ToString, dr.Item("panels").ToString, dr.Item("category").ToString)
            End While
            dr.close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnArchivedClose_Click(sender As Object, e As EventArgs) Handles btnArchivedClose.Click
        Me.Close()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub dgvThesisArchived_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThesisArchived.CellContentClick

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class