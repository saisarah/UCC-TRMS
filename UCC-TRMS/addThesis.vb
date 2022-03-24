Imports MySql.Data.MySqlClient
Public Class addThesis
    Dim conn As New MySqlConnection("datasource = db4free.net;port=3306;username=thesismanagement;password=Jesuschrist23;database=dbtrms")
    Private Sub btnAddThesisClose_Click(sender As Object, e As EventArgs) Handles btnAddThesisClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveThesis_Click(sender As Object, e As EventArgs) Handles btnSaveThesis.Click
        Try
            If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
                conn.Open()
                Dim comm As New MySqlCommand("INSERT INTO tblthesis(title, objectives, scope, limitations, teamname, members, panels, category) VALUES (@title, @objectives, @scope, @limitations, @teamname, @members, @panels, @category)", conn)
                With comm
                    .Parameters.AddWithValue("@title", tbTitle.Text.ToUpper())
                    .Parameters.AddWithValue("@objectives", tbObjectives.Text.ToUpper())
                    .Parameters.AddWithValue("@scope", tbScope.Text.ToUpper())
                    .Parameters.AddWithValue("@limitations", tbLimitation.Text.ToUpper())
                    .Parameters.AddWithValue("@teamname", tbTeam.Text.ToUpper())
                    .Parameters.AddWithValue("@members", tbMembers.Text.ToUpper())
                    .Parameters.AddWithValue("@panels", tbPanel.Text.ToUpper())
                    .Parameters.AddWithValue("@category", cbCategory.Text.ToUpper())
                    .ExecuteNonQuery()
                End With
                MsgBox("Record has been saved!", vbInformation)
                clear()
                With thesis
                    thesis.TopLevel = False
                    thesis.FormBorderStyle = FormBorderStyle.None
                    thesis.Dock = DockStyle.Fill
                    mainForm.pnlBody.Controls.Add(thesis)
                    mainForm.pnlBody.Tag = thesis
                    .LoadRecords()
                    thesis.BringToFront()
                    thesis.Show()
                    conn.Close()
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub clear()
        tbTitle.Clear()
        tbObjectives.Clear()
        tbScope.Clear()
        tbLimitation.Clear()
        tbTeam.Clear()
        tbMembers.Clear()
        tbPanel.Clear()
        cbCategory.Items.Clear()
    End Sub
End Class