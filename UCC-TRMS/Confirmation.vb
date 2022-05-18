Imports MySql.Data.MySqlClient
Public Class Confirmation
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Public Property SelectedRows As DataGridViewSelectedRowCollection
    Public sn As String
    Public update1 = False
    Public deleteStud = False
    Public deleteThesis = False
    Public addTh = False
    Public updateStud = False
    Public updateThesis = False
    Public btnYes = False

    Public Enum enmType
        Success
        Info
        WarningThesis
        WarningStud
        DangerStud
        DangerThesis
        InfoStud
        InfoThesis
    End Enum
    Private action As notification.enmAction

    Public Sub showAlert(ByVal msg As String, ByVal type As enmType)
        Me.Opacity = 0.0
        Dim fname As String

        For i As Integer = 1 To 10 - 1
            fname = "alert1" & i.ToString()
            Dim frm As Confirmation = CType(Application.OpenForms(fname), Confirmation)

            If frm Is Nothing Then
                Me.Name = fname
            End If
        Next

        Select Case type
            Case enmType.Info
                Me.PictureBox1.Image = My.Resources.Info
                Me.PictureBox2.Image = My.Resources.Ifo_qm
                Me.btnNoCancel.Text = "Cancel"
                Me.btnYesOk.Text = "Ok"
                Label2.Text = "Oops!"
                Label2.ForeColor = Color.FromArgb(66, 146, 255)
                btnYesOk.FillColor = Color.FromArgb(66, 146, 255)
            Case enmType.DangerStud
                Me.PictureBox1.Image = My.Resources.Dagnger
                Me.PictureBox2.Image = My.Resources.question__2_
                Me.btnNoCancel.Text = "Cancel"
                update1 = True
                deleteStud = False
                addTh = False
                deleteThesis = False
                lblmsg.ForeColor = Color.Black
                Label2.ForeColor = Color.FromArgb(255, 222, 89)
                btnYesOk.FillColor = Color.FromArgb(255, 222, 89)
            Case enmType.WarningStud
                Me.BackColor = Color.DarkOrange
                Me.PictureBox1.Image = My.Resources.Warning
                Me.PictureBox2.Image = My.Resources.warning__2_
                Me.btnNoCancel.Text = "Cancel"
                update1 = False
                deleteStud = True
                addTh = False
                deleteThesis = False
                lblmsg.ForeColor = Color.Black
                Label2.ForeColor = Color.FromArgb(255, 222, 89)
                btnYesOk.FillColor = Color.FromArgb(255, 222, 89)
            Case enmType.DangerThesis
                Me.PictureBox1.Image = My.Resources.Dagnger
                Me.PictureBox2.Image = My.Resources.question__2_
                Me.btnNoCancel.Text = "Cancel"
                update1 = False
                deleteStud = False
                addTh = True
                deleteThesis = False
                lblmsg.ForeColor = Color.Black
                Label2.ForeColor = Color.FromArgb(255, 222, 89)
                btnYesOk.FillColor = Color.FromArgb(255, 222, 89)
            Case enmType.WarningThesis
                Me.BackColor = Color.DarkOrange
                Me.PictureBox1.Image = My.Resources.Warning
                Me.PictureBox2.Image = My.Resources.warning__2_
                Me.btnNoCancel.Text = "Cancel"
                update1 = False
                deleteStud = False
                addTh = False
                deleteThesis = True
                Label2.ForeColor = Color.FromArgb(255, 66, 66)
                btnYesOk.FillColor = Color.FromArgb(255, 66, 66)
        End Select

        Me.lblmsg.Text = msg
        Me.Timer1.Interval = 1
        Me.action = enmAction.start
        Me.Timer1.Start()
        Me.Show()
    End Sub
    Public Enum enmAction
        start
    End Enum

    Sub clear()
        addStudent.tbfullname.Clear()
        addStudent.tbstudentno.Clear()
        addStudent.tbCourse.SelectedIndex = 0
        addStudent.tbcontact.Clear()
        addStudent.tbemail.Clear()
        addStudent.cbyear.SelectedIndex = 0
        addStudent.cbSection.SelectedIndex = 0

    End Sub
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnYesOk_Click(sender As Object, e As EventArgs) Handles btnYesOk.Click
        Try
            If deleteStud = False And update1 = True And addTh = False And deleteThesis = False Then
                addStudent.add()
                deleteStud = False
                addTh = False
                deleteThesis = False
                Me.Close()
            ElseIf deleteStud = True And update1 = False And addTh = False And deleteThesis = False Then
                Dim i As String
                i = SelectedRows(0).Cells(3).Value
                update1 = False
                addTh = False
                deleteThesis = False
                conn.Open()
                Dim command As New MySqlCommand("INSERT INTO tblarchivedstud (studID, fullname, studentno, email, course, year, section, contact) SELECT id, fullname, studentno, email, course, year, section, contact FROM tblstudents WHERE studentno ='" & i & "'", conn)
                command.ExecuteNonQuery()
                Dim command1 As New MySqlCommand("DELETE FROM tblstudents WHERE studentno ='" & i & "'", conn)
                command1.ExecuteNonQuery()
                mainForm.OpenChildForm(New borrowers)
                Me.Alert(i + " deleted successfully", notification.enmType.Success)
                Me.Close()
            ElseIf addTh = True And deleteStud = False And update1 = False And deleteThesis = False Then
                addThesis.add1()
                update1 = False
                deleteStud = False
                deleteThesis = False

                Me.Alert("New record added successfully!", notification.enmType.Success)
                mainForm.OpenChildForm(New thesis)
                Me.Close()
            ElseIf deleteThesis = True And addTh = False And deleteStud = False And update1 = False Then
                update1 = False
                deleteStud = False
                addTh = False
                Dim i As String
                i = SelectedRows(0).Cells(3).Value
                conn.Open()
                Dim command As New MySqlCommand("INSERT INTO tblarchive (thesis_id, title, objectives, scope, limitations, teamname, members, panels, category) SELECT thesis_id, title, objectives, scope, limitations, teamname, members, panels, category FROM tblthesis WHERE thesis_id ='" & i & "'", conn)
                command.ExecuteNonQuery()
                Dim command1 As New MySqlCommand("DELETE FROM tblthesis WHERE thesis_id ='" & i & "'", conn)
                command1.ExecuteNonQuery()
                conn.Close()
                mainForm.OpenChildForm(New thesis)
                Me.Alert(i + " deleted successfully", notification.enmType.Success)
                Me.Close()
            Else
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNoCancel_Click(sender As Object, e As EventArgs) Handles btnNoCancel.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1
        Opacity += 0.1
    End Sub

    Private Sub Confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class