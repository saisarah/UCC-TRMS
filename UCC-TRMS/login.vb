Imports MySql.Data.MySqlClient

Public Class login
    Dim conn As New MySqlConnection("datasource = db4free.net;port=3306;username=thesismanagement;password=Jesuschrist23;database=dbtrms")
    Dim cmdd As New MySqlCommand


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cm As New MySqlCommand("SELECT username FROM tblusers", conn)
        Dim dr As MySqlDataReader
        conn.Open()

        dr = cm.ExecuteReader
        If dr.Read Then
            cbCredentials.Items.Add(dr(0))
        End If
        dr.Close()

    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim reader As MySqlDataReader
        MessageBox.Show(cbCredentials.Text)

        Dim sql As String
        sql = "SELECT `username` FROM `tblusers` WHERE `username` = '" & cbCredentials.Text & "' "
        cmdd = New MySqlCommand(sql, conn)
        reader = cmdd.ExecuteReader

        mainForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnCloseLogin_Click_1(sender As Object, e As EventArgs) Handles btnCloseLogin.Click
        Application.Exit()
    End Sub
End Class