Imports MySql.Data.MySqlClient
Public Class studentArchive
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")

    Private Sub studentArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Guna2ShadowForm1.SetShadowForm(Me)
            Dim da As New MySqlDataAdapter("SELECT studentno, fullname,  course, year, section, email FROM tblstudents", conn)
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


        Catch ex As Exception

        End Try
        conn.Close()

    End Sub

    Private Sub btnStudentArchivedClose_Click(sender As Object, e As EventArgs) Handles btnStudentArchivedClose.Click
        Me.Close()
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
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, New Font(ListView1.Font, Poppins), New Point(e.Bounds.Left + 0, e.Bounds.Top + 2), HighlightText)

        Else
            e.DrawDefault = True
        End If
    End Sub
End Class