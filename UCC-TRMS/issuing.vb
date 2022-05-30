Imports MySql.Data.MySqlClient
Public Class issuing
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub loadData()
        Try

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
        loadData()

    End Sub

    Private Sub tbSearchThesis_TextChanged(sender As Object, e As EventArgs) Handles tbSearchThesis.TextChanged
        loadData()
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        loadData()
    End Sub
    Sub clear()
        lblSN.Text = ""
        lblFN.Text = ""
        lblCYS.Text = ""
        lblEm.Text = ""
        lblCN.Text = ""

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
            Else
                Me.Alert1("Student number not found!", Confirmation.enmType.Info)
                clear()
            End If
            conn.close()
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
            conn.Open()


            Dim cmd As New MySqlCommand("SELECT thesis_id, teamname, members FROM tblthesis WHERE thesis_id = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'", conn)
            Dim da As New MySqlDataAdapter
            Dim dt As New DataTable()
            da.SelectCommand = cmd
            da.Fill(dt)
            If ListView1.SelectedItems.Count > 0 And cbHoS.SelectedIndex = 1 And dt.Rows.Count > 0 And cmd.ExecuteNonQuery Then
                Dim newForm As New invoice
                newForm.lblFullName.Text = lblFN.Text
                newForm.lblStudentNumber.Text = lblSN.Text
                newForm.email = lblEm.Text
                newForm.lblTitle.Text = ListView1.SelectedItems(0).SubItems(1).Text
                newForm.lblObjectives.Text = ListView1.SelectedItems(0).SubItems(2).Text
                newForm.lblScoe.Text = ListView1.SelectedItems(0).SubItems(3).Text
                newForm.lblLimitations.Text = ListView1.SelectedItems(0).SubItems(4).Text
                newForm.lblCategory.Text = ListView1.SelectedItems(0).SubItems(5).Text
                newForm.lblTeamName.Text = dt.Rows(0).Item(1)
                newForm.lblMembers.Text = dt.Rows(0).Item(2)
                newForm.code = ListView1.SelectedItems(0).SubItems(0).Text
                newForm.Show()
            Else
                MsgBox("HARDCOPY")
            End If
            conn.Close()
        Catch ex As Exception

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
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(76, 71, 67)), e.Bounds)
            Dim lvi As ListViewItem = New ListViewItem
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, New Font(ListView1.Font, Poppins), New Point(e.Bounds.Left + 0, e.Bounds.Top + 2), HighlightText)

        Else
            e.DrawDefault = True
        End If
    End Sub
End Class