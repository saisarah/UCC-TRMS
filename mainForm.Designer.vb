<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.pnlSide.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlSide.Size = New System.Drawing.Size(158, 578)
        Me.pnlSide.TabIndex = 0
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnUsers.CheckedState.Parent = Me.btnUsers
        Me.btnUsers.CustomImages.Parent = Me.btnUsers
        Me.btnUsers.FillColor = System.Drawing.Color.Transparent
        Me.btnUsers.FillColor2 = System.Drawing.Color.Transparent
        Me.btnUsers.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.HoverState.Parent = Me.btnUsers
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnUsers.Location = New System.Drawing.Point(0, 479)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.PressedColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnUsers.ShadowDecoration.Parent = Me.btnUsers
        Me.btnUsers.Size = New System.Drawing.Size(153, 45)
        Me.btnUsers.TabIndex = 7
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Transparent
        Me.btnReports.CheckedState.Parent = Me.btnReports
        Me.btnReports.CustomImages.Parent = Me.btnReports
        Me.btnReports.FillColor = System.Drawing.Color.Transparent
        Me.btnReports.FillColor2 = System.Drawing.Color.Transparent
        Me.btnReports.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.HoverState.Parent = Me.btnReports
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnReports.Location = New System.Drawing.Point(0, 430)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.PressedColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnReports.ShadowDecoration.Parent = Me.btnReports
        Me.btnReports.Size = New System.Drawing.Size(153, 45)
        Me.btnReports.TabIndex = 6
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnIssuing
        '
        Me.btnIssuing.BackColor = System.Drawing.Color.Transparent
        Me.btnIssuing.CheckedState.Parent = Me.btnIssuing
        Me.btnIssuing.CustomImages.Parent = Me.btnIssuing
        Me.btnIssuing.FillColor = System.Drawing.Color.Transparent
        Me.btnIssuing.FillColor2 = System.Drawing.Color.Transparent
        Me.btnIssuing.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssuing.ForeColor = System.Drawing.Color.White
        Me.btnIssuing.HoverState.Parent = Me.btnIssuing
        Me.btnIssuing.Image = CType(resources.GetObject("btnIssuing.Image"), System.Drawing.Image)
        Me.btnIssuing.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIssuing.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnIssuing.Location = New System.Drawing.Point(0, 383)
        Me.btnIssuing.Name = "btnIssuing"
        Me.btnIssuing.PressedColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnIssuing.ShadowDecoration.Parent = Me.btnIssuing
        Me.btnIssuing.Size = New System.Drawing.Size(153, 45)
        Me.btnIssuing.TabIndex = 5
        Me.btnIssuing.Text = "Issuing"
        Me.btnIssuing.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnBorrowers
        '
        Me.btnBorrowers.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrowers.CheckedState.Parent = Me.btnBorrowers
        Me.btnBorrowers.CustomImages.Parent = Me.btnBorrowers
        Me.btnBorrowers.FillColor = System.Drawing.Color.Transparent
        Me.btnBorrowers.FillColor2 = System.Drawing.Color.Transparent
        Me.btnBorrowers.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowers.ForeColor = System.Drawing.Color.White
        Me.btnBorrowers.HoverState.Parent = Me.btnBorrowers
        Me.btnBorrowers.Image = CType(resources.GetObject("btnBorrowers.Image"), System.Drawing.Image)
        Me.btnBorrowers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBorrowers.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnBorrowers.Location = New System.Drawing.Point(0, 335)
        Me.btnBorrowers.Name = "btnBorrowers"
        Me.btnBorrowers.PressedColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBorrowers.ShadowDecoration.Parent = Me.btnBorrowers
        Me.btnBorrowers.Size = New System.Drawing.Size(153, 45)
        Me.btnBorrowers.TabIndex = 4
        Me.btnBorrowers.Text = "Borrowers"
        Me.btnBorrowers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnThesis
        '
        Me.btnThesis.BackColor = System.Drawing.Color.Transparent
        Me.btnThesis.CheckedState.Parent = Me.btnThesis
        Me.btnThesis.CustomImages.Parent = Me.btnThesis
        Me.btnThesis.FillColor = System.Drawing.Color.Transparent
        Me.btnThesis.FillColor2 = System.Drawing.Color.Transparent
        Me.btnThesis.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThesis.ForeColor = System.Drawing.Color.White
        Me.btnThesis.HoverState.Parent = Me.btnThesis
        Me.btnThesis.Image = CType(resources.GetObject("btnThesis.Image"), System.Drawing.Image)
        Me.btnThesis.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnThesis.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnThesis.Location = New System.Drawing.Point(0, 286)
        Me.btnThesis.Name = "btnThesis"
        Me.btnThesis.PressedColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnThesis.ShadowDecoration.Parent = Me.btnThesis
        Me.btnThesis.Size = New System.Drawing.Size(153, 45)
        Me.btnThesis.TabIndex = 3
        Me.btnThesis.Text = "Thesis"
        Me.btnThesis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FillColor2 = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 237)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(153, 45)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(158, 234)
        Me.Guna2Panel5.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 228)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(158, 0)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.ShadowDecoration.Parent = Me.pnlBody
        Me.pnlBody.Size = New System.Drawing.Size(516, 578)
        Me.pnlBody.TabIndex = 0
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlSide.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
