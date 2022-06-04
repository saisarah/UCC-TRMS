<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblInPosses = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSent = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBorrowers = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblThesisToday = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblBorrower = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 3
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1190, 578)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(865, 563)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(865, 58)
        Me.Panel3.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Location = New System.Drawing.Point(17, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(830, 2)
        Me.Panel4.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Top 10 Recently Borrowed Thesis"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Panel1.Location = New System.Drawing.Point(883, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 299)
        Me.Panel1.TabIndex = 2
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.Label9)
        Me.Guna2Panel4.Controls.Add(Me.lblInPosses)
        Me.Guna2Panel4.Location = New System.Drawing.Point(151, 152)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel4.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(9, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 44)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "IN POSSESION"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInPosses
        '
        Me.lblInPosses.BackColor = System.Drawing.Color.Transparent
        Me.lblInPosses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInPosses.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInPosses.ForeColor = System.Drawing.Color.White
        Me.lblInPosses.Location = New System.Drawing.Point(0, 0)
        Me.lblInPosses.Name = "lblInPosses"
        Me.lblInPosses.Size = New System.Drawing.Size(140, 140)
        Me.lblInPosses.TabIndex = 15
        Me.lblInPosses.Text = "0"
        Me.lblInPosses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.Label6)
        Me.Guna2Panel3.Controls.Add(Me.lblSent)
        Me.Guna2Panel3.Location = New System.Drawing.Point(6, 152)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "DOCUMENTS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "SENT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSent
        '
        Me.lblSent.BackColor = System.Drawing.Color.Transparent
        Me.lblSent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSent.ForeColor = System.Drawing.Color.White
        Me.lblSent.Location = New System.Drawing.Point(0, 0)
        Me.lblSent.Name = "lblSent"
        Me.lblSent.Size = New System.Drawing.Size(140, 140)
        Me.lblSent.TabIndex = 13
        Me.lblSent.Text = "0"
        Me.lblSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.lblBorrowers)
        Me.Guna2Panel2.Location = New System.Drawing.Point(151, 6)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 27)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "BORROWERS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorrowers
        '
        Me.lblBorrowers.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBorrowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowers.ForeColor = System.Drawing.Color.White
        Me.lblBorrowers.Location = New System.Drawing.Point(0, 0)
        Me.lblBorrowers.Name = "lblBorrowers"
        Me.lblBorrowers.Size = New System.Drawing.Size(140, 140)
        Me.lblBorrowers.TabIndex = 13
        Me.lblBorrowers.Text = "0"
        Me.lblBorrowers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guna2Panel5.Controls.Add(Me.Label4)
        Me.Guna2Panel5.Controls.Add(Me.Label2)
        Me.Guna2Panel5.Controls.Add(Me.lblThesisToday)
        Me.Guna2Panel5.Location = New System.Drawing.Point(6, 6)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel5.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "AS OF TODAY"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "THESIS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblThesisToday
        '
        Me.lblThesisToday.BackColor = System.Drawing.Color.Transparent
        Me.lblThesisToday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblThesisToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThesisToday.ForeColor = System.Drawing.Color.White
        Me.lblThesisToday.Location = New System.Drawing.Point(0, 0)
        Me.lblThesisToday.Name = "lblThesisToday"
        Me.lblThesisToday.Size = New System.Drawing.Size(140, 140)
        Me.lblThesisToday.TabIndex = 11
        Me.lblThesisToday.Text = "0"
        Me.lblThesisToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(5, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(820, 425)
        Me.Panel5.TabIndex = 18
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Panel6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Panel5)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(17, 64)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 40
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(830, 490)
        Me.Guna2ShadowPanel1.TabIndex = 24
        '
        'lblBorrower
        '
        Me.lblBorrower.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBorrower.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrower.ForeColor = System.Drawing.Color.White
        Me.lblBorrower.Location = New System.Drawing.Point(692, 17)
        Me.lblBorrower.Name = "lblBorrower"
        Me.lblBorrower.Size = New System.Drawing.Size(251, 21)
        Me.lblBorrower.TabIndex = 13
        Me.lblBorrower.Text = "BORROWER"
        Me.lblBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(95, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(313, 21)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "TITLE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCode
        '
        Me.lblCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.White
        Me.lblCode.Location = New System.Drawing.Point(-97, 17)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(161, 21)
        Me.lblCode.TabIndex = 6
        Me.lblCode.Text = "CODE"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(434, 17)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(232, 21)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "DATE ISSUED"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel6.Controls.Add(Me.lblBorrower)
        Me.Guna2Panel6.Controls.Add(Me.lblTitle)
        Me.Guna2Panel6.Controls.Add(Me.lblCode)
        Me.Guna2Panel6.Controls.Add(Me.lblDate)
        Me.Guna2Panel6.CustomBorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel6.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(5, 5)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(820, 55)
        Me.Guna2Panel6.TabIndex = 19
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 578)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard"
        Me.Text = "dashboard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblThesisToday As Label
    Friend WithEvents lblBorrowers As Label
    Friend WithEvents lblInPosses As Label
    Friend WithEvents lblSent As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Public WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblBorrower As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents lblDate As Label
End Class
