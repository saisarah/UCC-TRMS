<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class thesis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(thesis))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.thesisPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Objectives = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Scope = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Limitation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnArchived = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlThesisDetails = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblObjectives = New System.Windows.Forms.Label()
        Me.lblScope = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddThesis = New Guna.UI2.WinForms.Guna2Button()
        Me.cbCategories = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2Panel1.SuspendLayout()
        Me.thesisPanel.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.pnlThesisDetails.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.Guna2Panel1.Controls.Add(Me.thesisPanel)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1190, 578)
        Me.Guna2Panel1.TabIndex = 2
        '
        'thesisPanel
        '
        Me.thesisPanel.Controls.Add(Me.Guna2ShadowPanel1)
        Me.thesisPanel.Controls.Add(Me.btnArchived)
        Me.thesisPanel.Controls.Add(Me.pnlThesisDetails)
        Me.thesisPanel.Controls.Add(Me.btnAddThesis)
        Me.thesisPanel.Controls.Add(Me.cbCategories)
        Me.thesisPanel.Controls.Add(Me.tbSearch)
        Me.thesisPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thesisPanel.Location = New System.Drawing.Point(0, 0)
        Me.thesisPanel.Name = "thesisPanel"
        Me.thesisPanel.ShadowDecoration.Parent = Me.thesisPanel
        Me.thesisPanel.Size = New System.Drawing.Size(1190, 578)
        Me.thesisPanel.TabIndex = 9
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.ListView1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(432, 54)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 40
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(746, 387)
        Me.Guna2ShadowPanel1.TabIndex = 11
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Code, Me.Title, Me.Objectives, Me.Scope, Me.Limitation, Me.Category})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(5, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.OwnerDraw = True
        Me.ListView1.Size = New System.Drawing.Size(736, 377)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 12
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Code
        '
        Me.Code.Text = "Code"
        Me.Code.Width = 150
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 275
        '
        'Objectives
        '
        Me.Objectives.Text = "Objectives"
        Me.Objectives.Width = 250
        '
        'Scope
        '
        Me.Scope.Text = "Scope"
        Me.Scope.Width = 200
        '
        'Limitation
        '
        Me.Limitation.Text = "Limitation"
        Me.Limitation.Width = 200
        '
        'Category
        '
        Me.Category.Text = "Category"
        Me.Category.Width = 200
        '
        'btnArchived
        '
        Me.btnArchived.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArchived.BorderRadius = 5
        Me.btnArchived.CheckedState.Parent = Me.btnArchived
        Me.btnArchived.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArchived.CustomImages.Parent = Me.btnArchived
        Me.btnArchived.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnArchived.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchived.ForeColor = System.Drawing.Color.White
        Me.btnArchived.HoverState.Parent = Me.btnArchived
        Me.btnArchived.Image = CType(resources.GetObject("btnArchived.Image"), System.Drawing.Image)
        Me.btnArchived.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnArchived.Location = New System.Drawing.Point(948, 12)
        Me.btnArchived.Name = "btnArchived"
        Me.btnArchived.ShadowDecoration.Parent = Me.btnArchived
        Me.btnArchived.Size = New System.Drawing.Size(112, 36)
        Me.btnArchived.TabIndex = 10
        Me.btnArchived.Text = "Archived"
        '
        'pnlThesisDetails
        '
        Me.pnlThesisDetails.BackColor = System.Drawing.Color.White
        Me.pnlThesisDetails.BorderColor = System.Drawing.Color.Gainsboro
        Me.pnlThesisDetails.BorderThickness = 1
        Me.pnlThesisDetails.Controls.Add(Me.lblObjectives)
        Me.pnlThesisDetails.Controls.Add(Me.lblScope)
        Me.pnlThesisDetails.Controls.Add(Me.Label4)
        Me.pnlThesisDetails.Controls.Add(Me.lblTeam)
        Me.pnlThesisDetails.Controls.Add(Me.Label5)
        Me.pnlThesisDetails.Controls.Add(Me.lblLimit)
        Me.pnlThesisDetails.Controls.Add(Me.lblCategory)
        Me.pnlThesisDetails.Controls.Add(Me.lblTitle)
        Me.pnlThesisDetails.Controls.Add(Me.Guna2Panel3)
        Me.pnlThesisDetails.Controls.Add(Me.Label7)
        Me.pnlThesisDetails.Controls.Add(Me.Label6)
        Me.pnlThesisDetails.Controls.Add(Me.Label3)
        Me.pnlThesisDetails.Controls.Add(Me.Label2)
        Me.pnlThesisDetails.Location = New System.Drawing.Point(12, 12)
        Me.pnlThesisDetails.Name = "pnlThesisDetails"
        Me.pnlThesisDetails.ShadowDecoration.Parent = Me.pnlThesisDetails
        Me.pnlThesisDetails.Size = New System.Drawing.Size(414, 554)
        Me.pnlThesisDetails.TabIndex = 5
        '
        'lblObjectives
        '
        Me.lblObjectives.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjectives.ForeColor = System.Drawing.Color.Black
        Me.lblObjectives.Location = New System.Drawing.Point(97, 344)
        Me.lblObjectives.Name = "lblObjectives"
        Me.lblObjectives.Size = New System.Drawing.Size(302, 201)
        Me.lblObjectives.TabIndex = 14
        '
        'lblScope
        '
        Me.lblScope.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScope.ForeColor = System.Drawing.Color.Black
        Me.lblScope.Location = New System.Drawing.Point(100, 164)
        Me.lblScope.Name = "lblScope"
        Me.lblScope.Size = New System.Drawing.Size(302, 82)
        Me.lblScope.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(12, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Scope:"
        '
        'lblTeam
        '
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.ForeColor = System.Drawing.Color.Black
        Me.lblTeam.Location = New System.Drawing.Point(97, 131)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(305, 21)
        Me.lblTeam.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(12, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Limitation:"
        '
        'lblLimit
        '
        Me.lblLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimit.ForeColor = System.Drawing.Color.Black
        Me.lblLimit.Location = New System.Drawing.Point(100, 248)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(302, 82)
        Me.lblLimit.TabIndex = 10
        '
        'lblCategory
        '
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Location = New System.Drawing.Point(97, 99)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(309, 16)
        Me.lblCategory.TabIndex = 11
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(97, 61)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(302, 24)
        Me.lblTitle.TabIndex = 8
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Silver
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(414, 36)
        Me.Guna2Panel3.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Thesis Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(12, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Team Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(12, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(12, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Objectives:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Title:"
        '
        'btnAddThesis
        '
        Me.btnAddThesis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddThesis.BorderRadius = 5
        Me.btnAddThesis.CheckedState.Parent = Me.btnAddThesis
        Me.btnAddThesis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddThesis.CustomImages.Parent = Me.btnAddThesis
        Me.btnAddThesis.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnAddThesis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddThesis.ForeColor = System.Drawing.Color.White
        Me.btnAddThesis.HoverState.Parent = Me.btnAddThesis
        Me.btnAddThesis.Image = CType(resources.GetObject("btnAddThesis.Image"), System.Drawing.Image)
        Me.btnAddThesis.Location = New System.Drawing.Point(1066, 12)
        Me.btnAddThesis.Name = "btnAddThesis"
        Me.btnAddThesis.ShadowDecoration.Parent = Me.btnAddThesis
        Me.btnAddThesis.Size = New System.Drawing.Size(112, 36)
        Me.btnAddThesis.TabIndex = 2
        Me.btnAddThesis.Text = "Add Thesis"
        '
        'cbCategories
        '
        Me.cbCategories.BackColor = System.Drawing.Color.Transparent
        Me.cbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategories.FocusedColor = System.Drawing.Color.Empty
        Me.cbCategories.FocusedState.Parent = Me.cbCategories
        Me.cbCategories.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCategories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCategories.FormattingEnabled = True
        Me.cbCategories.HoverState.Parent = Me.cbCategories
        Me.cbCategories.ItemHeight = 30
        Me.cbCategories.Items.AddRange(New Object() {"WEB DEVELOPMENT", "APPLICATION DEVELOPMENT", "MOBILE DEVELOPMENT", "GAME DEVELOPMENT"})
        Me.cbCategories.ItemsAppearance.Parent = Me.cbCategories
        Me.cbCategories.Location = New System.Drawing.Point(686, 12)
        Me.cbCategories.Name = "cbCategories"
        Me.cbCategories.ShadowDecoration.Parent = Me.cbCategories
        Me.cbCategories.Size = New System.Drawing.Size(256, 36)
        Me.cbCategories.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbCategories.TabIndex = 8
        '
        'tbSearch
        '
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearch.DefaultText = ""
        Me.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.DisabledState.Parent = Me.tbSearch
        Me.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.tbSearch.FocusedState.Parent = Me.tbSearch
        Me.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbSearch.HoverState.Parent = Me.tbSearch
        Me.tbSearch.IconRight = CType(resources.GetObject("tbSearch.IconRight"), System.Drawing.Image)
        Me.tbSearch.Location = New System.Drawing.Point(432, 12)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearch.PlaceholderText = "Search"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.ShadowDecoration.Parent = Me.tbSearch
        Me.tbSearch.Size = New System.Drawing.Size(248, 36)
        Me.tbSearch.TabIndex = 7
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.FillWeight = 85.25535!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.Width = 36
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.FillWeight = 85.25535!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.Width = 36
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'thesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 578)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "thesis"
        Me.Text = "thesis"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.thesisPanel.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.pnlThesisDetails.ResumeLayout(False)
        Me.pnlThesisDetails.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddThesis As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlThesisDetails As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbCategories As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents thesisPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblLimit As Label
    Friend WithEvents lblScope As Label
    Friend WithEvents btnArchived As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Public WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Public WithEvents ListView1 As ListView
    Friend WithEvents Code As ColumnHeader
    Friend WithEvents Scope As ColumnHeader
    Friend WithEvents Limitation As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents lblObjectives As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Objectives As ColumnHeader
End Class
