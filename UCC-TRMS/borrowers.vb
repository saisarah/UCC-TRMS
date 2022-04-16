Imports MySql.Data.MySqlClient

Public Class borrowers
    Public Property SelectedRows As DataGridViewSelectedRowCollection

    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Dim it As Integer

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        addStudent.Label1.Text = "Add Student"
        addStudent.btnUpdateStudent.Enabled = False
        addStudent.BringToFront()
        addStudent.Show()
    End Sub

    Sub LoadRecords()

        Try
            dgvStudent.Rows.Clear()
            conn.Open()
            Dim cm As New MySqlCommand("SELECT * FROM tblstudents", conn)
            dr = cm.ExecuteReader
            While dr.Read

                dgvStudent.Rows.Add(dr.Item("id").ToString, dr.Item("fullname").ToString, dr.Item("studentno").ToString, dr.Item("course").ToString, dr.Item("year").ToString, dr.Item("section").ToString, dr.Item("contact").ToString, dr.Item("email").ToString)
            End While
            dr.close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Try
            conn.Open()
            Dim x As String
            x = tbSearch.Text
            Dim y As New MySqlCommand("SELECT * FROM tblstudents WHERE id LIKE '%" & x & "%' OR fullname LIKE '%" & x & "%' OR studentno LIKE '%" & x & "%' OR course LIKE '%" & x & "%' OR year LIKE '%" & x & "%' OR section LIKE '%" & x & "%' OR contact LIKE '%" & x & "%' OR email LIKE '%" & x & "%'", conn)
            y.ExecuteNonQuery()
            Dim da1 As New MySqlDataAdapter(y)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            dgvStudent.DataSource = dt1
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellClick
        Try
            If e.RowIndex > -1 Then
                dgvStudent.Rows(e.RowIndex).Selected = True
            End If

            Dim j As Integer
            Dim s As String
            j = dgvStudent.CurrentRow.Index
            s = dgvStudent.Item(2, j).Value.ToString()
            it = dgvStudent.CurrentRow.Index
            Dim i As Integer
            i = dgvStudent.CurrentRow.Index
            fullname.Text = dgvStudent.Item(3, i).Value.ToString
            studentno.Text = dgvStudent.Item(4, i).Value.ToString
            course.Text = dgvStudent.Item(6, i).Value.ToString
            year.Text = dgvStudent.Item(7, i).Value.ToString
            section.Text = dgvStudent.Item(8, i).Value.ToString
            contact.Text = dgvStudent.Item(9, i).Value.ToString
            email.Text = dgvStudent.Item(5, i).Value.ToString

        Catch ex As Exception

        End Try
    End Sub
    Private Sub borrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub

    Private Sub cbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategories.SelectedIndexChanged
        Try
            conn.Open()
            Dim x As String
            x = cbCategories.Text
            Dim y As New MySqlCommand("SELECT * FROM tblstudents WHERE category ='" & x & "'", conn)
            y.ExecuteNonQuery()
            Dim da1 As New MySqlDataAdapter(y)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            dgvStudent.DataSource = dt1
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvStudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellContentClick
        conn.Open()
        Dim j As Integer
        Dim s As String
        j = dgvStudent.CurrentRow.Index
        s = dgvStudent.Item(2, j).Value.ToString()
        Dim colName As String = dgvStudent.Columns(e.ColumnIndex).Name
        If colName = "Delete" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Dim command As New MySqlCommand("INSERT INTO tblarchivedstud (id, fullname, studentno, email, course, year, section, contact) SELECT id, fullname, studentno, email, course, year, section, contact FROM tblstudents WHERE id ='" & s & "'", conn)
                command.ExecuteNonQuery()

                Dim command1 As New MySqlCommand("DELETE FROM tblstudents WHERE id ='" & s & "'", conn)
                command1.ExecuteNonQuery()
                mainForm.OpenChildForm(New borrowers)

                If result = DialogResult.No Then
                    Me.Hide()
                End If
            End If
        ElseIf colName = "Edit" Then

            If dgvStudent.SelectedRows.Count > 0 Then
                Dim i As Integer
                i = dgvStudent.CurrentRow.Index
                Dim newForm As New addStudent
                newForm.SelectedRows = dgvStudent.SelectedRows
                newForm.tbfullname.Text = dgvStudent.Item(3, i).Value.ToString
                newForm.tbstudentno.Text = dgvStudent.Item(4, i).Value.ToString
                newForm.tbemail.Text = dgvStudent.Item(5, i).Value.ToString
                newForm.tbcourse.Text = dgvStudent.Item(6, i).Value.ToString
                newForm.cbyear.Text = dgvStudent.Item(7, i).Value.ToString
                newForm.tbsection.Text = dgvStudent.Item(8, i).Value.ToString
                newForm.tbcontact.Text = dgvStudent.Item(9, i).Value.ToString

                newForm.Label1.Text = "Update Student"
                newForm.btnSaveStudent.Enabled = False
                newForm.Show()

            End If

        End If


        conn.Close()
    End Sub
    Private Sub dgvStudent_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudent.CellMouseEnter
        Dim colname As String = dgvStudent.Columns(e.ColumnIndex).Name

        If colname <> "Delete" AndAlso colname <> "Edit" Then
            dgvStudent.Cursor = Cursors.[Default]
        Else
            dgvStudent.Cursor = Cursors.Hand
        End If
    End Sub
    Private Sub sizeDGV(ByVal dgv As DataGridView)
        Dim states As DataGridViewElementStates = DataGridViewElementStates.None
        dgv.ScrollBars = ScrollBars.None
        Dim totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight
        totalHeight += dgv.Rows.Count * 4
        Dim totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth
        dgv.ClientSize = New Size(totalWidth, totalHeight)
    End Sub

    Private Sub btnArchived_Click(sender As Object, e As EventArgs) Handles btnArchived.Click
        studentArchive.Show()
    End Sub
End Class