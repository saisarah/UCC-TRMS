Imports MySql.Data.MySqlClient
Public Class addUsers
    Public Property SelectedRows As DataGridViewSelectedRowCollection
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub btnAddUserClose_Click(sender As Object, e As EventArgs) Handles btnAddUserClose.Click
        Me.Close()
    End Sub
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnSaveUser_Click(sender As Object, e As EventArgs) Handles btnSaveUser.Click
        conn.Open()
        Try
            Dim stat As String = "Active"
            Dim comm As New MySqlCommand("INSERT INTO tblusers(username, status) VALUES (@username, @status)", conn)
            With comm
                .Parameters.AddWithValue("@username", tbName.Text.Substring(0, 1).ToUpper() + tbName.Text.Substring(1))
                .Parameters.AddWithValue("@status", stat.ToUpper())
                .ExecuteNonQuery()
            End With
            With borrowers
                mainForm.OpenChildForm(New users)
            End With
            Me.Alert("New record added successfully!", notification.enmType.Success)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub
End Class