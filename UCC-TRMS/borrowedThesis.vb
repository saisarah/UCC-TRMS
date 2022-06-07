Imports MySql.Data.MySqlClient
Public Class borrowedThesis
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Public lvItem As New ListViewItem
    Public sn, code1 As String

    Private Sub borrowedThesis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Start()
            Guna2ShadowForm1.SetShadowForm(Me)
            conn.Open()

            Dim da As New MySqlDataAdapter("SELECT thesis_id, title, dateret, limitations, category FROM tblborroweddetails WHERE status = 'IN POSSESION' AND studno ='" & issuing.lblSN.Text & "'", conn)
            Dim dt = New DataTable
            da.Fill(dt)
            Dim dr2 As DataRow
            ListView1.Items.Clear()

            For Each dr2 In dt.Rows

                lvItem = Me.ListView1.Items.Add(dr2(0).ToString())
                For s As Integer = 1 To 3
                    lvItem.SubItems.Add(dr2(s).ToString())

                Next
            Next
            For Each lvi As ListViewItem In Me.ListView1.Items
                lvi.UseItemStyleForSubItems = False
                lvi.SubItems(0).ForeColor = Color.Gray
                lvi.SubItems(1).ForeColor = Color.Gray
                lvi.SubItems(2).ForeColor = Color.Gray

            Next

        Catch ex As Exception
        End Try
        conn.Close()
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
            e.DrawDefault = False
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(252, 177, 45)), e.Bounds)
            Dim lvi As ListViewItem = New ListViewItem
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, New Font(ListView1.Font, Poppins), New Point(e.Bounds.Left + 0, e.Bounds.Top + 2), HighlightText)
        Else
            e.DrawDefault = True
        End If
    End Sub

    Private Sub btnArchivedClose_Click(sender As Object, e As EventArgs) Handles btnArchivedClose.Click
        Me.Close()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        ContextMenuStrip1.Show(Cursor.Position)
    End Sub
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Guna2ShadowForm1.SetShadowForm(Me)
            conn.Open()

            Dim da As New MySqlDataAdapter("SELECT thesis_id, title, dateissue, limitations, category FROM tblborroweddetails WHERE status = 'IN POSSESION' AND studno ='" & sn & "'", conn)
            Dim dt = New DataTable
            da.Fill(dt)
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

            Next

        Catch ex As Exception
        End Try
        conn.Close()
    End Sub

    Private Sub MarkAsOverdueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsOverdueToolStripMenuItem.Click
        Try
            conn.Open()
            Dim sa As String = ListView1.SelectedItems(0).ToString().Substring(15).Replace("}", "")
            Dim status As String = "OVERDUE"
            Dim ovd As Integer = 30
            Dim cm1 As New MySqlCommand("UPDATE tblborroweddetails SET status = @status, overdue = overdue + @overdue, pending = @pending WHERE thesis_id = '" & sa & "' AND status = 'IN POSSESION'", conn)
            cm1.Parameters.Add("@status", MySqlDbType.VarChar).Value = status
            cm1.Parameters.Add("@overdue", MySqlDbType.VarChar).Value = ovd
            cm1.Parameters.Add("@pending", MySqlDbType.VarChar).Value = ovd

            If cm1.ExecuteNonQuery Then
                Me.Alert(sa + " Marked successfuly!", notification.enmType.Success)

                Dim da As New MySqlDataAdapter("SELECT thesis_id, title, dateret FROM tblborroweddetails WHERE status = 'IN POSSESION' AND studno ='" & issuing.lblSN.Text & "'", conn)
                Dim dt = New DataTable
                da.Fill(dt)
                Dim dr2 As DataRow
                ListView1.Items.Clear()

                For Each dr2 In dt.Rows

                    lvItem = Me.ListView1.Items.Add(dr2(0).ToString())
                    For s As Integer = 1 To 2
                        lvItem.SubItems.Add(dr2(s).ToString())

                    Next
                Next
                For Each lvi As ListViewItem In Me.ListView1.Items
                    lvi.UseItemStyleForSubItems = False
                    lvi.SubItems(0).ForeColor = Color.Gray
                    lvi.SubItems(1).ForeColor = Color.Gray
                    lvi.SubItems(2).ForeColor = Color.Gray

                Next
            Else
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub MarkAsReturnedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsReturnedToolStripMenuItem.Click
        Try
            conn.Open()
            Dim sa As String = ListView1.SelectedItems(0).ToString().Substring(15).Replace("}", "")
            Dim status As String = "RETURNED"
            Dim cm1 As New MySqlCommand("UPDATE tblborroweddetails SET status = @status WHERE thesis_id = '" & sa & "' AND status = 'IN POSSESION'", conn)
            cm1.Parameters.Add("@status", MySqlDbType.VarChar).Value = status
            If cm1.ExecuteNonQuery Then
                Me.Alert(sa + " Returned successfuly!", notification.enmType.Success)

                Dim da As New MySqlDataAdapter("SELECT thesis_id, title, dateret FROM tblborroweddetails WHERE status = 'IN POSSESION' AND studno ='" & issuing.lblSN.Text & "'", conn)
                Dim dt = New DataTable
                da.Fill(dt)
                Dim dr2 As DataRow
                ListView1.Items.Clear()

                For Each dr2 In dt.Rows

                    lvItem = Me.ListView1.Items.Add(dr2(0).ToString())
                    For s As Integer = 1 To 2
                        lvItem.SubItems.Add(dr2(s).ToString())

                    Next
                Next
                For Each lvi As ListViewItem In Me.ListView1.Items
                    lvi.UseItemStyleForSubItems = False
                    lvi.SubItems(0).ForeColor = Color.Gray
                    lvi.SubItems(1).ForeColor = Color.Gray
                    lvi.SubItems(2).ForeColor = Color.Gray

                Next
            Else
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class