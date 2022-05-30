<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class issuing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(issuing))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbSearchStudNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCN = New System.Windows.Forms.Label()
        Me.lblEm = New System.Windows.Forms.Label()
        Me.lblCYS = New System.Windows.Forms.Label()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearchStud = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Objectives = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Scope = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Limitation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbSearchThesis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbHoS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnProcess = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 3
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.tbSearchStudNo)
        Me.Guna2Panel2.Controls.Add(Me.lblCN)
        Me.Guna2Panel2.Controls.Add(Me.lblEm)
        Me.Guna2Panel2.Controls.Add(Me.lblCYS)
        Me.Guna2Panel2.Controls.Add(Me.lblFN)
        Me.Guna2Panel2.Controls.Add(Me.lblSN)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.btnSearchStud)
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(863, 199)
        Me.Guna2Panel2.TabIndex = 5
        '
        'tbSearchStudNo
        '
        Me.tbSearchStudNo.BackColor = System.Drawing.Color.Transparent
        Me.tbSearchStudNo.BorderColor = System.Drawing.Color.Silver
        Me.tbSearchStudNo.BorderRadius = 2
        Me.tbSearchStudNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearchStudNo.DefaultText = ""
        Me.tbSearchStudNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearchStudNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearchStudNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearchStudNo.DisabledState.Parent = Me.tbSearchStudNo
        Me.tbSearchStudNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearchStudNo.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbSearchStudNo.FocusedState.Parent = Me.tbSearchStudNo
        Me.tbSearchStudNo.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbSearchStudNo.HoverState.Parent = Me.tbSearchStudNo
        Me.tbSearchStudNo.Location = New System.Drawing.Point(16, 8)
        Me.tbSearchStudNo.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.tbSearchStudNo.Name = "tbSearchStudNo"
        Me.tbSearchStudNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearchStudNo.PlaceholderText = "Student Number"
        Me.tbSearchStudNo.SelectedText = ""
        Me.tbSearchStudNo.ShadowDecoration.Parent = Me.tbSearchStudNo
        Me.tbSearchStudNo.Size = New System.Drawing.Size(434, 32)
        Me.tbSearchStudNo.TabIndex = 19
        '
        'lblCN
        '
        Me.lblCN.AutoSize = True
        Me.lblCN.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCN.Location = New System.Drawing.Point(138, 159)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(0, 19)
        Me.lblCN.TabIndex = 18
        '
        'lblEm
        '
        Me.lblEm.AutoSize = True
        Me.lblEm.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEm.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEm.Location = New System.Drawing.Point(138, 134)
        Me.lblEm.Name = "lblEm"
        Me.lblEm.Size = New System.Drawing.Size(0, 19)
        Me.lblEm.TabIndex = 17
        '
        'lblCYS
        '
        Me.lblCYS.AutoSize = True
        Me.lblCYS.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCYS.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCYS.Location = New System.Drawing.Point(138, 109)
        Me.lblCYS.Name = "lblCYS"
        Me.lblCYS.Size = New System.Drawing.Size(0, 19)
        Me.lblCYS.TabIndex = 16
        '
        'lblFN
        '
        Me.lblFN.AutoSize = True
        Me.lblFN.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFN.Location = New System.Drawing.Point(138, 84)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(0, 19)
        Me.lblFN.TabIndex = 15
        '
        'lblSN
        '
        Me.lblSN.AutoSize = True
        Me.lblSN.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSN.Location = New System.Drawing.Point(138, 57)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Size = New System.Drawing.Size(0, 19)
        Me.lblSN.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(21, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Contact No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(21, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(21, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Course/Yr/Section:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(21, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(21, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Student Number:"
        '
        'btnSearchStud
        '
        Me.btnSearchStud.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchStud.BorderRadius = 2
        Me.btnSearchStud.CheckedState.Parent = Me.btnSearchStud
        Me.btnSearchStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchStud.CustomImages.Parent = Me.btnSearchStud
        Me.btnSearchStud.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSearchStud.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchStud.ForeColor = System.Drawing.Color.White
        Me.btnSearchStud.HoverState.Parent = Me.btnSearchStud
        Me.btnSearchStud.Location = New System.Drawing.Point(459, 8)
        Me.btnSearchStud.Name = "btnSearchStud"
        Me.btnSearchStud.ShadowDecoration.Parent = Me.btnSearchStud
        Me.btnSearchStud.Size = New System.Drawing.Size(97, 32)
        Me.btnSearchStud.TabIndex = 8
        Me.btnSearchStud.Text = "Search"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel7.BackColor = System.Drawing.Color.White
        Me.Guna2Panel7.Controls.Add(Me.ListView1)
        Me.Guna2Panel7.Controls.Add(Me.cbCategory)
        Me.Guna2Panel7.Controls.Add(Me.tbSearchThesis)
        Me.Guna2Panel7.Location = New System.Drawing.Point(14, 226)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(863, 245)
        Me.Guna2Panel7.TabIndex = 15
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Code, Me.Title, Me.Objectives, Me.Scope, Me.Limitation, Me.Category})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 59)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.OwnerDraw = True
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(833, 277)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Code
        '
        Me.Code.Text = "CODE"
        Me.Code.Width = 150
        '
        'Title
        '
        Me.Title.Text = "TITLE"
        Me.Title.Width = 275
        '
        'Objectives
        '
        Me.Objectives.Text = "OBJECTIVES"
        Me.Objectives.Width = 250
        '
        'Scope
        '
        Me.Scope.Text = "SCOPE"
        Me.Scope.Width = 200
        '
        'Limitation
        '
        Me.Limitation.Text = "LIMITATION"
        Me.Limitation.Width = 200
        '
        'Category
        '
        Me.Category.Text = "CATEGORY"
        Me.Category.Width = 200
        '
        'cbCategory
        '
        Me.cbCategory.BackColor = System.Drawing.Color.Transparent
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
        Me.cbCategory.Location = New System.Drawing.Point(360, 11)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.ShadowDecoration.Parent = Me.cbCategory
        Me.cbCategory.Size = New System.Drawing.Size(254, 36)
        Me.cbCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbCategory.TabIndex = 14
        '
        'tbSearchThesis
        '
        Me.tbSearchThesis.BackColor = System.Drawing.Color.Transparent
        Me.tbSearchThesis.BorderColor = System.Drawing.Color.Silver
        Me.tbSearchThesis.BorderRadius = 2
        Me.tbSearchThesis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearchThesis.DefaultText = ""
        Me.tbSearchThesis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearchThesis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearchThesis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearchThesis.DisabledState.Parent = Me.tbSearchThesis
        Me.tbSearchThesis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearchThesis.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbSearchThesis.FocusedState.Parent = Me.tbSearchThesis
        Me.tbSearchThesis.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbSearchThesis.HoverState.Parent = Me.tbSearchThesis
        Me.tbSearchThesis.IconRight = CType(resources.GetObject("tbSearchThesis.IconRight"), System.Drawing.Image)
        Me.tbSearchThesis.Location = New System.Drawing.Point(16, 12)
        Me.tbSearchThesis.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.tbSearchThesis.Name = "tbSearchThesis"
        Me.tbSearchThesis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearchThesis.PlaceholderText = "Search"
        Me.tbSearchThesis.SelectedText = ""
        Me.tbSearchThesis.ShadowDecoration.Parent = Me.tbSearchThesis
        Me.tbSearchThesis.Size = New System.Drawing.Size(335, 36)
        Me.tbSearchThesis.TabIndex = 15
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2DateTimePicker1.BorderRadius = 10
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(981, 445)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(199, 36)
        Me.Guna2DateTimePicker1.TabIndex = 16
        Me.Guna2DateTimePicker1.Value = New Date(2022, 3, 9, 17, 56, 30, 651)
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(1101, 422)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 19)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Issue Date"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.Controls.Add(Me.cbHoS)
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Controls.Add(Me.btnProcess)
        Me.Guna2Panel1.Controls.Add(Me.Label15)
        Me.Guna2Panel1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1190, 578)
        Me.Guna2Panel1.TabIndex = 4
        '
        'cbHoS
        '
        Me.cbHoS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbHoS.BackColor = System.Drawing.Color.Transparent
        Me.cbHoS.BorderRadius = 10
        Me.cbHoS.BorderThickness = 0
        Me.cbHoS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbHoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHoS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbHoS.FocusedColor = System.Drawing.Color.Empty
        Me.cbHoS.FocusedState.Parent = Me.cbHoS
        Me.cbHoS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbHoS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbHoS.FormattingEnabled = True
        Me.cbHoS.HoverState.Parent = Me.cbHoS
        Me.cbHoS.ItemHeight = 30
        Me.cbHoS.Items.AddRange(New Object() {"HARD COPY", "SOFT COPY"})
        Me.cbHoS.ItemsAppearance.Parent = Me.cbHoS
        Me.cbHoS.Location = New System.Drawing.Point(975, 487)
        Me.cbHoS.Name = "cbHoS"
        Me.cbHoS.ShadowDecoration.Parent = Me.cbHoS
        Me.cbHoS.Size = New System.Drawing.Size(205, 36)
        Me.cbHoS.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbHoS.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Panel1.Controls.Add(Me.Guna2Panel6)
        Me.Panel1.Location = New System.Drawing.Point(883, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 299)
        Me.Panel1.TabIndex = 21
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.Label9)
        Me.Guna2Panel4.Controls.Add(Me.Label7)
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
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(2, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "CLEARED PAYMENT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(38, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 85)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.Label10)
        Me.Guna2Panel3.Location = New System.Drawing.Point(6, 152)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PENDING PAYMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(41, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 85)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "0"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Panel5.Controls.Add(Me.Label11)
        Me.Guna2Panel5.Controls.Add(Me.Label12)
        Me.Guna2Panel5.Location = New System.Drawing.Point(151, 6)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel5.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(10, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 35)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "BORROWED"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(38, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 85)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "0"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guna2Panel6.Controls.Add(Me.Label14)
        Me.Guna2Panel6.Controls.Add(Me.Label16)
        Me.Guna2Panel6.Location = New System.Drawing.Point(6, 6)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel6.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(21, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 35)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "OVERDUE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(41, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 85)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "0"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProcess
        '
        Me.btnProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcess.BackColor = System.Drawing.Color.Transparent
        Me.btnProcess.BorderRadius = 15
        Me.btnProcess.CheckedState.Parent = Me.btnProcess
        Me.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcess.CustomImages.Parent = Me.btnProcess
        Me.btnProcess.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnProcess.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.btnProcess.ForeColor = System.Drawing.Color.White
        Me.btnProcess.HoverState.Parent = Me.btnProcess
        Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
        Me.btnProcess.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnProcess.Location = New System.Drawing.Point(1073, 529)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.ShadowDecoration.Parent = Me.btnProcess
        Me.btnProcess.Size = New System.Drawing.Size(110, 37)
        Me.btnProcess.TabIndex = 20
        Me.btnProcess.Text = "Process"
        '
        'issuing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "issuing"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnProcess As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbSearchThesis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearchStud As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblCN As Label
    Friend WithEvents lblEm As Label
    Friend WithEvents lblCYS As Label
    Friend WithEvents lblFN As Label
    Friend WithEvents lblSN As Label
    Friend WithEvents tbSearchStudNo As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents ListView1 As ListView
    Friend WithEvents Code As ColumnHeader
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Objectives As ColumnHeader
    Friend WithEvents Scope As ColumnHeader
    Friend WithEvents Limitation As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents cbHoS As Guna.UI2.WinForms.Guna2ComboBox
End Class
