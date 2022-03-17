<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbEnterCredentials = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 3
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(237, 306)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(237, 306)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.btnLogin)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.tbEnterCredentials)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(237, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(330, 306)
        Me.Guna2Panel2.TabIndex = 1
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
        Me.btnLogin.Location = New System.Drawing.Point(137, 201)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.PressedState.ImageSize = New System.Drawing.Size(38, 48)
        Me.btnLogin.PressedState.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(52, 60)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Tag = ""
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(3, 306)
        Me.Guna2Panel3.TabIndex = 1
        '
        'tbEnterCredentials
        '
        Me.tbEnterCredentials.BackColor = System.Drawing.Color.Transparent
        Me.tbEnterCredentials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tbEnterCredentials.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbEnterCredentials.BorderThickness = 0
        Me.tbEnterCredentials.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEnterCredentials.DefaultText = ""
        Me.tbEnterCredentials.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEnterCredentials.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEnterCredentials.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEnterCredentials.DisabledState.Parent = Me.tbEnterCredentials
        Me.tbEnterCredentials.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEnterCredentials.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbEnterCredentials.FocusedState.Parent = Me.tbEnterCredentials
        Me.tbEnterCredentials.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbEnterCredentials.HoverState.Parent = Me.tbEnterCredentials
        Me.tbEnterCredentials.Location = New System.Drawing.Point(47, 117)
        Me.tbEnterCredentials.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tbEnterCredentials.Name = "tbEnterCredentials"
        Me.tbEnterCredentials.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEnterCredentials.PlaceholderForeColor = System.Drawing.Color.Transparent
        Me.tbEnterCredentials.PlaceholderText = "Enter Credential"
        Me.tbEnterCredentials.SelectedText = ""
        Me.tbEnterCredentials.ShadowDecoration.BorderRadius = 1
        Me.tbEnterCredentials.ShadowDecoration.Enabled = True
        Me.tbEnterCredentials.ShadowDecoration.Parent = Me.tbEnterCredentials
        Me.tbEnterCredentials.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.tbEnterCredentials.Size = New System.Drawing.Size(239, 60)
        Me.tbEnterCredentials.TabIndex = 0
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 306)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents tbEnterCredentials As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2ImageButton
End Class
