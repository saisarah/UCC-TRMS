Imports MySql.Data.MySqlClient

Public Class thesis
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Private Sub btnAddThesis_Click(sender As Object, e As EventArgs) Handles btnAddThesis.Click
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
            MsgBox(ex.Message, vbCritical)
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

            Dim i As Integer
            i = dgvThesis.CurrentRow.Index
            lblTitle.Text = dgvThesis.Item(1, i).Value.ToString
            lblScope.Text = dgvThesis.Item(3, i).Value.ToString
            lblLimit.Text = dgvThesis.Item(4, i).Value.ToString
            lblCategory.Text = dgvThesis.Item(8, i).Value.ToString
            lblObjectives.Text = dgvThesis.Item(2, i).Value.ToString
            lblTeam.Text = dgvThesis.Item(5, i).Value.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub thesis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub
End Class