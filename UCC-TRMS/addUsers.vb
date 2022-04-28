Imports MySql.Data.MySqlClient
Public Class addUsers
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub btnAddUserClose_Click(sender As Object, e As EventArgs) Handles btnAddUserClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveUser_Click(sender As Object, e As EventArgs) Handles btnSaveUser.Click
        Try
            conn.Open()
            Dim comm As New MySqlCommand("INSERT INTO tblusers(username) VALUES (@username)", conn)
            With comm
                .Parameters.AddWithValue("@username", tbName.Text.Substring(0, 1).ToUpper() + tbName.Text.Substring(1))

                .ExecuteNonQuery()
                conn.Close()
            End With
            With borrowers
                mainForm.OpenChildForm(New users)
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class