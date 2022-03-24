Imports MySql.Data.MySqlClient

Public Class thesis
    Dim conn As New MySqlConnection("datasource = db4free.net;port=3306;username=thesismanagement;password=Jesuschrist23;database=dbtrms")
    Private Sub btnAddThesis_Click(sender As Object, e As EventArgs) Handles btnAddThesis.Click
        addThesis.BringToFront()
        addThesis.Show()
    End Sub
    Sub LoadRecords()

        Try
            Dim i As Integer
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
End Class