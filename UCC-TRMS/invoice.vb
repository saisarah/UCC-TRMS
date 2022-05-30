Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO



Public Class invoice
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Public email, code As String
    Public Sub Alert(ByVal msg As String, ByVal type As notification.enmType)
        Dim frm As notification = New notification()
        frm.showAlert(msg, type)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Function UppercaseFirstLetter(ByVal val As String) As String

        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function

    Private Sub btnInvoiceProcess_Click_2(sender As Object, e As EventArgs) Handles btnInvoiceProcess.Click
        Try
            EasyHTMLReports1.AddControl(Guna2Panel1)

            Dim pdfFile As New Document
            Dim createPdf As PdfWriter = PdfWriter.GetInstance(pdfFile, New FileStream("C://Users//Asus//Documents//Pdf//" & lblStudentNumber.Text & " Request - " & lblTitle.Text & ".pdf", FileMode.Create))
            pdfFile.Open()

            Dim bmp As New Bitmap(Guna2Panel3.Width, Guna2Panel3.Height)
            Guna2Panel3.DrawToBitmap(bmp, Guna2Panel3.ClientRectangle)

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
            nm = lblFullName.Text.Substring(0, lblFullName.Text.IndexOf(" "))
            nm1 = nm.ToLower()
            Dim htmlString As String = "
Dear " & UppercaseFirstLetter(nm1) & ",

We are happy to inform you that your request for the E-" & lblTitle.Text & " document has been approved.
We have attached the said document title with Code " & code & " as a PDF file.


Kind Regards,
Student Assistant, MIS"

            mail.Body = htmlString
            Dim attach As System.Net.Mail.Attachment
            attach = New System.Net.Mail.Attachment("C:\Users\Asus\Documents\Pdf\" & lblStudentNumber.Text & " REQUEST - " & lblTitle.Text & ".pdf")
            mail.Attachments.Add(attach)
            smtpServer.Port = 587
            smtpServer.Credentials = New System.Net.NetworkCredential("thesisrecordmanagement@gmail.com", "TRMS.GLOCSP")
            smtpServer.EnableSsl = True
            smtpServer.Send(mail)
            Me.Close()
            Me.Alert("Attachment has been sent!", notification.enmType.Success)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblObjectives_Click(sender As Object, e As EventArgs) Handles lblObjectives.Click

    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class