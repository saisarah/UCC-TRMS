Imports MySql.Data.MySqlClient
Public Class borrowers
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Dim it As Integer
    Public Property SelectedRows As DataGridViewSelectedRowCollection

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        addStudent.Label1.Text = "Add Student"
        addStudent.btnUpdateStudent.Enabled = False
        addStudent.BringToFront()
        addStudent.Show()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        loadData()

    End Sub
    Private Sub loadData()
        Try

            conn.Open()
            If cbYear.SelectedIndex = -1 Then

                Dim x As String
                x = tbSearch.Text
                Dim da As New MySqlDataAdapter("SELECT studentno, fullname,  course, year, section, email FROM tblstudents WHERE year LIKE '%" & cbYear.Text & "%' AND fullname Like '%" & x & "%' Or studentno Like '%" & x & "%' OR studentno LIKE '%" & x & "%' OR email LIKE '%" & x & "%' OR course LIKE '%" & x & "%' OR year LIKE '%" & x & "%' OR section LIKE '%" & x & "%' OR contact LIKE '%" & x & "%'", conn)
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
                Dim da As New MySqlDataAdapter("SELECT studentno, fullname,  course, year, section, email FROM tblstudents WHERE year LIKE '%" & cbYear.Text & "%' AND fullname Like '%" & x & "%' Or studentno Like '%" & x & "%' OR studentno LIKE '%" & x & "%' OR email LIKE '%" & x & "%' OR course LIKE '%" & x & "%' OR year LIKE '%" & x & "%' OR section LIKE '%" & x & "%' OR contact LIKE '%" & x & "%'", conn)
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
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Public Sub Alert1(ByVal msg As String, ByVal type As Confirmation.enmType)
        Dim frm As Confirmation = New Confirmation()
        frm.showAlert(msg, type)
    End Sub
    Public Sub dgvStudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        conn.Open()
        Dim j As Integer
        Dim s As Integer
        '   j = dgvStudent.CurrentRow.Index
        '   s = dgvStudent.Item(3, j).Value.ToString()
        '     Dim colName As String = dgvStudent.Columns(e.ColumnIndex).Name
        If colName = "Delete" Then
            Dim newForm As New Confirmation
            '        newForm.SelectedRows = dgvStudent.SelectedRows
            newForm.BackColor = Color.DarkOrange
            newForm.PictureBox1.Image = My.Resources.Warning
            newForm.PictureBox2.Image = My.Resources.warning__2_
            newForm.btnNoCancel.Text = "Cancel"
            newForm.lblmsg.Text = "Are you sure you want to delete this record?"
            newForm.Label2.ForeColor = Color.FromArgb(255, 66, 66)
            newForm.btnYesOk.FillColor = Color.FromArgb(255, 66, 66)
            newForm.update1 = False
            newForm.deleteStud = True
            newForm.addTh = False
            newForm.deleteThesis = False
            newForm.Show()
        ElseIf colName = "Edit" Then

            '     If dgvStudent.SelectedRows.Count > 0 Then
            'Dim i As Integer
            'i = dgvStudent.CurrentRow.Index
            'Dim newForm As New addStudent
            'newForm.SelectedRows = dgvStudent.SelectedRows
            'newForm.tbfullname.Text = dgvStudent.Item(4, i).Value.ToString
            'newForm.tbstudentno.Text = dgvStudent.Item(3, i).Value.ToString
            'newForm.tbCourse.Text = dgvStudent.Item(5, i).Value.ToString
            'newForm.cbyear.Text = dgvStudent.Item(6, i).Value.ToString
            'newForm.cbSection.Text = dgvStudent.Item(7, i).Value.ToString
            'newForm.tbcontact.Text = dgvStudent.Item(8, i).Value.ToString
            'newForm.tbemail.Text = dgvStudent.Item(9, i).Value.ToString
            'newForm.tbstudentno.Enabled = False

            'newForm.Label1.Text = "Update Student"
            'newForm.btnSaveStudent.Enabled = False
            'newForm.Show()

            '        End If

        End If
        conn.Close()
    End Sub

    Private Sub btnArchived_Click(sender As Object, e As EventArgs) Handles btnArchived.Click
        studentArchive.Show()
    End Sub

    Private Sub dgvStudent_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs)
        If e.RowIndex >= 0 Then
            '   Me.dgvStudent.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub cbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYear.SelectedIndexChanged
        loadData()
        conn.Open()
        Dim x As String
        x = tbSearch.Text
        Dim da As New MySqlDataAdapter("SELECT studentno, fullname,  course, year, section, email FROM tblstudents WHERE year LIKE '%" & cbYear.Text & "%'", conn)
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

    Private Sub borrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        If e.Item.Selected = False Then
            e.DrawDefault = True
        End If
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
        e.DrawDefault = True
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

            Dim cm As New MySqlCommand("SELECT * FROM tblstudents WHERE studentno = '" & sa & "'", conn)
            dr = cm.ExecuteReader
            Dim fn, sn, cr, yrs, se, eme, con As String
            If dr.read() Then
                fn = dr(1)
                sn = dr(2)
                cr = dr(4)
                yrs = dr(5)
                se = dr(6)
                eme = dr(3)
                con = dr(7)

                fullname.Text = fn
                studentno.Text = sn
                course.Text = cr
                year.Text = yrs
                section.Text = se
                email.Text = eme
                contact.Text = con

            End If

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim sa As String = ListView1.SelectedItems(0).ToString().Substring(15).Replace("}", "")
        Dim newForm As New Confirmation
        newForm.BackColor = Color.DarkOrange
        newForm.PictureBox1.Image = My.Resources.Warning
        newForm.PictureBox2.Image = My.Resources.warning__2_
        newForm.btnNoCancel.Text = "Cancel"
        newForm.lblmsg.Text = "Are you sure you want to delete this record?"
        newForm.Label2.ForeColor = Color.FromArgb(255, 66, 66)
        newForm.btnYesOk.FillColor = Color.FromArgb(255, 66, 66)
        newForm.update1 = False
        newForm.deleteStud = True
        newForm.addTh = False
        newForm.deleteThesis = False
        newForm.id = sa
        newForm.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim sa As String = ListView1.SelectedItems(0).ToString().Substring(15).Replace("}", "")
        conn.Open()
        Try
            Dim cm As New MySqlCommand("SELECT * FROM tblstudents WHERE studentno = '" & sa & "'", conn)
            dr = cm.ExecuteReader
            Dim fn, sn, cr, yrs, se, eme, con As String
            If dr.read() Then
                fn = dr(1)
                sn = dr(2)
                cr = dr(4)
                yrs = dr(5)
                se = dr(6)
                eme = dr(3)
                con = dr(7)

                Dim newForm As New addStudent
                newForm.tbfullname.Text = fn
                newForm.tbCourse.Text = cr
                newForm.tbstudentno.Text = sn
                newForm.cbyear.Text = yrs
                newForm.cbSection.Text = se
                newForm.tbemail.Text = eme
                newForm.tbcontact.Text = con
                newForm.Label1.Text = "Update Student"
                newForm.btnSaveStudent.Enabled = False
                newForm.tbstudentno.Enabled = False
                newForm.stdId = sa
                newForm.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()


    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        ContextMenuStrip1.Show(Cursor.Position)
    End Sub
End Class