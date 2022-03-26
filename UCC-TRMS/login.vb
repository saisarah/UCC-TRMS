Imports MySql.Data.MySqlClient

Public Class login
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Dim cmdd As New MySqlCommand


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cm As New MySqlCommand("SELECT username FROM tblusers", conn)
            Dim dr As MySqlDataReader
            conn.Open()

            dr = cm.ExecuteReader
            If dr.Read Then
                cbCredentials.Items.Add(dr(0))
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim reader As MySqlDataReader

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