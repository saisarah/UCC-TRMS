Imports MySql.Data.MySqlClient

Public Class login
    Dim conn As New MySqlConnection("datasource = db4free.net;port=3306;username=thesismanagement;password=Jesuschrist23;database=dbtrms")
    Dim attempt As Integer = 0
    Dim cmdd As New MySqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbEnterCredentials.Text = "" Then
            MessageBox.Show("PLEASE FILL EMPTY BOX!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim reader As MySqlDataReader

            Try
                conn.Open()
                Dim sql As String
                sql = "SELECT `username` FROM `tblusers` WHERE `Username` = '" & tbEnterCredentials.Text & "' "
                cmdd = New MySqlCommand(sql, conn)
                reader = cmdd.ExecuteReader

                Dim count As Integer = 0
                While reader.Read
                    count += 1
                End While

                If count = 1 Then
                    mainForm.Show()
                    Me.Hide()
                    tbEnterCredentials.Clear()

                    conn.Close()
                    conn.Dispose()
                Else
                    MsgBox(“User does not exist!”)
                    attempt = attempt + 1
                    conn.Close()

                    tbEnterCredentials.Clear()

                    If attempt = 3 Then
                        Application.Exit()
                    End If

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally


            End Try
        End If
    End Sub
End Class