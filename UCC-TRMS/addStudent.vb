Imports MySql.Data.MySqlClient
Public Class addStudent
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Public Property SelectedRows As DataGridViewSelectedRowCollection
    Private Sub btnAddStudentClose_Click(sender As Object, e As EventArgs) Handles btnAddStudentClose.Click
        Me.Close()
    End Sub

    Public Sub Alert1(ByVal msg As String, ByVal type As Confirmation.enmType)
        Dim frm As Confirmation = New Confirmation()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
        Me.Alert1("Do you want to save this record?", Confirmation.enmType.DangerStud)
    End Sub
    Public Function namedontexist(ByVal StudentNumber As String) As Boolean
        Try
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

        Catch ex As Exception

        End Try
    End Function

    Public Sub add()
        Try
            Dim StudentNumber, fn As String
            Dim sn As Integer
            StudentNumber = tbstudentno.Text
            conn.Open()
            If namedontexist(StudentNumber) Then
                Me.Alert1("Student number not enrolled!", Confirmation.enmType.Info)
            Else
                Dim y As New MySqlCommand("SELECT studentno, fullname FROM tblstudents WHERE studentno = '" & tbstudentno.Text & "' AND fullname = '" & tbfullname.Text.ToUpper() & "'", conn)
                Dim dr As MySqlDataReader
                dr = y.ExecuteReader
                If dr.Read() Then
                    sn = dr(0).ToString()
                    fn = dr(1).ToString()
                End If
                dr.Close()
                If sn = tbstudentno.Text Or fn = tbfullname.Text Then
                    Me.Alert1("Student number already existed!", Confirmation.enmType.Info)
                Else
                    Dim comm As New MySqlCommand("INSERT INTO tblstudents(fullname, studentno, email, course, year, section, contact) VALUES (@fullname, @studentno, @email, @course, @year, @section, @contact)", conn)
                    With comm
                        .Parameters.AddWithValue("@fullname", tbfullname.Text.ToUpper())
                        .Parameters.AddWithValue("@studentno", tbstudentno.Text.ToUpper())
                        .Parameters.AddWithValue("@email", tbemail.Text)
                        .Parameters.AddWithValue("@course", tbcourse.Text.ToUpper())
                        .Parameters.AddWithValue("@year", cbyear.Text.ToUpper())
                        .Parameters.AddWithValue("@section", cbSection.Text.ToUpper())
                        .Parameters.AddWithValue("@contact", tbcontact.Text)
                        .ExecuteNonQuery()
                        Me.Alert(tbstudentno.Text + " has been save!", notification.enmType.Success)
                        conn.Close()
                    End With
                    clear()
                    With borrowers
                        mainForm.OpenChildForm(New borrowers)
                    End With

                    Me.Close()
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Sub clear()
        tbfullname.Clear()
        tbstudentno.Clear()
        tbcourse.Clear()
        tbcontact.Clear()
        tbemail.Clear()
        cbyear.SelectedIndex = 0
        cbSection.SelectedIndex = 0

    End Sub
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this Record?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim i As String
            i = SelectedRows(0).Cells(3).Value

            conn.Open()
            Dim comm As New MySqlCommand("UPDATE tblstudents SET fullname=@fullname, email=@email, course=@course, section=@section, year=@year, contact=@contact WHERE studentno = '" & i & "'", conn)
            With comm
                .Parameters.AddWithValue("@fullname", tbfullname.Text.ToUpper())
                .Parameters.AddWithValue("@course", tbcourse.Text.ToUpper())
                .Parameters.AddWithValue("@section", cbSection.Text.ToUpper())
                .Parameters.AddWithValue("@year", cbyear.Text.ToUpper())
                .Parameters.AddWithValue("@contact", tbcontact.Text)
                .Parameters.AddWithValue("@email", tbemail.Text)
            End With
            If comm.ExecuteNonQuery Then
                mainForm.OpenChildForm(New borrowers)
                Me.Hide()
                Me.Alert(i + " updated successfuly!", notification.enmType.Success)
            End If
            conn.Close()
        ElseIf result = DialogResult.No Then
            Me.Hide()
        End If
    End Sub

    Private Sub tbcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcontact.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Label1.Text <> "Update Student" Then
            cbyear.Text = cbyear.Items.Item(0).ToString()
            cbSection.SelectedIndex = 0
        End If

    End Sub
End Class