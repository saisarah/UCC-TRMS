Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO



Public Class invoice
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Public email, code As String
    Public title, cat, cd, tn, mem, year, panels, lim, sc, ob, selected, sec, lvl, crs, fnm, sn As String
    Public dateToday As DateTime

    Private Sub btnClosex_Click(sender As Object, e As EventArgs) Handles btnClosex.Click
        Me.Close()
    End Sub

    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Function UppercaseFirstLetter(ByVal val As String) As String

        If String.IsNullOrEmpty(val) Then
            Return val
        End If
        Dim array() As Char = val.ToCharArray
        array(0) = Char.ToUpper(array(0))
        Return New String(array)
    End Function

    Private Sub btnInvoiceProcess_Click_2(sender As Object, e As EventArgs) Handles btnInvoiceProcess.Click
        Try

            If selected = 1 Then

                Dim pdfFile As New Document
                Dim createPdf As PdfWriter = PdfWriter.GetInstance(pdfFile, New FileStream("C://Users//Sarah//Documents//Pdf//" & lblStudentNo.Text & " Request - " & title & ".pdf", FileMode.Create))
                pdfFile.Open()

                Dim bmp As New Bitmap(Panel2.Width, Panel2.Height)
                Panel2.DrawToBitmap(bmp, Panel2.ClientRectangle)

                Dim ItextImage As Image = Image.GetInstance(bmp, System.Drawing.Imaging.ImageFormat.Jpeg)
                ItextImage.Alignment = Element.ALIGN_CENTER
                ItextImage.ScalePercent(55.0F)
                pdfFile.Add(ItextImage)
                pdfFile.Close()
                Dim mail As New MailMessage
                Dim smtpServer As New SmtpClient("smtp.gmail.com")
                mail.From = New MailAddress("thesisrecordmanagement@gmail.com")
                mail.To.Add(email)
                mail.Subject = "Approval of Requested Copy"
                Dim nm, nm1 As String
                nm = lblFullName.Text.Substring(0, lblFullName.Text.IndexOf(""))
                nm1 = nm.ToLower()
                Dim htmlString As String = "
Dear " & UppercaseFirstLetter(nm1) & ",

We are happy to inform you that your request for the E-" & title & " document has been approved.
We have attached the said document title with Code " & code & " as a PDF file.


Kind Regards,
Student Assistant, MIS"
                conn.Open()
                mail.Body = htmlString
                Dim attach As System.Net.Mail.Attachment
                attach = New System.Net.Mail.Attachment("C:\Users\Sarah\Documents\Pdf\" & lblStudentNo.Text & " REQUEST - " & title & ".pdf")
                mail.Attachments.Add(attach)
                smtpServer.Port = 587
                smtpServer.Credentials = New System.Net.NetworkCredential("thesisrecordmanagement@gmail.com", "TRMS.GLOCSP")
                smtpServer.EnableSsl = True
                smtpServer.Send(mail)
                Dim CurrentDateTime As DateTime
                CurrentDateTime = DateTime.Now
                cur = DateTime.Now.AddDays(1).ToString("yyyy-dd-MM hh:mm:ss")

                Dim stat As String = "SENT"
                Dim comm As New MySqlCommand("INSERT INTO tblborroweddetails(thesis_id, title, dateissue, studno, fullname, crsyrsec, email, dateret, status) VALUES (@thesis_id, @title, @dateissue, @studno, @fullname, @course, @email, @dateret, @status)", conn)
                With comm

                    .Parameters.AddWithValue("@thesis_id", cd)
                    .Parameters.AddWithValue("@title", title.ToUpper())
                    .Parameters.AddWithValue("@dateissue", dateToday.ToString("yyyy-dd-MM hh:mm:ss"))
                    .Parameters.AddWithValue("@studno", sn)
                    .Parameters.AddWithValue("@fullname", fnm)
                    .Parameters.AddWithValue("@course", crs.ToUpper())
                    .Parameters.AddWithValue("@email", email)
                    .Parameters.AddWithValue("@dateret", cur)
                    .Parameters.AddWithValue("@status", stat)


                    .ExecuteNonQuery()
                End With
                Me.Close()
                Me.Alert("Attachment has been sent!", notification.enmType.Success)
                conn.Close()
            Else
                conn.Open()

                Dim CurrentDateTime As DateTime
                CurrentDateTime = DateTime.Now
                cur = DateTime.Now.AddDays(1)
                Dim stat As String = "IN POSSESION"
                cur = DateTime.Now.AddDays(1).ToString("yyyy-dd-MM hh:mm:ss")

                Dim comm As New MySqlCommand("INSERT INTO tblborroweddetails(thesis_id, title, dateissue, studno, fullname, crsyrsec, email, dateret, status) VALUES (@thesis_id, @title, @dateissue, @studno, @fullname, @course, @email, @dateret, @status)", conn)
                With comm

                    .Parameters.AddWithValue("@thesis_id", cd)
                    .Parameters.AddWithValue("@title", title.ToUpper())
                    .Parameters.AddWithValue("@dateissue", dateToday.ToString("yyyy-dd-MM hh:mm:ss"))
                    .Parameters.AddWithValue("@studno", sn)
                    .Parameters.AddWithValue("@fullname", fnm)
                    .Parameters.AddWithValue("@course", crs.ToUpper())
                    .Parameters.AddWithValue("@email", email)
                    .Parameters.AddWithValue("@dateret", cur)
                    .Parameters.AddWithValue("@status", stat)


                    .ExecuteNonQuery()
                End With
                Me.Close()
                conn.Close()

                Me.Alert("Borrowed Successful!", notification.enmType.Success)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        Dim c As ThesisUC = New ThesisUC
        c.Dock = DockStyle.Top

        For i As Integer = 0 To 1000
            c.lblCode.Text = cd
            c.lblTitle.Text = title
            c.lblTeamName.Text = tn
            c.lblCategory.Text = cat
            pnList.Controls.Add(c)

        Next
        Dim d As Soft_Copy = New Soft_Copy
        d.Dock = DockStyle.Top

        For i As Integer = 0 To 1000
            d.lblTitle.Text = title
            d.lblTeamName.Text = tn
            d.lblCategory.Text = cat
            d.lblFullName.Text = lblFullName.Text
            d.lblStudentNumber.Text = lblStudentNo.Text
            d.lblYear.Text = year
            d.lblMembers.Text = mem
            d.lblPanels.Text = panels
            d.lblLimitations.Text = lim
            d.lblScoe.Text = sc
            d.lblObjectives.Text = ob
            Panel2.Controls.Add(d)

        Next
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class