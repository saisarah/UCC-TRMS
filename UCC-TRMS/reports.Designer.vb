<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reports))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TRMSReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnSearchDate = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.EasyHTMLReports1 = New KimToo.EasyHTMLReports(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.TRMSReportViewer)
        Me.Guna2Panel1.Controls.Add(Me.btnSearchDate)
        Me.Guna2Panel1.Controls.Add(Me.dtpTo)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.dtpFrom)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1190, 706)
        Me.Guna2Panel1.TabIndex = 3
        '
        'TRMSReportViewer
        '
        Me.TRMSReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TRMSReportViewer.LocalReport.ReportEmbeddedResource = "UCC_TRMS.TRMSReport.rdlc"
        Me.TRMSReportViewer.Location = New System.Drawing.Point(108, 78)
        Me.TRMSReportViewer.Name = "TRMSReportViewer"
        Me.TRMSReportViewer.ServerReport.BearerToken = Nothing
        Me.TRMSReportViewer.Size = New System.Drawing.Size(919, 511)
        Me.TRMSReportViewer.TabIndex = 25
        '
        'btnSearchDate
        '
        Me.btnSearchDate.BorderRadius = 5
        Me.btnSearchDate.CheckedState.Parent = Me.btnSearchDate
        Me.btnSearchDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchDate.CustomImages.Parent = Me.btnSearchDate
        Me.btnSearchDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSearchDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchDate.ForeColor = System.Drawing.Color.White
        Me.btnSearchDate.HoverState.Parent = Me.btnSearchDate
        Me.btnSearchDate.Image = CType(resources.GetObject("btnSearchDate.Image"), System.Drawing.Image)
        Me.btnSearchDate.Location = New System.Drawing.Point(649, 22)
        Me.btnSearchDate.Name = "btnSearchDate"
        Me.btnSearchDate.ShadowDecoration.Parent = Me.btnSearchDate
        Me.btnSearchDate.Size = New System.Drawing.Size(89, 36)
        Me.btnSearchDate.TabIndex = 23
        Me.btnSearchDate.Text = "Search"
        '
        'dtpTo
        '
        Me.dtpTo.BorderRadius = 5
        Me.dtpTo.CheckedState.Parent = Me.dtpTo
        Me.dtpTo.CustomFormat = "yyyy-dd-MM"
        Me.dtpTo.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpTo.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.ForeColor = System.Drawing.Color.White
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTo.HoverState.Parent = Me.dtpTo
        Me.dtpTo.Location = New System.Drawing.Point(443, 22)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShadowDecoration.Parent = Me.dtpTo
        Me.dtpTo.Size = New System.Drawing.Size(199, 36)
        Me.dtpTo.TabIndex = 22
        Me.dtpTo.Value = New Date(2022, 3, 9, 17, 56, 30, 651)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 34)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "To:"
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderRadius = 5
        Me.dtpFrom.CheckedState.Parent = Me.dtpFrom
        Me.dtpFrom.CustomFormat = "yyyy-dd-MM"
        Me.dtpFrom.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpFrom.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.ForeColor = System.Drawing.Color.White
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFrom.HoverState.Parent = Me.dtpFrom
        Me.dtpFrom.Location = New System.Drawing.Point(182, 22)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShadowDecoration.Parent = Me.dtpFrom
        Me.dtpFrom.Size = New System.Drawing.Size(199, 36)
        Me.dtpFrom.TabIndex = 20
        Me.dtpFrom.Value = New Date(2022, 3, 9, 17, 56, 30, 651)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 34)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "From:"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 3
        Me.Guna2Elipse1.TargetControl = Me
        '
        'EasyHTMLReports1
        '
        Me.EasyHTMLReports1.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.EasyHTMLReports1.AlternativeRowGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.EasyHTMLReports1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.EasyHTMLReports1.HeaderFontColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.EasyHTMLReports1.HeaderGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.EasyHTMLReports1.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EasyHTMLReports1.RowDefaultFontColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.EasyHTMLReports1.RowDefaultGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
        '
        'reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 706)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reports"
        Me.Text = "reports"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnSearchDate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EasyHTMLReports1 As KimToo.EasyHTMLReports
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend WithEvents TRMSReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
