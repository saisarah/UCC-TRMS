Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class reports
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=dbtrms")
    Dim clicked As Boolean = False
    Public Sub report()
        Dim rptDst As ReportDataSource
        Me.TRMSReportViewer.RefreshReport()

        Try
            Dim from, to1 As String
            from = dtpFrom.Value.ToString("yyyy-dd-MM")
            to1 = dtpTo.Value.ToString("yyyy-dd-MM")
            conn.Open()
            comm = conn.CreateCommand()
            comm.CommandType = CommandType.Text
            comm.CommandText = "UPDATE tblreport SET`Student_Registered` = (SELECT COUNT(tblstudents.ID) FROM tblstudents),`Number_of_thesis` = (SELECT COUNT(tblthesis.thesis_id) FROM tblthesis),`Borrowed_Hardcopy` = (SELECT COUNT(tblborroweddetails.thesis_id) FROM tblborroweddetails WHERE status = 'IN POSSESION'),`Thesis_in_Sent` = (SELECT COUNT(tblborroweddetails.thesis_id) FROM tblborroweddetails WHERE status = 'SENT'),`Cleared_Payment` = (SELECT COUNT(tblborroweddetails.thesis_id) FROM tblborroweddetails WHERE status = 'CLEARED'),`Overdue` = (SELECT COUNT(tblborroweddetails.thesis_id) FROM tblborroweddetails WHERE status = 'OVERDUE'),`Date` = curdate() WHERE ID =2;"
            comm.ExecuteNonQuery()
            With Me.TRMSReportViewer.LocalReport

                .ReportPath = "C:\Users\Sarah\source\repos\UCC-TRMS\UCC-TRMS\TRMSReport.rdlc"
                .DataSources.Clear()

            End With

            Dim dsr As New DataSet1

            cmd1 = conn.CreateCommand()
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "SELECT * FROM tblreport"
            cmd1.ExecuteNonQuery()

            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd1)
            adapter.Fill(dsr.Tables("tblreport"))


            conn.Close()


            rptDst = New ReportDataSource("DataSet1", dsr.Tables("tblreport"))
            TRMSReportViewer.LocalReport.DataSources.Add(rptDst)
            TRMSReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            TRMSReportViewer.ZoomMode = ZoomMode.Percent
            TRMSReportViewer.ZoomPercent = 75
            TRMSReportViewer.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.TRMSReportViewer.RefreshReport()
    End Sub
    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = DateTime.Now.AddDays(-3)
        dtpTo.Value = DateTime.Now

         report()

        Me.TRMSReportViewer.RefreshReport()
    End Sub

    Private Sub btnSearchDate_Click(sender As Object, e As EventArgs) Handles btnSearchDate.Click
        Try
            Dim from, to1 As String
            from = dtpFrom.Value.ToString("yyyy-dd-MM")
            to1 = dtpTo.Value.ToString("yyyy-dd-MM")
            conn.Open()
            comm = conn.CreateCommand()
            comm.CommandType = CommandType.Text
            comm.CommandText = "UPDATE tblreport SET`Student_Registered` = (SELECT COUNT(*) FROM tblstudents WHERE tblstudents.dateReg BETWEEN '" & from & "' AND '" & to1 & "'),`Number_of_thesis` = (SELECT COUNT(*) FROM tblthesis),`Borrowed_Hardcopy` = (SELECT COUNT(*) FROM tblborroweddetails WHERE status = 'IN POSSESION' AND tblborroweddetails.dateissue BETWEEN '" & from & "' AND '" & to1 & "'),`Thesis_in_Sent` = (SELECT COUNT(*) FROM tblborroweddetails WHERE status ='SENT' AND tblborroweddetails.dateissue BETWEEN '" & from & "' AND '" & to1 & "'), `Cleared_Payment` = (SELECT COUNT(tblborroweddetails.thesis_id) FROM tblborroweddetails WHERE status = 'CLEARED' AND tblborroweddetails.dateissue BETWEEN '" & from & "' AND '" & to1 & "'),`Overdue` = (SELECT COUNT(tblborroweddetails.thesis_id) FROM tblborroweddetails WHERE status = 'OVERDUE' AND tblborroweddetails.dateissue BETWEEN '" & from & "' AND '" & to1 & "'),`Date` = curdate() WHERE ID =1;"
            comm.ExecuteNonQuery()
            With Me.TRMSReportViewer.LocalReport

                .ReportPath = "C:\Users\Sarah\source\repos\UCC-TRMS\UCC-TRMS\TRMSReport.rdlc"
                .DataSources.Clear()

            End With

            Dim dsr As New DataSet1

            cmd1 = conn.CreateCommand()
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "SELECT * FROM tblreport"
            cmd1.ExecuteNonQuery()

            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd1)
            adapter.Fill(dsr.Tables("tblreport"))


            conn.Close()


            rptDst = New ReportDataSource("DataSet1", dsr.Tables("tblreport"))
            TRMSReportViewer.LocalReport.DataSources.Add(rptDst)
            TRMSReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            TRMSReportViewer.ZoomMode = ZoomMode.Percent
            TRMSReportViewer.ZoomPercent = 75
            TRMSReportViewer.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.TRMSReportViewer.RefreshReport()

    End Sub
End Class