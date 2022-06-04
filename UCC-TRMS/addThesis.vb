Imports MySql.Data.MySqlClient
Public Class addThesis
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Public Property SelectedRows As DataGridViewSelectedRowCollection
    Public sel As String

    Private Sub btnAddThesisClose_Click(sender As Object, e As EventArgs) Handles btnAddThesisClose.Click
        Me.Close()
    End Sub
    Public Sub Alert1(ByVal msg As String, ByVal type As Confirmation.enmType)
        Dim frm As Confirmation = New Confirmation()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnSaveThesis_Click(sender As Object, e As EventArgs) Handles btnSaveThesis.Click
        Me.Alert1("Do you want to save this record?", Confirmation.enmType.DangerThesis)
    End Sub
    Public Sub add1()
        Try
            dn = Date.Now().ToString("MMddyy000")

            Dim rest As String = cbCourse.Text.Remove(0, 2)
            conn.Open()
            Dim y As New MySqlCommand("SELECT RIGHT(thesis_id,8) as yourvalue FROM tblthesis ORDER BY thesis_id DESC LIMIT 1 ", conn)
            Dim dr As MySqlDataReader
            Dim f As Integer
            Dim tid, id As Integer
            Dim tid1, cs, it, is1, emc As String
            id = 1
            dr = y.ExecuteReader
            If dr.Read() Then
                tid = dr(0)
                f = tid + id
            Else
                f = dn.ToString() + tid + id
            End If
            If rest = "CS" Then
                cs = rest
            ElseIf rest = "IT" Then
                it = rest
            ElseIf rest = "IS" Then
                is1 = rest
            ElseIf rest = "EMC" Then
                emc = rest
            End If
            dr.Close()
            Dim comm As New MySqlCommand("INSERT INTO tblthesis(thesis_id, title, objectives, scope, limitations, teamname, members, panels, category, course, year) VALUES (@thesis_id, @title, @objectives, @scope, @limitations, @teamname, @members, @panels, @category, @course, @year)", conn)
            With comm
                .Parameters.AddWithValue("@thesis_id", String.Concat(cs & it & is1 & emc & f))
                .Parameters.AddWithValue("@title", tbTitle.Text.ToUpper())
                .Parameters.AddWithValue("@objectives", tbObjectives.Text.ToUpper())
                .Parameters.AddWithValue("@scope", tbScope.Text.ToUpper())
                .Parameters.AddWithValue("@limitations", tbLimitation.Text.ToUpper())
                .Parameters.AddWithValue("@teamname", tbTeam.Text.ToUpper())
                .Parameters.AddWithValue("@members", tbMembers.Text.ToUpper())
                .Parameters.AddWithValue("@panels", tbPanel.Text.ToUpper())
                .Parameters.AddWithValue("@category", cbCategory.Text.ToUpper())
                .Parameters.AddWithValue("@course", cbCourse.Text.ToUpper())
                .Parameters.AddWithValue("@year", tbYear.Text)
                .ExecuteNonQuery()

            End With
            Me.Close()

            mainForm.OpenChildForm(New borrowers)
            clear()
                conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
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
        cbCategory.SelectedIndex = -1
        cbCourse.SelectedIndex = -1

    End Sub
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want To update this Record?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


        If result = DialogResult.Yes Then

            conn.Open()
            Dim comm As New MySqlCommand("UPDATE tblthesis Set title=@title, objectives=@objectives, scope=@scope, limitations=@limitations, teamname=@teamname, members=@members, panels=@panels, category=@category, course=@course, year=@year WHERE thesis_id = '" & sel & "'", conn)
            With comm
                .Parameters.AddWithValue("@title", tbTitle.Text.ToUpper())
                .Parameters.AddWithValue("@objectives", tbObjectives.Text.ToUpper())
                .Parameters.AddWithValue("@scope", tbScope.Text.ToUpper())
                .Parameters.AddWithValue("@limitations", tbLimitation.Text.ToUpper())
                .Parameters.AddWithValue("@teamname", tbTeam.Text.ToUpper())
                .Parameters.AddWithValue("@members", tbMembers.Text.ToUpper())
                .Parameters.AddWithValue("@panels", tbPanel.Text.ToUpper())
                .Parameters.AddWithValue("@category", cbCategory.Text.ToUpper())
                .Parameters.AddWithValue("@course", cbCourse.Text.ToUpper())
                .Parameters.AddWithValue("@year", tbYear.Text)



            End With
            If comm.ExecuteNonQuery Then
                mainForm.OpenChildForm(New thesis)
                Me.Hide()
                Me.Alert(sel + " updated successfully!", notification.enmType.Success)
            End If
            conn.Close()
        ElseIf result = DialogResult.No Then
        Else
            MsgBox("ERROR")
        End If


    End Sub

    Private Sub addThesis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub
End Class