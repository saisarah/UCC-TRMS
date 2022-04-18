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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.thesisPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnArchived = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvThesis = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlThesisDetails = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblObjectives = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.lblScope = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddThesis = New Guna.UI2.WinForms.Guna2Button()
        Me.cbCategories = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBJECTIVES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCOPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIMITATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEAMNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMBERS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PANEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2Panel1.SuspendLayout()
        Me.thesisPanel.SuspendLayout()
        CType(Me.dgvThesis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlThesisDetails.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
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
        Me.thesisPanel.Controls.Add(Me.btnArchived)
        Me.thesisPanel.Controls.Add(Me.dgvThesis)
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
        'dgvThesis
        '
        Me.dgvThesis.AllowUserToAddRows = False
        Me.dgvThesis.AllowUserToDeleteRows = False
        Me.dgvThesis.AllowUserToResizeColumns = False
        Me.dgvThesis.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvThesis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvThesis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvThesis.BackgroundColor = System.Drawing.Color.White
        Me.dgvThesis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvThesis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvThesis.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvThesis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvThesis.ColumnHeadersHeight = 50
        Me.dgvThesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvThesis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.title, Me.OBJECTIVES, Me.SCOPE, Me.LIMITATION, Me.TEAMNAME, Me.MEMBERS, Me.PANEL, Me.CATEGORY, Me.Edit, Me.Delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesis.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvThesis.EnableHeadersVisualStyles = False
        Me.dgvThesis.GridColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvThesis.Location = New System.Drawing.Point(384, 54)
        Me.dgvThesis.Name = "dgvThesis"
        Me.dgvThesis.ReadOnly = True
        Me.dgvThesis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesis.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvThesis.RowHeadersVisible = False
        Me.dgvThesis.RowHeadersWidth = 55
        Me.dgvThesis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvThesis.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvThesis.RowTemplate.Height = 30
        Me.dgvThesis.RowTemplate.ReadOnly = True
        Me.dgvThesis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvThesis.Size = New System.Drawing.Size(794, 468)
        Me.dgvThesis.TabIndex = 9
        Me.dgvThesis.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvThesis.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvThesis.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvThesis.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvThesis.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvThesis.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvThesis.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvThesis.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvThesis.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvThesis.ThemeStyle.ReadOnly = True
        Me.dgvThesis.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvThesis.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvThesis.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvThesis.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvThesis.ThemeStyle.RowsStyle.Height = 30
        Me.dgvThesis.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.dgvThesis.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'pnlThesisDetails
        '
        Me.pnlThesisDetails.BackColor = System.Drawing.Color.White
        Me.pnlThesisDetails.BorderColor = System.Drawing.Color.Gainsboro
        Me.pnlThesisDetails.BorderThickness = 1
        Me.pnlThesisDetails.Controls.Add(Me.lblTeam)
        Me.pnlThesisDetails.Controls.Add(Me.lblObjectives)
        Me.pnlThesisDetails.Controls.Add(Me.lblCategory)
        Me.pnlThesisDetails.Controls.Add(Me.lblLimit)
        Me.pnlThesisDetails.Controls.Add(Me.lblScope)
        Me.pnlThesisDetails.Controls.Add(Me.lblTitle)
        Me.pnlThesisDetails.Controls.Add(Me.Guna2Panel3)
        Me.pnlThesisDetails.Controls.Add(Me.Label7)
        Me.pnlThesisDetails.Controls.Add(Me.Label6)
        Me.pnlThesisDetails.Controls.Add(Me.Label5)
        Me.pnlThesisDetails.Controls.Add(Me.Label4)
        Me.pnlThesisDetails.Controls.Add(Me.Label3)
        Me.pnlThesisDetails.Controls.Add(Me.Label2)
        Me.pnlThesisDetails.Location = New System.Drawing.Point(12, 12)
        Me.pnlThesisDetails.Name = "pnlThesisDetails"
        Me.pnlThesisDetails.ShadowDecoration.Parent = Me.pnlThesisDetails
        Me.pnlThesisDetails.Size = New System.Drawing.Size(366, 467)
        Me.pnlThesisDetails.TabIndex = 5
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.ForeColor = System.Drawing.Color.Black
        Me.lblTeam.Location = New System.Drawing.Point(92, 276)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(0, 15)
        Me.lblTeam.TabIndex = 13
        '
        'lblObjectives
        '
        Me.lblObjectives.AutoSize = True
        Me.lblObjectives.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjectives.ForeColor = System.Drawing.Color.Black
        Me.lblObjectives.Location = New System.Drawing.Point(92, 328)
        Me.lblObjectives.Name = "lblObjectives"
        Me.lblObjectives.Size = New System.Drawing.Size(0, 15)
        Me.lblObjectives.TabIndex = 12
        Me.lblObjectives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Location = New System.Drawing.Point(92, 219)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(0, 15)
        Me.lblCategory.TabIndex = 11
        '
        'lblLimit
        '
        Me.lblLimit.AutoSize = True
        Me.lblLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimit.ForeColor = System.Drawing.Color.Black
        Me.lblLimit.Location = New System.Drawing.Point(92, 163)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(0, 15)
        Me.lblLimit.TabIndex = 10
        '
        'lblScope
        '
        Me.lblScope.AutoSize = True
        Me.lblScope.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScope.ForeColor = System.Drawing.Color.Black
        Me.lblScope.Location = New System.Drawing.Point(94, 113)
        Me.lblScope.Name = "lblScope"
        Me.lblScope.Size = New System.Drawing.Size(0, 15)
        Me.lblScope.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(94, 61)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 15)
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
        Me.Guna2Panel3.Size = New System.Drawing.Size(366, 36)
        Me.Guna2Panel3.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 5)
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
        Me.Label7.Location = New System.Drawing.Point(10, 276)
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
        Me.Label6.Location = New System.Drawing.Point(12, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Category:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(10, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Limitation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(12, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Scope:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(10, 328)
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
        Me.tbSearch.Location = New System.Drawing.Point(384, 12)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearch.PlaceholderText = ""
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.ShadowDecoration.Parent = Me.tbSearch
        Me.tbSearch.Size = New System.Drawing.Size(296, 36)
        Me.tbSearch.TabIndex = 7
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 103.4432!
        Me.id.HeaderText = "#"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'title
        '
        Me.title.DataPropertyName = "title"
        Me.title.FillWeight = 103.4432!
        Me.title.HeaderText = "TITLE"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        '
        'OBJECTIVES
        '
        Me.OBJECTIVES.DataPropertyName = "objectives"
        Me.OBJECTIVES.FillWeight = 103.4432!
        Me.OBJECTIVES.HeaderText = "OBJECTIVES"
        Me.OBJECTIVES.Name = "OBJECTIVES"
        Me.OBJECTIVES.ReadOnly = True
        '
        'SCOPE
        '
        Me.SCOPE.DataPropertyName = "scope"
        Me.SCOPE.FillWeight = 103.4432!
        Me.SCOPE.HeaderText = "SCOPE"
        Me.SCOPE.Name = "SCOPE"
        Me.SCOPE.ReadOnly = True
        '
        'LIMITATION
        '
        Me.LIMITATION.DataPropertyName = "limitations"
        Me.LIMITATION.FillWeight = 103.4432!
        Me.LIMITATION.HeaderText = "LIMITATION"
        Me.LIMITATION.Name = "LIMITATION"
        Me.LIMITATION.ReadOnly = True
        '
        'TEAMNAME
        '
        Me.TEAMNAME.DataPropertyName = "teamname"
        Me.TEAMNAME.FillWeight = 103.4432!
        Me.TEAMNAME.HeaderText = "TEAM NAME"
        Me.TEAMNAME.Name = "TEAMNAME"
        Me.TEAMNAME.ReadOnly = True
        '
        'MEMBERS
        '
        Me.MEMBERS.DataPropertyName = "members"
        Me.MEMBERS.FillWeight = 103.4432!
        Me.MEMBERS.HeaderText = "MEMBERS"
        Me.MEMBERS.Name = "MEMBERS"
        Me.MEMBERS.ReadOnly = True
        '
        'PANEL
        '
        Me.PANEL.DataPropertyName = "panels"
        Me.PANEL.FillWeight = 103.4432!
        Me.PANEL.HeaderText = "PANEL"
        Me.PANEL.Name = "PANEL"
        Me.PANEL.ReadOnly = True
        '
        'CATEGORY
        '
        Me.CATEGORY.DataPropertyName = "category"
        Me.CATEGORY.FillWeight = 103.4432!
        Me.CATEGORY.HeaderText = "CATEGORY"
        Me.CATEGORY.Name = "CATEGORY"
        Me.CATEGORY.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Edit.FillWeight = 85.25535!
        Me.Edit.HeaderText = ""
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Edit.Width = 36
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Delete.FillWeight = 85.25535!
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Delete.Width = 36
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
        CType(Me.dgvThesis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlThesisDetails.ResumeLayout(False)
        Me.pnlThesisDetails.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
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
    Friend WithEvents dgvThesis As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblLimit As Label
    Friend WithEvents lblScope As Label
    Friend WithEvents lblObjectives As Label
    Friend WithEvents btnArchived As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents OBJECTIVES As DataGridViewTextBoxColumn
    Friend WithEvents SCOPE As DataGridViewTextBoxColumn
    Friend WithEvents LIMITATION As DataGridViewTextBoxColumn
    Friend WithEvents TEAMNAME As DataGridViewTextBoxColumn
    Friend WithEvents MEMBERS As DataGridViewTextBoxColumn
    Friend WithEvents PANEL As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORY As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
