<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentArchive
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentArchive))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvStudentArchived = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnStudentArchivedClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgvStudentArchived, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel2.Controls.Add(Me.dgvStudentArchived)
        Me.Guna2Panel2.Controls.Add(Me.btnStudentArchivedClose)
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
        'dgvStudentArchived
        '
        Me.dgvStudentArchived.AllowUserToAddRows = False
        Me.dgvStudentArchived.AllowUserToDeleteRows = False
        Me.dgvStudentArchived.AllowUserToResizeColumns = False
        Me.dgvStudentArchived.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentArchived.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudentArchived.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudentArchived.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStudentArchived.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudentArchived.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStudentArchived.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStudentArchived.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvStudentArchived.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentArchived.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudentArchived.ColumnHeadersHeight = 50
        Me.dgvStudentArchived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStudentArchived.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fullname, Me.studentno, Me.course, Me.year, Me.section, Me.contact, Me.email})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentArchived.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudentArchived.EnableHeadersVisualStyles = False
        Me.dgvStudentArchived.GridColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvStudentArchived.Location = New System.Drawing.Point(16, 69)
        Me.dgvStudentArchived.Name = "dgvStudentArchived"
        Me.dgvStudentArchived.ReadOnly = True
        Me.dgvStudentArchived.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentArchived.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStudentArchived.RowHeadersVisible = False
        Me.dgvStudentArchived.RowHeadersWidth = 55
        Me.dgvStudentArchived.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvStudentArchived.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStudentArchived.RowTemplate.Height = 30
        Me.dgvStudentArchived.RowTemplate.ReadOnly = True
        Me.dgvStudentArchived.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudentArchived.Size = New System.Drawing.Size(790, 359)
        Me.dgvStudentArchived.TabIndex = 17
        Me.dgvStudentArchived.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower
        Me.dgvStudentArchived.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.dgvStudentArchived.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvStudentArchived.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvStudentArchived.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvStudentArchived.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvStudentArchived.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvStudentArchived.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvStudentArchived.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvStudentArchived.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStudentArchived.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvStudentArchived.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStudentArchived.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStudentArchived.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvStudentArchived.ThemeStyle.ReadOnly = True
        Me.dgvStudentArchived.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvStudentArchived.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStudentArchived.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvStudentArchived.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStudentArchived.ThemeStyle.RowsStyle.Height = 30
        Me.dgvStudentArchived.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.dgvStudentArchived.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 103.4432!
        Me.id.HeaderText = "#"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'fullname
        '
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.FillWeight = 103.4432!
        Me.fullname.HeaderText = "NAME"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        '
        'studentno
        '
        Me.studentno.DataPropertyName = "studentno"
        Me.studentno.FillWeight = 103.4432!
        Me.studentno.HeaderText = "STUDENT NUMBER"
        Me.studentno.Name = "studentno"
        Me.studentno.ReadOnly = True
        '
        'course
        '
        Me.course.DataPropertyName = "course"
        Me.course.FillWeight = 103.4432!
        Me.course.HeaderText = "COURSE"
        Me.course.Name = "course"
        Me.course.ReadOnly = True
        '
        'year
        '
        Me.year.DataPropertyName = "year"
        Me.year.FillWeight = 103.4432!
        Me.year.HeaderText = "YEAR"
        Me.year.Name = "year"
        Me.year.ReadOnly = True
        '
        'section
        '
        Me.section.DataPropertyName = "section"
        Me.section.FillWeight = 103.4432!
        Me.section.HeaderText = "SECTION"
        Me.section.Name = "section"
        Me.section.ReadOnly = True
        '
        'contact
        '
        Me.contact.DataPropertyName = "contact"
        Me.contact.FillWeight = 103.4432!
        Me.contact.HeaderText = "CONTACT NUMBER"
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.FillWeight = 103.4432!
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'btnStudentArchivedClose
        '
        Me.btnStudentArchivedClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudentArchivedClose.CheckedState.Parent = Me.btnStudentArchivedClose
        Me.btnStudentArchivedClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentArchivedClose.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnStudentArchivedClose.HoverState.Parent = Me.btnStudentArchivedClose
        Me.btnStudentArchivedClose.Image = CType(resources.GetObject("btnStudentArchivedClose.Image"), System.Drawing.Image)
        Me.btnStudentArchivedClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnStudentArchivedClose.Location = New System.Drawing.Point(777, 3)
        Me.btnStudentArchivedClose.Name = "btnStudentArchivedClose"
        Me.btnStudentArchivedClose.PressedState.Parent = Me.btnStudentArchivedClose
        Me.btnStudentArchivedClose.Size = New System.Drawing.Size(43, 27)
        Me.btnStudentArchivedClose.TabIndex = 13
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(823, 10)
        Me.Guna2Panel1.TabIndex = 16
        '
        'studentArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 489)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "studentArchive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "studentArchive"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.dgvStudentArchived, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvStudentArchived As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnStudentArchivedClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents studentno As DataGridViewTextBoxColumn
    Friend WithEvents course As DataGridViewTextBoxColumn
    Friend WithEvents year As DataGridViewTextBoxColumn
    Friend WithEvents section As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
