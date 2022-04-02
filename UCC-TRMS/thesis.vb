Imports MySql.Data.MySqlClient

Public Class thesis
    Public Property SelectedRows As DataGridViewSelectedRowCollection

    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Dim it As Integer
    Private Sub btnAddThesis_Click(sender As Object, e As EventArgs) Handles btnAddThesis.Click
        addThesis.Label1.Text = "Add Thesis"
        addThesis.btnUpdate.Enabled = False
        addThesis.BringToFront()
        addThesis.Show()
    End Sub
    Sub LoadRecords()

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

    Private Sub dgvThesis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThesis.CellClick
        Try
            If e.RowIndex > -1 Then
                dgvThesis.Rows(e.RowIndex).Selected = True
            End If

            Dim j As Integer
            Dim s As String
            j = dgvThesis.CurrentRow.Index
            s = dgvThesis.Item(2, j).Value.ToString()
            it = dgvThesis.CurrentRow.Index
            Dim i As Integer
            i = dgvThesis.CurrentRow.Index
            lblTitle.Text = dgvThesis.Item(3, i).Value.ToString
            lblScope.Text = dgvThesis.Item(5, i).Value.ToString
            lblLimit.Text = dgvThesis.Item(6, i).Value.ToString
            lblCategory.Text = dgvThesis.Item(10, i).Value.ToString
            lblObjectives.Text = dgvThesis.Item(4, i).Value.ToString
            lblTeam.Text = dgvThesis.Item(7, i).Value.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub thesis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Try
            conn.Open()
            Dim x As String
            x = tbSearch.Text
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

    Private Sub cbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategories.SelectedIndexChanged
        Try
            conn.Open()
            Dim x As String
            x = cbCategories.Text
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

    Private Sub dgvThesis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThesis.CellContentClick
        conn.Open()
        Dim j As Integer
        Dim s As String
        j = dgvThesis.CurrentRow.Index
        s = dgvThesis.Item(2, j).Value.ToString()
        Dim colName As String = dgvThesis.Columns(e.ColumnIndex).Name
        If colName = "Delete" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Dim command As New MySqlCommand("INSERT INTO tblarchive (id, title, objectives, scope, limitations, teamname, members, panels, category) SELECT id, title, objectives, scope, limitations, teamname, members, panels, category FROM tblthesis WHERE id ='" & s & "'", conn)
                command.ExecuteNonQuery()

                Dim command1 As New MySqlCommand("DELETE FROM tblthesis WHERE id ='" & s & "'", conn)
                command1.ExecuteNonQuery()
                mainForm.OpenChildForm(New thesis)

                If result = DialogResult.No Then
                    Me.Hide()
                End If
            End If
        ElseIf colName = "Edit" Then

            If dgvThesis.SelectedRows.Count > 0 Then
                Dim i As Integer
                i = dgvThesis.CurrentRow.Index
                Dim newForm As New addThesis
                newForm.SelectedRows = dgvThesis.SelectedRows
                newForm.tbTitle.Text = dgvThesis.Item(3, i).Value.ToString
                newForm.tbObjectives.Text = dgvThesis.Item(4, i).Value.ToString
                newForm.tbScope.Text = dgvThesis.Item(5, i).Value.ToString
                newForm.tbLimitation.Text = dgvThesis.Item(6, i).Value.ToString
                newForm.tbTeam.Text = dgvThesis.Item(7, i).Value.ToString
                newForm.tbMembers.Text = dgvThesis.Item(8, i).Value.ToString
                newForm.tbPanel.Text = dgvThesis.Item(9, i).Value.ToString
                newForm.cbCategory.Text = dgvThesis.Item(10, i).Value.ToString

                newForm.Label1.Text = "Update Thesis"
                newForm.btnSaveThesis.Enabled = False
                newForm.Show()

            End If

        End If


        conn.Close()
    End Sub

    Private Sub dgvThesis_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThesis.CellMouseEnter
        Dim colname As String = dgvThesis.Columns(e.ColumnIndex).Name

        If colname <> "Delete" AndAlso colname <> "Edit" Then
            dgvThesis.Cursor = Cursors.[Default]
        Else
            dgvThesis.Cursor = Cursors.Hand
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
End Class