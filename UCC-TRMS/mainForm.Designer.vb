﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlSide = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnReports = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnIssuing = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBorrowers = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnThesis = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlBody = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSide.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBody.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 3
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.pnlSide.Controls.Add(Me.btnUsers)
        Me.pnlSide.Controls.Add(Me.btnReports)
        Me.pnlSide.Controls.Add(Me.btnIssuing)
        Me.pnlSide.Controls.Add(Me.btnBorrowers)
        Me.pnlSide.Controls.Add(Me.btnThesis)
        Me.pnlSide.Controls.Add(Me.btnDashboard)
        Me.pnlSide.Controls.Add(Me.Guna2Panel5)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.ShadowDecoration.Parent = Me.pnlSide
        Me.pnlSide.Size = New System.Drawing.Size(248, 578)
        Me.pnlSide.TabIndex = 0
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnUsers.CheckedState.Parent = Me.btnUsers
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.CustomImages.Parent = Me.btnUsers
        Me.btnUsers.FillColor = System.Drawing.Color.Transparent
        Me.btnUsers.FillColor2 = System.Drawing.Color.Transparent
        Me.btnUsers.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUsers.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUsers.HoverState.Parent = Me.btnUsers
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnUsers.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnUsers.Location = New System.Drawing.Point(0, 520)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.PressedColor = System.Drawing.Color.Transparent
        Me.btnUsers.ShadowDecoration.Parent = Me.btnUsers
        Me.btnUsers.Size = New System.Drawing.Size(248, 50)
        Me.btnUsers.TabIndex = 7
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Transparent
        Me.btnReports.CheckedState.Parent = Me.btnReports
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.CustomImages.Parent = Me.btnReports
        Me.btnReports.FillColor = System.Drawing.Color.Transparent
        Me.btnReports.FillColor2 = System.Drawing.Color.Transparent
        Me.btnReports.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReports.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReports.HoverState.Parent = Me.btnReports
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnReports.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnReports.Location = New System.Drawing.Point(0, 469)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.PressedColor = System.Drawing.Color.Transparent
        Me.btnReports.ShadowDecoration.Parent = Me.btnReports
        Me.btnReports.Size = New System.Drawing.Size(248, 50)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnIssuing
        '
        Me.btnIssuing.BackColor = System.Drawing.Color.Transparent
        Me.btnIssuing.CheckedState.Parent = Me.btnIssuing
        Me.btnIssuing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssuing.CustomImages.Parent = Me.btnIssuing
        Me.btnIssuing.FillColor = System.Drawing.Color.Transparent
        Me.btnIssuing.FillColor2 = System.Drawing.Color.Transparent
        Me.btnIssuing.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.btnIssuing.ForeColor = System.Drawing.Color.White
        Me.btnIssuing.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIssuing.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIssuing.HoverState.Parent = Me.btnIssuing
        Me.btnIssuing.Image = CType(resources.GetObject("btnIssuing.Image"), System.Drawing.Image)
        Me.btnIssuing.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIssuing.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnIssuing.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnIssuing.Location = New System.Drawing.Point(0, 420)
        Me.btnIssuing.Name = "btnIssuing"
        Me.btnIssuing.PressedColor = System.Drawing.Color.Transparent
        Me.btnIssuing.ShadowDecoration.Parent = Me.btnIssuing
        Me.btnIssuing.Size = New System.Drawing.Size(248, 50)
        Me.btnIssuing.TabIndex = 5
        Me.btnIssuing.Text = "Issuing"
        Me.btnIssuing.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIssuing.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnBorrowers
        '
        Me.btnBorrowers.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrowers.CheckedState.Parent = Me.btnBorrowers
        Me.btnBorrowers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowers.CustomImages.Parent = Me.btnBorrowers
        Me.btnBorrowers.FillColor = System.Drawing.Color.Transparent
        Me.btnBorrowers.FillColor2 = System.Drawing.Color.Transparent
        Me.btnBorrowers.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.btnBorrowers.ForeColor = System.Drawing.Color.White
        Me.btnBorrowers.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBorrowers.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBorrowers.HoverState.Parent = Me.btnBorrowers
        Me.btnBorrowers.Image = CType(resources.GetObject("btnBorrowers.Image"), System.Drawing.Image)
        Me.btnBorrowers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBorrowers.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnBorrowers.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnBorrowers.Location = New System.Drawing.Point(0, 373)
        Me.btnBorrowers.Name = "btnBorrowers"
        Me.btnBorrowers.PressedColor = System.Drawing.Color.Transparent
        Me.btnBorrowers.ShadowDecoration.Parent = Me.btnBorrowers
        Me.btnBorrowers.Size = New System.Drawing.Size(248, 50)
        Me.btnBorrowers.TabIndex = 4
        Me.btnBorrowers.Text = "Borrowers"
        Me.btnBorrowers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBorrowers.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnThesis
        '
        Me.btnThesis.BackColor = System.Drawing.Color.Transparent
        Me.btnThesis.CheckedState.Parent = Me.btnThesis
        Me.btnThesis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThesis.CustomImages.Parent = Me.btnThesis
        Me.btnThesis.FillColor = System.Drawing.Color.Transparent
        Me.btnThesis.FillColor2 = System.Drawing.Color.Transparent
        Me.btnThesis.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.btnThesis.ForeColor = System.Drawing.Color.White
        Me.btnThesis.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnThesis.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnThesis.HoverState.Parent = Me.btnThesis
        Me.btnThesis.Image = CType(resources.GetObject("btnThesis.Image"), System.Drawing.Image)
        Me.btnThesis.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnThesis.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnThesis.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnThesis.Location = New System.Drawing.Point(0, 325)
        Me.btnThesis.Name = "btnThesis"
        Me.btnThesis.PressedColor = System.Drawing.Color.Transparent
        Me.btnThesis.ShadowDecoration.Parent = Me.btnThesis
        Me.btnThesis.Size = New System.Drawing.Size(248, 50)
        Me.btnThesis.TabIndex = 3
        Me.btnThesis.Text = "Thesis"
        Me.btnThesis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnThesis.TextOffset = New System.Drawing.Point(40, 0)
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FillColor2 = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Poppins", 11.0!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDashboard.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 276)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.PressedColor = System.Drawing.Color.Transparent
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(248, 50)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.TextOffset = New System.Drawing.Point(40, 0)
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(248, 280)
        Me.Guna2Panel5.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.pnlTop)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(248, 0)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.ShadowDecoration.Parent = Me.pnlBody
        Me.pnlBody.Size = New System.Drawing.Size(891, 578)
        Me.pnlBody.TabIndex = 0
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.White
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.ShadowDecoration.Parent = Me.pnlTop
        Me.pnlTop.Size = New System.Drawing.Size(891, 134)
        Me.pnlTop.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(626, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = """dddd, d MMMM yyyy  |  hh:mm:ss tt"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "user"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label 1"
        '
        'Timer1
        '
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thesis Record Management System"
        Me.pnlSide.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlSide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnThesis As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBorrowers As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnIssuing As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
