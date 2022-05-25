Imports MySql.Data.MySqlClient
Public Class thesis
    Public Property SelectedRows As DataGridViewSelectedRowCollection
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Dim it As Integer
    Public s1 As Boolean
    Private Sub btnAddThesis_Click(sender As Object, e As EventArgs) Handles btnAddThesis.Click
        addThesis.Label1.Text = "Add Thesis"
        addThesis.btnUpdate.Enabled = False
        addThesis.BringToFront()
        addThesis.Show()
    End Sub
    Sub LoadRecords()
        Try
            '  dgvThesis.Rows.Clear()
            cbCategories.SelectedIndex = 0
            conn.Open()
            Dim cm As New MySqlCommand("SELECT * FROM tblthesis", conn)
            dr = cm.ExecuteReader
            While dr.Read
                '      dgvThesis.Rows.Add(dr.Item("thesis_id").ToString, dr.Item("title").ToString, dr.Item("objectives").ToString, dr.Item("scope").ToString, dr.Item("limitations").ToString, dr.Item("teamname").ToString, dr.Item("members").ToString, dr.Item("panels").ToString, dr.Item("category").ToString)
            End While
            dr.close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub thesis_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        loadData()


    End Sub
    Private Sub loadData()
        Try

            conn.Open()
            If cbCategories.SelectedIndex = -1 Then

                Dim x As String
                x = tbSearch.Text
                Dim da As New MySqlDataAdapter("SELECT thesis_id, title, objectives, scope, limitations, category FROM tblthesis WHERE category LIKE '%" & cbCategories.Text & "%' AND title Like '%" & x & "%' OR objectives LIKE '%" & x & "%' OR scope LIKE '%" & x & "%' OR limitations LIKE '%" & x & "%' OR teamname LIKE '%" & x & "%' OR members LIKE '%" & x & "%' OR panels LIKE '%" & x & "%' OR category LIKE '%" & x & "%' ", conn)
                Dim dt = New DataTable
                da.Fill(dt)
                Dim lvItem As New ListViewItem
                Dim dr2 As DataRow
                ListView1.Items.Clear()

                For Each dr2 In dt.Rows

                    lvItem = Me.ListView1.Items.Add(dr2(0).ToString())
                    For s As Integer = 1 To 5
                        lvItem.SubItems.Add(dr2(s).ToString())

                    Next
                Next
                For Each lvi As ListViewItem In Me.ListView1.Items
                    lvi.UseItemStyleForSubItems = False
                    lvi.SubItems(0).ForeColor = Color.Gray
                    lvi.SubItems(1).ForeColor = Color.Gray
                    lvi.SubItems(2).ForeColor = Color.Gray
                    lvi.SubItems(3).ForeColor = Color.Gray
                    lvi.SubItems(4).ForeColor = Color.Gray
                    lvi.SubItems(5).ForeColor = Color.Gray
                Next

            Else
                    Dim x As String
                    x = tbSearch.Text
                    Dim da As New MySqlDataAdapter("SELECT thesis_id, title, objectives, scope, limitations, category FROM tblthesis WHERE title Like '%" & x & "%' OR objectives LIKE '%" & x & "%' OR scope LIKE '%" & x & "%' OR limitations LIKE '%" & x & "%' OR teamname LIKE '%" & x & "%' OR members LIKE '%" & x & "%' OR panels LIKE '%" & x & "%' OR category LIKE '%" & x & "%' ", conn)
                    Dim dt = New DataTable
                    da.Fill(dt)
                    Dim lvItem As New ListViewItem
                    Dim dr2 As DataRow
                    ListView1.Items.Clear()

                    For Each dr2 In dt.Rows

                        lvItem = Me.ListView1.Items.Add(dr2(0).ToString())
                        For s As Integer = 1 To 5
                            lvItem.SubItems.Add(dr2(s).ToString())

                        Next
                    Next
                    For Each lvi As ListViewItem In Me.ListView1.Items
                        lvi.UseItemStyleForSubItems = False
                        lvi.SubItems(0).ForeColor = Color.Gray
                        lvi.SubItems(1).ForeColor = Color.Gray
                        lvi.SubItems(2).ForeColor = Color.Gray
                        lvi.SubItems(3).ForeColor = Color.Gray
                        lvi.SubItems(4).ForeColor = Color.Gray
                        lvi.SubItems(5).ForeColor = Color.Gray


                    Next
                End If


        Catch ex As Exception
        End Try
        conn.Close()

    End Sub


    Private Sub cbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategories.SelectedIndexChanged
        loadData()
        conn.Open()
        Dim x As String
        x = tbSearch.Text
        Dim da As New MySqlDataAdapter("SELECT thesis_id, title, objectives, scope, limitations, category FROM tblthesis WHERE category LIKE '%" & cbCategories.Text & "%' ", conn)
        Dim dt = New DataTable
        da.Fill(dt)
        Dim lvItem As New ListViewItem
        Dim dr2 As DataRow
        ListView1.Items.Clear()

        For Each dr2 In dt.Rows

            lvItem = Me.ListView1.Items.Add(dr2(0).ToString())
            For s As Integer = 1 To 5
                lvItem.SubItems.Add(dr2(s).ToString())

            Next
        Next
        For Each lvi As ListViewItem In Me.ListView1.Items
            lvi.UseItemStyleForSubItems = False
            lvi.SubItems(0).ForeColor = Color.Gray
            lvi.SubItems(1).ForeColor = Color.Gray
            lvi.SubItems(2).ForeColor = Color.Gray
            lvi.SubItems(3).ForeColor = Color.Gray
            lvi.SubItems(4).ForeColor = Color.Gray
            lvi.SubItems(5).ForeColor = Color.Gray
        Next
        conn.Close()
    End Sub

    Private Sub dgvThesis_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
        '   Dim colname As String = dgvThesis.Columns(e.ColumnIndex).Name

        ' If colname <> "Delete" AndAlso colname <> "Edit" Then
        '       dgvThesis.Cursor = Cursors.[Default]
        '  Else
        '       dgvThesis.Cursor = Cursors.Hand
        '   End If
    End Sub

    Private Sub btnArchived_Click(sender As Object, e As EventArgs) Handles btnArchived.Click
        thesisArchived.Show()
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
        e.DrawDefault = True

    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        If e.Item.Selected = False Then
            e.DrawDefault = True
        End If
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        If e.Item.Selected = True Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(76, 71, 67)), e.Bounds)
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, New Font(ListView1.Font, Poppins), New Point(e.Bounds.Left + 0, e.Bounds.Top + 2), HighlightText)

        Else
            e.DrawDefault = True
        End If

    End Sub


    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        Dim sa As String = ListView1.SelectedItems(0).ToString().Substring(15).Replace("}", "")

        Try
            conn.Open()

            Dim cm As New MySqlCommand("SELECT * FROM tblthesis WHERE thesis_id = '" & sa & "'", conn)
            dr = cm.ExecuteReader
            Dim ttl, obj, sc, li, te, ca As String
            If dr.read() Then
                ttl = dr(1)
                obj = dr(2)
                sc = dr(3)
                li = dr(4)
                te = dr(5)
                ca = dr(8)
                lblTitle.Text = ttl
                lblObjectives.Text = obj
                lblScope.Text = sc
                lblLimit.Text = li
                lblTeam.Text = te
                lblCategory.Text = ca


            End If

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        ContextMenuStrip1.Show(Cursor.Position)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim sa As String = ListView1.SelectedItems(0).ToString().Substring(15).Replace("}", "")
        Dim newForm As New Confirmation
        newForm.BackColor = Color.DarkOrange
        newForm.PictureBox1.Image = My.Resources.Warning
        newForm.PictureBox2.Image = My.Resources.warning__2_
        newForm.btnNoCancel.Text = "Cancel"
        newForm.lblmsg.Text = "Are you sure you want to delete this record?"
        newForm.update1 = False
        newForm.deleteStud = False
        newForm.addTh = False
        newForm.deleteThesis = True
        newForm.Label2.ForeColor = Color.FromArgb(255, 66, 66)
        newForm.btnYesOk.FillColor = Color.FromArgb(255, 66, 66)
        newForm.ctid = sa
        newForm.Show()

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim sa As String = ListView1.SelectedItems(0).ToString().Substring(15).Replace("}", "")
        conn.Open()
        Try
            Dim cm As New MySqlCommand("SELECT * FROM tblthesis WHERE thesis_id = '" & sa & "'", conn)
            dr = cm.ExecuteReader
            Dim ttl, obj, sc, li, te, mem, pa, ca As String
            If dr.read() Then
                ttl = dr(1)
                obj = dr(2)
                sc = dr(3)
                li = dr(4)
                te = dr(5)
                mem = dr(6)
                pa = dr(7)
                ca = dr(8)
                Dim newForm As New addThesis
                newForm.tbTitle.Text = ttl
                newForm.tbObjectives.Text = obj
                newForm.tbScope.Text = sc
                newForm.tbLimitation.Text = li
                newForm.cbCategory.Text = ca
                newForm.tbTeam.Text = te
                newForm.tbMembers.Text = mem
                newForm.tbPanel.Text = pa
                newForm.Label1.Text = "Update Thesis"
                newForm.btnSaveThesis.Enabled = False
                newForm.sel = sa
                newForm.Show()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class