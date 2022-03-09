Public Class mainForm

    Private currentChildForm As Form
    Private btnDashboardWasClicked As Boolean = False
    Private btnThesisWasClicked As Boolean = False
    Private btnBorrowersWasClicked As Boolean = False



    Public Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlBody.Controls.Add(childForm)
        pnlBody.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        btnDashboardWasClicked = True
        OpenChildForm(New dashboard)
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New dashboard)
        btnDashboardWasClicked = True
    End Sub

    Private Sub btnThesis_Click(sender As Object, e As EventArgs) Handles btnThesis.Click
        OpenChildForm(New thesis)
        btnThesisWasClicked = True
    End Sub

    Private Sub btnBorrowers_Click(sender As Object, e As EventArgs) Handles btnBorrowers.Click
        OpenChildForm(New borrowers)
        btnBorrowersWasClicked = True
    End Sub
End Class
