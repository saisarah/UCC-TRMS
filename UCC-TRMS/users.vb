Imports MySql.Data.MySqlClient
Public Class users
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        addUsers.Label1.Text = "Add User"
        addUsers.btnUpdate.Enabled = False
        addUsers.BringToFront()
        addUsers.Show()
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvUsers.Rows.Clear()
            conn.Open()
            Dim cm As New MySqlCommand("SELECT * FROM tblusers", conn)
            dr = cm.ExecuteReader
            While dr.Read
                dgvUsers.Rows.Add(dr.Item("ID").ToString, dr.Item("username").ToString)
            End While

            dr.close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvUsers_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvUsers.RowPrePaint
        If e.RowIndex >= 0 Then
            Me.dgvUsers.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub dgvUsers_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellMouseEnter
        Dim colname As String = dgvUsers.Columns(e.ColumnIndex).Name

        If colname <> "Delete" AndAlso colname <> "Edit" Then
            dgvUsers.Cursor = Cursors.[Default]
        Else
            dgvUsers.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        conn.Open()
        Dim j As Integer
        Dim s As String
        j = dgvUsers.CurrentRow.Index
        s = dgvUsers.Item(2, j).Value.ToString()
        Dim colName As String = dgvUsers.Columns(e.ColumnIndex).Name
        If colName = "Delete" Then

        ElseIf colName = "Edit" Then
            If dgvUsers.SelectedRows.Count > 0 Then

            End If
        End If
        conn.Close()
    End Sub
End Class