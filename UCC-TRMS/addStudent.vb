Imports MySql.Data.MySqlClient
Public Class addStudent
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Public Property SelectedRows As DataGridViewSelectedRowCollection
    Private Sub btnAddStudentClose_Click(sender As Object, e As EventArgs) Handles btnAddStudentClose.Click
        Me.Close()
    End Sub

    Public Function namedontexist(ByVal StudentNumber As String) As Boolean
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM `tblenrolled` WHERE `studno`= ('" & StudentNumber & "')"

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter(cmd)
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
        Try
            Dim StudentNumber As String

            StudentNumber = tbstudentno.Text

            If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
                conn.Open()
                If namedontexist(StudentNumber) Then
                    MessageBox.Show("STUDENT NUMBER DOESN'T EXIST!", "ADD STUDENT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    clear()
                Else
                    Dim comm As New MySqlCommand("INSERT INTO tblstudents(fullname, studentno, email, course, year, section, contact) VALUES (@fullname, @studentno, @email, @course, @year, @section, @contact)", conn)
                    With comm
                        .Parameters.AddWithValue("@fullname", tbfullname.Text.ToUpper())
                        .Parameters.AddWithValue("@studentno", tbstudentno.Text.ToUpper())
                        .Parameters.AddWithValue("@email", tbemail.Text)
                        .Parameters.AddWithValue("@course", tbcourse.Text.ToUpper())
                        .Parameters.AddWithValue("@year", cbyear.Text.ToUpper())
                        .Parameters.AddWithValue("@section", tbsection.Text.ToUpper())
                        .Parameters.AddWithValue("@contact", tbcontact.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Record has been saved!", vbInformation)
                    clear()
                    With borrowers
                        mainForm.OpenChildForm(New borrowers)
                    End With
                    Me.Close()
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub clear()
        tbfullname.Clear()
        tbsection.Clear()
        tbstudentno.Clear()
        tbcourse.Clear()
        tbcontact.Clear()
        tbemail.Clear()
        cbyear.SelectedIndex = -1
    End Sub

    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this Record?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then



            Dim i As String
            i = SelectedRows(0).Cells(2).Value

            conn.Open()
            Dim comm As New MySqlCommand("UPDATE tblstudents SET fullname=@fullname, studentno=@studentno, email=@email, course=@course, section=@section, year=@year, contact=@contact WHERE id = '" & i & "'", conn)
            With comm
                .Parameters.AddWithValue("@fullname", tbfullname.Text.ToUpper())
                .Parameters.AddWithValue("@studentno", tbstudentno.Text.ToUpper())
                .Parameters.AddWithValue("@course", tbcourse.Text.ToUpper())
                .Parameters.AddWithValue("@section", tbsection.Text.ToUpper())
                .Parameters.AddWithValue("@year", cbyear.Text.ToUpper())
                .Parameters.AddWithValue("@contact", tbcontact.Text)
                .Parameters.AddWithValue("@email", tbemail.Text)
            End With
            If comm.ExecuteNonQuery Then
                MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mainForm.OpenChildForm(New borrowers)
                Me.Hide()
            End If
            conn.Close()
        ElseIf result = DialogResult.No Then
            Me.Hide()
        End If
    End Sub
End Class