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
        Timer1.Start()
        load()
    End Sub
    Public Sub load()
        Try
            conn.Open()
            Dim y As New MySqlCommand("SELECT * FROM tblusers Order by id desc", conn)
            Dim dr As MySqlDataReader
            dr = y.ExecuteReader
            While dr.Read
                Dim c As userSA = New userSA
                Dim a As Integer = 1
                c.Dock = DockStyle.Top
                For f As Integer = 0 To 1000
                    c.lblID.Text = dr(0)
                    c.lblUsername.Text = dr(1)
                    c.lblStat.Text = dr(2)
                    Panel1.Controls.Add(c)
                Next
                a = a + 1

            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
End Class