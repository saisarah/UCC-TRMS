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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.thesisPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvThesis = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlThesisDetails = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddThesis = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBJECTIVES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCOPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIMITATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEAMNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMBERS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PANEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(891, 578)
        Me.Guna2Panel1.TabIndex = 2
        '
        'thesisPanel
        '
        Me.thesisPanel.Controls.Add(Me.dgvThesis)
        Me.thesisPanel.Controls.Add(Me.pnlThesisDetails)
        Me.thesisPanel.Controls.Add(Me.btnAddThesis)
        Me.thesisPanel.Controls.Add(Me.Guna2ComboBox1)
        Me.thesisPanel.Controls.Add(Me.Guna2TextBox1)
        Me.thesisPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.thesisPanel.Location = New System.Drawing.Point(0, 0)
        Me.thesisPanel.Name = "thesisPanel"
        Me.thesisPanel.ShadowDecoration.Parent = Me.thesisPanel
        Me.thesisPanel.Size = New System.Drawing.Size(891, 578)
        Me.thesisPanel.TabIndex = 9
        '
        'dgvThesis
        '
        Me.dgvThesis.AllowUserToAddRows = False
        Me.dgvThesis.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvThesis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvThesis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvThesis.BackgroundColor = System.Drawing.Color.White
        Me.dgvThesis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvThesis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvThesis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvThesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThesis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.title, Me.OBJECTIVES, Me.SCOPE, Me.LIMITATION, Me.TEAMNAME, Me.MEMBERS, Me.PANEL, Me.CATEGORY})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvThesis.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvThesis.EnableHeadersVisualStyles = False
        Me.dgvThesis.GridColor = System.Drawing.Color.Gray
        Me.dgvThesis.Location = New System.Drawing.Point(384, 54)
        Me.dgvThesis.Name = "dgvThesis"
        Me.dgvThesis.RowHeadersVisible = False
        Me.dgvThesis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvThesis.Size = New System.Drawing.Size(495, 468)
        Me.dgvThesis.TabIndex = 9
        Me.dgvThesis.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvThesis.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvThesis.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvThesis.ThemeStyle.GridColor = System.Drawing.Color.Gray
        Me.dgvThesis.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvThesis.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvThesis.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvThesis.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvThesis.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThesis.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvThesis.ThemeStyle.ReadOnly = False
        Me.dgvThesis.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvThesis.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvThesis.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvThesis.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvThesis.ThemeStyle.RowsStyle.Height = 22
        Me.dgvThesis.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvThesis.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnlThesisDetails
        '
        Me.pnlThesisDetails.BackColor = System.Drawing.Color.White
        Me.pnlThesisDetails.BorderColor = System.Drawing.Color.Gainsboro
        Me.pnlThesisDetails.BorderThickness = 1
        Me.pnlThesisDetails.Controls.Add(Me.Label14)
        Me.pnlThesisDetails.Controls.Add(Me.Label13)
        Me.pnlThesisDetails.Controls.Add(Me.Label12)
        Me.pnlThesisDetails.Controls.Add(Me.Label11)
        Me.pnlThesisDetails.Controls.Add(Me.Label10)
        Me.pnlThesisDetails.Controls.Add(Me.Label9)
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(107, 401)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 21)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Lorem Ipsum"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(107, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 147)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Lorem ipsum dolor sit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "amet, consectetur " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "adipiscing elit, sed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "do eiusmod tem" &
    "por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "incididunt ut labore " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "et dolore magna " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aliqua."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(107, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Lorem Ipsum"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(107, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Lorem Ipsum"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(107, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Lorem Ipsum"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(107, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Lorem Ipsum"
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
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Thesis Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(12, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Team Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(12, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Category:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(12, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Limitation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Scope:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(12, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Objectives:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 21)
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
        Me.btnAddThesis.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddThesis.ForeColor = System.Drawing.Color.White
        Me.btnAddThesis.HoverState.Parent = Me.btnAddThesis
        Me.btnAddThesis.Location = New System.Drawing.Point(791, 12)
        Me.btnAddThesis.Name = "btnAddThesis"
        Me.btnAddThesis.ShadowDecoration.Parent = Me.btnAddThesis
        Me.btnAddThesis.Size = New System.Drawing.Size(88, 36)
        Me.btnAddThesis.TabIndex = 2
        Me.btnAddThesis.Text = "Add Thesis"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.Guna2ComboBox1.FocusedState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.FormattingEnabled = True
        Me.Guna2ComboBox1.HoverState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.ItemsAppearance.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(618, 12)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.ShadowDecoration.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(167, 36)
        Me.Guna2ComboBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2ComboBox1.TabIndex = 8
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(384, 12)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(228, 36)
        Me.Guna2TextBox1.TabIndex = 7
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "#"
        Me.id.Name = "id"
        '
        'title
        '
        Me.title.DataPropertyName = "title"
        Me.title.HeaderText = "TITLE"
        Me.title.Name = "title"
        '
        'OBJECTIVES
        '
        Me.OBJECTIVES.DataPropertyName = "objectives"
        Me.OBJECTIVES.HeaderText = "OBJECTIVES"
        Me.OBJECTIVES.Name = "OBJECTIVES"
        '
        'SCOPE
        '
        Me.SCOPE.DataPropertyName = "scope"
        Me.SCOPE.HeaderText = "SCOPE"
        Me.SCOPE.Name = "SCOPE"
        '
        'LIMITATION
        '
        Me.LIMITATION.DataPropertyName = "limitations"
        Me.LIMITATION.HeaderText = "LIMITATION"
        Me.LIMITATION.Name = "LIMITATION"
        '
        'TEAMNAME
        '
        Me.TEAMNAME.DataPropertyName = "teamname"
        Me.TEAMNAME.HeaderText = "TEAM NAME"
        Me.TEAMNAME.Name = "TEAMNAME"
        '
        'MEMBERS
        '
        Me.MEMBERS.DataPropertyName = "members"
        Me.MEMBERS.HeaderText = "MEMBERS"
        Me.MEMBERS.Name = "MEMBERS"
        '
        'PANEL
        '
        Me.PANEL.DataPropertyName = "panels"
        Me.PANEL.HeaderText = "PANEL"
        Me.PANEL.Name = "PANEL"
        '
        'CATEGORY
        '
        Me.CATEGORY.DataPropertyName = "category"
        Me.CATEGORY.HeaderText = "CATEGORY"
        Me.CATEGORY.Name = "CATEGORY"
        '
        'thesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 578)
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
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents thesisPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvThesis As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents OBJECTIVES As DataGridViewTextBoxColumn
    Friend WithEvents SCOPE As DataGridViewTextBoxColumn
    Friend WithEvents LIMITATION As DataGridViewTextBoxColumn
    Friend WithEvents TEAMNAME As DataGridViewTextBoxColumn
    Friend WithEvents MEMBERS As DataGridViewTextBoxColumn
    Friend WithEvents PANEL As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORY As DataGridViewTextBoxColumn
End Class
