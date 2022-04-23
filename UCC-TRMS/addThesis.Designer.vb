<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addThesis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addThesis))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddThesisClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbPanel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbMembers = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbTeam = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbLimitation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbScope = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbObjectives = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSaveThesis = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(500, 10)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.Guna2Panel2.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel2.Controls.Add(Me.btnAddThesisClose)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.cbCategory)
        Me.Guna2Panel2.Controls.Add(Me.tbPanel)
        Me.Guna2Panel2.Controls.Add(Me.tbMembers)
        Me.Guna2Panel2.Controls.Add(Me.tbTeam)
        Me.Guna2Panel2.Controls.Add(Me.tbLimitation)
        Me.Guna2Panel2.Controls.Add(Me.tbScope)
        Me.Guna2Panel2.Controls.Add(Me.tbObjectives)
        Me.Guna2Panel2.Controls.Add(Me.tbTitle)
        Me.Guna2Panel2.Controls.Add(Me.btnSaveThesis)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 10)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(500, 384)
        Me.Guna2Panel2.TabIndex = 1
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
        Me.btnUpdate.Location = New System.Drawing.Point(308, 340)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(87, 34)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        '
        'btnAddThesisClose
        '
        Me.btnAddThesisClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddThesisClose.CheckedState.Parent = Me.btnAddThesisClose
        Me.btnAddThesisClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddThesisClose.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnAddThesisClose.HoverState.Parent = Me.btnAddThesisClose
        Me.btnAddThesisClose.Image = CType(resources.GetObject("btnAddThesisClose.Image"), System.Drawing.Image)
        Me.btnAddThesisClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnAddThesisClose.Location = New System.Drawing.Point(455, 6)
        Me.btnAddThesisClose.Name = "btnAddThesisClose"
        Me.btnAddThesisClose.PressedState.Parent = Me.btnAddThesisClose
        Me.btnAddThesisClose.Size = New System.Drawing.Size(42, 15)
        Me.btnAddThesisClose.TabIndex = 13
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
        'cbCategory
        '
        Me.cbCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cbCategory.BorderRadius = 5
        Me.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cbCategory.FocusedState.Parent = Me.cbCategory
        Me.cbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.HoverState.Parent = Me.cbCategory
        Me.cbCategory.ItemHeight = 30
        Me.cbCategory.Items.AddRange(New Object() {"WEB DEVELOPMENT", "APPLICATION DEVELOPMENT", "MOBILE DEVELOPMENT", "GAME DEVELOPMENT"})
        Me.cbCategory.ItemsAppearance.Parent = Me.cbCategory
        Me.cbCategory.Location = New System.Drawing.Point(247, 298)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.ShadowDecoration.Parent = Me.cbCategory
        Me.cbCategory.Size = New System.Drawing.Size(241, 36)
        Me.cbCategory.TabIndex = 11
        '
        'tbPanel
        '
        Me.tbPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPanel.BackColor = System.Drawing.Color.Transparent
        Me.tbPanel.BorderRadius = 5
        Me.tbPanel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPanel.DefaultText = ""
        Me.tbPanel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPanel.DisabledState.Parent = Me.tbPanel
        Me.tbPanel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPanel.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbPanel.FocusedState.Parent = Me.tbPanel
        Me.tbPanel.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbPanel.HoverState.Parent = Me.tbPanel
        Me.tbPanel.Location = New System.Drawing.Point(13, 298)
        Me.tbPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPanel.Name = "tbPanel"
        Me.tbPanel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPanel.PlaceholderText = "Panel"
        Me.tbPanel.SelectedText = ""
        Me.tbPanel.ShadowDecoration.Parent = Me.tbPanel
        Me.tbPanel.Size = New System.Drawing.Size(226, 36)
        Me.tbPanel.TabIndex = 10
        '
        'tbMembers
        '
        Me.tbMembers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMembers.BackColor = System.Drawing.Color.Transparent
        Me.tbMembers.BorderRadius = 5
        Me.tbMembers.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMembers.DefaultText = ""
        Me.tbMembers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbMembers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbMembers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbMembers.DisabledState.Parent = Me.tbMembers
        Me.tbMembers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbMembers.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbMembers.FocusedState.Parent = Me.tbMembers
        Me.tbMembers.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbMembers.HoverState.Parent = Me.tbMembers
        Me.tbMembers.Location = New System.Drawing.Point(247, 254)
        Me.tbMembers.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMembers.Name = "tbMembers"
        Me.tbMembers.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMembers.PlaceholderText = "Members"
        Me.tbMembers.SelectedText = ""
        Me.tbMembers.ShadowDecoration.Parent = Me.tbMembers
        Me.tbMembers.Size = New System.Drawing.Size(241, 36)
        Me.tbMembers.TabIndex = 9
        '
        'tbTeam
        '
        Me.tbTeam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTeam.BackColor = System.Drawing.Color.Transparent
        Me.tbTeam.BorderRadius = 5
        Me.tbTeam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTeam.DefaultText = ""
        Me.tbTeam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTeam.DisabledState.Parent = Me.tbTeam
        Me.tbTeam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTeam.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbTeam.FocusedState.Parent = Me.tbTeam
        Me.tbTeam.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbTeam.HoverState.Parent = Me.tbTeam
        Me.tbTeam.Location = New System.Drawing.Point(13, 254)
        Me.tbTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTeam.Name = "tbTeam"
        Me.tbTeam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTeam.PlaceholderText = "Team Name"
        Me.tbTeam.SelectedText = ""
        Me.tbTeam.ShadowDecoration.Parent = Me.tbTeam
        Me.tbTeam.Size = New System.Drawing.Size(226, 36)
        Me.tbTeam.TabIndex = 8
        '
        'tbLimitation
        '
        Me.tbLimitation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLimitation.BackColor = System.Drawing.Color.Transparent
        Me.tbLimitation.BorderRadius = 5
        Me.tbLimitation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLimitation.DefaultText = ""
        Me.tbLimitation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLimitation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLimitation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLimitation.DisabledState.Parent = Me.tbLimitation
        Me.tbLimitation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLimitation.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbLimitation.FocusedState.Parent = Me.tbLimitation
        Me.tbLimitation.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbLimitation.HoverState.Parent = Me.tbLimitation
        Me.tbLimitation.Location = New System.Drawing.Point(247, 210)
        Me.tbLimitation.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLimitation.Name = "tbLimitation"
        Me.tbLimitation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLimitation.PlaceholderText = "Limitation"
        Me.tbLimitation.SelectedText = ""
        Me.tbLimitation.ShadowDecoration.Parent = Me.tbLimitation
        Me.tbLimitation.Size = New System.Drawing.Size(241, 36)
        Me.tbLimitation.TabIndex = 7
        '
        'tbScope
        '
        Me.tbScope.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbScope.BackColor = System.Drawing.Color.Transparent
        Me.tbScope.BorderRadius = 5
        Me.tbScope.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbScope.DefaultText = ""
        Me.tbScope.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbScope.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbScope.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbScope.DisabledState.Parent = Me.tbScope
        Me.tbScope.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbScope.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbScope.FocusedState.Parent = Me.tbScope
        Me.tbScope.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbScope.HoverState.Parent = Me.tbScope
        Me.tbScope.Location = New System.Drawing.Point(13, 210)
        Me.tbScope.Margin = New System.Windows.Forms.Padding(4)
        Me.tbScope.Name = "tbScope"
        Me.tbScope.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbScope.PlaceholderText = "Scope"
        Me.tbScope.SelectedText = ""
        Me.tbScope.ShadowDecoration.Parent = Me.tbScope
        Me.tbScope.Size = New System.Drawing.Size(226, 36)
        Me.tbScope.TabIndex = 6
        '
        'tbObjectives
        '
        Me.tbObjectives.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbObjectives.BackColor = System.Drawing.Color.Transparent
        Me.tbObjectives.BorderRadius = 5
        Me.tbObjectives.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbObjectives.DefaultText = ""
        Me.tbObjectives.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbObjectives.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbObjectives.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbObjectives.DisabledState.Parent = Me.tbObjectives
        Me.tbObjectives.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbObjectives.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbObjectives.FocusedState.Parent = Me.tbObjectives
        Me.tbObjectives.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbObjectives.HoverState.Parent = Me.tbObjectives
        Me.tbObjectives.Location = New System.Drawing.Point(13, 122)
        Me.tbObjectives.Margin = New System.Windows.Forms.Padding(4)
        Me.tbObjectives.Multiline = True
        Me.tbObjectives.Name = "tbObjectives"
        Me.tbObjectives.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbObjectives.PlaceholderText = "Objectives"
        Me.tbObjectives.SelectedText = ""
        Me.tbObjectives.ShadowDecoration.Parent = Me.tbObjectives
        Me.tbObjectives.Size = New System.Drawing.Size(475, 80)
        Me.tbObjectives.TabIndex = 5
        '
        'tbTitle
        '
        Me.tbTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTitle.BackColor = System.Drawing.Color.Transparent
        Me.tbTitle.BorderRadius = 5
        Me.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTitle.DefaultText = ""
        Me.tbTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTitle.DisabledState.Parent = Me.tbTitle
        Me.tbTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTitle.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbTitle.FocusedState.Parent = Me.tbTitle
        Me.tbTitle.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbTitle.HoverState.Parent = Me.tbTitle
        Me.tbTitle.Location = New System.Drawing.Point(13, 78)
        Me.tbTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTitle.PlaceholderText = "Title"
        Me.tbTitle.SelectedText = ""
        Me.tbTitle.ShadowDecoration.Parent = Me.tbTitle
        Me.tbTitle.Size = New System.Drawing.Size(475, 36)
        Me.tbTitle.TabIndex = 4
        '
        'btnSaveThesis
        '
        Me.btnSaveThesis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveThesis.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveThesis.BorderRadius = 10
        Me.btnSaveThesis.CheckedState.Parent = Me.btnSaveThesis
        Me.btnSaveThesis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveThesis.CustomImages.Parent = Me.btnSaveThesis
        Me.btnSaveThesis.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSaveThesis.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveThesis.ForeColor = System.Drawing.Color.White
        Me.btnSaveThesis.HoverState.Parent = Me.btnSaveThesis
        Me.btnSaveThesis.Location = New System.Drawing.Point(401, 340)
        Me.btnSaveThesis.Name = "btnSaveThesis"
        Me.btnSaveThesis.ShadowDecoration.Parent = Me.btnSaveThesis
        Me.btnSaveThesis.Size = New System.Drawing.Size(87, 34)
        Me.btnSaveThesis.TabIndex = 3
        Me.btnSaveThesis.Text = "Save"
        '
        'Timer1
        '
        '
        'addThesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 394)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addThesis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addThesis"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSaveThesis As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbObjectives As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLimitation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbScope As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbTeam As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPanel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbMembers As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddThesisClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class
