<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCloseLogin = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.cbCredentials = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel4.BorderRadius = 20
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(632, 10)
        Me.Guna2Panel4.TabIndex = 15
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 10)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(632, 239)
        Me.Guna2GradientPanel1.TabIndex = 16
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BackColor = System.Drawing.Color.White
        Me.Guna2GradientPanel2.Controls.Add(Me.Panel1)
        Me.Guna2GradientPanel2.Controls.Add(Me.btnCloseLogin)
        Me.Guna2GradientPanel2.Controls.Add(Me.cbCredentials)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2GradientPanel2.Controls.Add(Me.btnLogin)
        Me.Guna2GradientPanel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2GradientPanel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(632, 239)
        Me.Guna2GradientPanel2.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(262, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 195)
        Me.Panel1.TabIndex = 19
        '
        'btnCloseLogin
        '
        Me.btnCloseLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseLogin.CheckedState.Parent = Me.btnCloseLogin
        Me.btnCloseLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseLogin.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnCloseLogin.HoverState.Parent = Me.btnCloseLogin
        Me.btnCloseLogin.Image = CType(resources.GetObject("btnCloseLogin.Image"), System.Drawing.Image)
        Me.btnCloseLogin.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnCloseLogin.Location = New System.Drawing.Point(605, 6)
        Me.btnCloseLogin.Name = "btnCloseLogin"
        Me.btnCloseLogin.PressedState.Parent = Me.btnCloseLogin
        Me.btnCloseLogin.Size = New System.Drawing.Size(15, 15)
        Me.btnCloseLogin.TabIndex = 18
        '
        'cbCredentials
        '
        Me.cbCredentials.BackColor = System.Drawing.Color.Transparent
        Me.cbCredentials.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCredentials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCredentials.FocusedColor = System.Drawing.Color.Empty
        Me.cbCredentials.FocusedState.Parent = Me.cbCredentials
        Me.cbCredentials.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCredentials.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCredentials.FormattingEnabled = True
        Me.cbCredentials.HoverState.Parent = Me.cbCredentials
        Me.cbCredentials.ItemHeight = 30
        Me.cbCredentials.ItemsAppearance.Parent = Me.cbCredentials
        Me.cbCredentials.Location = New System.Drawing.Point(303, 61)
        Me.cbCredentials.Name = "cbCredentials"
        Me.cbCredentials.ShadowDecoration.Parent = Me.cbCredentials
        Me.cbCredentials.Size = New System.Drawing.Size(288, 36)
        Me.cbCredentials.TabIndex = 17
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(37, 27)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(195, 172)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 15
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.HoverState.Image = CType(resources.GetObject("btnLogin.HoverState.Image"), System.Drawing.Image)
        Me.btnLogin.HoverState.ImageSize = New System.Drawing.Size(39, 49)
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageSize = New System.Drawing.Size(39, 49)
        Me.btnLogin.Location = New System.Drawing.Point(422, 129)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.PressedState.ImageSize = New System.Drawing.Size(38, 48)
        Me.btnLogin.PressedState.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(39, 49)
        Me.btnLogin.TabIndex = 16
        Me.btnLogin.Tag = ""
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 249)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnCloseLogin As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents cbCredentials As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Panel1 As Panel
End Class
