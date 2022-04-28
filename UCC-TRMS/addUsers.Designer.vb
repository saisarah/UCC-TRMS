<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addUsers))
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAddUserClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSaveUser = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderRadius = 10
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Location = New System.Drawing.Point(308, 121)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(87, 34)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(500, 10)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 35)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Panel2.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel2.Controls.Add(Me.btnAddUserClose)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.tbName)
        Me.Guna2Panel2.Controls.Add(Me.btnSaveUser)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(500, 167)
        Me.Guna2Panel2.TabIndex = 3
        '
        'btnAddUserClose
        '
        Me.btnAddUserClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddUserClose.CheckedState.Parent = Me.btnAddUserClose
        Me.btnAddUserClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUserClose.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnAddUserClose.HoverState.Parent = Me.btnAddUserClose
        Me.btnAddUserClose.Image = CType(resources.GetObject("btnAddUserClose.Image"), System.Drawing.Image)
        Me.btnAddUserClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnAddUserClose.Location = New System.Drawing.Point(458, 15)
        Me.btnAddUserClose.Name = "btnAddUserClose"
        Me.btnAddUserClose.PressedState.Parent = Me.btnAddUserClose
        Me.btnAddUserClose.Size = New System.Drawing.Size(42, 15)
        Me.btnAddUserClose.TabIndex = 13
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Gray
        Me.Guna2Panel3.Location = New System.Drawing.Point(16, 62)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(467, 1)
        Me.Guna2Panel3.TabIndex = 12
        '
        'tbName
        '
        Me.tbName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbName.BackColor = System.Drawing.Color.Transparent
        Me.tbName.BorderRadius = 5
        Me.tbName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbName.DefaultText = ""
        Me.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbName.DisabledState.Parent = Me.tbName
        Me.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbName.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbName.FocusedState.Parent = Me.tbName
        Me.tbName.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbName.HoverState.Parent = Me.tbName
        Me.tbName.Location = New System.Drawing.Point(13, 78)
        Me.tbName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbName.Name = "tbName"
        Me.tbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbName.PlaceholderText = "John"
        Me.tbName.SelectedText = ""
        Me.tbName.ShadowDecoration.Parent = Me.tbName
        Me.tbName.Size = New System.Drawing.Size(475, 36)
        Me.tbName.TabIndex = 4
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveUser.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveUser.BorderRadius = 10
        Me.btnSaveUser.CheckedState.Parent = Me.btnSaveUser
        Me.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveUser.CustomImages.Parent = Me.btnSaveUser
        Me.btnSaveUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSaveUser.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUser.ForeColor = System.Drawing.Color.White
        Me.btnSaveUser.HoverState.Parent = Me.btnSaveUser
        Me.btnSaveUser.Location = New System.Drawing.Point(401, 121)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.ShadowDecoration.Parent = Me.btnSaveUser
        Me.btnSaveUser.Size = New System.Drawing.Size(87, 34)
        Me.btnSaveUser.TabIndex = 3
        Me.btnSaveUser.Text = "Save"
        '
        'addUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 167)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addUsers"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddUserClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSaveUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class
