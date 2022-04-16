<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class thesisArchived
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(thesisArchived))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvThesisArchived = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBJECTIVES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCOPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIMITATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEAMNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMBERS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PANEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnArchivedClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgvThesisArchived, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(823, 10)
        Me.Guna2Panel1.TabIndex = 14
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel2.Controls.Add(Me.dgvThesisArchived)
        Me.Guna2Panel2.Controls.Add(Me.btnArchivedClose)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 10)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(823, 479)
        Me.Guna2Panel2.TabIndex = 15
        '
        'dgvThesisArchived
        '
        Me.dgvThesisArchived.AllowUserToAddRows = False
        Me.dgvThesisArchived.AllowUserToDeleteRows = False
        Me.dgvThesisArchived.AllowUserToResizeColumns = False
        Me.dgvThesisArchived.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesisArchived.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvThesisArchived.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvThesisArchived.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvThesisArchived.BackgroundColor = System.Drawing.Color.White
        Me.dgvThesisArchived.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvThesisArchived.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvThesisArchived.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvThesisArchived.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesisArchived.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvThesisArchived.ColumnHeadersHeight = 50
        Me.dgvThesisArchived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvThesisArchived.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.title, Me.OBJECTIVES, Me.SCOPE, Me.LIMITATION, Me.TEAMNAME, Me.MEMBERS, Me.PANEL, Me.CATEGORY})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesisArchived.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvThesisArchived.EnableHeadersVisualStyles = False
        Me.dgvThesisArchived.GridColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvThesisArchived.Location = New System.Drawing.Point(28, 69)
        Me.dgvThesisArchived.Name = "dgvThesisArchived"
        Me.dgvThesisArchived.ReadOnly = True
        Me.dgvThesisArchived.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThesisArchived.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvThesisArchived.RowHeadersVisible = False
        Me.dgvThesisArchived.RowHeadersWidth = 55
        Me.dgvThesisArchived.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvThesisArchived.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvThesisArchived.RowTemplate.Height = 30
        Me.dgvThesisArchived.RowTemplate.ReadOnly = True
        Me.dgvThesisArchived.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvThesisArchived.Size = New System.Drawing.Size(771, 383)
        Me.dgvThesisArchived.TabIndex = 17
        Me.dgvThesisArchived.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower
        Me.dgvThesisArchived.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvThesisArchived.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvThesisArchived.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvThesisArchived.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvThesisArchived.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvThesisArchived.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvThesisArchived.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvThesisArchived.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvThesisArchived.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvThesisArchived.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvThesisArchived.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvThesisArchived.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvThesisArchived.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvThesisArchived.ThemeStyle.ReadOnly = True
        Me.dgvThesisArchived.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvThesisArchived.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvThesisArchived.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvThesisArchived.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvThesisArchived.ThemeStyle.RowsStyle.Height = 30
        Me.dgvThesisArchived.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.dgvThesisArchived.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        'btnArchivedClose
        '
        Me.btnArchivedClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArchivedClose.CheckedState.Parent = Me.btnArchivedClose
        Me.btnArchivedClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArchivedClose.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnArchivedClose.HoverState.Parent = Me.btnArchivedClose
        Me.btnArchivedClose.Image = CType(resources.GetObject("btnArchivedClose.Image"), System.Drawing.Image)
        Me.btnArchivedClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnArchivedClose.Location = New System.Drawing.Point(777, 3)
        Me.btnArchivedClose.Name = "btnArchivedClose"
        Me.btnArchivedClose.PressedState.Parent = Me.btnArchivedClose
        Me.btnArchivedClose.Size = New System.Drawing.Size(43, 27)
        Me.btnArchivedClose.TabIndex = 13
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Gray
        Me.Guna2Panel3.Location = New System.Drawing.Point(16, 62)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(790, 1)
        Me.Guna2Panel3.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Archived"
        '
        'thesisArchived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(823, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "thesisArchived"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "thesisArchived"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.dgvThesisArchived, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnArchivedClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvThesisArchived As Guna.UI2.WinForms.Guna2DataGridView
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
