Imports MySql.Data.MySqlClient
Public Class issuing
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")

    Private Sub loadData()

        Try
            Dim CurrentDateTime As DateTime
            CurrentDateTime = DateTime.Now
            Guna2DateTimePicker1.Value = CurrentDateTime
            conn.Open()
            If cbCategory.SelectedIndex = -1 Then

                Dim x As String
                x = tbSearchThesis.Text
                Dim da As New MySqlDataAdapter("SELECT thesis_id, title, objectives, scope, limitations, category FROM tblthesis WHERE category LIKE '%" & cbCategory.Text & "%' AND title Like '%" & x & "%' OR objectives LIKE '%" & x & "%' OR scope LIKE '%" & x & "%' OR limitations LIKE '%" & x & "%' OR teamname LIKE '%" & x & "%' OR members LIKE '%" & x & "%' OR panels LIKE '%" & x & "%' OR category LIKE '%" & x & "%' ", conn)
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
                x = tbSearchThesis.Text
                Dim da As New MySqlDataAdapter("SELECT thesis_id, title, objectives, scope, limitations, category FROM tblthesis WHERE category LIKE '%" & cbCategory.Text & "%' Or title Like '%" & x & "%' OR objectives LIKE '%" & x & "%' OR scope LIKE '%" & x & "%' OR limitations LIKE '%" & x & "%' OR teamname LIKE '%" & x & "%' OR members LIKE '%" & x & "%' OR panels LIKE '%" & x & "%' OR category LIKE '%" & x & "%' ", conn)
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
    Private Sub issuing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCnt()
        loadData()

    End Sub

    Private Sub tbSearchThesis_TextChanged(sender As Object, e As EventArgs) Handles tbSearchThesis.TextChanged

        loadData()
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        loadData()
        conn.Open()
        Dim x As String
        x = tbSearchThesis.Text
        Dim da As New MySqlDataAdapter("SELECT thesis_id, title, objectives, scope, limitations, category FROM tblthesis WHERE category LIKE '%" & cbCategory.Text & "%' ", conn)
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
    Sub clear()
        lblSN.Text = ""
        lblFN.Text = ""
        lblCYS.Text = ""
        lblEm.Text = ""
        lblCN.Text = ""
        lblBorrowed.Text = "0"

    End Sub
    Private Sub btnSearchStud_Click(sender As Object, e As EventArgs) Handles btnSearchStud.Click

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT fullname, studentno, course, year, section, contact, email FROM tblstudents WHERE studentno = '" & tbSearchStudNo.Text & "'", conn)

            Dim da As New MySqlDataAdapter
            Dim dt As New DataTable()
            Dim crs, yr As String
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 And cmd.ExecuteNonQuery Then
                crs = dt.Rows(0).Item(3)
                yr = dt.Rows(0).Item(4)
                lblSN.Text = dt.Rows(0).Item(1)
                lblFN.Text = dt.Rows(0).Item(0)
                lblCYS.Text = dt.Rows(0).Item(2) + " " + crs + yr
                lblEm.Text = dt.Rows(0).Item(6)
                lblCN.Text = dt.Rows(0).Item(5)
                loadCnt()
            Else
                Me.Alert1("Student number not found!", Confirmation.enmType.Info)
                clear()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub loadCnt()
        Timer1.Start()

        Try
            If lblSN.Text = "" Then
                lblBorrowed.Text = 0
            Else
                Dim snt As Integer = 0
                Dim cmd1 As New MySqlCommand("SELECT count(*) FROM tblborroweddetails WHERE studno = '" & tbSearchStudNo.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'IN POSSESION'", conn)
                ttl = cmd1.ExecuteScalar()
                Dim cmd2 As New MySqlCommand("SELECT count(*) FROM tblborroweddetails WHERE studno = '" & tbSearchStudNo.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'SENT'", conn)
                snt = cmd2.ExecuteScalar()
                lblBorrowed.Text = ttl + snt
                Dim cmd3 As New MySqlCommand("SELECT count(*) FROM tblborroweddetails WHERE studno = '" & tbSearchStudNo.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'OVERDUE'", conn)
                due = cmd3.ExecuteScalar()
                lblOverDue.Text = due
                Dim cmd4 As New MySqlCommand("SELECT count(*) FROM tblborroweddetails WHERE studno = '" & tbSearchStudNo.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'CLEARED'", conn)
                cleared = cmd4.ExecuteScalar()
                lblCleared.Text = cleared
                Dim cmd5 As New MySqlCommand("SELECT count(*) FROM tblborroweddetails WHERE studno = '" & tbSearchStudNo.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'PENDING'", conn)
                pending = cmd5.ExecuteScalar()
                lblPending.Text = pending

            End If

        Catch ex As Exception

        End Try

    End Sub
    Public Sub Alert1(ByVal msg As String, ByVal type As Confirmation.enmType)
        Dim frm As Confirmation = New Confirmation()
        frm.showAlert(msg, type)
    End Sub
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Try
            If cbHoS.SelectedIndex <> -1 Then
                conn.Open()
                Dim sele As String = cbHoS.SelectedIndex
                Dim cmd As New MySqlCommand("SELECT * FROM tblthesis WHERE thesis_id = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'", conn)
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable()
                da.SelectCommand = cmd
                da.Fill(dt)
                Dim CurrentDateTime As DateTime
                CurrentDateTime = DateTime.Now
                If ListView1.SelectedItems.Count > 0 And dt.Rows.Count > 0 And cmd.ExecuteNonQuery Then
                    Dim newForm As New invoice
                    newForm.lblFullName.Text = lblFN.Text
                    newForm.lblStudentNo.Text = lblSN.Text
                    newForm.fnm = lblFN.Text
                    newForm.sn = lblSN.Text
                    newForm.selected = sele
                    newForm.email = lblEm.Text
                    newForm.sc = ListView1.SelectedItems(0).SubItems(3).Text
                    newForm.lim = ListView1.SelectedItems(0).SubItems(4).Text
                    newForm.ob = ListView1.SelectedItems(0).SubItems(2).Text
                    newForm.code = ListView1.SelectedItems(0).SubItems(0).Text
                    newForm.title = ListView1.SelectedItems(0).SubItems(1).Text
                    newForm.cat = ListView1.SelectedItems(0).SubItems(5).Text
                    newForm.cd = ListView1.SelectedItems(0).SubItems(0).Text
                    newForm.tn = dt.Rows(0).Item(5)
                    newForm.mem = dt.Rows(0).Item(6)
                    newForm.year = dt.Rows(0).Item(10)
                    newForm.panels = dt.Rows(0).Item(7)
                    newForm.crs = lblCYS.Text
                    newForm.dateToday = Guna2DateTimePicker1.Value
                    newForm.Show()
                Else

                End If
            End If
            conn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try


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
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(252, 177, 45)), e.Bounds)
            Dim lvi As ListViewItem = New ListViewItem
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, New Font(ListView1.Font, Poppins), New Point(e.Bounds.Left + 0, e.Bounds.Top + 2), HighlightText)

        Else
            e.DrawDefault = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            conn.Open()
            Dim snt As Integer = 0
            Dim cmd1 As New MySqlCommand("SELECT count(*) FROM tblborroweddetails WHERE studno = '" & lblSN.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'IN POSSESION'", conn)
            ttl = cmd1.ExecuteScalar()
            lblBorrowed.Text = ttl
            Dim cmd3 As New MySqlCommand("SELECT SUM(overdue) FROM tblborroweddetails WHERE studno = '" & lblSN.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'OVERDUE'", conn)
            due = cmd3.ExecuteScalar()
            lblOverDue.Text = "₱" & due & ".00"
            Dim cmd4 As New MySqlCommand("SELECT SUM(cleared) FROM tblborroweddetails WHERE studno = '" & lblSN.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'CLEARED'", conn)
            cleared = cmd4.ExecuteScalar()
            lblCleared.Text = "₱" & cleared & ".00"
            Dim cmd5 As New MySqlCommand("SELECT SUM(overdue) FROM tblborroweddetails WHERE studno = '" & lblSN.Text & "' AND fullname = '" & lblFN.Text & "' AND status = 'OVERDUE'", conn)
            pending = cmd5.ExecuteScalar()
            lblPending.Text = "₱" & pending & ".00"
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblBorrowed.Click, Label7.Click
        Try
            conn.Open()
            If lblSN.Text = "" Then
                MessageBox.Show("Enter Student Number to View Borrowed List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim da As New MySqlDataAdapter("SELECT thesis_id, title, dateret FROM tblborroweddetails WHERE status = 'IN POSSESION' AND studno ='" & lblSN.Text & "'", conn)
                Dim dt = New DataTable
                da.Fill(dt)
                Dim lvItem As New ListViewItem
                Dim dr2 As DataRow
                Dim newForm As New borrowedThesis

                newForm.ListView1.Items.Clear()
                For Each dr2 In dt.Rows

                    newForm.lvItem = newForm.ListView1.Items.Add(dr2(0).ToString())
                    For s As Integer = 1 To 2
                        newForm.lvItem.SubItems.Add(dr2(s).ToString())

                    Next
                Next
                For Each lvi As ListViewItem In borrowedThesis.ListView1.Items
                    newForm.lvItem.UseItemStyleForSubItems = False
                    newForm.lvItem.SubItems(0).ForeColor = Color.Gray
                    newForm.lvItem.SubItems(1).ForeColor = Color.Gray
                    newForm.lvItem.SubItems(2).ForeColor = Color.Gray
                    newForm.sn = lblSN.Text
                Next
                newForm.code1 = dt.Rows(0).Item(0)
                If dt.Rows.Count >= 0 Then
                    newForm.Show()

                End If
            End If
            conn.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub lblPending_Click(sender As Object, e As EventArgs) Handles lblPending.Click, Label1.Click
        Try
            conn.Open()
            If lblSN.Text = "" Then
                MessageBox.Show("Enter Student Number to View Borrowed List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim da As New MySqlDataAdapter("SELECT thesis_id, title, dateret FROM tblborroweddetails WHERE status = 'OVERDUE' AND studno ='" & lblSN.Text & "'", conn)
                Dim dt = New DataTable
                da.Fill(dt)
                Dim lvItem As New ListViewItem
                Dim dr2 As DataRow
                Dim newForm As New Pendingvb

                newForm.ListView1.Items.Clear()
                For Each dr2 In dt.Rows

                    newForm.lvItem = newForm.ListView1.Items.Add(dr2(0).ToString())
                    For s As Integer = 1 To 2
                        newForm.lvItem.SubItems.Add(dr2(s).ToString())

                    Next
                Next
                For Each lvi As ListViewItem In newForm.ListView1.Items
                    newForm.lvItem.UseItemStyleForSubItems = False
                    newForm.lvItem.SubItems(0).ForeColor = Color.Gray
                    newForm.lvItem.SubItems(1).ForeColor = Color.Gray
                    newForm.lvItem.SubItems(2).ForeColor = Color.Gray
                    newForm.sn = lblSN.Text
                Next
                newForm.code1 = dt.Rows(0).Item(0)
                If dt.Rows.Count >= 0 Then
                    newForm.Show()

                End If
            End If
            conn.Close()

        Catch ex As Exception

        End Try

    End Sub


End Class