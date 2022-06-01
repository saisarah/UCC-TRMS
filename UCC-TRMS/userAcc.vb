Imports MySql.Data.MySqlClient
Public Class usersAcc
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        addUsers.Label1.Text = "Add User"
        addUsers.btnUpdate.Enabled = False
        addUsers.BringToFront()
        addUsers.Show()
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim y As New MySqlCommand("SELECT * FROM tblusers", conn)
            Dim dr As MySqlDataReader
            Dim id, user, stat As String
            dr = y.ExecuteReader
            If dr.Read() Then
                id = dr(0)
                user = dr(1)
                stat = dr(1)

            End If
            Dim c As userSA = New userSA
            c.Dock = DockStyle.Top

            For i As Integer = 0 To 1000
                c.lblID.Text = id
                c.lblUsername.Text = user
                c.lblStat.Text = stat
                Panel1.Controls.Add(c)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgvUsers_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
        '   Dim colname As String = dgvUsers.Columns(e.ColumnIndex).Name

        If colname <> "Delete" AndAlso colname <> "Edit" Then
            '      dgvUsers.Cursor = Cursors.[Default]
        Else
            '       dgvUsers.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        conn.Open()
        Dim j As Integer
        Dim s As String
        '  j = dgvUsers.CurrentRow.Index
        ' s = dgvUsers.Item(3, j).Value.ToString()
        'Dim colName As String = dgvUsers.Columns(e.ColumnIndex).Name
        '  If colName = "Delete" Then

        '   ElseIf colName = "Edit" Then
        '    If dgvUsers.SelectedRows.Count > 0 Then
        '   Dim i As Integer
        '  i = dgvUsers.CurrentRow.Index
        ' Dim newForm As New addUsers
        '   newForm.SelectedRows = dgvUsers.SelectedRows
        '    newForm.tbName.Text = dgvUsers.Item(1, i).Value.ToString
        'newForm.Label1.Text = "Update User"
        '  newForm.btnSaveUser.Enabled = False
        '    newForm.Show()

        '        End If
        '       End If
        conn.Close()
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs)
        If e.Item.Selected = False Then
            e.DrawDefault = True
        End If
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs)
        If e.Item.Selected = True Then
            e.DrawDefault = False
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(252, 177, 45)), e.Bounds)
            Dim lvi As ListViewItem = New ListViewItem
            '   TextRenderer.DrawText(e.Graphics, e.SubItem.Text, New Font(ListView1.Font, Poppins), New Point(e.Bounds.Left + 0, e.Bounds.Top + 2), HighlightText)
        Else
            e.DrawDefault = True
        End If

    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs)
        e.DrawDefault = True
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        '   Dim sa As String = ListView1.SelectedItems(0).ToString().Substring(15).Replace("}", "")
        Dim newForm As New Confirmation
        newForm.BackColor = Color.DarkOrange
        newForm.PictureBox1.Image = My.Resources.Warning
        newForm.PictureBox2.Image = My.Resources.warning__2_
        newForm.btnNoCancel.Text = "Cancel"
        newForm.lblmsg.Text = "Are you sure you want to delete this record?"

        newForm.Label2.ForeColor = Color.FromArgb(255, 66, 66)
        newForm.btnYesOk.FillColor = Color.FromArgb(255, 66, 66)
        newForm.ctid = sa
        newForm.Show()

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub
End Class